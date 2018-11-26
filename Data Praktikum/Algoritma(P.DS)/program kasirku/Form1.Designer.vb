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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SuperTruck = New System.Windows.Forms.RadioButton()
        Me.Truck = New System.Windows.Forms.RadioButton()
        Me.Bus = New System.Windows.Forms.RadioButton()
        Me.MiniBus = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtByCuciMobil = New System.Windows.Forms.TextBox()
        Me.gruopbox = New System.Windows.Forms.GroupBox()
        Me.Tambah3 = New System.Windows.Forms.CheckBox()
        Me.Tambah2 = New System.Windows.Forms.CheckBox()
        Me.txtTambah3 = New System.Windows.Forms.TextBox()
        Me.txtTambah2 = New System.Windows.Forms.TextBox()
        Me.Tambah1 = New System.Windows.Forms.CheckBox()
        Me.txtTambah1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.makan2 = New System.Windows.Forms.CheckBox()
        Me.makan3 = New System.Windows.Forms.CheckBox()
        Me.makan4 = New System.Windows.Forms.CheckBox()
        Me.makan5 = New System.Windows.Forms.CheckBox()
        Me.makan1 = New System.Windows.Forms.CheckBox()
        Me.TxtJumlahNasGorSp = New System.Windows.Forms.TextBox()
        Me.TxtJumlahMieGoreng = New System.Windows.Forms.TextBox()
        Me.TxtJumlahJusJeruk = New System.Windows.Forms.TextBox()
        Me.TxtJumlahNumDin = New System.Windows.Forms.TextBox()
        Me.txtJumlahNasGor = New System.Windows.Forms.TextBox()
        Me.TxtNumDin = New System.Windows.Forms.TextBox()
        Me.TxtJusJeruk = New System.Windows.Forms.TextBox()
        Me.TxtMieGoreng = New System.Windows.Forms.TextBox()
        Me.TxtNasGorSp = New System.Windows.Forms.TextBox()
        Me.TxtNasGor = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gruopbox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Algerian", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MUNARAH PUNYA INI WE...."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SpringGreen
        Me.GroupBox1.Controls.Add(Me.SuperTruck)
        Me.GroupBox1.Controls.Add(Me.Truck)
        Me.GroupBox1.Controls.Add(Me.Bus)
        Me.GroupBox1.Controls.Add(Me.MiniBus)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(130, 144)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "<<Jenis Mobil>>"
        '
        'SuperTruck
        '
        Me.SuperTruck.AutoSize = True
        Me.SuperTruck.Location = New System.Drawing.Point(6, 112)
        Me.SuperTruck.Name = "SuperTruck"
        Me.SuperTruck.Size = New System.Drawing.Size(107, 21)
        Me.SuperTruck.TabIndex = 3
        Me.SuperTruck.TabStop = True
        Me.SuperTruck.Text = "Super Truck"
        Me.SuperTruck.UseVisualStyleBackColor = True
        '
        'Truck
        '
        Me.Truck.AutoSize = True
        Me.Truck.Location = New System.Drawing.Point(6, 85)
        Me.Truck.Name = "Truck"
        Me.Truck.Size = New System.Drawing.Size(65, 21)
        Me.Truck.TabIndex = 2
        Me.Truck.TabStop = True
        Me.Truck.Text = "Truck"
        Me.Truck.UseVisualStyleBackColor = True
        '
        'Bus
        '
        Me.Bus.AutoSize = True
        Me.Bus.Location = New System.Drawing.Point(6, 58)
        Me.Bus.Name = "Bus"
        Me.Bus.Size = New System.Drawing.Size(53, 21)
        Me.Bus.TabIndex = 1
        Me.Bus.TabStop = True
        Me.Bus.Text = "Bus"
        Me.Bus.UseVisualStyleBackColor = True
        '
        'MiniBus
        '
        Me.MiniBus.AutoSize = True
        Me.MiniBus.Location = New System.Drawing.Point(6, 31)
        Me.MiniBus.Name = "MiniBus"
        Me.MiniBus.Size = New System.Drawing.Size(82, 21)
        Me.MiniBus.TabIndex = 0
        Me.MiniBus.TabStop = True
        Me.MiniBus.Text = "Mini Bus"
        Me.MiniBus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Biaya Cuci Mobil :"
        '
        'TxtByCuciMobil
        '
        Me.TxtByCuciMobil.Location = New System.Drawing.Point(342, 45)
        Me.TxtByCuciMobil.Multiline = True
        Me.TxtByCuciMobil.Name = "TxtByCuciMobil"
        Me.TxtByCuciMobil.Size = New System.Drawing.Size(141, 34)
        Me.TxtByCuciMobil.TabIndex = 3
        Me.TxtByCuciMobil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gruopbox
        '
        Me.gruopbox.BackColor = System.Drawing.Color.Lime
        Me.gruopbox.Controls.Add(Me.Tambah3)
        Me.gruopbox.Controls.Add(Me.Tambah2)
        Me.gruopbox.Controls.Add(Me.txtTambah3)
        Me.gruopbox.Controls.Add(Me.txtTambah2)
        Me.gruopbox.Controls.Add(Me.Tambah1)
        Me.gruopbox.Controls.Add(Me.txtTambah1)
        Me.gruopbox.Location = New System.Drawing.Point(201, 83)
        Me.gruopbox.Name = "gruopbox"
        Me.gruopbox.Size = New System.Drawing.Size(282, 113)
        Me.gruopbox.TabIndex = 4
        Me.gruopbox.TabStop = False
        Me.gruopbox.Text = "<<Biaya Tambahan>>"
        '
        'Tambah3
        '
        Me.Tambah3.AutoSize = True
        Me.Tambah3.Location = New System.Drawing.Point(6, 82)
        Me.Tambah3.Name = "Tambah3"
        Me.Tambah3.Size = New System.Drawing.Size(92, 21)
        Me.Tambah3.TabIndex = 23
        Me.Tambah3.Text = "Car Wash"
        Me.Tambah3.UseVisualStyleBackColor = True
        '
        'Tambah2
        '
        Me.Tambah2.AutoSize = True
        Me.Tambah2.Location = New System.Drawing.Point(6, 55)
        Me.Tambah2.Name = "Tambah2"
        Me.Tambah2.Size = New System.Drawing.Size(98, 21)
        Me.Tambah2.TabIndex = 24
        Me.Tambah2.Text = "Cuci Mesin"
        Me.Tambah2.UseVisualStyleBackColor = True
        '
        'txtTambah3
        '
        Me.txtTambah3.Location = New System.Drawing.Point(116, 85)
        Me.txtTambah3.Name = "txtTambah3"
        Me.txtTambah3.Size = New System.Drawing.Size(160, 22)
        Me.txtTambah3.TabIndex = 7
        Me.txtTambah3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTambah2
        '
        Me.txtTambah2.Location = New System.Drawing.Point(116, 57)
        Me.txtTambah2.Name = "txtTambah2"
        Me.txtTambah2.Size = New System.Drawing.Size(160, 22)
        Me.txtTambah2.TabIndex = 6
        Me.txtTambah2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Tambah1
        '
        Me.Tambah1.AutoSize = True
        Me.Tambah1.Location = New System.Drawing.Point(6, 28)
        Me.Tambah1.Name = "Tambah1"
        Me.Tambah1.Size = New System.Drawing.Size(105, 21)
        Me.Tambah1.TabIndex = 22
        Me.Tambah1.Text = "Cuci Kolong"
        Me.Tambah1.UseVisualStyleBackColor = True
        '
        'txtTambah1
        '
        Me.txtTambah1.Location = New System.Drawing.Point(116, 30)
        Me.txtTambah1.Name = "txtTambah1"
        Me.txtTambah1.Size = New System.Drawing.Size(160, 22)
        Me.txtTambah1.TabIndex = 5
        Me.txtTambah1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.BackColor = System.Drawing.Color.Lime
        Me.GroupBox3.Controls.Add(Me.makan2)
        Me.GroupBox3.Controls.Add(Me.makan3)
        Me.GroupBox3.Controls.Add(Me.makan4)
        Me.GroupBox3.Controls.Add(Me.makan5)
        Me.GroupBox3.Controls.Add(Me.makan1)
        Me.GroupBox3.Controls.Add(Me.TxtJumlahNasGorSp)
        Me.GroupBox3.Controls.Add(Me.TxtJumlahMieGoreng)
        Me.GroupBox3.Controls.Add(Me.TxtJumlahJusJeruk)
        Me.GroupBox3.Controls.Add(Me.TxtJumlahNumDin)
        Me.GroupBox3.Controls.Add(Me.txtJumlahNasGor)
        Me.GroupBox3.Controls.Add(Me.TxtNumDin)
        Me.GroupBox3.Controls.Add(Me.TxtJusJeruk)
        Me.GroupBox3.Controls.Add(Me.TxtMieGoreng)
        Me.GroupBox3.Controls.Add(Me.TxtNasGorSp)
        Me.GroupBox3.Controls.Add(Me.TxtNasGor)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 175)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "<<Makanan / Minuman>>"
        '
        'makan2
        '
        Me.makan2.AutoSize = True
        Me.makan2.Location = New System.Drawing.Point(6, 57)
        Me.makan2.Name = "makan2"
        Me.makan2.Size = New System.Drawing.Size(160, 21)
        Me.makan2.TabIndex = 21
        Me.makan2.Text = "Nasi Goreng Spesial"
        Me.makan2.UseVisualStyleBackColor = True
        '
        'makan3
        '
        Me.makan3.AutoSize = True
        Me.makan3.Location = New System.Drawing.Point(6, 84)
        Me.makan3.Name = "makan3"
        Me.makan3.Size = New System.Drawing.Size(104, 21)
        Me.makan3.TabIndex = 20
        Me.makan3.Text = "Mie Goreng"
        Me.makan3.UseVisualStyleBackColor = True
        '
        'makan4
        '
        Me.makan4.AutoSize = True
        Me.makan4.Location = New System.Drawing.Point(6, 113)
        Me.makan4.Name = "makan4"
        Me.makan4.Size = New System.Drawing.Size(91, 21)
        Me.makan4.TabIndex = 19
        Me.makan4.Text = "Jus Jeruk"
        Me.makan4.UseVisualStyleBackColor = True
        '
        'makan5
        '
        Me.makan5.AutoSize = True
        Me.makan5.Location = New System.Drawing.Point(6, 140)
        Me.makan5.Name = "makan5"
        Me.makan5.Size = New System.Drawing.Size(131, 21)
        Me.makan5.TabIndex = 18
        Me.makan5.Text = "Minuman Dingin"
        Me.makan5.UseVisualStyleBackColor = True
        '
        'makan1
        '
        Me.makan1.AutoSize = True
        Me.makan1.Location = New System.Drawing.Point(6, 31)
        Me.makan1.Name = "makan1"
        Me.makan1.Size = New System.Drawing.Size(110, 21)
        Me.makan1.TabIndex = 17
        Me.makan1.Text = "Nasi Goreng"
        Me.makan1.UseVisualStyleBackColor = True
        '
        'TxtJumlahNasGorSp
        '
        Me.TxtJumlahNasGorSp.Location = New System.Drawing.Point(408, 57)
        Me.TxtJumlahNasGorSp.Name = "TxtJumlahNasGorSp"
        Me.TxtJumlahNasGorSp.Size = New System.Drawing.Size(48, 22)
        Me.TxtJumlahNasGorSp.TabIndex = 16
        '
        'TxtJumlahMieGoreng
        '
        Me.TxtJumlahMieGoreng.Location = New System.Drawing.Point(408, 84)
        Me.TxtJumlahMieGoreng.Name = "TxtJumlahMieGoreng"
        Me.TxtJumlahMieGoreng.Size = New System.Drawing.Size(48, 22)
        Me.TxtJumlahMieGoreng.TabIndex = 15
        '
        'TxtJumlahJusJeruk
        '
        Me.TxtJumlahJusJeruk.Location = New System.Drawing.Point(408, 110)
        Me.TxtJumlahJusJeruk.Name = "TxtJumlahJusJeruk"
        Me.TxtJumlahJusJeruk.Size = New System.Drawing.Size(48, 22)
        Me.TxtJumlahJusJeruk.TabIndex = 14
        '
        'TxtJumlahNumDin
        '
        Me.TxtJumlahNumDin.Location = New System.Drawing.Point(408, 137)
        Me.TxtJumlahNumDin.Name = "TxtJumlahNumDin"
        Me.TxtJumlahNumDin.Size = New System.Drawing.Size(48, 22)
        Me.TxtJumlahNumDin.TabIndex = 13
        '
        'txtJumlahNasGor
        '
        Me.txtJumlahNasGor.Location = New System.Drawing.Point(408, 31)
        Me.txtJumlahNasGor.Name = "txtJumlahNasGor"
        Me.txtJumlahNasGor.Size = New System.Drawing.Size(48, 22)
        Me.txtJumlahNasGor.TabIndex = 12
        '
        'TxtNumDin
        '
        Me.TxtNumDin.Location = New System.Drawing.Point(224, 137)
        Me.TxtNumDin.Name = "TxtNumDin"
        Me.TxtNumDin.Size = New System.Drawing.Size(160, 22)
        Me.TxtNumDin.TabIndex = 11
        Me.TxtNumDin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtJusJeruk
        '
        Me.TxtJusJeruk.Location = New System.Drawing.Point(224, 111)
        Me.TxtJusJeruk.Name = "TxtJusJeruk"
        Me.TxtJusJeruk.Size = New System.Drawing.Size(160, 22)
        Me.TxtJusJeruk.TabIndex = 10
        Me.TxtJusJeruk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMieGoreng
        '
        Me.TxtMieGoreng.Location = New System.Drawing.Point(224, 84)
        Me.TxtMieGoreng.Name = "TxtMieGoreng"
        Me.TxtMieGoreng.Size = New System.Drawing.Size(160, 22)
        Me.TxtMieGoreng.TabIndex = 7
        Me.TxtMieGoreng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNasGorSp
        '
        Me.TxtNasGorSp.Location = New System.Drawing.Point(224, 57)
        Me.TxtNasGorSp.Name = "TxtNasGorSp"
        Me.TxtNasGorSp.Size = New System.Drawing.Size(160, 22)
        Me.TxtNasGorSp.TabIndex = 6
        Me.TxtNasGorSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNasGor
        '
        Me.TxtNasGor.Location = New System.Drawing.Point(224, 31)
        Me.TxtNasGor.Name = "TxtNasGor"
        Me.TxtNasGor.Size = New System.Drawing.Size(160, 22)
        Me.TxtNasGor.TabIndex = 5
        Me.TxtNasGor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Lime
        Me.GroupBox4.Controls.Add(Me.BtnReset)
        Me.GroupBox4.Controls.Add(Me.TxtKembali)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TxtBayar)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TxtTotal)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.BtnHitung)
        Me.GroupBox4.Location = New System.Drawing.Point(512, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 380)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "<<Control>>"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(5, 331)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(188, 47)
        Me.BtnReset.TabIndex = 7
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'TxtKembali
        '
        Me.TxtKembali.Location = New System.Drawing.Point(6, 286)
        Me.TxtKembali.Multiline = True
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(188, 41)
        Me.TxtKembali.TabIndex = 6
        Me.TxtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 35)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kembali"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBayar
        '
        Me.TxtBayar.Location = New System.Drawing.Point(6, 204)
        Me.TxtBayar.Multiline = True
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(188, 41)
        Me.TxtBayar.TabIndex = 4
        Me.TxtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bayar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(6, 122)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(188, 40)
        Me.TxtTotal.TabIndex = 2
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 35)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Biaya"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(6, 25)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(188, 56)
        Me.BtnHitung.TabIndex = 0
        Me.BtnHitung.Text = "Hitung"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(739, 416)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gruopbox)
        Me.Controls.Add(Me.TxtByCuciMobil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gruopbox.ResumeLayout(False)
        Me.gruopbox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SuperTruck As System.Windows.Forms.RadioButton
    Friend WithEvents Truck As System.Windows.Forms.RadioButton
    Friend WithEvents Bus As System.Windows.Forms.RadioButton
    Friend WithEvents MiniBus As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtByCuciMobil As System.Windows.Forms.TextBox
    Friend WithEvents gruopbox As System.Windows.Forms.GroupBox
    Friend WithEvents txtTambah3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTambah2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTambah1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtJumlahNasGorSp As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlahMieGoreng As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlahJusJeruk As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlahNumDin As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahNasGor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumDin As System.Windows.Forms.TextBox
    Friend WithEvents TxtJusJeruk As System.Windows.Forms.TextBox
    Friend WithEvents TxtMieGoreng As System.Windows.Forms.TextBox
    Friend WithEvents TxtNasGorSp As System.Windows.Forms.TextBox
    Friend WithEvents TxtNasGor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents TxtKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
    Friend WithEvents makan2 As System.Windows.Forms.CheckBox
    Friend WithEvents makan3 As System.Windows.Forms.CheckBox
    Friend WithEvents makan4 As System.Windows.Forms.CheckBox
    Friend WithEvents makan5 As System.Windows.Forms.CheckBox
    Friend WithEvents makan1 As System.Windows.Forms.CheckBox
    Friend WithEvents Tambah2 As System.Windows.Forms.CheckBox
    Friend WithEvents Tambah3 As System.Windows.Forms.CheckBox
    Friend WithEvents Tambah1 As System.Windows.Forms.CheckBox

End Class
