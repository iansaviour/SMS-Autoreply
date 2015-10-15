Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormGammuNomorAdd
    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim nomor_ditangani_dev1, nomor_ditangani_dev2, nomor_ditangani_dev3, nomor_ditangani_dev As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String

        Try
            'start
            nomor_ditangani_dev1 = CBNo1.EditValue.ToString
            nomor_ditangani_dev2 = CBNo2.EditValue.ToString
            nomor_ditangani_dev3 = CBNo3.EditValue.ToString
            If nomor_ditangani_dev1 = "" Or isNotNumberModem(nomor_ditangani_dev1) Then
                nomor_ditangani_dev1 = "*"
            End If
            If nomor_ditangani_dev2 = "" Or isNotNumberModem(nomor_ditangani_dev2) Then
                nomor_ditangani_dev2 = "*"
            End If
            If nomor_ditangani_dev3 = "" Or isNotNumberModem(nomor_ditangani_dev3) Then
                nomor_ditangani_dev3 = "*"
            End If
            nomor_ditangani_dev = "+62" & nomor_ditangani_dev1 & nomor_ditangani_dev2 & nomor_ditangani_dev3
            'end

            'insert atau update dulu
            koneksi.Open()
            command = koneksi.CreateCommand
            If Me.Text = "New Nomor" Then
                query = "INSERT INTO tb_modem_nmr(id_modem,nomor_balas) VALUES('" & FormGammu.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString & "','" & nomor_ditangani_dev & "')"
            Else
                query = "UPDATE tb_modem_nmr SET nomor_balas='" & nomor_ditangani_dev & "' WHERE id_nomor_balas='" & FormGammuNomor.GVModem.GetFocusedRowCellDisplayText("id_nomor_balas").ToString & "'"
            End If
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            'end insert
            FormGammuNomor.refresh_nomor()
            Close()
            Dispose()
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormGammuNomorAdd_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub FormGammuNomorAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim id_nmr As String
        Dim query As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list As MySqlDataAdapter
        Dim dset As DataSet
        If Me.Text = "Edit Nomor" Then
            id_nmr = FormGammuNomor.GVModem.GetFocusedRowCellDisplayText("id_nomor_balas").ToString
            koneksi.Open()
            query = "SELECT nomor_balas from tb_modem_nmr WHERE id_nomor_balas='" & id_nmr & "'"
            list = New MySqlDataAdapter(query, koneksi)
            dset = New DataSet
            list.Fill(dset, "data")
            'isi
            CBNo1.EditValue = dset.Tables("data").Rows(0)(0).ToString().Substring(3, 1)
            CBNo2.EditValue = dset.Tables("data").Rows(0)(0).ToString().Substring(4, 1)
            CBNo3.EditValue = dset.Tables("data").Rows(0)(0).ToString().Substring(5, 1)
            list.Dispose()
            dset.Dispose()
            koneksi.Close()
        End If
        koneksi.Dispose()
    End Sub
End Class