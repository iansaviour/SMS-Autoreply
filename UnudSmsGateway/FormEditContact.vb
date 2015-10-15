Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormEditContact

    Private Sub FormEditContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_kontak()
    End Sub
    Sub refresh_kontak()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT id_kontak,nama_kontak as 'Nama',no_hp as 'Nomor',email as 'Id Yahoo' FROM tb_kontak"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        koneksi.Open()
        adapter.Fill(data, "data")
        If data.Tables("data").Rows.Count = 0 Then
            Me.BEditContact.Visible = False
            Me.BDeleteContact.Visible = False
            Me.BPrivelege.Visible = False
        Else
            Me.BDeleteContact.Visible = True
            Me.BEditContact.Visible = True
            Me.BPrivelege.Visible = True
        End If
        Me.GCContact.DataSource = data.Tables("data")
        Me.GVContact.Columns("id_kontak").Visible = False
        koneksi.Close()
        data.Dispose()
        adapter.Dispose()
        koneksi.Dispose()
    End Sub

    Private Sub BNewContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNewContact.Click
        FormNewContact.ShowDialog()
    End Sub

    Private Sub BDeleteContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteContact.Click
        Dim result As DialogResult
        result = XtraMessageBox.Show("Anda ingin menghapus kontak?" & Environment.NewLine & "Data privelege dari kontak ini juga akan dihapus!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = Windows.Forms.DialogResult.Yes Then
            delete_kontak(Me.GVContact.GetFocusedRowCellDisplayText("id_kontak").ToString)
            refresh_kontak()
        End If
    End Sub
    Sub delete_kontak(ByVal id_kontak As String)
        Dim koneksi As New MySqlConnection(conn_db)
        koneksi.Open()
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String = "DELETE FROM tb_kontak WHERE id_kontak='" & id_kontak & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
        koneksi.Dispose()
    End Sub

    Private Sub BEditContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditContact.Click
        FormNewContact.Text = "Edit Contact"
        FormNewContact.id_kontak = Me.GVContact.GetFocusedRowCellDisplayText("id_kontak").ToString
        FormNewContact.ShowDialog()
    End Sub

    Private Sub BRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefresh.Click
        refresh_kontak()
    End Sub

    Private Sub BPrivelege_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrivelege.Click
        FormContactPrivelege.ShowDialog()
    End Sub

    Private Sub BPrintContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintContact.Click
        print(GCContact, "Contact")
    End Sub
End Class