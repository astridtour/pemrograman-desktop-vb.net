Public Class Form1
    'Dim i As Integer
    'Dim bilangan(10) As Integer
    Dim EjaanAngka() As String = {"zero.wav", "one.wav", "two.wav", "tiga.wav", "empat.wav", "lima.wav", "enam.wav", "tujuh.wav", "delapan.wav", "sembilan.wav"}
    Dim AlamatFile As String = Environment.CurrentDirectory & "\suara\"

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Txt1.Clear()
    End Sub


    'Private Sub BtnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
    '    ''Call panggil_L4()
    '    'With AxWindowsMediaPlayer1
    '    '    .URL = My.Application.Info.DirectoryPath & "\audio\" & Microsoft.VisualBasic.Trim(Txt1.Text) & ".wav"
    '    'End With

    '    Dim EjaanAngka(10) As String
    '    Txt1.Text = CStr(Txt1.Text)
    '    AxWindowsMediaPlayer1.URL = AlamatFile & EjaanAngka.Length = 10
    '    AxWindowsMediaPlayer1.Ctlcontrols.play()
    'End Sub
    'Private Function sndPlaysound(ByVal p1 As String, ByVal SND_NOSTOP As Integer) As Integer
    '    'Return Throw =New NotImplementedException
    '    Return 0
    'End Function

    Private Sub BtnPlay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPlay.Click
        If Not IsNumeric(Txt1.Text) Then
            Exit Sub
        Else
            Dim angka As Integer = CInt(Txt1.Text)
            My.Computer.Audio.Play(AlamatFile & EjaanAngka(angka))
        End If
      
    End Sub
End Class
