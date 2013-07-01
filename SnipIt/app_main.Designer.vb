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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ctxtmenuNew.SuspendLayout()
        Me.ctxtmenuCopy.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ctxtmenuNew.Size = New System.Drawing.Size(153, 98)
        '
        'MultiSnipToolStripMenuItem
        '
        Me.MultiSnipToolStripMenuItem.Name = "MultiSnipToolStripMenuItem"
        Me.MultiSnipToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MultiSnipToolStripMenuItem.Text = "MultiSnip"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'AutoClearToolStripMenuItem
        '
        Me.AutoClearToolStripMenuItem.Name = "AutoClearToolStripMenuItem"
        Me.AutoClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.ctxtmenuCopy.Size = New System.Drawing.Size(102, 26)
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.PictureBox1.Location = New System.Drawing.Point(3, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 47)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
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
End Class
