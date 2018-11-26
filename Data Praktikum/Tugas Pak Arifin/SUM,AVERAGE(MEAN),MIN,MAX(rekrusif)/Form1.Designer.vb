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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbFunction = New System.Windows.Forms.ComboBox()
        Me.LstTampil = New System.Windows.Forms.ListBox()
        Me.LblHasil = New System.Windows.Forms.Label()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnTambah)
        Me.GroupBox1.Controls.Add(Me.TxtData)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUTAN"
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(52, 74)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(109, 39)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(61, 31)
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(100, 22)
        Me.TxtData.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbFunction)
        Me.GroupBox2.Location = New System.Drawing.Point(236, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(199, 72)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FUNCTION REKRUSIF"
        '
        'CmbFunction
        '
        Me.CmbFunction.FormattingEnabled = True
        Me.CmbFunction.Items.AddRange(New Object() {"AVERAGE", "SUM", "MAX", "MIN"})
        Me.CmbFunction.Location = New System.Drawing.Point(18, 34)
        Me.CmbFunction.Name = "CmbFunction"
        Me.CmbFunction.Size = New System.Drawing.Size(159, 24)
        Me.CmbFunction.TabIndex = 0
        '
        'LstTampil
        '
        Me.LstTampil.FormattingEnabled = True
        Me.LstTampil.ItemHeight = 16
        Me.LstTampil.Location = New System.Drawing.Point(15, 147)
        Me.LstTampil.Name = "LstTampil"
        Me.LstTampil.Size = New System.Drawing.Size(227, 84)
        Me.LstTampil.TabIndex = 4
        '
        'LblHasil
        '
        Me.LblHasil.Font = New System.Drawing.Font("Algerian", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHasil.Location = New System.Drawing.Point(300, 100)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(153, 131)
        Me.LblHasil.TabIndex = 5
        Me.LblHasil.Text = "?"
        Me.LblHasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Location = New System.Drawing.Point(292, 272)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(109, 39)
        Me.BtnKeluar.TabIndex = 3
        Me.BtnKeluar.Text = "KELUAR"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(45, 272)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(109, 39)
        Me.BtnClear.TabIndex = 4
        Me.BtnClear.Text = "CLEAR"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 335)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.LstTampil)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents TxtData As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbFunction As System.Windows.Forms.ComboBox
    Friend WithEvents LstTampil As System.Windows.Forms.ListBox
    Friend WithEvents LblHasil As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button

End Class
