Public Class Form1
   
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Eht1.Text = " "
        Eht2.Text = " "

    End Sub
    Private Sub BtnPersentase_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPersentase.Click
        Txt1.Text = CStr(Eht1.Text) Or CStr(Eht2.Text)
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Dim i As Integer = 5
        Do Until (i >= 25)
            i = i + 1
            If i Mod 2 = 0 Then
                i = "genap"
            Else
                i = "ganjil"
            End If
        Loop
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Dim i As Integer = 5
        Do While (i <= 25)
            i = i + 1
            If i Mod 2 = 0 Then
                i = "genap"
            Else
                i = "ganjil"
            End If
        Loop
    End Sub
End Class
