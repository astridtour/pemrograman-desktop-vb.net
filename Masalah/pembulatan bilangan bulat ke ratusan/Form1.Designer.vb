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
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Btnhasil = New System.Windows.Forms.Button()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Location = New System.Drawing.Point(1, 17)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(130, 17)
        Me.Lbl2.TabIndex = 0
        Me.Lbl2.Text = "sebelum dibulatkan"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Location = New System.Drawing.Point(-2, 71)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(123, 17)
        Me.Lbl1.TabIndex = 1
        Me.Lbl1.Text = "setelah dibulatkan"
        '
        'Btnhasil
        '
        Me.Btnhasil.Location = New System.Drawing.Point(26, 169)
        Me.Btnhasil.Name = "Btnhasil"
        Me.Btnhasil.Size = New System.Drawing.Size(75, 23)
        Me.Btnhasil.TabIndex = 2
        Me.Btnhasil.Text = "hasil"
        Me.Btnhasil.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(151, 12)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(100, 22)
        Me.Txt1.TabIndex = 3
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(151, 66)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(100, 22)
        Me.Txt2.TabIndex = 4
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(176, 169)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 268)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Btnhasil)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Lbl2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Btnhasil As System.Windows.Forms.Button
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button

End Class
