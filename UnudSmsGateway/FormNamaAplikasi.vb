Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormNamaAplikasi
    Dim pemisahx As String
    Dim deskripsi As String
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormNamaAplikasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim del_rep, send_after, query_eksekusi, nama_aplikasi, x_hari, balas_spam, dir_backup, deskripsi_app As String
        Try
            koneksi.Open()

            query_eksekusi = "SELECT send_after,delivery_report,deskripsi_sms,nama_app_sms,char_pemisah,balas_spam,sms_x_hari_kosongkan,dir_backup FROM tb_option LIMIT 1"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            If dset_eksekusi.Tables("data").Rows.Count = 0 Then
                nama_aplikasi = "Unud SMS Gateway"
                x_hari = "7"
                balas_spam = "0"
                pemisahx = "#"
                dir_backup = "C:\gammu"
                deskripsi_app = "Copyright : Divinkom@2013"
                del_rep = "default"
                send_after = "0"
            Else
                nama_aplikasi = dset_eksekusi.Tables("data").Rows(0)("nama_app_sms").ToString()
                x_hari = dset_eksekusi.Tables("data").Rows(0)("sms_x_hari_kosongkan").ToString()
                balas_spam = dset_eksekusi.Tables("data").Rows(0)("balas_spam").ToString()
                pemisahx = dset_eksekusi.Tables("data").Rows(0)("char_pemisah").ToString()
                deskripsi_app = dset_eksekusi.Tables("data").Rows(0)("deskripsi_sms").ToString()
                dir_backup = dset_eksekusi.Tables("data").Rows(0)("dir_backup").ToString()
                del_rep = dset_eksekusi.Tables("data").Rows(0)("delivery_report").ToString()
                send_after = dset_eksekusi.Tables("data").Rows(0)("send_after").ToString()
            End If
            koneksi.Close()
            koneksi.Dispose()
            Me.TEPemisah.Text = nama_aplikasi
            Me.MEDeskripsi.Text = deskripsi_app.ToString
            Me.TEHariHapus.Text = x_hari
            If balas_spam = False Then
                Me.CEBalasSpam.Checked = False
            Else
                Me.CEBalasSpam.Checked = True
            End If

            If del_rep = "yes" Then
                CEDeliveryReport.Checked = True
            Else
                CEDeliveryReport.Checked = False
            End If
            TESMSSetelah.Text = send_after

            Me.TEAlamatBackup.Text = dir_backup
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If CheckValue(Application.ProductName) = "" Then
            CEStartStartup.Checked = False
        Else
            CEStartStartup.Checked = True
        End If

    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        RibbonForm.TimerGeneral.Enabled = False
        Dim nama_aplikasi, x_hari, balas_spam As String
        nama_aplikasi = Me.TEPemisah.Text.ToString
        x_hari = Me.TEHariHapus.Text.ToString
        Dim send_after As String = Me.TESMSSetelah.Text.ToString
        Dim dir_backup As String = Me.TEAlamatBackup.Text.ToString
        Dim deskripsi As String

        If CEDeliveryReport.Checked = True Then
            'aktif delivery report
            delivery_report = "yes"
        Else
            delivery_report = "no"
        End If

        deskripsi = Me.MEDeskripsi.Text.ToString
        If deskripsi = "" Then
            deskripsi = "Copyright : Divinkom @2013"
        End If

        If Me.CEBalasSpam.Checked = True Then
            balas_spam = "1"
        Else
            balas_spam = "0"
        End If

        Dim result As DialogResult

        If nama_aplikasi = "" Then
            XtraMessageBox.Show("Nama tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(x_hari) Then
            XtraMessageBox.Show("Jumlah hari tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf x_hari < 0 Then
            XtraMessageBox.Show("Jumlah hari tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not IsNumeric(send_after) Then
            XtraMessageBox.Show("Jumlah delay SMS tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf send_after < 0 Then
            XtraMessageBox.Show("Jumlah delay SMS tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If balas_spam = "1" Then
                result = XtraMessageBox.Show("Anda yakin ingin membalas spam?" & Environment.NewLine & "Jika diaktifkan, memungkinkan gammu saling balas tanpa henti!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If result = Windows.Forms.DialogResult.Yes Then
                    If CEStartStartup.Checked = True Then
                        RunAtStartup(Application.ProductName, Application.ExecutablePath.ToString)
                    Else
                        RemoveValue(Application.ProductName)
                    End If

                    Try
                        Using db_Conn As MySqlConnection = ReturnMyConn()
                            Dim MySQL_Query As New MySqlCommand("UPDATE tb_option SET nama_app_sms=?appsms,char_pemisah=?charpemisah,sms_x_hari_kosongkan=?harikosongkan,balas_spam=?balasspam,dir_backup=?dirbackup,deskripsi_sms=?deskripsi,delivery_report=?del_rep,send_after=?send_afterx", db_Conn)

                            MySQL_Query.CommandType = CommandType.Text
                            MySQL_Query.Parameters.Add(New MySqlParameter("appsms", nama_aplikasi))
                            MySQL_Query.Parameters.Add(New MySqlParameter("charpemisah", pemisahx))
                            MySQL_Query.Parameters.Add(New MySqlParameter("harikosongkan", x_hari))
                            MySQL_Query.Parameters.Add(New MySqlParameter("balasspam", balas_spam))
                            MySQL_Query.Parameters.Add(New MySqlParameter("dirbackup", dir_backup))
                            MySQL_Query.Parameters.Add(New MySqlParameter("deskripsi", deskripsi))
                            MySQL_Query.Parameters.Add(New MySqlParameter("del_rep", delivery_report))
                            MySQL_Query.Parameters.Add(New MySqlParameter("send_afterx", send_after))
                            MySQL_Query.ExecuteNonQuery()
                        End Using

                        kirim_setelah = send_after
                        apply_nama()
                        apply_del_rep()
                        apply_send_after()
                        Me.Close()
                        Me.Dispose()
                    Catch ex As Exception
                        XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                If CEStartStartup.Checked = True Then
                    RunAtStartup(Application.ProductName, Application.ExecutablePath.ToString)
                Else
                    RemoveValue(Application.ProductName)
                End If

                Try
                    Using db_Conn As MySqlConnection = ReturnMyConn()
                        Dim MySQL_Query As New MySqlCommand("UPDATE tb_option SET nama_app_sms=?appsms,char_pemisah=?charpemisah,sms_x_hari_kosongkan=?harikosongkan,balas_spam=?balasspam,dir_backup=?dirbackup,deskripsi_sms=?deskripsi,delivery_report=?del_rep,send_after=?send_afterx", db_Conn)

                        MySQL_Query.CommandType = CommandType.Text
                        MySQL_Query.Parameters.Add(New MySqlParameter("appsms", nama_aplikasi))
                        MySQL_Query.Parameters.Add(New MySqlParameter("charpemisah", pemisahx))
                        MySQL_Query.Parameters.Add(New MySqlParameter("harikosongkan", x_hari))
                        MySQL_Query.Parameters.Add(New MySqlParameter("balasspam", balas_spam))
                        MySQL_Query.Parameters.Add(New MySqlParameter("dirbackup", dir_backup))
                        MySQL_Query.Parameters.Add(New MySqlParameter("deskripsi", deskripsi))
                        MySQL_Query.Parameters.Add(New MySqlParameter("del_rep", delivery_report))
                        MySQL_Query.Parameters.Add(New MySqlParameter("send_afterx", send_after))
                        MySQL_Query.ExecuteNonQuery()
                    End Using

                    kirim_setelah = send_after
                    apply_nama()
                    apply_del_rep()
                    apply_send_after()
                    Me.Close()
                    Me.Dispose()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
        RibbonForm.TimerGeneral.Enabled = True
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Try
            Dim fbd = New FolderBrowserDialog
            fbd.Description = "Pilih lokasi gammu. Misalnya C:\gammu"
            fbd.ShowDialog()
            fbd.ShowNewFolderButton = False
            TEAlamatBackup.Text = fbd.SelectedPath.ToString
        Catch ex As Exception
            XtraMessageBox.Show("Sistem fatal error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function ReturnMyConn() As MySqlConnection
        Dim db_Conn As New MySqlConnection(conn_db)
        Try
            db_Conn.Open()
        Catch myerror As MySqlException
            MessageBox.Show("Error Connecting to Database: " & myerror.Message)
        End Try
        Return db_Conn
    End Function
End Class