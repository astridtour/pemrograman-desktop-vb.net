Public Class Form1
    Dim Gambar() As String = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10"}
    Dim Alamatfile As String = Environment.CurrentDirectory & "\asal gambar\"
    Dim PicGambar As New PictureBox
    Dim picturebox As New PictureBox


    Private Sub SubTambahGambar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubTambahGambar.Click
        Dim gambar As New PictureBox
        With OPDBerkas
            .Title = "Buka Berkas"
            .FileName = " "
            If OPDBerkas.ShowDialog = Windows.Forms.DialogResult.OK Then
                gambar.Image = Image.FromFile(.FileName)

            End If

            FlowLayoutPanel1.Controls.Add(gambar)
            'Me.picturebox.Size = New System.Drawing.Size(140, 140)

            gambar.Size = New Size(200, 180)
            gambar.SizeMode = PictureBoxSizeMode.StretchImage
        End With
    End Sub
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With PICGambar
            .Image = Nothing
            .SizeMode = PictureBoxSizeMode.Zoom
            'Me.picturebox.Size = New System.Drawing.Size(1200, 600)
        End With

        With OPDBerkas
            .Title = "Buka Berkas"
            .Filter = "JPEG files(*.Jpg)|*.Jpg|Bitmap file(*.bmp)|*.bmp|(*.*)|*.*"
            .FileName = " "
        End With

    End Sub
   
    Private Sub SubUbahUkuranGambar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubUbahUkuranGambar.Click


    End Sub

    Private Sub SubTutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubTutup.Click
        Application.Exit()
    End Sub

    Private Sub SubHapusGambarSemua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubHapusGambarSemua.Click
        Me.PICGambar.Image = Nothing

    End Sub
End Class
