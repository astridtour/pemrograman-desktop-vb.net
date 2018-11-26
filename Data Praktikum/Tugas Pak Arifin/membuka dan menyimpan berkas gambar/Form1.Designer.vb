<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.OPDBerkas = New System.Windows.Forms.OpenFileDialog()
        Me.SFDBerkas = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SubExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubOne = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubTwo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubThree = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubFour = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubFive = New System.Windows.Forms.ToolStripMenuItem()
        Me.PICGambar = New System.Windows.Forms.PictureBox()
        Me.LblInfoBerkas = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PICGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OPDBerkas
        '
        Me.OPDBerkas.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFile, Me.MnSize})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnFile
        '
        Me.mnFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubOpenFile, Me.SubSaveFile, Me.SubClear, Me.ToolStripSeparator1, Me.SubExit})
        Me.mnFile.Name = "mnFile"
        Me.mnFile.Size = New System.Drawing.Size(44, 24)
        Me.mnFile.Text = "&File"
        '
        'SubOpenFile
        '
        Me.SubOpenFile.Name = "SubOpenFile"
        Me.SubOpenFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.SubOpenFile.Size = New System.Drawing.Size(213, 24)
        Me.SubOpenFile.Text = "Open Image"
        '
        'SubSaveFile
        '
        Me.SubSaveFile.Name = "SubSaveFile"
        Me.SubSaveFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SubSaveFile.Size = New System.Drawing.Size(213, 24)
        Me.SubSaveFile.Text = "Save Image"
        '
        'SubClear
        '
        Me.SubClear.Name = "SubClear"
        Me.SubClear.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.SubClear.Size = New System.Drawing.Size(213, 24)
        Me.SubClear.Text = "ClearImage"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'SubExit
        '
        Me.SubExit.Name = "SubExit"
        Me.SubExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.SubExit.Size = New System.Drawing.Size(213, 24)
        Me.SubExit.Text = "Exit"
        '
        'MnSize
        '
        Me.MnSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubOne, Me.SubTwo, Me.SubThree, Me.SubFour, Me.SubFive})
        Me.MnSize.Name = "MnSize"
        Me.MnSize.Size = New System.Drawing.Size(91, 24)
        Me.MnSize.Text = "&Size Mode"
        '
        'SubOne
        '
        Me.SubOne.Name = "SubOne"
        Me.SubOne.Size = New System.Drawing.Size(141, 24)
        Me.SubOne.Text = "Center"
        '
        'SubTwo
        '
        Me.SubTwo.Name = "SubTwo"
        Me.SubTwo.Size = New System.Drawing.Size(141, 24)
        Me.SubTwo.Text = "Auto Size"
        '
        'SubThree
        '
        Me.SubThree.Name = "SubThree"
        Me.SubThree.Size = New System.Drawing.Size(141, 24)
        Me.SubThree.Text = "strech"
        '
        'SubFour
        '
        Me.SubFour.Name = "SubFour"
        Me.SubFour.Size = New System.Drawing.Size(141, 24)
        Me.SubFour.Text = "Normal"
        '
        'SubFive
        '
        Me.SubFive.Name = "SubFive"
        Me.SubFive.Size = New System.Drawing.Size(141, 24)
        Me.SubFive.Text = "Zoom"
        '
        'PICGambar
        '
        Me.PICGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PICGambar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PICGambar.Location = New System.Drawing.Point(0, 28)
        Me.PICGambar.Name = "PICGambar"
        Me.PICGambar.Size = New System.Drawing.Size(820, 381)
        Me.PICGambar.TabIndex = 1
        Me.PICGambar.TabStop = False
        '
        'LblInfoBerkas
        '
        Me.LblInfoBerkas.AutoSize = True
        Me.LblInfoBerkas.Location = New System.Drawing.Point(12, 383)
        Me.LblInfoBerkas.Name = "LblInfoBerkas"
        Me.LblInfoBerkas.Size = New System.Drawing.Size(42, 17)
        Me.LblInfoBerkas.TabIndex = 2
        Me.LblInfoBerkas.Text = "None"
        Me.LblInfoBerkas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 409)
        Me.Controls.Add(Me.LblInfoBerkas)
        Me.Controls.Add(Me.PICGambar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Membuka dan menyimpan berkas Gambar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PICGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OPDBerkas As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFDBerkas As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubSaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SubExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubOne As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubTwo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubThree As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubFour As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubFive As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PICGambar As System.Windows.Forms.PictureBox
    Friend WithEvents LblInfoBerkas As System.Windows.Forms.Label

End Class
