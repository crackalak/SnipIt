namespace SnipIt
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ctxmenuPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuNew = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MultiSnipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ctxmenuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseGreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EllipseCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThicknessToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctxmenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCopy = new SnipIt.SplitButton();
            this.btnNew = new SnipIt.SplitButton();
            this.btnSave = new SnipIt.SplitButton();
            this.btnPrint = new SnipIt.SplitButton();
            this.ctxmenuCopy.SuspendLayout();
            this.ctxmenuNew.SuspendLayout();
            this.ctxmenuEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ctxmenuSave.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxmenuPrint
            // 
            this.ctxmenuPrint.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxmenuPrint.Name = "ctxtmenuPrint";
            this.ctxmenuPrint.Size = new System.Drawing.Size(61, 4);
            this.ctxmenuPrint.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxmenuPrint_ItemClicked);
            // 
            // ctxmenuCopy
            // 
            this.ctxmenuCopy.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxmenuCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem});
            this.ctxmenuCopy.Name = "ctxtmenuCopy";
            this.ctxmenuCopy.Size = new System.Drawing.Size(113, 28);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // ctxmenuNew
            // 
            this.ctxmenuNew.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxmenuNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MultiSnipToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ClearToolStripMenuItem,
            this.AutoClearToolStripMenuItem});
            this.ctxmenuNew.Name = "ctxtmenuNew";
            this.ctxmenuNew.Size = new System.Drawing.Size(149, 82);
            // 
            // MultiSnipToolStripMenuItem
            // 
            this.MultiSnipToolStripMenuItem.Name = "MultiSnipToolStripMenuItem";
            this.MultiSnipToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.MultiSnipToolStripMenuItem.Text = "MultiSnip";
            this.MultiSnipToolStripMenuItem.Click += new System.EventHandler(this.MultiSnipToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // AutoClearToolStripMenuItem
            // 
            this.AutoClearToolStripMenuItem.Name = "AutoClearToolStripMenuItem";
            this.AutoClearToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.AutoClearToolStripMenuItem.Text = "Auto Clear";
            this.AutoClearToolStripMenuItem.Click += new System.EventHandler(this.AutoClearToolStripMenuItem_Click);
            // 
            // ctxmenuEdit
            // 
            this.ctxmenuEdit.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxmenuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.RectToolStripMenuItem,
            this.EllipseToolStripMenuItem,
            this.ThicknessToolStripComboBox,
            this.ToolStripSeparator1,
            this.TextEntryToolStripMenuItem,
            this.toolStripSeparator2,
            this.UndoToolStripMenuItem,
            this.ResetToolStripMenuItem});
            this.ctxmenuEdit.Name = "ctxmenuEdit";
            this.ctxmenuEdit.Size = new System.Drawing.Size(182, 230);
            // 
            // NoToolStripMenuItem
            // 
            this.NoToolStripMenuItem.Checked = true;
            this.NoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoToolStripMenuItem.Name = "NoToolStripMenuItem";
            this.NoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.NoToolStripMenuItem.Text = "No Tool";
            this.NoToolStripMenuItem.Click += new System.EventHandler(this.NoToolStripMenuItem_Click);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineBlackToolStripMenuItem,
            this.LineWhiteToolStripMenuItem,
            this.LineRedToolStripMenuItem,
            this.LineGreenToolStripMenuItem,
            this.LineBlueToolStripMenuItem,
            this.LineYellowToolStripMenuItem,
            this.LineCustomToolStripMenuItem});
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.LineToolStripMenuItem.Text = "Line";
            // 
            // LineBlackToolStripMenuItem
            // 
            this.LineBlackToolStripMenuItem.Name = "LineBlackToolStripMenuItem";
            this.LineBlackToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineBlackToolStripMenuItem.Text = "Black";
            this.LineBlackToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineWhiteToolStripMenuItem
            // 
            this.LineWhiteToolStripMenuItem.Name = "LineWhiteToolStripMenuItem";
            this.LineWhiteToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineWhiteToolStripMenuItem.Text = "White";
            this.LineWhiteToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineRedToolStripMenuItem
            // 
            this.LineRedToolStripMenuItem.Name = "LineRedToolStripMenuItem";
            this.LineRedToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineRedToolStripMenuItem.Text = "Red";
            this.LineRedToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineGreenToolStripMenuItem
            // 
            this.LineGreenToolStripMenuItem.Name = "LineGreenToolStripMenuItem";
            this.LineGreenToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineGreenToolStripMenuItem.Text = "Green";
            this.LineGreenToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineBlueToolStripMenuItem
            // 
            this.LineBlueToolStripMenuItem.Name = "LineBlueToolStripMenuItem";
            this.LineBlueToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineBlueToolStripMenuItem.Text = "Blue";
            this.LineBlueToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineYellowToolStripMenuItem
            // 
            this.LineYellowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.LineYellowToolStripMenuItem.Name = "LineYellowToolStripMenuItem";
            this.LineYellowToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineYellowToolStripMenuItem.Text = "Yellow";
            this.LineYellowToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineCustomToolStripMenuItem
            // 
            this.LineCustomToolStripMenuItem.Name = "LineCustomToolStripMenuItem";
            this.LineCustomToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.LineCustomToolStripMenuItem.Text = "Custom";
            this.LineCustomToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // RectToolStripMenuItem
            // 
            this.RectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RectBlackToolStripMenuItem,
            this.RectWhiteToolStripMenuItem,
            this.RectRedToolStripMenuItem,
            this.RectGreenToolStripMenuItem,
            this.RectBlueToolStripMenuItem,
            this.RectYellowToolStripMenuItem,
            this.RectCustomToolStripMenuItem});
            this.RectToolStripMenuItem.Name = "RectToolStripMenuItem";
            this.RectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.RectToolStripMenuItem.Text = "Rectangle";
            // 
            // RectBlackToolStripMenuItem
            // 
            this.RectBlackToolStripMenuItem.Name = "RectBlackToolStripMenuItem";
            this.RectBlackToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectBlackToolStripMenuItem.Text = "Black";
            this.RectBlackToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectWhiteToolStripMenuItem
            // 
            this.RectWhiteToolStripMenuItem.Name = "RectWhiteToolStripMenuItem";
            this.RectWhiteToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectWhiteToolStripMenuItem.Text = "White";
            this.RectWhiteToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectRedToolStripMenuItem
            // 
            this.RectRedToolStripMenuItem.Name = "RectRedToolStripMenuItem";
            this.RectRedToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectRedToolStripMenuItem.Text = "Red";
            this.RectRedToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectGreenToolStripMenuItem
            // 
            this.RectGreenToolStripMenuItem.Name = "RectGreenToolStripMenuItem";
            this.RectGreenToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectGreenToolStripMenuItem.Text = "Green";
            this.RectGreenToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectBlueToolStripMenuItem
            // 
            this.RectBlueToolStripMenuItem.Name = "RectBlueToolStripMenuItem";
            this.RectBlueToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectBlueToolStripMenuItem.Text = "Blue";
            this.RectBlueToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectYellowToolStripMenuItem
            // 
            this.RectYellowToolStripMenuItem.Name = "RectYellowToolStripMenuItem";
            this.RectYellowToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectYellowToolStripMenuItem.Text = "Yellow";
            this.RectYellowToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectCustomToolStripMenuItem
            // 
            this.RectCustomToolStripMenuItem.Name = "RectCustomToolStripMenuItem";
            this.RectCustomToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.RectCustomToolStripMenuItem.Text = "Custom";
            this.RectCustomToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // EllipseToolStripMenuItem
            // 
            this.EllipseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EllipseBlackToolStripMenuItem,
            this.EllipseWhiteToolStripMenuItem,
            this.EllipseRedToolStripMenuItem,
            this.EllipseGreenToolStripMenuItem,
            this.EllipseBlueToolStripMenuItem,
            this.EllipseYellowToolStripMenuItem,
            this.EllipseCustomToolStripMenuItem});
            this.EllipseToolStripMenuItem.Name = "EllipseToolStripMenuItem";
            this.EllipseToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.EllipseToolStripMenuItem.Text = "Ellipse";
            // 
            // EllipseBlackToolStripMenuItem
            // 
            this.EllipseBlackToolStripMenuItem.Name = "EllipseBlackToolStripMenuItem";
            this.EllipseBlackToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseBlackToolStripMenuItem.Text = "Black";
            this.EllipseBlackToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseWhiteToolStripMenuItem
            // 
            this.EllipseWhiteToolStripMenuItem.Name = "EllipseWhiteToolStripMenuItem";
            this.EllipseWhiteToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseWhiteToolStripMenuItem.Text = "White";
            this.EllipseWhiteToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseRedToolStripMenuItem
            // 
            this.EllipseRedToolStripMenuItem.Name = "EllipseRedToolStripMenuItem";
            this.EllipseRedToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseRedToolStripMenuItem.Text = "Red";
            this.EllipseRedToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseGreenToolStripMenuItem
            // 
            this.EllipseGreenToolStripMenuItem.Name = "EllipseGreenToolStripMenuItem";
            this.EllipseGreenToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseGreenToolStripMenuItem.Text = "Green";
            this.EllipseGreenToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseBlueToolStripMenuItem
            // 
            this.EllipseBlueToolStripMenuItem.Name = "EllipseBlueToolStripMenuItem";
            this.EllipseBlueToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseBlueToolStripMenuItem.Text = "Blue";
            this.EllipseBlueToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseYellowToolStripMenuItem
            // 
            this.EllipseYellowToolStripMenuItem.Name = "EllipseYellowToolStripMenuItem";
            this.EllipseYellowToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseYellowToolStripMenuItem.Text = "Yellow";
            this.EllipseYellowToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseCustomToolStripMenuItem
            // 
            this.EllipseCustomToolStripMenuItem.Name = "EllipseCustomToolStripMenuItem";
            this.EllipseCustomToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.EllipseCustomToolStripMenuItem.Text = "Custom";
            this.EllipseCustomToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // ThicknessToolStripComboBox
            // 
            this.ThicknessToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThicknessToolStripComboBox.Name = "ThicknessToolStripComboBox";
            this.ThicknessToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.ThicknessToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ThicknessToolStripComboBox_SelectedIndexChanged);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // TextEntryToolStripMenuItem
            // 
            this.TextEntryToolStripMenuItem.Name = "TextEntryToolStripMenuItem";
            this.TextEntryToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.TextEntryToolStripMenuItem.Text = "Text Entry";
            this.TextEntryToolStripMenuItem.Click += new System.EventHandler(this.TextEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Enabled = false;
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ResetToolStripMenuItem.Text = "Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.PictureBox1.ContextMenuStrip = this.ctxmenuEdit;
            this.PictureBox1.Location = new System.Drawing.Point(0, 38);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PictureBox1.Size = new System.Drawing.Size(256, 10);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // ctxmenuSave
            // 
            this.ctxmenuSave.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ctxmenuSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.ctxmenuSave.Name = "ctxmenuSave";
            this.ctxmenuSave.Size = new System.Drawing.Size(112, 28);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCopy, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 36);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCopy
            // 
            this.btnCopy.ContextMenuStrip = this.ctxmenuCopy;
            this.btnCopy.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(92, 4);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 28);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnNew
            // 
            this.btnNew.ContextMenuStrip = this.ctxmenuNew;
            this.btnNew.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(6, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 28);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ContextMenuStrip = this.ctxmenuSave;
            this.btnSave.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(178, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ContextMenuStrip = this.ctxmenuPrint;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(264, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(79, 28);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(349, 38);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SnipIt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctxmenuCopy.ResumeLayout(false);
            this.ctxmenuNew.ResumeLayout(false);
            this.ctxmenuEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ctxmenuSave.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.FontDialog FontDialog1;
        internal System.Windows.Forms.ColorDialog ColorDialog1;
        internal System.Windows.Forms.ContextMenuStrip ctxmenuEdit;
        internal System.Windows.Forms.ToolStripMenuItem NoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineBlackToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineWhiteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineRedToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineGreenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineBlueToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineYellowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LineCustomToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectBlackToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectWhiteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectRedToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectGreenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectBlueToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectYellowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RectCustomToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseBlackToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseWhiteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseRedToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseGreenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseBlueToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseYellowToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EllipseCustomToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TextEntryToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ResetToolStripMenuItem;
        internal System.Windows.Forms.ToolStripComboBox ThicknessToolStripComboBox;
        internal System.Windows.Forms.ContextMenuStrip ctxmenuCopy;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ctxmenuPrint;
        internal System.Windows.Forms.ContextMenuStrip ctxmenuNew;
        internal System.Windows.Forms.ToolStripMenuItem MultiSnipToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoClearToolStripMenuItem;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ContextMenuStrip ctxmenuSave;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal SplitButton btnSave;
        internal SplitButton btnCopy;
        internal SplitButton btnNew;
        internal SplitButton btnPrint;
    }
}

