Public Class Form1
    Dim gajiPokok As Double
    Dim gajiLembur As Double
    Dim gajiKotor As Double
    Dim pajak As Double
    Dim gajiBersih As Double
    Dim tunjanganSuamiIstri As Double
    Dim tunjanganAnak As Double
    Dim ja As Integer
    Dim ta As Double
    Dim i As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtGHN.Text = " "
        TxtGL.Text = " "
        TxtGKB.Text = " "
        txtTA.Text = " "
        TxtPPh.Text = " "
        TxtGB.Text = " "
        txtJamKerja.Text = " "
        cmbNikah.Text = " "
        TxtJA.Text = " "
        TxtTSS.Text = " "
        txtJamKerja.Focus()
    End Sub

    Private Sub BtnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
        'Dim gajiPokok As Double
        'Dim gajiLembur As Double
        'Dim gajiKotor As Double
        'Dim pajak As Double
        'Dim gajiBersih As Double
        'Dim tunjanganSuamiIstri As Double
        'Dim tunjanganAnak As Double
        'Dim ta As Integer


        If Val(txtJamKerja.Text) > 8 Then
            gajiLembur = (Val(txtJamKerja.Text) - 8) * 35000
            gajiPokok = 8 * 15000
        ElseIf txtJamKerja.Text > 250 Then
            MsgBox("jam kerja melebihi ketententuan yang ada")
        Else
            gajiPokok = Val(txtJamKerja.Text) * 15000
        End If

        If cmbNikah.SelectedItem = "Menikah" Then
            tunjanganSuamiIstri = 850000
        Else
            tunjanganSuamiIstri = 0
        End If

        gajiKotor = (gajiPokok + gajiLembur) * 25

        pajak = 0.1 * gajiKotor

        ja = Val(TxtJA.Text)

        tunjanganAnak = 0

        'For i As Integer = 1 To ja
        '    Select Case i
        '        Case 1 To 2I
        '            tunjanganAnak = tunjanganAnak + 300000
        '        Case 3 To 5
        '            tunjanganAnak = tunjanganAnak + 200000
        '        Case Else
        '            tunjanganAnak = tunjanganAnak + 100000
        '    End Select
        'Next



        If ja >= 1 And ja <= 2 Then
            tunjanganAnak = ja * 300000
        ElseIf ja >= 3 And ja <= 5 Then
            tunjanganAnak = (2 * 300000) + ((ja - 2) * 200000)
        ElseIf ja >= 5 And ja <= 10 Then
            tunjanganAnak = (2 * 300000) + ((5 - 2) * 200000) + ((ja - 5) * 100000)
        Else 
            MsgBox("sebaiknya anda ikut KB")
        End If

        'If ja >= 1 And ja <= 2 Then
        '    txtTA.Text = Val(ja * 300000)
        'ElseIf ja >= 3 And ja <= 5 Then
        '    txtTA.Text = Val(ja * 200000)
        'Elsea
        '    txtTA.Text = Val(ja * 100000)
        'End If


        'Select Case ja
        '    Case 1 To 2
        '        ja = Val(txtTA.Text) * 300000
        '    Case 3 To 5
        '        ja = Val(txtTA.Text) * 200000
        '    Case Else
        '        ja = Val(txtTA.Text) * 100000
        'End Select


        'Select Case ta
        '    Case 1, 2
        '        tunjanganAnak = ta * 300000
        '    Case 3, 4, 5
        '        tunjanganAnak = ta * 200000
        '    Case Else
        '        tunjanganAnak = ta * 100000
        'End Select

        gajiBersih = gajiKotor - pajak + tunjanganSuamiIstri + tunjanganAnak

        TxtGHN.Text = gajiPokok
        TxtGL.Text = gajiLembur
        TxtGKB.Text = gajiKotor
        TxtGB.Text = gajiBersih
        TxtTSS.Text = tunjanganSuamiIstri
        txtTA.Text = tunjanganAnak
        TxtPPh.Text = pajak

        If txtJamKerja.Text >= 250 And TxtJA.Text >= 10 Then
            MsgBox("Jumlah jam kerja yang anda Masukan tidak sesuai dengan peraturan dan sebaiknya anda mengikuti PROGRAM KB")

        End If
        'TxtGHN.Text = CStr(n * 15000)
        'TxtGL.Text = CStr(n * 35000)
        'TxtGKB.Text = TxtGHN.Text + TxtGL.Text
        'TxtTSS.Text = CStr(850000)
        'TxtTA.Text = CStr(n)
        'If n <= 2 Then
        '    TxtTA.Text = n * 300000
        'ElseIf n <= 5 Then
        '    TxtTA.Text = n * 200000
        'ElseIf n >= 5 Then
        '    TxtTA.Text = n * 100000
        'End If

        'TxtGKB.Text = CStr(TxtGHN.Text + TxtGL.Text)
        'TxtPPh.Text = CStr(TxtGKB.Text * 10%)
        'TxtGB.Text = CStr(TxtGKB.Text - TxtPPh.Text + TxtTA.Text + TxtTSS.Text)

    End Sub

    Private Sub BtnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtGHN.Text = " "
        TxtGL.Text = " "
        TxtGKB.Text = " "
        TxtTA.Text = " "
        TxtPPh.Text = " "
        TxtGB.Text = " "
        txtJamKerja.Text = " "
        cmbNikah.Text = " "
        TxtJA.Text = " "
        TxtTSS.Text = " "
        txtJamKerja.Focus()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub

    Private Sub txtJamKerja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJamKerja.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            cmbNikah.Focus()
        End If
    End Sub

    Private Sub txtJamKerja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJamKerja.TextChanged

    End Sub

    Private Sub cmbNikah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbNikah.KeyPress
        If e.KeyChar = Chr(Keys.Return) Then
            TxtJA.Focus()
        End If
    End Sub
End Class
