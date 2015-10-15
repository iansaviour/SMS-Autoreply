Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormSettingHost
    Private Sub FormSettingHost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_host()
    End Sub
    Sub refresh_host()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT nama_host as 'Nama Host',id_host,host as 'IP',db as 'Database' FROM tb_host WHERE is_local=1"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCHost.DataSource = data.Tables("data")
            Me.GVHost.Columns("id_host").Visible = False
            koneksi.Close()
            If GVHost.RowCount.ToString() = "0" Then
                Me.BDeleteHost.Visible = False
                Me.BEditHost.Visible = False
            Else
                Me.BDeleteHost.Visible = True
                Me.BEditHost.Visible = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub delete_host(ByVal id_host As String)
        Try
            Dim koneksi As New MySqlConnection(conn_db)
            koneksi.Open()
            Dim command As MySqlCommand = koneksi.CreateCommand
            Dim query As String = "DELETE FROM tb_host WHERE id_host='" & id_host & "'"
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub BNewHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNewHost.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            FormNewHost.Text = "New Host"
            FormNewHost.ShowDialog()
            FormNewHost.Focus()
        Catch ex As Exception
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BEditHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditHost.Click
        FormNewHost.Text = "Edit Host"
        FormNewHost.ShowDialog()
    End Sub

    Private Sub BDeleteHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteHost.Click
        Dim result As DialogResult
        result = XtraMessageBox.Show("Anda yakin ingin menghapus host?" & Environment.NewLine & "Data operasi yang berkaitan dengan host ini juga akan dihapus!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            delete_host(Me.GVHost.GetFocusedRowCellDisplayText("id_host").ToString())
            refresh_host()
        End If
    End Sub
End Class