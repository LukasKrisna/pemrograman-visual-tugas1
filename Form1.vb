Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Public Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        'deklarasi variabel
        Dim ukv As Integer = 150000
        Dim ukp, jumlahUkv

        'validasi formulir
        If TextBoxNim.Text = "" Or
           TextBoxNama.Text = "" Or
           ComboBoxProdi.Text = "" Or (
           CheckBoxAkuntansi.Checked = False And
           CheckBoxAlgo.Checked = False And
           CheckBoxDesain.Checked = False And
           CheckBoxPemrograman.Checked = False And
           CheckBoxRobotika.Checked = False) Then

            MsgBox("NIM, Nama, Prodi dan setidaknya 1 Mata Kuliah harus terisi")

        Else
            'pengkondisian ukp setiap prodi sesuai combo box
            If ComboBoxProdi.Text = "Sistem Informasi" Then
                ukp = "Rp 1.000.000"
            ElseIf ComboBoxProdi.Text = "Teknik Informatika" Then
                ukp = "Rp 1.000.000"
            ElseIf ComboBoxProdi.Text = "Komputerisasi Akuntansi" Then
                ukp = "Rp 700.000"
            ElseIf ComboBoxProdi.Text = "Teknik Multimedia Jaringan" Then
                ukp = "Rp 1.500.000"
            End If

            'pengkondisian jumlah ukv sesuai pilihan check box
            If CheckBoxAlgo.Checked = True Then
                jumlahUkv = jumlahUkv + ukv
            End If
            If CheckBoxPemrograman.Checked = True Then
                jumlahUkv = jumlahUkv + ukv
            End If
            If CheckBoxAkuntansi.Checked = True Then
                jumlahUkv = jumlahUkv + ukv
            End If
            If CheckBoxDesain.Checked = True Then
                jumlahUkv = jumlahUkv + ukv
            End If
            If CheckBoxRobotika.Checked = True Then
                jumlahUkv = jumlahUkv + ukv
            End If

            'menampilkan hasil form
            MsgBox(TextBoxNim.Text + vbCrLf + TextBoxNama.Text + vbCrLf + ComboBoxProdi.Text + vbCrLf +
                   "UKP " + ukp + vbCrLf + "UKV Rp " + jumlahUkv.ToString)
        End If

    End Sub
End Class
