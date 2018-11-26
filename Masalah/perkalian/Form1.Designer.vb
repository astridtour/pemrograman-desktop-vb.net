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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LstRESULT = New System.Windows.Forms.ListBox()
        Me.BtnLOOP1 = New System.Windows.Forms.Button()
        Me.BtnLOOP2 = New System.Windows.Forms.Button()
        Me.BtnLOOP3 = New System.Windows.Forms.Button()
        Me.BtnLOOP4 = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Looping Result :"
        '
        'LstRESULT
        '
        Me.LstRESULT.FormattingEnabled = True
        Me.LstRESULT.ItemHeight = 16
        Me.LstRESULT.Location = New System.Drawing.Point(16, 55)
        Me.LstRESULT.Name = "LstRESULT"
        Me.LstRESULT.Size = New System.Drawing.Size(232, 276)
        Me.LstRESULT.TabIndex = 1
        '
        'BtnLOOP1
        '
        Me.BtnLOOP1.Location = New System.Drawing.Point(308, 55)
        Me.BtnLOOP1.Name = "BtnLOOP1"
        Me.BtnLOOP1.Size = New System.Drawing.Size(167, 48)
        Me.BtnLOOP1.TabIndex = 2
        Me.BtnLOOP1.Text = "FOR-NEXT"
        Me.BtnLOOP1.UseVisualStyleBackColor = True
        '
        'BtnLOOP2
        '
        Me.BtnLOOP2.Location = New System.Drawing.Point(308, 109)
        Me.BtnLOOP2.Name = "BtnLOOP2"
        Me.BtnLOOP2.Size = New System.Drawing.Size(167, 41)
        Me.BtnLOOP2.TabIndex = 3
        Me.BtnLOOP2.Text = "WHILE"
        Me.BtnLOOP2.UseVisualStyleBackColor = True
        '
        'BtnLOOP3
        '
        Me.BtnLOOP3.Location = New System.Drawing.Point(308, 156)
        Me.BtnLOOP3.Name = "BtnLOOP3"
        Me.BtnLOOP3.Size = New System.Drawing.Size(167, 46)
        Me.BtnLOOP3.TabIndex = 4
        Me.BtnLOOP3.Text = "DO WHILE-LOOP"
        Me.BtnLOOP3.UseVisualStyleBackColor = True
        '
        'BtnLOOP4
        '
        Me.BtnLOOP4.Location = New System.Drawing.Point(308, 208)
        Me.BtnLOOP4.Name = "BtnLOOP4"
        Me.BtnLOOP4.Size = New System.Drawing.Size(167, 42)
        Me.BtnLOOP4.TabIndex = 5
        Me.BtnLOOP4.Text = "DO UNTIL-LOOP"
        Me.BtnLOOP4.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(173, 347)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(16, 347)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 404)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnLOOP4)
        Me.Controls.Add(Me.BtnLOOP3)
        Me.Controls.Add(Me.BtnLOOP2)
        Me.Controls.Add(Me.BtnLOOP1)
        Me.Controls.Add(Me.LstRESULT)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstRESULT As System.Windows.Forms.ListBox
    Friend WithEvents BtnLOOP1 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP2 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP3 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP4 As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
