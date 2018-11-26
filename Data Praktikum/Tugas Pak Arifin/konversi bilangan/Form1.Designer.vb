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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Hex_in = New System.Windows.Forms.RadioButton()
        Me.oct_in = New System.Windows.Forms.RadioButton()
        Me.Bin_in = New System.Windows.Forms.RadioButton()
        Me.Des_in = New System.Windows.Forms.RadioButton()
        Me.BtnKonversi = New System.Windows.Forms.Button()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hexout = New System.Windows.Forms.RadioButton()
        Me.Octout = New System.Windows.Forms.RadioButton()
        Me.Binout = New System.Windows.Forms.RadioButton()
        Me.Desout = New System.Windows.Forms.RadioButton()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Keluaran :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukkan Nilai :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PROGRAM KONVERSI BILANGAN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Hex_in)
        Me.GroupBox1.Controls.Add(Me.oct_in)
        Me.GroupBox1.Controls.Add(Me.Bin_in)
        Me.GroupBox1.Controls.Add(Me.Des_in)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 155)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukan :"
        '
        'Hex_in
        '
        Me.Hex_in.AutoSize = True
        Me.Hex_in.Location = New System.Drawing.Point(6, 118)
        Me.Hex_in.Name = "Hex_in"
        Me.Hex_in.Size = New System.Drawing.Size(109, 21)
        Me.Hex_in.TabIndex = 6
        Me.Hex_in.TabStop = True
        Me.Hex_in.Text = "Hexadesimal"
        Me.Hex_in.UseVisualStyleBackColor = True
        '
        'oct_in
        '
        Me.oct_in.AutoSize = True
        Me.oct_in.Location = New System.Drawing.Point(6, 82)
        Me.oct_in.Name = "oct_in"
        Me.oct_in.Size = New System.Drawing.Size(62, 21)
        Me.oct_in.TabIndex = 2
        Me.oct_in.TabStop = True
        Me.oct_in.Text = "Octal"
        Me.oct_in.UseVisualStyleBackColor = True
        '
        'Bin_in
        '
        Me.Bin_in.AutoSize = True
        Me.Bin_in.Location = New System.Drawing.Point(6, 51)
        Me.Bin_in.Name = "Bin_in"
        Me.Bin_in.Size = New System.Drawing.Size(62, 21)
        Me.Bin_in.TabIndex = 1
        Me.Bin_in.TabStop = True
        Me.Bin_in.Text = "Biner"
        Me.Bin_in.UseVisualStyleBackColor = True
        '
        'Des_in
        '
        Me.Des_in.AutoSize = True
        Me.Des_in.Location = New System.Drawing.Point(6, 18)
        Me.Des_in.Name = "Des_in"
        Me.Des_in.Size = New System.Drawing.Size(79, 21)
        Me.Des_in.TabIndex = 0
        Me.Des_in.TabStop = True
        Me.Des_in.Text = "Desimal"
        Me.Des_in.UseVisualStyleBackColor = True
        '
        'BtnKonversi
        '
        Me.BtnKonversi.Location = New System.Drawing.Point(18, 312)
        Me.BtnKonversi.Name = "BtnKonversi"
        Me.BtnKonversi.Size = New System.Drawing.Size(94, 44)
        Me.BtnKonversi.TabIndex = 0
        Me.BtnKonversi.Text = "Konversi"
        Me.BtnKonversi.UseVisualStyleBackColor = True
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(12, 76)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(154, 22)
        Me.Txt1.TabIndex = 4
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(263, 76)
        Me.Txt2.Multiline = True
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(122, 22)
        Me.Txt2.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Hexout)
        Me.GroupBox2.Controls.Add(Me.Octout)
        Me.GroupBox2.Controls.Add(Me.Binout)
        Me.GroupBox2.Controls.Add(Me.Desout)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 155)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Konversi :"
        '
        'Hexout
        '
        Me.Hexout.AutoSize = True
        Me.Hexout.Location = New System.Drawing.Point(6, 118)
        Me.Hexout.Name = "Hexout"
        Me.Hexout.Size = New System.Drawing.Size(109, 21)
        Me.Hexout.TabIndex = 6
        Me.Hexout.TabStop = True
        Me.Hexout.Text = "Hexadesimal"
        Me.Hexout.UseVisualStyleBackColor = True
        '
        'Octout
        '
        Me.Octout.AutoSize = True
        Me.Octout.Location = New System.Drawing.Point(6, 82)
        Me.Octout.Name = "Octout"
        Me.Octout.Size = New System.Drawing.Size(62, 21)
        Me.Octout.TabIndex = 2
        Me.Octout.TabStop = True
        Me.Octout.Text = "Octal"
        Me.Octout.UseVisualStyleBackColor = True
        '
        'Binout
        '
        Me.Binout.AutoSize = True
        Me.Binout.Location = New System.Drawing.Point(6, 51)
        Me.Binout.Name = "Binout"
        Me.Binout.Size = New System.Drawing.Size(62, 21)
        Me.Binout.TabIndex = 1
        Me.Binout.TabStop = True
        Me.Binout.Text = "Biner"
        Me.Binout.UseVisualStyleBackColor = True
        '
        'Desout
        '
        Me.Desout.AutoSize = True
        Me.Desout.Location = New System.Drawing.Point(6, 18)
        Me.Desout.Name = "Desout"
        Me.Desout.Size = New System.Drawing.Size(79, 21)
        Me.Desout.TabIndex = 0
        Me.Desout.TabStop = True
        Me.Desout.Text = "Desimal"
        Me.Desout.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(357, 312)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(94, 44)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(185, 312)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 44)
        Me.BtnClear.TabIndex = 9
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(407, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 30)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(376, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 386)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.BtnKonversi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnKonversi As System.Windows.Forms.Button
    Friend WithEvents Hex_in As System.Windows.Forms.RadioButton
    Friend WithEvents oct_in As System.Windows.Forms.RadioButton
    Friend WithEvents Bin_in As System.Windows.Forms.RadioButton
    Friend WithEvents Des_in As System.Windows.Forms.RadioButton
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Hexout As System.Windows.Forms.RadioButton
    Friend WithEvents Octout As System.Windows.Forms.RadioButton
    Friend WithEvents Binout As System.Windows.Forms.RadioButton
    Friend WithEvents Desout As System.Windows.Forms.RadioButton
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
