Public Class Form1

    Private Sub btnTUTUP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTUTUP.Click
        REM Menutup Form dan Aplikasi sekaligus
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnKONVERSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKONVERSI.Click
        REM memvalidasi data nilai akhir
        If Not IsNumeric(txtNA.Text) Then
            MsgBox("Data Tidak Valid", MsgBoxStyle.Critical, "Komentar")
            txtNA.Focus()
            Exit Sub
        End If
        REM Mengkonversi nilai akhir menjadi nilai huruf
        Dim Na As Single = 0
        Dim Nh As Char = " "
        REM mengisi nilai baru ke variabel Na
        Na = CSng(txtNA.Text)
        REM mengisi nilai baru ke variabel Nh
        If Na >= 85 And Na <= 100 Then
            Nh = "A"
        ElseIf Na >= 75 And Na <= 84 Then
            Nh = "B"
        ElseIf Na >= 65 And Na <= 74 Then
            Nh = "C"
        ElseIf Na >= 55 And Na <= 64 Then
            Nh = "D"
        Else
            Nh = "E"
        End If
        REM menampilkan hasil konversi
        txtNH.Text = Nh
    End Sub

    Private Sub txtNA_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNA.TextChanged
        REM menghapus NH bila NA kosong
        If Strings.Len(txtNA.Text) = 0 Then
            txtNH.Clear()
        End If
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        REM mengarahkan cursor di isian nilai akhir
        txtNA.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM mengatur urutan fokus
        txtNA.TabIndex = 0
        txtNH.TabIndex = 1
        btnKONVERSI.TabIndex = 2
        btnTUTUP.TabIndex = 3
    End Sub
End Class
