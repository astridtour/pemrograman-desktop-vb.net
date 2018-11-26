Public Class Form1
    'Const phi As Double = 22 / 7
    Dim input_angka, Hasil As Double
    Dim Rumus As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        LblNumeric.Text = LblNumeric.Text & "1"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        LblNumeric.Text = LblNumeric.Text & "0"
    End Sub

    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        LblNumeric.Text = LblNumeric.Text & "3"
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        LblNumeric.Text = LblNumeric.Text & "2"
    End Sub

    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        LblNumeric.Text = LblNumeric.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        LblNumeric.Text = LblNumeric.Text & "5"
    End Sub

    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        LblNumeric.Text = LblNumeric.Text & "6"
    End Sub

    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        LblNumeric.Text = LblNumeric.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        LblNumeric.Text = LblNumeric.Text & "8"
    End Sub

    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        LblNumeric.Text = LblNumeric.Text & "9"
    End Sub

    Private Sub BtnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTambah.Click
        input_angka = Val(LblNumeric.Text)
        Rumus = "+"
        LblNumeric.Text = Nothing
    End Sub

    Private Sub BtnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKurang.Click
        input_angka = Val(LblNumeric.Text)
        Rumus = "-"
        LblNumeric.Text = Nothing
    End Sub

    Private Sub BtnKali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKali.Click
        input_angka = Val(LblNumeric.Text)
        Rumus = "*"
        LblNumeric.Text = Nothing
    End Sub

    Private Sub BtnPangkat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPangkat.Click
        input_angka = Val(LblNumeric.Text)
        Rumus = "^"
        LblNumeric.Text = Nothing
    End Sub

    Private Sub btnBagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBagi.Click
        input_angka = Val(LblNumeric.Text)
        Rumus = "/"
        LblNumeric.Text = Nothing
    End Sub

    Private Sub BtnHasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHasil.Click
        If Rumus = "+" Then

            LblNumeric.Text = input_angka + Val(LblNumeric.Text)

        ElseIf Rumus = "-" Then

            LblNumeric.Text = input_angka - Val(LblNumeric.Text)

        ElseIf Rumus = "*" Then

            LblNumeric.Text = input_angka * Val(LblNumeric.Text)

        ElseIf Rumus = "/" Then

            LblNumeric.Text = input_angka / Val(LblNumeric.Text)

        ElseIf Rumus = "^" Then

            LblNumeric.Text = input_angka ^ Val(LblNumeric.Text)

        End If
    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        If LblNumeric.Text.Length <> 0 Then
            LblNumeric.Text = LblNumeric.Text.Remove(LblNumeric.Text.Length - 1)

        End If

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        LblNumeric.Text = Nothing
        input_angka = Nothing
        Hasil = Nothing
        Rumus = Nothing

    End Sub
End Class
