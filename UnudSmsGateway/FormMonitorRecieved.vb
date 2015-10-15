Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class FormMonitorRecieved
    Private Sub FormMonitorRecieved_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        Try
            view_list()
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub
    Public Sub view_list()
        Dim query As String = "SELECT tb_operasi_out.id_op_out,tb_operasi_out.id_operasi, DATE(tb_operasi_out.datetime) AS date, TIME(tb_operasi_out.datetime) AS time, tb_operasi_out.message_out AS message, tb_operasi_out.no_hp, tb_operasi.nama_operasi AS operasi FROM tb_operasi_out, tb_operasi, tb_operasi_out_data WHERE tb_operasi_out_data.id_op_out = tb_operasi_out.id_op_out AND tb_operasi.id_operasi = tb_operasi_out.id_operasi ORDER BY tb_operasi_out.datetime DESC"
        Dim data As DataTable

        data = execute_query(query, -1, True, "", "", "", "")
        GCRequest.DataSource = data

        If data.Rows.Count > 0 Then
            BDeleteInbox.Enabled = True
        Else
            BDeleteInbox.Enabled = False
        End If

        If GVRequest.RowCount > 0 Then
            Dim id_op_out As String = GVRequest.GetFocusedRowCellDisplayText("id_op_out").ToString
            view_partner(id_op_out)
        Else
            GVResult.Columns.Clear()

            If Not GCResult.DataSource Is Nothing Then
                Dim data_cast As DataTable = GCResult.DataSource

                data_cast.Rows.Clear()
            End If
        End If
    End Sub
    Public Sub view_partner(ByVal id_op_out As String)
        Dim query2 As String = String.Format("SELECT reply_data, format FROM tb_operasi_out_data WHERE id_op_out = '{0}'", id_op_out)
        Dim data_temp As DataTable = execute_query(query2, -1, True, "", "", "", "")
        Dim data As New DataTable

        Dim koneksi As New MySqlConnection(conn_db)
        Dim query_ID, temp_pecah, data_reply, query_data, param, valuex As String
        Dim m, o, formatx, p As Integer
        Dim words, words2, bijis As String()
        Dim jml_param, jml_biji As Integer
        Dim query As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader

        formatx = 1

        If data_temp.Rows(0)("reply_data").ToString.Substring(0, 7) = "Error :" Or data_temp.Rows(0)("reply_data").ToString.Substring(0, 8) = "Sukses :" Or data_temp.Rows(0)("reply_data").ToString.Length < 7 Then
            formatx = 0
        End If

        If formatx.ToString = "1" Then
            'ambil pemisah
            Dim char_pemisah As String
            koneksi.Open()
            query_ID = "SELECT tb_host.karakter_pemisah FROM tb_operasi,tb_host,tb_operasi_out WHERE tb_operasi_out.id_operasi = tb_operasi.id_operasi AND tb_operasi.id_host = tb_host.id_host AND id_op_out='" & id_op_out & "'"
            command = koneksi.CreateCommand()
            command.CommandText = query_ID
            reader = command.ExecuteReader()
            reader.Read()
            char_pemisah = reader.GetValue(0).ToString
            koneksi.Close()

            If char_pemisah = "" Then
                koneksi.Open()
                query_ID = "SELECT char_pemisah FROM tb_option LIMIT 1"
                command = koneksi.CreateCommand()
                command.CommandText = query_ID
                reader = command.ExecuteReader()
                reader.Read()
                char_pemisah = reader.GetValue(0).ToString
                koneksi.Close()
            End If

            data_reply = data_temp.Rows(0)("reply_data").ToString
            p = 1
            bijis = data_reply.ToString.Split(New String() {"{:r:}"}, StringSplitOptions.None)
            jml_biji = bijis.Length
            query = ""
            For Each biji In bijis
                words = biji.Split(New Char() {char_pemisah})
                jml_param = words.Length
                query_data = "SELECT "
                o = 1
                For Each word In words
                    temp_pecah = word
                    words2 = temp_pecah.ToString.Split(New String() {"{:c:}"}, StringSplitOptions.None)
                    m = 1
                    param = ""
                    valuex = ""
                    For Each word2 In words2
                        If m = 1 Then
                            param = word2
                        Else
                            valuex = word2
                        End If
                        m = m + 1
                    Next
                    If o = jml_param Then
                        query_data = query_data & "'" & valuex & "' AS '" & param & "'"
                    Else
                        query_data = query_data & "'" & valuex & "' AS '" & param & "',"
                    End If

                    o = o + 1
                Next
                If p = jml_biji Then
                    query = query & query_data
                Else
                    query = query & query_data & " UNION "
                End If
                p = p + 1
            Next

            Dim data2 As New DataSet
            Dim adapter As New MySqlDataAdapter(query, koneksi)
            koneksi.Open()
            adapter.Fill(data2, "data")
            GCResult.DataSource = data2.Tables("data")
            GVResult.PopulateColumns()
            koneksi.Close()
        Else
            data.Columns.Add("data_respond")

            For i As Integer = 0 To data_temp.Rows.Count - 1
                data.Rows.Add(data_temp.Rows(i)("reply_data").ToString)
            Next

            GVResult.Columns.Clear()
            GCResult.DataSource = data

            GVResult.Columns(0).Caption = "Respond"
        End If
    End Sub

    Private Sub GVRequest_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVRequest.RowClick
        Cursor = Cursors.WaitCursor

        Try
            Dim id_op_out As String = GVRequest.GetFocusedRowCellDisplayText("id_op_out").ToString

            view_partner(id_op_out)
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub BDeleteInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteInbox.Click
        Dim confirm As DialogResult = XtraMessageBox.Show("Anda yakin ingin menghapus log ini?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = Windows.Forms.DialogResult.Yes Then
            Cursor = Cursors.WaitCursor

            Try
                Dim id_op_out As String = GVRequest.GetFocusedRowCellDisplayText("id_op_out").ToString
                Dim query As String = String.Format("DELETE tb_operasi_out, tb_operasi_out_data FROM tb_operasi_out, tb_operasi_out_data WHERE tb_operasi_out.id_op_out = tb_operasi_out_data.id_op_out AND tb_operasi_out.id_op_out = '{0}'", id_op_out)

                execute_non_query(query, True, "", "", "", "")
                view_list()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        print(GCRequest, "Log Remote Receive")
    End Sub

    Private Sub BPrintResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintResult.Click
        print(GCResult, "Balasan " & GVRequest.GetFocusedRowCellDisplayText("message").ToString & " - " & GVRequest.GetFocusedRowCellDisplayText("date").ToString & " - " & GVRequest.GetFocusedRowCellDisplayText("time").ToString)
    End Sub
End Class