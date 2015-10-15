Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class FormSelectContact

    Private Sub FormSelectContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_db_to_cb(Me.CLBContact)
        tampil_grup_to_cb(Me.CLBGrupKontak)
    End Sub
    Sub tampil_db_to_cb(ByRef CLB As CheckedListBoxControl)
        Dim query_database As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        koneksi.Open()
        query_database = "SELECT id_kontak,CONCAT(nama_kontak,' [',no_hp,']') AS 'fullset' FROM tb_kontak ORDER BY nama_kontak"
        Dim list_db As MySqlDataAdapter = New MySqlDataAdapter(query_database, koneksi)
        Dim dset_db As DataSet = New DataSet
        list_db.Fill(dset_db, "data")
        Dim n As Integer = dset_db.Tables("data").Rows.Count
        CLB.Items.Clear()
        CLB.DataSource = dset_db.Tables("data")
        CLB.DisplayMember = "fullset"
        CLB.ValueMember = "id_kontak"
        list_db.Dispose()
        dset_db.Dispose()
        koneksi.Close()
        koneksi.Dispose()
    End Sub
    Sub tampil_grup_to_cb(ByRef CLB As CheckedListBoxControl)
        Dim query_database As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        koneksi.Open()
        query_database = "SELECT id_grup_kontak,grup_kontak FROM tb_grup_kontak ORDER BY grup_kontak ASC"
        Dim list_db As MySqlDataAdapter = New MySqlDataAdapter(query_database, koneksi)
        Dim dset_db As DataSet = New DataSet
        list_db.Fill(dset_db, "data")
        Dim n As Integer = dset_db.Tables("data").Rows.Count
        CLB.Items.Clear()
        CLB.DataSource = dset_db.Tables("data")
        CLB.DisplayMember = "grup_kontak"
        CLB.ValueMember = "id_grup_kontak"
        list_db.Dispose()
        dset_db.Dispose()
        koneksi.Close()
        koneksi.Dispose()
    End Sub
    Private Sub BOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOk.Click
        Dim nomor As String
        Dim nomor_simpan As String = ""
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader

        If CLBContact.CheckedItems.Count <> 0 Then
            Dim x As Integer = CLBContact.CheckedItems.Count
            Dim a As Integer = 1
            For Each item As DataRowView In CLBContact.CheckedItems
                koneksi.Open()
                query = "SELECT no_hp FROM tb_kontak WHERE id_kontak='" & item(CLBContact.ValueMember).ToString & "'"
                command = koneksi.CreateCommand()
                command.CommandText = query
                reader = command.ExecuteReader()
                reader.Read()
                nomor = reader.GetValue(0).ToString
                koneksi.Close()

                If a = x Then
                    nomor_simpan = nomor_simpan & nomor
                Else
                    nomor_simpan = nomor_simpan & nomor & ";"
                End If
                a = a + 1
            Next item
            koneksi.Dispose()
        Else
            XtraMessageBox.Show("Pilih minimal satu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        FormSMS.TBNoTujuan.Text = nomor_simpan
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BCancelGrup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelGrup.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BOkGrupKontak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOkGrupKontak.Click
        Dim nomor As String
        Dim nomor_simpan As String = ""
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim query, query_eksekusi As String
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet
        Dim n As Integer

        If CLBGrupKontak.CheckedItems.Count <> 0 Then
            Dim x As Integer = CLBGrupKontak.CheckedItems.Count
            Dim a As Integer = 1
            For Each item As DataRowView In CLBGrupKontak.CheckedItems
                koneksi.Open()
                query_eksekusi = "SELECT id_kontak FROM tb_grup_kontak_member WHERE id_grup_kontak='" & item(CLBGrupKontak.ValueMember).ToString & "'"
                list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
                koneksi.Close()

                dset_eksekusi = New DataSet
                list_eksekusi.Fill(dset_eksekusi, "data")
                n = dset_eksekusi.Tables("data").Rows.Count
                For i = 0 To n - 1
                    koneksi.Open()
                    query = "SELECT no_hp FROM tb_kontak WHERE id_kontak='" & dset_eksekusi.Tables("data").Rows(i)(0).ToString() & "'"
                    command = koneksi.CreateCommand()
                    command.CommandText = query
                    reader = command.ExecuteReader()
                    reader.Read()
                    nomor = reader.GetValue(0).ToString
                    koneksi.Close()
                    If a = x And i = n - 1 Then
                        nomor_simpan = nomor_simpan & nomor
                    Else
                        nomor_simpan = nomor_simpan & nomor & ";"
                    End If
                Next

                list_eksekusi.Dispose()
                dset_eksekusi.Dispose()
                a = a + 1
            Next item
            koneksi.Dispose()
            FormSMS.TBNoTujuan.Text = nomor_simpan
            Me.Close()
            Me.Dispose()
        Else
            XtraMessageBox.Show("Pilih minimal satu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class