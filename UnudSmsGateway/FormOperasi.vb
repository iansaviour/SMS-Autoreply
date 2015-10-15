Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormOperasi

    Private Sub FormOperasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_operasi()
    End Sub

    Sub refresh_operasi()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT tb_operasi.id_operasi,tb_operasi.id_host,tb_operasi.nama_operasi as 'Nama Operasi',tb_host.nama_host AS 'Nama Host',tb_operasi.keyword as 'Keyword',tb_host.db as 'Database',tb_operasi.id_jenis_sql,tb_jenis_sql.jenis_sql AS 'Jenis SQL',tb_operasi.id_jenis_operasi,tb_jenis_operasi.jenis_operasi AS 'Jenis operasi' FROM(tb_operasi, tb_jenis_operasi, tb_jenis_sql, tb_host) WHERE tb_operasi.id_jenis_operasi = tb_jenis_operasi.id_jenis_operasi AND tb_operasi.id_jenis_sql=tb_jenis_sql.id_jenis_sql AND tb_operasi.id_host=tb_host.id_host"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCOperasiEks.DataSource = data.Tables("data")
            Me.GVOperasiEks.Columns("id_operasi").Visible = False
            Me.GVOperasiEks.Columns("id_host").Visible = False
            Me.GVOperasiEks.Columns("id_jenis_sql").Visible = False
            Me.GVOperasiEks.Columns("id_jenis_operasi").Visible = False
            koneksi.Close()
            data.Dispose()
            koneksi.Dispose()
            If GVOperasiEks.RowCount.ToString() = "0" Then
                Me.SimpleButton1.Visible = False
            Else
                Me.SimpleButton1.Visible = True
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        FormPanelOperasi.TEIdOperasi.Text = Me.GVOperasiEks.GetFocusedRowCellDisplayText("id_operasi").ToString()
        Try
            FormPanelOperasi.ShowDialog()
        Catch ex As Exception
            FormPanelOperasi.ShowDialog()
        End Try
    End Sub

    Private Sub BPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        print(GCOperasiEks, "Operasi Partner")
    End Sub
End Class