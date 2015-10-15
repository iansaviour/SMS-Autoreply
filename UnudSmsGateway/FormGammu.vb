Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports System.Text

Public Class FormGammu
    Private Sub BTambahModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambahModem.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            FormAddModem.Text = "New Modem"
            FormAddModem.ShowDialog()
            FormAddModem.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub FormGammu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_modem()
    End Sub
    Sub refresh_modem()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT id_modem,nama_modem as 'Nama Modem',nomor as 'Nomor HP', IF(is_default=1,'Ya','Tidak') as 'Default' FROM tb_modem ORDER BY id_modem ASC"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        Try
            koneksi.Open()
            adapter.Fill(data, "data")
            Me.GCModem.DataSource = data.Tables("data")
            Me.GVModem.Columns("id_modem").Visible = False
            koneksi.Close()
            If GVModem.RowCount.ToString() = "0" Then
                Me.BEditModem.Visible = False
                Me.BHapusModem.Visible = False
                Me.BDefault.Visible = False
            Else
                Me.BHapusModem.Visible = True
                Me.BEditModem.Visible = True
                Me.BDefault.Visible = True
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Server database tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BEditModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditModem.Click
        FormAddModem.Text = "Edit Modem"
        FormAddModem.ShowDialog()
    End Sub

    Private Sub BHapusModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHapusModem.Click
        Dim id_modem As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String
       
        id_modem = Me.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString

        If Me.GVModem.GetFocusedRowCellDisplayText("Default").ToString = "Ya" Then
            MsgBox("Tidak dapat menghapus default modem")
        Else
            'hapus dulu
            koneksi.Open()
            command = koneksi.CreateCommand
            query = "DELETE FROM tb_modem WHERE id_modem='" & id_modem & "'"
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            'end hapus

            reload_modem()

            Me.refresh_modem()
        End If
    End Sub

    Private Sub BDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDefault.Click
        Dim id_modem As String
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim query As String
        id_modem = Me.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString
        koneksi.Open()
        command = koneksi.CreateCommand
        query = "UPDATE tb_modem SET is_default='2'"
        command.CommandText = query
        command.ExecuteNonQuery()
        query = "UPDATE tb_modem SET is_default='1' WHERE id_modem='" & id_modem & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
        Me.refresh_modem()
    End Sub

    Private Sub BCekPulsa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCekPulsa.Click
        If RibbonForm.is_use_gammu = "1" Then
            RibbonForm.TimerGeneral.Enabled = False
            StopService()
            Dim id_modem As String = Me.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString
            Dim query As String = String.Format("SELECT nama_modem,cek_pulsa,direktori FROM tb_modem WHERE id_modem='" & id_modem & "'")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            Dim cek_pulsa As String = data.Rows(0)("cek_pulsa").ToString
            Dim direktori As String = data.Rows(0)("direktori").ToString

            Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
            System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\cek_pulsa.bat")
            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendLine("chdir " & direktori & "\bin")
            sb.AppendLine("gammu -c smsdrc" & id_modem & " getussd " & cek_pulsa)
            sb.AppendLine("pause")
            sb.AppendLine("exit")
            Using outfile As StreamWriter = New StreamWriter(mydocpath + "\cek_pulsa.bat", True)
                outfile.Write(sb.ToString)
            End Using
            Try
                Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\cek_pulsa.bat")
                Dim process As Process = process.Start(psi)
                process.Dispose()
            Catch ex As Exception
            End Try
            RibbonForm.TimerGeneral.Enabled = True
        Else
            MsgBox("Not available for this service.")
        End If
    End Sub

    Private Sub BNetwork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNetwork.Click
        If RibbonForm.is_use_gammu = "1" Then
            Me.Cursor = Cursors.WaitCursor
            RibbonForm.TimerGeneral.Enabled = False
            StopService()
            Dim id_modem As String = Me.GVModem.GetFocusedRowCellDisplayText("id_modem").ToString
            Dim query As String = String.Format("SELECT direktori FROM tb_modem WHERE id_modem='" & id_modem & "'")
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")
            Dim direktori As String = data.Rows(0)("direktori").ToString

            Dim mydocpath As String = My.Application.Info.DirectoryPath.ToString
            System.IO.File.Delete(My.Application.Info.DirectoryPath.ToString & "\cek_network.bat")
            Dim sb As StringBuilder = New StringBuilder()
            sb.AppendLine("chdir " & direktori & "\bin")
            sb.AppendLine("gammu -c smsdrc" & id_modem & " monitor 1")
            sb.AppendLine("pause")
            sb.AppendLine("exit")
            Using outfile As StreamWriter = New StreamWriter(mydocpath + "\cek_network.bat", True)
                outfile.Write(sb.ToString)
            End Using
            Try
                Dim psi As New ProcessStartInfo(My.Application.Info.DirectoryPath.ToString() & "\cek_network.bat")
                Dim process As Process = process.Start(psi)
                process.Dispose()
            Catch ex As Exception
            End Try
            RibbonForm.TimerGeneral.Enabled = True
            Me.Cursor = Cursors.Default
        Else
            MsgBox("Not available for this service.")
        End If
    End Sub

    Private Sub BNmr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNmr.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            FormGammuNomor.Text = "Nomor dibalas"
            FormGammuNomor.ShowDialog()
            FormGammuNomor.Focus()
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class