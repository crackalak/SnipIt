using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SnipIt
{
    public partial class MainForm : Form
    {
        #region variables

        private bool autoClear;
        private bool debugMode;

        enum drawEnum
        {
            Line,
            Rect,
            Ellipse
        }

        private Point lastImagePrintPos;
        private Point? previousMousePos;

        public Image originalImage;

        private Pen drawingPen;
        private drawEnum drawingType;
        private Font drawingFont;
        private Color drawingFontColor;
        private Stack<Image> undoStack;

        const string ImageFileFilter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.png|Bitmap Images (*.bmp)|*.bmp|JPEG Images (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Images (*.png)|*.png";

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (string command in Environment.GetCommandLineArgs())
            {
                if (command == "/debug")
                {
                    debugMode = true;
                    break;
                }
            }

            LoadPrinters();
            LoadCombos();

            this.TopMost = true;
            
            undoStack = new Stack<Image>();
        }

        private void LoadPrinters()
        {
            // add installed printers to menustrip
            // set the default printer to be checked in the menu strip
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                string findPrinter = PrinterSettings.InstalledPrinters[i];
                ToolStripItem currentItem = ctxmenuPrint.Items.Add(findPrinter);
                if (PrintDocument1.PrinterSettings.PrinterName == findPrinter)
                {
                    ToolStripMenuItem defaultPrinterMenu = (ToolStripMenuItem)currentItem;
                    defaultPrinterMenu.Checked = true;
                }
            }
        }

        private void LoadCombos()
        {
            for (int i = 1; i < 11; i++)
            {
                ThicknessToolStripComboBox.Items.Add("Thickness: " + i.ToString());
            }
            ThicknessToolStripComboBox.SelectedIndex = 0;
        }

        private void MultiSnipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!MultiSnipToolStripMenuItem.Checked)
            {
                MultiSnipToolStripMenuItem.Checked = true;
                Program.MultiSnip = true;
            }
            else
            {
                MultiSnipToolStripMenuItem.Checked = false;
                Program.MultiSnip = false;
            }
        }

        private void AutoClearCheck() {
            if (autoClear)
            {
                ClearAll();
            }
        }

        private void ClearAll()
        {
            PictureBox1.Image = null;
            PictureBox1.Invalidate();
            PictureBox1.Visible = false;

            if (originalImage != null)
            {
                originalImage.Dispose();
            }

            undoStack = new Stack<Image>();

            CloseSubForms();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // hide snip forms if in multisnip mode, otherwise close them
            if (Program.MultiSnip)
            {
                foreach (Form item in Application.OpenForms)
                {
                    item.Hide();
                }
                undoStack = new Stack<Image>();
            }
            else
            {
                this.Hide();
                // close the sub forms after switching from multi to single
                ClearAll();
            }

            UndoToolStripMenuItem.Enabled = false;

            //show capture form
            using (CaptureForm capture = new CaptureForm())
            {
                if (capture.ShowDialog() == DialogResult.OK)
                {
                    MainForm snipForm;

                    if (Program.MultiSnip)
                    {
                        snipForm = new MainForm();
                        snipForm.ShowInTaskbar = false;
                        snipForm.btnNew.Enabled = false;
                        Program.ControllerForm.Text = "SnipIt - Main";
                    }
                    else
                    {
                        snipForm = Program.ControllerForm;
                        snipForm.Text = "SnipIt";
                    }

                    // load captured image
                    snipForm.PictureBox1.Image = capture.ImageCaptured;
                    snipForm.PictureBox1.Visible = true;

                    // hold original image
                    snipForm.originalImage = capture.ImageCaptured;

                    // show new form to top left of current snip position
                    snipForm.StartPosition = FormStartPosition.Manual;
                    snipForm.Location = capture.PanelPosition;

                    snipForm.Show();
                }

                // show each snip and set non main settings
                foreach (Form showForm in Application.OpenForms)
                {
                    showForm.Show();
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                Clipboard.Clear();
                Clipboard.SetImage(PictureBox1.Image);

                AutoClearCheck();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                try
                {
                    SaveFileDialog1.CheckPathExists = true;
                    SaveFileDialog1.Filter = "Bitmap Images (*.bmp)|*.bmp|JPEG Images (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Images (*.png)|*.png";
                    SaveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                    SaveFileDialog1.ShowDialog();
                    if (!string.IsNullOrEmpty(SaveFileDialog1.FileName))
                    {
                        string fileExt = System.IO.Path.GetExtension(SaveFileDialog1.FileName);
                        ImageFormat format;

                        switch (fileExt)
                        {
                            case ".bmp":
                                format = ImageFormat.Bmp;
                                break;
                            case ".jpg":
                                format = ImageFormat.Jpeg;
                                break;
                            case ".png":
                                format = ImageFormat.Png;
                                break;
                            default:
                                format = ImageFormat.Bmp;
                                break;
                        }

                        PictureBox1.Image.Save(SaveFileDialog1.FileName, format);

                        AutoClearCheck();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                try
                {
                    // if a printer hasn't been selected then the default printer is used
                    PrintDocument1.PrinterSettings.PrinterName = Program.LastPrinterName;

                    // change orientation depending on size of picture
                    if (PictureBox1.Image.Width >= (PrintDocument1.PrinterSettings.DefaultPageSettings.PaperSize.Width 
                                                    - PrintDocument1.PrinterSettings.DefaultPageSettings.Margins.Left 
                                                    - PrintDocument1.PrinterSettings.DefaultPageSettings.Margins.Right))
                    {
                        PrintDocument1.DefaultPageSettings.Landscape = true;
                    }
                    else
                    {
                        PrintDocument1.DefaultPageSettings.Landscape = false;
                    }

                    if (debugMode)
                    {
                        MessageBox.Show(string.Format("Image Width: {0} \nPage Width: {1} \n", PictureBox1.Image.Width, PrintDocument1.DefaultPageSettings.PaperSize.Width - PrintDocument1.DefaultPageSettings.Margins.Left - PrintDocument1.DefaultPageSettings.Margins.Right), "Debug Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // make sure the held values are set to zero before printing
                    lastImagePrintPos.X = 0;
                    lastImagePrintPos.Y = 0;

                    // make sure that printer dialog boxes can be seen while printing
                    this.TopMost = false;
                    PrintDocument1.Print();
                    this.TopMost = true;

                    AutoClearCheck();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!string.IsNullOrEmpty(Program.LastPrinterName))
                {
                    // check the previously selected printer
                    // could have been selected in a different form
                    foreach (ToolStripMenuItem item in ctxmenuPrint.Items)
                    {
                        item.Checked = item.Text == Program.LastPrinterName ? true : false;
                    }
                }
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int imageMargin = 10;
            int pageWidth = (int)((e.PageBounds.Width - imageMargin * 2) /100 * PictureBox1.Image.HorizontalResolution);
            int pageHeight = (int)((e.PageBounds.Height - imageMargin * 2) / 100 * PictureBox1.Image.VerticalResolution);

            // check if the image is bigger than can fit on the page
            if (pageWidth < PictureBox1.Image.Width || pageHeight < PictureBox1.Image.Height)
            {
                // get a rectangle indicating the portion of the image we want to print
                Rectangle imageRect = new Rectangle(lastImagePrintPos, new Size(pageWidth, pageHeight));

                e.Graphics.DrawImage(PictureBox1.Image, e.PageBounds.X + imageMargin, e.PageBounds.Y + imageMargin, imageRect, GraphicsUnit.Pixel);

                // move to the next page to the right
                lastImagePrintPos.X += pageWidth;

                if (PictureBox1.Image.Width < lastImagePrintPos.X)
	            {
		            if (PictureBox1.Image.Height > lastImagePrintPos.Y + pageHeight)
	                {
                        // reset the x value to zero and increment the y value to print the next row of pages
                        lastImagePrintPos.X = 0;
                        lastImagePrintPos.Y += pageHeight;
                        e.HasMorePages = true;
	                }
                    else
                    {
                        // the whole width and height of the image have been printed
                        // stop the printing
                        lastImagePrintPos.X = 0;
                        lastImagePrintPos.Y = 0;
                        e.HasMorePages = false;
                    }
	            }
                else
                {
                    e.HasMorePages = true;
                }
            }
            else
            {
                // image can fit on one page
                e.Graphics.DrawImage(PictureBox1.Image, new Point(imageMargin, imageMargin));
            }
        }

        private void ctxmenuPrint_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in ctxmenuPrint.Items)
            {
                if (item.Text == e.ClickedItem.Text)
                {
                    item.Checked = true;
                    Program.LastPrinterName = item.Text;
                }
                else
	            {
                    item.Checked = false;
	            }
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                // get image from clipboard and load
                LoadExternalImage(Clipboard.GetImage());
            }
        }

        private void AutoClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Checked)
            {
                item.Checked = false;
                autoClear = false;
            }
            else
            {
                item.Checked = true;
                autoClear = true;
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && NoToolStripMenuItem.Checked == false)
            {
                // add a new clone of the image to the stack
                undoStack.Push((Image)PictureBox1.Image.Clone());

                if (TextEntryToolStripMenuItem.Checked)
                {
                    this.TopMost = false;

                    using (InputBox inp = new InputBox())
                    {
                        inp.Title = "Text Entry";
                        inp.Prompt = "Enter text to add:";

                        if (inp.ShowDialog() == DialogResult.OK)
                        {
                            if (!string.IsNullOrEmpty(inp.Entry))
                            {
                                // draw the text over the image
                                Graphics g = Graphics.FromImage(PictureBox1.Image);

                                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                                g.DrawString(inp.Entry, drawingFont, new SolidBrush(drawingFontColor), e.Location);

                                PictureBox1.Invalidate();
                            }
                        }
                    }

                    this.TopMost = true;
                    UndoToolStripMenuItem.Enabled = true;
                    ResetToolStripMenuItem.Enabled = true;
                }
                else
                {
                    previousMousePos = e.Location;
                    this.Cursor = Cursors.Cross;
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PictureBox1.Image != null && previousMousePos != null)
            {
                // set the image to the previous one each time before drawing
                PictureBox1.Image = (Image)undoStack.Peek().Clone();

                Graphics g = Graphics.FromImage(PictureBox1.Image);

                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                float startX = 0, startY = 0;
                float drawWidth = 0, drawHeight = 0;

                // work out drawing direction
                if (e.X > previousMousePos.Value.X)
                {
                    // right
                    drawWidth = e.X - previousMousePos.Value.X;
                    startX = previousMousePos.Value.X;
                }
                else
                {
                    // left
                    drawWidth = previousMousePos.Value.X - e.X;
                    startX = e.X;
                }

                if (e.Y > previousMousePos.Value.Y)
                {
                    // down
                    drawHeight = e.Y - previousMousePos.Value.Y;
                    startY = previousMousePos.Value.Y;
                }
                else
                {
                    // up
                    drawHeight = previousMousePos.Value.Y - e.Y;
                    startY = e.Y;
                }

                switch (drawingType)
                {
                    case drawEnum.Line:
                        
                        g.DrawLine(drawingPen, previousMousePos.Value, e.Location);
                        break;
                    case drawEnum.Rect:

                        g.DrawRectangle(drawingPen, startX, startY, drawWidth, drawHeight);
                        break;
                    case drawEnum.Ellipse:

                        g.DrawEllipse(drawingPen, startX, startY, drawWidth, drawHeight);
                        break;
                    default:

                        MessageBox.Show("Not Supported!", "Drawing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                }

                PictureBox1.Invalidate();
                UndoToolStripMenuItem.Enabled = true;
                ResetToolStripMenuItem.Enabled = true;
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // finish drawing
            previousMousePos = null;
            this.Cursor = Cursors.Default;
        }


        private void LineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingType = drawEnum.Line;

            SetDrawingStyle((ToolStripMenuItem)sender);

            LineToolStripMenuItem.Checked = true;
        }

        private void RectColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingType = drawEnum.Rect;

            SetDrawingStyle((ToolStripMenuItem)sender);

            RectToolStripMenuItem.Checked = true;
        }

        private void EllipseColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingType = drawEnum.Ellipse;

            SetDrawingStyle((ToolStripMenuItem)sender);

            EllipseToolStripMenuItem.Checked = true;
        }

        private void SetDrawingStyle(ToolStripMenuItem item)
        {
            ResetEditToolStrip();
            
            item.Checked = true;

            Single lineThickness = ThicknessToolStripComboBox.SelectedIndex + 1;

            switch (item.Text)
            {
                case "Black":

                    drawingPen = new Pen(Brushes.Black);
                    break;

                case "White":

                    drawingPen = new Pen(Brushes.White);
                    break;

                case "Red":

                    drawingPen = new Pen(Brushes.Red);
                    break;

                case "Green":

                    drawingPen = new Pen(Brushes.Green);
                    break;

                case "Blue":

                    drawingPen = new Pen(Brushes.Blue);
                    break;

                case "Yellow":

                    drawingPen = new Pen(Brushes.Yellow);
                    break;

                case "Custom":

                    ColorDialog1.ShowDialog();
                    drawingPen = new Pen(ColorDialog1.Color);
                    break;

                default:

                    drawingPen = new Pen(Brushes.Black);
                    break;
            }

            drawingPen.Width = lineThickness;
        }

        private void ResetEditToolStrip()
        {
            // reset the checked value of all menu items
            foreach (ToolStripItem item in ctxmenuEdit.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                {
                    if (menuItem.HasDropDownItems)
                    {
                        ResetMenuItemChecked(menuItem);
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void ResetMenuItemChecked(ToolStripMenuItem item)
        {
            item.Checked = false;

            foreach (ToolStripDropDownItem dropDown in item.DropDownItems)
            {
                if (dropDown.HasDropDownItems)
                {
                    // only menuitems can have dropdown items
                    ResetMenuItemChecked((ToolStripMenuItem)dropDown);
                }
                else
                {
                    if (dropDown is ToolStripMenuItem menuItem)
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void NoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetEditToolStrip();
            NoToolStripMenuItem.Checked = true;
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Clear();

            PictureBox1.Image = (Image)originalImage.Clone();
            UndoToolStripMenuItem.Enabled = false;
            ResetToolStripMenuItem.Enabled = false;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null && undoStack != null)
            {
                // show the previous image
                PictureBox1.Image = (Image)undoStack.Pop().Clone();

                if (undoStack.Count == 0)
                {
                    UndoToolStripMenuItem.Enabled = false;
                    ResetToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void ThicknessToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drawingPen != null)
            {
                drawingPen.Width = ThicknessToolStripComboBox.SelectedIndex + 1;
            }
        }

        private void TextEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog1.FontMustExist = true;
            FontDialog1.ShowColor = true;
            FontDialog1.Font = drawingFont;

            if (FontDialog1.ShowDialog() == DialogResult.OK)
            {
                drawingFont = FontDialog1.Font;
                drawingFontColor = FontDialog1.Color;

                ResetEditToolStrip();

                TextEntryToolStripMenuItem.Checked = true;
            }
        }

        private void CloseSubForms()
        {
            // can't use foreach here because the collection gets modified
            // with the close method
            for (int i = Application.OpenForms.Count - 1; i > -1; i--)
            {
                if (Application.OpenForms[i] != Program.ControllerForm)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.CheckFileExists = true;
                    ofd.Filter = ImageFileFilter;
                    ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                    if (ofd.ShowDialog() == DialogResult.OK) 
                    {
                        // image file will be locked until ClearAll is called
                        LoadExternalImage(Image.FromFile(ofd.FileName));
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Invalid Image Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadExternalImage(Image img)
        {
            this.SuspendLayout();

            PictureBox1.Image = img;
            PictureBox1.Visible = true;
            originalImage = PictureBox1.Image;
            undoStack = new Stack<Image>();

            this.ResumeLayout();
        }
    }
}