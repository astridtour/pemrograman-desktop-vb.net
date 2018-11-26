<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KELUARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.master = New System.Windows.Forms.ToolStripMenuItem()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANGGOTAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BUKUToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.transaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEMINJAMANToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENGEMBALIANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.laporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.master, Me.transaksi, Me.laporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.LOGOUTToolStripMenuItem, Me.KELUARToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
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
        'master
        '
        Me.master.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINToolStripMenuItem, Me.ANGGOTAToolStripMenuItem1, Me.BUKUToolStripMenuItem1})
        Me.master.Name = "master"
        Me.master.Size = New System.Drawing.Size(77, 24)
        Me.master.Text = "MASTER"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'ANGGOTAToolStripMenuItem1
        '
        Me.ANGGOTAToolStripMenuItem1.Name = "ANGGOTAToolStripMenuItem1"
        Me.ANGGOTAToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.ANGGOTAToolStripMenuItem1.Text = "ANGGOTA"
        '
        'BUKUToolStripMenuItem1
        '
        Me.BUKUToolStripMenuItem1.Name = "BUKUToolStripMenuItem1"
        Me.BUKUToolStripMenuItem1.Size = New System.Drawing.Size(152, 24)
        Me.BUKUToolStripMenuItem1.Text = "BUKU"
        '
        'transaksi
        '
        Me.transaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PEMINJAMANToolStripMenuItem1, Me.PENGEMBALIANToolStripMenuItem})
        Me.transaksi.Name = "transaksi"
        Me.transaksi.Size = New System.Drawing.Size(98, 24)
        Me.transaksi.Text = "TRANSAKSI"
        '
        'PEMINJAMANToolStripMenuItem1
        '
        Me.PEMINJAMANToolStripMenuItem1.Name = "PEMINJAMANToolStripMenuItem1"
        Me.PEMINJAMANToolStripMenuItem1.Size = New System.Drawing.Size(187, 24)
        Me.PEMINJAMANToolStripMenuItem1.Text = "PEMINJAMAN"
        '
        'PENGEMBALIANToolStripMenuItem
        '
        Me.PENGEMBALIANToolStripMenuItem.Name = "PENGEMBALIANToolStripMenuItem"
        Me.PENGEMBALIANToolStripMenuItem.Size = New System.Drawing.Size(187, 24)
        Me.PENGEMBALIANToolStripMenuItem.Text = "PENGEMBALIAN"
        '
        'laporan
        '
        Me.laporan.Name = "laporan"
        Me.laporan.Size = New System.Drawing.Size(87, 24)
        Me.laporan.Text = "LAPORAN"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 164)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuUtama"
        Me.Text = "MENU UTAMA APLIKASI PERPUSTAKAAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KELUARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents master As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANGGOTAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BUKUToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents transaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEMINJAMANToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENGEMBALIANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents laporan As System.Windows.Forms.ToolStripMenuItem

End Class
