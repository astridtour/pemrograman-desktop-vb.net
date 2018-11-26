Public Class Form1

    Private Sub Btnhasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnhasil.Click
        If (Txt1.Text) = False Then
            MsgBox("tanggal yang anda masukkan salah")
        End If
        If Txt1.Text >= 0 Then
            Txt2.Text = "100"

            If Txt1.Text >= 100 Then
                Dim x As Integer
                Txt1.text= CStr("x mod 100"))
            End If
        End If
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
    End Sub

    Private Sub BtnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Txt1.Clear()
        Txt2.Clear()
        Txt1.Focus()
    End Sub
End Class
