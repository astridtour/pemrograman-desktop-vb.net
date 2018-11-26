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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNoAnggota = New System.Windows.Forms.TextBox()
        Me.TxtJudulBuku = New System.Windows.Forms.TextBox()
        Me.TxtNmAnggota = New System.Windows.Forms.TextBox()
        Me.TxtNoBuku = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Anggota :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Buku :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Anggota :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Judul Buku :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tanggal Peminjaman :"
        '
        'TxtNoAnggota
        '
        Me.TxtNoAnggota.Location = New System.Drawing.Point(194, 7)
        Me.TxtNoAnggota.Name = "TxtNoAnggota"
        Me.TxtNoAnggota.Size = New System.Drawing.Size(181, 22)
        Me.TxtNoAnggota.TabIndex = 5
        '
        'TxtJudulBuku
        '
        Me.TxtJudulBuku.Location = New System.Drawing.Point(194, 142)
        Me.TxtJudulBuku.Name = "TxtJudulBuku"
        Me.TxtJudulBuku.Size = New System.Drawing.Size(181, 22)
        Me.TxtJudulBuku.TabIndex = 7
        '
        'TxtNmAnggota
        '
        Me.TxtNmAnggota.Location = New System.Drawing.Point(194, 91)
        Me.TxtNmAnggota.Name = "TxtNmAnggota"
        Me.TxtNmAnggota.Size = New System.Drawing.Size(181, 22)
        Me.TxtNmAnggota.TabIndex = 8
        '
        'TxtNoBuku
        '
        Me.TxtNoBuku.Location = New System.Drawing.Point(194, 48)
        Me.TxtNoBuku.Name = "TxtNoBuku"
        Me.TxtNoBuku.Size = New System.Drawing.Size(181, 22)
        Me.TxtNoBuku.TabIndex = 9
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 190)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 22)
        Me.DateTimePicker1.TabIndex = 10
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(15, 254)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(91, 41)
        Me.BtnProses.TabIndex = 11
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'BtnTutup
        '
        Me.BtnTutup.Location = New System.Drawing.Point(284, 254)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(91, 41)
        Me.BtnTutup.TabIndex = 12
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(148, 254)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(91, 41)
        Me.BtnBatal.TabIndex = 13
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 307)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtNoBuku)
        Me.Controls.Add(Me.TxtNmAnggota)
        Me.Controls.Add(Me.TxtJudulBuku)
        Me.Controls.Add(Me.TxtNoAnggota)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "PEMINJAMAN BUKU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNoAnggota As System.Windows.Forms.TextBox
    Friend WithEvents TxtJudulBuku As System.Windows.Forms.TextBox
    Friend WithEvents TxtNmAnggota As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoBuku As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button

End Class
