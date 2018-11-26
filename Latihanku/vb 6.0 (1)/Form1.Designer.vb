<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihanvb61
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
        Me.Lst1 = New System.Windows.Forms.ListBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnTampil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukan Nama :"
        '
        'Lst1
        '
        Me.Lst1.FormattingEnabled = True
        Me.Lst1.ItemHeight = 33
        Me.Lst1.Location = New System.Drawing.Point(49, 85)
        Me.Lst1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Lst1.Name = "Lst1"
        Me.Lst1.Size = New System.Drawing.Size(348, 235)
        Me.Lst1.TabIndex = 1
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(242, 19)
        Me.txt1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(228, 40)
        Me.txt1.TabIndex = 2
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(439, 95)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(131, 47)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnTampil
        '
        Me.BtnTampil.Location = New System.Drawing.Point(439, 179)
        Me.BtnTampil.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(131, 47)
        Me.BtnTampil.TabIndex = 4
        Me.BtnTampil.Text = "Tampilkan"
        Me.BtnTampil.UseVisualStyleBackColor = True
        '
        'Latihanvb61
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 350)
        Me.Controls.Add(Me.BtnTampil)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Lst1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "Latihanvb61"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "latihan Array 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lst1 As System.Windows.Forms.ListBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTampil As System.Windows.Forms.Button

End Class
