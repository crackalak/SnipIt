<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class app_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(app_main))
        Me.cmdnew = New System.Windows.Forms.Button()
        Me.ctxtmenuNew = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MultiSnipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cmdcopy = New System.Windows.Forms.Button()
        Me.ctxtmenuCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdprint = New System.Windows.Forms.Button()
        Me.ctxtmenuPrint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ctxmenuEdit = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineYellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineCustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectYellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectCustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseWhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseRedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseGreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseYellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EllipseCustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ctxtmenuNew.SuspendLayout()
        Me.ctxtmenuCopy.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmenuEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdnew
        '
        Me.cmdnew.ContextMenuStrip = Me.ctxtmenuNew
        Me.cmdnew.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(3, 2)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(65, 24)
        Me.cmdnew.TabIndex = 0
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'ctxtmenuNew
        '
        Me.ctxtmenuNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MultiSnipToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClearToolStripMenuItem, Me.AutoClearToolStripMenuItem})
        Me.ctxtmenuNew.Name = "ctxtmenuNew"
        Me.ctxtmenuNew.Size = New System.Drawing.Size(137, 76)
        '
        'MultiSnipToolStripMenuItem
        '
        Me.MultiSnipToolStripMenuItem.Name = "MultiSnipToolStripMenuItem"
        Me.MultiSnipToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MultiSnipToolStripMenuItem.Text = "MultiSnip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AutoClearToolStripMenuItem
        '
        Me.AutoClearToolStripMenuItem.Name = "AutoClearToolStripMenuItem"
        Me.AutoClearToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AutoClearToolStripMenuItem.Text = "Auto Clear"
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(133, 2)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(65, 24)
        Me.cmdsave.TabIndex = 2
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdcopy
        '
        Me.cmdcopy.ContextMenuStrip = Me.ctxtmenuCopy
        Me.cmdcopy.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcopy.Location = New System.Drawing.Point(68, 2)
        Me.cmdcopy.Name = "cmdcopy"
        Me.cmdcopy.Size = New System.Drawing.Size(65, 24)
        Me.cmdcopy.TabIndex = 3
        Me.cmdcopy.Text = "Copy"
        Me.cmdcopy.UseVisualStyleBackColor = True
        '
        'ctxtmenuCopy
        '
        Me.ctxtmenuCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasteToolStripMenuItem})
        Me.ctxtmenuCopy.Name = "ctxtmenuCopy"
        Me.ctxtmenuCopy.Size = New System.Drawing.Size(113, 26)
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'cmdprint
        '
        Me.cmdprint.ContextMenuStrip = Me.ctxtmenuPrint
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 7.854546!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.Location = New System.Drawing.Point(198, 2)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(65, 24)
        Me.cmdprint.TabIndex = 4
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'ctxtmenuPrint
        '
        Me.ctxtmenuPrint.Name = "ctxtmenuPrint"
        Me.ctxtmenuPrint.Size = New System.Drawing.Size(61, 4)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.MinimumSize = New System.Drawing.Size(260, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 78)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.ContextMenuStrip = Me.ctxmenuEdit
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 47)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ctxmenuEdit
        '
        Me.ctxmenuEdit.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoToolStripMenuItem, Me.LineToolStripMenuItem, Me.RectToolStripMenuItem, Me.EllipseToolStripMenuItem, Me.ToolStripSeparator1, Me.UndoToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ctxmenuEdit.Name = "ctxmenuEdit"
        Me.ctxmenuEdit.Size = New System.Drawing.Size(153, 164)
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Checked = True
        Me.NoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NoToolStripMenuItem.Text = "No Tool"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineBlackToolStripMenuItem, Me.LineWhiteToolStripMenuItem, Me.LineRedToolStripMenuItem, Me.LineGreenToolStripMenuItem, Me.LineBlueToolStripMenuItem, Me.LineYellowToolStripMenuItem, Me.LineCustomToolStripMenuItem})
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LineToolStripMenuItem.Text = "Line"
        '
        'LineBlackToolStripMenuItem
        '
        Me.LineBlackToolStripMenuItem.Name = "LineBlackToolStripMenuItem"
        Me.LineBlackToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineBlackToolStripMenuItem.Text = "Black"
        '
        'LineWhiteToolStripMenuItem
        '
        Me.LineWhiteToolStripMenuItem.Name = "LineWhiteToolStripMenuItem"
        Me.LineWhiteToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineWhiteToolStripMenuItem.Text = "White"
        '
        'LineRedToolStripMenuItem
        '
        Me.LineRedToolStripMenuItem.Name = "LineRedToolStripMenuItem"
        Me.LineRedToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineRedToolStripMenuItem.Text = "Red"
        '
        'LineGreenToolStripMenuItem
        '
        Me.LineGreenToolStripMenuItem.Name = "LineGreenToolStripMenuItem"
        Me.LineGreenToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineGreenToolStripMenuItem.Text = "Green"
        '
        'LineBlueToolStripMenuItem
        '
        Me.LineBlueToolStripMenuItem.Name = "LineBlueToolStripMenuItem"
        Me.LineBlueToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineBlueToolStripMenuItem.Text = "Blue"
        '
        'LineYellowToolStripMenuItem
        '
        Me.LineYellowToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.LineYellowToolStripMenuItem.Name = "LineYellowToolStripMenuItem"
        Me.LineYellowToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineYellowToolStripMenuItem.Text = "Yellow"
        '
        'LineCustomToolStripMenuItem
        '
        Me.LineCustomToolStripMenuItem.Name = "LineCustomToolStripMenuItem"
        Me.LineCustomToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.LineCustomToolStripMenuItem.Text = "Custom"
        '
        'RectToolStripMenuItem
        '
        Me.RectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RectBlackToolStripMenuItem, Me.RectWhiteToolStripMenuItem, Me.RectRedToolStripMenuItem, Me.RectGreenToolStripMenuItem, Me.RectBlueToolStripMenuItem, Me.RectYellowToolStripMenuItem, Me.RectCustomToolStripMenuItem})
        Me.RectToolStripMenuItem.Name = "RectToolStripMenuItem"
        Me.RectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RectToolStripMenuItem.Text = "Rectangle"
        '
        'RectBlackToolStripMenuItem
        '
        Me.RectBlackToolStripMenuItem.Name = "RectBlackToolStripMenuItem"
        Me.RectBlackToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectBlackToolStripMenuItem.Text = "Black"
        '
        'RectWhiteToolStripMenuItem
        '
        Me.RectWhiteToolStripMenuItem.Name = "RectWhiteToolStripMenuItem"
        Me.RectWhiteToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectWhiteToolStripMenuItem.Text = "White"
        '
        'RectRedToolStripMenuItem
        '
        Me.RectRedToolStripMenuItem.Name = "RectRedToolStripMenuItem"
        Me.RectRedToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectRedToolStripMenuItem.Text = "Red"
        '
        'RectGreenToolStripMenuItem
        '
        Me.RectGreenToolStripMenuItem.Name = "RectGreenToolStripMenuItem"
        Me.RectGreenToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectGreenToolStripMenuItem.Text = "Green"
        '
        'RectBlueToolStripMenuItem
        '
        Me.RectBlueToolStripMenuItem.Name = "RectBlueToolStripMenuItem"
        Me.RectBlueToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectBlueToolStripMenuItem.Text = "Blue"
        '
        'RectYellowToolStripMenuItem
        '
        Me.RectYellowToolStripMenuItem.Name = "RectYellowToolStripMenuItem"
        Me.RectYellowToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectYellowToolStripMenuItem.Text = "Yellow"
        '
        'RectCustomToolStripMenuItem
        '
        Me.RectCustomToolStripMenuItem.Name = "RectCustomToolStripMenuItem"
        Me.RectCustomToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RectCustomToolStripMenuItem.Text = "Custom"
        '
        'EllipseToolStripMenuItem
        '
        Me.EllipseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EllipseBlackToolStripMenuItem, Me.EllipseWhiteToolStripMenuItem, Me.EllipseRedToolStripMenuItem, Me.EllipseGreenToolStripMenuItem, Me.EllipseBlueToolStripMenuItem, Me.EllipseYellowToolStripMenuItem, Me.EllipseCustomToolStripMenuItem})
        Me.EllipseToolStripMenuItem.Name = "EllipseToolStripMenuItem"
        Me.EllipseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EllipseToolStripMenuItem.Text = "Elipse"
        '
        'EllipseBlackToolStripMenuItem
        '
        Me.EllipseBlackToolStripMenuItem.Name = "EllipseBlackToolStripMenuItem"
        Me.EllipseBlackToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseBlackToolStripMenuItem.Text = "Black"
        '
        'EllipseWhiteToolStripMenuItem
        '
        Me.EllipseWhiteToolStripMenuItem.Name = "EllipseWhiteToolStripMenuItem"
        Me.EllipseWhiteToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseWhiteToolStripMenuItem.Text = "White"
        '
        'EllipseRedToolStripMenuItem
        '
        Me.EllipseRedToolStripMenuItem.Name = "EllipseRedToolStripMenuItem"
        Me.EllipseRedToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseRedToolStripMenuItem.Text = "Red"
        '
        'EllipseGreenToolStripMenuItem
        '
        Me.EllipseGreenToolStripMenuItem.Name = "EllipseGreenToolStripMenuItem"
        Me.EllipseGreenToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseGreenToolStripMenuItem.Text = "Green"
        '
        'EllipseBlueToolStripMenuItem
        '
        Me.EllipseBlueToolStripMenuItem.Name = "EllipseBlueToolStripMenuItem"
        Me.EllipseBlueToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseBlueToolStripMenuItem.Text = "Blue"
        '
        'EllipseYellowToolStripMenuItem
        '
        Me.EllipseYellowToolStripMenuItem.Name = "EllipseYellowToolStripMenuItem"
        Me.EllipseYellowToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseYellowToolStripMenuItem.Text = "Yellow"
        '
        'EllipseCustomToolStripMenuItem
        '
        Me.EllipseCustomToolStripMenuItem.Name = "EllipseCustomToolStripMenuItem"
        Me.EllipseCustomToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.EllipseCustomToolStripMenuItem.Text = "Custom"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Enabled = False
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'PrintDocument1
        '
        '
        'app_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 34)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdprint)
        Me.Controls.Add(Me.cmdcopy)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.cmdnew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(272, 58)
        Me.Name = "app_main"
        Me.Text = "SnipIt"
        Me.ctxtmenuNew.ResumeLayout(False)
        Me.ctxtmenuCopy.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmenuEdit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdcopy As System.Windows.Forms.Button
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ctxtmenuNew As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MultiSnipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxtmenuPrint As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxtmenuCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxmenuEdit As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineRedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineYellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectRedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectYellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseWhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseRedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseGreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseBlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseYellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EllipseCustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents LineCustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RectCustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
