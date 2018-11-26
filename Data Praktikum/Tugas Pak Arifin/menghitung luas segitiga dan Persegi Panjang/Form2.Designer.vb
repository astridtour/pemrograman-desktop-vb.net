<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TxtLebar = New System.Windows.Forms.TextBox()
        Me.TxtKeliling = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPanjang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtLuas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtLebar
        '
        Me.TxtLebar.Location = New System.Drawing.Point(105, 53)
        Me.TxtLebar.Name = "TxtLebar"
        Me.TxtLebar.Size = New System.Drawing.Size(100, 22)
        Me.TxtLebar.TabIndex = 12
        '
        'TxtKeliling
        '
        Me.TxtKeliling.Location = New System.Drawing.Point(105, 90)
        Me.TxtKeliling.Name = "TxtKeliling"
        Me.TxtKeliling.Size = New System.Drawing.Size(100, 22)
        Me.TxtKeliling.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Keliling :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lebar :"
        '
        'TxtPanjang
        '
        Me.TxtPanjang.Location = New System.Drawing.Point(105, 13)
        Me.TxtPanjang.Name = "TxtPanjang"
        Me.TxtPanjang.Size = New System.Drawing.Size(100, 22)
        Me.TxtPanjang.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Panjang :"
        '
        'TxtLuas
        '
        Me.TxtLuas.Location = New System.Drawing.Point(105, 130)
        Me.TxtLuas.Name = "TxtLuas"
        Me.TxtLuas.Size = New System.Drawing.Size(100, 22)
        Me.TxtLuas.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Luas :"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(238, 185)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 40)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(129, 185)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 40)
        Me.BtnReset.TabIndex = 16
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(14, 185)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(79, 40)
        Me.BtnHitung.TabIndex = 15
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 255)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtLuas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtLebar)
        Me.Controls.Add(Me.TxtKeliling)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPanjang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Persegi Panjang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLebar As System.Windows.Forms.TextBox
    Friend WithEvents TxtKeliling As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPanjang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtLuas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
End Class
