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
        Me.txtNH = New System.Windows.Forms.TextBox
        Me.txtNA = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnKONVERSI = New System.Windows.Forms.Button
        Me.btnTUTUP = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtNH
        '
        Me.txtNH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNH.Location = New System.Drawing.Point(288, 176)
        Me.txtNH.Name = "txtNH"
        Me.txtNH.Size = New System.Drawing.Size(256, 33)
        Me.txtNH.TabIndex = 4
        '
        'txtNA
        '
        Me.txtNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNA.Location = New System.Drawing.Point(288, 144)
        Me.txtNA.Name = "txtNA"
        Me.txtNA.Size = New System.Drawing.Size(256, 33)
        Me.txtNA.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nilai Huruf :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nilai Akhir :"
        '
        'btnKONVERSI
        '
        Me.btnKONVERSI.Location = New System.Drawing.Point(568, 144)
        Me.btnKONVERSI.Name = "btnKONVERSI"
        Me.btnKONVERSI.Size = New System.Drawing.Size(136, 32)
        Me.btnKONVERSI.TabIndex = 6
        Me.btnKONVERSI.Text = "&Konversi"
        Me.btnKONVERSI.UseVisualStyleBackColor = True
        '
        'btnTUTUP
        '
        Me.btnTUTUP.Location = New System.Drawing.Point(568, 176)
        Me.btnTUTUP.Name = "btnTUTUP"
        Me.btnTUTUP.Size = New System.Drawing.Size(136, 32)
        Me.btnTUTUP.TabIndex = 6
        Me.btnTUTUP.Text = "&Tutup"
        Me.btnTUTUP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 540)
        Me.Controls.Add(Me.btnTUTUP)
        Me.Controls.Add(Me.btnKONVERSI)
        Me.Controls.Add(Me.txtNH)
        Me.Controls.Add(Me.txtNA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Name = "Form1"
        Me.Text = "Konversi Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNH As System.Windows.Forms.TextBox
    Friend WithEvents txtNA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnKONVERSI As System.Windows.Forms.Button
    Friend WithEvents btnTUTUP As System.Windows.Forms.Button

End Class
