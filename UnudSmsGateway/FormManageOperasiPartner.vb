Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormManageOperasiPartner
    Private Sub BImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BImport.Click
        FormImportOperasi.ShowDialog()
    End Sub
    Sub refresh_operasi()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT tb_operasi.id_operasi,tb_operasi.id_host,tb_operasi.nama_operasi as 'Nama Operasi',tb_host.nama_host AS 'Nama Host',tb_operasi.keyword as 'Keyword',tb_host.db as 'Database',tb_operasi.id_jenis_sql,tb_jenis_sql.jenis_sql AS 'Jenis SQL',tb_operasi.id_jenis_operasi,tb_jenis_operasi.jenis_operasi AS 'Jenis operasi' FROM(tb_operasi, tb_jenis_operasi, tb_jenis_sql, tb_host) WHERE tb_operasi.id_jenis_operasi = tb_jenis_operasi.id_jenis_operasi AND tb_operasi.id_jenis_sql=tb_jenis_sql.id_jenis_sql AND tb_operasi.id_host=tb_host.id_host AND tb_host.is_local='0'"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCOperasiPartner.DataSource = data.Tables("data")
            Me.GVOperasiPartner.Columns("id_operasi").Visible = False
            Me.GVOperasiPartner.Columns("id_host").Visible = False
            Me.GVOperasiPartner.Columns("id_jenis_sql").Visible = False
            Me.GVOperasiPartner.Columns("id_jenis_operasi").Visible = False
            koneksi.Close()
            data.Dispose()
            koneksi.Dispose()
            If GVOperasiPartner.RowCount.ToString() = "0" Then
                Me.BEksekusi.Visible = False
                Me.BDelete.Visible = False
            Else
                Me.BEksekusi.Visible = True
                Me.BDelete.Visible = True
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FormManageOperasiPartner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_operasi()
    End Sub
    Sub delete_operasi_partner(ByVal id_operasi As String)
        Try
            Dim koneksi As New MySqlConnection(conn_db)
            koneksi.Open()
            Dim command As MySqlCommand = koneksi.CreateCommand
            Dim query As String = "DELETE FROM tb_operasi WHERE id_operasi='" & id_operasi & "'"
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            koneksi.Dispose()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Private Sub BEksekusi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEksekusi.Click
        FormPanelOperasi.TEIdOperasi.Text = Me.GVOperasiPartner.GetFocusedRowCellDisplayText("id_operasi").ToString()
        Try
            FormPanelOperasi.ShowDialog()
        Catch ex As Exception
            FormPanelOperasi.ShowDialog()
        End Try
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        Dim result As DialogResult
        result = XtraMessageBox.Show("Anda yakin ingin menghapus Operasi ini?" & Environment.NewLine & "Data operasi yang berkaitan dengan oeprasi ini juga akan dihapus!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            delete_operasi_partner(Me.GVOperasiPartner.GetFocusedRowCellDisplayText("id_operasi").ToString())
            refresh_operasi()
        End If
    End Sub

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrint.Click
        print(GCOperasiPartner, "Operasi Partner")
    End Sub
End Class