Public Class Form1
    Dim pencacah As Integer = 0

    Sub AturTombol(Optional ByVal Respon As Boolean = True)
        BTN01.Enabled = Respon
        BTN02.Enabled = Respon
        BTN03.Enabled = Respon
        BTN04.Enabled = Respon
        BTN05.Enabled = Respon
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            With PICgambar
                .Image = Nothing
                .SizeMode = PictureBoxSizeMode.StretchImage
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        With TMRpewaktu
            .Enabled = False
            .Interval = 2000
        End With
    End Sub


    Private Sub BTN02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN02.Click
        PICgambar.Image = My.Resources._02
    End Sub

    Private Sub BTN03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN03.Click
        PICgambar.Image = My.Resources._03
    End Sub

    Private Sub BTN04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN04.Click
        PICgambar.Image = My.Resources._04
    End Sub

    Private Sub BTN05_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN05.Click
        PICgambar.Image = My.Resources._05
    End Sub

    Private Sub BTNotomatis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNotomatis.Click
        If Strings.UCase(BTNotomatis.Text) = Strings.UCase("Otomatis") Then
            BTNotomatis.Text = "Hentikan"
            TMRpewaktu.Enabled = True
            Call AturTombol(False)
        Else
            BTNotomatis.Text = "Otomatis"
            TMRpewaktu.Enabled = False
            Call AturTombol()
        End If
    End Sub

    Private Sub TMRpewaktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMRpewaktu.Tick
        pencacah += 1
        If pencacah > 5 Then pencacah = 1
        Select Case pencacah
            Case 1 : PICgambar.Image = My.Resources._01
            Case 2 : PICgambar.Image = My.Resources._02
            Case 3 : PICgambar.Image = My.Resources._03
            Case 4 : PICgambar.Image = My.Resources._04
            Case Else : PICgambar.Image = My.Resources._05
        End Select
    End Sub

    Private Sub BTN01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN01.Click
        PICgambar.Image = My.Resources._01
    End Sub

    Private Sub BTNbuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNbuka.Click
        Dim ofd As New OpenFileDialog()
        With ofd
            .Title = "Buka Berkas Gambar"
            .Filter = "JPEG image|*.jpg|BITMAP image|*.bmp|GIF image|*.gif"
            .ShowDialog()
            If .FileName <> "" Then
                PICgambar.ImageLocation = .FileName
            End If
        End With
    End Sub

    Private Sub BTNsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNsimpan.Click
        If PICgambar.ImageLocation = String.Empty Then
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
                    Case 1 : PICgambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Case 2 : PICgambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp)
                    Case Else : PICgambar.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif)
                End Select
                fs.Close()
                MessageBox.Show("Berkas Berhasil Disimpan", "Sukses....", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                PICgambar.Image = Nothing
            End If
        End If
    End Sub
End Class
