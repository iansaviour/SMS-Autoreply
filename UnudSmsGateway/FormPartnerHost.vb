Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FormPartnerHost
    Dim id_host_edit As Integer
    Private Sub BSimpanHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanHost.Click
        Dim nama_host As String = Me.TBNamaHost.Text
        Dim nomor_kontak As String = Me.TBNomorKontak.Text
        Dim email As String = Me.TBEmail.Text
        Dim karakter_pemisah As String = Me.TBCharPemisah.Text
        Dim error_text As String

        error_text = ""
        If nama_host = "" Then
            error_text = error_text & vbCrLf & "Nama Host harus diisi !"
        Else
            If nomor_kontak = "" And email = "" Then
                error_text = error_text & vbCrLf & "Isi minimal salah satu dari nomor kontak dan email"
            Else
                nomor_kontak = "+62" & nomor_kontak
                If karakter_pemisah.Length <> 1 Or karakter_pemisah = " " Or karakter_pemisah = "=" Or karakter_pemisah = "~" Or karakter_pemisah = "," Then
                    error_text = error_text & vbCrLf & "Pemisah tidak valid"
                End If
            End If
        End If
        If error_text = "" Then
            Dim koneksi As New MySqlConnection(conn_db)
            Try
                koneksi.Open()
                Dim command As MySqlCommand = koneksi.CreateCommand
                Dim query As String
                Dim is_lokalx As String
                is_lokalx = "0"

                If Me.Text = "Edit Host" Then
                    query = "UPDATE tb_host set host='" & host & "',no_hp='" & nomor_kontak & "',email='" & email & "',nama_host='" & nama_host & "',is_local='" & is_lokalx & "',karakter_pemisah='" & karakter_pemisah & "' WHERE id_host='" & id_host_edit & "'"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                Else
                    query = "INSERT INTO tb_host(host,no_hp,email,nama_host,is_local,karakter_pemisah) VALUE('" & host & "','" & nomor_kontak & "','" & email & "','" & nama_host & "','" & is_lokalx & "','" & karakter_pemisah & "')"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                End If
                koneksi.Close()
                FormSettingHostPartner.refresh_host()
                Me.Close()
                Me.Dispose()
            Catch ex As Exception

            End Try
        Else
            XtraMessageBox.Show("Error : " & error_text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormPartnerHost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Edit Host" Then
            Dim query_database As String
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim list_db As MySqlDataAdapter
            Dim dset_db As DataSet
            'cari detil host
            id_host_edit = FormSettingHostPartner.GVHost.GetFocusedRowCellDisplayText("id_host").ToString()
            koneksi.Open()
            query_database = "SELECT host,username,password,db,nama_host,no_hp,email,is_local,karakter_pemisah FROM tb_host WHERE id_host='" & id_host_edit & "'"
            list_db = New MySqlDataAdapter(query_database, koneksi)
            dset_db = New DataSet
            list_db.Fill(dset_db, "data")
            Dim ip_host As String = dset_db.Tables("data").Rows(0)(0).ToString()
            Dim user_host As String = dset_db.Tables("data").Rows(0)(1).ToString()
            Dim pass_host As String = dset_db.Tables("data").Rows(0)(2).ToString()
            Dim db_host As String = dset_db.Tables("data").Rows(0)(3).ToString()
            Dim nama_host As String = dset_db.Tables("data").Rows(0)(4).ToString()
            Dim hp_host As String = dset_db.Tables("data").Rows(0)(5).ToString()
            Dim email_host As String = dset_db.Tables("data").Rows(0)(6).ToString()
            Dim is_lokal As String = dset_db.Tables("data").Rows(0)(7).ToString()
            Dim karakter_pemisah As String = dset_db.Tables("data").Rows(0)(8).ToString()
            list_db.Dispose()
            dset_db.Dispose()
            koneksi.Close()
            Me.TBNamaHost.Text = nama_host
            If Not hp_host.Length < 4 Then
                Me.TBNomorKontak.Text = hp_host.Substring(3, hp_host.Length - 3)
            End If
            Me.TBEmail.Text = email_host
            Me.TBCharPemisah.Text = karakter_pemisah
        End If
    End Sub

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBatal.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class