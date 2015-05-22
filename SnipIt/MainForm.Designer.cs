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
            this.cmdprint = new System.Windows.Forms.Button();
            this.ctxtmenuPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmdcopy = new System.Windows.Forms.Button();
            this.ctxtmenuCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdsave = new System.Windows.Forms.Button();
            this.cmdnew = new System.Windows.Forms.Button();
            this.ctxtmenuNew = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.TextEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThicknessToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctxtmenuCopy.SuspendLayout();
            this.ctxtmenuNew.SuspendLayout();
            this.ctxmenuEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdprint
            // 
            this.cmdprint.ContextMenuStrip = this.ctxtmenuPrint;
            this.cmdprint.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdprint.Location = new System.Drawing.Point(198, 5);
            this.cmdprint.Name = "cmdprint";
            this.cmdprint.Size = new System.Drawing.Size(65, 24);
            this.cmdprint.TabIndex = 8;
            this.cmdprint.Text = "Print";
            this.cmdprint.UseVisualStyleBackColor = true;
            this.cmdprint.Click += new System.EventHandler(this.cmdprint_Click);
            this.cmdprint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmdprint_MouseDown);
            // 
            // ctxtmenuPrint
            // 
            this.ctxtmenuPrint.Name = "ctxtmenuPrint";
            this.ctxtmenuPrint.Size = new System.Drawing.Size(61, 4);
            this.ctxtmenuPrint.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtmenuPrint_ItemClicked);
            // 
            // cmdcopy
            // 
            this.cmdcopy.ContextMenuStrip = this.ctxtmenuCopy;
            this.cmdcopy.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdcopy.Location = new System.Drawing.Point(68, 5);
            this.cmdcopy.Name = "cmdcopy";
            this.cmdcopy.Size = new System.Drawing.Size(65, 24);
            this.cmdcopy.TabIndex = 7;
            this.cmdcopy.Text = "Copy";
            this.cmdcopy.UseVisualStyleBackColor = true;
            this.cmdcopy.Click += new System.EventHandler(this.cmdcopy_Click);
            // 
            // ctxtmenuCopy
            // 
            this.ctxtmenuCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem});
            this.ctxtmenuCopy.Name = "ctxtmenuCopy";
            this.ctxtmenuCopy.Size = new System.Drawing.Size(103, 26);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // cmdsave
            // 
            this.cmdsave.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdsave.Location = new System.Drawing.Point(133, 5);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(65, 24);
            this.cmdsave.TabIndex = 6;
            this.cmdsave.Text = "Save";
            this.cmdsave.UseVisualStyleBackColor = true;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // cmdnew
            // 
            this.cmdnew.ContextMenuStrip = this.ctxtmenuNew;
            this.cmdnew.Font = new System.Drawing.Font("Arial", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdnew.Location = new System.Drawing.Point(3, 5);
            this.cmdnew.Name = "cmdnew";
            this.cmdnew.Size = new System.Drawing.Size(65, 24);
            this.cmdnew.TabIndex = 5;
            this.cmdnew.Text = "New";
            this.cmdnew.UseVisualStyleBackColor = true;
            this.cmdnew.Click += new System.EventHandler(this.cmdnew_Click);
            // 
            // ctxtmenuNew
            // 
            this.ctxtmenuNew.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MultiSnipToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.ClearToolStripMenuItem,
            this.AutoClearToolStripMenuItem});
            this.ctxtmenuNew.Name = "ctxtmenuNew";
            this.ctxtmenuNew.Size = new System.Drawing.Size(131, 76);
            // 
            // MultiSnipToolStripMenuItem
            // 
            this.MultiSnipToolStripMenuItem.Name = "MultiSnipToolStripMenuItem";
            this.MultiSnipToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.MultiSnipToolStripMenuItem.Text = "MultiSnip";
            this.MultiSnipToolStripMenuItem.Click += new System.EventHandler(this.MultiSnipToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // AutoClearToolStripMenuItem
            // 
            this.AutoClearToolStripMenuItem.Name = "AutoClearToolStripMenuItem";
            this.AutoClearToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.AutoClearToolStripMenuItem.Text = "Auto Clear";
            this.AutoClearToolStripMenuItem.Click += new System.EventHandler(this.AutoClearToolStripMenuItem_Click);
            // 
            // ctxmenuEdit
            // 
            this.ctxmenuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.RectToolStripMenuItem,
            this.EllipseToolStripMenuItem,
            this.TextEntryToolStripMenuItem,
            this.ToolStripSeparator1,
            this.UndoToolStripMenuItem,
            this.ResetToolStripMenuItem,
            this.ThicknessToolStripComboBox});
            this.ctxmenuEdit.Name = "ctxmenuEdit";
            this.ctxmenuEdit.Size = new System.Drawing.Size(182, 191);
            // 
            // NoToolStripMenuItem
            // 
            this.NoToolStripMenuItem.Checked = true;
            this.NoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoToolStripMenuItem.Name = "NoToolStripMenuItem";
            this.NoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
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
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.LineToolStripMenuItem.Text = "Line";
            // 
            // LineBlackToolStripMenuItem
            // 
            this.LineBlackToolStripMenuItem.Name = "LineBlackToolStripMenuItem";
            this.LineBlackToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineBlackToolStripMenuItem.Text = "Black";
            this.LineBlackToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineWhiteToolStripMenuItem
            // 
            this.LineWhiteToolStripMenuItem.Name = "LineWhiteToolStripMenuItem";
            this.LineWhiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineWhiteToolStripMenuItem.Text = "White";
            this.LineWhiteToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineRedToolStripMenuItem
            // 
            this.LineRedToolStripMenuItem.Name = "LineRedToolStripMenuItem";
            this.LineRedToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineRedToolStripMenuItem.Text = "Red";
            this.LineRedToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineGreenToolStripMenuItem
            // 
            this.LineGreenToolStripMenuItem.Name = "LineGreenToolStripMenuItem";
            this.LineGreenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineGreenToolStripMenuItem.Text = "Green";
            this.LineGreenToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineBlueToolStripMenuItem
            // 
            this.LineBlueToolStripMenuItem.Name = "LineBlueToolStripMenuItem";
            this.LineBlueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineBlueToolStripMenuItem.Text = "Blue";
            this.LineBlueToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineYellowToolStripMenuItem
            // 
            this.LineYellowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.LineYellowToolStripMenuItem.Name = "LineYellowToolStripMenuItem";
            this.LineYellowToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.LineYellowToolStripMenuItem.Text = "Yellow";
            this.LineYellowToolStripMenuItem.Click += new System.EventHandler(this.LineColorToolStripMenuItem_Click);
            // 
            // LineCustomToolStripMenuItem
            // 
            this.LineCustomToolStripMenuItem.Name = "LineCustomToolStripMenuItem";
            this.LineCustomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            this.RectToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.RectToolStripMenuItem.Text = "Rectangle";
            // 
            // RectBlackToolStripMenuItem
            // 
            this.RectBlackToolStripMenuItem.Name = "RectBlackToolStripMenuItem";
            this.RectBlackToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectBlackToolStripMenuItem.Text = "Black";
            this.RectBlackToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectWhiteToolStripMenuItem
            // 
            this.RectWhiteToolStripMenuItem.Name = "RectWhiteToolStripMenuItem";
            this.RectWhiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectWhiteToolStripMenuItem.Text = "White";
            this.RectWhiteToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectRedToolStripMenuItem
            // 
            this.RectRedToolStripMenuItem.Name = "RectRedToolStripMenuItem";
            this.RectRedToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectRedToolStripMenuItem.Text = "Red";
            this.RectRedToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectGreenToolStripMenuItem
            // 
            this.RectGreenToolStripMenuItem.Name = "RectGreenToolStripMenuItem";
            this.RectGreenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectGreenToolStripMenuItem.Text = "Green";
            this.RectGreenToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectBlueToolStripMenuItem
            // 
            this.RectBlueToolStripMenuItem.Name = "RectBlueToolStripMenuItem";
            this.RectBlueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectBlueToolStripMenuItem.Text = "Blue";
            this.RectBlueToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectYellowToolStripMenuItem
            // 
            this.RectYellowToolStripMenuItem.Name = "RectYellowToolStripMenuItem";
            this.RectYellowToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.RectYellowToolStripMenuItem.Text = "Yellow";
            this.RectYellowToolStripMenuItem.Click += new System.EventHandler(this.RectColorToolStripMenuItem_Click);
            // 
            // RectCustomToolStripMenuItem
            // 
            this.RectCustomToolStripMenuItem.Name = "RectCustomToolStripMenuItem";
            this.RectCustomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
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
            this.EllipseToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.EllipseToolStripMenuItem.Text = "Ellipse";
            // 
            // EllipseBlackToolStripMenuItem
            // 
            this.EllipseBlackToolStripMenuItem.Name = "EllipseBlackToolStripMenuItem";
            this.EllipseBlackToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseBlackToolStripMenuItem.Text = "Black";
            this.EllipseBlackToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseWhiteToolStripMenuItem
            // 
            this.EllipseWhiteToolStripMenuItem.Name = "EllipseWhiteToolStripMenuItem";
            this.EllipseWhiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseWhiteToolStripMenuItem.Text = "White";
            this.EllipseWhiteToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseRedToolStripMenuItem
            // 
            this.EllipseRedToolStripMenuItem.Name = "EllipseRedToolStripMenuItem";
            this.EllipseRedToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseRedToolStripMenuItem.Text = "Red";
            this.EllipseRedToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseGreenToolStripMenuItem
            // 
            this.EllipseGreenToolStripMenuItem.Name = "EllipseGreenToolStripMenuItem";
            this.EllipseGreenToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseGreenToolStripMenuItem.Text = "Green";
            this.EllipseGreenToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseBlueToolStripMenuItem
            // 
            this.EllipseBlueToolStripMenuItem.Name = "EllipseBlueToolStripMenuItem";
            this.EllipseBlueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseBlueToolStripMenuItem.Text = "Blue";
            this.EllipseBlueToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseYellowToolStripMenuItem
            // 
            this.EllipseYellowToolStripMenuItem.Name = "EllipseYellowToolStripMenuItem";
            this.EllipseYellowToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseYellowToolStripMenuItem.Text = "Yellow";
            this.EllipseYellowToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // EllipseCustomToolStripMenuItem
            // 
            this.EllipseCustomToolStripMenuItem.Name = "EllipseCustomToolStripMenuItem";
            this.EllipseCustomToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.EllipseCustomToolStripMenuItem.Text = "Custom";
            this.EllipseCustomToolStripMenuItem.Click += new System.EventHandler(this.EllipseColorToolStripMenuItem_Click);
            // 
            // TextEntryToolStripMenuItem
            // 
            this.TextEntryToolStripMenuItem.Name = "TextEntryToolStripMenuItem";
            this.TextEntryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.TextEntryToolStripMenuItem.Text = "Text Entry";
            this.TextEntryToolStripMenuItem.Click += new System.EventHandler(this.TextEntryToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem
            // 
            this.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem";
            this.ResetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ResetToolStripMenuItem.Text = "Reset";
            this.ResetToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // ThicknessToolStripComboBox
            // 
            this.ThicknessToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThicknessToolStripComboBox.Name = "ThicknessToolStripComboBox";
            this.ThicknessToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.ThicknessToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ThicknessToolStripComboBox_SelectedIndexChanged);
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.PictureBox1.ContextMenuStrip = this.ctxmenuEdit;
            this.PictureBox1.Location = new System.Drawing.Point(0, 32);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.PictureBox1.Size = new System.Drawing.Size(256, 10);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Visible = false;
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(266, 32);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.cmdprint);
            this.Controls.Add(this.cmdcopy);
            this.Controls.Add(this.cmdsave);
            this.Controls.Add(this.cmdnew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 58);
            this.Name = "MainForm";
            this.Text = "SnipIt";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ctxtmenuCopy.ResumeLayout(false);
            this.ctxtmenuNew.ResumeLayout(false);
            this.ctxmenuEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdprint;
        internal System.Windows.Forms.Button cmdcopy;
        internal System.Windows.Forms.Button cmdsave;
        internal System.Windows.Forms.Button cmdnew;
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
        internal System.Windows.Forms.ContextMenuStrip ctxtmenuCopy;
        internal System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip ctxtmenuPrint;
        internal System.Windows.Forms.ContextMenuStrip ctxtmenuNew;
        internal System.Windows.Forms.ToolStripMenuItem MultiSnipToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AutoClearToolStripMenuItem;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}

