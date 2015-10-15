Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormLogin

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BLogin.Click
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim jml_eksekusi As Integer

        Dim username As String = Me.TEUsername.Text
        Dim password As String = Me.TEPassword.Text

        If username = "" Or password = "" Then
            XtraMessageBox.Show("Username dan password harus diisikan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            jml_eksekusi = 0
            Try
                koneksi.Open()
                Dim query As String
                query = "SELECT COUNT(*) FROM tb_user WHERE username='" & username & "'"
                command = koneksi.CreateCommand()
                command.CommandText = query
                reader = command.ExecuteReader()
                reader.Read()
                jml_eksekusi = reader.GetValue(0).ToString
                koneksi.Close()

                If jml_eksekusi = 0 Then
                    XtraMessageBox.Show("Username Tidak terdaftar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    koneksi.Open()
                    query = "SELECT COUNT(*) FROM tb_user WHERE username='" & username & "' AND password=MD5('" & password & "')"
                    command = koneksi.CreateCommand()
                    command.CommandText = query
                    reader = command.ExecuteReader()
                    reader.Read()
                    jml_eksekusi = reader.GetValue(0).ToString
                    koneksi.Close()

                    If jml_eksekusi = 0 Then
                        XtraMessageBox.Show("Password atau username salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        is_login_menu = True
                        RibbonForm.BBLogin.Enabled = False
                        RibbonForm.BBLogout.Enabled = True
                        user_logged = username
                        RibbonForm.tampilkan_menu()

                        Me.Close()
                        Me.Dispose()
                    End If
                End If
            Catch ex As Exception
                XtraMessageBox.Show("Password atau username salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        End If
    End Sub
End Class