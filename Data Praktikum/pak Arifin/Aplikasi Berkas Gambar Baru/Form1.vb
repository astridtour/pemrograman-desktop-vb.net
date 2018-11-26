Option Explicit On

Public Class Form1
    Dim wadahGambar() As PictureBox
    Dim ofd As New OpenFileDialog
    Dim imageFiles As String()
    Dim ukuranLebar As Integer
    Dim ukuranPanjang As Integer
    Dim itemTerpilih As Integer


    Private Sub mnTambahBerkas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnTambahBerkas.Click
        ofd = New OpenFileDialog
        With ofd
            .Title = "Buka Berkas"
            .Filter = "JPEG Files|*.jpg|All Files|*.*"
            .Multiselect = True
            .RestoreDirectory = True
            .FileName = ""
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                imageFiles = .FileNames
                ReDim wadahGambar(imageFiles.Length - 1)
                For idx As Integer = 0 To imageFiles.Length - 1
                    wadahGambar(idx) = New PictureBox
                    With wadahGambar(idx)
                        .Width = ukuranLebar
                        .Height = ukuranPanjang
                        .Parent = FLPgambar
                        .Image = Image.FromFile(ofd.FileNames(idx))
                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Show()
                    End With
                Next
            End If
        End With
    End Sub

    Private Sub mnTutupAplikasi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnTutupAplikasi.Click
        Application.Exit()
    End Sub

    Private Sub mnHapusSemuaBerkas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnHapusSemuaBerkas.Click
        FLPgambar.Controls.Clear()
    End Sub

    Private Sub mnUbahUkuran_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnUbahUkuran.Click

        ukuranLebar = CInt(InputBox("Tentukan nilai ukuran Lebar?", "Input", "300"))
        ukuranPanjang = CInt(InputBox("Tentukan nilai ukuran Panjang?", "Input", "200"))

        For i As Integer = 0 To FLPgambar.Controls.Count - 1
            FLPgambar.Controls(i).Width = ukuranLebar
            FLPgambar.Controls(i).Height = ukuranPanjang
        Next
        FLPgambar.Refresh()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ukuranLebar = 300
        ukuranPanjang = 200
    End Sub

  
End Class
