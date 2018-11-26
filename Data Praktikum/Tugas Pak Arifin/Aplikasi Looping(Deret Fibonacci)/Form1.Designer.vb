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
        Me.BtnEXIT = New System.Windows.Forms.Button()
        Me.BtnRESET = New System.Windows.Forms.Button()
        Me.BtnLOOP4 = New System.Windows.Forms.Button()
        Me.BtnLOOP3 = New System.Windows.Forms.Button()
        Me.BtnLOOP2 = New System.Windows.Forms.Button()
        Me.BtnLOOP1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Looping Result :"
        '
        'LstRESULT
        '
        Me.LstRESULT.FormattingEnabled = True
        Me.LstRESULT.ItemHeight = 28
        Me.LstRESULT.Location = New System.Drawing.Point(5, 44)
        Me.LstRESULT.Name = "LstRESULT"
        Me.LstRESULT.Size = New System.Drawing.Size(255, 284)
        Me.LstRESULT.TabIndex = 1
        '
        'BtnEXIT
        '
        Me.BtnEXIT.Location = New System.Drawing.Point(145, 334)
        Me.BtnEXIT.Name = "BtnEXIT"
        Me.BtnEXIT.Size = New System.Drawing.Size(115, 38)
        Me.BtnEXIT.TabIndex = 2
        Me.BtnEXIT.Text = "&Exit"
        Me.BtnEXIT.UseVisualStyleBackColor = True
        '
        'BtnRESET
        '
        Me.BtnRESET.Location = New System.Drawing.Point(5, 334)
        Me.BtnRESET.Name = "BtnRESET"
        Me.BtnRESET.Size = New System.Drawing.Size(115, 38)
        Me.BtnRESET.TabIndex = 3
        Me.BtnRESET.Text = "&Reset"
        Me.BtnRESET.UseVisualStyleBackColor = True
        '
        'BtnLOOP4
        '
        Me.BtnLOOP4.Location = New System.Drawing.Point(327, 166)
        Me.BtnLOOP4.Name = "BtnLOOP4"
        Me.BtnLOOP4.Size = New System.Drawing.Size(224, 42)
        Me.BtnLOOP4.TabIndex = 4
        Me.BtnLOOP4.Text = "DO UNTIL-LOOP"
        Me.BtnLOOP4.UseVisualStyleBackColor = True
        '
        'BtnLOOP3
        '
        Me.BtnLOOP3.Location = New System.Drawing.Point(327, 133)
        Me.BtnLOOP3.Name = "BtnLOOP3"
        Me.BtnLOOP3.Size = New System.Drawing.Size(224, 41)
        Me.BtnLOOP3.TabIndex = 5
        Me.BtnLOOP3.Text = "DO WHILE-LOOP"
        Me.BtnLOOP3.UseVisualStyleBackColor = True
        '
        'BtnLOOP2
        '
        Me.BtnLOOP2.Location = New System.Drawing.Point(327, 94)
        Me.BtnLOOP2.Name = "BtnLOOP2"
        Me.BtnLOOP2.Size = New System.Drawing.Size(224, 42)
        Me.BtnLOOP2.TabIndex = 6
        Me.BtnLOOP2.Text = "WHILE"
        Me.BtnLOOP2.UseVisualStyleBackColor = True
        '
        'BtnLOOP1
        '
        Me.BtnLOOP1.Location = New System.Drawing.Point(327, 55)
        Me.BtnLOOP1.Name = "BtnLOOP1"
        Me.BtnLOOP1.Size = New System.Drawing.Size(224, 48)
        Me.BtnLOOP1.TabIndex = 7
        Me.BtnLOOP1.Text = "FOR-NEXT"
        Me.BtnLOOP1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 442)
        Me.Controls.Add(Me.BtnLOOP1)
        Me.Controls.Add(Me.BtnLOOP2)
        Me.Controls.Add(Me.BtnLOOP3)
        Me.Controls.Add(Me.BtnLOOP4)
        Me.Controls.Add(Me.BtnRESET)
        Me.Controls.Add(Me.BtnEXIT)
        Me.Controls.Add(Me.LstRESULT)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstRESULT As System.Windows.Forms.ListBox
    Friend WithEvents BtnEXIT As System.Windows.Forms.Button
    Friend WithEvents BtnRESET As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP4 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP3 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP2 As System.Windows.Forms.Button
    Friend WithEvents BtnLOOP1 As System.Windows.Forms.Button

End Class
