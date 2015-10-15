Public Class FormSchedulerAdd 

    Private Sub FormSchedulerAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SE_load_min(LEMin)
        SE_load_hour(LEHr)
        SE_load_dow(LEDow)
        SE_load_date(LEDom)
        SE_load_month(LEMonth)
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub FormSchedulerAdd_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub Badd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badd.Click
        'add

    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        'delete from query

    End Sub
End Class