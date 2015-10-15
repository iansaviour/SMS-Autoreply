Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormContactPrivelege
    Dim id_kontak As String = FormEditContact.GVContact.GetFocusedRowCellDisplayText("id_kontak").ToString
    Private Sub FormContactPrivelege_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_operasi(Me.CLBOperasi)
    End Sub
    Private Sub view_operasi(ByVal listbox As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim query As String = "SELECT id_operasi,nama_operasi FROM tb_operasi"
        Dim data As DataTable = execute_query(query, -1, False, app_host, app_username, app_password, app_database)

        listbox.DataSource = data
        listbox.DisplayMember = "nama_operasi"
        listbox.ValueMember = "id_operasi"

        Dim n As Integer = listbox.ItemCount
        For i = 0 To n - 1
            query = "SELECT * FROM tb_privilege WHERE id_kontak='" & id_kontak & "' AND id_operasi='" & listbox.GetItemValue(i).ToString & "'"
            data = execute_query(query, -1, False, app_host, app_username, app_password, app_database)

            If data.Rows.Count <> 0 Then
                listbox.SetItemChecked(i, True)
            End If
        Next i
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim num As Integer
        Dim query As String
        Try
            query = "DELETE FROM tb_privilege WHERE id_kontak='" & id_kontak & "'"
            execute_non_query(query, True, "", "", "", "")

            num = CLBOperasi.CheckedItems.Count

            For i As Integer = 0 To num - 1
                query = "INSERT INTO tb_privilege(id_kontak,id_operasi) VALUES('" & id_kontak & "','" & CLBOperasi.CheckedItems.Item(i).ToString & "')"
                execute_non_query(query, True, "", "", "", "")
            Next

            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Server database tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BSAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSAll.Click
        Dim num As Integer
        num = CLBOperasi.ItemCount

        For i As Integer = 0 To num - 1
            CLBOperasi.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub BDSAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDSAll.Click
        Dim num As Integer
        num = CLBOperasi.ItemCount

        For i As Integer = 0 To num - 1
            CLBOperasi.SetItemChecked(i, False)
        Next
    End Sub
End Class