Public Class Form2
    Dim panjang, lebar As Integer
    Dim luas As Integer
    Dim keliling As Integer

    Private Sub BtnHitung_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        panjang = Val(TxtPanjang.Text)
        lebar = Val(TxtLebar.Text)
        luas = Val(TxtLuas.Text)
        keliling = Val(TxtKeliling.Text)
        TxtLuas.Text = CStr(panjang * lebar)
        TxtKeliling.Text = CStr(2 * (panjang + lebar))

    End Sub

    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtPanjang.Text = "0"
        TxtLebar.Text = "0"
        TxtLuas.Text = " "
        TxtKeliling.Text = " "
        TxtPanjang.Focus()

    End Sub

    Private Sub BtnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        TxtPanjang.Text = "0"
        TxtLebar.Text = "0"
        TxtLuas.Text = " "
        TxtKeliling.Text = " "
        TxtPanjang.Focus()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()

    End Sub
End Class