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
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.TxtAlas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLuas = New System.Windows.Forms.TextBox()
        Me.TxtTinggi = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPersegiPanjang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alas :"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(28, 188)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(79, 40)
        Me.BtnHitung.TabIndex = 1
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'TxtAlas
        '
        Me.TxtAlas.Location = New System.Drawing.Point(118, 23)
        Me.TxtAlas.Name = "TxtAlas"
        Me.TxtAlas.Size = New System.Drawing.Size(100, 22)
        Me.TxtAlas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tinggi :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Luas :"
        '
        'TxtLuas
        '
        Me.TxtLuas.Location = New System.Drawing.Point(118, 112)
        Me.TxtLuas.Name = "TxtLuas"
        Me.TxtLuas.Size = New System.Drawing.Size(100, 22)
        Me.TxtLuas.TabIndex = 5
        '
        'TxtTinggi
        '
        Me.TxtTinggi.Location = New System.Drawing.Point(118, 63)
        Me.TxtTinggi.Name = "TxtTinggi"
        Me.TxtTinggi.Size = New System.Drawing.Size(100, 22)
        Me.TxtTinggi.TabIndex = 6
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(143, 188)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 40)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(252, 188)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 40)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPersegiPanjang
        '
        Me.BtnPersegiPanjang.Location = New System.Drawing.Point(252, 23)
        Me.BtnPersegiPanjang.Name = "BtnPersegiPanjang"
        Me.BtnPersegiPanjang.Size = New System.Drawing.Size(75, 111)
        Me.BtnPersegiPanjang.TabIndex = 9
        Me.BtnPersegiPanjang.Text = "Persegi Panjang"
        Me.BtnPersegiPanjang.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 240)
        Me.Controls.Add(Me.BtnPersegiPanjang)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.TxtTinggi)
        Me.Controls.Add(Me.TxtLuas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtAlas)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Program Hitung Luas Segitiga"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents TxtAlas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLuas As System.Windows.Forms.TextBox
    Friend WithEvents TxtTinggi As System.Windows.Forms.TextBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnPersegiPanjang As System.Windows.Forms.Button

End Class
