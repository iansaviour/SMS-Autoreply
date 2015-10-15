Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormKeyword
    Private Sub FormKeyword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_operasi()
    End Sub
    Sub refresh_operasi()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT tb_operasi.id_operasi,tb_operasi.id_host,tb_host.nama_host AS 'Nama Host',tb_operasi.keyword as 'Keyword',tb_host.db as 'Database',tb_operasi.id_jenis_sql,tb_jenis_sql.jenis_sql AS 'Jenis SQL',tb_operasi.id_jenis_operasi,tb_jenis_operasi.jenis_operasi AS 'Jenis operasi',tb_operasi.nama_operasi AS 'Nama operasi',IF(tb_operasi.is_publik='1','Publik','Privat') AS 'Publik' FROM(tb_operasi, tb_jenis_operasi, tb_jenis_sql, tb_host) WHERE tb_operasi.id_jenis_operasi = tb_jenis_operasi.id_jenis_operasi AND tb_operasi.id_jenis_sql=tb_jenis_sql.id_jenis_sql AND tb_operasi.id_host=tb_host.id_host AND tb_host.is_local='1'"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCOperasi.DataSource = data.Tables("data")
            Me.GVOperasi.Columns("id_operasi").Visible = False
            Me.GVOperasi.Columns("id_host").Visible = False
            Me.GVOperasi.Columns("id_jenis_sql").Visible = False
            Me.GVOperasi.Columns("id_jenis_operasi").Visible = False
            koneksi.Close()
            If GVOperasi.RowCount.ToString() = "0" Then
                Me.BDeleteKeyword.Visible = False
            Else
                Me.BDeleteKeyword.Visible = True
            End If
            If GVOperasi.RowCount > 0 Then
                Dim id_operasi As Integer = GVOperasi.GetDataRow(GVOperasi.FocusedRowHandle)(0)
                view_partner(id_operasi)
            Else
                If Not GCCast.DataSource Is Nothing Then
                    Dim data_cast As DataTable = GCCast.DataSource
                    data_cast.Rows.Clear()
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        koneksi.Dispose()
        data.Dispose()
    End Sub
    Sub delete_operasi(ByVal id_operasi As String)
        Try
            Dim koneksi As New MySqlConnection(conn_db)
            koneksi.Open()
            Dim command As MySqlCommand = koneksi.CreateCommand
            Dim query As String = "DELETE FROM tb_operasi WHERE id_operasi='" & id_operasi & "'"
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            koneksi.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub tes_koneksi(ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String)
        Dim conn As String
        conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";Database=" & database
        Dim koneksi As MySqlConnection = New MySqlConnection(conn)
        koneksi.Open()
        koneksi.Close()
        koneksi.Dispose()
    End Sub
    Private Sub BtambahOperasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtambahOperasi.Click
        FormSingleOperasi.id_operasi = "-1"
        FormSingleOperasi.ShowDialog()
    End Sub
    Private Sub BDeleteKeyword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteKeyword.Click
        Dim result As DialogResult
        result = XtraMessageBox.Show("Anda yakin ingin menghapus Operasi?" & Environment.NewLine & "Data operasi yang berkaitan dengan oeprasi ini juga akan dihapus!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            delete_operasi(Me.GVOperasi.GetFocusedRowCellDisplayText("id_operasi").ToString())
            refresh_operasi()
        End If
    End Sub
    Private Sub BExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExport.Click
        FormExportOperasi.ShowDialog()
    End Sub
    Private Sub BEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEdit.Click
        FormSingleOperasi.id_operasi = GVOperasi.GetFocusedRowCellDisplayText("id_operasi").ToString()
        FormSingleOperasi.ShowDialog()
    End Sub
    Public Sub view_partner(ByVal id_operasi As Integer)
        Dim query As String = "SELECT * FROM tb_host WHERE is_local = '0'"
        Dim data_temp As DataTable = execute_query(query, -1, True, "", "", "", "")
        Dim data As New DataTable

        data.Columns.Add("id_host")
        data.Columns.Add("cek").DataType = GetType(Boolean)
        data.Columns.Add("nama_host")
        data.Columns.Add("no_hp")
        data.Columns.Add("email")

        For i As Integer = 0 To data_temp.Rows.Count - 1
            If (cek_partner(id_operasi, data_temp.Rows(i)("id_host")) > 0) Then
                data.Rows.Add(data_temp.Rows(i)("id_host").ToString, True, data_temp.Rows(i)("nama_host").ToString, data_temp.Rows(i)("no_hp").ToString, data_temp.Rows(i)("email").ToString)
            Else
                data.Rows.Add(data_temp.Rows(i)("id_host").ToString, False, data_temp.Rows(i)("nama_host").ToString, data_temp.Rows(i)("no_hp").ToString, data_temp.Rows(i)("email").ToString)
            End If
        Next

        GCCast.DataSource = data
    End Sub
    Public Function cek_partner(ByVal id_operasi As Integer, ByVal id_host As Integer)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_cast WHERE id_host = '{0}' AND id_operasi = '{1}'", id_host, id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Return data.Rows.Count
    End Function
    Public Sub add_cast(ByVal id_host As Integer, ByVal id_operasi As Integer)
        Dim query As String = String.Format("INSERT INTO tb_operasi_cast(id_host, id_operasi) VALUES('{0}','{1}')", id_host, id_operasi)
        execute_non_query(query, True, "", "", "", "")
    End Sub

    Public Sub del_cast(ByVal id_host As Integer, ByVal id_operasi As Integer)
        Dim query As String = String.Format("DELETE FROM tb_operasi_cast WHERE id_host = '{0}' AND id_operasi = '{1}'", id_host, id_operasi)
        execute_non_query(query, True, "", "", "", "")
    End Sub

    Private Sub GVCast_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVCast.RowClick
        Cursor = Cursors.WaitCursor
        Try
            Dim id_host As Integer = GVCast.GetDataRow(e.RowHandle)(0)
            Dim id_operasi As Integer = GVOperasi.GetDataRow(GVOperasi.FocusedRowHandle)(0)

            If GVCast.GetFocusedRowCellValue("cek") = False Then
                GVCast.SetFocusedRowCellValue("cek", True)
                add_cast(id_host, id_operasi)
            Else
                GVCast.SetFocusedRowCellValue("cek", False)
                del_cast(id_host, id_operasi)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub GVOperasi_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVOperasi.RowClick
        Cursor = Cursors.WaitCursor
        Try
            Dim id_operasi As Integer = GVOperasi.GetDataRow(GVOperasi.FocusedRowHandle)(0)

            view_partner(id_operasi)
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        print(GCOperasi, "Operasi Lokal")
    End Sub
End Class