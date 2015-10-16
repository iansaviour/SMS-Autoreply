Public Class FormSchedulerAdd 
    Public id_event As String = "-1"
    Private Sub FormSchedulerAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        action_load()
    End Sub

    Sub action_load()
        SE_load_status_aktif(LEStatus)
        If id_event = "-1" Then 'new
            XTPJadwal.PageVisible = False
            XTPNomor.PageVisible = False
        Else
            XTPJadwal.PageVisible = True
            XTPNomor.PageVisible = True

            Dim query As String = "SELECT * FROM tb_event WHERE id_event='" + id_event + "'"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

            If data.Rows.Count > 0 Then
                TENama.Text = data.Rows(0)("event_name").ToString
                MEDesc.Text = data.Rows(0)("event_desc").ToString
                MEPesan.Text = data.Rows(0)("event_message").ToString

                LEStatus.EditValue = data.Rows(0)("event_status").ToString
            End If

            load_schedule()
            load_kontak()
        End If
    End Sub

    Sub load_schedule()
        Dim query As String = "SELECT id_event_meta, CAST(FROM_UNIXTIME(repeat_start) AS DATETIME) AS start_date, repeat_start,repeat_interval,repeat_year,IF(repeat_month='*','*',MONTHNAME(STR_TO_DATE(repeat_month,'%m'))) as repeat_month,repeat_day,repeat_week,IF(repeat_weekday='*','*',ELT(repeat_weekday, 'Minggu', 'Senin', 'Selasa', 'Rabu', 'Kamis', 'Jumat', 'Sabtu')) as repeat_weekday,repeat_hour,repeat_minute,"
        query += " CONCAT(FLOOR(HOUR(SEC_TO_TIME(repeat_interval)) / 24), ' days ',MOD(HOUR(SEC_TO_TIME(repeat_interval)), 24), ' hours ',MINUTE(SEC_TO_TIME(repeat_interval)), ' minutes ',SECOND(SEC_TO_TIME(repeat_interval)), ' seconds') AS `interval`"
        query += " FROM tb_event_meta"
        query += " WHERE id_event='" + id_event + "'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        GCSchedule.DataSource = data
        If data.Rows.Count > 0 Then
            GVSchedule.BestFitColumns()
            BEditSchedule.Visible = True
            BDelSchedule.Visible = True
        Else
            BEditSchedule.Visible = False
            BDelSchedule.Visible = False
        End If
    End Sub

    Sub load_kontak()
        Dim query As String = "SELECT tb_event_kontak.id_event_kontak,tb_kontak.* FROM tb_event_kontak"
        query += " INNER JOIN tb_kontak ON tb_kontak.id_kontak = tb_event_kontak.id_kontak"
        query += " WHERE tb_event_kontak.id_event='" + id_event + "'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        GCKontak.DataSource = data
        If data.Rows.Count > 0 Then
            GVKontak.BestFitColumns()
            BDeleteKontak.Visible = True
        Else
            BDeleteKontak.Visible = False
        End If
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub FormSchedulerAdd_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddSchedule.Click
        FormSchedulerTimer.id_event = id_event
        FormSchedulerTimer.ShowDialog()
    End Sub

    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Dim query As String

        If id_event = "-1" Then 'new
            query = "INSERT INTO tb_event(event_name,event_desc,event_message,event_status) VALUES('" + TENama.Text + "','" + MEDesc.Text + "','" + MEPesan.Text + "','" + LEStatus.EditValue.ToString + "');SELECT LAST_INSERT_ID(); "
            id_event = execute_query(query, 0, True, "", "", "", "")
            infoCustom("Schedule created")
        Else 'edit
            query = "UPDATE tb_event SET event_name='" + TENama.Text + "',event_desc='" + MEDesc.Text + "',event_message='" + MEPesan.Text + "',event_status='" + LEStatus.EditValue.ToString + "'); "
            execute_non_query(query, True, "", "", "", "")
            infoCustom("Schedule updated")
        End If

        action_load()
        FormScheduler.view_scheduler()
        FormScheduler.GVSchedule.FocusedRowHandle = find_row(FormScheduler.GVSchedule, "id_event", id_event)
    End Sub

    Private Sub BAddKontak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddKontak.Click
        FormMemberKontak.id_pop_up = "2"
        FormMemberKontak.ShowDialog()
    End Sub

    Private Sub BDeleteKontak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteKontak.Click
        If ask_msgbox("Anda yakin ingin menghapus kontak dari schedule ini?") Then
            Dim id_event_kontak As String = GVKontak.GetFocusedRowCellValue("id_event_kontak").ToString

            Dim query As String = "DELETE FROM tb_event_kontak WHERE id_event_kontak='" + id_event_kontak + "'"
            execute_non_query(query, True, "", "", "", "")
            load_kontak()
        End If
    End Sub

    Private Sub BDelSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelSchedule.Click
        If ask_msgbox("Anda yakin ingin menghapus jadwal dari schedule ini?") Then
            Dim id_event_meta As String = GVSchedule.GetFocusedRowCellValue("id_event_meta").ToString

            Dim query As String = "DELETE FROM tb_event_meta WHERE id_event_meta='" + id_event_meta + "'"
            execute_non_query(query, True, "", "", "", "")
            load_schedule()
        End If
    End Sub

    Private Sub BEditSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditSchedule.Click
        FormSchedulerTimer.id_event = id_event
        FormSchedulerTimer.id_event_meta = GVSchedule.GetFocusedRowCellValue("id_event_meta").ToString
        FormSchedulerTimer.ShowDialog()
    End Sub
End Class