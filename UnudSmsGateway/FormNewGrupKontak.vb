Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormNewGrupKontak
    Private id_grup_kontak As Integer
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim query As String
        If TENamaGrup.Text = "" Then
            XtraMessageBox.Show("Mohon isikan nama grup !")
        Else
            If Me.Text = "Edit Grup Kontak" Then
                Try
                    query = "UPDATE tb_grup_kontak SET grup_kontak='" & TENamaGrup.Text & "' WHERE id_grup_kontak='" & id_grup_kontak & "'"
                    execute_non_query(query, True, "", "", "", "")
                    FormGrupKontak.refresh_grup_kontak()
                    Me.Close()
                    Me.Dispose()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message, "Server database tidak ditemukan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    query = "INSERT INTO tb_grup_kontak(grup_kontak) VALUES('" & TENamaGrup.Text & "')"
                    execute_non_query(query, True, "", "", "", "")
                    FormGrupKontak.refresh_grup_kontak()
                    Me.Close()
                    Me.Dispose()
                Catch ex As Exception
                    XtraMessageBox.Show(ex.Message, "Server database tidak ditemukan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub FormNewGrupKontak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim query_ID As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)

        If Me.Text = "Edit Grup Kontak" Then
            id_grup_kontak = FormGrupKontak.GVGrupKontak.GetFocusedRowCellDisplayText("id_grup_kontak").ToString()
            Dim nama_grup As String
            koneksi.Open()
            query_ID = "SELECT grup_kontak FROM tb_grup_kontak WHERE id_grup_kontak='" & id_grup_kontak & "'"
            Command = koneksi.CreateCommand()
            Command.CommandText = query_ID
            reader = Command.ExecuteReader()
            reader.Read()
            nama_grup = reader.GetValue(0).ToString
            koneksi.Close()
            TENamaGrup.Text = nama_grup
        End If
    End Sub
End Class