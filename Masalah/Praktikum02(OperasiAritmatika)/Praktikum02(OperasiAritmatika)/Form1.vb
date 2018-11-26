

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'memposisikan from ditengah layar
        Me.CenterToScreen()

        'membatalkan tombol kontrol fromMe.ContolBox = False

        'menentukan urutan fokus kontrol textbox txtnilai1 dan txtnilai2 txtNilai1.TabIndex = 0 txtNilai2.TabIndex=1

        'mengatur label LbLhasiloperasi
        With LblHasilOperasi
            .AutoSize = True
            .BackColor = Color.Transparent
            .BorderStyle = BorderStyle.None
            .Font = New Font("Cambria", 36, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleLeft
        End With
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        'mengosongkan nilai proferti text masing - masing kontrol texbox
        txtNilai1.Clear()
        txtNilai2.Clear()
        'mengosongkan nilai proferti text masing - masing kontrol Label
        LblHasilOperasi.Text = "999,99"
        'mengarahkan cursor ke kontrol textBox txtNilai1
        txtNilai1.Focus()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        'menutup from sekaligus menutup aplikasi
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub BtnKali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKali.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi perkalian sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text =
            Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) *
            Conversion.Val(txtNilai2.Text), "#,#"), ",", ".")
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Perkalian Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnPangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPangkat.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi pemangkatan sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text =
            Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) ^
            Conversion.Val(txtNilai2.Text), "#,#"), ",", ".")
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Pemangkatan Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnBagiBulat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBagiBulat.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi pembagian pecahan sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text =
            Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) \
            Conversion.Val(txtNilai2.Text), "#,#"), ",", ".")
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Pembagian Bulat Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'If LblHasilOperasi.Text = 0 Then
        '  CStr "0"
        'End If
    End Sub

    Private Sub BtnBagiPecahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBagiPecahan.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi pembagian pecahan sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text =
            Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) /
            Conversion.Val(txtNilai2.Text), "#0.00"), ".", ",")
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Pembagian Pecahan Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnJumlah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnJumlah.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi penjumlahan sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text =
            Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) +
            Conversion.Val(txtNilai2.Text), "#,#"), ",", ".")
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Penjumlahan Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKurang.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
            Try
                'menampilkan hasil operasi pengurangan sbg nilai Text
                'kontrol TextBox txtHasilOperasi
                LblHasilOperasi.Text =
                Strings.Replace(Strings.Format(Conversion.Val(txtNilai1.Text) -
                Conversion.Val(txtNilai2.Text), "#,#"), ",", ".")
            Catch ex As Exception
                'menampilkan dialog pesan kesalahan
                MessageBox.Show("Operasi Pengurangan Gagal", "Pesan", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
    End Sub

    Private Sub BtnSisaBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSisaBagi.Click
        'memvalidasi masukan data
        If Strings.Trim(txtNilai1.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Pertama", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai1.Focus()
            Exit Sub
        End If
        If Strings.Trim(txtNilai2.Text) = String.Empty Then
            MessageBox.Show("Isikan Nilai Kedua", "Peringatan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNilai2.Focus()
            Exit Sub
        End If
        Try
            'menampilkan hasil operasi modulus sbg nilai Text
            'kontrol TextBox txtHasilOperasi
            LblHasilOperasi.Text = CStr(Conversion.Val(txtNilai1.Text) Mod
            Conversion.Val(txtNilai2.Text))
        Catch ex As Exception
            'menampilkan dialog pesan kesalahan
            MessageBox.Show("Operasi Modulus Gagal", "Pesan", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

