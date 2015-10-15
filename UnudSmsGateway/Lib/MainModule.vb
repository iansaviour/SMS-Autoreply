Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.ServiceProcess
Imports System.IO
Imports System.Text

Module MainModule
    Public host As String
    Public usn As String
    Public pwd As String
    Public dbs As String
    Public conn_db As String
    'Public nama_gammu_service As String
    Public is_login_menu As Boolean
    Public user_logged As String
    Public has_start_service As String
    Public has_force_stop As String
    '=============================================================================================================
    ' Modul Umum
    '=============================================================================================================
    Function ask_msgbox(ByVal question As String)
        Dim confirm As DialogResult
        confirm = XtraMessageBox.Show(question, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If confirm = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub errorCustom(ByVal err_msg As String)
        XtraMessageBox.Show(err_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub stopCustom(ByVal stop_msg As String)
        XtraMessageBox.Show(stop_msg, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Sub infoCustom(ByVal info_msg As String)
        XtraMessageBox.Show(info_msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub warningCustom(ByVal warning_msg As String)
        XtraMessageBox.Show(warning_msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Delay(ByVal dblSecs As Double)
        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub
    Sub uninstallservice()
        If RibbonForm.is_use_gammu = "1" Then
            If Not File.Exists(My.Application.Info.DirectoryPath.ToString & "\uninstallservice.bat") Then
                Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
                Dim sb As StringBuilder = New StringBuilder()

                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\uninstallservice.bat")
                'count sebanyak modem
                Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
                Dim query_eksekusi, id_modem, nama_modem, dir_modem As String
                Dim list_eksekusi As MySqlDataAdapter
                Dim dset_eksekusi As DataSet
                Dim n As Integer

                query_eksekusi = "SELECT id_modem,nama_modem,direktori FROM tb_modem"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                For i = 0 To n - 1
                    id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                    dir_modem = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                    'isi
                    sb.AppendLine("chdir " & dir_modem & "\bin")
                    sb.AppendLine("gammu-smsd -c smsdrc" & id_modem & " -n GammuSMSD" & id_modem & " -u")
                    'end isi
                Next i
                sb.AppendLine("exit")
                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()
                koneksi.Dispose()
                'end count

                Using outfile As StreamWriter = New StreamWriter(mydocpath + "\uninstallservice.bat", True)
                    outfile.Write(sb.ToString)
                End Using
            End If

            Dim cek_status As Boolean
            Dim try_count As Integer
            try_count = 0
            cek_status = False
            While cek_status = False
                If Not CheckAdaService() Then
                    cek_status = True
                    Exit While
                End If
                Try
                    Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\uninstallservice.bat")
                    psi.WindowStyle = ProcessWindowStyle.Hidden

                    Dim process As Process = process.Start(psi)
                    process.Dispose()
                    Delay(5)
                Catch ex As Exception
                End Try
            End While
        Else
            'jika ada
        End If
    End Sub
    Sub InstallService()
        If RibbonForm.is_use_gammu = "1" Then
            If CheckService() Then
                uninstallservice()
            End If

            If Not File.Exists(My.Application.Info.DirectoryPath.ToString & "\installservice.bat") Then
                Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
                Dim sb As StringBuilder = New StringBuilder()

                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\installservice.bat")
                'count sebanyak modem
                Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
                Dim query_eksekusi, id_modem, nama_modem, dir_modem As String
                Dim list_eksekusi As MySqlDataAdapter
                Dim dset_eksekusi As DataSet
                Dim n As Integer

                query_eksekusi = "SELECT id_modem,nama_modem,direktori FROM tb_modem"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                For i = 0 To n - 1
                    id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                    dir_modem = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                    'isi
                    sb.AppendLine("net stop ""GammuSMSD" & id_modem & """")
                    sb.AppendLine("chdir " & dir_modem & "\bin")
                    sb.AppendLine("gammu-smsd -c smsdrc" & id_modem & " -n GammuSMSD" & id_modem & " -i")
                    'end isi
                Next i
                sb.AppendLine("exit")
                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()
                koneksi.Dispose()
                'end count

                Using outfile As StreamWriter = New StreamWriter(mydocpath + "\installservice.bat", True)
                    outfile.Write(sb.ToString)
                End Using
            End If

            Dim cek_status As Boolean
            Dim try_count As Integer
            try_count = 0
            cek_status = False
            While cek_status = False
                If CheckService() Then
                    cek_status = True
                    Exit While
                End If
                Try
                    Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\installservice.bat")
                    psi.WindowStyle = ProcessWindowStyle.Hidden

                    Dim process As Process = process.Start(psi)
                    process.Dispose()
                    Delay(5)
                Catch ex As Exception
                End Try
            End While
        Else
            'jika ada 
        End If
    End Sub
    Sub StartService()
        If RibbonForm.is_use_gammu = "1" Then
            Dim cek_status As Boolean
            Dim try_count As Integer
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim query_eksekusi, id_modem, nama_modem As String
            Dim list_eksekusi As MySqlDataAdapter
            Dim dset_eksekusi As DataSet
            Dim n, i As Integer

            try_count = 0
            cek_status = False

            If Not File.Exists(My.Application.Info.DirectoryPath.ToString & "\start.bat") Then
                Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
                Dim sb As StringBuilder = New StringBuilder()

                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\start.bat")
                'count sebanyak modem
                query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                For i = 0 To n - 1
                    id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                    'isi
                    sb.AppendLine("net stop ""GammuSMSD" & id_modem & """")
                    sb.AppendLine("net start ""GammuSMSD" & id_modem & """")
                    'end isi
                Next i
                sb.AppendLine("exit")
                'end count
                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()

                Using outfile As StreamWriter = New StreamWriter(mydocpath + "\start.bat", True)
                    outfile.Write(sb.ToString)
                End Using
            End If

            Dim try_load As Integer = 0

            While cek_status = 0
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
                'end ambil testing service

                If GetServiceStatus(nama_serviceawal).ToString = "Running" Then
                    cek_status = 1
                    RibbonForm.BBStartService.Enabled = False
                    RibbonForm.BBStopService.Enabled = True
                    RibbonForm.STTimer.Caption = "Gammu Aktif."
                    RibbonForm.timer_status = True
                    RibbonForm.SchedulerSMS.Enabled = True
                    has_start_service = 1
                    Exit While
                End If

                'update 5/7/2015
                If try_load > 3 Then
                    reload_modem()
                End If
                try_load = try_load + 1
                '=end update

                Try
                    Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\start.bat")
                    psi.WindowStyle = ProcessWindowStyle.Hidden

                    Dim process As Process = process.Start(psi)
                    process.Dispose()
                    Delay(5)
                Catch ex As Exception
                End Try

                
            End While
            koneksi.Dispose()
        Else
            RibbonForm.BBStartService.Enabled = False
            RibbonForm.BBStopService.Enabled = True
            RibbonForm.STTimer.Caption = "Service Aktif."
            RibbonForm.timer_status = True
            RibbonForm.SchedulerSMS.Enabled = True
            has_start_service = 1
        End If
    End Sub
    Sub StopService()
        If RibbonForm.is_use_gammu = "1" Then
            Dim cek_status As Boolean
            Dim try_count As Integer
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim query_eksekusi, id_modem, nama_modem As String
            Dim list_eksekusi As MySqlDataAdapter
            Dim dset_eksekusi As DataSet
            Dim n, i As Integer
            try_count = 0
            cek_status = False

            If Not File.Exists(My.Application.Info.DirectoryPath.ToString & "\stop.bat") Then
                Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
                Dim sb As StringBuilder = New StringBuilder()

                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\stop.bat")
                'count sebanyak modem
                query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                For i = 0 To n - 1
                    id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                    'isi
                    sb.AppendLine("net stop ""GammuSMSD" & id_modem & """")
                    'end isi
                Next i
                sb.AppendLine("exit")
                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()
                'end count

                Using outfile As StreamWriter = New StreamWriter(mydocpath + "\stop.bat", True)
                    outfile.Write(sb.ToString)
                End Using
            End If

            While cek_status = False
                If CheckAdaService() Then
                    'service test
                    query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem ORDER BY id_modem ASC"
                    list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                    dset_eksekusi = New DataSet
                    list_eksekusi.Fill(dset_eksekusi, "data")
                    n = dset_eksekusi.Tables("data").Rows.Count
                    id_modem = dset_eksekusi.Tables("data").Rows(0)(0).ToString()
                    nama_modem = dset_eksekusi.Tables("data").Rows(0)(1).ToString()
                    Dim nama_serviceawal = "GammuSMSD" & id_modem
                    list_eksekusi.Dispose()
                    dset_eksekusi.Dispose()
                    'end ambil testing service

                    If GetServiceStatus(nama_serviceawal).ToString = "Stopped" Then
                        cek_status = True
                        RibbonForm.BBStartService.Enabled = True
                        RibbonForm.BBStopService.Enabled = False
                        RibbonForm.STTimer.Caption = "Gammu Tidak Aktif."
                        RibbonForm.timer_status = False
                        RibbonForm.SchedulerSMS.Enabled = False
                        Exit While
                    End If
                    Try
                        Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\stop.bat")
                        psi.WindowStyle = ProcessWindowStyle.Hidden

                        Dim process As Process = process.Start(psi)
                        process.Dispose()
                        Delay(10)
                    Catch ex As Exception
                    End Try
                Else
                    RibbonForm.BBStartService.Enabled = True
                    RibbonForm.BBStopService.Enabled = False
                    RibbonForm.STTimer.Caption = "Gammu Tidak Aktif."
                    RibbonForm.timer_status = False
                    RibbonForm.SchedulerSMS.Enabled = False
                    Exit While
                End If
            End While
            koneksi.Dispose()
        Else
            RibbonForm.BBStartService.Enabled = True
            RibbonForm.BBStopService.Enabled = False
            RibbonForm.STTimer.Caption = "Service Tidak Aktif."
            RibbonForm.timer_status = False
            RibbonForm.SchedulerSMS.Enabled = False
        End If
    End Sub
    Function GetServiceStatus(ByVal strServiceName As String) As ServiceControllerStatus
        Dim status As ServiceControllerStatus
        If CheckAdaService() Then
            Dim service As New ServiceController(strServiceName)
            status = service.Status
            service.Dispose()
        End If
        Return status
    End Function
    Function CheckService() As Boolean
        Dim colServices As Object
        Dim objService As Object
        'count sebanyak modem
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_eksekusi, Name, id_modem, nama_modem As String
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim n, k, l, ada As Integer
        l = 1
        ' 0 tidak ada
        ada = 0
        query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
        list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
        dset_eksekusi = New DataSet
        list_eksekusi.Fill(dset_eksekusi, "data")
        n = dset_eksekusi.Tables("data").Rows.Count
        For i = 0 To n - 1
            id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
            nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
            'isi
            Name = "GammuSMSD" & id_modem
            colServices = GetObject("winmgmts:").ExecQuery _
            ("Select Name from Win32_Service where Name = '" & Name & "'")
            k = 0
            For Each objService In colServices
                If Len(objService.Name) Then
                    CheckService = True
                    k = 1
                    ada = 1
                End If
            Next
            'end isi
            If k = 0 Then
                l = 0
            End If
        Next i
        If ada = 0 Then
            CheckService = False
        Else
            CheckService = True
        End If
        list_eksekusi.Dispose()
        dset_eksekusi.Dispose()
        'end count

        colServices = Nothing
    End Function
    Function CheckAdaService() As Boolean
        Dim colServices As Object
        Dim objService As Object
        'count sebanyak modem
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_eksekusi, Name, id_modem, nama_modem As String
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim n, l As Integer
        l = 0
        query_eksekusi = "SELECT id_modem,nama_modem FROM tb_modem"
        list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
        dset_eksekusi = New DataSet
        list_eksekusi.Fill(dset_eksekusi, "data")
        n = dset_eksekusi.Tables("data").Rows.Count
        For i = 0 To n - 1
            id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
            nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
            'isi
            Name = "GammuSMSD" & id_modem
            colServices = GetObject("winmgmts:").ExecQuery _
            ("Select Name from Win32_Service where Name = '" & Name & "'")
            For Each objService In colServices
                If Len(objService.Name) Then
                    CheckAdaService = True
                End If
            Next
        Next i
        list_eksekusi.Dispose()
        dset_eksekusi.Dispose()
        'end count
        colServices = Nothing
    End Function
    Function repair_string(ByVal input As String)
        Dim output As String = ""
        Dim length As Integer = input.Length
        Dim i As Integer = -1

        Try
            While i <= length - 1
                i = i + 1
                If input(i) = """" Then
                    input = input.Insert(i, "\")
                    i = i + 1
                    length = length + 1
                End If
            End While
        Catch ex As Exception

        End Try

        output = input
        Return output
    End Function

    '=============================================================================================================
    ' Modul handling database aplikasi
    '=============================================================================================================

    Sub update_conn_db()
        conn_db = "Database=" & dbs & ";Data Source=" & host & ";User Id=" & usn & ";Password=" & pwd & ";Convert Zero Datetime=True"
    End Sub

    '===========================================================================================
    'Modul Log File
    '===========================================================================================

    Sub create_log_directory()
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\log"
        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Sub create_log(ByVal messege As String, ByVal username As String)
        Dim path As String = My.Application.Info.DirectoryPath.ToString & "\log\" & Date.Now.ToString("yyyy_MM") & ".txt"
        Dim date_log As String = Date.Now.ToString("MMMM d, yyyy  HH:mm:ss")
        If Not File.Exists(path) Then
            Using oWrite As StreamWriter = New StreamWriter(path)
                oWrite.WriteLine(date_log & " - " & username & " - " & messege)
            End Using
        Else
            Using oWrite As StreamWriter = New StreamWriter(path, True)
                oWrite.WriteLine(date_log & " - " & username & " - " & messege)
            End Using
        End If
    End Sub
    Sub reload_modem()
        If RibbonForm.is_use_gammu = "1" Then
            Dim query_eksekusi, id_modem, nama_modem, dir_modem, port_modem, conn_modem, pin_modem As String
            Dim list_eksekusi As MySqlDataAdapter
            Dim dset_eksekusi As DataSet
            Dim n As Integer
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)

            RibbonForm.TimerGeneral.Enabled = False
            StopService()
            uninstallservice()
            'count sebanyak modem
            query_eksekusi = "SELECT id_modem,nama_modem,direktori,port,connection,pin FROM tb_modem"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            n = dset_eksekusi.Tables("data").Rows.Count
            For i = 0 To n - 1
                id_modem = dset_eksekusi.Tables("data").Rows(i)(0).ToString()
                nama_modem = dset_eksekusi.Tables("data").Rows(i)(1).ToString()
                dir_modem = dset_eksekusi.Tables("data").Rows(i)(2).ToString()
                port_modem = dset_eksekusi.Tables("data").Rows(i)(3).ToString()
                conn_modem = dset_eksekusi.Tables("data").Rows(i)(4).ToString()
                pin_modem = dset_eksekusi.Tables("data").Rows(i)(5).ToString()
                'isi
                create_file_smsdrc_new(id_modem, nama_modem, dir_modem & "\bin", app_host, app_username, app_password, app_database, port_modem, conn_modem, pin_modem)
                'end isi
            Next i
            list_eksekusi.Dispose()
            dset_eksekusi.Dispose()
            InstallService()
            StartService()
            RibbonForm.TimerGeneral.Enabled = True
            'end count
        Else
            'jika ada
        End If
    End Sub
    Sub SE_load_min(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim query As String = "SELECT '*' AS value_min,'Semua menit' AS display_min"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim dr As DataRow
        For i As Integer = 0 To 59
            dr = data.NewRow()
            dr(0) = i.ToString
            dr(1) = i.ToString
            data.Rows.Add(dr)
        Next

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "display_min"
        SLE.Properties.ValueMember = "value_min"
        SLE.EditValue = data.Rows(0)(0).ToString
    End Sub
    Sub SE_load_hour(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim query As String = "SELECT '*' AS value_hour,'Semua jam' AS display_hour"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim dr As DataRow
        For i As Integer = 0 To 23
            dr = data.NewRow()
            dr(0) = i.ToString
            dr(1) = i.ToString
            data.Rows.Add(dr)
        Next

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "display_hour"
        SLE.Properties.ValueMember = "value_hour"
        SLE.EditValue = data.Rows(0)(0).ToString
    End Sub
    Sub SE_load_date(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)

        Dim query As String = "SELECT '*' AS value_date,'Semua tanggal' AS display_date"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim dr As DataRow
        For i As Integer = 1 To 31
            dr = data.NewRow()
            dr(0) = i.ToString
            dr(1) = i.ToString
            data.Rows.Add(dr)
        Next

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "display_date"
        SLE.Properties.ValueMember = "value_date"
        SLE.EditValue = data.Rows(0)(0).ToString
 
    End Sub
    Sub SE_load_month(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim query As String = "SELECT '*' AS value_month,'Semua bulan' AS display_month"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        data.Rows.Add(New Object() {1, "Januari"})
        data.Rows.Add(New Object() {2, "Februari"})
        data.Rows.Add(New Object() {3, "Maret"})
        data.Rows.Add(New Object() {4, "April"})
        data.Rows.Add(New Object() {5, "Mei"})
        data.Rows.Add(New Object() {6, "Juni"})
        data.Rows.Add(New Object() {7, "Juli"})
        data.Rows.Add(New Object() {8, "Agustus"})
        data.Rows.Add(New Object() {9, "September"})
        data.Rows.Add(New Object() {10, "Oktober"})
        data.Rows.Add(New Object() {11, "November"})
        data.Rows.Add(New Object() {12, "Desember"})

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "display_month"
        SLE.Properties.ValueMember = "value_month"
        SLE.EditValue = data.Rows(0)(0).ToString
    End Sub
    Sub SE_load_dow(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim query As String = "SELECT '*' AS value_dow,'Semua hari' AS display_dow"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        data.Rows.Add(New Object() {1, "Minggu"})
        data.Rows.Add(New Object() {2, "Senin"})
        data.Rows.Add(New Object() {3, "Selasa"})
        data.Rows.Add(New Object() {4, "Rabu"})
        data.Rows.Add(New Object() {5, "Kamis"})
        data.Rows.Add(New Object() {6, "Jumat"})
        data.Rows.Add(New Object() {7, "Sabtu"})

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "display_dow"
        SLE.Properties.ValueMember = "value_dow"
        SLE.EditValue = data.Rows(0)(0).ToString
    End Sub
    Sub SE_load_status(ByRef SLE As DevExpress.XtraEditors.SearchLookUpEdit)
        Dim query As String = "SELECT '1' AS id_status,'Aktif' AS status"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        data.Rows.Add(New Object() {2, "Tidak Aktif"})

        SLE.Properties.DataSource = Nothing
        SLE.Properties.DataSource = data
        SLE.Properties.DisplayMember = "status"
        SLE.Properties.ValueMember = "id_status"
        SLE.EditValue = data.Rows(0)(0).ToString
    End Sub
End Module
