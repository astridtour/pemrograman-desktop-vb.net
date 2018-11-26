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
        Me.btnHAPUS = New System.Windows.Forms.Button
        Me.btnGENERAL = New System.Windows.Forms.Button
        Me.txtHASIL = New System.Windows.Forms.TextBox
        Me.btnPOLA1 = New System.Windows.Forms.Button
        Me.btnPOLA2 = New System.Windows.Forms.Button
        Me.btnPOLA3 = New System.Windows.Forms.Button
        Me.btnPOLA4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnHAPUS
        '
        Me.btnHAPUS.Location = New System.Drawing.Point(352, 24)
        Me.btnHAPUS.Name = "btnHAPUS"
        Me.btnHAPUS.Size = New System.Drawing.Size(192, 32)
        Me.btnHAPUS.TabIndex = 1
        Me.btnHAPUS.Text = "&Hapus"
        Me.btnHAPUS.UseVisualStyleBackColor = True
        '
        'btnGENERAL
        '
        Me.btnGENERAL.Location = New System.Drawing.Point(352, 64)
        Me.btnGENERAL.Name = "btnGENERAL"
        Me.btnGENERAL.Size = New System.Drawing.Size(192, 40)
        Me.btnGENERAL.TabIndex = 2
        Me.btnGENERAL.Text = "&Generalisasi"
        Me.btnGENERAL.UseVisualStyleBackColor = True
        '
        'txtHASIL
        '
        Me.txtHASIL.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHASIL.Location = New System.Drawing.Point(32, 24)
        Me.txtHASIL.Multiline = True
        Me.txtHASIL.Name = "txtHASIL"
        Me.txtHASIL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHASIL.Size = New System.Drawing.Size(288, 368)
        Me.txtHASIL.TabIndex = 3
        '
        'btnPOLA1
        '
        Me.btnPOLA1.Location = New System.Drawing.Point(352, 112)
        Me.btnPOLA1.Name = "btnPOLA1"
        Me.btnPOLA1.Size = New System.Drawing.Size(192, 40)
        Me.btnPOLA1.TabIndex = 4
        Me.btnPOLA1.Text = "Segitiga"
        Me.btnPOLA1.UseVisualStyleBackColor = True
        '
        'btnPOLA2
        '
        Me.btnPOLA2.Location = New System.Drawing.Point(352, 160)
        Me.btnPOLA2.Name = "btnPOLA2"
        Me.btnPOLA2.Size = New System.Drawing.Size(192, 40)
        Me.btnPOLA2.TabIndex = 4
        Me.btnPOLA2.Text = "Segitiga"
        Me.btnPOLA2.UseVisualStyleBackColor = True
        '
        'btnPOLA3
        '
        Me.btnPOLA3.Location = New System.Drawing.Point(352, 216)
        Me.btnPOLA3.Name = "btnPOLA3"
        Me.btnPOLA3.Size = New System.Drawing.Size(192, 40)
        Me.btnPOLA3.TabIndex = 4
        Me.btnPOLA3.Text = "Segitiga"
        Me.btnPOLA3.UseVisualStyleBackColor = True
        '
        'btnPOLA4
        '
        Me.btnPOLA4.Location = New System.Drawing.Point(352, 272)
        Me.btnPOLA4.Name = "btnPOLA4"
        Me.btnPOLA4.Size = New System.Drawing.Size(192, 40)
        Me.btnPOLA4.TabIndex = 4
        Me.btnPOLA4.Text = "Segitiga"
        Me.btnPOLA4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 422)
        Me.Controls.Add(Me.btnPOLA4)
        Me.Controls.Add(Me.btnPOLA3)
        Me.Controls.Add(Me.btnPOLA2)
        Me.Controls.Add(Me.btnPOLA1)
        Me.Controls.Add(Me.txtHASIL)
        Me.Controls.Add(Me.btnGENERAL)
        Me.Controls.Add(Me.btnHAPUS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHAPUS As System.Windows.Forms.Button
    Friend WithEvents btnGENERAL As System.Windows.Forms.Button
    Friend WithEvents txtHASIL As System.Windows.Forms.TextBox
    Friend WithEvents btnPOLA1 As System.Windows.Forms.Button
    Friend WithEvents btnPOLA2 As System.Windows.Forms.Button
    Friend WithEvents btnPOLA3 As System.Windows.Forms.Button
    Friend WithEvents btnPOLA4 As System.Windows.Forms.Button

End Class
