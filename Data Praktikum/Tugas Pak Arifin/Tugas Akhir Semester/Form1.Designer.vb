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
        Me.MnFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SubTambahGambar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubUbahUkuranGambar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubHapusGambarSemua = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubTutup = New System.Windows.Forms.ToolStripMenuItem()
        Me.OPDBerkas = New System.Windows.Forms.OpenFileDialog()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MnFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnFile
        '
        Me.MnFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubTambahGambar, Me.SubUbahUkuranGambar, Me.SubHapusGambarSemua, Me.SubTutup})
        Me.MnFile.Name = "MnFile"
        Me.MnFile.Size = New System.Drawing.Size(247, 122)
        Me.MnFile.Text = "&File"
        '
        'SubTambahGambar
        '
        Me.SubTambahGambar.Name = "SubTambahGambar"
        Me.SubTambahGambar.Size = New System.Drawing.Size(246, 24)
        Me.SubTambahGambar.Text = "Tambahkan Gambar Baru"
        '
        'SubUbahUkuranGambar
        '
        Me.SubUbahUkuranGambar.Name = "SubUbahUkuranGambar"
        Me.SubUbahUkuranGambar.Size = New System.Drawing.Size(246, 24)
        Me.SubUbahUkuranGambar.Text = "Ubah Ukura Gambar"
        '
        'SubHapusGambarSemua
        '
        Me.SubHapusGambarSemua.Name = "SubHapusGambarSemua"
        Me.SubHapusGambarSemua.Size = New System.Drawing.Size(246, 24)
        Me.SubHapusGambarSemua.Text = "Hapus Gambar"
        '
        'SubTutup
        '
        Me.SubTutup.Name = "SubTutup"
        Me.SubTutup.Size = New System.Drawing.Size(246, 24)
        Me.SubTutup.Text = "Tutup Aplikasi "
        '
        'OPDBerkas
        '
        Me.OPDBerkas.FileName = "OPDBerkas"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.ContextMenuStrip = Me.MnFile
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(808, 387)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 387)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Image View"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnFile.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MnFile As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SubTambahGambar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubUbahUkuranGambar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubHapusGambarSemua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubTutup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OPDBerkas As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel

End Class
