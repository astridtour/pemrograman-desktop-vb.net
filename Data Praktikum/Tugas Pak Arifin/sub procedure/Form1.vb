Public Class Form1
    REM definsi peosedur sub hapusisitextbox
    Dim A, B, C, D, En, F As Integer

    Private Sub kirimberdasarkanNilai(ByVal param1 As Integer, _
        ByVal param2 As Integer, ByVal param3 As Integer, ByVal param4 As Integer, ByVal param5 As Integer, ByVal param6 As Integer)
        A += 10
        B += 10
        C += 10
        D += 10
        En += 10
        F += 10

        'A += 0
        'B += 0
        'C += 0
        'D += 0
        'En += 0
        'F += 0
    End Sub
    Private Sub kirimberdasarkanReferensi(ByRef param1 As Integer, _
        ByRef param2 As Integer, ByRef param3 As Integer, ByRef param4 As Integer, ByRef param5 As Integer, ByRef param6 As Integer)
        A += 10
        B += 10
        C += 10
        D += 10
        En += 10
        F += 10

        'A += 0
        'B += 0
        'C += 0
        'D += 0
        'En += 0
        'F += 0
    End Sub

    Private Sub HapusTeks()
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txt6.Clear()
    End Sub

    Private Sub isitextbox()
        txt1.Text = 1
        txt2.Text = 2
        txt3.Text = 3
        txt4.Text = 4
        txt5.Text = 5
        txt6.Text = 6

    End Sub
    Sub storetextBox(ByVal v1 As Byte, ByVal v2 As Byte, ByVal v3 As Byte, ByVal v4 As Byte, ByVal v5 As Byte, ByVal v6 As Byte)
        txt1.Text = v1
        txt2.Text = v2
        txt3.Text = v3
        txt4.Text = v4
        txt5.Text = v5
        txt6.Text = v6

    End Sub
    Sub filltextBox(Optional ByVal v1 As Byte = 0, _
                    Optional ByVal v2 As Byte = 0, _
                    Optional ByVal v3 As Byte = 0, _
                    Optional ByVal v4 As Byte = 0, _
                    Optional ByVal v5 As Byte = 0, _
                    Optional ByVal v6 As Byte = 0)

        txt1.Text = v1
        txt2.Text = v2
        txt3.Text = v3
        txt4.Text = v4
        txt5.Text = v5
        txt6.Text = v6

    End Sub

    Private Sub cleartextbox()
        For Each kotakinput As Control In Me.Controls
            If TypeOf kotakinput Is TextBox Then
                kotakinput.Text = ""

            End If
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        'Memanggil prosedur sub HapusIsiTextbox
        'Call HapusIsitextBox()
        REM memanggil prosedur sub cleartextbox
        'cleartextbox()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDefault.Click
        'Call storetextBox(10, 20, " ", " ", " ", 40)
        Call filltextBox()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        cleartextbox()
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'menginisialisasi nilai variabel A,B,C,D,E dan F
        A = 1
        B = 2
        C = 3
        D = 4
        En = 5
        F = 6

    End Sub

    Private Sub BtnValue_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnValue.Click
        REM memangggil prosedur sub kirimberdasarkanNilai
        'Call kirimberdasarkanNilai(A, B, C, D, En, F)
        Call filltextBox(A, B, C, D, En, F)

    End Sub

    Private Sub Btnferensi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReferensi.Click
        REM memangggil prosedur sub kirimberdasarkanReferensi
        Call kirimberdasarkanReferensi(A, B, C, D, En, F)
        Call filltextBox(A, B, C, D, En, F)
    End Sub
End Class
