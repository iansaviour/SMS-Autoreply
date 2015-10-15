Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormGammuNomor
    Private Sub FormGammuNomor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_nomor()
    End Sub
    Sub refresh_nomor()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT id_nomor_balas,nomor_balas as 'Nomor Yang Dilayani' FROM tb_modem_nmr WHERE id_modem='" & FormGammu.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString & "' ORDER BY nomor_balas ASC"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCModem.DataSource = data.Tables("data")
            Me.GVModem.Columns("id_nomor_balas").Visible = False
            koneksi.Close()
            If GVModem.RowCount.ToString() = "0" Then
                Me.BEditModem.Visible = False
                Me.BHapusModem.Visible = False
            Else
                Me.BHapusModem.Visible = True
                Me.BEditModem.Visible = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTambahModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambahModem.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            FormGammuNomorAdd.Text = "New Nomor"
            FormGammuNomorAdd.ShowDialog()
            FormGammuNomorAdd.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BEditModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditModem.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            FormGammuNomorAdd.Text = "Edit Nomor"
            FormGammuNomorAdd.ShowDialog()
            FormGammuNomorAdd.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BHapusModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHapusModem.Click
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String
        Try
            'hapus dulu
            koneksi.Open()
            command = koneksi.CreateCommand
            query = "DELETE FROM tb_modem_nmr WHERE id_nomor_balas='" & GVModem.GetFocusedRowCellDisplayText("id_nomor_balas").ToString & "'"
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            'end hapus
            refresh_nomor()
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class