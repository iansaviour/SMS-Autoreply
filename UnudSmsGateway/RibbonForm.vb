Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
'todo
'- spam reply message
'- broadcast
'- loading progress bar di select service gammu atau other
'- create say function
'- 
Public Class RibbonForm
    Public timer_status As Boolean = True
    Public id_user As Integer
    Public username As String
    Public is_login As Boolean
    Public is_ext_sch_tray As Boolean = False
    Public is_use_gammu As String = "1" '1 = gammu, 2 = not using gammu

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuSMS.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormSMS.MdiParent = Me
            FormSMS.Show()
            FormSMS.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormSMS.WindowState = FormWindowState.Maximized
        FormSMS.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cast_operasi(ByVal sender As String, ByVal id_operasi As Integer, ByVal message As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_cast, tb_host WHERE tb_operasi_cast.id_host = tb_host.id_host AND tb_operasi_cast.id_operasi = '{0}'", id_operasi)

        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_id, sms_out As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim error_tanda As Integer = 0

        Dim sender_ID As String = sender_default_id()
        Dim pemisah_lokal As String

        'ambil pemisah
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        pemisah_lokal = reader.GetValue(0).ToString
        koneksi.Close()
        '

        For i As Integer = 0 To data.Rows.Count - 1
            Dim no_hp As String = data.Rows(i)("no_hp").ToString

            If no_hp <> sender Or no_hp <> nomor_default() Then
                Dim karakter_pemisah As String = data.Rows(i)("karakter_pemisah").ToString

                If karakter_pemisah = "" Then
                    'ambil pemisah
                    koneksi.Open()
                    query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
                    command = koneksi.CreateCommand()
                    command.CommandText = query_id
                    reader = command.ExecuteReader()
                    reader.Read()
                    karakter_pemisah = reader.GetValue(0).ToString
                    koneksi.Close()
                    '
                End If

                sms_out = message.ToString.Replace(pemisah_lokal, karakter_pemisah)

                fungsi_send_sms(sms_out, no_hp, "2")

                koneksi.Close()
                koneksi.Dispose()
            End If
        Next
    End Sub

    Private Sub RibbonForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        apply_skin()
        has_start_service = 0

        If Not File.Exists(My.Application.Info.DirectoryPath.ToString & "\DatabaseConfiguration.xml") Then
            connection_problem = True
            DashboardToolStripMenuItem.Visible = False
            FormServer.ShowInTaskbar = True
            FormServer.ShowDialog()
        Else
            Try
                read_database_configuration()
                check_connection(True, "", "", "", "")
            Catch ex As Exception
                connection_problem = True
                DashboardToolStripMenuItem.Visible = False
                FormServer.ShowInTaskbar = True
                FormServer.ShowDialog()
            End Try
        End If
        If has_start_service = 0 Then
            FormServiceSetup.ShowDialog()
        End If
        '
        If is_use_gammu = "1" Then
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim query_eksekusi, id_modem, nama_modem As String
            Dim list_eksekusi As MySqlDataAdapter
            Dim dset_eksekusi As DataSet
            Dim n As Integer
            'service test
            query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()
            If n = 0 Then
                connection_problem = True
                DashboardToolStripMenuItem.Visible = False
                FormSettingGammu.ShowInTaskbar = True
                FormSettingGammu.ShowDialog()
            Else
                Try
                    'read_gammu_configuration()
                    'nama_gammu_service = "GammuSMSD"
                    If Not CheckService() Then
                        InstallService()
                    End If
                    'service test
                    query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
                    list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                    dset_eksekusi = New DataSet
                    list_eksekusi.Fill(dset_eksekusi, "data")
                    n = dset_eksekusi.Tables("data").Rows.Count
                    id_modem = dset_eksekusi.Tables("data").Rows(0)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(0)(1).ToString()
                    Dim nama_serviceawal = "GammuSMSD" & id_modem
                    list_eksekusi.Dispose()
                    dset_eksekusi.Dispose()
                    koneksi.Dispose()
                    'end ambil testing service

                    If Not GetServiceStatus(nama_serviceawal).ToString = "Running" Then
                        StartService()
                    Else
                        BBStartService.Enabled = False
                        BBStopService.Enabled = True
                        STTimer.Caption = "Gammu Aktif."
                        timer_status = True
                        SchedulerSMS.Enabled = True
                        has_start_service = 1
                    End If
                Catch ex As Exception
                    connection_problem = True
                    DashboardToolStripMenuItem.Visible = False
                    FormSettingGammu.ShowInTaskbar = True
                    FormSettingGammu.ShowDialog()
                End Try
            End If
        End If
        
        apply_nama()
        apply_del_rep()
        apply_send_after()

        NotifyIconSMS.ShowBalloonTip(2000, "Information", "Aplikasi SMS sedang berjalan." + Environment.NewLine + "Klik disini untuk opsi lebih lanjut.", ToolTipIcon.Info)

    End Sub

    Private Sub SchedulerSMS_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchedulerSMS.Tick
        'respon_sms()
        Try
            If Not Me.BGWResponSMS.IsBusy Then
                Me.BGWResponSMS.RunWorkerAsync()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub respon_sms()
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_eksekusi, query_parsing, log_in As String
        Dim koneksi2 As MySqlConnection
        Dim host, username, password As String
        Dim list_db As MySqlDataAdapter
        Dim dset_db As DataSet
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim command As MySqlCommand
        Dim command2 As MySqlCommand
        Dim command3 As MySqlCommand
        Dim reader, reader2 As MySqlDataReader
        Dim balas_spam, sms_in, dbx, query_ID, jml_eksekusi, pengirim, id_eksekusi, jenis_operasi, output_sms, output_field, sms_out, key_op As String
        Dim n, m As Integer
        Dim words As String()
        Dim word, conn As String
        Dim ID As Integer
        Dim is_broadcastx As String = ""
        Dim broadcast_grupx As String = ""
        'pilah sender ID
        Dim textx As String
        Dim id_operasix As Integer
        'end pilah

        id_eksekusi = ""

        'Try
        koneksi.Open()
        Dim query As String
        query = "SELECT COUNT(*) FROM tb_eksekusi_respon"
        command = koneksi.CreateCommand()
        command.CommandText = query
        reader = command.ExecuteReader()
        reader.Read()
        jml_eksekusi = reader.GetValue(0).ToString
        koneksi.Close()

        Dim char_pemisah, char_pemisah2, is_lokal As String
        char_pemisah = ""
        char_pemisah2 = ""
        is_lokal = ""

        'ambil pemisah
        koneksi.Open()
        query_ID = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_ID
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '

        'ambil balas_spam
        koneksi.Open()
        query_ID = "SELECT balas_spam FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_ID
        reader = command.ExecuteReader()
        reader.Read()
        balas_spam = reader.GetValue(0).ToString
        koneksi.Close()
        '

        koneksi.Open()
        If jml_eksekusi <> "0" Then
            'yang gagal / spam
            query_eksekusi = "SELECT tb_eksekusi_respon.id_eksekusi,inbox.SenderNumber,tb_eksekusi_respon.query_value,tb_eksekusi_respon.output_sms FROM inbox, tb_eksekusi_respon WHERE tb_eksekusi_respon.id_sms = inbox.ID AND output_sms='Error : SMS SPAM'"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count
            For i = 0 To n - 1
                id_eksekusi = dset_eksekusi.Tables("data").Rows(i)(0).ToString()

                If balas_spam = True Then
                    pengirim = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                    output_sms = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                    fungsi_send_sms(output_sms, pengirim, "1")
                End If

                command2 = koneksi.CreateCommand
                query_parsing = "DELETE FROM tb_eksekusi_respon WHERE id_eksekusi='" & id_eksekusi & "'"
                command2.CommandText = query_parsing
                command2.ExecuteNonQuery()
            Next i
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()

            'yang gagal
            query_eksekusi = "SELECT tb_eksekusi_respon.id_eksekusi,inbox.SenderNumber,tb_eksekusi_respon.query_value,tb_eksekusi_respon.output_sms FROM inbox, tb_eksekusi_respon WHERE tb_eksekusi_respon.id_sms = inbox.ID AND query_value='error'"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count
            For i = 0 To n - 1
                id_eksekusi = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                pengirim = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                output_sms = dset_eksekusi.Tables("data").Rows(i)(3).ToString()

                fungsi_send_sms(output_sms, pengirim, "1")

                command2 = koneksi.CreateCommand
                query_parsing = "DELETE FROM tb_eksekusi_respon WHERE id_eksekusi='" & id_eksekusi & "'"
                command2.CommandText = query_parsing
                command2.ExecuteNonQuery()
            Next i
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()

            'utamakan operasi ke reply data
            query_eksekusi = "SELECT tb_eksekusi_respon.id_eksekusi,inbox.SenderNumber,tb_operasi.id_jenis_operasi,tb_eksekusi_respon.query_value,tb_host.host,tb_host.username,tb_host.password,tb_eksekusi_respon.output_sms,tb_eksekusi_respon.output_field,tb_eksekusi_respon.key_op,tb_host.db,tb_eksekusi_respon.id_operasi,inbox.TextDecoded,tb_eksekusi_respon.is_broadcast,tb_eksekusi_respon.broadcast_grup FROM inbox, tb_eksekusi_respon, tb_operasi, tb_host WHERE tb_eksekusi_respon.id_operasi = tb_operasi.id_operasi AND tb_operasi.id_host = tb_host.id_host AND tb_eksekusi_respon.id_sms = inbox.ID AND tb_eksekusi_respon.op_status='1'"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count

            For i = 0 To n - 1
                id_eksekusi = dset_eksekusi.Tables("data").Rows(i)(0).ToString()

                pengirim = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                
                'operasi
                jenis_operasi = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                query_parsing = dset_eksekusi.Tables("data").Rows(i)(3).ToString()
                host = dset_eksekusi.Tables("data").Rows(i)(4).ToString()
                username = dset_eksekusi.Tables("data").Rows(i)(5).ToString()
                password = dset_eksekusi.Tables("data").Rows(i)(6).ToString()
                output_sms = dset_eksekusi.Tables("data").Rows(i)(7).ToString()
                output_field = dset_eksekusi.Tables("data").Rows(i)(8).ToString()
                key_op = dset_eksekusi.Tables("data").Rows(i)(9).ToString()
                dbx = dset_eksekusi.Tables("data").Rows(i)(10).ToString()
                id_operasix = dset_eksekusi.Tables("data").Rows(i)(11).ToString()
                textx = dset_eksekusi.Tables("data").Rows(i)(12).ToString()

                'operasi cast / sebar ke yang lain
                cast_operasi(pengirim.ToString, id_operasix, textx.ToString)

                'search in database used
                conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";Database=" & dbx
                koneksi2 = New MySqlConnection(conn)
                'try
                Try
                    koneksi2.Open()
                    If query_parsing = "error" Then
                        sms_out = key_op & char_pemisah & output_sms
                        log_in = output_sms
                    Else
                        If jenis_operasi = "4" Then
                            words = output_field.Split(New Char() {","c})
                            list_db = New MySqlDataAdapter(query_parsing, koneksi2)
                            dset_db = New DataSet
                            list_db.Fill(dset_db, "data")

                            If dset_db.Tables("data").Rows.Count = 0 Then
                                sms_out = key_op & char_pemisah & "Error : Data tidak ditemukan"
                                log_in = "Error : Data tidak ditemukan"
                            Else
                                sms_out = key_op & "" & char_pemisah
                                log_in = ""
                                For j = 0 To dset_db.Tables("data").Rows.Count - 1
                                    m = 0
                                    For Each word In words
                                        If m = 0 Then
                                            sms_out = sms_out & word & "{:c:}" & dset_db.Tables("data").Rows(j)(m).ToString()
                                            log_in = log_in & word & "{:c:}" & dset_db.Tables("data").Rows(j)(m).ToString()
                                        Else
                                            sms_out = sms_out & char_pemisah & word & "{:c:}" & dset_db.Tables("data").Rows(j)(m).ToString()
                                            log_in = log_in & char_pemisah & word & "{:c:}" & dset_db.Tables("data").Rows(j)(m).ToString()
                                        End If
                                        m = m + 1
                                    Next
                                    If j = (dset_db.Tables("data").Rows.Count - 1) Then
                                        sms_out = sms_out
                                        log_in = log_in
                                    Else
                                        sms_out = sms_out & "{:r:}"
                                        log_in = log_in & "{:r:}"
                                    End If
                                Next
                            End If
                            list_db.Dispose()
                            dset_db.Dispose()
                        ElseIf jenis_operasi = "3" Or jenis_operasi = "2" Or jenis_operasi = "1" Then ' insert update delete
                            m = 0
                            Try
                                command3 = koneksi2.CreateCommand
                                command3.CommandText = query_parsing
                                command3.ExecuteNonQuery()
                            Catch ex As Exception
                                m = 1
                            End Try
                            If m = 0 Then
                                sms_out = key_op & char_pemisah & "Sukses : Perintah sukses dieksekusi !"
                                log_in = "Sukses : Perintah sukses dieksekusi !"
                            Else
                                sms_out = key_op & char_pemisah & "Error : Perintah gagal !"
                                log_in = "Error : Perintah gagal !"
                            End If
                        Else 'fungsi dan prosedur
                            If output_sms = "" Then
                                m = 0
                                Try
                                    command3 = koneksi2.CreateCommand
                                    command3.CommandText = query_parsing
                                    command3.ExecuteNonQuery()
                                Catch ex As Exception
                                    m = 1
                                End Try
                                If m = 0 Then
                                    sms_out = key_op & char_pemisah & "Sukses : Perintah sukses dieksekusi !"
                                    log_in = "Sukses : Perintah sukses dieksekusi !"
                                Else
                                    sms_out = key_op & char_pemisah & "Error : Perintah gagal !"
                                    log_in = "Error : Perintah gagal !"
                                End If
                            Else
                                sms_out = key_op & "" & char_pemisah
                                log_in = ""
                                words = output_sms.Split(New Char() {","c})
                                list_db = New MySqlDataAdapter(query_parsing, koneksi2)
                                dset_db = New DataSet
                                list_db.Fill(dset_db, "data")

                                If dset_db.Tables("data").Rows.Count = 0 Then
                                    sms_out = key_op & char_pemisah & "Error : Data tidak ditemukan"
                                    log_in = "Error : Data tidak ditemukan"
                                Else
                                    m = 0
                                    For Each word In words
                                        If dset_db.Tables("data").Rows(0)(m).ToString = "" Then
                                            sms_out = String.Format("{0}{1} = {2}{3}", sms_out, word, "null", vbCrLf)
                                            log_in = String.Format("{0}{1} = {2}{3}", log_in, word, "null", vbCrLf)
                                        Else
                                            sms_out = String.Format("{0}{1} = {2}{3}", sms_out, word, dset_db.Tables("data").Rows(0)(m), vbCrLf)
                                            log_in = String.Format("{0}{1} = {2}{3}", log_in, word, dset_db.Tables("data").Rows(0)(m), vbCrLf)
                                        End If
                                        m = m + 1
                                    Next
                                End If
                                list_db.Dispose()
                                dset_db.Dispose()
                            End If
                        End If
                    End If
                    koneksi2.Close()
                    koneksi2.Dispose()
                Catch ex As Exception
                    sms_out = key_op & char_pemisah & "Error : Server tidak dapat diakses."
                    log_in = "Error : Server tidak dapat diakses."
                End Try
                

                command2 = koneksi.CreateCommand
                'in dan in data
                query = "INSERT INTO tb_operasi_in(id_operasi,no_hp,message_in) VALUE ('" & id_operasix & "','" & pengirim & "','" & textx & "')"
                command2.CommandText = query
                command2.ExecuteNonQuery()
                'in data
                'get id_op_in
                query_ID = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                command = koneksi.CreateCommand()
                command.CommandText = query_ID
                reader2 = command.ExecuteReader()
                reader2.Read()
                ID = reader2.GetValue(0).ToString
                reader2.Close()
                'in data
                query = "INSERT INTO tb_operasi_in_data(id_op_in,format,sent_data) VALUE ('" & ID & "','0','" & log_in & "')"
                command2.CommandText = query
                command2.ExecuteNonQuery()
                'end in dan in data

                fungsi_send_sms(sms_out, pengirim, "1")

                query_parsing = "DELETE FROM tb_eksekusi_respon WHERE id_eksekusi='" & id_eksekusi & "'"
                command2.CommandText = query_parsing
                command2.ExecuteNonQuery()
                koneksi2.Close()
                koneksi2.Dispose()
            Next i
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()

            'yang sukses
            query_eksekusi = "SELECT tb_eksekusi_respon.id_eksekusi,inbox.SenderNumber,tb_operasi.id_jenis_operasi,tb_eksekusi_respon.query_value,tb_host.host,tb_host.username,tb_host.password,tb_eksekusi_respon.output_sms,tb_eksekusi_respon.output_field,inbox.TextDecoded,tb_host.db,IFNULL(tb_eksekusi_respon.id_operasi,0) as id_operasi,tb_eksekusi_respon.is_broadcast,tb_eksekusi_respon.broadcast_grup "
            query_eksekusi += " FROM tb_eksekusi_respon "
            query_eksekusi += " LEFT JOIN inbox ON tb_eksekusi_respon.id_sms = inbox.ID "
            query_eksekusi += " LEFT JOIN tb_operasi ON tb_eksekusi_respon.id_operasi = tb_operasi.id_operasi "
            query_eksekusi += " LEFT JOIN tb_host ON tb_operasi.id_host = tb_host.id_host "
            query_eksekusi += " WHERE op_status='0'"

            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count

            For i = 0 To n - 1
                id_eksekusi = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                pengirim = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                
                jenis_operasi = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                query_parsing = dset_eksekusi.Tables("data").Rows(i)(3).ToString()
                host = dset_eksekusi.Tables("data").Rows(i)(4).ToString()
                username = dset_eksekusi.Tables("data").Rows(i)(5).ToString()
                password = dset_eksekusi.Tables("data").Rows(i)(6).ToString()
                output_sms = dset_eksekusi.Tables("data").Rows(i)(7).ToString()
                output_field = dset_eksekusi.Tables("data").Rows(i)(8).ToString()
                sms_in = dset_eksekusi.Tables("data").Rows(i)(9).ToString()
                dbx = dset_eksekusi.Tables("data").Rows(i)(10).ToString()
                id_operasix = dset_eksekusi.Tables("data").Rows(i)(11).ToString()

                is_broadcastx = dset_eksekusi.Tables("data").Rows(i)(12).ToString()
                broadcast_grupx = dset_eksekusi.Tables("data").Rows(i)(13).ToString()

                '==== proses ====
                'local
                conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";database=" & dbx
                koneksi2 = New MySqlConnection(conn)
                'koneksi local
                Try
                    koneksi2.Open()
                    If query_parsing = "error" Then
                        sms_out = output_sms
                    Else
                        'update 0.0.1
                        'is broadcast = 2
                        If is_broadcastx = "2" Then
                             sms_out = output_sms
                        Else
                            If jenis_operasi = "4" Then
                                words = output_sms.Split(New Char() {","c})
                                list_db = New MySqlDataAdapter(query_parsing, koneksi2)
                                dset_db = New DataSet
                                list_db.Fill(dset_db, "data")
                                If dset_db.Tables("data").Rows.Count = 0 Then
                                    sms_out = "Maaf, data tidak ditemukan."
                                Else
                                    sms_out = ""
                                    For j = 0 To dset_db.Tables("data").Rows.Count - 1
                                        m = 0
                                        For Each word In words
                                            sms_out = String.Format("{0}{1} {2}{3}", sms_out, word, dset_db.Tables("data").Rows(j)(m), vbCrLf)
                                            m = m + 1
                                        Next
                                        If j = dset_db.Tables("data").Rows.Count - 1 Then
                                            sms_out = sms_out
                                        Else
                                            sms_out = sms_out & vbCrLf
                                        End If
                                    Next
                                End If
                                list_db.Dispose()
                                dset_db.Dispose()
                            ElseIf jenis_operasi = "3" Or jenis_operasi = "2" Or jenis_operasi = "1" Then ' insert update delete
                                m = 0
                                Try
                                    command3 = koneksi2.CreateCommand
                                    command3.CommandText = query_parsing
                                    command3.ExecuteNonQuery()
                                Catch ex As Exception
                                    m = 1
                                End Try
                                If m = 0 Then
                                    sms_out = "Permintaan selesai diproses."
                                Else
                                    sms_out = "Maaf, permintaan tidak dapat diproses."
                                End If
                            Else 'fungsi dan prosedur
                                If output_sms = "" Then
                                    m = 0
                                    Try
                                        command3 = koneksi2.CreateCommand
                                        command3.CommandText = query_parsing
                                        command3.ExecuteNonQuery()
                                    Catch ex As Exception
                                        m = 1
                                    End Try
                                    If m = 0 Then
                                        sms_out = "Permintaan selesai diproses."
                                    Else
                                        sms_out = "Maaf, permintaan tidak dapat diproses."
                                    End If
                                Else
                                    words = output_sms.Split(New Char() {","c})
                                    list_db = New MySqlDataAdapter(query_parsing, koneksi2)
                                    dset_db = New DataSet
                                    list_db.Fill(dset_db, "data")

                                    If dset_db.Tables("data").Rows.Count = 0 Then
                                        sms_out = "Maaf, data tidak ditemukan."
                                    Else
                                        m = 0
                                        sms_out = ""
                                        For Each word In words
                                            If dset_db.Tables("data").Rows(0)(m).ToString = "" Then
                                                'sms_out = String.Format("{0}{1} = {2}{3}", sms_out, word, "null", vbCrLf)
                                                sms_out = String.Format("{0}{1}{2}", sms_out, "-", vbCrLf)
                                            Else
                                                'sms_out = String.Format("{0}{1} = {2}{3}", sms_out, word, dset_db.Tables("data").Rows(0)(m), vbCrLf)
                                                sms_out = String.Format("{0}{1}{2}", sms_out, dset_db.Tables("data").Rows(0)(m), vbCrLf)
                                            End If
                                            m = m + 1
                                        Next
                                    End If
                                    list_db.Dispose()
                                    dset_db.Dispose()
                                End If
                            End If
                        End If
                    End If
                    koneksi2.Close()
                    koneksi2.Dispose()
                Catch ex As Exception
                    sms_out = "Maaf, data saat ini tidak dapat diakses."
                End Try
                
                'operasi cast
                cast_operasi(pengirim.ToString, id_operasix, sms_in.ToString)

                If is_broadcastx = "1" Then
                    fungsi_broadcast_sms(sms_out, pengirim, "1", broadcast_grupx)
                ElseIf is_broadcastx = "2" Then
                    fungsi_broadcast_sms(sms_out, pengirim, "1", broadcast_grupx)
                Else
                    fungsi_send_sms(sms_out, pengirim, "1")
                End If

                command2 = koneksi.CreateCommand
                query_parsing = "DELETE FROM tb_eksekusi_respon WHERE id_eksekusi='" & id_eksekusi & "'"
                command2.CommandText = query_parsing
                command2.ExecuteNonQuery()
            Next i
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()
        End If
        koneksi.Close()
        'Catch ex As Exception
        'StartService()
        'MsgBox("Fatal error : " & ex.ToString)
        'End Try
        koneksi.Dispose()
    End Sub
    Public Function SplitString(ByVal TheString As String, ByVal StringLen As Integer) As String()
        Dim ArrCount As Integer  'as it is declared locally, it will automatically reset to 0 when this is called again
        Dim I As Long  'we are going to use it.. so declare it (with local scope to avoid breaking other code)
        Dim TempArray() As String
        ReDim TempArray((Len(TheString) - 1) \ StringLen)
        For I = 1 To Len(TheString) Step StringLen
            TempArray(ArrCount) = Mid$(TheString, I, StringLen)
            ArrCount = ArrCount + 1
        Next
        SplitString = TempArray   'actually return the value
    End Function

    Private Sub BBContact_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBContact.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormEditContact.MdiParent = Me
            FormEditContact.Show()
            FormEditContact.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormEditContact.WindowState = FormWindowState.Maximized
        FormEditContact.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBUserManage_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBUserManage.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormUser.MdiParent = Me
            FormUser.Show()
            FormUser.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormUser.WindowState = FormWindowState.Maximized
        FormUser.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBOperasiEks_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            FormOperasi.MdiParent = Me
            FormOperasi.Show()
            FormOperasi.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormOperasi.WindowState = FormWindowState.Maximized
        FormOperasi.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub OperasiTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormPanelOperasi.refresh_log()
    End Sub

    Private Sub BBStartService_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBStartService.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            StartService()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            XtraMessageBox.Show("Service tidak ditemukan!", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BBStopService_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBStopService.ItemClick
        Dim result As DialogResult
        Me.Cursor = Cursors.WaitCursor
        result = XtraMessageBox.Show("Anda ingin mematikan service?" & Environment.NewLine & "Auto respon tidak akan berjalan ketika service dimatikan!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            Try
                '
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\start.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\stop.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\installservice.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\uninstallservice.bat")
                '
                StopService()
                has_start_service = 0
            Catch ex As Exception
                XtraMessageBox.Show("Service sedang bekerja !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBManageOP_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBManageOP.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormKeyword.MdiParent = Me
            FormKeyword.Show()
            FormKeyword.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormKeyword.WindowState = FormWindowState.Maximized
        FormKeyword.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBLogin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBLogin.ItemClick
        FormLogin.ShowDialog()
    End Sub

    Private Sub BBLogout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBLogout.ItemClick
        Dim result As DialogResult
        result = XtraMessageBox.Show("Anda yakin ingin keluar?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            For Each child As Form In Me.MdiChildren
                child.Close()
            Next child
            is_login_menu = False
            Me.BBLogin.Enabled = True
            Me.BBLogout.Enabled = False
            tampilkan_menu()
        End If
    End Sub
    Sub tampilkan_menu()
        If is_login_menu = True Then
            RPGManajemenUser.Visible = True
            RPOperasiAll.Visible = True
        Else
            RPGManajemenUser.Visible = False
            RPOperasiAll.Visible = False
        End If
    End Sub

    Private Sub BBServerConfig_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBServerConfig.ItemClick
        FormServer.ShowDialog()
    End Sub

    Private Sub BBCharSpec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBCharSpec.ItemClick
        FormPemisah.ShowDialog()
    End Sub

    Private Sub BBContactGroup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBContactGroup.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormGrupKontak.MdiParent = Me
            FormGrupKontak.Show()
            FormGrupKontak.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormGrupKontak.WindowState = FormWindowState.Maximized
        FormGrupKontak.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BBManageOperasiPartner_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBManageOperasiPartner.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormManageOperasiPartner.MdiParent = Me
            FormManageOperasiPartner.Show()
            FormManageOperasiPartner.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormManageOperasiPartner.WindowState = FormWindowState.Maximized
        FormManageOperasiPartner.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBHost_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBHost.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormSettingHost.MdiParent = Me
            FormSettingHost.Show()
            FormSettingHost.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormSettingHost.WindowState = FormWindowState.Maximized
        FormSettingHost.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BBHeader_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBHeader.ItemClick
        FormNamaAplikasi.ShowDialog()
    End Sub

    Private Sub BBGammuConfig_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBGammuConfig.ItemClick
        'single modem
        'FormSettingGammu.ShowDialog()
        Me.Cursor = Cursors.WaitCursor
        Try
            FormGammu.MdiParent = Me
            FormGammu.Show()
            FormGammu.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormGammu.WindowState = FormWindowState.Maximized
        FormGammu.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub TimerGeneral_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGeneral.Tick
        Me.STDate.Caption = Date.Now.ToString("MMMM d, yyyy  HH:mm:ss")
        TimerGeneral.Enabled = False
        cek_sms_kosongkan()
        TimerGeneral.Enabled = True

        If has_start_service = 1 Then
            If is_use_gammu = "1" Then
                Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
                Dim query_eksekusi, id_modem, nama_modem As String
                Dim list_eksekusi As MySqlDataAdapter
                Dim dset_eksekusi As DataSet
                Dim n As Integer
                'service test
                query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                id_modem = dset_eksekusi.Tables("data").Rows(0)(0).ToString()
                nama_modem = dset_eksekusi.Tables("data").Rows(0)(1).ToString()
                Dim nama_serviceawal = "GammuSMSD" & id_modem
                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()
                koneksi.Dispose()
                'end ambil testing service

                If GetServiceStatus(nama_serviceawal).ToString = "Stopped" Then
                    TimerGeneral.Enabled = False
                    'recreate_log(nama_logx, dir_gammux & "\bin")
                    TimerGeneral.Enabled = True
                End If
            Else
                'jika ada
                TimerGeneral.Enabled = True
            End If
        Else
            'jika belum start service
            TimerGeneral.Enabled = False
        End If
    End Sub
    Private Sub RibbonForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        has_start_service = 0
        TimerGeneral.Enabled = False
    End Sub

    Private Sub BBServerPartner_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBServerPartner.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormSettingHostPartner.MdiParent = Me
            FormSettingHostPartner.Show()
            FormSettingHostPartner.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormSettingHostPartner.WindowState = FormWindowState.Maximized
        FormSettingHostPartner.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBSentMonitor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBSentMonitor.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormMonitorSent.MdiParent = Me
            FormMonitorSent.Show()
            FormMonitorSent.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormMonitorSent.WindowState = FormWindowState.Maximized
        FormMonitorSent.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBRevievedMonitor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBRevievedMonitor.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormMonitorRecieved.MdiParent = Me
            FormMonitorRecieved.Show()
            FormMonitorRecieved.WindowState = FormWindowState.Maximized
        Catch ex As Exception
        End Try
        FormMonitorRecieved.WindowState = FormWindowState.Maximized
        FormMonitorRecieved.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BGWResponSMS_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BGWResponSMS.DoWork
        respon_sms()
    End Sub

    Private Sub BBAbout_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBAbout.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormAbout.ShowDialog()
        Catch ex As Exception
        End Try
        FormAbout.Focus()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBImportExport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBImportExport.ItemClick
        FormImportExportExcel.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        NotifyIconSMS.Visible = False

        End
    End Sub

    Private Sub DashboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DashboardToolStripMenuItem.Click
        Visible = True
        Opacity = 100

        Show()
        WindowState = FormWindowState.Maximized
        BringToFront()
        Focus()
    End Sub

    Private Sub BBService_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBService.ItemClick
        FormServiceSetup.ShowDialog()
    End Sub

    Private Sub BBScheduler_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBScheduler.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            FormScheduler.MdiParent = Me
            FormScheduler.Show()
            FormScheduler.WindowState = FormWindowState.Maximized
            FormScheduler.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BBBroadcast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            FormScheduler.MdiParent = Me
            FormScheduler.Show()
            FormScheduler.WindowState = FormWindowState.Maximized
            FormScheduler.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class