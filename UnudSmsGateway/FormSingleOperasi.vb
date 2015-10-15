Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Public Class FormSingleOperasi
    Public id_operasi As String
    Private data_insert_parameter As New DataTable

    Private data_update_value_parameter As New DataTable
    Private data_update_key_parameter As New DataTable

    Dim data_delete_parameter As New DataTable

    Dim data_select_output As New DataTable
    Dim data_select_join As New DataTable
    Dim data_select_key_parameter As New DataTable

    Private data_func_parameter As New DataTable

    Private data_proc_parameter As New DataTable

    Private tar_host As String
    Private tar_username As String
    Private tar_password As String
    Private tar_database As String

    Private insert_host As String
    Private insert_username As String
    Private insert_password As String
    Private insert_database As String

    Private update_host As String
    Private update_username As String
    Private update_password As String
    Private update_database As String

    Private delete_host As String
    Private delete_username As String
    Private delete_password As String
    Private delete_database As String

    Private select_host As String
    Private select_username As String
    Private select_password As String
    Private select_database As String

    Private function_host As String
    Private function_username As String
    Private function_password As String
    Private function_database As String

    Private procedure_host As String
    Private procedure_username As String
    Private procedure_password As String
    Private procedure_database As String
    Private Sub set_insert_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        insert_host = data.Rows(0)("host").ToString
        insert_username = data.Rows(0)("username").ToString
        insert_password = data.Rows(0)("password").ToString
        insert_database = data.Rows(0)("db").ToString
    End Sub

    Private Sub set_update_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        update_host = data.Rows(0)("host").ToString
        update_username = data.Rows(0)("username").ToString
        update_password = data.Rows(0)("password").ToString
        update_database = data.Rows(0)("db").ToString
    End Sub

    Private Sub set_delete_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        delete_host = data.Rows(0)("host").ToString
        delete_username = data.Rows(0)("username").ToString
        delete_password = data.Rows(0)("password").ToString
        delete_database = data.Rows(0)("db").ToString
    End Sub

    Private Sub set_select_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        select_host = data.Rows(0)("host").ToString
        select_username = data.Rows(0)("username").ToString
        select_password = data.Rows(0)("password").ToString
        select_database = data.Rows(0)("db").ToString
    End Sub
    Private Sub set_function_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        function_host = data.Rows(0)("host").ToString
        function_username = data.Rows(0)("username").ToString
        function_password = data.Rows(0)("password").ToString
        function_database = data.Rows(0)("db").ToString
    End Sub
    Private Sub set_procedure_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        procedure_host = data.Rows(0)("host").ToString
        procedure_username = data.Rows(0)("username").ToString
        procedure_password = data.Rows(0)("password").ToString
        procedure_database = data.Rows(0)("db").ToString
    End Sub

    Private Sub generate_format_select()
        Dim format As String = TEKeywordIns.Text & "#"
        Dim num_parameter As Integer = GVParameterIns.RowCount
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & char_pemisah
            End If

            format = format & GVParameterIns.GetRowCellValue(i, "name")
        Next

        TEFormatIns.Text = format
    End Sub
    Private Sub generate_format_update()
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '

        Dim format As String = TEKeywordUpd.Text
        Dim num_parameter As Integer = GVValUpd.RowCount

        If num_parameter <> 0 Then
            format = format & char_pemisah
        End If

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & "#"
            End If

            format = format & GVValUpd.GetRowCellValue(i, "nama")
        Next

        num_parameter = GVKeyUpd.RowCount

        If num_parameter <> 0 Then
            format = format & "#"
        End If

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & "#"
            End If

            format = format & GVKeyUpd.GetRowCellValue(i, "nama")
        Next

        TEFormatUpd.Text = format
    End Sub
    Private Sub generate_format_delete()
        Dim format As String = TEKeywordDel.Text & "#"
        Dim num_parameter As Integer = GVParameterDel.RowCount
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & char_pemisah
            End If

            format = format & GVParameterDel.GetRowCellValue(i, "name")
        Next

        TEFormatDel.Text = format
    End Sub
    Private Sub generate_format_search()
        Dim format As String = TEKeywordSearch.Text
        Dim num_parameter As Integer = GVParamSearch.RowCount
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '

        If num_parameter <> 0 Then
            format = format & char_pemisah
        End If

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & char_pemisah
            End If

            format = format & GVParamSearch.GetRowCellValue(i, "name")
        Next

        TEFormatSearch.Text = format
        format = ""
        num_parameter = GVOutputSearch.RowCount

        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & ","
            End If

            format = format & GVOutputSearch.GetRowCellValue(i, "name") & "[value]"
        Next
        TEBalasanSearch.Text = format
    End Sub
    Private Sub generate_format_procedure()
        Dim format As String = TEKeywordProc.Text & "#"
        Dim num_parameter As Integer = GVparameterProc.RowCount
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '
        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & char_pemisah
            End If

            format = format & GVparameterProc.GetRowCellValue(i, "name")
        Next

        TEFormatProc.Text = format
    End Sub
    Private Sub generate_format_function()
        Dim format As String = TEKeywordFunc.Text & "#"
        Dim num_parameter As Integer = GVParameterFunc.RowCount
        'ambil pemisah
        Dim koneksi As MySqlConnection = New MySqlConnection(conn_db)
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim char_pemisah, query_id As String
        koneksi.Open()
        query_id = "SELECT char_pemisah FROM tb_option LIMIT 1"
        command = koneksi.CreateCommand()
        command.CommandText = query_id
        reader = command.ExecuteReader()
        reader.Read()
        char_pemisah = reader.GetValue(0).ToString
        koneksi.Close()
        '
        For i As Integer = 0 To num_parameter - 1

            If i <> 0 Then
                format = format & char_pemisah
            End If

            format = format & GVParameterFunc.GetRowCellValue(i, "name")
        Next

        TEFormatFunc.Text = format
    End Sub
    Private Sub view_server(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_host,nama_host as 'Server',db as 'Database' FROM tb_host WHERE is_local=1"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = data
        lookup.Properties.DisplayMember = "Server"
        lookup.Properties.ValueMember = "id_host"
    End Sub
    Private Sub set_connection(ByVal id_host As String)
        Dim query As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        tar_host = data.Rows(0)("host").ToString
        tar_username = data.Rows(0)("username").ToString
        tar_password = data.Rows(0)("password").ToString
        tar_database = data.Rows(0)("db").ToString
    End Sub
    Private Sub view_list(ByVal indeks_operasi As Integer, ByVal listbox As DevExpress.XtraEditors.LookUpEdit)
        Dim tar_host As String = ""
        Dim tar_username As String = ""
        Dim tar_password As String = ""
        Dim tar_database As String = ""
        Dim query As String = ""
        Dim display As String = ""

        If indeks_operasi = 1 Then
            tar_host = insert_host
            tar_username = insert_username
            tar_password = insert_password
            tar_database = insert_database
            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 2 Then
            tar_host = update_host
            tar_username = update_username
            tar_password = update_password
            tar_database = update_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 3 Then
            tar_host = delete_host
            tar_username = delete_username
            tar_password = delete_password
            tar_database = delete_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 4 Then
            tar_host = select_host
            tar_username = select_username
            tar_password = select_password
            tar_database = select_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 5 Then
            tar_host = function_host
            tar_username = function_username
            tar_password = function_password
            tar_database = function_database

            query = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'FUNCTION'", tar_database)
            display = "SPECIFIC_NAME"
        ElseIf indeks_operasi = 6 Then
            tar_host = select_host
            tar_username = procedure_username
            tar_password = procedure_password
            tar_database = procedure_database

            query = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'PROCEDURE'", tar_database)
            display = "SPECIFIC_NAME"
        End If
        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

        listbox.Properties.Columns.Clear()
        listbox.Properties.DataSource = data
        listbox.Properties.DisplayMember = display
        listbox.Properties.ValueMember = display
        listbox.Properties.PopulateColumns()
    End Sub
    Private Sub view_table(ByVal listbox As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim query As String = "SHOW TABLES"
        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

        listbox.DataSource = data
        listbox.DisplayMember = "Tables_in_" & tar_database
        listbox.ValueMember = "Tables_in_" & tar_database
    End Sub
    Private Sub view_table_cb(ByVal indeks_operasi As Integer, ByVal cb As DevExpress.XtraEditors.CheckedListBoxControl)
        Dim tar_host As String = ""
        Dim tar_username As String = ""
        Dim tar_password As String = ""
        Dim tar_database As String = ""
        Dim query As String = ""
        Dim display As String = ""

        If indeks_operasi = 1 Then
            tar_host = insert_host
            tar_username = insert_username
            tar_password = insert_password
            tar_database = insert_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 2 Then
            tar_host = update_host
            tar_username = update_username
            tar_password = update_password
            tar_database = update_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 3 Then
            tar_host = delete_host
            tar_username = delete_username
            tar_password = delete_password
            tar_database = delete_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 4 Then
            tar_host = select_host
            tar_username = select_username
            tar_password = select_password
            tar_database = select_database

            query = "SHOW TABLES"
            display = "Tables_in_" & tar_database
        ElseIf indeks_operasi = 5 Then
            tar_host = function_host
            tar_username = function_username
            tar_password = function_password
            tar_database = function_database

            query = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'FUNCTION'", tar_database)
            display = "SPECIFIC_NAME"
        ElseIf indeks_operasi = 6 Then
            tar_host = procedure_host
            tar_username = procedure_username
            tar_password = procedure_password
            tar_database = procedure_database

            query = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'PROCEDURE'", tar_database)
            display = "SPECIFIC_NAME"
        End If

        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

        cb.DataSource = data
        cb.DisplayMember = display
        cb.ValueMember = display
    End Sub
    Private Sub view_proc_cb(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'PROCEDURE'", tar_database)

        tar_host = procedure_host
        tar_username = procedure_username
        tar_password = procedure_password
        tar_database = procedure_database

        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)
        cb.Properties.Columns.Clear()
        cb.Properties.DataSource = data
        cb.Properties.DisplayMember = "SPECIFIC_NAME"
        cb.Properties.ValueMember = "SPECIFIC_NAME"
        cb.Properties.PopulateColumns()
    End Sub
    Private Sub view_func_cb(ByVal cb As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = String.Format("SELECT SPECIFIC_NAME FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA = '{0}' AND ROUTINE_TYPE = 'FUNCTION'", tar_database)
        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

        cb.Properties.DataSource = data
        cb.Properties.DisplayMember = "SPECIFIC_NAME"
        cb.Properties.ValueMember = "SPECIFIC_NAME"
    End Sub
    Private Sub add_combo_grid(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col As Integer, ByVal tabel As DevExpress.XtraEditors.BaseCheckedListBoxControl.CheckedItemCollection)
        Dim combo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        tar_host = select_host
        tar_username = select_username
        tar_password = select_password
        tar_database = select_database

        combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        combo.Items.Clear()

        For i As Integer = 0 To tabel.Count - 1
            Dim query As String = String.Format("DESC {0}", tabel.Item(i).ToString)
            Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

            For j As Integer = 0 To data.Rows.Count - 1
                combo.Items.Add(tabel.Item(i).ToString & "." & data.Rows(j)(0).ToString)
            Next
        Next

        grid.Columns(col).ColumnEdit = combo
    End Sub
    Private Sub add_combo_grid_from_clb(ByVal indeks_operasi As String, ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col As Integer, ByVal tabel As String)
        Dim combo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        combo.Items.Clear()

        If indeks_operasi = 1 Then
            tar_host = insert_host
            tar_username = insert_username
            tar_password = insert_password
            tar_database = insert_database
        ElseIf indeks_operasi = 2 Then
            tar_host = update_host
            tar_username = update_username
            tar_password = update_password
            tar_database = update_database
        ElseIf indeks_operasi = 3 Then
            tar_host = delete_host
            tar_username = delete_username
            tar_password = delete_password
            tar_database = delete_database
        ElseIf indeks_operasi = 4 Then
            tar_host = select_host
            tar_username = select_username
            tar_password = select_password
            tar_database = select_database
        ElseIf indeks_operasi = 5 Then
            tar_host = function_host
            tar_username = function_username
            tar_password = function_password
            tar_database = function_database
        ElseIf indeks_operasi = 6 Then
            tar_host = select_host
            tar_username = procedure_username
            tar_password = procedure_password
            tar_database = procedure_database
        End If

        Dim query As String = String.Format("DESC {0}", tabel)
        Dim data As DataTable = execute_query(query, -1, False, tar_host, tar_username, tar_password, tar_database)

        For j As Integer = 0 To data.Rows.Count - 1
            combo.Items.Add(tabel & "." & data.Rows(j)(0).ToString)
        Next

        grid.Columns(col).ColumnEdit = combo
    End Sub
    Private Sub add_kriteria(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView, ByVal col As Integer)
        Dim combo As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        combo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        combo.Items.Clear()

        combo.Items.Add("=")
        combo.Items.Add("<")
        combo.Items.Add("<=")
        combo.Items.Add(">")
        combo.Items.Add(">=")
        combo.Items.Add("LIKE")

        grid.Columns(col).ColumnEdit = combo
    End Sub
    Private Function add_row_grid(ByVal indeks_operasi As Integer, ByVal proc As String)
        Dim data As New DataTable
        Dim query As String = ""
        Dim result As String = ""
        Dim component() As String
        Dim single_component() As String

        If indeks_operasi = 5 Then
            tar_host = function_host
            tar_username = function_username
            tar_password = function_password
            tar_database = function_database
        ElseIf indeks_operasi = 6 Then
            tar_host = select_host
            tar_username = procedure_username
            tar_password = procedure_password
            tar_database = procedure_database
        End If

        query = String.Format("SELECT CAST(param_list AS CHAR(1000) CHARACTER SET utf8) AS parameter FROM mysql.proc WHERE db = '{0}' AND NAME = '{1}'", tar_database, proc)

        If proc <> "" Then
            result = execute_query(query, 0, False, tar_host, tar_username, tar_password, tar_database)

            If result <> "" Then
                component = result.Split(",")
                data.Columns.Add("field")
                data.Columns.Add("name")
                data.Columns.Add("kriteria")

                For i As Integer = 0 To component.Length - 1
                    single_component = component(i).Split(" ")

                    For j As Integer = 0 To single_component.Length - 1
                        If single_component(j) <> "" Then
                            data.Rows.Add(single_component(j), "")

                            GoTo cont_process
                        End If
                    Next

cont_process:

                Next
            End If
        End If

        Return data
    End Function
    Private Sub FormSingleOperasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            view_server(LEHostIns)
            view_server(LEHostUpd)
            view_server(LEHostDel)
            view_server(LEHostSearch)
            view_server(LEHostProc)
            view_server(LEHostFunc)
            'edit
            If Not id_operasi = "-1" Then
                Dim query As String = String.Format("SELECT * FROM tb_operasi WHERE id_operasi = '{0}'", id_operasi)
                Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

                Dim jenis_operasi As String = data.Rows(0)("id_jenis_operasi").ToString
                Dim jenis_sql As String = data.Rows(0)("id_jenis_sql").ToString
                Dim nama_operasi As String = data.Rows(0)("nama_operasi").ToString
                Dim keyword As String = data.Rows(0)("keyword").ToString
                Dim is_publik As Boolean = data.Rows(0)("is_publik").ToString
                Dim id_host As String = data.Rows(0)("id_host").ToString

                XTInsert.PageEnabled = True
                XTUpdate.PageEnabled = True
                XTDelete.PageEnabled = True
                XTSearch.PageEnabled = True
                XTProcedure.PageEnabled = True
                XTFunction.PageEnabled = True

                XTab.SelectedTabPageIndex = 0
                XTab.SelectedTabPageIndex = 1
                XTab.SelectedTabPageIndex = 2
                XTab.SelectedTabPageIndex = 3
                XTab.SelectedTabPageIndex = 4
                XTab.SelectedTabPageIndex = 5

                view_server(LEHostIns)
                view_server(LEHostUpd)
                view_server(LEHostDel)
                view_server(LEHostSearch)
                view_server(LEHostProc)
                view_server(LEHostFunc)

                If jenis_operasi = "0" Then
                    If jenis_sql = "2" Then
                        XTab.SelectedTabPageIndex = 5

                        XTInsert.PageEnabled = False
                        XTUpdate.PageEnabled = False
                        XTUpdate.PageEnabled = False
                        XTDelete.PageEnabled = False
                        XTProcedure.PageEnabled = False

                        TENamaFunc.Text = nama_operasi
                        TEKeywordFunc.Text = keyword

                        If is_publik = True Then
                            CETampilFunc.Checked = True
                        Else
                            CETampilFunc.Checked = False
                        End If

                        LEHostFunc.EditValue = Nothing
                        LEHostFunc.ItemIndex = LEHostFunc.Properties.GetDataSourceRowIndex("id_host", id_host)

                        query = String.Format("SELECT * FROM tb_operasi_prosedural WHERE id_operasi = '{0}'", id_operasi)
                        Dim data_prosedural As DataTable = execute_query(query, -1, True, "", "", "", "")

                        Dim dtb_func As DataTable = LETabelFunc.Properties.DataSource

                        For i As Integer = 0 To data_prosedural.Rows.Count - 1
                            For j As Integer = 0 To dtb_func.Rows.Count - 1
                                If dtb_func.Rows(j)("SPECIFIC_NAME").ToString = data_prosedural.Rows(i)("nama_prosedural").ToString Then
                                    LETabelFunc.ItemIndex = LETabelFunc.Properties.GetDataSourceRowIndex("SPECIFIC_NAME", data_prosedural.Rows(i)("nama_prosedural").ToString)
                                    TEFuncOutput.Text = data_prosedural.Rows(i)("nama_hasil").ToString
                                End If
                            Next
                        Next

                        query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '0'", id_operasi)
                        Dim data_value_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                        data_func_parameter.Clear()

                        For i As Integer = 0 To data_value_parameter.Rows.Count - 1
                            data_func_parameter.Rows.Add(data_value_parameter.Rows(i)("parameter").ToString, data_value_parameter.Rows(i)("nama_parameter").ToString)
                        Next
                    ElseIf jenis_sql = "3" Then
                        XTab.SelectedTabPageIndex = 5

                        XTInsert.PageEnabled = False
                        XTUpdate.PageEnabled = False
                        XTDelete.PageEnabled = False
                        XTSearch.PageEnabled = False
                        XTFunction.PageEnabled = False

                        TENamaProc.Text = nama_operasi
                        TEKeywordProc.Text = keyword

                        If is_publik = True Then
                            CETampilProc.Checked = True
                        Else
                            CETampilProc.Checked = False
                        End If

                        LEHostProc.EditValue = Nothing
                        LEHostProc.ItemIndex = LEHostProc.Properties.GetDataSourceRowIndex("id_host", id_host)

                        query = String.Format("SELECT * FROM tb_operasi_prosedural WHERE id_operasi = '{0}'", id_operasi)
                        Dim data_prosedural As DataTable = execute_query(query, -1, True, "", "", "", "")

                        Dim dtb_proc As DataTable = LETabelProc.Properties.DataSource

                        For i As Integer = 0 To data_prosedural.Rows.Count - 1
                            For j As Integer = 0 To dtb_proc.Rows.Count - 1
                                If dtb_proc.Rows(j)("SPECIFIC_NAME").ToString = data_prosedural.Rows(i)("nama_prosedural").ToString Then
                                    LETabelProc.ItemIndex = LETabelProc.Properties.GetDataSourceRowIndex("SPECIFIC_NAME", data_prosedural.Rows(i)("nama_prosedural").ToString)
                                End If
                            Next
                        Next

                        query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '0'", id_operasi)
                        Dim data_value_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                        data_proc_parameter.Clear()

                        For i As Integer = 0 To data_value_parameter.Rows.Count - 1
                            data_proc_parameter.Rows.Add(data_value_parameter.Rows(i)("parameter").ToString, data_value_parameter.Rows(i)("nama_parameter").ToString)
                        Next
                    End If
                ElseIf jenis_operasi = "1" Then
                    XTab.SelectedTabPageIndex = 0

                    XTUpdate.PageEnabled = False
                    XTDelete.PageEnabled = False
                    XTSearch.PageEnabled = False
                    XTProcedure.PageEnabled = False
                    XTFunction.PageEnabled = False

                    TENamaIns.Text = nama_operasi
                    TEKeywordIns.Text = keyword

                    If is_publik = True Then
                        CETampilIns.Checked = True
                    Else
                        CETampilIns.Checked = False
                    End If

                    LEHostIns.EditValue = Nothing
                    LEHostIns.ItemIndex = LEHostIns.Properties.GetDataSourceRowIndex("id_host", id_host)

                    query = String.Format("SELECT * FROM tb_operasi_tabel WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_tabel As DataTable = execute_query(query, -1, True, "", "", "", "")

                    Dim query_db As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
                    Dim data_db As DataTable = execute_query(query_db, -1, True, "", "", "", "")

                    Dim dtb_ins As DataTable = CLBTabelIns.Properties.DataSource

                    For i As Integer = 0 To data_tabel.Rows.Count - 1
                        For j As Integer = 0 To dtb_ins.Rows.Count - 1
                            If dtb_ins.Rows(j)("Tables_in_" & data_db.Rows(0)("db").ToString).ToString = data_tabel.Rows(i)("nama_tabel").ToString Then
                                CLBTabelIns.ItemIndex = CLBTabelIns.Properties.GetDataSourceRowIndex("Tables_in_" & data_db.Rows(0)("db").ToString, data_tabel.Rows(i)("nama_tabel").ToString)
                            End If
                        Next
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '0'", id_operasi)
                    Dim data_value_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_value_parameter.Rows.Count - 1
                        data_insert_parameter.Rows.Add(data_value_parameter.Rows(i)("parameter").ToString, data_value_parameter.Rows(i)("nama_parameter").ToString)
                    Next
                ElseIf jenis_operasi = "2" Then
                    XTab.SelectedTabPageIndex = 1

                    XTInsert.PageEnabled = False
                    XTDelete.PageEnabled = False
                    XTSearch.PageEnabled = False
                    XTProcedure.PageEnabled = False
                    XTFunction.PageEnabled = False

                    TENamaUpd.Text = nama_operasi
                    TEKeywordUpd.Text = keyword

                    If is_publik = True Then
                        CETampilUpd.Checked = True
                    Else
                        CETampilUpd.Checked = False
                    End If

                    LEHostUpd.EditValue = Nothing
                    LEHostUpd.ItemIndex = LEHostUpd.Properties.GetDataSourceRowIndex("id_host", id_host)

                    query = String.Format("SELECT * FROM tb_operasi_tabel WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_tabel As DataTable = execute_query(query, -1, True, "", "", "", "")

                    Dim query_db As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
                    Dim data_db As DataTable = execute_query(query_db, -1, True, "", "", "", "")

                    Dim dtb_upd As DataTable = LETabelUpd.Properties.DataSource

                    For i As Integer = 0 To data_tabel.Rows.Count - 1
                        For j As Integer = 0 To dtb_upd.Rows.Count - 1
                            If dtb_upd.Rows(j)("Tables_in_" & data_db.Rows(0)("db").ToString).ToString = data_tabel.Rows(i)("nama_tabel").ToString Then
                                LETabelUpd.ItemIndex = LETabelUpd.Properties.GetDataSourceRowIndex("Tables_in_" & data_db.Rows(0)("db").ToString, data_tabel.Rows(i)("nama_tabel").ToString)
                            End If
                        Next
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '0'", id_operasi)
                    Dim data_value_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_value_parameter.Rows.Count - 1
                        data_update_value_parameter.Rows.Add(data_value_parameter.Rows(i)("parameter").ToString, data_value_parameter.Rows(i)("nama_parameter").ToString)
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '1'", id_operasi)
                    Dim data_key_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_key_parameter.Rows.Count - 1
                        data_update_key_parameter.Rows.Add(data_key_parameter.Rows(i)("parameter").ToString, data_key_parameter.Rows(i)("nama_parameter").ToString, data_key_parameter.Rows(i)("type").ToString)
                    Next
                ElseIf jenis_operasi = "3" Then
                    XTab.SelectedTabPageIndex = 2

                    XTInsert.PageEnabled = False
                    XTUpdate.PageEnabled = False
                    XTSearch.PageEnabled = False
                    XTProcedure.PageEnabled = False
                    XTFunction.PageEnabled = False

                    TENamaDel.Text = nama_operasi
                    TEKeywordDel.Text = keyword

                    If is_publik = True Then
                        CETampilDel.Checked = True
                    Else
                        CETampilDel.Checked = False
                    End If

                    LETabelDel.EditValue = Nothing
                    LEHostDel.ItemIndex = LEHostDel.Properties.GetDataSourceRowIndex("id_host", id_host)

                    query = String.Format("SELECT * FROM tb_operasi_tabel WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_tabel As DataTable = execute_query(query, -1, True, "", "", "", "")

                    Dim query_db As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
                    Dim data_db As DataTable = execute_query(query_db, -1, True, "", "", "", "")

                    Dim dtb_del As DataTable = LETabelDel.Properties.DataSource

                    For i As Integer = 0 To data_tabel.Rows.Count - 1
                        For j As Integer = 0 To dtb_del.Rows.Count - 1
                            If dtb_del.Rows(j)("Tables_in_" & data_db.Rows(0)("db").ToString).ToString = data_tabel.Rows(i)("nama_tabel").ToString Then
                                LETabelDel.ItemIndex = LETabelDel.Properties.GetDataSourceRowIndex("Tables_in_" & data_db.Rows(0)("db").ToString, data_tabel.Rows(i)("nama_tabel").ToString)
                            End If
                        Next
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '1'", id_operasi)
                    Dim data_key_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_key_parameter.Rows.Count - 1
                        data_delete_parameter.Rows.Add(data_key_parameter.Rows(i)("parameter").ToString, data_key_parameter.Rows(i)("nama_parameter").ToString, data_key_parameter.Rows(i)("type").ToString)
                    Next
                ElseIf jenis_operasi = "4" Then
                    XTab.SelectedTabPageIndex = 3

                    XTInsert.PageEnabled = False
                    XTUpdate.PageEnabled = False
                    XTDelete.PageEnabled = False
                    XTProcedure.PageEnabled = False
                    XTFunction.PageEnabled = False

                    TENamaSearch.Text = nama_operasi
                    TEKeywordSearch.Text = keyword

                    If is_publik = True Then
                        CETampilSearch.Checked = True
                    Else
                        CETampilSearch.Checked = False
                    End If

                    LEHostSearch.EditValue = Nothing
                    LEHostSearch.ItemIndex = LEHostSearch.Properties.GetDataSourceRowIndex("id_host", id_host)

                    query = String.Format("SELECT * FROM tb_operasi_tabel WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_tabel As DataTable = execute_query(query, -1, True, "", "", "", "")

                    Dim query_db As String = String.Format("SELECT * FROM tb_host WHERE id_host = '{0}'", id_host)
                    Dim data_db As DataTable = execute_query(query_db, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_tabel.Rows.Count - 1
                        For j As Integer = 0 To CLBTabelSearch.ItemCount - 1
                            If CLBTabelSearch.GetItemText(j) = data_tabel.Rows(i)("nama_tabel").ToString Then
                                CLBTabelSearch.SetItemChecked(j, True)
                            End If
                        Next
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' AND is_kunci = '1'", id_operasi)
                    Dim data_key_parameter As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_key_parameter.Rows.Count - 1
                        data_select_key_parameter.Rows.Add(data_key_parameter.Rows(i)("parameter").ToString, data_key_parameter.Rows(i)("nama_parameter").ToString, data_key_parameter.Rows(i)("type").ToString)
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_output WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_output As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_output.Rows.Count - 1
                        data_select_output.Rows.Add(data_output.Rows(i)("output").ToString, data_output.Rows(i)("nama_output").ToString)
                    Next

                    query = String.Format("SELECT * FROM tb_operasi_join WHERE id_operasi = '{0}'", id_operasi)
                    Dim data_join As DataTable = execute_query(query, -1, True, "", "", "", "")

                    For i As Integer = 0 To data_join.Rows.Count - 1
                        Dim parts() As String = data_join.Rows(i)("field_join").ToString.Split("=")
                        data_select_join.Rows.Add(parts(0).Trim, parts(1).Trim)
                    Next
                End If
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'awal insert
    Private Sub LEHostIns_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostIns.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            CLBTabelIns.Properties.Columns.Clear()
            set_insert_connection(LEHostIns.EditValue.ToString)
            view_list(1, CLBTabelIns)
            CLBTabelIns.EditValue = ""
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub
    Private Sub CLBTabelIns_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLBTabelIns.EditValueChanged
        Cursor = Cursors.WaitCursor

        data_insert_parameter.Clear()

        If data_insert_parameter.Columns.Count < 2 Then
            data_insert_parameter.Columns.Add("field")
            data_insert_parameter.Columns.Add("name")
        End If

        GCParameterIns.DataSource = data_insert_parameter
        DNParameterIns.DataSource = data_insert_parameter

        Try
            add_combo_grid_from_clb(1, GVParameterIns, 0, CLBTabelIns.EditValue.ToString)
        Catch ex As Exception
        End Try

        Cursor = Cursors.Default
    End Sub
    Private Sub TEKeywordIns_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordIns.EditValueChanged
        generate_format_select()
    End Sub

    Private Sub GVParameterIns_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVParameterIns.RowCountChanged
        generate_format_select()
    End Sub

    Private Sub GVParameterIns_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVParameterIns.ValidateRow
        generate_format_select()
    End Sub

    Private Sub BSaveIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSaveIns.Click
        Cursor = Cursors.WaitCursor

        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaIns.Text
        Dim keyword As String = TEKeywordIns.Text.ToUpper
        Dim is_publik As String = "0"

        If (CETampilIns.Checked = True) Then
            is_publik = "1"
        End If
        Dim id_jenis_operasi As String = "1"
        Dim id_jenis_sql As String = "1"

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVParameterIns.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi parameter minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                If id_operasi <> "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                Dim id_host As String = LEHostIns.EditValue.ToString
                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                query = String.Format("INSERT INTO tb_operasi_tabel(id_operasi,nama_tabel) VALUES('{0}','{1}')", id_operasi2, CLBTabelIns.EditValue.ToString)
                execute_non_query(query, True, "", "", "", "")

                num = GVParameterIns.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVParameterIns.GetRowCellValue(i, "field").ToString, GVParameterIns.GetRowCellValue(i, "name").ToString, "0", "=")
                    execute_non_query(query, True, "", "", "", "")
                Next
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If
        Cursor = Cursors.Default
    End Sub
    'end of Insert
    'awal update
    Private Sub LEHostUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostUpd.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            LETabelUpd.Properties.Columns.Clear()
            set_update_connection(LEHostUpd.EditValue.ToString)
            view_list(2, LETabelUpd)
            LETabelUpd.EditValue = ""
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub LETabelUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LETabelUpd.EditValueChanged
        Cursor = Cursors.WaitCursor

        data_update_key_parameter.Clear()
        data_update_value_parameter.Clear()

        If data_update_value_parameter.Columns.Count < 2 Then
            data_update_value_parameter.Columns.Add("field")
            data_update_value_parameter.Columns.Add("nama")
        End If

        GCValUpd.DataSource = data_update_value_parameter
        DNValUpd.DataSource = data_update_value_parameter
        If data_update_key_parameter.Columns.Count < 3 Then
            data_update_key_parameter.Columns.Add("field")
            data_update_key_parameter.Columns.Add("nama")
            data_update_key_parameter.Columns.Add("kriteria")
        End If

        GCKeyUpd.DataSource = data_update_key_parameter
        DNKeyUpd.DataSource = data_update_key_parameter

        Try
            add_combo_grid_from_clb(2, GVValUpd, 0, LETabelUpd.EditValue.ToString)
            add_combo_grid_from_clb(2, GVKeyUpd, 0, LETabelUpd.EditValue.ToString)
            add_kriteria(GVKeyUpd, 2)
        Catch ex As Exception

        End Try

        Cursor = Cursors.Default
    End Sub
    Private Sub TEKeywordUpd_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordUpd.EditValueChanged
        generate_format_update()
    End Sub
    Private Sub GVKeyUpd_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVKeyUpd.RowCountChanged
        generate_format_update()
    End Sub

    Private Sub GVKeyUpd_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVKeyUpd.ValidateRow
        generate_format_update()
    End Sub
    Private Sub GVValUpd_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVValUpd.RowCountChanged
        generate_format_update()
    End Sub

    Private Sub GVValUpd_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVValUpd.ValidateRow
        generate_format_update()
    End Sub

    Private Sub BSimpanUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanUpd.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaUpd.Text
        Dim keyword As String = TEKeywordUpd.Text.ToUpper
        Dim is_publik As String = "0"

        If (CETampilUpd.Checked = True) Then
            is_publik = "1"
        End If

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVKeyUpd.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi parameter kunci minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVValUpd.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi parameter minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_host As String = LEHostUpd.EditValue.ToString
                Dim id_jenis_operasi As String = "2"
                Dim id_jenis_sql As String = "1"

                If Not id_operasi = "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                query = String.Format("INSERT INTO tb_operasi_tabel(id_operasi,nama_tabel) VALUES('{0}','{1}')", id_operasi2, LETabelUpd.EditValue.ToString)
                execute_non_query(query, True, "", "", "", "")

                num = GVValUpd.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVValUpd.GetRowCellValue(i, "field").ToString, GVValUpd.GetRowCellValue(i, "nama").ToString, "0", "")
                    execute_non_query(query, True, "", "", "", "")
                Next

                num = GVKeyUpd.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVKeyUpd.GetRowCellValue(i, "field").ToString, GVKeyUpd.GetRowCellValue(i, "nama").ToString, "1", GVKeyUpd.GetRowCellValue(i, "kriteria").ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If

        Cursor = Cursors.Default
    End Sub
    'akhir update
    'awal delete
    Private Sub LEHostDel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostDel.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            LETabelDel.Properties.Columns.Clear()
            set_delete_connection(LEHostDel.EditValue.ToString)
            view_list(3, LETabelDel)
            LETabelDel.EditValue = ""
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub LETabelDel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LETabelDel.EditValueChanged
        Cursor = Cursors.WaitCursor

        data_delete_parameter.Clear()

        If data_delete_parameter.Columns.Count < 3 Then
            data_delete_parameter.Columns.Add("field")
            data_delete_parameter.Columns.Add("name")
            data_delete_parameter.Columns.Add("kriteria")
        End If
        
        GCParameterDel.DataSource = data_delete_parameter
        DNParamDel.DataSource = data_delete_parameter

        Try
            add_combo_grid_from_clb(3, GVParameterDel, 0, LETabelDel.EditValue.ToString)
            add_kriteria(GVParameterDel, 2)
        Catch ex As Exception
        End Try

        Cursor = Cursors.Default
    End Sub
    Private Sub TEKeywordDel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordDel.EditValueChanged
        generate_format_delete()
    End Sub
    Private Sub GVParameterDel_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVParameterDel.RowCountChanged
        generate_format_delete()
    End Sub
    Private Sub GVParameterDel_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVParameterDel.ValidateRow
        generate_format_delete()
    End Sub

    Private Sub BSimpanDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanDel.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaDel.Text
        Dim keyword As String = TEKeywordDel.Text.ToUpper
        Dim is_publik As String = "0"

        If (CETampilDel.Checked = True) Then
            is_publik = "1"
        End If

        Dim id_jenis_operasi As String = "3"
        Dim id_jenis_sql As String = "1"

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVParameterDel.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi parameter minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_host As String = LEHostDel.EditValue.ToString

                If id_operasi <> "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                query = String.Format("INSERT INTO tb_operasi_tabel(id_operasi,nama_tabel) VALUES('{0}','{1}')", id_operasi2, LETabelDel.EditValue.ToString)
                execute_non_query(query, True, "", "", "", "")

                num = GVParameterDel.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVParameterDel.GetRowCellValue(i, "field").ToString, GVParameterDel.GetRowCellValue(i, "name").ToString, "1", GVParameterDel.GetRowCellValue(i, "kriteria").ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next

            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If

        Cursor = Cursors.Default
    End Sub
    'akhir delete
    'awal select
    Private Sub LEHostSearch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostSearch.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            set_select_connection(LEHostSearch.EditValue.ToString)
            view_table_cb(4, CLBTabelSearch)
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub CLBTabelSearch_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles CLBTabelSearch.ItemCheck
        Cursor = Cursors.WaitCursor

        data_select_output.Clear()
        If data_select_output.Columns.Count < 2 Then
            data_select_output.Columns.Add("field")
            data_select_output.Columns.Add("name")
        End If
        GCOutputSearch.DataSource = data_select_output
        DNOutputSearch.DataSource = data_select_output

        data_select_key_parameter.Clear()
        If data_select_key_parameter.Columns.Count < 3 Then
            data_select_key_parameter.Columns.Add("field")
            data_select_key_parameter.Columns.Add("name")
            data_select_key_parameter.Columns.Add("kriteria")
        End If
        GCParamSearch.DataSource = data_select_key_parameter
        DNParamSearch.DataSource = data_select_key_parameter

        data_select_join.Clear()
        If data_select_join.Columns.Count < 2 Then
            data_select_join.Columns.Add("field")
            data_select_join.Columns.Add("name")
        End If
        GCJoinSearch.DataSource = data_select_join
        DNJoinSearch.DataSource = data_select_join

        Try
            Dim tabel As DevExpress.XtraEditors.BaseCheckedListBoxControl.CheckedItemCollection = CLBTabelSearch.CheckedItems
            add_combo_grid(GVParamSearch, 0, tabel)
            add_kriteria(GVParamSearch, 2)
            add_combo_grid(GVOutputSearch, 0, tabel)
            add_combo_grid(GVJoinSearch, 0, tabel)
            add_combo_grid(GVJoinSearch, 1, tabel)
        Catch ex As Exception
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub GVParamSearch_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVParamSearch.RowCountChanged
        generate_format_search()
    End Sub
    Private Sub GVParamSearch_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVParamSearch.ValidateRow
        generate_format_search()
    End Sub
    Private Sub GVOutputSearch_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVOutputSearch.RowCountChanged
        generate_format_search()
    End Sub
    Private Sub GVOutputSearch_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVOutputSearch.ValidateRow
        generate_format_search()
    End Sub
    Private Sub TEKeywordSearch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordSearch.EditValueChanged
        generate_format_search()
    End Sub
    Private Sub BSimpanSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanSearch.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaSearch.Text
        Dim keyword As String = TEKeywordSearch.Text.ToUpper
        Dim is_publik As String = "0"

        If (CETampilSearch.Checked = True) Then
            is_publik = "1"
        End If

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword.ToString <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVParamSearch.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi parameter kunci minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVOutputSearch.RowCount = "0" Then
            XtraMessageBox.Show("Harap mengisi output minimal 1.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_host As String = LEHostSearch.EditValue.ToString
                Dim id_jenis_operasi As String = "4"
                Dim id_jenis_sql As String = "1"

                If id_operasi <> "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                num = CLBTabelSearch.CheckedItems.Count

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_tabel(id_operasi,nama_tabel) VALUES('{0}','{1}')", id_operasi2, CLBTabelSearch.CheckedItems.Item(i).ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next

                num = GVOutputSearch.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_output(id_operasi,output,nama_output) VALUES('{0}','{1}','{2}')", id_operasi2, GVOutputSearch.GetRowCellValue(i, "field").ToString, GVOutputSearch.GetRowCellValue(i, "name").ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next

                num = GVParamSearch.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVParamSearch.GetRowCellValue(i, "field").ToString, GVParamSearch.GetRowCellValue(i, "name").ToString, "1", GVParamSearch.GetRowCellValue(i, "kriteria").ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next

                num = GVJoinSearch.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_join(id_operasi,field_join) VALUES('{0}','{1}')", id_operasi2, GVJoinSearch.GetRowCellValue(i, "field").ToString & " = " & GVJoinSearch.GetRowCellValue(i, "name").ToString)
                    execute_non_query(query, True, "", "", "", "")
                Next
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If

        Cursor = Cursors.Default
    End Sub
    'akhir select
    'awal procedure
    Private Sub LEHostProc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostProc.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            LETabelProc.Properties.Columns.Clear()
            set_procedure_connection(LEHostProc.EditValue.ToString)
            view_list(6, LETabelProc)
            LETabelProc.EditValue = ""
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub LETabelProc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LETabelProc.EditValueChanged
        Cursor = Cursors.WaitCursor
        data_proc_parameter.Clear()
        If data_proc_parameter.Columns.Count < 2 Then
            data_proc_parameter.Columns.Add("field")
            data_proc_parameter.Columns.Add("name")
        End If

        Try
            data_proc_parameter = add_row_grid(6, LETabelProc.EditValue.ToString)
            GVparameterProc.Columns(0).OptionsColumn.AllowEdit = False
            GCParameterProc.DataSource = data_proc_parameter
        Catch ex As Exception
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub BSimpanProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanProc.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaProc.Text
        Dim keyword As String = TEKeywordProc.Text.ToUpper
        Dim is_publik As String = "0"

        If (CETampilProc.Checked = True) Then
            is_publik = "1"
        End If

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVparameterProc.RowCount = "0" Then
            XtraMessageBox.Show("Prosedur tidak valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_host As String = LEHostProc.EditValue.ToString
                Dim id_jenis_operasi As String = "0"
                Dim id_jenis_sql As String = "3"

                If id_operasi <> "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                query = String.Format("INSERT INTO tb_operasi_prosedural(id_operasi,nama_prosedural) VALUES('{0}','{1}')", id_operasi2, LETabelProc.EditValue.ToString)
                execute_non_query(query, True, "", "", "", "")

                num = GVparameterProc.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVparameterProc.GetRowCellValue(i, "field").ToString, GVparameterProc.GetRowCellValue(i, "name").ToString, "0", "")
                    execute_non_query(query, True, "", "", "", "")
                Next
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub GVparameterProc_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVparameterProc.ValidateRow
        generate_format_procedure()
    End Sub

    Private Sub GVparameterProc_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVparameterProc.RowCountChanged
        generate_format_procedure()
    End Sub

    Private Sub TEKeywordProc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordProc.EditValueChanged
        generate_format_procedure()
    End Sub
    'akhir procedure
    'awal function
    Private Sub LEHostFunc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEHostFunc.EditValueChanged
        Cursor = Cursors.WaitCursor
        Try
            LETabelFunc.Properties.Columns.Clear()
            set_function_connection(LEHostFunc.EditValue.ToString)
            view_list(5, LETabelFunc)
            LETabelFunc.EditValue = ""
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub LETabelFunc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LETabelFunc.EditValueChanged
        Cursor = Cursors.WaitCursor
        data_func_parameter.Clear()
        If data_func_parameter.Columns.Count < 2 Then
            data_func_parameter.Columns.Add("field")
            data_func_parameter.Columns.Add("name")
        End If

        Try
            data_func_parameter = add_row_grid(5, LETabelFunc.EditValue.ToString)
            GVParameterFunc.Columns(0).OptionsColumn.AllowEdit = False
            GCParameterFunc.DataSource = data_func_parameter
        Catch ex As Exception
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub BSimpanFunc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpanFunc.Click
        Cursor = Cursors.WaitCursor
        Dim query As String = ""
        Dim num As Integer = 0
        Dim id_operasi2 As String = ""

        Dim nama_operasi As String = TENamaFunc.Text
        Dim keyword As String = TEKeywordFunc.Text.ToUpper
        Dim outputx As String = TEFuncOutput.Text
        Dim is_publik As String = "0"

        If (CETampilFunc.Checked = True) Then
            is_publik = "1"
        End If

        query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_host.is_local='1' AND keyword='" & keyword & "'"
        Dim cek_keyword As String = execute_query(query, 0, True, "", "", "", "")

        If id_operasi <> "-1" Then
            query = "SELECT COUNT(*) FROM tb_operasi,tb_host WHERE tb_host.id_host=tb_operasi.id_host AND tb_operasi.keyword='" & keyword & "' AND tb_host.is_local='1' AND id_operasi !='" & id_operasi & "'"
            cek_keyword = execute_query(query, 0, True, "", "", "", "")
        End If

        If nama_operasi = "" Then
            XtraMessageBox.Show("Harap isi nama host.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "" Then
            XtraMessageBox.Show("Harap isi keyword.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf keyword = "OP" Or keyword = "RE_OP" Or keyword = "FOWARD" Or keyword.Length < 2 Then
            XtraMessageBox.Show("Keyword tidak valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cek_keyword <> "0" Then
            XtraMessageBox.Show("Keyword telah digunakan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf GVParameterFunc.RowCount = "0" Then
            XtraMessageBox.Show("Function tidak valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf outputx = "" Then
            XtraMessageBox.Show("Output tidak valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim id_host As String = LEHostFunc.EditValue.ToString
                Dim id_jenis_operasi As String = "0"
                Dim id_jenis_sql As String = "2"

                If id_operasi <> "-1" Then
                    query = String.Format("DELETE FROM tb_operasi WHERE id_operasi='{0}'", id_operasi)
                    execute_non_query(query, True, "", "", "", "")
                End If

                query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                execute_non_query(query, True, "", "", "", "")

                query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                id_operasi2 = execute_query(query, 0, True, "", "", "", "")

                query = String.Format("INSERT INTO tb_operasi_prosedural(id_operasi,nama_prosedural,nama_hasil) VALUES('{0}','{1}','{2}')", id_operasi2, LETabelFunc.EditValue.ToString, outputx)
                execute_non_query(query, True, "", "", "", "")

                num = GVParameterFunc.RowCount

                For i As Integer = 0 To num - 1
                    query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}','{3}','{4}')", id_operasi2, GVParameterFunc.GetRowCellValue(i, "field").ToString, GVParameterFunc.GetRowCellValue(i, "name").ToString, "0", "")
                    execute_non_query(query, True, "", "", "", "")
                Next
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Cursor = Cursors.Default
            Cursor = Cursors.WaitCursor

            Try
                FormKeyword.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Me.Close()
            Me.Dispose()
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub TEKeywordFunc_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TEKeywordFunc.EditValueChanged
        generate_format_function()
    End Sub
    Private Sub GVParameterFunc_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVParameterFunc.ValidateRow
        generate_format_function()
    End Sub

    Private Sub GVParameterFunc_RowCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVParameterFunc.RowCountChanged
        generate_format_function()
    End Sub

    Private Sub FormSingleOperasi_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class