Public Class Form1
    Dim a, b, c, i As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()

    End Sub

    Private Sub BtnLOOP1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP1.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
        a = 1 : b = 1
        With LstRESULT
            .Items.Add("suku (1):" & CStr(a))
            .Items.Add("suku (2):" & CStr(b))
        End With
        For i = 1 To 8 Step 1
            c = a + b
            With LstRESULT
                .Items.Add("suku(i+2):" & CStr(c))
            End With
            a = b
            b = c
        Next
    End Sub

    Private Sub BtnLOOP2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP2.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
        a = 1 : b = 1
        With LstRESULT
            .Items.Add("suku (1):" & CStr(a))
            .Items.Add("suku (2):" & CStr(b))
        End With
        i = 1
        While (i <= 8)
            c = a + b
            With LstRESULT
                .Items.Add("suku(i+2):" & CStr(c))
            End With
            a = b
            b = c
            i += 1
        End While
    End Sub

    Private Sub BtnLOOP3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP3.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
        a = 1 : b = 1
        With LstRESULT
            .Items.Add("suku (1):" & CStr(a))
            .Items.Add("suku (2):" & CStr(b))
        End With
        i = 1
        Do While (i <= 8)
            c = a + b
            With LstRESULT
                .Items.Add("suku(i+2):" & CStr(c))
            End With
            a = b
            b = c
            i += 1
        Loop
    End Sub

    Private Sub BtnLOOP4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP4.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
        a = 1 : b = 1
        With LstRESULT
            .Items.Add("suku (1):" & CStr(a))
            .Items.Add("suku (2):" & CStr(b))
        End With
        i = 1
        Do Until (i > 8)
            c = a + b
            With LstRESULT
                .Items.Add("suku(i+2):" & CStr(c))
            End With
            a = b
            b = c
            i += 1
        Loop
    End Sub

    Private Sub BtnRESET_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRESET.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
    End Sub

    Private Sub BtnEXIT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEXIT.Click
        REM menutup from dan menutup aplikasi program
        Me.Close()

    End Sub
End Class

