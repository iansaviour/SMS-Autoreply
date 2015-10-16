Public Class FormSchedulerTimer 
    Public id_event_meta As String = "-1"
    Public id_event As String = "-1"

    Private Sub FormSchedulerTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        action_load()
    End Sub
    Sub action_load()
        SE_load_min(LEMin)
        SE_load_hour(LEHr)
        SE_load_dow(LEDow)
        SE_load_date(LEDom)
        SE_load_month(LEMonth)
        SE_load_week(LEWeek)
        '
        SE_load_intsec(SEIntSec)
        SE_load_intmin(SEIntMenit)
        SE_load_inthr(SEIntJam)
        '
        If id_event_meta = "-1" Then 'new
        Else 'edit
            Dim query As String = "SELECT CAST(FROM_UNIXTIME(repeat_start) AS DATETIME) AS start_date,FLOOR(HOUR(SEC_TO_TIME(repeat_interval)) / 24) AS `days`,MOD(HOUR(SEC_TO_TIME(repeat_interval)), 24) AS `hours`,MINUTE(SEC_TO_TIME(repeat_interval)) AS  `minutes`,SECOND(SEC_TO_TIME(repeat_interval)) AS `seconds`,tb_event_meta.* FROM tb_event_meta WHERE id_event_meta='" + id_event_meta + "'"
            Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

            DEStart.EditValue = data.Rows(0)("start_date")
            SEIntDay.EditValue = data.Rows(0)("days")
            SEIntJam.EditValue = data.Rows(0)("hours")
            SEIntMenit.EditValue = data.Rows(0)("minutes")
            SEIntSec.EditValue = data.Rows(0)("seconds")

            LEDom.EditValue = data.Rows(0)("repeat_day")
            LEMonth.EditValue = data.Rows(0)("repeat_month")
            LEDow.EditValue = data.Rows(0)("repeat_weekday")
            LEWeek.EditValue = data.Rows(0)("repeat_week")
            LEHr.EditValue = data.Rows(0)("repeat_hour")
            LEHr.EditValue = data.Rows(0)("repeat_minute")
        End If
    End Sub
    Private Sub BSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        Dim query As String = ""

        Dim date_start As Date = DEStart.EditValue
        Dim s_date_start As String = date_start.ToString("yyyy-MM-dd HH:mm:ss")

        Dim int_hour As Integer = 0
        Dim int_minute As Integer = 0
        Dim int_sec As Integer = 0

        int_hour = (SEIntDay.EditValue * 24) + SEIntJam.EditValue
        int_minute = SEIntMenit.EditValue
        int_sec = SEIntSec.EditValue

        Dim interval_string As String = int_hour.ToString + ":" + int_minute.ToString + ":" + int_sec.ToString

        If id_event_meta = "-1" Then 'new
            query = "INSERT INTO tb_event_meta(id_event,repeat_start,repeat_interval,repeat_year,repeat_month,repeat_day,repeat_week,repeat_weekday,repeat_hour,repeat_minute) VALUES('" + id_event + "',UNIX_TIMESTAMP('" + s_date_start + "'),TIME_TO_SEC('" + interval_string + "'),'*','" + LEMonth.EditValue.ToString + "','" + LEDom.EditValue.ToString + "','" + LEWeek.EditValue.ToString + "','" + LEDow.EditValue.ToString + "','" + LEHr.EditValue.ToString + "','" + LEMin.EditValue.ToString + "');SELECT LAST_INSERT_ID(); "
            id_event_meta = execute_query(query, 0, True, "", "", "", "")
            infoCustom("Schedule created")
        Else 'edit
            query = "UPDATE tb_event_meta SET repeat_start=UNIX_TIMESTAMP('" + s_date_start + "'),repeat_interval=TIME_TO_SEC('" + interval_string + "'),repeat_year='*',repeat_month='" + LEMonth.EditValue.ToString + "',repeat_day='" + LEDom.EditValue.ToString + "',repeat_week='" + LEWeek.EditValue.ToString + "',repeat_weekday='" + LEDow.EditValue.ToString + "',repeat_hour='" + LEHr.EditValue.ToString + "',repeat_minute='" + LEMin.EditValue.ToString + "' WHERE id_event_meta='" + id_event_meta + "'; "
            execute_non_query(query, True, "", "", "", "")
            infoCustom("Schedule updated")
        End If

        FormSchedulerAdd.load_schedule()
        FormSchedulerAdd.GVSchedule.FocusedRowHandle = find_row(FormSchedulerAdd.GVSchedule, "id_event_meta", id_event_meta)
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub FormSchedulerTimer_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub
End Class