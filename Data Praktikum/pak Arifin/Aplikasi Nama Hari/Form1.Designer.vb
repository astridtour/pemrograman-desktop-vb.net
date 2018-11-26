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
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpTANGGAL = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSekarang = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlusSatuHari = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPlusDuaHari = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPlusTigaHari = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMinusSatuHari = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMinusDuaHari = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMinusTigaHari = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Tanggal :"
        '
        'dtpTANGGAL
        '
        Me.dtpTANGGAL.CustomFormat = "dd-MM-yyyy"
        Me.dtpTANGGAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTANGGAL.Location = New System.Drawing.Point(240, 38)
        Me.dtpTANGGAL.Name = "dtpTANGGAL"
        Me.dtpTANGGAL.Size = New System.Drawing.Size(145, 26)
        Me.dtpTANGGAL.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(109, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal :"
        '
        'txtSekarang
        '
        Me.txtSekarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSekarang.Location = New System.Drawing.Point(204, 223)
        Me.txtSekarang.Name = "txtSekarang"
        Me.txtSekarang.Size = New System.Drawing.Size(179, 26)
        Me.txtSekarang.TabIndex = 3
        Me.txtSekarang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal + 1 hari :"
        '
        'txtPlusSatuHari
        '
        Me.txtPlusSatuHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlusSatuHari.Location = New System.Drawing.Point(204, 280)
        Me.txtPlusSatuHari.Name = "txtPlusSatuHari"
        Me.txtPlusSatuHari.Size = New System.Drawing.Size(179, 26)
        Me.txtPlusSatuHari.TabIndex = 3
        Me.txtPlusSatuHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tanggal + 2 hari :"
        '
        'txtPlusDuaHari
        '
        Me.txtPlusDuaHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlusDuaHari.Location = New System.Drawing.Point(204, 310)
        Me.txtPlusDuaHari.Name = "txtPlusDuaHari"
        Me.txtPlusDuaHari.Size = New System.Drawing.Size(179, 26)
        Me.txtPlusDuaHari.TabIndex = 3
        Me.txtPlusDuaHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tanggal + 3 hari :"
        '
        'txtPlusTigaHari
        '
        Me.txtPlusTigaHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlusTigaHari.Location = New System.Drawing.Point(203, 340)
        Me.txtPlusTigaHari.Name = "txtPlusTigaHari"
        Me.txtPlusTigaHari.Size = New System.Drawing.Size(179, 26)
        Me.txtPlusTigaHari.TabIndex = 3
        Me.txtPlusTigaHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Tanggal - 1 hari :"
        '
        'txtMinusSatuHari
        '
        Me.txtMinusSatuHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinusSatuHari.Location = New System.Drawing.Point(206, 166)
        Me.txtMinusSatuHari.Name = "txtMinusSatuHari"
        Me.txtMinusSatuHari.Size = New System.Drawing.Size(179, 26)
        Me.txtMinusSatuHari.TabIndex = 3
        Me.txtMinusSatuHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tanggal - 2 hari :"
        '
        'txtMinusDuaHari
        '
        Me.txtMinusDuaHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinusDuaHari.Location = New System.Drawing.Point(206, 134)
        Me.txtMinusDuaHari.Name = "txtMinusDuaHari"
        Me.txtMinusDuaHari.Size = New System.Drawing.Size(179, 26)
        Me.txtMinusDuaHari.TabIndex = 3
        Me.txtMinusDuaHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Tanggal - 3 hari :"
        '
        'txtMinusTigaHari
        '
        Me.txtMinusTigaHari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinusTigaHari.Location = New System.Drawing.Point(206, 103)
        Me.txtMinusTigaHari.Name = "txtMinusTigaHari"
        Me.txtMinusTigaHari.Size = New System.Drawing.Size(179, 26)
        Me.txtMinusTigaHari.TabIndex = 3
        Me.txtMinusTigaHari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Informasi Nama Hari :"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(202, 371)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 28)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMinusTigaHari)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMinusDuaHari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMinusSatuHari)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPlusTigaHari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPlusDuaHari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPlusSatuHari)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSekarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpTANGGAL)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Menentukan Nama Hari atas Data Tanggal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpTANGGAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSekarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlusSatuHari As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPlusDuaHari As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPlusTigaHari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMinusSatuHari As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMinusDuaHari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMinusTigaHari As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
