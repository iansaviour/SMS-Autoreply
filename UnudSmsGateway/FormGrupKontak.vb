Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormGrupKontak

    Private Sub FormGrupKontak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_grup_kontak()
    End Sub
    Sub refresh_grup_kontak()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT id_grup_kontak,grup_kontak as 'Grup Kontak' FROM tb_grup_kontak"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        koneksi.Open()
        adapter.Fill(data, "data")
        Me.GCGrupKontak.DataSource = data.Tables("data")
        Me.GVGrupKontak.Columns("id_grup_kontak").Visible = False
        If data.Tables("data").Rows.Count = 0 Then
            Me.BDelete.Visible = False
            XTPMember.PageVisible = False
        Else
            Me.BDelete.Visible = True
            XTPMember.PageVisible = True
            show_member(GVGrupKontak.GetFocusedRowCellValue("id_grup_kontak").ToString)
        End If
        
        koneksi.Close()
        data.Dispose()
        adapter.Dispose()
        koneksi.Dispose()
    End Sub
    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        delete_grup_kontak(Me.GVGrupKontak.GetFocusedRowCellDisplayText("id_grup_kontak").ToString())
        refresh_grup_kontak()
    End Sub
    Sub delete_grup_kontak(ByVal id_grup_kontak As Integer)
        Dim koneksi As New MySqlConnection(conn_db)
        koneksi.Open()
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String = "DELETE FROM tb_grup_kontak WHERE id_grup_kontak='" & id_grup_kontak & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
    End Sub

    Private Sub BTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambah.Click
        FormNewGrupKontak.ShowDialog()
    End Sub

    Private Sub BEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEdit.Click
        FormNewGrupKontak.Text = "Edit Grup Kontak"
        FormNewGrupKontak.ShowDialog()
    End Sub

    Sub show_member(ByVal id_grup As String)
        Dim query As String = "SELECT g_m.id_grup_kontak_member,g_m.id_kontak,k.nama_kontak,k.no_hp,k.email "
        query += " FROM tb_grup_kontak_member g_m"
        query += " INNER JOIN tb_kontak k ON k.id_kontak=g_m.id_kontak"
        query += " WHERE g_m.id_grup_kontak='" & id_grup & "'"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, app_database)

        GCKontak.DataSource = data
        If data.Rows.Count > 0 Then
            BDeleteMember.Visible = True
        Else
            BDeleteMember.Visible = False
        End If
    End Sub

    Private Sub BRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefresh.Click
        refresh_grup_kontak()
    End Sub

    Private Sub BAddMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddMember.Click
        FormMemberKontak.id_pop_up = "1"
        FormMemberKontak.id_grup_kontak = GVGrupKontak.GetFocusedRowCellValue("id_grup_kontak").ToString
        FormMemberKontak.ShowDialog()
    End Sub

    Private Sub GVGrupKontak_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GVGrupKontak.FocusedRowChanged
        If GVGrupKontak.RowCount > 0 Then
            show_member(GVGrupKontak.GetFocusedRowCellValue("id_grup_kontak").ToString)
        End If
    End Sub
    Private Sub GVKontak_CustomColumnDisplayText(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GVKontak.CustomColumnDisplayText
        If e.Column.FieldName = "no" Then
            e.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub

    Private Sub BDeleteMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteMember.Click
        If ask_msgbox("Apakah anda yakin ingin menghapus member ini dari grup ?") Then
            Dim id_kontak As String = GVKontak.GetFocusedRowCellValue("id_kontak").ToString
            Dim id_grup_kontak As String = GVGrupKontak.GetFocusedRowCellValue("id_grup_kontak").ToString

            Dim query As String = "DELETE FROM tb_grup_kontak_member WHERE id_grup_kontak='" + id_grup_kontak + "' AND id_kontak='" + id_kontak + "'"
            execute_non_query(query, True, "", "", "", "")
        End If
    End Sub
End Class