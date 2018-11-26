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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBIL = New System.Windows.Forms.TextBox
        Me.LbLHASIL = New System.Windows.Forms.Label
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan Bulat ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pembulatan :"
        '
        'txtBIL
        '
        Me.txtBIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBIL.Location = New System.Drawing.Point(216, 64)
        Me.txtBIL.Name = "txtBIL"
        Me.txtBIL.Size = New System.Drawing.Size(200, 29)
        Me.txtBIL.TabIndex = 1
        Me.txtBIL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbLHASIL
        '
        Me.LbLHASIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbLHASIL.Location = New System.Drawing.Point(216, 96)
        Me.LbLHASIL.Name = "LbLHASIL"
        Me.LbLHASIL.Size = New System.Drawing.Size(200, 32)
        Me.LbLHASIL.TabIndex = 2
        Me.LbLHASIL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCLEAR
        '
        Me.btnCLEAR.Location = New System.Drawing.Point(440, 64)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(112, 32)
        Me.btnCLEAR.TabIndex = 3
        Me.btnCLEAR.Text = "&Clear"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.Location = New System.Drawing.Point(440, 96)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(112, 32)
        Me.btnEXIT.TabIndex = 3
        Me.btnEXIT.Text = "&Exit"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 479)
        Me.Controls.Add(Me.btnEXIT)
        Me.Controls.Add(Me.btnCLEAR)
        Me.Controls.Add(Me.LbLHASIL)
        Me.Controls.Add(Me.txtBIL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Pembulatan Ke Ratusan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBIL As System.Windows.Forms.TextBox
    Friend WithEvents LbLHASIL As System.Windows.Forms.Label
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button

End Class
