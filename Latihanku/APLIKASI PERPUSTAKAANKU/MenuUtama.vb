Public Class MenuUtama

    Private Sub ANGGOTAToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANGGOTAToolStripMenuItem1.Click
        Anggota.Show()
        Me.Hide()
    End Sub

    Private Sub BUKUToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUKUToolStripMenuItem1.Click
        FormBuku.Show()
        Me.Hide()
    End Sub

    Private Sub PEMINJAMANToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEMINJAMANToolStripMenuItem1.Click
        Peminjaman.Show()
        Me.Hide()
    End Sub
    Private Sub PENGEMBALIANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENGEMBALIANToolStripMenuItem.Click
        Pengembalian.Show()
        Me.Hide()
    End Sub

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        MsgBox("SERIUS ANDA MAU MENUTUP APLIKASI INI?")
        Me.Close()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        MsgBox("APAKAH ANDA INGIN KELUAR ? ")
        Login.Show()
    End Sub

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
