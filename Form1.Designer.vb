<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LabelNama = New Label()
        LabelNIM = New Label()
        LabelProdi = New Label()
        LabelMatkul = New Label()
        TextBoxNim = New TextBox()
        TextBoxNama = New TextBox()
        ComboBoxProdi = New ComboBox()
        CheckBoxAlgo = New CheckBox()
        CheckBoxPemrograman = New CheckBox()
        CheckBoxAkuntansi = New CheckBox()
        CheckBoxDesain = New CheckBox()
        CheckBoxRobotika = New CheckBox()
        ButtonSend = New Button()
        SuspendLayout()
        ' 
        ' LabelNama
        ' 
        LabelNama.AutoSize = True
        LabelNama.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNama.Location = New Point(76, 99)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(71, 25)
        LabelNama.TabIndex = 0
        LabelNama.Text = "Nama :"' 
        ' LabelNIM
        ' 
        LabelNIM.AutoSize = True
        LabelNIM.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LabelNIM.Location = New Point(90, 52)
        LabelNIM.Name = "LabelNIM"
        LabelNIM.Size = New Size(62, 25)
        LabelNIM.TabIndex = 1
        LabelNIM.Text = "NIM : "' 
        ' LabelProdi
        ' 
        LabelProdi.AutoSize = True
        LabelProdi.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LabelProdi.Location = New Point(81, 151)
        LabelProdi.Name = "LabelProdi"
        LabelProdi.Size = New Size(66, 25)
        LabelProdi.TabIndex = 2
        LabelProdi.Text = "Prodi :"' 
        ' LabelMatkul
        ' 
        LabelMatkul.AutoSize = True
        LabelMatkul.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LabelMatkul.Location = New Point(25, 197)
        LabelMatkul.Name = "LabelMatkul"
        LabelMatkul.Size = New Size(122, 25)
        LabelMatkul.TabIndex = 3
        LabelMatkul.Text = "Mata Kuliah :"' 
        ' TextBoxNim
        ' 
        TextBoxNim.Location = New Point(158, 57)
        TextBoxNim.Name = "TextBoxNim"
        TextBoxNim.Size = New Size(191, 23)
        TextBoxNim.TabIndex = 4
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(158, 104)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(337, 23)
        TextBoxNama.TabIndex = 5
        ' 
        ' ComboBoxProdi
        ' 
        ComboBoxProdi.FormattingEnabled = True
        ComboBoxProdi.Items.AddRange(New Object() {"Sistem Informasi", "Teknik Multimedia Jaringan", "Teknik Informatika", "Komputerisasi Akuntansi"})
        ComboBoxProdi.Location = New Point(158, 156)
        ComboBoxProdi.Name = "ComboBoxProdi"
        ComboBoxProdi.Size = New Size(191, 23)
        ComboBoxProdi.TabIndex = 6
        ' 
        ' CheckBoxAlgo
        ' 
        CheckBoxAlgo.AutoSize = True
        CheckBoxAlgo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxAlgo.Location = New Point(158, 199)
        CheckBoxAlgo.Name = "CheckBoxAlgo"
        CheckBoxAlgo.Size = New Size(98, 25)
        CheckBoxAlgo.TabIndex = 7
        CheckBoxAlgo.Text = "Algoritma"
        CheckBoxAlgo.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxPemrograman
        ' 
        CheckBoxPemrograman.AutoSize = True
        CheckBoxPemrograman.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxPemrograman.Location = New Point(158, 230)
        CheckBoxPemrograman.Name = "CheckBoxPemrograman"
        CheckBoxPemrograman.Size = New Size(128, 25)
        CheckBoxPemrograman.TabIndex = 8
        CheckBoxPemrograman.Text = "Pemrograman"
        CheckBoxPemrograman.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxAkuntansi
        ' 
        CheckBoxAkuntansi.AutoSize = True
        CheckBoxAkuntansi.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxAkuntansi.Location = New Point(158, 261)
        CheckBoxAkuntansi.Name = "CheckBoxAkuntansi"
        CheckBoxAkuntansi.Size = New Size(98, 25)
        CheckBoxAkuntansi.TabIndex = 9
        CheckBoxAkuntansi.Text = "Akuntansi"
        CheckBoxAkuntansi.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxDesain
        ' 
        CheckBoxDesain.AutoSize = True
        CheckBoxDesain.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxDesain.Location = New Point(158, 292)
        CheckBoxDesain.Name = "CheckBoxDesain"
        CheckBoxDesain.Size = New Size(76, 25)
        CheckBoxDesain.TabIndex = 10
        CheckBoxDesain.Text = "Desain"
        CheckBoxDesain.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxRobotika
        ' 
        CheckBoxRobotika.AutoSize = True
        CheckBoxRobotika.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBoxRobotika.Location = New Point(158, 323)
        CheckBoxRobotika.Name = "CheckBoxRobotika"
        CheckBoxRobotika.Size = New Size(91, 25)
        CheckBoxRobotika.TabIndex = 11
        CheckBoxRobotika.Text = "Robotika"
        CheckBoxRobotika.UseVisualStyleBackColor = True
        ' 
        ' ButtonSend
        ' 
        ButtonSend.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonSend.Location = New Point(356, 388)
        ButtonSend.Name = "ButtonSend"
        ButtonSend.Size = New Size(139, 63)
        ButtonSend.TabIndex = 12
        ButtonSend.Text = "Kirim"
        ButtonSend.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(542, 487)
        Controls.Add(ButtonSend)
        Controls.Add(CheckBoxRobotika)
        Controls.Add(CheckBoxDesain)
        Controls.Add(CheckBoxAkuntansi)
        Controls.Add(CheckBoxPemrograman)
        Controls.Add(CheckBoxAlgo)
        Controls.Add(ComboBoxProdi)
        Controls.Add(TextBoxNama)
        Controls.Add(TextBoxNim)
        Controls.Add(LabelMatkul)
        Controls.Add(LabelProdi)
        Controls.Add(LabelNIM)
        Controls.Add(LabelNama)
        MaximizeBox = False
        Name = "Form1"
        Text = "Perhitungan UKP & UKV"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelNIM As Label
    Friend WithEvents LabelProdi As Label
    Friend WithEvents LabelMatkul As Label
    Friend WithEvents TextBoxNim As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents ComboBoxProdi As ComboBox
    Friend WithEvents CheckBoxAlgo As CheckBox
    Friend WithEvents CheckBoxPemrograman As CheckBox
    Friend WithEvents CheckBoxAkuntansi As CheckBox
    Friend WithEvents CheckBoxDesain As CheckBox
    Friend WithEvents CheckBoxRobotika As CheckBox
    Friend WithEvents ButtonSend As Button
End Class
