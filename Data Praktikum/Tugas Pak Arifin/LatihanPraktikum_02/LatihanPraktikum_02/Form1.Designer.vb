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
        Me.BtnPangkat = New System.Windows.Forms.Button()
        Me.BtnBagiBulat = New System.Windows.Forms.Button()
        Me.BtnBagiPecahan = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnJumlah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnSisaBagi = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbLHasilOperasi = New System.Windows.Forms.Label()
        Me.TxtNilai2 = New System.Windows.Forms.TextBox()
        Me.TxtNilai1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnPangkat
        '
        Me.BtnPangkat.Location = New System.Drawing.Point(429, 37)
        Me.BtnPangkat.Name = "BtnPangkat"
        Me.BtnPangkat.Size = New System.Drawing.Size(189, 53)
        Me.BtnPangkat.TabIndex = 0
        Me.BtnPangkat.Text = "Pemangkatan"
        Me.BtnPangkat.UseVisualStyleBackColor = True
        '
        'BtnBagiBulat
        '
        Me.BtnBagiBulat.Location = New System.Drawing.Point(429, 85)
        Me.BtnBagiBulat.Name = "BtnBagiBulat"
        Me.BtnBagiBulat.Size = New System.Drawing.Size(189, 52)
        Me.BtnBagiBulat.TabIndex = 1
        Me.BtnBagiBulat.Text = "Pembagian Bulat"
        Me.BtnBagiBulat.UseVisualStyleBackColor = True
        '
        'BtnBagiPecahan
        '
        Me.BtnBagiPecahan.Location = New System.Drawing.Point(429, 131)
        Me.BtnBagiPecahan.Name = "BtnBagiPecahan"
        Me.BtnBagiPecahan.Size = New System.Drawing.Size(189, 52)
        Me.BtnBagiPecahan.TabIndex = 2
        Me.BtnBagiPecahan.Text = "Pembagian Pecahan"
        Me.BtnBagiPecahan.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Location = New System.Drawing.Point(750, 37)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(189, 53)
        Me.BtnKali.TabIndex = 3
        Me.BtnKali.Text = "Perkalian"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnJumlah
        '
        Me.BtnJumlah.Location = New System.Drawing.Point(750, 85)
        Me.BtnJumlah.Name = "BtnJumlah"
        Me.BtnJumlah.Size = New System.Drawing.Size(189, 52)
        Me.BtnJumlah.TabIndex = 4
        Me.BtnJumlah.Text = "Penjumlahan"
        Me.BtnJumlah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Location = New System.Drawing.Point(750, 131)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(189, 52)
        Me.BtnKurang.TabIndex = 5
        Me.BtnKurang.Text = "Pengurangan"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnSisaBagi
        '
        Me.BtnSisaBagi.Location = New System.Drawing.Point(429, 179)
        Me.BtnSisaBagi.Name = "BtnSisaBagi"
        Me.BtnSisaBagi.Size = New System.Drawing.Size(510, 55)
        Me.BtnSisaBagi.TabIndex = 6
        Me.BtnSisaBagi.Text = "Modulus"
        Me.BtnSisaBagi.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(429, 230)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(116, 50)
        Me.BtnHapus.TabIndex = 7
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(828, 230)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(111, 50)
        Me.BtnKeluar.TabIndex = 8
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nilai Ke-1?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nilai Ke-2?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Hasil Operasi"
        '
        'LbLHasilOperasi
        '
        Me.LbLHasilOperasi.BackColor = System.Drawing.Color.Transparent
        Me.LbLHasilOperasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLHasilOperasi.Location = New System.Drawing.Point(13, 314)
        Me.LbLHasilOperasi.Name = "LbLHasilOperasi"
        Me.LbLHasilOperasi.Size = New System.Drawing.Size(926, 66)
        Me.LbLHasilOperasi.TabIndex = 19
        Me.LbLHasilOperasi.Text = "999,99"
        Me.LbLHasilOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNilai2
        '
        Me.TxtNilai2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNilai2.Location = New System.Drawing.Point(143, 97)
        Me.TxtNilai2.Name = "TxtNilai2"
        Me.TxtNilai2.Size = New System.Drawing.Size(100, 22)
        Me.TxtNilai2.TabIndex = 21
        '
        'TxtNilai1
        '
        Me.TxtNilai1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNilai1.Location = New System.Drawing.Point(143, 32)
        Me.TxtNilai1.Name = "TxtNilai1"
        Me.TxtNilai1.Size = New System.Drawing.Size(100, 22)
        Me.TxtNilai1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 538)
        Me.Controls.Add(Me.TxtNilai1)
        Me.Controls.Add(Me.TxtNilai2)
        Me.Controls.Add(Me.LbLHasilOperasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSisaBagi)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnJumlah)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnBagiPecahan)
        Me.Controls.Add(Me.BtnBagiBulat)
        Me.Controls.Add(Me.BtnPangkat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPangkat As System.Windows.Forms.Button
    Friend WithEvents BtnBagiBulat As System.Windows.Forms.Button
    Friend WithEvents BtnBagiPecahan As System.Windows.Forms.Button
    Friend WithEvents BtnKali As System.Windows.Forms.Button
    Friend WithEvents BtnJumlah As System.Windows.Forms.Button
    Friend WithEvents BtnKurang As System.Windows.Forms.Button
    Friend WithEvents BtnSisaBagi As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbLHasilOperasi As System.Windows.Forms.Label
    Friend WithEvents TxtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilai1 As System.Windows.Forms.TextBox

End Class
