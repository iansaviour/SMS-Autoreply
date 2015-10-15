Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Public Class FormSMS
    Inherits DevExpress.XtraEditors.XtraForm

    Private Sub FormSMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refresh_inbox()
        refresh_SentItem()
        refresh_outbox()
    End Sub
    Private Sub BDeleteInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteInbox.Click
        delete_inbox(Me.GVInbox.GetFocusedRowCellDisplayText("ID").ToString())
        refresh_inbox()
    End Sub
    Sub delete_inbox(ByVal id_sms As String)
        Dim koneksi As New MySqlConnection(conn_db)
        koneksi.Open()
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String = "DELETE FROM inbox WHERE ID='" & id_sms & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
    End Sub
    Sub delete_outbox(ByVal id_sms As String)
        Dim koneksi As New MySqlConnection(conn_db)
        koneksi.Open()
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String
        query = "DELETE FROM outbox_multipart WHERE ID='" & id_sms & "'"
        command.CommandText = query
        command.ExecuteNonQuery()

        query = "DELETE FROM outbox WHERE ID='" & id_sms & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
    End Sub
    Sub delete_sentitems(ByVal id_sms As String)
        Dim koneksi As New MySqlConnection(conn_db)
        koneksi.Open()
        Dim command As MySqlCommand = koneksi.CreateCommand
        Dim query As String = "DELETE FROM sentitems WHERE ID='" & id_sms & "'"
        command.CommandText = query
        command.ExecuteNonQuery()
        koneksi.Close()
    End Sub
    Sub refresh_inbox()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT inbox.ID,IF(tb_kontak.nama_kontak IS NULL,inbox.SenderNumber,tb_kontak.nama_kontak) AS 'Pengirim',inbox.TextDecoded AS 'Text' , DATE(inbox.ReceivingDateTime) AS 'Receive Date', Time(inbox.ReceivingDateTime) AS 'Receive Time' , inbox.RecipientID as 'Modem' FROM inbox LEFT JOIN tb_kontak ON inbox.SenderNumber=tb_kontak.no_hp GROUP BY inbox.id ORDER BY inbox.ID DESC"
        Dim adapter As New MySqlDataAdapter(query, koneksi)
        koneksi.Open()
        adapter.Fill(data, "data")
        If data.Tables("data").Rows.Count = 0 Then
            Me.BDeleteInbox.Visible = False
        Else
            Me.BDeleteInbox.Visible = True
        End If
        Me.GCInbox.DataSource = data.Tables("data")
        Me.GVInbox.Columns("ID").Visible = False
        koneksi.Close()
        data.Dispose()
        adapter.Dispose()
        koneksi.Dispose()
    End Sub
    Sub refresh_SentItem()
        Dim koneksi As New MySqlConnection(conn_db)
        Dim data As New DataSet
        Dim query As String = "SELECT sentitems.ID,IF(tb_kontak.nama_kontak IS NULL,sentitems.DestinationNumber,tb_kontak.nama_kontak) AS 'Tujuan',sentitems.TextDecoded AS 'Text',DATE(sentitems.SendingDateTime) AS 'Sending Date' ,TIME(sentitems.SendingDateTime) AS 'Sending Time' , Status AS 'Status', SenderID as 'Modem' FROM sentitems LEFT JOIN tb_kontak ON sentitems.DestinationNumber=tb_kontak.no_hp GROUP BY sentitems.id ORDER BY SendingDateTime DESC"
        Dim adapter As New MySqlDataAdapter(query, koneksi)

        koneksi.Open()
        adapter.Fill(data, "data")
        If data.Tables("data").Rows.Count = 0 Then
            Me.BDeleteSent.Visible = False
        Else
            Me.BDeleteSent.Visible = True
        End If
        Me.GCSentItem.DataSource = data.Tables("data")
        Me.GVSentItem.Columns("ID").Visible = False
        koneksi.Close()
        data.Dispose()
        adapter.Dispose()
        koneksi.Dispose()
    End Sub
    Sub refresh_outbox()
        Dim query As String = "SELECT outbox.ID, IF(tb_kontak.nama_kontak IS NULL,outbox.DestinationNumber,tb_kontak.nama_kontak) AS 'Tujuan' ,outbox.TextDecoded AS 'Text',DATE(outbox.SendingDateTime) AS 'Sending Date', TIME(outbox.SendingDateTime) AS 'Sending Time','pending' AS 'Status',outbox.MultiPart FROM outbox LEFT JOIN tb_kontak ON outbox.DestinationNumber=tb_kontak.no_hp GROUP BY outbox.id ORDER BY outbox.ID DESC"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Dim data_temp As DataTable
        Dim temp_text As String = ""

        
        If data.Rows.Count = 0 Then
            Me.BDeleteOutbox.Visible = False
        Else
            For i As Integer = 0 To (data.Rows.Count - 1)
                If data.Rows(i)("MultiPart").ToString = "true" Then
                    temp_text = data.Rows(i)("Text").ToString
                    query = "SELECT * FROM outbox_multipart WHERE ID='" & data.Rows(i)("ID").ToString & "' ORDER BY SequencePosition"
                    data_temp = execute_query(query, -1, True, "", "", "", "")
                    For j As Integer = 0 To (data_temp.Rows.Count - 1)
                        temp_text = temp_text & data_temp.Rows(j)("TextDecoded").ToString
                    Next

                    data.Rows(i)("Text") = temp_text
                End If
            Next
            Me.BDeleteOutbox.Visible = True
        End If
        Me.GCOutbox.DataSource = data
        Me.GVOutbox.Columns("ID").Visible = False
        Me.GVOutbox.Columns("MultiPart").Visible = False
    End Sub

    Private Sub BRefreshInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefreshInbox.Click
        refresh_inbox()
    End Sub

    Private Sub BDeleteSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteSent.Click
        delete_sentitems(Me.GVSentItem.GetFocusedRowCellDisplayText("ID").ToString)

        refresh_SentItem()
    End Sub

    Private Sub TEIsiSMS_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEIsiSMS.EditValueChanged
        Dim jml_huruf = Me.TEIsiSMS.Text.Count()
        Dim jml_sms = Math.Ceiling(jml_huruf / 153)
        If jml_sms = 0 Then
            jml_sms = 1
        End If
        Me.LJmlSms.Text = jml_huruf & "(" & jml_sms & ")"
    End Sub

    Private Sub BSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSend.Click
        Cursor = Cursors.WaitCursor
        Try
            Dim koneksi As New MySqlConnection(conn_db)
            Dim text_sms As String = Me.TEIsiSMS.Text
            Dim jml_huruf = Me.TEIsiSMS.Text.Count
            Dim no_tujuan = Me.TBNoTujuan.Text
            Dim jml_sms = Math.Ceiling(jml_huruf / 153)
            Dim command As MySqlCommand
            Dim query, query_ID As String
            Dim reader As MySqlDataReader
            Dim udh As String
            Dim ID As Integer
            Dim sender_ID As String = sender_default_id()


            If Not no_tujuan = "" Then
                ' Split string based on spaces
                Dim nomors As String() = no_tujuan.Split(New Char() {";"c})

                ' Use For Each loop over words and display them
                Dim nomor As String
                For Each nomor In nomors
                    If jml_sms = 1 Then
                        koneksi.Open()
                        command = koneksi.CreateCommand
                        query = "INSERT INTO outbox(DeliveryReport,TextDecoded,DestinationNumber,CreatorID,SenderID) VALUE ('" & delivery_report & "','" & text_sms & "','" & nomor & "','1','" & sender_ID & "')"
                        command.CommandText = query
                        command.ExecuteNonQuery()
                        koneksi.Close()
                    Else
                        koneksi.Open()
                        query_ID = "SHOW TABLE STATUS LIKE 'outbox'"
                        command = koneksi.CreateCommand()
                        command.CommandText = query_ID
                        reader = command.ExecuteReader()
                        reader.Read()
                        ID = reader.GetValue(10).ToString
                        koneksi.Close()

                        koneksi.Open()
                        command = koneksi.CreateCommand()
                        Dim StringArray() As String
                        StringArray = SplitString(text_sms, 153)
                        For i = 1 To jml_sms
                            udh = String.Format("050003A7{0:00}{1:00}", jml_sms, i)
                            If i = 1 Then
                                query = "INSERT INTO outbox (DeliveryReport,DestinationNumber, UDH, TextDecoded, ID, MultiPart, CreatorID, SenderID) VALUE ('" & delivery_report & "','" & nomor & "','" & udh & "','" & StringArray(i - 1) & "','" & ID & "','true','1','" & sender_ID & "')"
                                command.CommandText = query
                                command.ExecuteNonQuery()
                            Else
                                query = "INSERT INTO outbox_multipart (UDH, TextDecoded, ID, SequencePosition) VALUE ('" & udh & "','" & StringArray(i - 1) & "','" & ID & "','" & i & "')"
                                command.CommandText = query
                                command.ExecuteNonQuery()
                            End If
                        Next i
                        koneksi.Close()
                    End If
                Next
                Me.TEIsiSMS.Text = ""
                Me.TBNoTujuan.Text = ""
                TCMessage.SelectedTabPageIndex = 3
                refresh_outbox()
            Else
                XtraMessageBox.Show("Nomor tujuan harap diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Cursor = Cursors.Default
    End Sub
    Public Function SplitString(ByVal TheString As String, ByVal StringLen As Integer) As String()
        Dim ArrCount As Integer  'as it is declared locally, it will automatically reset to 0 when this is called again
        Dim I As Long  'we are going to use it.. so declare it (with local scope to avoid breaking other code)
        Dim TempArray() As String
        ReDim TempArray((Len(TheString) - 1) \ StringLen)
        For I = 1 To Len(TheString) Step StringLen
            TempArray(ArrCount) = Mid$(TheString, I, StringLen)
            ArrCount = ArrCount + 1
        Next
        SplitString = TempArray   'actually return the value
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        FormSelectContact.ShowDialog()
    End Sub

    Private Sub BRefreshSent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefreshSent.Click
        refresh_SentItem()
    End Sub

    Private Sub BRefreshOutbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRefreshOutbox.Click
        refresh_outbox()
    End Sub

    Private Sub BDeleteOutbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDeleteOutbox.Click
        delete_outbox(Me.GVOutbox.GetFocusedRowCellDisplayText("ID").ToString)

        refresh_outbox()
    End Sub

    Private Sub GVOutbox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVOutbox.DoubleClick
        If BDeleteOutbox.Visible = True Then
            FormSMSDetail.TBNomor.Text = Me.GVOutbox.GetFocusedRowCellDisplayText("Tujuan").ToString()
            FormSMSDetail.LCDatetime.Text = Me.GVOutbox.GetFocusedRowCellDisplayText("Sending Date").ToString() & " " & Me.GVOutbox.GetFocusedRowCellDisplayText("Sending Time").ToString()
            FormSMSDetail.TEIsiSMS.Text = Me.GVOutbox.GetFocusedRowCellDisplayText("Text").ToString()
            FormSMSDetail.ShowDialog()
        End If
    End Sub

    Private Sub GVSentItem_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVSentItem.DoubleClick
        If BDeleteSent.Visible = True Then
            FormSMSDetail.TBNomor.Text = Me.GVSentItem.GetFocusedRowCellDisplayText("Tujuan").ToString()
            FormSMSDetail.LCDatetime.Text = Me.GVSentItem.GetFocusedRowCellDisplayText("Sending Date").ToString() & " " & Me.GVSentItem.GetFocusedRowCellDisplayText("Sending Time").ToString()
            FormSMSDetail.TEIsiSMS.Text = Me.GVSentItem.GetFocusedRowCellDisplayText("Text").ToString()
            FormSMSDetail.ShowDialog()
        End If
    End Sub

    Private Sub GVInbox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVInbox.DoubleClick
        If BDeleteInbox.Visible = True Then
            FormSMSDetail.TBNomor.Text = Me.GVInbox.GetFocusedRowCellDisplayText("Pengirim").ToString()
            FormSMSDetail.LCDatetime.Text = Me.GVInbox.GetFocusedRowCellDisplayText("Receive Date").ToString() & " " & Me.GVInbox.GetFocusedRowCellDisplayText("Receive Time").ToString()
            FormSMSDetail.TEIsiSMS.Text = Me.GVInbox.GetFocusedRowCellDisplayText("Text").ToString()
            FormSMSDetail.ShowDialog()
        End If
    End Sub

    Private Sub BPrintOutbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintOutbox.Click
        print(GCOutbox, "Outbox")
    End Sub

    Private Sub BPrintSentItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintSentItems.Click
        print(GCSentItem, "Sent Items")
    End Sub

    Private Sub BPrintInbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPrintInbox.Click
        print(GCInbox, "Inbox")
    End Sub

    Private Sub BBCContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormSelectContact.ShowDialog()
    End Sub
End Class