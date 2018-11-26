Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        CmbFunction.SelectedIndex = 0
        TxtData.Focus()

    End Sub

    Private Sub TxtData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtData.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = vbBack Or e.KeyChar = " " Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        If TxtData.Text = " " Then
            MsgBox("kolom ini harus di isi", MsgBoxStyle.Critical)
        Else
            Dim status As Boolean = False
            For i As Integer = 0 To LstTampil.Items.Count - 1
                If CInt(LstTampil.Items(i) = TxtData.Text) Then
                    status = False
                    Exit For

                End If
            Next
            If status = False Then
                LstTampil.Items.Add(TxtData.Text)
                TxtData.Clear()
                TxtData.Focus()

            End If

        End If
    End Sub

    Private Sub CmbFunction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFunction.SelectedIndexChanged
        Try

        Catch ex As Exception
            LblHasil.Text = " "
            If CmbFunction.SelectedIndex <> 0 Then
                If LstTampil.Items.Count < 1 Then
                    MsgBox("data tidak ada di listBox sehingga data tidak dapat di proses")
                Else
                    If CmbFunction.SelectedIndex = 1 Then
                        Dim average As Integer = CInt(LstTampil.Items(0))
                        Dim sum As Integer = 0
                        For i As Integer = 0 To LstTampil.Items.Count - 1
                            sum += CInt(LstTampil.Items(1))


                        Next
                        Dim rata As Decimal = sum / LstTampil.Items.Count
                        LblHasil.Text = Math.Round(rata, 2)
                    Else
                        If CmbFunction.SelectedIndex = 2 Then
                            Dim min As Integer = CInt(LstTampil.Items(0))
                            For i As Integer = 1 To LstTampil.Items.Count - 1
                                If (LstTampil.Items(i) < min) Then
                                    min = LstTampil.Items(i)

                                End If
                            Next
                            LblHasil.Text = min
                        ElseIf CmbFunction.SelectedIndex = 3 Then
                            Dim max As Integer = CInt(LstTampil.Items(0))
                            For i As Integer = 1 To LstTampil.Items.Count - 1
                                If CInt(LstTampil.Items(i) > max) Then
                                    max = LstTampil.Items(i)

                                End If
                            Next
                            LblHasil.Text = max

                        End If
                        TxtData.Text = " "
                        TxtData.Focus()

                    End If
                End If
            End If
        End Try
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtData.Clear()
        LstTampil.Items.Clear()
        LblHasil.Text = " "

    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()

    End Sub
End Class
