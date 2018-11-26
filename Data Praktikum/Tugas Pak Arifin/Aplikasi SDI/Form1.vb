Public Class Form1

    Private Sub subFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subFile1.Click
        'membuka form2 dari form1
        Form2.Show()
    End Sub

    Private Sub subFile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subFile2.Click
        'menutup semua form dan aplikasi
        Application.Exit()
    End Sub
End Class
