Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormNewUser

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim nama_user As String = TENamaUser.Text
        Dim password As String = TEPassword.Text
        Dim rep_password As String = TERepeat.Text
        Dim username As String = TEUsername.Text
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query, query_cek As String

        If nama_user = "" Or password = "" Or username = "" Then
            XtraMessageBox.Show("Semua field harus diisikan !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Not password = rep_password Then
            XtraMessageBox.Show("Perulangan password tidak sama !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                koneksi.Open()
                query_cek = "Select * from tb_user WHERE username='" & username & "'"
                Dim list_db As MySqlDataAdapter = New MySqlDataAdapter(query_cek, koneksi)
                Dim dset_db As DataSet = New DataSet
                list_db.Fill(dset_db, "data")
                Dim n As Integer = dset_db.Tables("data").Rows.Count
                dset_db.Dispose()
                list_db.Dispose()
                koneksi.Close()

                If n = 0 Then
                    koneksi.Open()
                    command = koneksi.CreateCommand
                    query = "INSERT INTO tb_user(nama_user,username,password) VALUES('" & nama_user & "','" & username & "',MD5('" & password & "'))"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    koneksi.Close()
                    FormUser.refresh_user()
                    Me.Close()
                    Me.Dispose()
                Else
                    XtraMessageBox.Show("Username telah digunakan !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                koneksi.Dispose()
            Catch ex As Exception
                XtraMessageBox.Show("Server tidak terdeteksi !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class