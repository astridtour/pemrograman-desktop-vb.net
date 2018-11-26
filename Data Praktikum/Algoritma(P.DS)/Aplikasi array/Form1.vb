Public Class Form1
    Dim ArrayProv() As String = {"NAD", "sumut", "riau"}
    'NAD'
    Dim arraykotaNad() As String = {"Banda", "lokseumawe"}
    Dim arrayKecBanda() As String = {"Darussalam", "Indrapuri"}
    Dim arrayKeclokseumawe() As String = {"Muara Satu", "Muara Dua"}

    'SUMUT'
    Dim arraykotaSUMUT() As String = {"Medan", "Pematang Siantar"}
    Dim arrayKecMedan() As String = {"Medan Timur", "Medan Johor"}
    Dim arrayKecPematangSiantar() As String = {"Siantar Martoba", "Siantar Marihat"}

    'RIAU'
    Dim arraykotaRIAU() As String = {"Pekan Baru", "Dumai"}
    Dim arrayKecPekanBaru() As String = {"Bukit Raya", "Lima Puluh"}
    Dim arrayKecDumai() As String = {"Dumai Barat", "Bukit Kapur"}

    'Dim ArrayProv() As String = {"Jawa Barat", "Banten", "Jawa Tengah"}
    'Dim ArrayKotaJabar() As String = {"Bandung", "Cimahi"}
    'Dim ArrayKotaBanten() As String = {"Cilegon", "Serang"}
    'Dim ArrayKotaJateng() As String = {"Brebes", "Semarang"}
    'Dim ArrayKecBandung() As String = {"Antapani", "Babakanciparay"}
    'Dim ArrayKecCimahi() As String = {"Cimahi Utara", "Cimahi Tengah"}
    'Dim ArrayKecCilegon() As String = {"Cibeber", "Gerogol"}
    'Dim ArrayKecSerang() As String = {"Curug", "Kasemen"}
    'Dim ArrayKecBrebes() As String = {"Losari", "Salem"}
    'Dim ArrayKecSemarang() As String = {"Banyumanik", "Mijen"}


    'Dim ArrayProv() As String = {"NAD", "sumut", "riau"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbProv.Items.AddRange(ArrayProv)
    End Sub

    Private Sub cmbProv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbProv.SelectedIndexChanged
        If CmbProv.SelectedIndex = 0 Then
            CmbKota.Items.Clear()
            'CmbKota.Items.AddRange(ArrayKotaJabar)
            CmbKota.Items.AddRange(arraykotaNad)
        ElseIf CmbProv.SelectedIndex = 1 Then
            CmbKota.Items.Clear()
            'CmbKota.Items.AddRange(ArrayKotaBanten)
            CmbKota.Items.AddRange(arraykotaSUMUT)
        ElseIf CmbProv.SelectedIndex = 2 Then
            CmbKota.Items.Clear()
            'CmbKota.Items.AddRange(ArrayKotaJateng)
            CmbKota.Items.AddRange(arraykotaRIAU)
        End If
    End Sub

    Private Sub cmbKota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbKota.SelectedIndexChanged
        If CmbKota.SelectedItem = "Banda" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKecBanda)
        ElseIf CmbKota.SelectedItem = "lokseumawe" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKeclokseumawe)
        ElseIf CmbKota.SelectedItem = "Medan" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKecMedan)
        ElseIf CmbKota.SelectedItem = "Pematang Siantar" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKecPematangSiantar)
        ElseIf CmbKota.SelectedItem = "Pekan Baru" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKecPekanBaru)
        ElseIf CmbKota.SelectedItem = "Dumai" Then
            CmbKecamatan.Items.Clear()
            CmbKecamatan.Items.AddRange(arrayKecDumai)



            'If CmbKota.SelectedItem = "Bandung" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecBandung)
            'ElseIf CmbKota.SelectedItem = "Cimahi" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecCimahi)
            'ElseIf CmbKota.SelectedItem = "Cilegon" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecCilegon)
            'ElseIf CmbKota.SelectedItem = "Serang" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecSerang)
            'ElseIf CmbKota.SelectedItem = "Brebes" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecBrebes)
            'ElseIf CmbKota.SelectedItem = "Semarang" Then
            '    CmbKecamatan.Items.Clear()
            '    CmbKecamatan.Items.AddRange(ArrayKecSemarang)
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        LstTampil.Items.Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProses.Click
        If CmbProv.SelectedItem = "" Then
            MsgBox("belum pilih Provinsi")
        ElseIf CmbKota.SelectedItem = "" Then
            MsgBox("belum pilih Kota")
        ElseIf CmbKecamatan.SelectedItem = "" Then
            MsgBox("belum pilih Kecamatan")
        Else
            LstTampil.Items.Clear()
            LstTampil.Items.Add("Provinsi yang dipilih " + CmbProv.SelectedItem)
            LstTampil.Items.Add("Kota yang dipilih " + CmbKota.SelectedItem)
            LstTampil.Items.Add("Kecamatan yang dipilih " + CmbKecamatan.SelectedItem)
        End If
    End Sub
End Class

