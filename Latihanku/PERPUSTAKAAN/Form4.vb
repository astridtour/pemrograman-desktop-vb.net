Public Class Form4

    Private Sub BUKUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUKUToolStripMenuItem.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub PEMINJAMANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEMINJAMANToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub ANGGOTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANGGOTAToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub TUTUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TUTUPToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class