Public Class Latihanvb61
    'mendefinisikan variabel nilai global nama sebagai array
    'dan jumlah data
    Dim nama(20) As String
    Dim n As Integer

    Private Sub Latihanvb61_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'saat from dipanggil jumlah array diisi dengan nol
        n = 0

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        'menambahkan nomor array dan memindahkan isi txt1
        'ke array nama
        n = n + 1
        nama(n) = Trim(txt1.Text)

        'mengosongkan isi txt1 dan menaruh kursor ke txt1
        txt1.Text = " "
        txt1.Focus()

    End Sub

    Private Sub BtnTampil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTampil.Click
        'menampilkan semua isi array nama
        Lst1.ClearSelected()
        For i = 1 To n
            'ListBox'.additem(nama(i))
        Next i

    End Sub
End Class
