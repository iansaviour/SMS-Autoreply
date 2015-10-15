Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormPemisah
    Dim query_eksekusi, pemisah, nama_app_ym, nama_aplikasi, x_hari, balas_spam, broadcast_keyword, normal_broadcast As String
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub FormPemisah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim list_eksekusi As MySqlDataAdapter
        Dim dset_eksekusi As DataSet

        Try
            koneksi.Open()

            query_eksekusi = "SELECT nama_app_ym,nama_app_sms,char_pemisah,balas_spam,sms_x_hari_kosongkan,keyword_broadcast,normal_broadcast FROM tb_option LIMIT 1"
            list_eksekusi = New MySqlDataAdapter(query_eksekusi, koneksi)
            dset_eksekusi = New DataSet
            list_eksekusi.Fill(dset_eksekusi, "data")
            If dset_eksekusi.Tables("data").Rows.Count = 0 Then
                nama_aplikasi = "Unud SMS Gateway"
                x_hari = "7"
                balas_spam = "0"
                pemisah = "#"
                nama_app_ym = "YM Auto Respond"
                broadcast_keyword = "BROADCAST"
            Else
                nama_aplikasi = dset_eksekusi.Tables("data").Rows(0)("nama_app_sms").ToString()
                x_hari = dset_eksekusi.Tables("data").Rows(0)("sms_x_hari_kosongkan").ToString()
                balas_spam = dset_eksekusi.Tables("data").Rows(0)("balas_spam").ToString()
                pemisah = dset_eksekusi.Tables("data").Rows(0)("char_pemisah").ToString()
                nama_app_ym = dset_eksekusi.Tables("data").Rows(0)("nama_app_ym").ToString()
                broadcast_keyword = dset_eksekusi.Tables("data").Rows(0)("keyword_broadcast").ToString()
                normal_broadcast = dset_eksekusi.Tables("data").Rows(0)("normal_broadcast").ToString()
            End If

            koneksi.Close()
            koneksi.Dispose()

            TEPemisah.Text = pemisah
            TEBroadcastKw.Text = normal_broadcast
            TEBroadcastOperasi.Text = broadcast_keyword
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Dim karakter, bc_kw, query, norm_bc As String
        karakter = TEPemisah.Text.ToString
        bc_kw = TEBroadcastOperasi.Text.ToString
        norm_bc = TEBroadcastKw.Text.ToString
        If karakter.Length <> 1 Or karakter = " " Or karakter = "=" Or karakter = "~" Or karakter = "," Or karakter = "." Or karakter = "'" Then
            XtraMessageBox.Show("Karakter pemisah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf bc_kw.Length < 1 Or bc_kw = "" Then
            XtraMessageBox.Show("Keyword untuk broadcast tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                query = String.Format("UPDATE tb_option SET char_pemisah='" & karakter & "',keyword_broadcast='" & bc_kw & "',normal_broadcast='" & norm_bc & "'")
                execute_non_query(query, True, "", "", "", "")
                Me.Close()
                Me.Dispose()
            Catch ex As Exception
                XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub FormPemisah_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class