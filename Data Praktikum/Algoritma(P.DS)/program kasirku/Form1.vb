Public Class Form1
    Dim total, bayar, kembali As Double
    Dim bycucimobil, totaltambah, totalmakan As Double
    Dim makan As CheckBox()
    Dim Tambah As CheckBox()
    Dim txttambah As TextBox()
    Dim txtmakan As TextBox()
    Dim txtjumlah As TextBox()
    Dim hargamakan() As Double = {17000, 21000, 16000, 10000, 5000}
    Dim hargatambahan() As Double = {10000, 15000, 25000}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        makan = New CheckBox() {makan1, makan2, makan3, makan4, makan5}
        txtmakan = New TextBox() {TxtNasGor, TxtNasGorSp, TxtMieGoreng, TxtJusJeruk, TxtNumDin}
        txtjumlah = New TextBox() {txtJumlahNasGor, TxtJumlahNasGorSp, TxtJumlahMieGoreng, TxtJumlahJusJeruk, TxtJumlahNumDin}
        Tambah = New CheckBox() {Tambah1, Tambah2, Tambah3}
        txttambah = New TextBox() {txtTambah3, txtTambah1, txtTambah2}


        For i = 0 To 4
            txtmakan(i).Text = "Rp. " & Format(hargamakan(i), "#,#.##")
        Next

        For i = 0 To 2
            txttambah(i).Text = "Rp.  " & Format(hargatambahan(i), "#,#.##")
        Next
        bycucimobil = 0
    End Sub

    Private Sub MiniBus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniBus.CheckedChanged
        bycucimobil = 15000
        TxtByCuciMobil.Text = "Rp.  " & Format(bycucimobil, "#,#.##")

    End Sub

    Private Sub Bus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bus.CheckedChanged
        bycucimobil = 25000
        TxtByCuciMobil.Text = "Rp.  " & Format(bycucimobil, "#,#.##")
    End Sub

    Private Sub Truck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Truck.CheckedChanged
        bycucimobil = 30000
        TxtByCuciMobil.Text = "Rp.  " & Format(bycucimobil, "#,#.##")
    End Sub

    Private Sub SuperTruck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuperTruck.CheckedChanged
        bycucimobil = 50000
        TxtByCuciMobil.Text = "Rp.  " & Format(bycucimobil, "#,#.##")
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim i As Integer
        Dim totalmakan = 0
        Dim totaltambahan = 0
        For i = 0 To 2
            If tambah(i).checked Then
                totaltambah = totaltambahan + hargatambahan(i)

            End If
        Next

        For i = 0 To 4
            If makan(i).Checked Then
                totalmakan = totalmakan + (hargamakan(i) * Val(txtjumlah(i).Text))
            End If
        Next
        total = bycucimobil + totaltambah + totalmakan
        TxtTotal.Text = "Rp.  " & Format(total, "#,#.## ")
    End Sub

    Private Sub TxtByCuciMobil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtByCuciMobil.KeyPress
        If e.KeyChar = Chr(13) Then
            kembali = Val(TxtBayar.Text - TxtTotal.Text)
            TxtKembali.Text = "Rp.  " & Format(total, "#,#.##")

        End If
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        Dim i As Integer
        For i = 0 To 4
            makan(i).Checked = False

        Next

        For i = 0 To 4
            txtjumlah(i).Text = 0

        Next

        For i = 0 To 2
            tambah(i).checked = False

        Next
        TxtTotal.Clear()
        TxtBayar.Clear()
        TxtKembali.Clear()

    End Sub
End Class
