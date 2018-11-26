Public Class Form1
    Dim indeks As Integer = 0
    Private Sub subFILE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subFILE1.Click
        'menaikkan nilai indeks
        indeks += 1
        'memanggil duplikat dari Form2
        Dim myDoc As New Form2
        With myDoc
            .MdiParent = Me
            .Text = .Text & CStr(indeks)
            .Show()
        End With
    End Sub

    Private Sub subFILE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subFILE2.Click
        'menutup aplikasi
        Application.Exit()
    End Sub

    Private Sub cmsBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsBaru.Click
        subFILE1.PerformClick()
    End Sub

    Private Sub cmsTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsTutup.Click
        subFILE2.PerformClick()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
