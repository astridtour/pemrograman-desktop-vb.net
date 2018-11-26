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
        Me.LblHasilOperasi = New System.Windows.Forms.Label()
        Me.txtNilai1 = New System.Windows.Forms.TextBox()
        Me.txtNilai2 = New System.Windows.Forms.TextBox()
        Me.BtnPangkat = New System.Windows.Forms.Button()
        Me.BtnBagiBulat = New System.Windows.Forms.Button()
        Me.BtnBagiPecahan = New System.Windows.Forms.Button()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnJumlah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnSisaBagi = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Ke-1?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Ke-2?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 33)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil Operasi"
        '
        'LblHasilOperasi
        '
        Me.LblHasilOperasi.BackColor = System.Drawing.Color.Transparent
        Me.LblHasilOperasi.Location = New System.Drawing.Point(25, 261)
        Me.LblHasilOperasi.Name = "LblHasilOperasi"
        Me.LblHasilOperasi.Size = New System.Drawing.Size(1046, 56)
        Me.LblHasilOperasi.TabIndex = 3
        Me.LblHasilOperasi.Text = "999,99"
        Me.LblHasilOperasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNilai1
        '
        Me.txtNilai1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNilai1.Location = New System.Drawing.Point(223, 35)
        Me.txtNilai1.Name = "txtNilai1"
        Me.txtNilai1.Size = New System.Drawing.Size(100, 40)
        Me.txtNilai1.TabIndex = 5
        '
        'txtNilai2
        '
        Me.txtNilai2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNilai2.Location = New System.Drawing.Point(223, 94)
        Me.txtNilai2.Name = "txtNilai2"
        Me.txtNilai2.Size = New System.Drawing.Size(100, 40)
        Me.txtNilai2.TabIndex = 6
        '
        'BtnPangkat
        '
        Me.BtnPangkat.Location = New System.Drawing.Point(380, 36)
        Me.BtnPangkat.Name = "BtnPangkat"
        Me.BtnPangkat.Size = New System.Drawing.Size(275, 45)
        Me.BtnPangkat.TabIndex = 7
        Me.BtnPangkat.Text = "Pemangkatan"
        Me.BtnPangkat.UseVisualStyleBackColor = True
        '
        'BtnBagiBulat
        '
        Me.BtnBagiBulat.Location = New System.Drawing.Point(380, 75)
        Me.BtnBagiBulat.Name = "BtnBagiBulat"
        Me.BtnBagiBulat.Size = New System.Drawing.Size(275, 42)
        Me.BtnBagiBulat.TabIndex = 8
        Me.BtnBagiBulat.Text = "Pembagian Bulat"
        Me.BtnBagiBulat.UseVisualStyleBackColor = True
        '
        'BtnBagiPecahan
        '
        Me.BtnBagiPecahan.Location = New System.Drawing.Point(380, 113)
        Me.BtnBagiPecahan.Name = "BtnBagiPecahan"
        Me.BtnBagiPecahan.Size = New System.Drawing.Size(275, 43)
        Me.BtnBagiPecahan.TabIndex = 9
        Me.BtnBagiPecahan.Text = "Pembagian Pecahan"
        Me.BtnBagiPecahan.UseVisualStyleBackColor = True
        '
        'BtnKali
        '
        Me.BtnKali.Location = New System.Drawing.Point(833, 36)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(238, 45)
        Me.BtnKali.TabIndex = 10
        Me.BtnKali.Text = "Perkalian"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnJumlah
        '
        Me.BtnJumlah.Location = New System.Drawing.Point(833, 75)
        Me.BtnJumlah.Name = "BtnJumlah"
        Me.BtnJumlah.Size = New System.Drawing.Size(238, 42)
        Me.BtnJumlah.TabIndex = 11
        Me.BtnJumlah.Text = "Penjumlahan"
        Me.BtnJumlah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Location = New System.Drawing.Point(833, 113)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(238, 43)
        Me.BtnKurang.TabIndex = 12
        Me.BtnKurang.Text = "Pengurangan"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnSisaBagi
        '
        Me.BtnSisaBagi.Location = New System.Drawing.Point(380, 151)
        Me.BtnSisaBagi.Name = "BtnSisaBagi"
        Me.BtnSisaBagi.Size = New System.Drawing.Size(691, 50)
        Me.BtnSisaBagi.TabIndex = 13
        Me.BtnSisaBagi.Text = "Modulus"
        Me.BtnSisaBagi.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(380, 198)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(275, 46)
        Me.BtnHapus.TabIndex = 14
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(833, 198)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(238, 46)
        Me.BtnKeluar.TabIndex = 15
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 379)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSisaBagi)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnJumlah)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.BtnBagiPecahan)
        Me.Controls.Add(Me.BtnBagiBulat)
        Me.Controls.Add(Me.BtnPangkat)
        Me.Controls.Add(Me.txtNilai2)
        Me.Controls.Add(Me.txtNilai1)
        Me.Controls.Add(Me.LblHasilOperasi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "Form1"
        Me.Text = "Hasil Operasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblHasilOperasi As System.Windows.Forms.Label
    Friend WithEvents txtNilai1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNilai2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnPangkat As System.Windows.Forms.Button
    Friend WithEvents BtnBagiBulat As System.Windows.Forms.Button
    Friend WithEvents BtnBagiPecahan As System.Windows.Forms.Button
    Friend WithEvents BtnKali As System.Windows.Forms.Button
    Friend WithEvents BtnJumlah As System.Windows.Forms.Button
    Friend WithEvents BtnKurang As System.Windows.Forms.Button
    Friend WithEvents BtnSisaBagi As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button

End Class
