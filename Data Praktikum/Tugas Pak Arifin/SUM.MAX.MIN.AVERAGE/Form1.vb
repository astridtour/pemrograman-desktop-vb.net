Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSUM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSUM.Click
        TxtHasil.Text = CInt(Val(TxtA.Text) + (TxtB.Text) + (TxtC.Text) + (TxtD.Text))
    End Sub

    Private Sub BtnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMax.Click
        If TxtA.Text > TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text > TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text > TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text > TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtB.Text > TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text > TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text > TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text > TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtC.Text > TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text > TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text > TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text > TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtD.Text > TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtD.Text))
        ElseIf TxtD.Text > TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtD.Text))
        ElseIf TxtD.Text > TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        Else
            TxtHasil.Text = CInt(Val(TxtD.Text))

        End If

    End Sub

    Private Sub BtnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAverage.Click
        TxtHasil.Text = CInt(Val(TxtA.Text) + (TxtB.Text) + (TxtC.Text) + (TxtD.Text)) / 4
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtA.Clear()
        TxtB.Clear()
        TxtC.Clear()
        TxtD.Clear()
        TxtHasil.Clear()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMin.Click
        If TxtA.Text < TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text < TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text < TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtA.Text < TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtA.Text))
        ElseIf TxtB.Text < TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text < TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text < TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtB.Text < TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtB.Text))
        ElseIf TxtC.Text < TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text < TxtA.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text < TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtC.Text < TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtC.Text))
        ElseIf TxtD.Text < TxtD.Text Then
            TxtHasil.Text = CInt(Val(TxtD.Text))
        ElseIf TxtD.Text < TxtC.Text Then
            TxtHasil.Text = CInt(Val(TxtD.Text))
        ElseIf TxtD.Text < TxtB.Text Then
            TxtHasil.Text = CInt(Val(TxtD.Text))
        Else
            TxtHasil.Text = CInt(Val(TxtA.Text))

        End If
    End Sub
End Class
