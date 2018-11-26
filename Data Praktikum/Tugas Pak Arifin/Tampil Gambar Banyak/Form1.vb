Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pic As New PictureBox
        Dim dialog As New OpenFileDialog
        dialog.Filter = "All Image*.Jpg)|*.Jpg|Bitmap file(*.bmp)|*.bmp|(*.*)|*.*"
        dialog.ShowDialog()
        If dialog.FileName <> " " Then
            With pic
                .Width = 120
                .Height = 80
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Image = Image.FromFile(dialog.FileName)

            End With
            FlowLayoutPanel1.Controls.Add(pic)
        End If

    End Sub
End Class
