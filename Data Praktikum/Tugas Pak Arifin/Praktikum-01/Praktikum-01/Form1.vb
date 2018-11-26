Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FromDua As New Form2
        With FromDua
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FromTiga As New Form3
        With FromTiga
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim FromEmpat As New Form4
        With FromEmpat
            .ShowDialog()
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim FromEmpat As New Form4
        With FromEmpat
            .ShowDialog()
        End With
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Const Respon As Byte = vbYes
        Dim konfirmasi As Byte
        konfirmasi = MessageBox.Show("Anda yakin menutup aplikasi ini?", _
        "Konfirmasi Menutup Aplikasi", MessageBoxButtons.YesNo, _
MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If konfirmasi = Respon Then Application.Exit()

    End Sub
End Class
