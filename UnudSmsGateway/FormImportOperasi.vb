Imports DevExpress.XtraEditors
Imports System.Xml
Imports System.Security.Cryptography
Imports System.Security.Cryptography.Xml
Imports System.Text

Public Class FormImportOperasi
    Private Sub import_operasi(ByVal id_host As String)
        Dim path As String = TEAlamat.Text
        Dim myXmlDocument As New XmlDocument
        Dim operationList, operationSingle, operationJoin, operationOutput, operationParameter, operationProsedural, operationTabel As XmlNodeList
        Dim id_operasi As String
        Dim query As String

        myXmlDocument.Load(path)
        operationList = myXmlDocument.GetElementsByTagName("operation")

        For Each operation As XmlNode In operationList
            If operation.Name = "operation" Then
                operationSingle = operation.ChildNodes

                For Each operation_single As XmlNode In operationSingle
                    Dim id_jenis_operasi As String = operation_single.ChildNodes.Item(0).InnerText
                    Dim id_jenis_sql As String = operation_single.ChildNodes.Item(1).InnerText
                    Dim keyword As String = operation_single.ChildNodes.Item(2).InnerText
                    Dim is_publik As String = operation_single.ChildNodes.Item(3).InnerText
                    Dim nama_operasi As String = operation_single.ChildNodes.Item(4).InnerText

                    query = String.Format("INSERT INTO tb_operasi(id_host,id_jenis_operasi,id_jenis_sql,keyword,is_publik,nama_operasi) VALUES('{0}','{1}','{2}','{3}',{4},'{5}')", id_host, id_jenis_operasi, id_jenis_sql, keyword, is_publik, nama_operasi)
                    execute_non_query(query, True, "", "", "", "")

                    query = "SELECT LAST_INSERT_ID() AS id ORDER BY id DESC LIMIT 1"
                    id_operasi = execute_query(query, 0, True, "", "", "", "")

                    operationJoin = operation_single.ChildNodes.Item(5).ChildNodes

                    For Each operation_join As XmlNode In operationJoin
                        Dim field_join As String = operation_join.ChildNodes.Item(0).InnerText

                        query = String.Format("INSERT INTO tb_operasi_join(id_operasi,field_join) VALUES('{0}','{1}')", id_operasi, field_join)
                        execute_non_query(query, True, "", "", "", "")
                    Next

                    operationOutput = operation_single.ChildNodes.Item(6).ChildNodes

                    For Each operation_output As XmlNode In operationOutput
                        Dim output As String = operation_output.ChildNodes.Item(0).InnerText
                        Dim nama_output As String = operation_output.ChildNodes.Item(1).InnerText

                        query = String.Format("INSERT INTO tb_operasi_output(id_operasi,output,nama_output) VALUES('{0}','{1}','{2}')", id_operasi, output, nama_output)
                        execute_non_query(query, True, "", "", "", "")
                    Next

                    operationParameter = operation_single.ChildNodes.Item(7).ChildNodes

                    For Each operation_parameter As XmlNode In operationParameter
                        Dim parameter As String = operation_parameter.ChildNodes.Item(0).InnerText
                        Dim nama_parameter As String = operation_parameter.ChildNodes.Item(1).InnerText
                        Dim is_kunci As String = operation_parameter.ChildNodes.Item(2).InnerText
                        Dim type As String = operation_parameter.ChildNodes.Item(3).InnerText

                        query = String.Format("INSERT INTO tb_operasi_parameter(id_operasi,parameter,nama_parameter,is_kunci,type) VALUES('{0}','{1}','{2}',{3},'{4}')", id_operasi, parameter, nama_parameter, is_kunci, type)
                        execute_non_query(query, True, "", "", "", "")
                    Next

                    operationProsedural = operation_single.ChildNodes.Item(8).ChildNodes

                    For Each operation_prosedural As XmlNode In operationProsedural
                        Dim nama_prosedural As String = operation_prosedural.ChildNodes.Item(0).InnerText

                        query = String.Format("INSERT INTO tb_operasi_prosedural(id_operasi,nama_prosedural) VALUES('{0}','{1}')", id_operasi, nama_prosedural)
                        execute_non_query(query, True, "", "", "", "")
                    Next

                    operationTabel = operation_single.ChildNodes.Item(9).ChildNodes

                    For Each operation_tabel As XmlNode In operationTabel
                        Dim nama_tabel As String = operation_tabel.ChildNodes.Item(0).InnerText

                        query = String.Format("INSERT INTO tb_operasi_tabel(id_operasi,nama_tabel) VALUES('{0}','{1}')", id_operasi, nama_tabel)
                        execute_non_query(query, True, "", "", "", "")
                    Next
                Next
            End If
        Next
    End Sub
    Private Sub BCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Dim fileDialog As New OpenFileDialog()

        fileDialog.Filter = "Xml Files (*.xml)|*.xml"
        fileDialog.FilterIndex = 2
        fileDialog.RestoreDirectory = True

        If fileDialog.ShowDialog() = DialogResult.OK Then
            TEAlamat.Text = fileDialog.FileName.ToString
        End If
    End Sub
    Private Sub view_server(ByVal lookup As DevExpress.XtraEditors.LookUpEdit)
        Dim query As String = "SELECT id_host,nama_host,no_hp,email FROM tb_host WHERE is_local = '0'"
        Dim data As DataTable = execute_query(query, -1, True, "", "", "", "")

        lookup.Properties.DataSource = data

        lookup.Properties.DisplayMember = "nama_host"
        lookup.Properties.ValueMember = "id_host"
    End Sub

    Private Sub FormImportOperasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        Try
            TEAlamat.Text = ""
            LEServerPartner.EditValue = ""

            LEServerPartner.Properties.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            view_server(LEServerPartner)
        Catch ex As Exception
            XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Cursor = Cursors.Default
    End Sub

    Private Sub BSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSimpan.Click
        Cursor = Cursors.WaitCursor

        Dim address As String = TEAlamat.Text
        Dim id_host As String = LEServerPartner.EditValue.ToString

        If Not isValue(address) Or Not isValue(id_host) Then
            XtraMessageBox.Show("Invalid input data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                import_operasi(id_host)
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Close()

            Try
                FormManageOperasiPartner.refresh_operasi()
            Catch ex As Exception
                XtraMessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

        Cursor = Cursors.Default
    End Sub
End Class