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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.Txt2 = New System.Windows.Forms.TextBox()
        Me.Txt3 = New System.Windows.Forms.TextBox()
        Me.Txt4 = New System.Windows.Forms.TextBox()
        Me.Txt5 = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnHasil = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai Tugas Pribadi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Tugas Kelompok :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai UTS :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UAS :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(46, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nilai Akhir :"
        '
        'Txt1
        '
        Me.Txt1.Location = New System.Drawing.Point(211, 17)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(118, 22)
        Me.Txt1.TabIndex = 11
        '
        'Txt2
        '
        Me.Txt2.Location = New System.Drawing.Point(211, 54)
        Me.Txt2.Name = "Txt2"
        Me.Txt2.Size = New System.Drawing.Size(118, 22)
        Me.Txt2.TabIndex = 12
        '
        'Txt3
        '
        Me.Txt3.Location = New System.Drawing.Point(211, 97)
        Me.Txt3.Name = "Txt3"
        Me.Txt3.Size = New System.Drawing.Size(118, 22)
        Me.Txt3.TabIndex = 13
        '
        'Txt4
        '
        Me.Txt4.Location = New System.Drawing.Point(211, 145)
        Me.Txt4.Name = "Txt4"
        Me.Txt4.Size = New System.Drawing.Size(118, 22)
        Me.Txt4.TabIndex = 14
        '
        'Txt5
        '
        Me.Txt5.Location = New System.Drawing.Point(211, 194)
        Me.Txt5.Name = "Txt5"
        Me.Txt5.Size = New System.Drawing.Size(118, 22)
        Me.Txt5.TabIndex = 15
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(57, 289)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(124, 39)
        Me.BtnClear.TabIndex = 16
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnHasil
        '
        Me.BtnHasil.Location = New System.Drawing.Point(360, 289)
        Me.BtnHasil.Name = "BtnHasil"
        Me.BtnHasil.Size = New System.Drawing.Size(107, 39)
        Me.BtnHasil.TabIndex = 17
        Me.BtnHasil.Text = "Hasil"
        Me.BtnHasil.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(211, 372)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(118, 44)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(561, 449)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnHasil)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Txt5)
        Me.Controls.Add(Me.Txt4)
        Me.Controls.Add(Me.Txt3)
        Me.Controls.Add(Me.Txt2)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menentukan NA Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt3 As System.Windows.Forms.TextBox
    Friend WithEvents Txt4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt5 As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnHasil As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button

End Class
