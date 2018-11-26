<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.myMenu = New System.Windows.Forms.MenuStrip
        Me.mnFILE = New System.Windows.Forms.ToolStripMenuItem
        Me.subFile1 = New System.Windows.Forms.ToolStripMenuItem
        Me.subFile2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.myMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'myMenu
        '
        Me.myMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnFILE})
        Me.myMenu.Location = New System.Drawing.Point(0, 0)
        Me.myMenu.Name = "myMenu"
        Me.myMenu.Size = New System.Drawing.Size(537, 24)
        Me.myMenu.TabIndex = 0
        Me.myMenu.Text = "Full Down Menu"
        '
        'mnFILE
        '
        Me.mnFILE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.subFile1, Me.ToolStripSeparator1, Me.subFile2})
        Me.mnFILE.Name = "mnFILE"
        Me.mnFILE.Size = New System.Drawing.Size(37, 20)
        Me.mnFILE.Text = "&File"
        '
        'subFile1
        '
        Me.subFile1.Name = "subFile1"
        Me.subFile1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.subFile1.Size = New System.Drawing.Size(152, 22)
        Me.subFile1.Text = "New"
        '
        'subFile2
        '
        Me.subFile2.Name = "subFile2"
        Me.subFile2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.subFile2.Size = New System.Drawing.Size(152, 22)
        Me.subFile2.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 443)
        Me.Controls.Add(Me.myMenu)
        Me.Name = "Form1"
        Me.Text = "Aplikasi SIngle Doucment Interface"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.myMenu.ResumeLayout(False)
        Me.myMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents myMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnFILE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents subFile1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents subFile2 As System.Windows.Forms.ToolStripMenuItem

End Class
