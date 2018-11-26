Public Class Form1
    REM deklarasi variabel bilangan dan BykData 
    Dim bilangan() As Integer
    Dim BykData As Byte

    Function getSum(ByVal ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim i As Integer = 0
        For Each i In arr
            sum += i
        Next i
        Return sum
    End Function

    Function getAverage(ByVal ParamArray arr As Integer()) As Single
        Dim sum As Integer = 0
        Dim i As Integer = 0
        For Each i In arr
            sum += i
        Next i
        Return sum / BykData
    End Function

    Function getMax(ByVal ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim Max As Integer = arr(0)
        Dim i As Integer = 0
        For Each i In arr
            If Max > i Then
                Max = Max
            Else
                Max = i
            End If
        Next i
        Return Max
    End Function

    Function getMin(ByVal ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim Min As Integer = arr(0)
        Dim i As Integer = 0
        For Each i In arr
            If Min < i Then
                Min = Min
            Else
                Min = i
            End If
        Next i
        Return Min
    End Function


    Private Sub ClearTextBox(Optional ByVal nilai As Integer = 0)
        With Me
            .TextBox1.Text = CStr(nilai)
            .TextBox2.Text = CStr(nilai)
            .TextBox3.Text = CStr(nilai)
            .TextBox4.Text = CStr(nilai)
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM mengubah Text Button1 
        If Button1.Text = "Reset" Then
            REM memanggil prosedur ClearTextBox
            Call ClearTextBox()
            Button1.Text = "Input"
        Else
            REM menentukan Banyak Data
            BykData = CByte(InputBox("Tentukan Banyak Data", "Konfirmasi", 0))
            REM evaluasi banyak data
            If BykData = 0 Then
                MessageBox.Show("Apaan nech.............", "Peringatan", _
                                              MessageBoxButtons.OK, _
                                              MessageBoxIcon.Warning)
                REM keluar dari prosedur Button1_Click
                Exit Sub
            Else
                REM mendeklarasi ulang variabel bilangan
                ReDim bilangan(BykData)
                REM meminta masukan koleksi data tipe integer
                For i As Integer = 0 To BykData - 1 Step 1
                    bilangan(i) = CInt(InputBox("Tentukan Nilai", _
                                               "Data Ke-" & CStr(i + 1), 0))
                Next
                REM mengaktifkan button2
                Button2.Enabled = True
            End If


            Button1.Text = "Reset"
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM menonaktifkan button2
        Button2.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        REM mengisi Text dari TextBox1 dengan fungsi getSum
        TextBox1.Text = CStr(getSum(bilangan))
        REM mengisi Text dari TextBox2 dengan fungsi getAverage
        TextBox2.Text = CStr(getAverage(bilangan))
        REM mengisi Text dari TextBox3 dengan fungsi getMax
        TextBox3.Text = CStr(getMax(bilangan))
        REM mengisi Text dari TextBox4 dengan fungsi getMin
        TextBox4.Text = CStr(getMin(bilangan))
    End Sub
End Class
