Module sounds
    Public Const SND_NOSTOP = &H10
    Public Declare Function sndPlaysound Lib "winmm.dll" Alias "sndPlaysoundA" (ByVal ByVal1pszsound)
End Module
Public Class Form1
    Dim sounds(14) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sounds(1) = My.Application.Info.DirectoryPath & "\audio\satu.wav"
        sounds(2) = My.Application.Info.DirectoryPath & "\audio\dua.wav"
        sounds(3) = My.Application.Info.DirectoryPath & "\audio\tiga.wav"
        sounds(4) = My.Application.Info.DirectoryPath & "\audio\empat.wav"
        sounds(5) = My.Application.Info.DirectoryPath & "\audio\lima.wav"
        sounds(6) = My.Application.Info.DirectoryPath & "\audio\enam.wav"
        sounds(7) = My.Application.Info.DirectoryPath & "\audio\tujuh.wav"
        sounds(8) = My.Application.Info.DirectoryPath & "\audio\delapan.wav"
        sounds(9) = My.Application.Info.DirectoryPath & "\audio\sembilan.wav"
    End Sub
    Sub panggil_L4()
        Dim arrJumlahKarakterSpasi() As String
        arrJumlahKarakterSpasi = Split(LblTerbilang.Text, " ")
        For i = LBound(arrJumlahKarakterSpasi) To UBound(arrJumlahKarakterSpasi)
            Call sndPlaysound(My.Application.Info.DirectoryPath & "\audio\ " & arrJumlahKarakterSpasi(i) & ".wav", SND_NOSTOP)
        Next
    End Sub
    Private Function terbilang(ByVal i As Integer) As String
        Dim angka() As String = {" nol ", " satu ", "dua ", "tiga ", "empat ", "lima ", "enam ", "tujuh ", "delapan ", "sembilan ", "sepulu ", "sebelas "}
        Dim hasil As String = " "

        Select Case i
            Case 1 To 11
                hasil &= angka(i)
            Case 12 To 19
                hasil &= angka(i Mod 10) & " belas "
            Case 20 To 99
                hasil &= terbilang(Int(i / 10)) & "puluh " & terbilang(i Mod 10)
            Case 100 To 199
                hasil &= " seratus " & terbilang(i Mod 100)
            Case 200 To 999
                hasil &= terbilang(Int(i / 100)) & " ratus " & terbilang(i Mod 100)
            Case 1000 To 1999
                hasil &= "seribu" & terbilang(i Mod 1000)
            Case 2000 To 9999
                hasil &= terbilang(Int(i / 1000)) & " ribu " & terbilang(i Mod 1000)
            Case Else : hasil &= angka(0)
        End Select
        Return hasil.Trim
    End Function

    Private Sub BtnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
        LblTerbilang.Text = terbilang(TextBox1.Text)
        'Call panggil_L4()
        With AxWindowsMediaPlayer1
            .URL = My.Application.Info.DirectoryPath & "\audio\" & Microsoft.VisualBasic.Trim(LblTerbilang.Text) & ".wav"
        End With

    End Sub

    Private Function sndPlaysound(ByVal p1 As String, ByVal SND_NOSTOP As Integer) As Integer
        '    Return Throw =New NotImplementedException
        Return 0
    End Function

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class