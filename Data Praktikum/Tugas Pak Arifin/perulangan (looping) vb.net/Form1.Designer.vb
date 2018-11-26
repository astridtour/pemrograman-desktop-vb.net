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
        Me.BtnFORNEXT = New System.Windows.Forms.Button()
        Me.Lst1 = New System.Windows.Forms.ListBox()
        Me.BtnFOREACHNEXT = New System.Windows.Forms.Button()
        Me.BtnWHILE = New System.Windows.Forms.Button()
        Me.BtnDOUNTILLOOP = New System.Windows.Forms.Button()
        Me.BtnDOWHILELOOP = New System.Windows.Forms.Button()
        Me.BtnRESET = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnFORNEXT
        '
        Me.BtnFORNEXT.Location = New System.Drawing.Point(297, 97)
        Me.BtnFORNEXT.Name = "BtnFORNEXT"
        Me.BtnFORNEXT.Size = New System.Drawing.Size(140, 38)
        Me.BtnFORNEXT.TabIndex = 1
        Me.BtnFORNEXT.Text = "FOR-NEXT"
        Me.BtnFORNEXT.UseVisualStyleBackColor = True
        '
        'Lst1
        '
        Me.Lst1.FormattingEnabled = True
        Me.Lst1.ItemHeight = 16
        Me.Lst1.Location = New System.Drawing.Point(12, 12)
        Me.Lst1.Name = "Lst1"
        Me.Lst1.Size = New System.Drawing.Size(239, 356)
        Me.Lst1.TabIndex = 2
        '
        'BtnFOREACHNEXT
        '
        Me.BtnFOREACHNEXT.Location = New System.Drawing.Point(297, 141)
        Me.BtnFOREACHNEXT.Name = "BtnFOREACHNEXT"
        Me.BtnFOREACHNEXT.Size = New System.Drawing.Size(140, 38)
        Me.BtnFOREACHNEXT.TabIndex = 3
        Me.BtnFOREACHNEXT.Text = "FOR EACH-NEXT"
        Me.BtnFOREACHNEXT.UseVisualStyleBackColor = True
        '
        'BtnWHILE
        '
        Me.BtnWHILE.Location = New System.Drawing.Point(297, 273)
        Me.BtnWHILE.Name = "BtnWHILE"
        Me.BtnWHILE.Size = New System.Drawing.Size(140, 38)
        Me.BtnWHILE.TabIndex = 4
        Me.BtnWHILE.Text = "WHILE"
        Me.BtnWHILE.UseVisualStyleBackColor = True
        '
        'BtnDOUNTILLOOP
        '
        Me.BtnDOUNTILLOOP.Location = New System.Drawing.Point(297, 229)
        Me.BtnDOUNTILLOOP.Name = "BtnDOUNTILLOOP"
        Me.BtnDOUNTILLOOP.Size = New System.Drawing.Size(140, 38)
        Me.BtnDOUNTILLOOP.TabIndex = 5
        Me.BtnDOUNTILLOOP.Text = "DO UNTIL - LOOP"
        Me.BtnDOUNTILLOOP.UseVisualStyleBackColor = True
        '
        'BtnDOWHILELOOP
        '
        Me.BtnDOWHILELOOP.Location = New System.Drawing.Point(297, 185)
        Me.BtnDOWHILELOOP.Name = "BtnDOWHILELOOP"
        Me.BtnDOWHILELOOP.Size = New System.Drawing.Size(140, 38)
        Me.BtnDOWHILELOOP.TabIndex = 6
        Me.BtnDOWHILELOOP.Text = "DO WHILE - LOOP"
        Me.BtnDOWHILELOOP.UseVisualStyleBackColor = True
        '
        'BtnRESET
        '
        Me.BtnRESET.Location = New System.Drawing.Point(297, 12)
        Me.BtnRESET.Name = "BtnRESET"
        Me.BtnRESET.Size = New System.Drawing.Size(140, 66)
        Me.BtnRESET.TabIndex = 7
        Me.BtnRESET.Text = "RESET"
        Me.BtnRESET.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 391)
        Me.Controls.Add(Me.BtnRESET)
        Me.Controls.Add(Me.BtnDOWHILELOOP)
        Me.Controls.Add(Me.BtnDOUNTILLOOP)
        Me.Controls.Add(Me.BtnWHILE)
        Me.Controls.Add(Me.BtnFOREACHNEXT)
        Me.Controls.Add(Me.Lst1)
        Me.Controls.Add(Me.BtnFORNEXT)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnFORNEXT As System.Windows.Forms.Button
    Friend WithEvents Lst1 As System.Windows.Forms.ListBox
    Friend WithEvents BtnFOREACHNEXT As System.Windows.Forms.Button
    Friend WithEvents BtnWHILE As System.Windows.Forms.Button
    Friend WithEvents BtnDOUNTILLOOP As System.Windows.Forms.Button
    Friend WithEvents BtnDOWHILELOOP As System.Windows.Forms.Button
    Friend WithEvents BtnRESET As System.Windows.Forms.Button

End Class
