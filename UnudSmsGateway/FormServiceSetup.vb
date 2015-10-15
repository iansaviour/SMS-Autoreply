Public Class FormServiceSetup 

    Private Sub FormServiceSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If RibbonForm.is_use_gammu = "1" Then
            RadioGroup1.EditValue = "1"
        Else
            RadioGroup1.EditValue = "2"
        End If
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Try
            Cursor = Cursors.WaitCursor
            If has_start_service = 1 Then
                StopService()
            End If
            If RadioGroup1.EditValue = "1" Then
                RibbonForm.is_use_gammu = "1"
            Else
                RibbonForm.is_use_gammu = "2"
            End If
            StartService()
            Cursor = Cursors.Default
            Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Close()
    End Sub

    Private Sub FormServiceSetup_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
        If has_start_service = 0 Then
            End
        End If
    End Sub
End Class