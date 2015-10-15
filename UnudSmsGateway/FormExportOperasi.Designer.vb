<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExportOperasi
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GCExport = New DevExpress.XtraGrid.GridControl
        Me.GVExport = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnCheck = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnHost = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnServer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.CESemuaOperasi = New DevExpress.XtraEditors.CheckEdit
        Me.BBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.TextEditAddress = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.CESemuaOperasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GCExport)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(613, 263)
        Me.GroupControl1.TabIndex = 11
        Me.GroupControl1.Text = "Operasi"
        '
        'GCExport
        '
        Me.GCExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCExport.Location = New System.Drawing.Point(2, 22)
        Me.GCExport.MainView = Me.GVExport
        Me.GCExport.Name = "GCExport"
        Me.GCExport.Size = New System.Drawing.Size(609, 239)
        Me.GCExport.TabIndex = 0
        Me.GCExport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVExport})
        '
        'GVExport
        '
        Me.GVExport.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnId, Me.GridColumnCheck, Me.GridColumnHost, Me.GridColumnServer})
        Me.GVExport.GridControl = Me.GCExport
        Me.GVExport.Name = "GVExport"
        '
        'GridColumnId
        '
        Me.GridColumnId.FieldName = "id_column"
        Me.GridColumnId.Name = "GridColumnId"
        '
        'GridColumnCheck
        '
        Me.GridColumnCheck.Caption = "Check"
        Me.GridColumnCheck.FieldName = "cek"
        Me.GridColumnCheck.Name = "GridColumnCheck"
        Me.GridColumnCheck.OptionsColumn.AllowSize = False
        Me.GridColumnCheck.OptionsColumn.ShowCaption = False
        Me.GridColumnCheck.Visible = True
        Me.GridColumnCheck.VisibleIndex = 0
        Me.GridColumnCheck.Width = 27
        '
        'GridColumnHost
        '
        Me.GridColumnHost.Caption = "Host"
        Me.GridColumnHost.FieldName = "nama_host"
        Me.GridColumnHost.Name = "GridColumnHost"
        Me.GridColumnHost.Visible = True
        Me.GridColumnHost.VisibleIndex = 1
        Me.GridColumnHost.Width = 281
        '
        'GridColumnServer
        '
        Me.GridColumnServer.Caption = "Operasi"
        Me.GridColumnServer.FieldName = "nama_operasi"
        Me.GridColumnServer.Name = "GridColumnServer"
        Me.GridColumnServer.Visible = True
        Me.GridColumnServer.VisibleIndex = 2
        Me.GridColumnServer.Width = 285
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BCancel)
        Me.GroupControl2.Controls.Add(Me.BSimpan)
        Me.GroupControl2.Controls.Add(Me.CESemuaOperasi)
        Me.GroupControl2.Controls.Add(Me.BBrowse)
        Me.GroupControl2.Controls.Add(Me.TextEditAddress)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 263)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(613, 134)
        Me.GroupControl2.TabIndex = 12
        Me.GroupControl2.Text = "Lokasi Penyimpanan"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(2, 86)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(609, 23)
        Me.BCancel.TabIndex = 16
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(2, 109)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(609, 23)
        Me.BSimpan.TabIndex = 15
        Me.BSimpan.Text = "Simpan"
        '
        'CESemuaOperasi
        '
        Me.CESemuaOperasi.Location = New System.Drawing.Point(129, 58)
        Me.CESemuaOperasi.Name = "CESemuaOperasi"
        Me.CESemuaOperasi.Properties.Caption = "Semua Operasi"
        Me.CESemuaOperasi.Size = New System.Drawing.Size(109, 19)
        Me.CESemuaOperasi.TabIndex = 14
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(533, 29)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BBrowse.TabIndex = 13
        Me.BBrowse.Text = "Browse"
        '
        'TextEditAddress
        '
        Me.TextEditAddress.Location = New System.Drawing.Point(131, 29)
        Me.TextEditAddress.Name = "TextEditAddress"
        Me.TextEditAddress.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TextEditAddress.Properties.Appearance.Options.UseFont = True
        Me.TextEditAddress.Properties.ReadOnly = True
        Me.TextEditAddress.Size = New System.Drawing.Size(396, 23)
        Me.TextEditAddress.TabIndex = 12
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Alamat File XML"
        '
        'FormExportOperasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormExportOperasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Operasi"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.CESemuaOperasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEditAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CESemuaOperasi As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCExport As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVExport As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumnId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnHost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnServer As DevExpress.XtraGrid.Columns.GridColumn
End Class
