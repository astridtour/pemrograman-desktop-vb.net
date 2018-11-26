Public Class Form1
    Dim i, j, r, s As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
    End Sub

    Private Sub BtnLOOP1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP1.Click
        REM mengosongkan items listbox
        i = 1
        j = 1
        LstRESULT.Items.Clear()
        i = <=10 : j = <=10

        With LstRESULT
            .Items.Add(" i):" & CStr(i))
            .Items.Add(" (j):" & CStr(j))
        End With


            For j = 1 To 10
                With LstRESULT
                .Items.Add("suku(i*j):" & CStr(r))
                End With
            i = j
            r = i * j
            Next
    End Sub

    Private Sub BtnLOOP2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP2.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
         i = <=10 : j = <=10
        With LstRESULT
            .Items.Add(" i):" & CStr(i))
            .Items.Add(" (j):" & CStr(j))
        End With
        i = j
        While (i <= 10)
            r = i + j
            With LstRESULT
                .Items.Add("suku(i*j):" & CStr(r))
            End With
            i = j
            i <= 10
        End While
    End Sub

    Private Sub BtnLOOP3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP3.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
         i = <=10 : j = <=10
        With LstRESULT
            .Items.Add(" i):" & CStr(i))
            .Items.Add(" (j):" & CStr(j))
        End With
        i = j
        Do While (i <= 10)
            r = i + j
            With LstRESULT
                .Items.Add("suku(i*j):" & CStr(r))
            End With
            i = j
        Loop
    End Sub
    Private Sub BtnLOOP4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLOOP4.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
         i = <=10 : j = <=10
        With LstRESULT
            .Items.Add(" i):" & CStr(i))
            .Items.Add(" (j):" & CStr(j))
        End With
        i = j
        Do Until (i >= 10)
            r = i + j
            With LstRESULT
                .Items.Add("suku(i*j):" & CStr(r))
            End With
            i = j
        Loop
    End Sub

    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click
        REM mengosongkan items listbox
        LstRESULT.Items.Clear()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        REM menutup from dan menutup aplikasi program
        Me.Close()
    End Sub
End Class

