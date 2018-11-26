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
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtD = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnSUM = New System.Windows.Forms.Button()
        Me.BtnAverage = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMax = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "A"
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(46, 23)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(100, 22)
        Me.TxtA.TabIndex = 3
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(46, 67)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(100, 22)
        Me.TxtB.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "B"
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(44, 114)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(100, 22)
        Me.TxtC.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "C"
        '
        'TxtD
        '
        Me.TxtD.Location = New System.Drawing.Point(44, 158)
        Me.TxtD.Name = "TxtD"
        Me.TxtD.Size = New System.Drawing.Size(100, 22)
        Me.TxtD.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "D"
        '
        'BtnSUM
        '
        Me.BtnSUM.Location = New System.Drawing.Point(218, 17)
        Me.BtnSUM.Name = "BtnSUM"
        Me.BtnSUM.Size = New System.Drawing.Size(115, 41)
        Me.BtnSUM.TabIndex = 10
        Me.BtnSUM.Text = "SUM"
        Me.BtnSUM.UseVisualStyleBackColor = True
        '
        'BtnAverage
        '
        Me.BtnAverage.Location = New System.Drawing.Point(218, 161)
        Me.BtnAverage.Name = "BtnAverage"
        Me.BtnAverage.Size = New System.Drawing.Size(115, 41)
        Me.BtnAverage.TabIndex = 11
        Me.BtnAverage.Text = "AVERAGE"
        Me.BtnAverage.UseVisualStyleBackColor = True
        '
        'BtnMin
        '
        Me.BtnMin.Location = New System.Drawing.Point(218, 114)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(115, 41)
        Me.BtnMin.TabIndex = 12
        Me.BtnMin.Text = "MIN"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnMax
        '
        Me.BtnMax.Location = New System.Drawing.Point(218, 67)
        Me.BtnMax.Name = "BtnMax"
        Me.BtnMax.Size = New System.Drawing.Size(115, 41)
        Me.BtnMax.TabIndex = 13
        Me.BtnMax.Text = "MAX"
        Me.BtnMax.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(46, 231)
        Me.TxtHasil.Multiline = True
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(185, 65)
        Me.TxtHasil.TabIndex = 14
        Me.TxtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(402, 17)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(115, 41)
        Me.BtnClear.TabIndex = 15
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(402, 90)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(115, 41)
        Me.BtnExit.TabIndex = 16
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 334)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.BtnMax)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.BtnAverage)
        Me.Controls.Add(Me.BtnSUM)
        Me.Controls.Add(Me.TxtD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents TxtB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtD As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnSUM As System.Windows.Forms.Button
    Friend WithEvents BtnAverage As System.Windows.Forms.Button
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnMax As System.Windows.Forms.Button
    Friend WithEvents TxtHasil As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button

End Class
