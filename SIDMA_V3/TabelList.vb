Imports System.Data.OleDb

Public Class TabelList
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Kuliah\Matkul\Pemrograman Visual\Tugas\Project\SIDMA_V3\Database\DataMHS.accdb")
    Dim dr As OleDbDataReader

    Private Sub TabelList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadingDatagridView()
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
End Class