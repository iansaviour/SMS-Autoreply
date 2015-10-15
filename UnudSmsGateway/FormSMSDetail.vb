Public Class FormSMSDetail 
    Private Sub FormSMSDetail_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        FormSMS.TBNoTujuan.Text = Me.TBNomor.Text
        FormSMS.TEIsiSMS.Text = ""
        FormSMS.TCMessage.SelectedTabPageIndex = 0
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        FormSMS.TEIsiSMS.Text = Me.TEIsiSMS.Text
        FormSMS.TBNoTujuan.Text = ""
        FormSMS.TCMessage.SelectedTabPageIndex = 0
        Me.Close()
    End Sub
End Class