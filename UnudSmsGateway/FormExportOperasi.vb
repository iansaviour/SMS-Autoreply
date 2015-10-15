Imports DevExpress.XtraEditors
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports System.Text

Public Class FormExportOperasi
    Private Function get_operasi(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi WHERE id_operasi = '{0}'", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Function get_tabel(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_tabel WHERE id_operasi = '{0}'", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Function get_prosedural(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_prosedural WHERE id_operasi = '{0}'", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Function get_parameter(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_parameter WHERE id_operasi = '{0}' ORDER BY id_operasi_parameter", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Function get_output(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_output WHERE id_operasi = '{0}' ORDER BY id_operasi_output", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Function get_join(ByVal id_operasi As String)
        Dim query As String = String.Format("SELECT * FROM tb_operasi_join WHERE id_operasi = '{0}' ORDER BY id_operasi_join", id_operasi)
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        Return data
    End Function

    Private Sub export_operasi()
        Dim path As String = TextEditAddress.Text

        Dim xml_writer As New XmlTextWriter(path, System.Text.Encoding.UTF8)
        xml_writer.WriteStartDocument(True)
        xml_writer.Formatting = Formatting.Indented
        xml_writer.Indentation = 2
        xml_writer.WriteStartElement("operation")

        For j As Integer = 0 To GVExport.RowCount - 1
            If GVExport.GetRowCellValue(j, "cek") = True Then
                Dim id_operasi As String = GVExport.GetRowCellValue(j, "id_operasi").ToString

                Dim data_operasi As DataTable = get_operasi(id_operasi)
                Dim data_join As DataTable = get_join(id_operasi)
                Dim data_output As DataTable = get_output(id_operasi)
                Dim data_parameter As DataTable = get_parameter(id_operasi)
                Dim data_prosedural As DataTable = get_prosedural(id_operasi)
                Dim data_tabel As DataTable = get_tabel(id_operasi)

                xml_writer.WriteStartElement("operation_single")

                xml_writer.WriteStartElement("id_jenis_operasi")
                xml_writer.WriteString(data_operasi.Rows(0)("id_jenis_operasi").ToString)
                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("id_jenis_sql")
                xml_writer.WriteString(data_operasi.Rows(0)("id_jenis_sql").ToString)
                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("keyword")
                xml_writer.WriteString(data_operasi.Rows(0)("keyword").ToString)
                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("is_publik")
                xml_writer.WriteString(data_operasi.Rows(0)("is_publik").ToString)
                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("nama_operasi")
                xml_writer.WriteString(data_operasi.Rows(0)("nama_operasi").ToString)
                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("operasi_join")

                For i As Integer = 0 To data_join.Rows.Count - 1
                    xml_writer.WriteStartElement("operasi_join_single")

                    xml_writer.WriteStartElement("field_join")
                    xml_writer.WriteString(data_join.Rows(i)("field_join").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteEndElement()
                Next

                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("operasi_output")

                For i As Integer = 0 To data_output.Rows.Count - 1
                    xml_writer.WriteStartElement("operasi_output_single")

                    xml_writer.WriteStartElement("output")
                    xml_writer.WriteString(data_output.Rows(i)("output").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteStartElement("nama_output")
                    xml_writer.WriteString(data_output.Rows(i)("nama_output").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteEndElement()
                Next

                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("operasi_parameter")

                For i As Integer = 0 To data_parameter.Rows.Count - 1
                    xml_writer.WriteStartElement("operasi_parameter_single")

                    xml_writer.WriteStartElement("parameter")
                    xml_writer.WriteString(data_parameter.Rows(i)("parameter").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteStartElement("nama_parameter")
                    xml_writer.WriteString(data_parameter.Rows(i)("nama_parameter").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteStartElement("is_kunci")
                    xml_writer.WriteString(data_parameter.Rows(i)("is_kunci").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteStartElement("type")
                    xml_writer.WriteString(data_parameter.Rows(i)("type").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteEndElement()
                Next

                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("operasi_prosedural")

                For i As Integer = 0 To data_prosedural.Rows.Count - 1
                    xml_writer.WriteStartElement("operasi_prosedural_single")

                    xml_writer.WriteStartElement("nama_prosedural")
                    xml_writer.WriteString(data_prosedural.Rows(i)("nama_prosedural").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteEndElement()
                Next

                xml_writer.WriteEndElement()

                xml_writer.WriteStartElement("operasi_tabel")

                For i As Integer = 0 To data_tabel.Rows.Count - 1
                    xml_writer.WriteStartElement("operasi_tabel_single")

                    xml_writer.WriteStartElement("nama_tabel")
                    xml_writer.WriteString(data_tabel.Rows(i)("nama_tabel").ToString)
                    xml_writer.WriteEndElement()

                    xml_writer.WriteEndElement()
                Next

                xml_writer.WriteEndElement()

                xml_writer.WriteEndElement()
            End If
        Next

        xml_writer.WriteEndElement()
        xml_writer.WriteEndDocument()
        xml_writer.Close()
    End Sub
    Private Sub view_operation()
        Dim query As String = "SELECT * FROM tb_operasi,tb_host WHERE tb_operasi.id_host = tb_host.id_host AND tb_host.is_local = '1' ORDER BY nama_host,nama_operasi"
        Dim data_temp As DataTable = execute_query(query, -1, True, "", "", "", "")
        Dim data As New DataTable

        data.Columns.Add("id_operasi")
        data.Columns.Add("cek").DataType = GetType(Boolean)
        data.Columns.Add("nama_host")
        data.Columns.Add("nama_operasi")

        For i As Integer = 0 To data_temp.Rows.Count - 1
            data.Rows.Add(data_temp.Rows(i)("id_operasi").ToString, False, data_temp.Rows(i)("nama_host").ToString, data_temp.Rows(i)("nama_operasi").ToString)
        Next

        GCExport.DataSource = data
    End Sub
    Private Sub FormExportOperasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        Try
            view_operation()
            TextEditAddress.Text = ""
            CESemuaOperasi.Checked = False
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub CESemuaOperasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CESemuaOperasi.CheckedChanged
        Cursor = Cursors.WaitCursor

        If CESemuaOperasi.Checked = False Then
            For i As Integer = 0 To GVExport.RowCount - 1
                GVExport.SetRowCellValue(i, "cek", False)
            Next
        Else
            For i As Integer = 0 To GVExport.RowCount - 1
                GVExport.SetRowCellValue(i, "cek", True)
            Next
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub GVExport_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GVExport.RowClick
        Cursor = Cursors.WaitCursor

        If GVExport.GetFocusedRowCellValue("cek") = False Then
            GVExport.SetFocusedRowCellValue("cek", True)

            Dim cek As Boolean = True

            For i As Integer = 0 To GVExport.RowCount - 1
                If GVExport.GetRowCellValue(i, "cek") = False Then
                    cek = False
                End If
            Next

            If cek = True Then
                CESemuaOperasi.Checked = True
            End If
        Else
            GVExport.SetFocusedRowCellValue("cek", False)
            CESemuaOperasi.Checked = False
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Dim fileDialog As New SaveFileDialog()

        fileDialog.Filter = "Xml Files (*.xml)|*.xml"
        fileDialog.FilterIndex = 2
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog() = DialogResult.OK Then
            TextEditAddress.Text = fileDialog.FileName.ToString
        End If
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Cursor = Cursors.WaitCursor

        Dim address As String = TextEditAddress.Text

        If Not isValue(address) Then
            XtraMessageBox.Show("Invalid input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                export_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Close()
        End If

        Cursor = Cursors.Default
    End Sub

    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class