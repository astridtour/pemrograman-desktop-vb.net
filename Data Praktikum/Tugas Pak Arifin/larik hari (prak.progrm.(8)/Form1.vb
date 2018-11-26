Public Class Form1
    REM menginsialisasi nama hari dalam satu minggu
    Dim daysname() As String = {"minggu", "senin", "selasa", "rabu", "kamis", "jum'at", "sabtu"}
    'dim strangkabulan(0 to 12) as string
    Dim strangkabulan(12) As String
    Dim monthsname() As String = {"januari", "februari", "maret", "april", "mei", "juni", "juli", "agustus", "september", "oktober", "november", "desember"}
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        REM menentukan urutan focus
        CmbHari.TabIndex = 0
        CmbBulan.TabIndex = 1
        REM mengisi item ComboBOx dengan elemen daysname
        With CmbHari
            .Items.Clear()
            For i As Integer = 0 To 6 Step 1
                .Items.Add(DaysName(i))
            Next
            .Text = "[pilih]"
        End With
        REM mengisi items combo dengan string angka 01-12
        With CmbBulan
            .Items.Clear()
            For j As Integer = 1 To 12 Step 1
                strangkabulan(j - 1) = IIf(j < 10, CStr(0) & CStr(j), CStr(j))
                .Items.Add(strangkabulan(j - 1))
                '        .Items.Add(CStr(j))
            Next
            .Text = "-pilih-"
        End With

    End Sub

    Private Sub CmbHari_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbHari.SelectedIndexChanged
        Try
            REM memperoleh item combobox yang terpilih
            Dim indeksitemsterpilih As Integer = CmbHari.SelectedIndex
            REM memperoleh item terpilih sebagai text  textbox
            TxtHari.Text = daysname(indeksitemsterpilih)
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub CmbBulan_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBulan.SelectedIndexChanged
        Try
            REM memperoleh item combobox yang terpilih
            Dim indeksitemsterpilih As Integer = CmbBulan.SelectedIndex
            REM memperoleh item terpilih sebagai text  textbox
            TxtBulan.Text = monthsname(indeksitemsterpilih)
        Catch ex As Exception

        End Try
        
    End Sub
End Class
