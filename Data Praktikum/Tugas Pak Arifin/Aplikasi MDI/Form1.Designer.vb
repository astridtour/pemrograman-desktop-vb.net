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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnFILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.subFILE1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.subFILE2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPopup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsBaru = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsTutup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.mnPopup.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFILE})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnFILE
        '
        Me.mnFILE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subFILE1, Me.ToolStripSeparator1, Me.subFILE2})
        Me.mnFILE.Name = "mnFILE"
        Me.mnFILE.Size = New System.Drawing.Size(47, 24)
        Me.mnFILE.Text = "&FILE"
        '
        'subFILE1
        '
        Me.subFILE1.Name = "subFILE1"
        Me.subFILE1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.subFILE1.Size = New System.Drawing.Size(161, 24)
        Me.subFILE1.Text = "New"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'subFILE2
        '
        Me.subFILE2.Name = "subFILE2"
        Me.subFILE2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.subFILE2.Size = New System.Drawing.Size(161, 24)
        Me.subFILE2.Text = "Exit"
        '
        'mnPopup
        '
        Me.mnPopup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsBaru, Me.ToolStripSeparator2, Me.cmsTutup})
        Me.mnPopup.Name = "mnPopup"
        Me.mnPopup.Size = New System.Drawing.Size(220, 54)
        '
        'cmsBaru
        '
        Me.cmsBaru.Name = "cmsBaru"
        Me.cmsBaru.Size = New System.Drawing.Size(219, 22)
        Me.cmsBaru.Text = "Tambahkan Dokumen Baru"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'cmsTutup
        '
        Me.cmsTutup.Name = "cmsTutup"
        Me.cmsTutup.Size = New System.Drawing.Size(219, 22)
        Me.cmsTutup.Text = "Tutup Aplikasi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 502)
        Me.ContextMenuStrip = Me.mnPopup
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Mutiple Docoument Interface"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mnPopup.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFILE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subFILE1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents subFILE2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnPopup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsBaru As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsTutup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
