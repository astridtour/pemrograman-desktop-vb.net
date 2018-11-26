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
        Me.CmbProv = New System.Windows.Forms.ComboBox()
        Me.CmbKecamatan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbKota = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LstTampil = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Provinsi"
        '
        'CmbProv
        '
        Me.CmbProv.FormattingEnabled = True
        Me.CmbProv.Location = New System.Drawing.Point(142, 21)
        Me.CmbProv.Name = "CmbProv"
        Me.CmbProv.Size = New System.Drawing.Size(195, 24)
        Me.CmbProv.TabIndex = 1
        '
        'CmbKecamatan
        '
        Me.CmbKecamatan.FormattingEnabled = True
        Me.CmbKecamatan.Location = New System.Drawing.Point(142, 140)
        Me.CmbKecamatan.Name = "CmbKecamatan"
        Me.CmbKecamatan.Size = New System.Drawing.Size(195, 24)
        Me.CmbKecamatan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kecamatan"
        '
        'CmbKota
        '
        Me.CmbKota.FormattingEnabled = True
        Me.CmbKota.Location = New System.Drawing.Point(142, 80)
        Me.CmbKota.Name = "CmbKota"
        Me.CmbKota.Size = New System.Drawing.Size(195, 24)
        Me.CmbKota.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kota/Kabupaten"
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(31, 198)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(75, 23)
        Me.BtnProses.TabIndex = 6
        Me.BtnProses.Text = "PROSES"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(262, 198)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "EXIT"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(142, 198)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(75, 23)
        Me.BtnBatal.TabIndex = 8
        Me.BtnBatal.Text = "BATAL"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LstTampil)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 241)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 185)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OUTPUT"
        '
        'LstTampil
        '
        Me.LstTampil.FormattingEnabled = True
        Me.LstTampil.ItemHeight = 16
        Me.LstTampil.Location = New System.Drawing.Point(16, 32)
        Me.LstTampil.Name = "LstTampil"
        Me.LstTampil.Size = New System.Drawing.Size(261, 132)
        Me.LstTampil.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.CmbKota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbKecamatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbProv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbProv As System.Windows.Forms.ComboBox
    Friend WithEvents CmbKecamatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbKota As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LstTampil As System.Windows.Forms.ListBox

End Class
