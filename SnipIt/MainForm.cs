using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipIt
{
    public partial class MainForm : Form
    {
        #region variables

        private string selPrinter;
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

            // add installed printers to menustrip
            // set the default printer to be checked in the menu strip
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                string findPrinter = PrinterSettings.InstalledPrinters[i];
                ToolStripItem currentItem = ctxtmenuPrint.Items.Add(findPrinter);
                if (PrintDocument1.PrinterSettings.PrinterName == findPrinter)
                {
                    ToolStripMenuItem defaultPrinterMenu = (ToolStripMenuItem)currentItem;
                    defaultPrinterMenu.Checked = true;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                ThicknessToolStripComboBox.Items.Add("Thickness: " + i.ToString());
            }
            ThicknessToolStripComboBox.SelectedIndex = 0;

            this.TopMost = true;

            undoStack = new Stack<Image>();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if (this == Program.ControllerForm)
            //{
            //    // minimise each open form at the same time
            //    foreach (Form item in Application.OpenForms)
            //    {
            //        // ignore the main form with asterisk as the tag
            //        if (item != this)
            //        {
            //            item.Visible = !item.Visible;
            //        }
            //    }
            //}
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

        private void cmdcopy_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                Clipboard.Clear();
                Clipboard.SetImage(PictureBox1.Image);

                AutoClearCheck();
            }
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            if (PictureBox1.Image != null)
            {
                try
                {
                    SaveFileDialog1.CheckPathExists = true;
                    SaveFileDialog1.Filter = "Bitmap Images (*.bmp)|*.bmp|JPEG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png";
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

        private void cmdprint_Click(object sender, EventArgs e)
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

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int imageMargin = 10;
            int pageWidth = (int)((e.PageBounds.Width - imageMargin * 2) /100 * PictureBox1.Image.HorizontalResolution);
            int pageHeight = (int)((e.PageBounds.Height - imageMargin * 2) / 100 * PictureBox1.Image.VerticalResolution);

            // check if the image is bigger than can fit on the page
            if (pageWidth < PictureBox1.Image.Width || pageWidth < PictureBox1.Image.Height)
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

        private void cmdprint_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!string.IsNullOrEmpty(Program.LastPrinterName))
                {
                    // check the previously selected printer
                    // could have been selected in a different form
                    foreach (ToolStripMenuItem item in ctxtmenuPrint.Items)
                    {
                        item.Checked = item.Text == Program.LastPrinterName ? true : false;
                    }
                }
            }
        }

        private void ctxtmenuPrint_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in ctxtmenuPrint.Items)
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
                PictureBox1.Image = Clipboard.GetImage();
                PictureBox1.Visible = true;

                // fix for form not autoscaling after picture size has changed
                this.Invalidate();
                this.PerformAutoScale();
                
                // change main form dimensions for new capture
                //this.Height = this.Height + PictureBox1.Height + 5;
                //this.Width = PictureBox1.Width + 12;

                //// change panel container dimensions for border around piturebox
                //Panel1.Width = this.Width - 6;
                //Panel1.Height = this.Height - 32;
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
            if (e.Button == System.Windows.Forms.MouseButtons.Left && NoToolStripMenuItem.Checked == false)
            {
                // add a new clone of the image to the stack
                undoStack.Push((Image)PictureBox1.Image.Clone());

                if (TextEntryToolStripMenuItem.Checked)
                {
                    this.TopMost = false;

                    // TODO Add inputbox class
                    string textEntry = "";

                    if (!string.IsNullOrEmpty(textEntry))
                    {
                        // draw the text over the image
                        Graphics g = Graphics.FromImage(PictureBox1.Image);

                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.DrawString(textEntry, drawingFont, new SolidBrush(drawingFontColor), e.Location);

                        PictureBox1.Invalidate();
                    }

                    this.TopMost = true;
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

                switch (drawingType)
                {
                    case drawEnum.Line:
                        
                        g.DrawLine(drawingPen, previousMousePos.Value, e.Location);
                        break;
                    case drawEnum.Rect:
                        
                        g.DrawRectangle(drawingPen, previousMousePos.Value.X, previousMousePos.Value.Y, e.X - previousMousePos.Value.X, e.Y - previousMousePos.Value.Y);
                        break;
                    case drawEnum.Ellipse:

                        g.DrawEllipse(drawingPen, previousMousePos.Value.X, previousMousePos.Value.Y, e.X - previousMousePos.Value.X, e.Y - previousMousePos.Value.Y);
                        break;
                    default:

                        MessageBox.Show("Not Supported!", "Drawing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                }

                PictureBox1.Invalidate();
                UndoToolStripMenuItem.Enabled = true;
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
                ToolStripMenuItem menuItem = item as ToolStripMenuItem;

                if (menuItem != null)
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
                    ToolStripMenuItem menuItem = dropDown as ToolStripMenuItem;

                    if (menuItem != null)
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

            if (FontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                drawingFont = FontDialog1.Font;
                drawingFontColor = FontDialog1.Color;

                ResetEditToolStrip();

                TextEntryToolStripMenuItem.Checked = true;
                UndoToolStripMenuItem.Enabled = true;
            }
        }

        private void CloseSubForms()
        {
            // can't use for each here because the collection gets modified
            // with the close method
            for (int i = Application.OpenForms.Count - 1; i > -1; i--)
            {
                if (Application.OpenForms[i] != Program.ControllerForm)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void cmdnew_Click(object sender, EventArgs e)
        {
            // hide snip forms if in multisnip mode, otherwise close them
            if (Program.MultiSnip)
            {
                foreach (Form item in Application.OpenForms)
                {
                    item.Hide();
                }

                if (autoClear)
                {
                    this.PictureBox1.Image = null;
                    this.PictureBox1.Visible = false;
                }
            }
            else
            {
                // close the sub forms after switching from multi to single
                CloseSubForms();   

                this.PictureBox1.Image = null;
                this.PictureBox1.Visible = false;
                this.Hide();
            }

            undoStack = new Stack<Image>();
            UndoToolStripMenuItem.Enabled = false;

            //show capture form
            using (CaptureForm capture = new CaptureForm())
            {
                if (capture.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MainForm snipForm;

                    if (Program.MultiSnip) 
                    {
                        snipForm = new MainForm();
                        snipForm.ShowInTaskbar = false;
                        snipForm.cmdnew.Enabled = false;
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
    }
}
