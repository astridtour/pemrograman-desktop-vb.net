Public Class Form1
    Dim EjaanAngka(0 To 9) As String
    Dim AlamatFile As String = "E:\suara\aku\"

    'Private Declare Function mcisendstring Lib "WAV.dll" Alias "mcisendstringa" (ByVal Ipstycommand As String, ByVal IpstrReturnstring As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        'Lbl1 akan menampilkan bilangan acak antara 0-9'
        Dim angka As Integer = Int(Rnd() * 10)
        Lbl1.Text = CStr(angka)
        AxWindowsMediaPlayer1.URL = AlamatFile & EjaanAngka(angka)
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        'time diaktifkan'
        Timer1.Enabled = True
        'mengosongkan masing-masing label'
        Lbl1.Text = ""
       
        'My.Computer.Audio.Play("My.Resources.astrid_aja, AudioPlayMode.BackgroundLoop")
    End Sub

    Private Sub BtnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStop.Click
        Lbl1.Text = "?"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Timer1.Enabled = False
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2500
        EjaanAngka(0) = "nol.wav"
        EjaanAngka(1) = "satu.wav"
        EjaanAngka(2) = "dua.wav"
        EjaanAngka(3) = "tiga.wav"
        EjaanAngka(4) = "empat.wav"
        EjaanAngka(5) = "lima.wav"
        EjaanAngka(6) = "enam.wav"
        EjaanAngka(7) = "tujuh.wav"
        EjaanAngka(8) = "delapan.wav"
        EjaanAngka(9) = "sembilan.wav"


    End Sub
End Class
