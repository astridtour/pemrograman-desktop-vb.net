Public Class Form2
    Dim pencacah As Integer = 0

    Sub AturTombol(Optional ByVal Respon As Boolean = True)
        BTN01.Enabled = Respon
        BTN02.Enabled = Respon
        BTN03.Enabled = Respon
        BTN04.Enabled = Respon
        BTN05.Enabled = Respon
        BTN06.Enabled = Respon
        BTN07.Enabled = Respon
        BTN08.Enabled = Respon
        BTN09.Enabled = Respon
        BTN10.Enabled = Respon
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pencacah += 1
        If pencacah > 10 Then pencacah = 1
        Select Case pencacah
            Case 1 : PICGambar.Image = My.Resources._01
            Case 2 : PICGambar.Image = My.Resources._02
            Case 3 : PICGambar.Image = My.Resources._03
            Case 4 : PICGambar.Image = My.Resources._04
            Case 5 : PICGambar.Image = My.Resources._05
            Case 6 : PICGambar.Image = My.Resources._06
            Case 7 : PICGambar.Image = My.Resources._07
            Case 8 : PICGambar.Image = My.Resources._08
            Case 9 : PICGambar.Image = My.Resources._09
            Case Else : PICGambar.Image = My.Resources._10
        End Select
    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            With PICGambar
                .Image = Nothing
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        With Timer1
            .Enabled = False
            .Interval = 2000
        End With
    End Sub

    Private Sub BTN01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN01.Click
        PICGambar.Image = My.Resources.gambar01
    End Sub

    Private Sub BTN02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN02.Click
        PICGambar.Image = My.Resources._02
    End Sub

    Private Sub BTN03_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN03.Click
        PICGambar.Image = My.Resources._03
    End Sub

    Private Sub BTN04_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN04.Click
        PICGambar.Image = My.Resources._04
    End Sub

    Private Sub BTN05_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN05.Click
        PICGambar.Image = My.Resources._05
    End Sub

    Private Sub BTN06_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN06.Click
        PICGambar.Image = My.Resources._06
    End Sub

    Private Sub BTN07_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN07.Click
        PICGambar.Image = My.Resources._07
    End Sub

    Private Sub BTN08_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN08.Click
        PICGambar.Image = My.Resources._08
    End Sub

    Private Sub BTN09_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN09.Click
        PICGambar.Image = My.Resources._09
    End Sub

    Private Sub BTN10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BTN10.Click
        PICGambar.Image = My.Resources._01
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If PICGambar.ImageLocation = String.Empty Then
            MessageBox.Show("Silahkan buka terlebih dahulu berkas gambarnya...", "Saran", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1)
            Exit Sub
        Else
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "JPEG Image|*.jpg|BITMAP Image|*.bmp|GIF Image|*.gif"
            sfd.Title = "Simpan Berkas Gambar"
            sfd.ShowDialog()
            If sfd.FileName <> "" Then
                Dim fs As System.IO.FileStream = CType(sfd.OpenFile(), System.IO.FileStream)
                Select Case sfd.FilterIndex
                    Case 1 : PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 2 : PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case Else : PICGambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                End Select
                fs.Close()
                MessageBox.Show("Berkas Berhasil Disimpan", "Sukses....", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                PICGambar.Image = Nothing
            End If
        End If
    End Sub

    Private Sub BtnBuka_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBuka.Click
        Dim ofd As New OpenFileDialog()
        With ofd
            .Title = "Buka Berkas Gambar"
            .Filter = "JPEG image|*.jpg|BITMAP image|*.bmp|GIF image|*.gif"
            .ShowDialog()
            If .FileName <> "" Then
                PICGambar.ImageLocation = .FileName
            End If
        End With
    End Sub

    Private Sub BtnOtomatis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOtomatis.Click
        If Strings.UCase(BtnOtomatis.Text) = Strings.UCase("Otomatis") Then
            BtnOtomatis.Text = "Hentikan"
            Timer1.Enabled = True
            Call AturTombol(False)
        Else
            BtnOtomatis.Text = "Otomatis"
            Timer1.Enabled = False
            Call AturTombol()
        End If
    End Sub
End Class