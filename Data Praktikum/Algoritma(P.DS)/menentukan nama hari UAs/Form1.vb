Public Class Form1

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtThn.Focus()
        TxtHari.Clear()

       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        With TxtHari
            If ComboBox1.SelectedItem Mod 7 = 0 Then
                TxtHari.Text = "Minggu"
            ElseIf ComboBox1.SelectedItem Mod 7 = 1 Then
                TxtHari.Text = "Senin"
            ElseIf ComboBox1.SelectedItem Mod 7 = 2 Then
                TxtHari.Text = "Selasa"
            ElseIf ComboBox1.SelectedItem Mod 7 = 3 Then
                TxtHari.Text = "Rabu"
            ElseIf ComboBox1.SelectedItem Mod 7 = 4 Then
                TxtHari.Text = "Kamis"
            ElseIf ComboBox1.SelectedItem Mod 7 = 5 Then
                TxtHari.Text = "Jum'at"
            ElseIf ComboBox1.SelectedItem Mod 7 = 6 Then
                TxtHari.Text = "Sabtu"
            End If
        End With

    End Sub
End Class
