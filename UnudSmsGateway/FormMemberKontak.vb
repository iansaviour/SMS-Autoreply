Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormMemberKontak
    Public id_grup_kontak As String
    Public id_pop_up As String = "-1"
    '1 = grup kontak
    '2 = scheduler
    Private Sub FormMemberKontak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_kontak()
    End Sub
    Sub load_kontak()
        Dim query As String = ""

        If id_pop_up = "1" Then
            query = "SELECT id_kontak,nama_kontak,no_hp,email,'no' as checkbox FROM tb_kontak"
            query += " WHERE id_kontak NOT IN"
            query += " ("
            query += " SELECT "
            query += " g_m.id_kontak"
            query += " FROM "
            query += " tb_grup_kontak_member g_m"
            query += " WHERE g_m.id_grup_kontak = '" & id_grup_kontak & "'"
            query += " )"
            Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, app_database)
            GCKontak.DataSource = data
        Else

        End If

        If GVKontak.RowCount > 0 Then
            BEdit.Visible = False
        Else
            BEdit.Visible = True
        End If
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        'empty filter
        GVKontak.ApplyFindFilter("")
        'loop all the centang
        GVKontak.ActiveFilterString = "[checkbox] = 'yes'"

        'For i As Integer = 0 To GVKontak.RowCount - 1
        '    Console.WriteLine(GVKontak.GetRowCellValue(i, "id_kontak"))
        'Next

        Dim query As String
        Try
            For i As Integer = 0 To GVKontak.RowCount - 1
                query = "INSERT INTO tb_grup_kontak_member(id_grup_kontak,id_kontak) VALUES('" & id_grup_kontak & "','" & GVKontak.GetRowCellValue(i, "id_kontak").ToString & "')"
                execute_non_query(query, True, "", "", "", "")
            Next

            FormGrupKontak.show_member(id_grup_kontak)

            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Server database tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefresh.Click
        load_kontak()
    End Sub
End Class