Public Class Form1
    Dim A, B As Integer
    'contoh prosedur function
    Function Tambah(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer
        x = a + b
        Return x
    End Function

    Function Kali(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer
        x = a * b
        Return x
    End Function

    Function Kurang(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim x As Integer
        x = a - b
        Return x
    End Function

    Function Bagi(ByVal a As Integer, ByVal b As Integer) As Single
        Dim x As Single
        x = a / b
        Return x
    End Function
    'contoh prosedur sub
    Sub Bersih()
        txt1.Clear()
        txt6.Clear()
        txt5.Clear()
        txt4.Clear()
        txt3.Clear()
        txt2.Clear()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Bersih() 'atau Call Bersih
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Bersih() 'memanggil prosedur sub Bersih
        txt1.Focus() 'menempatkan cursor ke isian Nilai a
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        'memvalidasi nilai a dan b
        If Not (IsNumeric(txt1.Text) And IsNumeric(txt2.Text)) Then
            Exit Sub ' keluar dari prosedur event Button2_Click
        End If
        'mengoperasikan nilai a dan b dengan memanggil prosedur function
        Try
            A = CInt(txt1.Text) : B = CInt(txt2.Text)
            'menampilkan hasil operasi  penjumlahan
            txt5.Text = Tambah(A, B)
            'menampilkan hasil operasi perkalian
            txt4.Text = Kali(A, B)
            'menampilkan hasil operasi pembagian
            txt3.Text = Bagi(A, B)
            'menampilkan hasil operasi pengurangan
            txt2.Text = Kurang(A, B)
        Catch ex As Exception
            'menampilkan  pesan kesalahan dan keluar dari prosedur event 
            MsgBox(ex.Message, MsgBoxStyle.Information, "Komentar")
            Exit Sub
        End Try
     
    End Sub

End Class

