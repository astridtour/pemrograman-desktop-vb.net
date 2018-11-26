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
        Me.TxtLength = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.TxtBreadth = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnHasil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtLength
        '
        Me.TxtLength.Location = New System.Drawing.Point(12, 12)
        Me.TxtLength.Name = "TxtLength"
        Me.TxtLength.Size = New System.Drawing.Size(100, 22)
        Me.TxtLength.TabIndex = 0
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(12, 68)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(100, 22)
        Me.TxtHeight.TabIndex = 1
        '
        'TxtBreadth
        '
        Me.TxtBreadth.Location = New System.Drawing.Point(12, 40)
        Me.TxtBreadth.Name = "TxtBreadth"
        Me.TxtBreadth.Size = New System.Drawing.Size(100, 22)
        Me.TxtBreadth.TabIndex = 2
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(228, 12)
        Me.TxtHasil.Multiline = True
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(117, 78)
        Me.TxtHasil.TabIndex = 3
        Me.TxtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(12, 130)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(100, 41)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(180, 130)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(100, 41)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnHasil
        '
        Me.BtnHasil.Location = New System.Drawing.Point(352, 130)
        Me.BtnHasil.Name = "BtnHasil"
        Me.BtnHasil.Size = New System.Drawing.Size(100, 41)
        Me.BtnHasil.TabIndex = 6
        Me.BtnHasil.Text = "Hasil"
        Me.BtnHasil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 203)
        Me.Controls.Add(Me.BtnHasil)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtBreadth)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.TxtLength)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLength As System.Windows.Forms.TextBox
    Friend WithEvents TxtHeight As System.Windows.Forms.TextBox
    Friend WithEvents TxtBreadth As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnHasil As System.Windows.Forms.Button

End Class
