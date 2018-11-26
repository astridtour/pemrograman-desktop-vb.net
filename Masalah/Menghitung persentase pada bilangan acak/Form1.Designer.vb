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
        Me.components = New System.ComponentModel.Container()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.BtnPersentase = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Eht1 = New System.Windows.Forms.Integration.ElementHost()
        Me.Eht2 = New System.Windows.Forms.Integration.ElementHost()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Txt1
        '
        Me.Txt1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt1.Font = New System.Drawing.Font("Monotype Corsiva", 100.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1.Location = New System.Drawing.Point(0, 26)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(227, 195)
        Me.Txt1.TabIndex = 0
        '
        'BtnPersentase
        '
        Me.BtnPersentase.Location = New System.Drawing.Point(542, 70)
        Me.BtnPersentase.Name = "BtnPersentase"
        Me.BtnPersentase.Size = New System.Drawing.Size(141, 48)
        Me.BtnPersentase.TabIndex = 1
        Me.BtnPersentase.Text = "Persentase :"
        Me.BtnPersentase.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(331, 315)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(139, 48)
        Me.BtnReset.TabIndex = 2
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(622, 315)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(139, 48)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Persentase Angka Ganjil :"
        '
        'Eht1
        '
        Me.Eht1.Location = New System.Drawing.Point(282, 223)
        Me.Eht1.Name = "Eht1"
        Me.Eht1.Size = New System.Drawing.Size(200, 30)
        Me.Eht1.TabIndex = 6
        Me.Eht1.Child = Nothing
        '
        'Eht2
        '
        Me.Eht2.Location = New System.Drawing.Point(596, 223)
        Me.Eht2.Name = "Eht2"
        Me.Eht2.Size = New System.Drawing.Size(200, 30)
        Me.Eht2.TabIndex = 8
        Me.Eht2.Text = "Peersentase Angka Genap :"
        Me.Eht2.Child = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Peersentase Angka Genap :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "[ Opsi Pengulangan : ]"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(282, 70)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(124, 21)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Do Until - Loop"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(282, 114)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Do While Loop"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 472)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Eht2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Eht1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnPersentase)
        Me.Controls.Add(Me.Txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnPersentase As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Eht1 As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents Eht2 As System.Windows.Forms.Integration.ElementHost
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton

End Class
