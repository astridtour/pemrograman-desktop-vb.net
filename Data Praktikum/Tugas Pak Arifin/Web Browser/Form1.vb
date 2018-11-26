Public Class Form1

    Private Sub BtnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGo.Click
        WebBrowser1.Navigate(Txt1.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Txt1.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub Txt1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(Txt1.Text)
            e.SuppressKeyPress = True
        End If
        If e.KeyCode = Keys.F5 Then
            WebBrowser1.Refresh()
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub BtnStop_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        WebBrowser1.Stop()
    End Sub
End Class
