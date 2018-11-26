Public Class Form1
    Public Function terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {" ", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        elseif nilai <20 then
            Return terbilang(nilai - 10) & "belas"
        elseif nilai <100 then 
            Return (terbilang(CInt((nilai \ 10))) & "puluh") + terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return "seratus" & terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (terbilang(CInt((nilai \ 100))) & "ratus") + terbilang(nilai Mod 100)

        ElseIf nilai < 2000 Then
            Return "seribu" & terbilang(nilai - 1000)
        ElseIf nilai < 10000000 Then
            Return (terbilang(CInt((nilai \ 1000))) & "ribu") + terbilang(nilai Mod 1000)

        elseif nilai<1000000000 then
            Return (terbilang(CInt((nilai \ 10000000))) & "juta") + terbilang(nilai Mod 10000000)

        ElseIf nilai < 1000000000000 Then
            Return (terbilang(CInt((nilai \ 1000000000))) & "milyar") + terbilang(nilai Mod 1000000000)

        ElseIf nilai < 1000000000000000 Then
            Return (terbilang(CInt((nilai \ 1000000000000))) & "trilyun") + terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Txt1.Text = terbilang(TextBox2.Text)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox2.Text = " "
        Txt1.Text = " "
        TextBox2.Focus()
    End Sub
End Class
