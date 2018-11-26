<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUKUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMINJAMANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANGGOTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TUTUPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.BUKUToolStripMenuItem, Me.PEMINJAMANToolStripMenuItem, Me.ANGGOTAToolStripMenuItem, Me.TUTUPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'BUKUToolStripMenuItem
        '
        Me.BUKUToolStripMenuItem.Name = "BUKUToolStripMenuItem"
        Me.BUKUToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.BUKUToolStripMenuItem.Text = "BUKU"
        '
        'PEMINJAMANToolStripMenuItem
        '
        Me.PEMINJAMANToolStripMenuItem.Name = "PEMINJAMANToolStripMenuItem"
        Me.PEMINJAMANToolStripMenuItem.Size = New System.Drawing.Size(114, 24)
        Me.PEMINJAMANToolStripMenuItem.Text = "PEMINJAMAN"
        '
        'ANGGOTAToolStripMenuItem
        '
        Me.ANGGOTAToolStripMenuItem.Name = "ANGGOTAToolStripMenuItem"
        Me.ANGGOTAToolStripMenuItem.Size = New System.Drawing.Size(91, 24)
        Me.ANGGOTAToolStripMenuItem.Text = "ANGGOTA"
        '
        'TUTUPToolStripMenuItem
        '
        Me.TUTUPToolStripMenuItem.Name = "TUTUPToolStripMenuItem"
        Me.TUTUPToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.TUTUPToolStripMenuItem.Text = "TUTUP"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.LOGOUTToolStripMenuItem.Text = "LOGOUT"
        '
        'KELUARToolStripMenuItem
        '
        Me.KELUARToolStripMenuItem.Name = "KELUARToolStripMenuItem"
        Me.KELUARToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.KELUARToolStripMenuItem.Text = "KELUAR"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 255)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.Text = "MENU"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUKUToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMINJAMANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANGGOTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TUTUPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
