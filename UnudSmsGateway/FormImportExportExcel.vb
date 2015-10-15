Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class FormImportExportExcel
    Private dataset_field As DataSet
    Public host As String = ""
    Public usn As String = ""
    Public pwd As String = ""
    Public dbs As String = ""
    Public connx = "Database=" & dbs & ";Data Source=" & host & ";User Id=" & usn & ";Password=" & pwd & ";Convert Zero Datetime=True"
    Public hosty As String = ""
    Public usny As String = ""
    Public pwdy As String = ""
    Public dbsy As String = ""
    Public conny = "Database=" & dbsy & ";Data Source=" & hosty & ";User Id=" & usny & ";Password=" & pwdy & ";Convert Zero Datetime=True"

    Private Sub FormImportExportExcel_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private t As Threading.Thread
    Private Delegate Sub del_update_progressbar(ByVal process_row As Integer)
    Private Delegate Sub del_finish_messege(ByVal error_num As Integer, ByVal mess_code As Integer)
    Private no_warn As Boolean = False
    Private is_finish_import As Boolean = True
    Public DtSet As DataSet
    Private id_new_ref_table As Integer
    Private table_name As String

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Me.Cursor = Cursors.WaitCursor
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Select excel file to import"
        fdlg.InitialDirectory = "C:\"
        fdlg.Filter = "Excel File|*.xls; *.xlsx"
        fdlg.FilterIndex = 0
        fdlg.RestoreDirectory = True
        Me.Cursor = Cursors.Default
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.TBFileAddress.Text = fdlg.FileName
        End If
    End Sub

    Private Sub TBFileAddress_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBFileAddress.EditValueChanged
        fill_combo_worksheet()
        Me.BStartImport.Enabled = True
    End Sub

    Private Sub FormImportExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setting_grid()
    End Sub

    Private Sub CBWorksheetName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBWorksheetName.SelectedIndexChanged
        fill_field_grid()
    End Sub

    Private Sub FormImportExcel_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Dispose()
    End Sub

    Private Sub BStartImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BStartImport.Click
        If TBTableName.Text = "" Then
            XtraMessageBox.Show("Input nama tabel tujuan !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not cek_grid_ready() Then
            XtraMessageBox.Show("Mohon cek kembali detail field tujuan ! " & vbNewLine & "Nama field, tipe data, dan length harus diisi dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Cursor = Cursors.WaitCursor
            Dim pass As Boolean = create_table()
            If pass = True Then
                'id_new_ref_table = FormImportExcelModule.new_reference()
                table_name = Me.TBTableName.Text

                Me.is_finish_import = False
                Me.TBTableName.Enabled = False
                Me.MemoDescription.Enabled = False
                Me.BStartImport.Enabled = False
                Me.BBrowse.Enabled = False
                Me.CBWorksheetName.Enabled = False
                Me.CheckSurrogateKey.Enabled = False
                Me.GCFieldSetting.Enabled = False

                t = New Threading.Thread(AddressOf import_excel)
                t.IsBackground = True
                t.Start()

            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TBFileAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBFileAddress.Click
        Me.Cursor = Cursors.WaitCursor
        Dim fdlg As OpenFileDialog = New OpenFileDialog()
        fdlg.Title = "Select excel file to import"
        fdlg.InitialDirectory = "C:\"
        fdlg.Filter = "Excel File|*.xls; *.xlsx"
        fdlg.FilterIndex = 0
        fdlg.RestoreDirectory = True
        Me.Cursor = Cursors.Default
        If fdlg.ShowDialog() = DialogResult.OK Then
            Me.TBFileAddress.Text = fdlg.FileName
        End If
    End Sub

    Private Sub CheckSurrogateKey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSurrogateKey.CheckedChanged
        If Me.CheckSurrogateKey.Checked = True Then
            For i As Integer = 0 To Me.GVFieldSetting.RowCount - 1
                Me.GVFieldSetting.SetRowCellValue(i, "primary_key", False)
            Next
            Me.GVFieldSetting.Columns(5).OptionsColumn.AllowEdit = False
        Else
            Me.GVFieldSetting.Columns(5).OptionsColumn.AllowEdit = True
        End If
    End Sub

    Private Sub FormImportExcel_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        If is_finish_import = False Then
            result = XtraMessageBox.Show("This current extracting process still running!" & Environment.NewLine & "Are you sure want to stop this process?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = Windows.Forms.DialogResult.Yes Then
                no_warn = True
                Try
                    t.Abort()
                Catch ex As Exception
                End Try
                Me.Cursor = Cursors.WaitCursor
                If Me.CheckSurrogateKey.Checked = True Then
                    add_auto_num_key()
                End If
                'FormReferenceTable.Enabled = True
                'FormReferenceTableModule.fill_table_list()
                'FormReferenceTable.LBTableList.SelectedValue = id_new_ref_table
                Me.Cursor = Cursors.Default
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    '=========================================================================================

    Sub update_progress_bar(ByVal process_row As Integer)
        If Me.ProgressBarImport.InvokeRequired And Me.GBImportProcess.InvokeRequired Then
            Dim _del_update_progressbar As New del_update_progressbar(AddressOf update_progress_bar)
            Me.Invoke(_del_update_progressbar, New Object() {process_row})
        Else
            Me.ProgressBarImport.EditValue = process_row
            Me.ProgressBarImport.Update()
            Me.GBImportProcess.Text = "Import Process  -  " & process_row.ToString() & "%"
            Me.GBImportProcess.Update()
        End If
    End Sub

    Sub finish_messege(ByVal error_num As Integer, ByVal mess_code As Integer)
        If Me.InvokeRequired Then
            Try
                Dim _del_finish_messege As New del_finish_messege(AddressOf finish_messege)
                Me.Invoke(_del_finish_messege, New Object() {error_num, mess_code})
            Catch ex As Exception
            End Try
        Else
            If no_warn = False Then
                If mess_code = 1 Then
                    XtraMessageBox.Show("Table successfully imported!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf mess_code = 2 Then
                    XtraMessageBox.Show("There was " & error_num.ToString & " data failed to import!" & Environment.NewLine() & "Maybe there was problem of primary key or data type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    XtraMessageBox.Show("Connection failed!" & Environment.NewLine() & "Cannot import table!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                Me.Cursor = Cursors.WaitCursor
                If Me.CheckSurrogateKey.Checked = True Then
                    add_auto_num_key()
                End If
                'FormReferenceTable.Enabled = True
                'FormReferenceTableModule.fill_table_list()
                'FormReferenceTable.LBTableList.SelectedValue = id_new_ref_table
                Me.Cursor = Cursors.Default
                is_finish_import = True
                Me.Close()
            End If
        End If
    End Sub

    '=========================================================================================
    'Module Import Excel
    '=========================================================================================

    Sub import_excel()
        Dim k As Integer = 0
        Try
            fill_dataset()
            Dim query As String
            Dim koneksi As New MySqlConnection(connx)
            Dim command As MySqlCommand
            Dim error_num As Integer = 0
            For j As Integer = 0 To Me.DtSet.Tables("data").Rows.Count - 1
                Try
                    query = "INSERT INTO " & Me.TBTableName.Text & "("
                    k = 0
                    For i As Integer = 0 To Me.GVFieldSetting.RowCount - 1
                        If Me.GVFieldSetting.GetDataRow(i).Item(0) = True Then
                            If Not k = 0 Then
                                query = query & ","
                            End If
                            query = query & Me.GVFieldSetting.GetDataRow(i).Item(2).ToString
                            k = 1
                        End If
                    Next
                    query = query & ") VALUES("
                    k = 0
                    For i As Integer = 0 To Me.GVFieldSetting.RowCount - 1
                        If Me.GVFieldSetting.GetDataRow(i).Item(0) = True Then
                            If Not k = 0 Then
                                query = query & ","
                            End If
                            query = query & """" & DtSet.Tables("data").Rows(j).Item(i).ToString & """"
                            k = 1
                        End If
                    Next
                    query = query & ")"

                    koneksi.Open()
                    command = koneksi.CreateCommand
                    command.CommandText = query
                    command.ExecuteNonQuery()
                    koneksi.Close()

                    Dim process_row As Integer = (((j + 1) / DtSet.Tables("data").Rows.Count) * 100).ToString()
                    update_progress_bar(process_row)
                Catch ex As Exception
                    error_num += 1
                End Try
            Next
            If error_num = 0 Then
                finish_messege(0, 1)
            Else
                update_progress_bar(100)
                finish_messege(error_num, 2)
            End If
        Catch ex As Exception
            finish_messege(0, 3)
        End Try
    End Sub

    Sub fill_dataset()
        Dim MyConnection As OleDbConnection
        DtSet = New DataSet
        Dim MyCommand As OleDbDataAdapter
        MyConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Me.TBFileAddress.Text & "';Extended Properties=""Excel 12.0;IMEX=1;HDR=YES;""")
        MyCommand = New OleDbDataAdapter("select * from [" & Me.CBWorksheetName.SelectedItem.ToString & "$]", MyConnection)
        MyCommand.TableMappings.Add("", "data")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet, "data")
        MyConnection.Close()
    End Sub
    Sub fill_combo_worksheet()
        Dim oledbconn As New OleDbConnection
        Dim strConn As String
        Dim ExcelTables As DataTable
        Try
            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & TBFileAddress.Text & "';Extended Properties=""Excel 12.0;IMEX=1;HDR=YES;"""
            oledbconn.ConnectionString = strConn
            oledbconn.Open()
            ExcelTables = oledbconn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            Dim dr As DataRow
            Dim i As Integer = 0
            CBWorksheetName.Properties.Items.Clear()
            For Each dr In ExcelTables.Rows
                If dr.Item(3).ToString = "TABLE" Then
                    If InStr(dr.Item(2), "$") > 0 Then
                        i += 1
                        CBWorksheetName.Properties.Items.Add(dr.Item(2).ToString.Substring(0, dr.Item(2).ToString.Length - 1))
                        If i = 1 Then
                            CBWorksheetName.SelectedItem = dr.Item(2).ToString.Substring(0, dr.Item(2).ToString.Length - 1)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Function create_table()
        Try
            Dim query As String = query_table_excel()
            Dim koneksi As New MySqlConnection(connx)
            koneksi.Open()
            Dim command As MySqlCommand = koneksi.CreateCommand
            command.CommandText = query
            command.ExecuteNonQuery()
            koneksi.Close()
            Return True
        Catch ex As Exception
            XtraMessageBox.Show("Problem creating table in database!" & Environment.NewLine() & "Please check your table configuration!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Function query_table_excel()
        Dim query As String = ""
        query = "CREATE TABLE " & TBTableName.Text & " ("
        Dim k As Integer
        k = 0
        For i As Integer = 0 To GVFieldSetting.RowCount - 1
            If GVFieldSetting.GetDataRow(i).Item(0) = True Then
                If Not k = 0 Then
                    query = query & ","
                End If
                query = query & GVFieldSetting.GetDataRow(i).Item(2).ToString & " " & GVFieldSetting.GetDataRow(i).Item(3).ToString
                If Not GVFieldSetting.GetDataRow(i).Item(4).ToString = "" Then
                    query = query & "(" & GVFieldSetting.GetDataRow(i).Item(4).ToString & ")"
                End If
                k = 1
            End If
        Next
        k = 0
        If CheckSurrogateKey.Checked = False Then
            query = query & ", PRIMARY KEY ("
            For i As Integer = 0 To GVFieldSetting.RowCount - 1
                If GVFieldSetting.GetDataRow(i).Item(5) = True Then
                    If Not k = 0 Then
                        query = query & ","
                    End If
                    query = query & GVFieldSetting.GetDataRow(i).Item(2).ToString
                    k = 1
                End If
            Next
            query = query & "))"
        Else
            query = query & ")"
        End If
        Return query
    End Function

    Sub fill_field_grid()
        Dim oledbconn As New OleDbConnection
        Dim strConn As String
        Dim data_temp As New DataSet

        dataset_field = New DataSet()
        dataset_field.Tables.Add("data_field")
        dataset_field.Tables("data_field").Columns.Add("use").DataType = GetType(System.Boolean)
        dataset_field.Tables("data_field").Columns.Add("origin_column")
        dataset_field.Tables("data_field").Columns.Add("new_column")
        dataset_field.Tables("data_field").Columns.Add("data_type")
        dataset_field.Tables("data_field").Columns.Add("length")
        dataset_field.Tables("data_field").Columns.Add("primary_key").DataType = GetType(System.Boolean)

        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & TBFileAddress.Text & "';Extended Properties=""Excel 12.0;IMEX=1;HDR=YES;"""
        oledbconn.ConnectionString = strConn
        Dim MyCommand As OleDbDataAdapter
        MyCommand = New OleDbDataAdapter("select * from [" & CBWorksheetName.SelectedItem.ToString & "$]", oledbconn)
        MyCommand.Fill(data_temp, "data")

        For i As Integer = 0 To data_temp.Tables("data").Columns.Count - 1
            dataset_field.Tables("data_field").Rows.Add(True, data_temp.Tables("data").Columns(i).ColumnName.ToString, data_temp.Tables("data").Columns(i).ColumnName.ToString, "", "", False)
        Next

        GCFieldSetting.DataSource = dataset_field.Tables("data_field")
    End Sub

    Sub setting_grid()
        Dim combo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        GVFieldSetting.Columns(3).ColumnEdit = combo
        combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        combo.Items.Clear()
        'Dim text As New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        'text.ReadOnly = True
        'GVFieldSetting.Columns(1).ColumnEdit = text

        combo.Items.Clear()
        combo.Items.Add("bigint")
        combo.Items.Add("binary")
        combo.Items.Add("bit")
        combo.Items.Add("blob")
        combo.Items.Add("bool")
        combo.Items.Add("boolean")
        combo.Items.Add("char")
        combo.Items.Add("date")
        combo.Items.Add("datetime")
        combo.Items.Add("decimal")
        combo.Items.Add("double")
        combo.Items.Add("float")
        combo.Items.Add("int")
        combo.Items.Add("longblob")
        combo.Items.Add("longtext")
        combo.Items.Add("mediumblob")
        combo.Items.Add("mediumint")
        combo.Items.Add("mediumtext")
        combo.Items.Add("numeric")
        combo.Items.Add("real")
        combo.Items.Add("set")
        combo.Items.Add("smallint")
        combo.Items.Add("text")
        combo.Items.Add("time")
        combo.Items.Add("timestamp")
        combo.Items.Add("tinyblob")
        combo.Items.Add("tinyint")
        combo.Items.Add("tinytext")
        combo.Items.Add("varbinary")
        combo.Items.Add("varchar")
        combo.Items.Add("year")
    End Sub

    Function cek_grid_ready()
        Dim result As Boolean = False
        Dim null As Boolean = True
        Dim field_num As Boolean = True
        Dim primary_key As Boolean = False
        Dim row_n As Integer = 0

        For i As Integer = 0 To GVFieldSetting.RowCount - 1
            If GVFieldSetting.GetDataRow(i).Item(0) = True Then
                If GVFieldSetting.GetDataRow(i).Item(3) = "" Then
                    null = False
                End If
                row_n += 1
                If GVFieldSetting.GetDataRow(i).Item(5) = True Then
                    primary_key = True
                End If
            End If
        Next

        If row_n = 0 Then
            field_num = False
        End If

        If CheckSurrogateKey.Checked = True Then
            primary_key = True
        End If

        If null = True And field_num = True And primary_key = True Then
            result = True
        End If

        Return result
    End Function

    Sub add_auto_num_key()
        Dim conn As String = connx
        Dim num As Integer = 0
        Dim num_s As String = ""
        Dim done As Boolean = False
        Dim koneksi As New MySqlConnection(conn)
        Dim command As MySqlCommand = koneksi.CreateCommand

        While done = False
            Try
                If num = 0 Then
                    num_s = ""
                Else
                    num_s = num.ToString
                End If

                koneksi.Open()
                command.CommandText = "ALTER TABLE " & TBTableName.Text & " ADD COLUMN id_" & TBTableName.Text & num_s & " BIGINT AUTO_INCREMENT UNIQUE, ADD PRIMARY KEY(id_" & TBTableName.Text & num_s & ")"
                command.ExecuteNonQuery()
                koneksi.Close()
                done = True
            Catch ex As Exception
                num += 1
            End Try
        End While
    End Sub

    Private Sub BCekKoneksi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCekKoneksi.Click
        host = TBHost.Text
        usn = TBUsername.Text
        pwd = TBPassword.Text
        If Me.BCekKoneksi.Text = "Check Connection" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                tampil_db_to_cb(Me.CBDatabase, Me.TBHost.Text, Me.TBUsername.Text, Me.TBPassword.Text)
                Me.Cursor = Cursors.Default
                Me.BCekKoneksi.Text = "Change Connection"
                Me.TBHost.Enabled = False
                Me.TBUsername.Enabled = False
                Me.TBPassword.Enabled = False
                Me.CBDatabase.Enabled = True
                Me.BSimpanHost.Enabled = True
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.BCekKoneksi.Text = "Check Connection"
            Me.TBHost.Enabled = True
            Me.TBUsername.Enabled = True
            Me.TBPassword.Enabled = True
            Me.CBDatabase.Enabled = False
            Me.BSimpanHost.Enabled = False
        End If
    End Sub
    Sub tampil_db_to_cb(ByRef CB As ComboBoxEdit, ByVal host As String, ByVal username As String, ByVal password As String)
        Dim conn, query_database As String
        conn = "Data Source=" & host & ";User Id=" & username & ";Password=" & password
        Dim koneksi As MySqlConnection = New MySqlConnection(conn)
        koneksi.Open()
        query_database = "SHOW DATABASES"
        Dim list_db As MySqlDataAdapter = New MySqlDataAdapter(query_database, koneksi)
        Dim dset_db As DataSet = New DataSet
        list_db.Fill(dset_db, "data")
        Dim n As Integer = dset_db.Tables("data").Rows.Count
        Dim temp_db As String
        CB.Properties.Items.Clear()
        For i = 0 To n - 1
            temp_db = dset_db.Tables("data").Rows(i)(0).ToString()
            CB.Properties.Items.Add(temp_db)
        Next i
        list_db.Dispose()
        dset_db.Dispose()
        koneksi.Close()
        koneksi.Dispose()
    End Sub

    Private Sub BSimpanHost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanHost.Click
        If BSimpanHost.Text = "Choose Database" Then
            CBDatabase.Enabled = False
            BSimpanHost.Text = "Change Database"
            PC1.Enabled = True
            host = TBHost.Text
            usn = TBUsername.Text
            pwd = TBPassword.Text
            dbs = CBDatabase.EditValue.ToString
        Else
            CBDatabase.Enabled = True
            BSimpanHost.Text = "Choose Database"
            PC1.Enabled = False
        End If
        connx = "Database=" & dbs & ";Data Source=" & host & ";User Id=" & usn & ";Password=" & pwd & ";Convert Zero Datetime=True"
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCekExp.Click
        hosty = TEHostExp.Text
        usny = TEUsnExpt.Text
        pwdy = TEPassExpt.Text
        If Me.BCekExp.Text = "Check Connection" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                tampil_db_to_cb(Me.CBDBExpt, Me.TEHostExp.Text, Me.TEUsnExpt.Text, Me.TEPassExpt.Text)
                Me.Cursor = Cursors.Default
                Me.BCekExp.Text = "Change Connection"
                Me.TEHostExp.Enabled = False
                Me.TEUsnExpt.Enabled = False
                Me.TEPassExpt.Enabled = False
                Me.CBDBExpt.Enabled = True
                Me.BDbExp.Enabled = True
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Me.BCekExp.Text = "Check Connection"
            Me.TEHostExp.Enabled = True
            Me.TEUsnExpt.Enabled = True
            Me.TEPassExpt.Enabled = True
            Me.CBDBExpt.Enabled = False
            Me.BDbExp.Enabled = False
        End If
    End Sub

    Private Sub BDbExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDbExp.Click
        If BDbExp.Text = "Choose Database" Then
            CBDBExpt.Enabled = False
            BSimpanHost.Text = "Change Database"
            hosty = TEHostExp.Text
            usny = TEUsnExpt.Text
            dbsy = CBDBExpt.EditValue.ToString
            conny = "Database=" & dbsy & ";Data Source=" & hosty & ";User Id=" & usny & ";Password=" & pwdy & ";Convert Zero Datetime=True"
            view_table()
            GCTbales.Enabled = True
        Else
            GCTbales.Enabled = False
            CBDBExpt.Enabled = True
            BDbExp.Text = "Choose Database"
        End If
    End Sub
    Sub view_table()
        Dim data As DataTable = execute_query("SHOW TABLES", -1, False, hosty, usny, pwdy, dbsy)
        GCTables.DataSource = data

        If Not data.Rows.Count = 0 Then
            BExport.Enabled = True
            GCVView.Enabled = True
            view_isi()
        Else
            BExport.Enabled = False
            GCVView.Enabled = False
        End If
    End Sub
    Sub view_isi()
        Dim data As DataTable = execute_query("SELECT * FROM " & GVTables.GetFocusedRowCellDisplayText("Tables_in_" & CBDBExpt.EditValue.ToString).ToString, -1, False, hosty, usny, pwdy, dbsy)
        GCView.DataSource = data
        GVView.PopulateColumns()
    End Sub

    Private Sub GVTables_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVTables.RowClick
        view_isi()
    End Sub

    Private Sub BExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BExport.Click
        print(GCView, "Database : " & CBDBExpt.EditValue.ToString & " Table : " & GVTables.GetFocusedRowCellDisplayText("Tables_in_" & CBDBExpt.EditValue.ToString))
    End Sub
End Class