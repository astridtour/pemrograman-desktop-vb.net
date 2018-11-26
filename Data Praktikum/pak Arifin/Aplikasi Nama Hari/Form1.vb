Option Explicit On
Public Class Form1
    Dim namaHari() As String = {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu"}
    Dim tanggalBaru As Date

    Private Function cetakNamaHari(ByVal Tgl As Date) As String
        Dim indeksHari As Integer = Weekday(Tgl) - 1
        Return namaHari(indeksHari)
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(i) Is TextBox Then Me.Controls(i).Enabled = False
        Next
    End Sub

    Private Sub dtpTANGGAL_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTANGGAL.ValueChanged
        txtSekarang.Text = Strings.UCase(cetakNamaHari(dtpTANGGAL.Value))
        Dim hari, bulan, tahun As Integer
        hari = DatePart(DateInterval.Day, dtpTANGGAL.Value)
        bulan = DatePart(DateInterval.Month, dtpTANGGAL.Value)
        tahun = DatePart(DateInterval.Year, dtpTANGGAL.Value)
        tanggalBaru = New Date(tahun, bulan, hari + 1)
        txtPlusSatuHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
        tanggalBaru = New Date(tahun, bulan, hari + 2)
        txtPlusDuaHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
        tanggalBaru = New Date(tahun, bulan, hari + 3)
        txtPlusTigaHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
        tanggalBaru = New Date(tahun, bulan, hari - 1)
        txtMinusSatuHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
        tanggalBaru = New Date(tahun, bulan, hari - 2)
        txtMinusDuaHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
        tanggalBaru = New Date(tahun, bulan, hari - 3)
        txtMinusTigaHari.Text = Strings.UCase(cetakNamaHari(tanggalBaru))
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        dtpTANGGAL.Value = Now
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(i) Is TextBox Then Me.Controls(i).Text = ""
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
