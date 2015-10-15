Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormUser

    Private Sub FormUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_user()
    End Sub
    Sub refresh_user()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String
        If user_logged = "admin" Then
            query = "SELECT id_user,username as 'Username',nama_user as 'Nama User' FROM tb_user"
        Else
            query = "SELECT id_user,username as 'Username',nama_user as 'Nama User' FROM tb_user WHERE username !='admin'"
        End If
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            If data.Tables("data").Rows.Count = 0 Then
                Me.BDeleteUser.Visible = False
                Me.BEditUser.Visible = False
            Else
                Me.BDeleteUser.Visible = True
                Me.BEditUser.Visible = True
            End If
            Me.GCUser.DataSource = data.Tables("data")
            Me.GVUser.Columns("id_user").Visible = False
            koneksi.Close()
            data.Dispose()
            adapter.Dispose()
            koneksi.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak dapat diakses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNewUser.Click
        FormNewUser.ShowDialog()
    End Sub

    Private Sub BEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditUser.Click
        FormEditUser.TEIdUser.Text = Me.GVUser.GetFocusedRowCellDisplayText("id_user").ToString
        FormEditUser.ShowDialog()
    End Sub

    Private Sub BDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteUser.Click
        If Me.GVUser.GetFocusedRowCellDisplayText("Username").ToString() = "admin" Then
            XtraMessageBox.Show("Admin tidak bisa dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.GVUser.GetFocusedRowCellDisplayText("Username").ToString() = user_logged Then
            XtraMessageBox.Show("Anda sedang login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            delete_user(Me.GVUser.GetFocusedRowCellDisplayText("id_user").ToString())
            refresh_user()
        End If
    End Sub

    Sub delete_user(ByVal id_user As String)
        Dim koneksi As New MySqlConnection(conn_db)
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String
        Try
            koneksi.Open()
            query = "DELETE FROM tb_user WHERE id_user='" & id_user & "'"
            command.CommandText = query
            command.ExecuteNonQuery()

            koneksi.Close()
            koneksi.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak dapat diakses!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class