Public Class Form1
    Sub simpan()
        Dim file = TxtNama.Text.ToString + cmbFormat.Text.ToString
        Try
            If TxtNama.Text = " " Then
                TxtNama.Focus()
            Else
                Exit Sub
            End If
            If txtText.Text = " " Then
                txtText.Focus()
            Else
                : Exit Sub
            End If
            My.Computer.FileSystem.WriteAllText(file, txtText.Text, False)
            MsgBox("berhasil menyimpan", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("gagal menyimpan file!", MsgBoxStyle.Critical)
            clear()
        End Try
    End Sub

    Sub baca()
        Try
            If TxtNama.Text = " " Then
                TxtNama.Focus()
            Else
                Exit Sub

            End If
            Dim file = TxtNama.Text.ToString + cmbFormat.Text.ToString
            Using temp As New IO.StreamReader(file.ToString)
                txtText.Text = temp.ReadLine

            End Using
        Catch ex As Exception
            MsgBox("nama file tidak ditemukan", MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub clear()
        TxtNama.Clear()
        txtText.Clear()
        TxtNama.Select()
        With cmbFormat()
            .Items.Add(".ini")
            .Items.Add(".text")
        End With
        cmbFormat.Text = ".ini"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clear()
        TxtNama.Text = "contoh"
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call simpan()
    End Sub

    Private Sub BtnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRead.Click
        Call baca()
    End Sub

    Private Sub BtnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCheck.Click
        Try
            Dim location As String
            location = Application.StartupPath
            'ini adalah lokasi file aplikasinya
            Process.Start(location)
            'membuka explorer file lokasi
        Catch ex As Exception

        End Try

    End Sub
End Class
