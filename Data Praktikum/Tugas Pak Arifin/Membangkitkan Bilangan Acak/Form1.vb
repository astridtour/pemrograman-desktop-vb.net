Public Class Form1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Lbl1 akan menampilkan bilangan acak antara 0-9'
        Lbl1.Text = CStr(Int(Rnd() * 10))

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        'time diaktifkan'
        Timer1.Enabled = True
        'mengosongkan masing-masing label'
        Lbl1.Text = ""

    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        'time tidak diaktifkan'
        Timer1.Enabled = False
        'Lbl1.text akan menampilkan hasil bilangan acak'
        Lbl1.Text = Lbl1.Text
    End Sub
    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Interval = 1000
    End Sub
    
End Class
