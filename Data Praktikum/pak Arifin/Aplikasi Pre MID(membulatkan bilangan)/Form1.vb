Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBIL.Clear()
        LbLHASIL.Text = String.Empty
    End Sub

    Private Sub txtBIL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBIL.TextChanged
        If Not (IsNumeric(txtBIL.Text)) Then
            LbLHASIL.Text = String.Empty
            Exit Sub
        Else
            Try
                Dim BIL As Integer = CInt(txtBIL.Text)
                Dim SEM As Integer = BIL
                Dim HASIL As Integer = 0
                Dim SISA As Integer = BIL Mod 100
                If (SISA <> 0) Then
                    BIL = 100 - SISA
                    HASIL = SEM + BIL
                Else
                    HASIL = SEM
                End If
                LbLHASIL.Text = CStr(HASIL)
            Catch ex As Exception
                MessageBox.Show("Data Tidak Valid" & vbCrLf & "Deskripsi Kesalahan : " & _
                vbCrLf & Err.Description, "Komentar", MessageBoxButtons.OK, _
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            End Try
        End If
    End Sub

    Private Sub btnCLEAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLEAR.Click
        Me.Form1_Load(sender, e)
        txtBIL.Focus()
    End Sub

    Private Sub btnEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEXIT.Click
        Me.Dispose()
        Application.Exit()
    End Sub
End Class
