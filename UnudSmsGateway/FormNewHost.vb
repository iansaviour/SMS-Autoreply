Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class FormNewHost
    Dim id_host_edit As Integer
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
                Me.TBNamaHost.Enabled = True
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
            Me.TBNamaHost.Enabled = False
        End If
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

    Private Sub BBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBatal.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Sub clear_form()
        Me.BCekKoneksi.Text = "Cek Koneksi"
        Me.TBHost.Text = ""
        Me.TBUsername.Text = ""
        Me.TBPassword.Text = ""
        Me.CBDatabase.Properties.Items.Clear()
        Me.TBNamaHost.Text = ""
        Me.TBHost.Enabled = True
        Me.TBUsername.Enabled = True
        Me.TBPassword.Enabled = True
        Me.CBDatabase.Enabled = False
        Me.TBNamaHost.Enabled = False
    End Sub
    Private Sub BSimpanHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanHost.Click
        Dim host As String = Me.TBHost.Text
        Dim username As String = Me.TBUsername.Text
        Dim password As String = Me.TBPassword.Text
        Dim database As String = Me.CBDatabase.Text
        Dim nama_host As String = Me.TBNamaHost.Text
        Dim error_text As String

        error_text = ""
        If nama_host = "" Then
            error_text = error_text & vbCrLf & "Nama Host harus diisi !"
        Else
            If database = "" Then
                error_text = error_text & vbCrLf & "Pilih salah satu database !"
            Else
                'validasi database
                Try
                    Dim conn As String
                    conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password & ";Database=" & database
                    Dim koneksi As MySqlConnection = New MySqlConnection(conn)
                    koneksi.Open()
                    koneksi.Close()
                    koneksi.Dispose()
                Catch ex As Exception
                    error_text = error_text & vbCrLf & "Database tidak valid"
                End Try
            End If
        End If
        If error_text = "" Then
            Dim koneksi As New MySqlConnection(conn_db)
            Try
                koneksi.Open()
                Dim command As MySqlCommand = koneksi.CreateCommand
                Dim query As String
                Dim is_lokalx As String
                is_lokalx = "1"

                If Me.Text = "Edit Host" Then
                    query = "UPDATE tb_host set host='" & host & "',username='" & username & "',PASSWORD='" & password & "',db='" & database & "',nama_host='" & nama_host & "',is_local='" & is_lokalx & "' WHERE id_host='" & id_host_edit & "'"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                Else
                    query = "INSERT INTO tb_host(host,username,PASSWORD,db,nama_host,is_local) VALUE('" & host & "','" & username & "','" & password & "','" & database & "','" & nama_host & "','" & is_lokalx & "')"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                End If
                koneksi.Close()
                FormSettingHost.refresh_host()
                Me.Close()
                Me.Dispose()
            Catch ex As Exception

            End Try
        Else
            XtraMessageBox.Show("Error : " & error_text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormNewHost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Edit Host" Then
            Dim query_database As String
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim list_db As MySqlDataAdapter
            Dim dset_db As DataSet
            'cari detil host
            id_host_edit = FormSettingHost.GVHost.GetFocusedRowCellDisplayText("id_host").ToString()
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
            Me.TBHost.Text = ip_host
            Me.TBUsername.Text = user_host
            Me.TBPassword.Text = pass_host
            Me.TBNamaHost.Text = nama_host
            Me.CBDatabase.EditValue = db_host
        End If
    End Sub
End Class