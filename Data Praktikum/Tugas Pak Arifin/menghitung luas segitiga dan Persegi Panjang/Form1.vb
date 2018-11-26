Public Class Form1
    Const rumus = 0.5 '1/2
    Dim alas, tinggi As Double
    Dim Luas As Double

    Private Sub BtnHitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        alas = Val(TxtAlas.Text)
        tinggi = Val(TxtTinggi.Text)
        TxtLuas.Text = CStr(rumus * alas * tinggi)

    End Sub

    Private Sub BtnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        TxtAlas.Text = "0"
        TxtTinggi.Text = "0"
        TxtLuas.Text = " "

    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtAlas.Text = "0"
        TxtTinggi.Text = "0"
        TxtLuas.Text = " "
        TxtAlas.Focus()

    End Sub

    Private Sub BtnPersegiPanjang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPersegiPanjang.Click

    End Sub
End Class
