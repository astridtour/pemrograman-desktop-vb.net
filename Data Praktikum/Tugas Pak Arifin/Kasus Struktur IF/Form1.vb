Public Class Form1
    Const harga As Integer = 35000
    Dim n As Integer
    Dim total As Long = 0
    Dim potongan As Single = 0
    Dim pembayaran As Double = 0

    Private Sub BtnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        TxtJumlah.Clear()
        TxtHarga.Clear()
        TxtPembayaran.Clear()
        TxtPotongan.Clear()
        TxtTotal.Clear()
        TxtJumlah.Focus()

    End Sub

    'Private Sub TxtJumlah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtJumlah.Click
    '    If Not IsNumeric(TxtJumlah.Text) Then
    '        TxtHarga.Clear()
    '        TxtPembayaran.Clear()
    '        TxtPotongan.Clear()
    '        TxtTotal.Clear()
    '        MsgBox("masukan jumlah nominal buah yang anda beli.")
    '    Else
    '        TxtHarga.Text = String.Format(harga, "Rp#,#0")

    '    End If
    '    n = CInt(TxtJumlah.Text)
    '    total = Harga * n
    '    If total > 320000 Then
    '        potongan = 0.15 * total
    '    End If
    '    pembayaran = total - potongan
    '    TxtTotal.Text = String.Format(total, "Rp#,#0")
    '    TxtPotongan.Text = String.Format(potongan, "Rp#,#0")
    '    TxtPembayaran.Text = String.Format(pembayaran, "Rp#,#0")
    'End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
        MsgBox("anda yakin menutup aplikasi ini?")

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtHarga.Enabled = False
        TxtTotal.Enabled = False
        TxtPotongan.Enabled = False
        TxtPembayaran.Enabled = False

    End Sub

    Private Sub BtnHasil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
        If Not IsNumeric(TxtJumlah.Text) Then
            TxtHarga.Clear()
            TxtPembayaran.Clear()
            TxtPotongan.Clear()
            TxtTotal.Clear()
            MsgBox("masukan jumlah nominal buah yang anda beli.")
        Else
            TxtHarga.Text = String.Format(harga, "Rp#,#0")

        End If
        n = CInt(TxtJumlah.Text)
        total = harga * n
        If total > 320000 Then
            potongan = 0.15 * total
        End If
        pembayaran = total - potongan
        TxtTotal.Text = String.Format(total, "Rp#,#0")
        TxtPotongan.Text = String.Format(potongan, "Rp#,#0")
        TxtPembayaran.Text = String.Format(pembayaran, "Rp#,#0")
    End Sub
End Class
