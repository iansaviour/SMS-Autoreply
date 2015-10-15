Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormNewContact
    Public id_kontak As String
    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim nama_kontak As String = Me.TENamaContact.Text
        Dim no_telp As String = "+62" & Me.TENoTelp.Text
        Dim email As String = Me.TEEmail.Text
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String

        If Me.TENamaContact.Text = "" Or Me.TENoTelp.Text = "" Or Me.TEEmail.Text = "" Then
            XtraMessageBox.Show("Semua field harus diisikan !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                If Me.Text = "Edit Contact" Then
                    koneksi.Open()
                    command = koneksi.CreateCommand
                    query = "UPDATE tb_kontak SET nama_kontak='" & nama_kontak & "',no_hp='" & no_telp & "',email='" & email & "' WHERE id_kontak='" & id_kontak & "'"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    koneksi.Close()
                Else
                    koneksi.Open()
                    command = koneksi.CreateCommand
                    query = "INSERT INTO tb_kontak(nama_kontak,no_hp,email) VALUES('" & nama_kontak & "','" & no_telp & "','" & email & "')"
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    koneksi.Close()
                End If
                command.Dispose()
                koneksi.Dispose()
                FormEditContact.refresh_kontak()
                Me.Close()
                Me.Dispose()
            Catch ex As Exception
                XtraMessageBox.Show("Database tidak dapat diakses !", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormNewContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Edit Contact" Then
            Dim query As String
            Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
            Dim list As MySqlDataAdapter
            Dim dset As DataSet

            koneksi.Open()
            query = "SELECT nama_kontak,no_hp,email FROM tb_kontak WHERE id_kontak='" & id_kontak & "'"
            list = New MySqlDataAdapter(query, koneksi)
            dset = New DataSet
            list.Fill(dset, "data")

            Dim x As String = dset.Tables("data").Rows(0)(1).ToString()
            Dim length As Integer = x.Length
            'isi
            Me.TENamaContact.Text = dset.Tables("data").Rows(0)(0).ToString()
            Me.TENoTelp.Text = x.Substring(3, length - 3)
            Me.TEEmail.Text = dset.Tables("data").Rows(0)(2).ToString()

            list.Dispose()
            dset.Dispose()
            koneksi.Close()
            koneksi.Dispose()
        End If
    End Sub
End Class