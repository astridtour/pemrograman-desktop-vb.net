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
        Me.DTPicker1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtpTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.Txt1 = New System.Windows.Forms.TextBox()
        Me.LblBln = New System.Windows.Forms.Label()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tanggal lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Zodiak"
        '
        'DTPicker1
        '
        Me.DTPicker1.Location = New System.Drawing.Point(29, 173)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(75, 23)
        Me.DTPicker1.TabIndex = 5
        Me.DTPicker1.Text = "Tampil"
        Me.DTPicker1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(173, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(326, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Keluar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dtpTglLahir
        '
        Me.dtpTglLahir.CustomFormat = "dd-MMMM-yyyy"
        Me.dtpTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTglLahir.Location = New System.Drawing.Point(150, 21)
        Me.dtpTglLahir.Name = "dtpTglLahir"
        Me.dtpTglLahir.Size = New System.Drawing.Size(264, 23)
        Me.dtpTglLahir.TabIndex = 8
        '
        'Txt1
        '
        Me.Txt1.Enabled = False
        Me.Txt1.Location = New System.Drawing.Point(150, 121)
        Me.Txt1.Name = "Txt1"
        Me.Txt1.Size = New System.Drawing.Size(127, 23)
        Me.Txt1.TabIndex = 11
        '
        'LblBln
        '
        Me.LblBln.AutoSize = True
        Me.LblBln.Location = New System.Drawing.Point(147, 88)
        Me.LblBln.Name = "LblBln"
        Me.LblBln.Size = New System.Drawing.Size(45, 17)
        Me.LblBln.TabIndex = 12
        Me.LblBln.Text = "Label3"
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.Location = New System.Drawing.Point(147, 61)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(45, 17)
        Me.LblTgl.TabIndex = 12
        Me.LblTgl.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(530, 239)
        Me.Controls.Add(Me.LblTgl)
        Me.Controls.Add(Me.LblBln)
        Me.Controls.Add(Me.Txt1)
        Me.Controls.Add(Me.dtpTglLahir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTPicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTPicker1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dtpTglLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt1 As System.Windows.Forms.TextBox
    Friend WithEvents LblBln As System.Windows.Forms.Label
    Friend WithEvents LblTgl As System.Windows.Forms.Label
End Class
