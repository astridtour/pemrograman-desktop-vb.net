Public Class Form2
    Dim X As Long = 0

    Private Sub btnGENERATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERATE.Click
        REM menginisialisasi nilai baru ke variabel X
        If Not (IsNumeric(txtNOMINAL.Text)) Then
            LbL100Ribu.Text = String.Empty
            LbL50Ribu.Text = String.Empty
            LbL20Ribu.Text = String.Empty
            LbL10Ribu.Text = String.Empty
            LbL5Ribu.Text = String.Empty
            LbL2Ribu.Text = String.Empty
            LbLRibu.Text = String.Empty
            LbL5Ratus.Text = String.Empty
            LbL2Ratus.Text = String.Empty
            LbLRatus.Text = String.Empty
            Exit Sub
        Else
            X = CLng(txtNOMINAL.Text)
        End If
        Dim ju0 As Integer = 0 REM variabel jumlah besaran uang Seratus Ribuan
        Dim ju1 As Integer = 0 REM variabel jumlah besaran uang Lima puluh Ribuan
        Dim ju2 As Integer = 0 REM variabel jumlah besaran uang Dua puluh Ribuan
        Dim ju3 As Integer = 0 REM variabel jumlah besaran uang Sepuluh Ribuan
        Dim ju4 As Integer = 0 REM variabel jumlah besaran uang Lima Ribuan
        Dim ju5 As Integer = 0 REM variabel jumlah besaran uang Dua Ribuan
        Dim ju6 As Integer = 0 REM variabel jumlah besaran uang Seribuan
        Dim ju7 As Integer = 0 REM variabel jumlah besaran uang Lima Ratusan
        Dim ju8 As Integer = 0 REM variabel jumlah besaran uang Dua Ratuan
        Dim ju9 As Integer = 0 REM variabel jumlah besaran uang Seratusan
        Dim SISA As Integer = 0
        REM mengkonversi nominal uang ke masing-masing besaran uang
        Do While X >= 100
            Select Case X
                Case Is >= 100000 : ju0 += 1 : X -= 100000
                Case Is >= 50000 : ju1 += 1 : X -= 50000
                Case Is >= 20000 : ju2 = 1 : X -= 20000
                Case Is >= 10000 : ju3 += 1 : X -= 10000
                Case Is >= 5000 : ju4 += 1 : X -= 5000
                Case Is >= 2000 : ju5 += 1 : X -= 2000
                Case Is >= 1000 : ju6 += 1 : X -= 1000
                Case Is >= 500 : ju7 += 1 : X -= 500
                Case Is >= 200 : ju8 += 1 : X -= 200
                Case Is >= 100 : ju9 += 1 : X -= 100
            End Select
        Loop
        REM menampilkan Hasil konversi 
        LbL100Ribu.Text = CStr(ju0)
        LbL50Ribu.Text = CStr(ju1)
        LbL20Ribu.Text = CStr(ju2)
        LbL10Ribu.Text = CStr(ju3)
        LbL5Ribu.Text = CStr(ju4)
        LbL2Ribu.Text = CStr(ju5)
        LbLRibu.Text = CStr(ju6)
        LbL5Ratus.Text = CStr(ju7)
        LbL2Ratus.Text = CStr(ju8)
        LbLRatus.Text = CStr(ju9)
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Me.Form2_Load(sender, e) : txtNOMINAL.Focus()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNOMINAL.Clear()
        LbL100Ribu.Text = String.Empty
        LbL50Ribu.Text = String.Empty
        LbL20Ribu.Text = String.Empty
        LbL10Ribu.Text = String.Empty
        LbL5Ribu.Text = String.Empty
        LbL2Ribu.Text = String.Empty
        LbLRibu.Text = String.Empty
        LbL5Ratus.Text = String.Empty
        LbL2Ratus.Text = String.Empty
        LbLRatus.Text = String.Empty
    End Sub
End Class