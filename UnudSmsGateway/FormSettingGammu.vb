Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO

Public Class FormSettingGammu
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
        If connection_problem = True Then
            RibbonForm.Close()
            RibbonForm.Dispose()
        End If
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Try
            Dim fbd = New FolderBrowserDialog
            fbd.Description = "Pilih lokasi gammu. Misalnya C:\gammu"
            fbd.ShowDialog()
            fbd.ShowNewFolderButton = False
            TEAlamat.Text = fbd.SelectedPath.ToString
        Catch ex As Exception
            XtraMessageBox.Show("Sistem fatal error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim port_dev As String = TEPortDev.Text
        Dim conn_dev As String = TEConnDev.Text
        Dim dir_gammu As String = TEAlamat.Text
        Dim pin_dev As String = TEPin.Text
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query_eksekusi, id_modem, nama_modem, dir_modem, port_modem, conn_modem, pin_modem As String
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim command As MySqlCommand
        Dim query As String
        Dim n As Integer

        Me.Cursor = Cursors.WaitCursor
        Try
            If port_dev = "" Or conn_dev = "" Or dir_gammu = "" Then
                XtraMessageBox.Show("Isilah semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                koneksi.Open()
                command = koneksi.CreateCommand
                query = "DELETE FROM tb_modem"
                command.CommandText = query
                command.ExecuteNonQuery()
                query = "INSERT INTO tb_modem(nama_modem,direktori,port,connection,pin,nomor,is_default) VALUES('modem_default','" & dir_gammu.Replace("\", "\\") & "','" & port_dev & "','" & conn_dev & "','" & pin_dev & "','+62812','1')"
                command.CommandText = query
                command.ExecuteNonQuery()
                koneksi.Close()
                'end insert

                RibbonForm.TimerGeneral.Enabled = False
                StopService()
                MsgBox("Service Stopped")
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
                RibbonForm.DashboardToolStripMenuItem.Visible = True
                'end count
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        koneksi.Dispose()
        FormGammu.refresh_modem()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormSettingGammu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If connection_problem Then
            TEAlamat.Text = "C:\gammu"
        End If
    End Sub
End Class