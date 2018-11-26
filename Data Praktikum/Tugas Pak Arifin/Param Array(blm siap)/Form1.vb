Public Class Form1
    REM deklarasi variabel bilangn dan banyak data
    Dim bilangan As Integer
    Dim bykdata As Byte
    Function getsum(ByVal ParamArray arr As Integer()) As Single
        Dim sum As Integer = 0
        Dim i As Integer = 0
        For Each i In Arr
            sum += i

        Next i
        Return sum
    End Function

    Private Sub cleartextbox(Optional ByVal nilai As Integer = 0)
        With Me
            .TextBox1.Text = CStr(nilai)
            .TextBox2.Text = CStr(nilai)
            .TextBox3.Text = CStr(nilai)
            .TextBox4.Text = CStr(nilai)
        End With
    End Sub

    'Function SUM(ByVal a As Integer, ByVal b As Integer) As Integer
    '    Dim x As Integer
    '    x = a + b
    '    Return x
    'End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bilangan As Integer
        Dim bykdata As Byte

        REM MENGUBAH TXT1 BTN 1
        If Button1.Text = "reset" Then
            REM memanggil clear textbox
            Call cleartextbox()
            Button1.Text = "input"
        Else
            REM menentukan banyak data
            REM b masukan koleksi data tipe integer
            'bykdata = MsgBox("tentukan banyak data?")
            bykdata = CByte(InputBox("tentukan banyak data", "konfirmasi", 0))
            If bykdata = 0 Then
                MessageBox.Show("isi data", "warning", _
                MessageBoxButtons.OK, _
                MessageBoxIcon.Warning)
                'MessageBox.Show("isikan data dengan benar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                REM keluar dari prosedur button1_click
                Exit Sub
            Else
                REM mendeklarsikan ulang variabel bilangan
                ReDim [bilangan](bykdata)

                REM memintan masukan koleksi data tipe integer
                For i As Integer = 0 To bykdata - 1 Step 1
                    bilangan(i) = CInt(InputBox("tentukan nilai", _
                                              "data ke- " & CStr(i + 1), 0))
                Next
                REM mengaktifkan tombol hasil
                Button3.Enabled = True

            End If
            Button1.Text = "reset"
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM menonaktifkan button 2
        Button3.Enabled = False

    End Sub
End Class
