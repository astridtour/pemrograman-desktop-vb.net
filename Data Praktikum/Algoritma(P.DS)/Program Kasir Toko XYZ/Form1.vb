Public Class Form1
    Sub simpan()
        Dim file = CmbKodeBarang.Text.ToString
        Try
            My.Computer.FileSystem.WriteAllText(file, CmbKodeBarang.Text, False)
        Catch ex As Exception
            MsgBox("gagal menyimpan file!", MsgBoxStyle.Critical)
            clear()
        End Try
        MsgBox("berhasil menyimpan", MsgBoxStyle.Information)
    End Sub

    Sub clear()
        CmbKodeBarang.Text = "Pilih Kode Barang"
        TxtNamaBarang.Text = " "
        TxtJumlahBarang.Text = " "
        TxtHargaBarang.Text = " "
        TxtTotalbarang.Text = " "
        TxtDisccount.Text = " "
        TxtUangDibayar.Text = " "
        TxtKembali.Text = " "
        CmbKodeBarang.Focus()
    End Sub
    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        CmbKodeBarang.Text = "Pilih Kode Barang"
        TxtNamaBarang.Text = " "
        TxtJumlahBarang.Text = " "
        TxtHargaBarang.Text = " "
        TxtTotalbarang.Text = " "
        TxtDisccount.Text = " "
        TxtUangDibayar.Text = " "
        TxtKembali.Text = " "
        CmbKodeBarang.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With SFDFile
            .Title = "Simpan Berkas "
            .Filter = "Txt files(*.Txt)|"
            .FileName = " "
        End With

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim SFD As New SaveFileDialog
        SFD.Filter = "Txt files(*.Txt)|"
        SFD.Title = "Simpan Berkas "
        SFD.ShowDialog()
        Call simpan()

    End Sub

    Private Sub CmbKodeBarang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKodeBarang.SelectedIndexChanged
        With TxtNamaBarang
            If CmbKodeBarang.Text = "K001" Then
                TxtNamaBarang.Text = "Gula Putih"
            ElseIf CmbKodeBarang.Text = "K002" Then
                TxtNamaBarang.Text = " Sabun Mandi"
            ElseIf CmbKodeBarang.Text = "K003" Then
                TxtNamaBarang.Text = "Tepung Roti"
            ElseIf CmbKodeBarang.Text = "K004" Then
                TxtNamaBarang.Text = "Sirup ABC"
            ElseIf CmbKodeBarang.Text = "K005" Then
                TxtNamaBarang.Text = "Roti Srikaya"
            ElseIf CmbKodeBarang.Text = "K006" Then
                TxtNamaBarang.Text = "TimTam"
            ElseIf CmbKodeBarang.Text = "K007" Then
                TxtNamaBarang.Text = "Lasegar"
            ElseIf CmbKodeBarang.Text = "K008" Then
                TxtNamaBarang.Text = "Mie Lidih"
            ElseIf CmbKodeBarang.Text = "K009" Then
                TxtNamaBarang.Text = "Kecap Bango"
            ElseIf CmbKodeBarang.Text = "K010" Then
                TxtNamaBarang.Text = "GoodTime"
            End If

        End With

        With TxtHargaBarang
            If TxtNamaBarang.Text = "Gula Putih" Then
                TxtHargaBarang.Text = "160000"
            ElseIf TxtNamaBarang.Text = " Sabun Mandi" Then
                TxtHargaBarang.Text = "30000"
            ElseIf TxtNamaBarang.Text = "Tepung Roti" Then
                TxtHargaBarang.Text = "80000"
            ElseIf TxtNamaBarang.Text = "Sirup ABC" Then
                TxtHargaBarang.Text = "135000"
            ElseIf TxtNamaBarang.Text = "Roti Srikaya" Then
                TxtHargaBarang.Text = "175000"
            ElseIf TxtNamaBarang.Text = "TimTam" Then
                TxtHargaBarang.Text = "105000"
            ElseIf TxtNamaBarang.Text = "Lasegar" Then
                TxtHargaBarang.Text = "215000"
            ElseIf TxtNamaBarang.Text = "Mie Lidih" Then
                TxtHargaBarang.Text = "55000"
            ElseIf TxtNamaBarang.Text = "Kecap Bango" Then
                TxtHargaBarang.Text = "305000"
            ElseIf TxtNamaBarang.Text = "GoodTime" Then
                TxtHargaBarang.Text = "105000"
            End If
        End With
    End Sub

    Private Sub TxtJumlahBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtJumlahBarang.TextChanged
        If Not IsNumeric(TxtJumlahBarang.Text) Then MsgBox("Apaan Nech....!!!! Masukan Jumlah Barang ...??!!")
        With TxtTotalbarang
            TxtTotalbarang.Text = (Val(TxtHargaBarang.Text) * (TxtJumlahBarang.Text))

        End With

        With TxtDisccount
            If TxtTotalbarang.Text > 1000000 Then
                TxtDisccount.Text = (Val(TxtTotalbarang.Text) * 0.05)
            ElseIf TxtTotalbarang.Text > 2000000 Then
                TxtDisccount.Text = (Val(TxtTotalbarang.Text) * 0.1)
            ElseIf TxtTotalbarang.Text < 1000000 Then
                TxtDisccount.Text = "0"
            End If
        End With

        With TxtTotalDibayar
            TxtTotalDibayar.Text = (Val(TxtTotalbarang.Text) - (TxtDisccount.Text))
        End With
    End Sub
    Sub opsional()
        TxtUangDibayar.Text = " "

    End Sub

    Private Sub TxtUangDibayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUangDibayar.TextChanged
        With TxtKembali
            TxtKembali.Text = (Val(TxtUangDibayar.Text) - (TxtTotalDibayar.Text))
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Kode Barang    " + CmbKodeBarang.SelectedItem + "   Nama Barang    " + TxtNamaBarang.Text + " Jumlah Barang  " + TxtJumlahBarang.Text + " Harga Barang Rp. " + TxtHargaBarang.Text + " Total Harga Rp. " + TxtTotalbarang.Text + " Discount Rp. " + TxtDisccount.Text + " Total Di Bayar Rp. " + TxtTotalDibayar.Text + " Uang Di Bayar Rp. " + TxtUangDibayar.Text + " Kembali Rp. " + TxtKembali.Text)
    End Sub
End Class
