Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class FormServer
    Private Sub BCekKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCekKoneksi.Click
        If Me.BCekKoneksi.Text = "Cek Koneksi" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                tampil_db_to_cb(Me.CBDatabase, Me.TBHost.Text, Me.TBUsername.Text, Me.TBPassword.Text)
                Me.Cursor = Cursors.Default
                Me.BCekKoneksi.Text = "Ganti Koneksi"
                Me.TBHost.Enabled = False
                Me.TBUsername.Enabled = False
                Me.TBPassword.Enabled = False
                Me.CBDatabase.Enabled = True
                Me.BSimpanHost.Enabled = True
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.BCekKoneksi.Text = "Cek Koneksi"
            Me.TBHost.Enabled = True
            Me.TBUsername.Enabled = True
            Me.TBPassword.Enabled = True
            Me.CBDatabase.Enabled = False
            Me.BSimpanHost.Enabled = False
        End If
        
    End Sub

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub
    Sub tampil_db_to_cb(ByRef CB As ComboBoxEdit, ByVal host As String, ByVal username As String, ByVal password As String)
        Dim conn, query_database As String
        conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password
        Dim koneksi As MySqlConnection = New MySqlConnection(conn)
        koneksi.Open()
        query_database = "SHOW DATABASES"
        Dim list_db As MySqlDataAdapter = New MySqlDataAdapter(query_database, koneksi)
        Dim dset_db As DataSet = New DataSet
        list_db.Fill(dset_db, "data")
        Dim n As Integer = dset_db.Tables("data").Rows.Count
        Dim temp_db As String
        CB.Properties.Items.Clear()
        For i = 0 To n - 1
            temp_db = dset_db.Tables("data").Rows(i)(0).ToString()
            CB.Properties.Items.Add(temp_db)
        Next i
        list_db.Dispose()
        dset_db.Dispose()
        koneksi.Close()
        koneksi.Dispose()
    End Sub

    Private Sub BSimpanHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanHost.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not Me.CBDatabase.EditValue.ToString = "" Then
                '
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\start.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\stop.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\installservice.bat")
                System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\uninstallservice.bat")
                '
                write_database_configuration(TBHost.Text, TBUsername.Text, TBPassword.Text, CBDatabase.EditValue.ToString)
                read_database_configuration()
                RibbonForm.TimerGeneral.Enabled = False
                RibbonForm.SchedulerSMS.Enabled = False
                'count sebanyak modem
                Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
                Dim query_eksekusi, id_modem, nama_modem, dir_modem, port_modem, conn_modem, pin_modem As String
                Dim list_eksekusi As MySqlDataAdapter
                Dim dset_eksekusi As DataSet
                Dim n As Integer
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
                'InstallService()
                'StartService()
                RibbonForm.TimerGeneral.Enabled = True
                RibbonForm.SchedulerSMS.Enabled = True
                'end count
                '
                RibbonForm.DashboardToolStripMenuItem.Visible = True
                Me.Close()
                Me.Dispose()
            Else
                XtraMessageBox.Show("Harap memilih database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FormServer_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If connection_problem = True Then
            RibbonForm.Close()
            RibbonForm.Dispose()
        End If
    End Sub
End Class