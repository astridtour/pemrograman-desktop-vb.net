Public Class Form1
    Dim onSelection As Boolean = False
    Dim indeks As Integer
    Sub Normal()
        TXTa.Text = "" 'mengosongkan property Text kontrol TXTa
        TXTb.Text = "" 'mengosongkan property Text kontrol TXTb
        TXTc.Text = "" 'mengosongkan property Text kontrol TXTc
        TXTd.Text = "" 'mengosongkan property Text kontrol TXTd
        TxtE.Text = "" 'mengosongkan property Text kontrol TXTe End Sub
    End Sub

    Private Sub BtnConfig_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnConfig.Click
        'Mengkonfigurasi ListView 
        With LSVTabel
            'membatalkan seluruh items
            .Items.Clear()
            'memilih tipe View Details (Baris dan Kolom ditampilkan)
            .View = View.Details
            'membuat kolom meliputi teks judul, lebar kolom, perataan teks judul
            .Columns.Add("A", 80, HorizontalAlignment.Left)
            .Columns.Add("B", 80, HorizontalAlignment.Center)
            .Columns.Add("C", 80, HorizontalAlignment.Center)
            .Columns.Add("D", 80, HorizontalAlignment.Center)
            .Columns.Add("E", 80, HorizontalAlignment.Center)
            'menampilkan grid (garis bantu)
            .GridLines = True
            'mengaktifkan  tipe seleksian secara perbaris
            .FullRowSelect = True
        End With
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        'menginisialisasi var myTable sbg ListViewItems
        Dim myTable As ListViewItem
        myTable = New ListViewItem
        'mengisi ListViewItems myTable dengan Item baru yaitu Text dan SubItems
        With myTable
            .Text = 10
            .SubItems.Add(20)
            .SubItems.Add(30)
            .SubItems.Add(40)
            .SubItems.Add(50)
        End With
        'mengisi myTable sbg item baru ke ListView
        LSVTabel.Items.Add(myTable)
        'menginstansiasi myTable sebagai ListViewItem baru
        myTable = New ListViewItem
        'mengisi ListViewItems myTable dengan Item baru yaitu Text dan SubItems
        With myTable
            .Text = "x"
            .SubItems.Add("y")
            .SubItems.Add("o")
            .SubItems.Add("p")
            .SubItems.Add("q")
        End With
        'mengisi myTable sbg item baru ke ListView
        LSVTabel.Items.Add(myTable)

    End Sub

    Private Sub BtnSetting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSetting.Click
        'Mengkonfigurasi DataGridView
        With DGVTabel
            'menghapus seluruh kolom yang sudah ada
            .Columns.Clear()
            'menentukan jumlah kolom
            .ColumnCount = 5
            'menginisialisasi teks judul setiap kolom
            .Columns(0).HeaderText = "A"
            .Columns(1).HeaderText = "B"
            .Columns(2).HeaderText = "C"
            .Columns(3).HeaderText = "D"
            .Columns(4).HeaderText = "E"
            'menginisialisasi lebar setiap kolom
            .Columns(0).Width = 80
            .Columns(1).Width = 80
            .Columns(2).Width = 80
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            'memilih perataan teks judul kolom
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'mengaktifkan tipe seleksian secara perbaris
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'memilih perataan pencetakan data setiap kolom
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'membuat warna latar cell setiap baris berbeda
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
        End With
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        'mengisi baris baru / data setiap kolom DataGridView
        'data bertipe integer atau float tanpa tanda kutip
        DGVTabel.Rows.Add(10, 20, 30, 40, 50)
        'data bertipe teks (string) diapit tanda kutip
        DGVTabel.Rows.Add("x", "y", " o", " p", "q")

    End Sub

    Private Sub DGVTabel_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVTabel.CellEnter
        'mengisi nilai baru (true) ke var onSelection onSelection = True
    End Sub

    Private Sub DGVTabel_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGVTabel.CellMouseDoubleClick
        'mengunci cell baris data yg terpilih
        DGVTabel.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True

    End Sub

    Private Sub DGVTabel_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVTabel.RowEnter
        If onSelection Then 'menguji variabel onSelection
            Try
                indeks = e.RowIndex 'membaca indeks baris data yg tersorot
                With DGVTabel
                    'Mengisi nilai property Text masing-masing objek kontrol TextBox TXT ....
                    'dengan nilai Cell baris data yg tersorot
                    TxtA.Text = .Rows(indeks).Cells(0).Value.ToString
                    TxtB.Text = .Rows(indeks).Cells(1).Value.ToString
                    TxtC.Text = .Rows(indeks).Cells(2).Value.ToString
                    TxtD.Text = .Rows(indeks).Cells(3).Value.ToString
                    TxtE.Text = .Rows(indeks).Cells(4).Value.ToString
                End With
            Catch ex As Exception
                Exit Try 'keluar dari blok Try 
            End Try
            onSelection = False 'mengembalikan nilai var onSelection ke nilai awal 
        End If
    End Sub

    Private Sub LSVTabel_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles LSVTabel.ItemSelectionChanged
        Try
            'membaca indeks items yg tersorot
            indeks = e.ItemIndex
            With LSVTabel
                'mengisi Text TXTa dgn nilai Text items ybs
                TxtA.Text = .Items(indeks).Text
                'mengisi Text TXTb dgn SubItems(1) items ybs
                TxtB.Text = .Items(indeks).SubItems(1).Text
                'mengisi Text TXTc dgn SubItems(2) items ybs
                TxtC.Text = .Items(indeks).SubItems(2).Text
                'mengisi Text TXTd dgn SubItems(3) items ybs
                TxtD.Text = .Items(indeks).SubItems(3).Text
                'mengisi Text TXTe dgn SubItems(4) items ybs
                TxtE.Text = .Items(indeks).SubItems(4).Text 'mengubah nilai var Onselection ke nilai awal
                onSelection = False
            End With
Catch ex As Exception
            Exit Try 'keluar dari blok Try
        End Try

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        Try
            'menghapus items Listview yg sedang tersorot LSVtabel.Items.RemoveAt(indeks)
        Catch ex As Exception
            Exit Try 'keluar dari blok Try
        Finally
            Normal() 'memanggil prosedur Normal()
        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            'menghapus baris data DataGridView yg tersorot DGVtabel.Rows.RemoveAt(indeks)
        Catch ex As Exception
            Exit Try 'keluar dari blok Try
        Finally
            Normal() 'memanggil prosedur Normal
        End Try

    End Sub

    Private Sub BtnUbah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        Try
            'mengubah item yang terpilih dengan nilai baru
            With LSVTabel
                'mengubah nilai Text item terpilih dengan nilai Text kontrol TXTa
                .Items(indeks).Text = TxtA.Text
                'mengubah nilai Text SubItems(1) dari item terpilih dengan nilai Text kontrol TXTb .Items(indeks).SubItems(1).Text = TXTb.Text
                'mengubah nilai Text SubItems(2) dari item terpilih dengan nilai Text kontrol TXTc .Items(indeks).SubItems(2).Text = TXTc.Text
                'mengubah nilai Text SubItems(3) dari item terpilih dengan nilai Text kontrol TXTd .Items(indeks).SubItems(3).Text = TXTd.Text
                'mengubah nilai Text SubItems(4) dari item terpilih dengan nilai Text kontrol TXTe
                .Items(indeks).SubItems(4).Text = TxtE.Text
            End With
        Catch ex As Exception
            'keluar dari blok Try Exit Try
        Finally
            'memanggil prosedur Normal Normal()
        End Try

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Try
            'mengubah nilai cell baris data yang terpilih dengan nilai baru
            With DGVTabel
                'nilai baru Cells(0) adalah nilai Text kontrol TXTa .Rows(indeks).Cells(0).Value = TXTa.Text
                'nilai baru Cells(1) adalah nilai Text kontrol TXTb
                .Rows(indeks).Cells(1).Value = TxtB.Text
                'nilai baru Cells(2) adalah nilai Text kontrol TXTc .Rows(indeks).Cells(2).Value = TXTc.Text
                'nilai baru Cells(3) adalah nilai Text kontrol TXTd
                .Rows(indeks).Cells(3).Value = TxtD.Text
                'nilai baru Cells(4) adalah nilai Text kontrol TXTe
                .Rows(indeks).Cells(4).Value = TxtE.Text
            End With
Catch ex As Exception
            'keluar dari blok Try-Catch Exit Try
        Finally
            'memanggil prosedur Normal Normal()
        End Try

    End Sub
End Class
