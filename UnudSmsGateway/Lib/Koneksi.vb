Imports System.Xml
Imports System.Text
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports MySql.Data.MySqlClient
Imports DevExpress.LookAndFeel
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraPrinting

Module Database
    Public app_host As String
    Public app_username As String
    Public app_password As String
    Public app_database As String
    Public port_devx As String
    Public conn_devx As String
    Public dir_gammux As String
    Public pinx As String
    Public nama_logx As String
    Public delivery_report As String = "default"
    Public kirim_setelah As String = "0"

    Public connection_problem As String

    Public title_print As String
    Public Sub RunAtStartup(ByVal ApplicationName As String, ByVal ApplicationPath As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        With CU
            .CreateSubKey(ApplicationName)
            .SetValue(ApplicationName, """" & ApplicationPath.ToString & """")
        End With
    End Sub

    Public Sub RemoveValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            .DeleteValue(ApplicationName, False)
        End With
    End Sub

    Public Function CheckValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            Return .GetValue(ApplicationName)
        End With
    End Function
    Sub apply_skin()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.OfficeSkins.Register()
        UserLookAndFeel.Default.UseWindowsXPTheme = False
        UserLookAndFeel.Default.SkinName = "Office 2010 Blue"
    End Sub
    Sub apply_nama()
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim query_eksekusi, pemisah, deskripsi As String
        Try
            koneksi.Open()

            query_eksekusi = "SELECT nama_app_sms,deskripsi_sms FROM tb_option LIMIT 1"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            If dset_eksekusi.Tables("data").Rows.Count = 0 Then
                pemisah = "Udayana SMS"
                deskripsi = "Copyright : Divinkom @2013"
            Else
                pemisah = dset_eksekusi.Tables("data").Rows(0)(0).ToString()
                deskripsi = dset_eksekusi.Tables("data").Rows(0)(1).ToString()
            End If
            koneksi.Close()
            koneksi.Dispose()
            RibbonForm.Text = pemisah.ToString
            FormAbout.LabelNama.Text = pemisah.ToString
            FormAbout.labelDeskripsi.Text = deskripsi.ToString
        Catch ex As Exception
            RibbonForm.Text = "Udayana SMS"
            FormAbout.LabelNama.Text = "Udayana SMS"
            FormAbout.labelDeskripsi.Text = "Copyright : Divinkom @2013"
        End Try
        RibbonForm.TimerGeneral.Enabled = True
    End Sub
    Sub apply_del_rep()
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim query_eksekusi As String
        Try
            koneksi.Open()

            query_eksekusi = "SELECT delivery_report FROM tb_option LIMIT 1"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")

            delivery_report = dset_eksekusi.Tables("data").Rows(0)(0).ToString()

            koneksi.Close()
            koneksi.Dispose()
        Catch ex As Exception
            delivery_report = "default"
        End Try
        RibbonForm.TimerGeneral.Enabled = True
    End Sub
    Sub apply_send_after()
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim query_eksekusi As String
        Try
            koneksi.Open()

            query_eksekusi = "SELECT send_after FROM tb_option LIMIT 1"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")

            kirim_setelah = dset_eksekusi.Tables("data").Rows(0)(0).ToString()

            koneksi.Close()
            koneksi.Dispose()
        Catch ex As Exception
            kirim_setelah = "0"
        End Try
        RibbonForm.TimerGeneral.Enabled = True
    End Sub
    Sub kosongkan_respon()
        Dim queryx As String = "DELETE FROM tb_eksekusi_respon"
        execute_non_query(queryx, True, "", "", "", "")
    End Sub
    Function BackupDatabase(ByVal strFilePath As String) As Boolean
        If File.Exists(My.Application.Info.DirectoryPath.ToString & "\mysqldump.exe") Then
            Dim proses = Process.Start(My.Application.Info.DirectoryPath.ToString & "\mysqldump.exe ", " -u " & app_username & " --password=" & app_password & " -h" & app_host & " " & app_database & " -r """ & strFilePath & "\backup_operasi" & Date.Now.ToString("MMMM_d_yyyy-HH_mm_ss") & ".sql""")
            proses.WaitForExit()
        End If
    End Function
    Public Function sender_default_id()
        Dim query As String = String.Format("SELECT nama_modem FROM tb_modem WHERE is_default='1'")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Dim sender_default As String = data.Rows(0)("nama_modem").ToString
        Return sender_default
    End Function
    Public Function nomor_default()
        Dim query As String = String.Format("SELECT nomor FROM tb_modem WHERE is_default='1'")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Dim nomor As String = data.Rows(0)("nomor").ToString
        Return nomor
    End Function
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
    Public Sub fungsi_broadcast_sms(ByVal sms_out As String, ByVal no_hp As String, ByVal sender_wise As String, ByVal grup_name As String)
        Dim query_cek As String = "SELECT * FROM tb_grup_kontak WHERE grup_kontak='" & grup_name & "'"
        Dim data_cek As DataTable = execute_query(query_cek, -1, True, "", "", "", "")

        Dim query As String = "SELECT kontak.nama_kontak,kontak.no_hp FROM tb_grup_kontak_member g_kontak_m"
        query += " INNER JOIN tb_grup_kontak g_kontak ON g_kontak.id_grup_kontak=g_kontak_m.id_grup_kontak"
        query += " INNER JOIN tb_kontak kontak ON g_kontak_m.id_kontak=kontak.id_kontak"
        query += " WHERE g_kontak.grup_kontak='" & grup_name & "'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        If data.Rows.Count > 0 Then
            For i As Integer = 0 To data.Rows.Count - 1
                fungsi_send_sms(sms_out, data.Rows(0)("no_hp").ToString, sender_wise)
            Next
            'send broadcast success
            fungsi_send_sms("Broadcast sukses.", no_hp, sender_wise)
        Else
            'send there is no grup member
            fungsi_send_sms("Tidak ada yang terdaftar dalam grup.", no_hp, sender_wise)
        End If
    End Sub
    Public Sub fungsi_send_sms(ByVal sms_out As String, ByVal no_hp As String, ByVal sender_wise As String)
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_parsing As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query, query_ID As String
        Dim jml_sms
        Dim udh As String
        Dim ID As Integer
        Dim StringArray() As String
        Dim sendernya As String

        If sender_wise = "1" Then
            sendernya = pilih_modem(no_hp)
        Else
            sendernya = sender_default_id()
        End If


        koneksi.Open()
        jml_sms = Math.Ceiling(sms_out.Count / 153)
        command = koneksi.CreateCommand
        If jml_sms = 1 Then
            query_parsing = "INSERT INTO outbox(DeliveryReport,TextDecoded,DestinationNumber,CreatorID,SenderID) VALUE ('" & delivery_report & "','" & sms_out & "','" & no_hp & "','1','" & sendernya & "')"
            command.CommandText = query_parsing
            command.ExecuteNonQuery()
        Else
            query_ID = "SHOW TABLE STATUS LIKE 'outbox'"
            command = koneksi.CreateCommand()
            command.CommandText = query_ID
            reader = command.ExecuteReader()
            reader.Read()
            ID = reader.GetValue(10).ToString
            koneksi.Close()
            koneksi.Open()
            command = koneksi.CreateCommand()
            StringArray = SplitString(sms_out, 153)
            For k = 1 To jml_sms
                udh = String.Format("050003A7{0:00}{1:00}", jml_sms, k)
                If k = 1 Then
                    query = "INSERT INTO outbox (DeliveryReport,DestinationNumber, UDH, TextDecoded, ID, MultiPart, CreatorID, SenderID) VALUE ('" & delivery_report & "','" & no_hp & "','" & udh & "','" & StringArray(k - 1) & "','" & ID & "','true','1','" & sendernya & "')"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                Else
                    query = "INSERT INTO outbox_multipart (UDH, TextDecoded, ID, SequencePosition) VALUE ('" & udh & "','" & StringArray(k - 1) & "','" & ID & "','" & k & "')"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                End If
            Next k
        End If
        koneksi.Close()
        koneksi.Dispose()
    End Sub
    Sub cek_sms_kosongkan()
        Dim queryx As String
        Dim query As String = String.Format("SELECT sms_x_hari_kosongkan,dir_backup FROM tb_option")
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
        Dim jml_hari As Integer
        Dim dir_backup As String

        Dim cek_layak As Integer = 0

        If data.Rows.Count = 0 Then
            jml_hari = 0
            dir_backup = ""
        Else
            jml_hari = data.Rows(0)("sms_x_hari_kosongkan")
            dir_backup = data.Rows(0)("dir_backup").ToString
        End If

        If Not jml_hari = 0 Then
            query = "SELECT ID FROM outbox WHERE DATEDIFF(SYSDATE(),SendingDateTime)>=" & jml_hari
            data = execute_query(query, -1, True, "", "", "", "")
            cek_layak = cek_layak + data.Rows.Count
            query = "SELECT ID FROM inbox WHERE DATEDIFF(SYSDATE(),ReceivingDateTime)>=" & jml_hari
            data = execute_query(query, -1, True, "", "", "", "")
            cek_layak = cek_layak + data.Rows.Count
            query = "SELECT ID FROM sentitems WHERE DATEDIFF(SYSDATE(),SendingDateTime)>=" & jml_hari
            data = execute_query(query, -1, True, "", "", "", "")
            cek_layak = cek_layak + data.Rows.Count

            If cek_layak > 0 Then
                'backup
                Try
                    BackupDatabase(dir_backup)
                Catch ex As Exception

                End Try
                'kosongkan outbox
                query = "SELECT ID,DATEDIFF(SYSDATE(),SendingDateTime) AS beda FROM outbox"
                data = execute_query(query, -1, True, "", "", "", "")
                For i As Integer = 0 To data.Rows.Count - 1
                    If Integer.Parse(data.Rows(i)("beda")) >= jml_hari Then
                        queryx = "DELETE FROM outbox_multipart WHERE ID='" & data.Rows(i)("ID") & "'"
                        execute_non_query(queryx, True, "", "", "", "")
                        queryx = "DELETE FROM outbox WHERE ID='" & data.Rows(i)("ID") & "'"
                        execute_non_query(queryx, True, "", "", "", "")
                    End If
                Next
                'kosongkan inbox
                query = "SELECT ID,DATEDIFF(SYSDATE(),ReceivingDateTime) AS beda FROM inbox"
                data = execute_query(query, -1, True, "", "", "", "")
                For i As Integer = 0 To data.Rows.Count - 1
                    If Integer.Parse(data.Rows(i)("beda")) >= jml_hari Then
                        queryx = "DELETE FROM inbox WHERE ID='" & data.Rows(i)("ID") & "'"
                        execute_non_query(queryx, True, "", "", "", "")
                    End If
                Next
                'kosongkan sentitem
                query = "SELECT ID,DATEDIFF(SYSDATE(),SendingDateTime) AS beda FROM sentitems"
                data = execute_query(query, -1, True, "", "", "", "")
                For i As Integer = 0 To data.Rows.Count - 1
                    If Integer.Parse(data.Rows(i)("beda")) >= jml_hari Then
                        queryx = "DELETE FROM sentitems WHERE ID='" & data.Rows(i)("ID") & "'"
                        execute_non_query(queryx, True, "", "", "", "")
                    End If
                Next
            End If
        End If
    End Sub
    Public Function isPhoneNumber(ByVal phoneNumber As String)
        Dim pattern As String = "\+\d+"
        Dim test As New RegularExpressions.Regex(pattern)
        Dim valid As Boolean = False
        valid = test.IsMatch(phoneNumber, 0)
        Return valid
    End Function

    Public Function isValue(ByVal value As String)
        Dim valid As Boolean = True
        If value = "" Then
            valid = False
        End If
        Return valid
    End Function
    Public Function isNotNumberModem(ByVal value As String)
        Dim valid As Boolean = True
        If value = "*" Or value = "1" Or value = "2" Or value = "3" Or value = "4" Or value = "5" Or value = "6" Or value = "7" Or value = "8" Or value = "9" Or value = "0" Then
            valid = False
        End If
        Return valid
    End Function
    Public Function isGridFilled(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim valid As Boolean = True

        For i As Integer = 0 To grid.RowCount - 1
            For j As Integer = 0 To 1
                If grid.GetRowCellValue(i, grid.Columns.Item(j)).ToString = "" Then
                    valid = False
                End If
            Next
        Next

        Return valid
    End Function
    Function execute_non_query(ByVal command_text As String, ByVal is_local As Boolean, ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String)
        If is_local = True Then
            host = app_host
            username = app_username
            password = app_password
            database = app_database
        End If

        Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Database={3};Convert Zero Datetime=True", host, username, password, database)
        Dim connection As MySqlConnection = New MySqlConnection(connection_string)
        connection.Open()
        Dim command As MySqlCommand = connection.CreateCommand()
        command.CommandText = command_text
        command.ExecuteNonQuery()
        command.Dispose()
        connection.Close()
        connection.Dispose()

        Return True
    End Function

    Function execute_query(ByVal command_text As String, ByVal col_index As Integer, ByVal is_local As Boolean, ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String)
        If is_local = True Then
            host = app_host
            username = app_username
            password = app_password
            database = app_database
        End If

        Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Database={3};Convert Zero Datetime=True", host, username, password, database)
        If col_index < 0 Then 'return data table
            Dim connection As New MySqlConnection(connection_string)
            connection.Open()
            Dim data As New DataTable
            Dim adapter As New MySqlDataAdapter(command_text, connection)
            adapter.Fill(data)
            adapter.Dispose()
            data.Dispose()
            connection.Close()
            connection.Dispose()

            Return data
        Else 'return reader
            Dim connection As MySqlConnection = New MySqlConnection(connection_string)
            connection.Open()
            Dim command As MySqlCommand = connection.CreateCommand()
            command.CommandText = command_text
            Dim reader As MySqlDataReader = command.ExecuteReader()
            reader.Read()
            Dim result As String = reader.GetValue(col_index).ToString
            command.Dispose()
            connection.Close()
            connection.Dispose()

            Return result
        End If

        Return 0
    End Function

    Function show_databases(ByVal is_local As Boolean, ByVal host As String, ByVal username As String, ByVal password As String)
        If is_local = True Then
            host = app_host
            username = app_username
            password = app_password
        End If

        Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Convert Zero Datetime=True", host, username, password)

        Dim connection As New MySqlConnection(connection_string)
        connection.Open()
        Dim data As New DataTable
        Dim adapter As New MySqlDataAdapter("SHOW DATABASES", connection)
        adapter.Fill(data)
        adapter.Dispose()
        data.Dispose()
        connection.Close()
        connection.Dispose()

        Return data
    End Function

    Function check_connection(ByVal is_local As Boolean, ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String)
        If is_local = True Then
            host = app_host
            username = app_username
            password = app_password
            database = app_database
        End If

        Dim connection_string As String = String.Format("Data Source={0};User Id={1};Password={2};Database={3};Convert Zero Datetime=True", host, username, password, database)

        Dim connection As New MySqlConnection(connection_string)
        connection.Open()
        connection.Close()
        connection.Dispose()

        Return True
    End Function
    'tidak terpakai
    Sub write_database_configuration(ByVal ip As String, ByVal un As String, ByVal ps As String, ByVal db As String)
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\DatabaseConfiguration.xml"

        Dim xml_writer As New XmlTextWriter(path, System.Text.Encoding.UTF8)
        xml_writer.WriteStartDocument(True)
        xml_writer.Formatting = Formatting.Indented
        xml_writer.Indentation = 2
        xml_writer.WriteStartElement("database_config")
        createNode(ip, un, ps, db, xml_writer)
        xml_writer.WriteEndElement()
        xml_writer.WriteEndDocument()
        xml_writer.Close()

        Dim xmldoc As New XmlDocument()
        xmldoc.Load(path)
        Dim sharedkey As New TripleDESCryptoServiceProvider()
        Dim md5 As New MD5CryptoServiceProvider()
        sharedkey.Key = md5.ComputeHash(System.Text.Encoding.Unicode.GetBytes("0904505009"))

        Dim exml As EncryptedXml = New EncryptedXml(xmldoc)
        Dim encryptElement As XmlElement = CType(xmldoc.SelectSingleNode("/database_config"), XmlElement)
        Dim encryptXML As Byte() = exml.EncryptData(encryptElement, sharedkey, False)
        Dim ed As New EncryptedData()
        ed.Type = EncryptedXml.XmlEncElementUrl
        ed.EncryptionMethod = New EncryptionMethod(EncryptedXml.XmlEncTripleDESUrl)
        ed.CipherData = New CipherData()
        ed.CipherData.CipherValue = encryptXML
        EncryptedXml.ReplaceElement(encryptElement, ed, False)

        xmldoc.Save(path)
    End Sub
    'tidak terpakai
    Sub write_gammu_configuration(ByVal dir As String, ByVal port_dev As String, ByVal conn_dev As String, ByVal pin_dev As String, ByVal log_dev As String)
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\GammuConfiguration.xml"

        Dim xml_writer As New XmlTextWriter(path, System.Text.Encoding.UTF8)
        xml_writer.WriteStartDocument(True)
        xml_writer.Formatting = Formatting.Indented
        xml_writer.Indentation = 2
        xml_writer.WriteStartElement("gammu_config")
        createNode2(dir, port_dev, conn_dev, pin_dev, log_dev, xml_writer)
        xml_writer.WriteEndElement()
        xml_writer.WriteEndDocument()
        xml_writer.Close()

        Dim xmldoc As New XmlDocument()
        xmldoc.Load(path)
        Dim sharedkey As New TripleDESCryptoServiceProvider()
        Dim md5 As New MD5CryptoServiceProvider()
        sharedkey.Key = md5.ComputeHash(System.Text.Encoding.Unicode.GetBytes("0904505009"))

        Dim exml As EncryptedXml = New EncryptedXml(xmldoc)
        Dim encryptElement As XmlElement = CType(xmldoc.SelectSingleNode("/gammu_config"), XmlElement)
        Dim encryptXML As Byte() = exml.EncryptData(encryptElement, sharedkey, False)
        Dim ed As New EncryptedData()
        ed.Type = EncryptedXml.XmlEncElementUrl
        ed.EncryptionMethod = New EncryptionMethod(EncryptedXml.XmlEncTripleDESUrl)
        ed.CipherData = New CipherData()
        ed.CipherData.CipherValue = encryptXML
        EncryptedXml.ReplaceElement(encryptElement, ed, False)

        xmldoc.Save(path)
    End Sub
    Sub read_database_configuration()
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\DatabaseConfiguration.xml"
        Dim sharedkey As New TripleDESCryptoServiceProvider()
        Dim md5 As New MD5CryptoServiceProvider()
        sharedkey.Key = md5.ComputeHash(System.Text.Encoding.Unicode.GetBytes("0904505009"))

        Dim encryptedDoc As New XmlDocument()
        encryptedDoc.Load(path)

        Dim EncryptedElement As XmlElement = CType(encryptedDoc.GetElementsByTagName("EncryptedData")(0), XmlElement)

        Dim ed As New EncryptedData()
        ed.LoadXml(EncryptedElement)

        Dim encryptXML As New EncryptedXml()
        Dim decryptedXML As Byte() = encryptXML.DecryptData(ed, sharedkey)

        encryptXML.ReplaceData(EncryptedElement, decryptedXML)

        Dim xmlnode As XmlNodeList
        xmlnode = encryptedDoc.GetElementsByTagName("database_config")
        app_host = xmlnode(0).ChildNodes.Item(0).InnerText.Trim()
        app_username = xmlnode(0).ChildNodes.Item(1).InnerText.Trim()
        app_password = xmlnode(0).ChildNodes.Item(2).InnerText.Trim()
        app_database = xmlnode(0).ChildNodes.Item(3).InnerText.Trim()
        conn_db = "Database=" & app_database & ";Data Source=" & app_host & ";User Id=" & app_username & ";Password=" & app_password & ";Convert Zero Datetime=True"
        connection_problem = False
    End Sub
    Sub read_gammu_configuration()
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\GammuConfiguration.xml"
        Dim sharedkey As New TripleDESCryptoServiceProvider()
        Dim md5 As New MD5CryptoServiceProvider()
        sharedkey.Key = md5.ComputeHash(System.Text.Encoding.Unicode.GetBytes("0904505009"))

        Dim encryptedDoc As New XmlDocument()
        encryptedDoc.Load(path)

        Dim EncryptedElement As XmlElement = CType(encryptedDoc.GetElementsByTagName("EncryptedData")(0), XmlElement)

        Dim ed As New EncryptedData()
        ed.LoadXml(EncryptedElement)

        Dim encryptXML As New EncryptedXml()
        Dim decryptedXML As Byte() = encryptXML.DecryptData(ed, sharedkey)

        encryptXML.ReplaceData(EncryptedElement, decryptedXML)

        Dim xmlnode As XmlNodeList
        xmlnode = encryptedDoc.GetElementsByTagName("gammu_config")
        dir_gammux = xmlnode(0).ChildNodes.Item(0).InnerText.Trim()
        port_devx = xmlnode(0).ChildNodes.Item(1).InnerText.Trim()
        conn_devx = xmlnode(0).ChildNodes.Item(2).InnerText.Trim()
        pinx = xmlnode(0).ChildNodes.Item(3).InnerText.Trim()
        nama_logx = xmlnode(0).ChildNodes.Item(4).InnerText.Trim()
        connection_problem = False
    End Sub
    Private Sub createNode(ByVal ip As String, ByVal un As String, ByVal ps As String, ByVal db As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("ip_address")
        writer.WriteString(ip)
        writer.WriteEndElement()
        writer.WriteStartElement("username")
        writer.WriteString(un)
        writer.WriteEndElement()
        writer.WriteStartElement("password")
        writer.WriteString(ps)
        writer.WriteEndElement()
        writer.WriteStartElement("database")
        writer.WriteString(db)
        writer.WriteEndElement()
    End Sub
    Private Sub createNode2(ByVal dir As String, ByVal port_dev As String, ByVal conn_dev As String, ByVal pin_dev As String, ByVal log_dev As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("direktori")
        writer.WriteString(dir)
        writer.WriteEndElement()
        writer.WriteStartElement("port")
        writer.WriteString(port_dev)
        writer.WriteEndElement()
        writer.WriteStartElement("connection")
        writer.WriteString(conn_dev)
        writer.WriteEndElement()
        writer.WriteStartElement("pin")
        writer.WriteString(pin_dev)
        writer.WriteEndElement()
        writer.WriteStartElement("nama_log")
        writer.WriteString(log_dev)
        writer.WriteEndElement()
    End Sub
    'yang lama
    Sub create_file_smsdrc(ByVal dir As String, ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String, ByVal port_dev As String, ByVal conn_dev As String, ByVal pin_dev As String, ByVal log_dev As String)
        Dim mydocpath As String = dir
        Dim sb As StringBuilder = New StringBuilder()

        System.IO.File.Delete(dir & "\smsdrc")

        recreate_log(log_dev, dir)

        sb.AppendLine("[gammu]")
        sb.AppendLine("port=" & port_dev)
        sb.AppendLine("connection=" & conn_dev)
        sb.AppendLine()
        sb.AppendLine("[smsd]")
        sb.AppendLine("service=Sql")
        sb.AppendLine("driver=native_mysql")
        sb.AppendLine("PIN=" & pin_dev)
        sb.AppendLine("LogFile=" & dir & "\" & log_dev & ".txt")
        sb.AppendLine("user=" & username)
        sb.AppendLine("password=" & password)
        sb.AppendLine("host=" & host)
        sb.AppendLine("database=" & database)

        Using outfile As StreamWriter = New StreamWriter(mydocpath + "\smsdrc", False)
            outfile.Write(sb.ToString)
        End Using
    End Sub
    Sub create_file_smsdrc_new(ByVal id_modem As String, ByVal nama_modem As String, ByVal dir As String, ByVal host As String, ByVal username As String, ByVal password As String, ByVal database As String, ByVal port_dev As String, ByVal conn_dev As String, ByVal pin_dev As String)
        Dim mydocpath As String = dir
        Dim sb As StringBuilder = New StringBuilder()

        recreate_log("log_" & id_modem & "_" & nama_modem, dir)
        System.IO.File.Delete(dir & "\smsdrc" & id_modem)

        System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\start.bat")
        System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\stop.bat")
        System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\installservice.bat")
        System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\uninstallservice.bat")

        sb.AppendLine("[gammu]")
        sb.AppendLine("port=" & port_dev)
        sb.AppendLine("connection=" & conn_dev)
        sb.AppendLine()
        sb.AppendLine("[smsd]")
        sb.AppendLine("service=Sql")
        sb.AppendLine("Phoneid=" & nama_modem)
        sb.AppendLine("driver=native_mysql")
        sb.AppendLine("PIN=" & pin_dev)
        sb.AppendLine("LogFile=" & dir & "\log_" & id_modem & "_" & nama_modem & ".txt")
        sb.AppendLine("user=" & username)
        sb.AppendLine("password=" & password)
        sb.AppendLine("host=" & host)
        sb.AppendLine("database=" & database)

        Using outfile As StreamWriter = New StreamWriter(mydocpath & "\smsdrc" & id_modem, False)
            outfile.Write(sb.ToString)
        End Using
    End Sub
    Sub recreate_log(ByVal nama_log As String, ByVal dir As String)
        StopService()
        System.IO.File.Delete(dir & "\" & nama_log & ".txt")
        Dim mydocpath As String = dir
        Dim sb As StringBuilder = New StringBuilder()
        sb.AppendLine("LOG FILE")
        Using outfile As StreamWriter = New StreamWriter(mydocpath + "\" + nama_log + ".txt", False)
            outfile.Write(sb.ToString)
        End Using
    End Sub
    '==== print ===
    Sub CreateMarginalHeaderArea(ByVal sender As System.Object, ByVal e As CreateAreaEventArgs)
        Dim rec As RectangleF = New RectangleF(0, 5, e.Graph.ClientPageSize.Width, 50)
        Dim top As Integer = rec.Top
        
        'fetch dari db
        Try
            
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub print(ByVal GridControlHere As DevExpress.XtraGrid.GridControl, ByVal title_here As String)
        title_print = ""
        title_print = title_here
        Dim componentLink As New PrintableComponentLink(New PrintingSystem())
        componentLink.Component = GridControlHere
        componentLink.Landscape = True
        AddHandler componentLink.CreateReportHeaderArea, AddressOf CreateReportHeaderArea
        Dim phf As PageHeaderFooter = TryCast(componentLink.PageHeaderFooter, PageHeaderFooter)

        ' Clear the PageHeaderFooter's contents.
        phf.Header.Content.Clear()

        ' Add custom information to the link's header.
        phf.Footer.Content.AddRange(New String() _
            {"Printed By: [User Name]", "", "Date: [Date Printed]"})
        phf.Footer.LineAlignment = BrickAlignment.Near

        componentLink.CreateDocument()
        componentLink.ShowPreview()
    End Sub
    Sub CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As CreateAreaEventArgs)
        Dim reportHeader As String = title_print
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 11, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
    End Sub
    Function pilih_modem(ByVal pengirim As String)
        Dim query_modem, tiga_digit_pengirim, tiga_digit_modem, tiga_digit_modem1, tiga_digit_modem2, tiga_digit_modem3, sendernya As String
        Dim sender_i, sender_j As Integer
        Dim list_db As MySqlDataAdapter
        Dim dset_db As DataSet

        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)

        sendernya = ""
        query_modem = "SELECT tb_modem_nmr.id_modem,tb_modem_nmr.nomor_balas,tb_modem.nama_modem FROM tb_modem INNER JOIN tb_modem_nmr ON tb_modem.id_modem=tb_modem_nmr.id_modem ORDER BY tb_modem_nmr.id_modem AND tb_modem_nmr.id_nomor_balas DESC"

        If (Len(pengirim.ToString)) < 7 Then
            sendernya = sender_default_id()
        Else
            tiga_digit_pengirim = pengirim.Substring(3, 3)
            list_db = New MySqlDataAdapter(query_modem, koneksi)
            dset_db = New DataSet
            list_db.Fill(dset_db, "data")
            For sender_i = 0 To dset_db.Tables("data").Rows.Count - 1
                sender_j = 1
                tiga_digit_modem = dset_db.Tables("data").Rows(sender_i)(1).ToString
                tiga_digit_modem1 = tiga_digit_modem.Substring(3, 1)
                tiga_digit_modem2 = tiga_digit_modem.Substring(4, 1)
                tiga_digit_modem3 = tiga_digit_modem.Substring(5, 1)
                'pertama
                If Not tiga_digit_modem1 = "*" Then
                    If Not tiga_digit_modem1 = tiga_digit_pengirim.Substring(0, 1) Then
                        sender_j = 0
                    End If
                End If
                'kedua
                If Not tiga_digit_modem2 = "*" Then
                    If Not tiga_digit_modem2 = tiga_digit_pengirim.Substring(1, 1) Then
                        sender_j = 0
                    End If
                End If
                'ketiga
                If Not tiga_digit_modem3 = "*" Then
                    If Not tiga_digit_modem3 = tiga_digit_pengirim.Substring(2, 1) Then
                        sender_j = 0
                    End If
                End If
                If sender_j = 1 Then
                    sendernya = dset_db.Tables("data").Rows(sender_i)(2).ToString
                    Exit For
                End If
            Next sender_i

            If sender_j = 0 Then
                'gak ada ketemu sama
                sendernya = sender_default_id()
            End If
            list_db.Dispose()
            dset_db.Dispose()
        End If
        Return sendernya
    End Function
End Module
