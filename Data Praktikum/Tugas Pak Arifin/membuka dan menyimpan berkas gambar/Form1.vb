Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With PICGambar
            .Image = Nothing
            .SizeMode = PictureBoxSizeMode.CenterImage

        End With

        With OPDBerkas
            .Title = "Buka Berkas"
            .Filter = "JPEG files(*.Jpg)|*.Jpg|Bitmap file(*.bmp)|*.bmp|(*.*)|*.*"
            .FileName = " "

        End With

        With SFDBerkas
            .Title = "Simpan Berkas Gambar"
            .Filter = "JPEG files(*.Jpg)|*.Jpg|Bitmap file(*.bmp)|*.bmp|(*.*)|*.*"
            .FileName = " "
        End With
        LblInfoBerkas.Text = "None"
    End Sub

    Private Sub SubOpenFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubOpenFile.Click
        With OPDBerkas
            .Title = "Buka Berkas"
            .FileName = " "
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                PICGambar.Image = Image.FromFile(.FileName)
                LblInfoBerkas.Text = "info berkas:" & Space(1) & .FileName.ToString

            End If
        End With

    End Sub

    Private Sub SubOne_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubOne.Click
        PICGambar.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub SubTwo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubTwo.Click
        PICGambar.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub SubThree_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubThree.Click
        PICGambar.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub SubFour_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubFour.Click
        PICGambar.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub SubFive_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubFive.Click
        PICGambar.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Private Sub SubSaveFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubSaveFile.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "JPEG files(*.Jpg)|*.Jpg|Bitmap file(*.bmp)|*.bmp|(*.*)|*.*"
        sfd.Title = "Save  Image file"
        sfd.ShowDialog()
        If sfd.FileName <> " " Then
            Dim fs As System.IO.FileStream = CType(sfd.OpenFile(), System.IO.FileStream)
            Select Case sfd.FilterIndex
                Case 1
                    PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                Case 2
                    PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                Case 3
                    PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                
            End Select
            fs.Close()
        End If
        SubClear.PerformClick()

    End Sub

    Private Sub SubClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubClear.Click
        If OPDBerkas.FileName = " " Then
            MsgBox("Berkas Gambar Masih Kosong....", MsgBoxStyle.Information, "Informasi")

        Else
            OPDBerkas.FileName = " "
            SFDBerkas.FileName = " "
            PICGambar.Image = Nothing
            LblInfoBerkas.Text = " "
        End If
        
    End Sub
End Class
