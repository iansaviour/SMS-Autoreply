Public Class FormScheduler 

    Private Sub BTambahModem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTambahSchedule.Click
        FormSchedulerAdd.ShowDialog()
    End Sub

    Private Sub FormScheduler_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        view_scheduler()
    End Sub

    Sub view_scheduler()
        Dim query As String = "SELECT id_event,event_name,event_desc,IF(event_status=1,'Aktif','Tidak Aktif') as event_status FROM tb_event"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        GCSchedule.DataSource = data
        If data.Rows.Count > 0 Then
            GVSchedule.BestFitColumns()
            BHapusSchedule.Visible = True
            BEditSchedule.Visible = True
        Else
            BHapusSchedule.Visible = False
            BEditSchedule.Visible = False
        End If
    End Sub

    Private Sub BEditSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BEditSchedule.Click
        FormSchedulerAdd.id_event = GVSchedule.GetFocusedRowCellValue("id_event").ToString
        FormSchedulerAdd.ShowDialog()
    End Sub

    Private Sub BHapusSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BHapusSchedule.Click
        If ask_msgbox("Are you sure want to delete this schedule ?") Then
            Dim id_event As String = GVSchedule.GetFocusedRowCellValue("id_event").ToString

            Dim query As String = "DELETE FROM tb_event WHERE id_event='" + id_event + "'"
            execute_non_query(query, True, "", "", "", "")
            view_scheduler()
        End If
    End Sub
End Class