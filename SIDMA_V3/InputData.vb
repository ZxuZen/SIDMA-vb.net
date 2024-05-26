Imports System.Data.OleDb
Imports System.IO

Public Class InputData
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kuliah\Matkul\Pemrograman Visual\Tugas\Project\SIDMA_V3\Database\DataMHS.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Dim isDataSelected As Boolean

    Private Sub InputData_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub InputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message)
        End Try
        conn.Close()
        loadingDatagridView()
        FillKelasComboBox()
    End Sub

    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from DataMhs", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("NIM"), dr.Item("Nama"), dr.Item("Angkatan"), dr.Item("Kelas"), dr.Item("Jenis Kelamin"), dr.Item("Status"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub FillKelasComboBox()
        Dim kelasList As New List(Of String)
        kelasList.Add("TI A")
        kelasList.Add("TI B")
        kelasList.Add("TI C")
        kelasList.Add("PTI A")
        kelasList.Add("PTI B")
        kelasList.Add("PTI C")
        kelasList.Add("SI A")
        kelasList.Add("SI B")
        kelasList.Add("SI C")

        cbKelas.Items.Clear()

        For Each kelas In kelasList
            cbKelas.Items.Add(kelas)
        Next
    End Sub

    Sub clear()
        txtNama.Clear()
        txtNIM.Clear()
        rdAktif.Checked = False
        rdNon.Checked = False
        rdLanang.Checked = False
        rdWedok.Checked = False
        cbAngkatan.SelectedIndex = -1
        cbKelas.SelectedIndex = -1
    End Sub

    Sub save()
        Dim NIM As String = txtNIM.Text
        Dim Nama As String = txtNama.Text
        Dim Angkatan As String = If(cbAngkatan.SelectedItem Is Nothing, "", cbAngkatan.SelectedItem.ToString)
        Dim Kelas As String = If(cbKelas.SelectedItem Is Nothing, "", cbKelas.SelectedItem.ToString)
        Dim Gender As String = "Tidak Ada Gender Terpilih"
        Dim AktifPoOra As String = "Tidak Ada Status Terpilih"

        If Not IsNumeric(NIM) Then
            MsgBox("Masukkan angka sebagai NIM.", vbExclamation)
            Return
        End If

        If NIM.Length < 11 Then
            MsgBox("NIM kurang dari 11 angka.", vbExclamation)
            Return
        End If

        If NIM.Length > 11 Then
            MsgBox("NIM lebih dari 11 angka.", vbExclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(Angkatan) Then
            MsgBox("Anda belum memilih angkatan.", vbExclamation)
            Return
        End If

        If String.IsNullOrWhiteSpace(Kelas) Then
            MsgBox("Anda belum memilih kelas.", vbExclamation)
            Return
        End If

        If rdLanang.Checked = True Then
            Gender = rdLanang.Text
        ElseIf rdWedok.Checked = True Then
            Gender = rdWedok.Text
        Else
            MsgBox("Anda belum memilih gender.", vbExclamation)
            Return
        End If

        If rdAktif.Checked = True Then
            AktifPoOra = rdAktif.Text
        ElseIf rdNon.Checked = True Then
            AktifPoOra = rdNon.Text
        Else
            MsgBox("Anda belum memilih status mahasiswa.", vbExclamation)
            Return
        End If

        If IsNimDuplicated(NIM) Then
            MsgBox("NIM telah digunakan.", vbExclamation)
            Return
        End If

        If Nama.Any(Function(c) Char.IsDigit(c)) Then
            MsgBox("Isi Nama dengan Huruf.", vbExclamation)
            Return
        End If

        Try
            conn.Open()
            If MsgBox("Apakah anda yakin menyimpan data ini", vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("INSERT INTO DataMhs (NIM, Nama, Angkatan, Kelas, [Jenis Kelamin], [Status]) VALUES (@NIM, @Nama, @Angkatan, @Kelas, @JenisKelamin, @Status)", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@NIM", NIM)
                cmd.Parameters.AddWithValue("@Nama", Nama)
                cmd.Parameters.AddWithValue("@Angkatan", Angkatan)
                cmd.Parameters.AddWithValue("@Kelas", Kelas)
                cmd.Parameters.AddWithValue("@JenisKelamin", Gender)
                cmd.Parameters.AddWithValue("@Status", AktifPoOra)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data berhasil disimpan", vbInformation)
                Else
                    MsgBox("Data gagal disimpan", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatagridView()
        clear()
    End Sub

    Function IsNimDuplicated(nim As String) As Boolean
        Dim query As String = "SELECT NIM FROM DataMhs WHERE NIM = @NIM"
        Using cmd As New OleDbCommand(query, conn)
            cmd.Parameters.AddWithValue("@NIM", nim)
            conn.Open()
            Dim result As Object = cmd.ExecuteScalar()
            conn.Close()
            Return result IsNot Nothing
        End Using
    End Function

    Sub delete()
        Try
            conn.Open()
            If MsgBox("Apakah anda yakin menghapus data ini", vbYesNo) = vbYes Then
                Dim cmd As New OleDbCommand("Delete from DataMhs Where NIM=@NIM", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Data berhasil dihapus", vbInformation)
                Else
                    MsgBox("Data gagal dihapus", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        loadingDatagridView()
        clear()
    End Sub

    Sub golek()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from DataMhs WHERE NIM LIKE @search OR Nama LIKE @search", conn)
            cmd.Parameters.AddWithValue("@search", "%" & txtCari.Text & "%")
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("NIM"), dr.Item("Nama"), dr.Item("Angkatan"), dr.Item("Kelas"), dr.Item("Jenis Kelamin"), dr.Item("Status"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        clear
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        save()
    End Sub

    Private Sub btnTI_Click(sender As Object, e As EventArgs) Handles btnTI.Click
        FillKelasComboBoxForProdi("TI")
    End Sub

    Private Sub btnPTI_Click(sender As Object, e As EventArgs) Handles btnPTI.Click
        FillKelasComboBoxForProdi("PTI")
    End Sub

    Private Sub btnSI_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        FillKelasComboBoxForProdi("SI")
    End Sub

    Private Sub FillKelasComboBoxForProdi(prodi As String)
        Dim kelasList As New List(Of String)

        If prodi = "TI" Then
            kelasList.Add("TI A")
            kelasList.Add("TI B")
            kelasList.Add("TI C")
        ElseIf prodi = "PTI" Then
            kelasList.Add("PTI A")
            kelasList.Add("PTI B")
            kelasList.Add("PTI C")
        ElseIf prodi = "SI" Then
            kelasList.Add("SI A")
            kelasList.Add("SI B")
            kelasList.Add("SI C")
        End If

        cbKelas.Items.Clear()

        For Each kelas In kelasList
            cbKelas.Items.Add(kelas)
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            txtNIM.Text = selectedRow.Cells(0).Value.ToString()
            txtNama.Text = selectedRow.Cells(1).Value.ToString()
            cbAngkatan.SelectedItem = selectedRow.Cells(2).Value.ToString()
            cbKelas.SelectedItem = selectedRow.Cells(3).Value.ToString()

            Dim jenisKelamin As String = selectedRow.Cells(4).Value.ToString()
            If jenisKelamin = "Laki-Laki" Then
                rdLanang.Checked = True
            ElseIf jenisKelamin = "Perempuan" Then
                rdWedok.Checked = True
            Else
                rdLanang.Checked = False
                rdWedok.Checked = False
            End If

            Dim status As String = selectedRow.Cells(5).Value.ToString()
            If status = "Aktif" Then
                rdAktif.Checked = True
            ElseIf status = "Tidak Aktif" Then
                rdNon.Checked = True
            Else
                rdAktif.Checked = False
                rdNon.Checked = False
            End If

            isDataSelected = True
        End If
    End Sub

    Private Sub btnDelData_Click(sender As Object, e As EventArgs) Handles btnDelData.Click
        delete()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If isDataSelected Then
            Dim NIM As String = txtNIM.Text
            Dim Nama As String = txtNama.Text
            Dim Angkatan As String = cbAngkatan.SelectedItem.ToString
            Dim Kelas As String = cbKelas.SelectedItem.ToString
            Dim Gender As String = "Tidak Ada Gender Terpilih"
            Dim AktifPoOra As String = "Tidak Ada Status Terpilih"

            If rdLanang.Checked = True Then
                Gender = rdLanang.Text
            ElseIf rdWedok.Checked = True Then
                Gender = rdWedok.Text
            End If

            If rdAktif.Checked = True Then
                AktifPoOra = rdAktif.Text
            ElseIf rdNon.Checked = True Then
                AktifPoOra = rdNon.Text
            End If

            Try
                conn.Open()
                Dim cmd As New OleDbCommand("UPDATE DataMhs SET Nama=?, Angkatan=?, Kelas=?, [Jenis Kelamin]=?, [Status]=? WHERE NIM=?", conn)
                cmd.Parameters.AddWithValue("?", Nama)
                cmd.Parameters.AddWithValue("?", Angkatan)
                cmd.Parameters.AddWithValue("?", Kelas)
                cmd.Parameters.AddWithValue("?", Gender)
                cmd.Parameters.AddWithValue("?", AktifPoOra)
                cmd.Parameters.AddWithValue("?", NIM)

                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try

            MessageBox.Show("Data berhasil diperbarui")
            loadingDatagridView()
            clear()
        Else
            MessageBox.Show("Silahkan pilih data yang akan diperbarui")
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        golek()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        TabelList.Show()
    End Sub
End Class