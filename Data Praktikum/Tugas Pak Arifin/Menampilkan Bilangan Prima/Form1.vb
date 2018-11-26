Public Class Form1
    Dim n As Integer
    Dim k = 0
    Dim bil = 2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = Val(TextBox1.Text)
        ListBox1.Clear()
        k = 0

        bil = 2

        While k < n

            prima = True

            For pembagi = 2 To bil - 1

                If bil Mod pembagi = 0 Then prima = False

            Next pembagi

            If prima Then
                ListBox1.AddItem(bil)
                k = k + 1
            End If

            bil = bil + 1

        End While

    End Sub
End Class
