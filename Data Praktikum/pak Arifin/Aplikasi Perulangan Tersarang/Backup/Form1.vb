Public Class Form1

    Private Sub btnHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHAPUS.Click
        txtHASIL.Clear()
    End Sub

    Private Sub btnGENERAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGENERAL.Click
        For i As Integer = 1 To 10 Step 1
            For j As Integer = 1 To 10 Step 1
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,3} x{1,3}={2,3}", i, j, i * j) & vbCrLf
            Next
            txtHASIL.Text = txtHASIL.Text & vbCrLf
        Next
    End Sub

   

    Private Sub btnPOLA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOLA2.Click
        Dim i As Integer = 5
        While (i >= 1)
            Dim j As Integer = 1
            While (j <= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,3}", j)
                j = j + 1
            End While
            txtHASIL.Text = txtHASIL.Text & vbCrLf
            i = i - 1
        End While
    End Sub

    Private Sub btnPOLA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOLA3.Click
        Dim i As Integer = 5
        While (i >= 1)
            Dim j As Integer = 1
            Dim k As Integer = 5
            While (k >= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,4}", Strings.Chr(32))
                k = k - 1
            End While
            While (j <= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,3}", j)
                j = j + 1
            End While
            txtHASIL.Text = txtHASIL.Text & vbCrLf
            i = i - 1
        End While
    End Sub

    Private Sub btnPOLA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOLA4.Click
        Dim i As Integer = 1
        While (i <= 5)
            Dim j As Integer = 1
            Dim k As Integer = 5
            While (k >= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,4}", Strings.Chr(32))
                k = k - 1
            End While
            While (j <= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,3}", j)
                j = j + 1
            End While
            txtHASIL.Text = txtHASIL.Text & vbCrLf
            i = i + 1
        End While
    End Sub

    Private Sub btnPOLA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPOLA1.Click
        Dim i As Integer = 1
        While (i <= 5)
            Dim j As Integer = 1
            While (j <= i)
                txtHASIL.Text = txtHASIL.Text & String.Format("{0,3}", j)
                j = j + 1
            End While
            txtHASIL.Text = txtHASIL.Text & vbCrLf
            i = i + 1
        End While
    End Sub
End Class
