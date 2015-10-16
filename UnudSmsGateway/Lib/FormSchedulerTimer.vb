Public Class FormSchedulerTimer 

    Private Sub FormSchedulerTimer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SE_load_min(LEMin)
        SE_load_hour(LEHr)
        SE_load_dow(LEDow)
        SE_load_date(LEDom)
        SE_load_month(LEMonth)

    End Sub
End Class