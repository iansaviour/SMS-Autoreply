Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormPanelOperasi
    Dim id_operasi As String
    Private Sub FormPanelOperasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id_operasi = TEIdOperasi.Text
        refresh_parameter()
        refresh_view()
        refresh_log()
    End Sub
    Sub refresh_parameter()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT nama_parameter as 'Parameter','' as 'Value' FROM tb_operasi_parameter WHERE id_operasi='" & id_operasi & "'"
        Dim adapter As New MySqlDataAdapter(query, koneksi)

        koneksi.Open()
        adapter.Fill(data, "data")
        Me.GCparameter.DataSource = data.Tables("data")
        GVParameter.Columns("Parameter").OptionsColumn.AllowEdit = False
        koneksi.Close()
        koneksi.Dispose()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_eksekusi, query_id, ID, sms_out As String
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim n As Integer
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim error_tanda As Integer = 0
        Dim destination_num As String
        Dim sender_ID As String = sender_default_id()

        Dim char_pemisah As String

        koneksi.Open()
        query_id = "SELECT tb_host.karakter_pemisah FROM tb_operasi,tb_host WHERE tb_operasi.id_host = tb_host.id_host AND id_operasi='" & id_operasi & "'"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()

        If char_pemisah = "" Then
            'ambil pemisah
            koneksi.Open()
            query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
            command = koneksi.CreateCommand()
            command.CommandText = query_id
            reader = command.ExecuteReader()
            reader.Read()
            char_pemisah = reader.GetValue(0).ToString
            koneksi.Close()
            '
        End If

        sms_out = "OP" & char_pemisah

        koneksi.Open()
        query_id = "SHOW TABLE STATUS LIKE 'tb_operasi_out'"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        ID = reader.GetValue(10).ToString
        koneksi.Close()

        sms_out = sms_out & ID

        koneksi.Open()
        query_id = "SELECT keyword FROM tb_operasi WHERE id_operasi='" & id_operasi & "'"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        ID = reader.GetValue(0).ToString
        koneksi.Close()

        sms_out = sms_out & char_pemisah & ID

        koneksi.Open()
        query_id = "SELECT tb_host.no_hp FROM tb_operasi,tb_host WHERE tb_operasi.id_host = tb_host.id_host AND id_operasi='" & id_operasi & "'"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        destination_num = reader.GetValue(0).ToString
        koneksi.Close()

        koneksi.Open()
        query_eksekusi = "SELECT nama_parameter FROM tb_operasi_parameter WHERE id_operasi='" & id_operasi & "'"
        list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
        dset_eksekusi = New DataSet
        list_eksekusi.Fill(dset_eksekusi, "data")
        n = dset_eksekusi.Tables("data").Rows.Count
        For i = 0 To n - 1
            sms_out = sms_out & char_pemisah & GVParameter.GetRowCellValue(i, "Value").ToString
            If GVParameter.GetRowCellValue(i, "Value").ToString = "" Then
                error_tanda = 1
            End If
        Next i
        list_eksekusi.Dispose()
        dset_eksekusi.Dispose()
        koneksi.Close()
        koneksi.Dispose()

        If error_tanda = 0 Then
            koneksi.Open()
            command = koneksi.CreateCommand
            query_eksekusi = "INSERT INTO tb_operasi_out(id_operasi,no_hp,message_out) VALUES('" & id_operasi & "','" & destination_num & "','" & sms_out & "')"
            command.CommandText = query_eksekusi
            command.ExecuteNonQuery()
            query_eksekusi = "INSERT INTO outbox(DeliveryReport,TextDecoded,DestinationNumber,CreatorID,SenderID) VALUE ('" & delivery_report & "','" & sms_out & "','" & destination_num & "','1','" & sender_ID & "')"
            command.CommandText = query_eksekusi
            command.ExecuteNonQuery()
            koneksi.Close()
        Else
            Dim result As DialogResult
            result = XtraMessageBox.Show("Ada beberapa parameter yang tidak terisi !" & Environment.NewLine & "Parameter kosong dapat menyebabkan data null/error!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.Yes Then
                koneksi.Open()
                command = koneksi.CreateCommand
                query_eksekusi = "INSERT INTO tb_operasi_out(id_operasi,message_out) VALUES('" & id_operasi & "','" & sms_out & "')"
                command.CommandText = query_eksekusi
                command.ExecuteNonQuery()
                query_eksekusi = "INSERT INTO outbox(DeliveryReport,TextDecoded,DestinationNumber,CreatorID,SenderID) VALUE ('" & delivery_report & "','" & sms_out & "','" & destination_num & "','1','" & sender_ID & "')"
                command.CommandText = query_eksekusi
                command.ExecuteNonQuery()
                koneksi.Close()
            End If
        End If
        refresh_log()
        refresh_parameter()
        koneksi.Dispose()
    End Sub
    Sub refresh_log()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT tb_operasi_out.id_op_out AS 'Id','Reply' AS 'Status',tb_operasi_out_data.reply_data AS 'Command',DATE(tb_operasi_out_data.datetime) AS 'Tanggal',TIME(tb_operasi_out_data.datetime) AS 'Waktu' FROM tb_operasi_out_data,tb_operasi_out WHERE tb_operasi_out_data.id_op_out = tb_operasi_out.id_op_out AND id_operasi='" & id_operasi & "' UNION SELECT id_op_out AS 'Id','Perintah' AS 'Status',message_out AS 'Command',DATETIME AS 'Waktu' FROM tb_operasi_out WHERE id_operasi='" & id_operasi & "' AND tb_operasi_out.type='0' ORDER BY waktu DESC"
        Dim adapter As New MySqlDataAdapter(query, koneksi)

        koneksi.Open()
        adapter.Fill(data, "data")
        Me.GCLog.DataSource = data.Tables("data")
        Me.GVLog.Columns("Id").Visible = False
        koneksi.Close()
        koneksi.Dispose()
    End Sub
    Sub refresh_view()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim query_ID, data_reply, waktu, query_data, query_eksekusi, temp_pecah, param, valuex As String
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim n, m, o, p As Integer
        Dim words, words2, bijis As String()
        Dim jml_param, jml_biji As Integer
        Dim query As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader

        'ambil pemisah
        Dim char_pemisah As String
        koneksi.Open()
        query_ID = "SELECT tb_host.karakter_pemisah FROM tb_operasi,tb_host WHERE tb_operasi.id_host = tb_host.id_host AND id_operasi='" & id_operasi & "'"
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

        koneksi.Open()
        query_eksekusi = "SELECT tb_operasi_out_data.reply_data,tb_operasi_out_data.datetime FROM tb_operasi_out_data,tb_operasi_out WHERE tb_operasi_out_data.id_op_out=tb_operasi_out.id_op_out AND tb_operasi_out.id_operasi = '" & id_operasi & "' AND tb_operasi_out.type='0' ORDER BY tb_operasi_out_data.datetime DESC LIMIT 1"
        list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
        dset_eksekusi = New DataSet
        list_eksekusi.Fill(dset_eksekusi, "data")
        n = dset_eksekusi.Tables("data").Rows.Count
        If n <> 0 Then
            query = ""
            data_reply = dset_eksekusi.Tables("data").Rows(0)(0).ToString()
            waktu = dset_eksekusi.Tables("data").Rows(0)(1).ToString()
            query_data = ""
            If data_reply.Length > 7 Then
                If data_reply.Substring(0, 7) = "Error :" Then
                    query = String.Format("SELECT '{0}' as 'Error'", data_reply)
                ElseIf data_reply.Substring(0, 8) = "Sukses :" Then
                    query = String.Format("SELECT '{0}' as 'Sukses'", data_reply)
                Else
                    p = 1
                    bijis = data_reply.ToString.Split(New String() {"{:r:}"}, StringSplitOptions.None)
                    jml_biji = bijis.Length
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
                End If
            Else
                p = 1
                bijis = data_reply.ToString.Split(New String() {"{:r:}"}, StringSplitOptions.None)
                jml_biji = bijis.Length
                For Each biji In bijis
                    words = biji.Split(New Char() {char_pemisah})
                    jml_param = words.Length
                    query_data = "SELECT "
                    o = 1
                    For Each word In words
                        temp_pecah = word
                        words2 = temp_pecah.Split(New String() {"{:c:}"}, StringSplitOptions.None)
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
            End If
            koneksi.Close()

            If Not query = "" Then
                Dim data As New DataSet
                Dim adapter As New MySqlDataAdapter(query, koneksi)
                koneksi.Open()
                adapter.Fill(data, "data")
                GCViewOp.DataSource = data.Tables("data")
                GVViewOp.PopulateColumns()
                koneksi.Close()
            End If
        End If
        koneksi.Dispose()
    End Sub

    Private Sub BRefreshEksekusi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefreshEksekusi.Click
        refresh_log()
        refresh_view()
    End Sub
End Class