Public Class Form1
    Dim tgl, bln, tahun As Integer
    Dim NamaZodiak As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPicker1.Click
        If IsDate(dtpTglLahir.Text) = False Then
            MsgBox("tanggal yang anda masukkan salah")

            Exit Sub
        End If
        tgl = Format(dtpTglLahir.Value, "dd")
        bln = Format(dtpTglLahir.Value, "MM")

        Select Case bln
            Case 1 'Untuk bulan Januari
                If (tgl >= 1 And tgl <= 20) Then
                    NamaZodiak = "Capricorn"
                Else
                    NamaZodiak = "Aquarius"
                End If
            Case 2 'Untuk bulan Februari
                If (tgl >= 1 And tgl <= 19) Then
                    NamaZodiak = "Aquarius"
                Else
                    NamaZodiak = "Pisces"
                End If
            Case 3 'Untuk bulan Maret
                If (tgl >= 21 And tgl <= 31) Then
                    NamaZodiak = "Pisces"
                Else
                    NamaZodiak = "Aries"
                End If
            Case 4 'untuk bulan April
                If (tgl >= 21 And tgl <= 31) Then
                    NamaZodiak = "Aries"
                Else
                    NamaZodiak = "Taurus"
                End If
            Case 5 'untuk bulan Mei
                If (tgl >= 1 And tgl <= 31) Then
                    NamaZodiak = "Taurus"
                Else
                    NamaZodiak = "Gemini"
                End If
            Case 6 'untuk bulan Juni 
                If (tgl >= 22 And tgl <= 31) Then
                    NamaZodiak = "Gemini"
                Else
                    NamaZodiak = "Cancer"
                End If
            Case 7 'untuk bulan Juli
                If (tgl >= 1 And tgl <= 23) Then
                    NamaZodiak = "Cancer"
                Else
                    NamaZodiak = "Leo"
                End If
            Case 8 'untuk bulan Agustus
                If (tgl >= 1 And tgl <= 22) Then
                    NamaZodiak = "Leo"
                Else
                    NamaZodiak = "Virgo"
                End If
            Case 9 'untuk bulan September
                If (tgl >= 24 And tgl <= 31) Then
                    NamaZodiak = "Virgo"
                Else
                    NamaZodiak = "Libra"
                End If
            Case 10 'untuk bulan Oktober
                If (tgl >= 24 And tgl <= 31) Then
                    NamaZodiak = "Libra"
                Else
                    NamaZodiak = "Scorpio"
                End If
            Case 11 'untuk bulan November
                If (tgl >= 23 And tgl <= 31) Then
                    NamaZodiak = "Scorpio"
                Else
                    NamaZodiak = "Sagitarius"
                End If
            Case Else
                If (tgl >= 22 And tgl <= 31) Then
                    NamaZodiak = "Capricorn"
                Else
                    NamaZodiak = "Sagitarius"
                End If


        End Select

        'If tgl >= 20 And bln = 1 Or tgl <= 18 And bln = 2 Then
        '    Txt1.Text = "Aquarius"
        'End If
        'If tgl >= 19 And bln = 2 Or tgl <= 20 And bln = 3 Then
        '    Txt1.Text = "Pisces"
        'End If
        'If tgl >= 21 And bln = 4 Or tgl <= 20 And bln = 5 Then
        '    Txt1.Text = "Aries"
        'End If
        'If tgl >= 21 And bln = 5 Or tgl <= 20 And bln = 6 Then
        '    Txt1.Text = "Gemini"
        'End If
        'If tgl >= 21 And bln = 6 Or tgl <= 20 And bln = 7 Then
        '    Txt1.Text = "Cancer"
        'End If
        'If tgl >= 21 And bln = 7 Or tgl <= 21 And bln = 8 Then
        '    Txt1.Text = "Leo"
        'End If
        'If tgl >= 22 And bln = 8 Or tgl <= 21 And bln = 9 Then
        '    Txt1.Text = "Virgo"
        'End If
        'If tgl >= 22 And bln = 9 Or tgl <= 22 And bln = 10 Then
        '    Txt1.Text = "Libra"
        'End If
        'If tgl >= 23 And bln = 10 Or tgl <= 22 And bln = 11 Then
        '    Txt1.Text = "Scorpio"
        'End If
        'If tgl >= 23 And bln = 11 Or tgl <= 20 And bln = 12 Then
        '    Txt1.Text = "Sagitarius"
        'End If
        'If tgl >= 21 And bln = 12 Or tgl <= 19 And bln = 1 Then
        '    Txt1.Text = "Capricorn"
        'End If
        Txt1.Text = NamaZodiak

    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click

        Txt1.Text = " "
        DTPicker1.Focus()

    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub dtpTglLahir_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTglLahir.ValueChanged
        LblTgl.Text = CStr(Format(dtpTglLahir.Value, "dd"))
        LblBln.Text = CStr(Format(dtpTglLahir.Value, "MM"))
    End Sub
End Class