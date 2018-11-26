Public Class Form1
    Dim NamaHari = {"Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu"}
    Dim BanyakHari As Integer = 0 - 6
    Dim wD As Long

    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TxtTgl.Text = DateTimePicker1.Value.ToString("ddddd")
        TxtPlus1.Text = Format(DateAdd(DateInterval.Day, 1, DateTimePicker1.Value), "ddddd")
        TxtPlus2.Text = Format(DateAdd(DateInterval.Day, 2, DateTimePicker1.Value), "ddddd")
        TxtPlus3.Text = Format(DateAdd(DateInterval.Day, 3, DateTimePicker1.Value), "ddddd")
        TxtMin1.Text = Format(DateAdd(DateInterval.Day, -1, DateTimePicker1.Value), "ddddd")
        TxtMin2.Text = Format(DateAdd(DateInterval.Day, -2, DateTimePicker1.Value), "ddddd")
        TxtMin3.Text = Format(DateAdd(DateInterval.Day, -3, DateTimePicker1.Value), "ddddd")
        'TxtMin1.Text = Format(DateDiff(DateInterval.Day, 1, DateTimePicker1.Value), "weekday")

        ''TxtMin1.Text = DateTimePicker1.Value()

        ''TxtMin1.Text = DateDiff(DateInterval.Weekday, 1, DateTimePicker1.Value)
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        TxtMin1.Clear()
        TxtMin2.Clear()
        TxtMin3.Clear()
        TxtPlus1.Clear()
        TxtPlus2.Clear()
        TxtPlus3.Clear()
        TxtTgl.Clear()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()

    End Sub
End Class
