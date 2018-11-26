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
        Me.components = New System.ComponentModel.Container
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnTambahBerkas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnHapusSemuaBerkas = New System.Windows.Forms.ToolStripMenuItem
        Me.mnUbahUkuran = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnTutupAplikasi = New System.Windows.Forms.ToolStripMenuItem
        Me.FLPgambar = New System.Windows.Forms.FlowLayoutPanel
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnTambahBerkas, Me.mnHapusSemuaBerkas, Me.mnUbahUkuran, Me.ToolStripSeparator1, Me.mnTutupAplikasi})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(192, 98)
        '
        'mnTambahBerkas
        '
        Me.mnTambahBerkas.Name = "mnTambahBerkas"
        Me.mnTambahBerkas.Size = New System.Drawing.Size(191, 22)
        Me.mnTambahBerkas.Text = "Tambahkan Item Baru"
        '
        'mnHapusSemuaBerkas
        '
        Me.mnHapusSemuaBerkas.Name = "mnHapusSemuaBerkas"
        Me.mnHapusSemuaBerkas.Size = New System.Drawing.Size(191, 22)
        Me.mnHapusSemuaBerkas.Text = "Hapus Semua Item"
        '
        'mnUbahUkuran
        '
        Me.mnUbahUkuran.Name = "mnUbahUkuran"
        Me.mnUbahUkuran.Size = New System.Drawing.Size(191, 22)
        Me.mnUbahUkuran.Text = "Ubah Ukuran"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(188, 6)
        '
        'mnTutupAplikasi
        '
        Me.mnTutupAplikasi.Name = "mnTutupAplikasi"
        Me.mnTutupAplikasi.Size = New System.Drawing.Size(191, 22)
        Me.mnTutupAplikasi.Text = "Tutup Aplikasi"
        '
        'FLPgambar
        '
        Me.FLPgambar.AllowDrop = True
        Me.FLPgambar.AutoScroll = True
        Me.FLPgambar.AutoSize = True
        Me.FLPgambar.ContextMenuStrip = Me.ContextMenuStrip1
        Me.FLPgambar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FLPgambar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.FLPgambar.Location = New System.Drawing.Point(0, 0)
        Me.FLPgambar.Name = "FLPgambar"
        Me.FLPgambar.Padding = New System.Windows.Forms.Padding(70, 20, 50, 20)
        Me.FLPgambar.Size = New System.Drawing.Size(874, 490)
        Me.FLPgambar.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 490)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.FLPgambar)
        Me.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Image Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnTambahBerkas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnHapusSemuaBerkas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnTutupAplikasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnUbahUkuran As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FLPgambar As System.Windows.Forms.FlowLayoutPanel

End Class
