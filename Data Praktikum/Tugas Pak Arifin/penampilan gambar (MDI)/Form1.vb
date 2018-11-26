Public Class Form1
    Dim indeks As Integer = 0

    Private Sub SubNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubNew.Click
        indeks += 1
        Dim myDoc As New Form2
        With myDoc
            .MdiParent = Me
            .Text = .Text & CStr(indeks)
            .Show()
        End With
    End Sub

    Private Sub SubExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubExit.Click
        Application.Exit()
    End Sub

    Private Sub cmsBaru_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsBaru.Click
        SubNew.PerformClick()
    End Sub

    Private Sub cmsTutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsTutup.Click
        SubExit.PerformClick()
    End Sub
End Class
