Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTukar.Click
        Dim A As Integer
        Dim B As Integer
        Dim C As Integer
        Dim D As Integer

        A = txtA.Text
        B = txtB.Text
        C = txtC.Text
        D = txtD.Text

        TextBox8.Text = D
        TextBox7.Text = C
        TextBox6.Text = A
        TextBox5.Text = B

    End Sub

   
    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Close()
    End Sub
End Class
