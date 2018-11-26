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
        Me.components = New System.ComponentModel.Container()
        Me.PICgambar = New System.Windows.Forms.PictureBox()
        Me.BTN01 = New System.Windows.Forms.Button()
        Me.BTN02 = New System.Windows.Forms.Button()
        Me.BTN03 = New System.Windows.Forms.Button()
        Me.BTN04 = New System.Windows.Forms.Button()
        Me.BTN05 = New System.Windows.Forms.Button()
        Me.BTNotomatis = New System.Windows.Forms.Button()
        Me.TMRpewaktu = New System.Windows.Forms.Timer(Me.components)
        Me.BTNbuka = New System.Windows.Forms.Button()
        Me.BTNsimpan = New System.Windows.Forms.Button()
        CType(Me.PICgambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PICgambar
        '
        Me.PICgambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PICgambar.Location = New System.Drawing.Point(12, 12)
        Me.PICgambar.Name = "PICgambar"
        Me.PICgambar.Size = New System.Drawing.Size(528, 370)
        Me.PICgambar.TabIndex = 0
        Me.PICgambar.TabStop = False
        '
        'BTN01
        '
        Me.BTN01.Location = New System.Drawing.Point(562, 12)
        Me.BTN01.Name = "BTN01"
        Me.BTN01.Size = New System.Drawing.Size(138, 33)
        Me.BTN01.TabIndex = 1
        Me.BTN01.Text = "Gambar 1"
        Me.BTN01.UseVisualStyleBackColor = True
        '
        'BTN02
        '
        Me.BTN02.Location = New System.Drawing.Point(562, 51)
        Me.BTN02.Name = "BTN02"
        Me.BTN02.Size = New System.Drawing.Size(138, 33)
        Me.BTN02.TabIndex = 1
        Me.BTN02.Text = "Gambar 2"
        Me.BTN02.UseVisualStyleBackColor = True
        '
        'BTN03
        '
        Me.BTN03.Location = New System.Drawing.Point(562, 90)
        Me.BTN03.Name = "BTN03"
        Me.BTN03.Size = New System.Drawing.Size(138, 33)
        Me.BTN03.TabIndex = 1
        Me.BTN03.Text = "Gambar 3"
        Me.BTN03.UseVisualStyleBackColor = True
        '
        'BTN04
        '
        Me.BTN04.Location = New System.Drawing.Point(562, 129)
        Me.BTN04.Name = "BTN04"
        Me.BTN04.Size = New System.Drawing.Size(138, 33)
        Me.BTN04.TabIndex = 1
        Me.BTN04.Text = "Gambar 4"
        Me.BTN04.UseVisualStyleBackColor = True
        '
        'BTN05
        '
        Me.BTN05.Location = New System.Drawing.Point(562, 168)
        Me.BTN05.Name = "BTN05"
        Me.BTN05.Size = New System.Drawing.Size(138, 33)
        Me.BTN05.TabIndex = 1
        Me.BTN05.Text = "Gambar 5"
        Me.BTN05.UseVisualStyleBackColor = True
        '
        'BTNotomatis
        '
        Me.BTNotomatis.Location = New System.Drawing.Point(562, 207)
        Me.BTNotomatis.Name = "BTNotomatis"
        Me.BTNotomatis.Size = New System.Drawing.Size(138, 33)
        Me.BTNotomatis.TabIndex = 1
        Me.BTNotomatis.Text = "Otomatis"
        Me.BTNotomatis.UseVisualStyleBackColor = True
        '
        'TMRpewaktu
        '
        '
        'BTNbuka
        '
        Me.BTNbuka.Location = New System.Drawing.Point(562, 272)
        Me.BTNbuka.Name = "BTNbuka"
        Me.BTNbuka.Size = New System.Drawing.Size(138, 33)
        Me.BTNbuka.TabIndex = 1
        Me.BTNbuka.Text = "Buka Berkas"
        Me.BTNbuka.UseVisualStyleBackColor = True
        '
        'BTNsimpan
        '
        Me.BTNsimpan.Location = New System.Drawing.Point(562, 311)
        Me.BTNsimpan.Name = "BTNsimpan"
        Me.BTNsimpan.Size = New System.Drawing.Size(138, 33)
        Me.BTNsimpan.TabIndex = 1
        Me.BTNsimpan.Text = "Simpan Berkas"
        Me.BTNsimpan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 404)
        Me.Controls.Add(Me.BTNsimpan)
        Me.Controls.Add(Me.BTNbuka)
        Me.Controls.Add(Me.BTNotomatis)
        Me.Controls.Add(Me.BTN05)
        Me.Controls.Add(Me.BTN04)
        Me.Controls.Add(Me.BTN03)
        Me.Controls.Add(Me.BTN02)
        Me.Controls.Add(Me.BTN01)
        Me.Controls.Add(Me.PICgambar)
        Me.Font = New System.Drawing.Font("Cambria", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form1"
        Me.Text = "Menampilkan File Gambar"
        CType(Me.PICgambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PICgambar As System.Windows.Forms.PictureBox
    Friend WithEvents BTN01 As System.Windows.Forms.Button
    Friend WithEvents BTN02 As System.Windows.Forms.Button
    Friend WithEvents BTN03 As System.Windows.Forms.Button
    Friend WithEvents BTN04 As System.Windows.Forms.Button
    Friend WithEvents BTN05 As System.Windows.Forms.Button
    Friend WithEvents BTNotomatis As System.Windows.Forms.Button
    Friend WithEvents TMRpewaktu As System.Windows.Forms.Timer
    Friend WithEvents BTNbuka As System.Windows.Forms.Button
    Friend WithEvents BTNsimpan As System.Windows.Forms.Button

End Class
