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
        Me.LSVTabel = New System.Windows.Forms.ListView()
        Me.DGVTabel = New System.Windows.Forms.DataGridView()
        Me.BtnConfig = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSetting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtE = New System.Windows.Forms.TextBox()
        Me.TxtD = New System.Windows.Forms.TextBox()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        CType(Me.DGVTabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSVTabel
        '
        Me.LSVTabel.Location = New System.Drawing.Point(0, 0)
        Me.LSVTabel.Name = "LSVTabel"
        Me.LSVTabel.Size = New System.Drawing.Size(508, 320)
        Me.LSVTabel.TabIndex = 0
        Me.LSVTabel.UseCompatibleStateImageBehavior = False
        '
        'DGVTabel
        '
        Me.DGVTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTabel.Location = New System.Drawing.Point(536, 0)
        Me.DGVTabel.Name = "DGVTabel"
        Me.DGVTabel.RowTemplate.Height = 24
        Me.DGVTabel.Size = New System.Drawing.Size(524, 320)
        Me.DGVTabel.TabIndex = 1
        '
        'BtnConfig
        '
        Me.BtnConfig.Location = New System.Drawing.Point(12, 353)
        Me.BtnConfig.Name = "BtnConfig"
        Me.BtnConfig.Size = New System.Drawing.Size(111, 37)
        Me.BtnConfig.TabIndex = 2
        Me.BtnConfig.Text = "Config"
        Me.BtnConfig.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Location = New System.Drawing.Point(397, 353)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(111, 37)
        Me.BtnUbah.TabIndex = 3
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(269, 353)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(111, 37)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(140, 353)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(111, 37)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(680, 353)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(111, 37)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(809, 353)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(111, 37)
        Me.BtnInsert.TabIndex = 8
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(937, 353)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(111, 37)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSetting
        '
        Me.BtnSetting.Location = New System.Drawing.Point(552, 353)
        Me.BtnSetting.Name = "BtnSetting"
        Me.BtnSetting.Size = New System.Drawing.Size(111, 37)
        Me.BtnSetting.TabIndex = 6
        Me.BtnSetting.Text = "Setting"
        Me.BtnSetting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kolom 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(876, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Kolom 5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(689, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kolom 4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(492, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Kolom 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Kolom 2"
        '
        'TxtA
        '
        Me.TxtA.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtA.Location = New System.Drawing.Point(77, 437)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(85, 38)
        Me.TxtA.TabIndex = 15
        '
        'TxtE
        '
        Me.TxtE.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtE.Location = New System.Drawing.Point(881, 437)
        Me.TxtE.Name = "TxtE"
        Me.TxtE.Size = New System.Drawing.Size(85, 38)
        Me.TxtE.TabIndex = 17
        '
        'TxtD
        '
        Me.TxtD.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtD.Location = New System.Drawing.Point(694, 437)
        Me.TxtD.Name = "TxtD"
        Me.TxtD.Size = New System.Drawing.Size(85, 38)
        Me.TxtD.TabIndex = 18
        '
        'TxtC
        '
        Me.TxtC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtC.Location = New System.Drawing.Point(497, 437)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(85, 38)
        Me.TxtC.TabIndex = 19
        '
        'TxtB
        '
        Me.TxtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtB.Location = New System.Drawing.Point(269, 437)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(85, 38)
        Me.TxtB.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 564)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtD)
        Me.Controls.Add(Me.TxtE)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnInsert)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSetting)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnConfig)
        Me.Controls.Add(Me.DGVTabel)
        Me.Controls.Add(Me.LSVTabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVTabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LSVTabel As System.Windows.Forms.ListView
    Friend WithEvents DGVTabel As System.Windows.Forms.DataGridView
    Friend WithEvents BtnConfig As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSetting As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents TxtE As System.Windows.Forms.TextBox
    Friend WithEvents TxtD As System.Windows.Forms.TextBox
    Friend WithEvents TxtC As System.Windows.Forms.TextBox
    Friend WithEvents TxtB As System.Windows.Forms.TextBox

End Class
