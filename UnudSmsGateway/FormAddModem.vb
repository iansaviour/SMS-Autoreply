Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO

Public Class FormAddModem
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

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim nama_dev As String = TENamaGammu.Text
        Dim port_dev As String = TEPortDev.Text
        Dim conn_dev As String = TEConnDev.Text
        Dim dir_gammu As String = TEAlamat.Text
        Dim pin_dev As String = TEPin.Text
        Dim nomor_dev As String = TENomor.Text
        Dim cek_pulsa As String = TECekPulsa.Text
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String

        Me.Cursor = Cursors.WaitCursor
        Try
            If port_dev = "" Or conn_dev = "" Or dir_gammu = "" Or nama_dev = "" Or nomor_dev = "" Then
                XtraMessageBox.Show("Isilah semua field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                
                'insert atau update dulu
                koneksi.Open()
                command = koneksi.CreateCommand
                If Me.Text = "Edit Modem" Then
                    query = "UPDATE tb_modem SET nama_modem='" & nama_dev & "',direktori='" & dir_gammu.Replace("\", "\\") & "',port='" & port_dev & "',connection='" & conn_dev & "',pin='" & pin_dev & "',nomor='+62" & nomor_dev & "',cek_pulsa='" & cek_pulsa & "' WHERE id_modem='" & FormGammu.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString & "'"
                Else
                    query = "INSERT INTO tb_modem(nama_modem,direktori,port,connection,pin,nomor,cek_pulsa) VALUES('" & nama_dev & "','" & dir_gammu.Replace("\", "\\") & "','" & port_dev & "','" & conn_dev & "','" & pin_dev & "','+62" & nomor_dev & "','" & cek_pulsa & "')"
                End If
                command.CommandText = query
                command.ExecuteNonQuery()
                koneksi.Close()
                'end insert

                reload_modem()
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

    Private Sub FormAddModem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id_modem As String
        Dim query As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list As MySqlDataAdapter
        Dim dset As DataSet
        If Me.Text = "Edit Modem" Then
            id_modem = FormGammu.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString
            koneksi.Open()
            query = "SELECT nama_modem,direktori,port,connection,pin,nomor,cek_pulsa from tb_modem WHERE id_modem='" & id_modem & "'"
            list = New MySqlDataAdapter(query, koneksi)
            dset = New DataSet
            list.Fill(dset, "data")
            'isi
            TENamaGammu.Text = dset.Tables("data").Rows(0)(0).ToString()
            TEPortDev.Text = dset.Tables("data").Rows(0)(2).ToString()
            TEConnDev.Text = dset.Tables("data").Rows(0)(3).ToString()
            TEAlamat.Text = dset.Tables("data").Rows(0)(1).ToString()
            TEPin.Text = dset.Tables("data").Rows(0)(4).ToString()
            TENomor.Text = dset.Tables("data").Rows(0)(5).ToString().Substring(3)
            'CBNo1.EditValue = dset.Tables("data").Rows(0)(6).ToString().Substring(3, 1)
            'CBNo2.EditValue = dset.Tables("data").Rows(0)(6).ToString().Substring(4, 1)
            'CBNo3.EditValue = dset.Tables("data").Rows(0)(6).ToString().Substring(5, 1)
            TECekPulsa.Text = dset.Tables("data").Rows(0)(6).ToString()
            list.Dispose()
            dset.Dispose()
            koneksi.Close()
        End If
        koneksi.Dispose()
    End Sub
End Class