Public Class Form1

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Txt1.Text = ""
        Txt2.Text = ""
        Txt3.Text = ""
        Txt4.Text = ""
        Txt5.Text = ""
        Txt1.Focus()

    End Sub

    Private Sub BtnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
        Txt5.Text = CStr(0.1 * Txt1.Text + 0.1 * Txt2.Text + 0.35 * Txt3.Text + 0.45 * Txt4.Text)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
