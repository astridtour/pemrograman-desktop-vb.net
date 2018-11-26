Option Explicit On
Public Class Form1

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        Txt1.Text = ""
        Txt2.Text = ""
        Txt1.Focus()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txt2.Enabled = False
    End Sub
    Public Function BinToDes(ByVal NBiner As String) As Long
        Dim A As Integer
        Dim B As Long
        Dim Nilai As Long
        On Error GoTo ErrorHandler
        B = 1
        For A = Len(NBiner) To 1 Step -1
            If Mid(NBiner, A, 1) = "1" Then Nilai = Nilai + B
            B = B * 2
        Next
        BinToDes = Nilai
        Exit Function
ErrorHandler:
        BinToDes = 0
    End Function
    Public Function DesToBin(ByVal NDesimal As Long) As String
        Dim C As Byte
        Dim D As Long
        Dim Nilai As Integer
        On Error GoTo ErrorHandler
        D = (2 ^ 31) - 1
        While D > 0
            If NDesimal - D >= 0 Then
                NDesimal = NDesimal - D
                Nilai = Nilai & "1"
            Else
                If Val(Nilai) > 0 Then Nilai = Nilai & "0"
            End If
            D = D / 2
        End While
        DesToBin = Nilai
        Exit Function
ErrorHandler:
        DesToBin = 0
    End Function
    Public Function DesToHex(ByVal NDesimal As Long) As String
        DesToHex = Hex(NDesimal)
    End Function

    Public Function HexToDes(ByVal NHexa As String) As Long
        Dim E As Integer
        Dim Nilai As Long
        Dim F As Long
        Dim CharNilai As Byte
        On Error GoTo ErrorHandler
        For E = Len(NHexa) To 1 Step -1
            Select Case Mid(NHexa, E, 1)
                Case "0" To "9" : CharNilai = CInt(Mid(NHexa, E, 1))
                Case Else : CharNilai = Asc(Mid(NHexa, E, 1)) - 55
            End Select
            Nilai = Nilai + ((16 ^ F) * CharNilai)
            F = F + 1
        Next E
        HexToDes = Nilai
        Exit Function
ErrorHandler:
        HexToDes = 0
    End Function
    Public Function DesToOk(ByVal NDesimal As Long) As String
        DesToOk = Oct(NDesimal)
    End Function
    Public Function OkToDes(ByVal NOktal As String) As Long
        Dim G As Integer
        Dim H As Long
        Dim Nilai As Long
        On Error GoTo ErrorHandler
        For G = Len(NOktal) To 1 Step -1
            Nilai = Nilai + (8 ^ H) * CInt(Mid(NOktal, G, 1))
            H = H + 1
        Next G
        OkToDes = Nilai
        Exit Function
ErrorHandler:
        OkToDes = 0
    End Function
    Public Function BinToOk(ByVal bin As Long) As String
        BinToOk = DesToOk(BinToDes(bin))
    End Function

    Public Function OkToBin(ByVal NOktal As Double) As String
        OkToBin = DesToBin(OkToDes(NOktal))
    End Function
    Public Function BinToHex(ByVal NBiner As Long) As String
        BinToHex = DesToHex(BinToDes(NBiner))
    End Function

    Public Function OkToHex(ByVal NOktal As Double) As String
        OkToHex = DesToHex(OkToDes(NOktal))
    End Function

    Public Function HexToBin(ByVal NHexa As String) As String
        HexToBin = DesToBin(HexToDes(NHexa))
    End Function
    Public Function HexToOk(ByVal NHexa As String) As Double
        HexToOk = DesToOk(HexToDes(NHexa))
    End Function

    Private Sub BtnKonversi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKonversi.Click
        If Bin_in.Checked And Desout.Checked Then Txt2.Text = BinToDes(Txt1.Text)
        If Bin_in.Checked And Binout.Checked Then Txt2.Text = Txt1.Text
        If Bin_in.Checked And Octout.Checked Then Txt2.Text = BinToOk(Txt1.Text)
        If Bin_in.Checked And Hexout.Checked Then Txt2.Text = BinToHex(Txt1.Text)
        If Des_in.Checked And Binout.Checked Then Txt2.Text = DesToBin(Txt1.Text)
        If Des_in.Checked And Desout.Checked Then Txt2.Text = Txt1.Text
        If Des_in.Checked And Octout.Checked Then Txt2.Text = DesToOk(Txt1.Text)
        If Des_in.Checked And Hexout.Checked Then Txt2.Text = DesToHex(Txt1.Text)
        If oct_in.Checked And Binout.Checked Then Txt2.Text = OkToBin(Txt1.Text)
        If oct_in.Checked And Hexout.Checked Then Txt2.Text = OkToHex(Txt1.Text)
        If oct_in.Checked And Desout.Checked Then Txt2.Text = OkToDes(Txt1.Text)
        If oct_in.Checked And Octout.Checked Then Txt2.Text = Txt1.Text
        If Hex_in.Checked And Binout.Checked Then Txt2.Text = HexToBin(Txt1.Text)
        If Hex_in.Checked And Desout.Checked Then Txt2.Text = HexToDes(Txt1.Text)
        If Hex_in.Checked And Octout.Checked Then Txt2.Text = HexToOk(Txt1.Text)
        If Hex_in.Checked And Hexout.Checked Then Txt2.Text = Txt1.Text
        If Txt1.Text = "" Then
            MsgBox("maaf ???? anda belum memasukan bilangan")
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim tutup As String
        tutup = MessageBox.Show("Anda Yakin Ingin Menutup Program ini ?", "INFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tutup = MsgBoxResult.Yes Then
            End
        Else
        End If
    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Dim strangka() = {"0000", "0000"}
            Txt2.Text = strangka(0) & Space(5) & strangka(1)
            Txt2.Text = Txt2.Text & vbCrLf & "0"
            Txt2.TextAlign = HorizontalAlignment.Right

        End If

    End Sub
End Class
