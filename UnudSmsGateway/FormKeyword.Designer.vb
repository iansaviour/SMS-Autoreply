<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeyword
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
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.GCOperasi = New DevExpress.XtraGrid.GridControl
        Me.GVOperasi = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ComKeyword = New DevExpress.XtraEditors.GroupControl
        Me.BPrint = New DevExpress.XtraEditors.SimpleButton
        Me.BExport = New DevExpress.XtraEditors.SimpleButton
        Me.BDeleteKeyword = New DevExpress.XtraEditors.SimpleButton
        Me.BEdit = New DevExpress.XtraEditors.SimpleButton
        Me.BtambahOperasi = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GCCast = New DevExpress.XtraGrid.GridControl
        Me.GVCast = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.id_host = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_host = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_hp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.email = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GCOperasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOperasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComKeyword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComKeyword.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCCast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVCast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GCOperasi)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(687, 181)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Operasi"
        '
        'GCOperasi
        '
        Me.GCOperasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOperasi.Location = New System.Drawing.Point(2, 22)
        Me.GCOperasi.MainView = Me.GVOperasi
        Me.GCOperasi.Name = "GCOperasi"
        Me.GCOperasi.Size = New System.Drawing.Size(683, 157)
        Me.GCOperasi.TabIndex = 0
        Me.GCOperasi.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOperasi})
        '
        'GVOperasi
        '
        Me.GVOperasi.GridControl = Me.GCOperasi
        Me.GVOperasi.Name = "GVOperasi"
        Me.GVOperasi.OptionsBehavior.Editable = False
        '
        'ComKeyword
        '
        Me.ComKeyword.Controls.Add(Me.BPrint)
        Me.ComKeyword.Controls.Add(Me.BExport)
        Me.ComKeyword.Controls.Add(Me.BDeleteKeyword)
        Me.ComKeyword.Controls.Add(Me.BEdit)
        Me.ComKeyword.Controls.Add(Me.BtambahOperasi)
        Me.ComKeyword.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComKeyword.Location = New System.Drawing.Point(0, 0)
        Me.ComKeyword.Name = "ComKeyword"
        Me.ComKeyword.Size = New System.Drawing.Size(687, 61)
        Me.ComKeyword.TabIndex = 2
        Me.ComKeyword.Text = "Command"
        '
        'BPrint
        '
        Me.BPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrint.Location = New System.Drawing.Point(403, 22)
        Me.BPrint.Name = "BPrint"
        Me.BPrint.Size = New System.Drawing.Size(86, 37)
        Me.BPrint.TabIndex = 9
        Me.BPrint.Text = "Print"
        '
        'BExport
        '
        Me.BExport.Dock = System.Windows.Forms.DockStyle.Left
        Me.BExport.Location = New System.Drawing.Point(301, 22)
        Me.BExport.Name = "BExport"
        Me.BExport.Size = New System.Drawing.Size(102, 37)
        Me.BExport.TabIndex = 5
        Me.BExport.Text = "Export"
        '
        'BDeleteKeyword
        '
        Me.BDeleteKeyword.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDeleteKeyword.Location = New System.Drawing.Point(199, 22)
        Me.BDeleteKeyword.Name = "BDeleteKeyword"
        Me.BDeleteKeyword.Size = New System.Drawing.Size(102, 37)
        Me.BDeleteKeyword.TabIndex = 4
        Me.BDeleteKeyword.Text = "Delete"
        '
        'BEdit
        '
        Me.BEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEdit.Location = New System.Drawing.Point(101, 22)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(98, 37)
        Me.BEdit.TabIndex = 3
        Me.BEdit.Text = "Edit"
        '
        'BtambahOperasi
        '
        Me.BtambahOperasi.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtambahOperasi.Location = New System.Drawing.Point(2, 22)
        Me.BtambahOperasi.Name = "BtambahOperasi"
        Me.BtambahOperasi.Size = New System.Drawing.Size(99, 37)
        Me.BtambahOperasi.TabIndex = 0
        Me.BtambahOperasi.Text = "Tambah"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GCCast)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(687, 172)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Cast"
        '
        'GCCast
        '
        Me.GCCast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCast.Location = New System.Drawing.Point(2, 22)
        Me.GCCast.MainView = Me.GVCast
        Me.GCCast.Name = "GCCast"
        Me.GCCast.Size = New System.Drawing.Size(683, 148)
        Me.GCCast.TabIndex = 0
        Me.GCCast.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVCast})
        '
        'GVCast
        '
        Me.GVCast.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cek, Me.id_host, Me.nama_host, Me.no_hp, Me.email})
        Me.GVCast.GridControl = Me.GCCast
        Me.GVCast.Name = "GVCast"
        Me.GVCast.OptionsBehavior.Editable = False
        '
        'cek
        '
        Me.cek.AppearanceHeader.Options.UseTextOptions = True
        Me.cek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cek.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.cek.Caption = "*"
        Me.cek.FieldName = "cek"
        Me.cek.Name = "cek"
        Me.cek.Visible = True
        Me.cek.VisibleIndex = 0
        Me.cek.Width = 20
        '
        'id_host
        '
        Me.id_host.Caption = "Id"
        Me.id_host.FieldName = "id_host"
        Me.id_host.Name = "id_host"
        Me.id_host.Visible = True
        Me.id_host.VisibleIndex = 1
        '
        'nama_host
        '
        Me.nama_host.Caption = "Partner"
        Me.nama_host.FieldName = "nama_host"
        Me.nama_host.Name = "nama_host"
        Me.nama_host.Visible = True
        Me.nama_host.VisibleIndex = 2
        '
        'no_hp
        '
        Me.no_hp.Caption = "Nomor"
        Me.no_hp.FieldName = "no_hp"
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Visible = True
        Me.no_hp.VisibleIndex = 3
        '
        'email
        '
        Me.email.Caption = "Yahoo Id"
        Me.email.FieldName = "email"
        Me.email.Name = "email"
        Me.email.Visible = True
        Me.email.VisibleIndex = 4
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 61)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl4)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(687, 359)
        Me.SplitContainerControl1.SplitterPosition = 181
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'FormKeyword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 420)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.ComKeyword)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormKeyword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Operasi Lokal"
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GCOperasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOperasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComKeyword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComKeyword.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCCast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVCast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCOperasi As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOperasi As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ComKeyword As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtambahOperasi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDeleteKeyword As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCCast As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVCast As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents id_host As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_host As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_hp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BPrint As DevExpress.XtraEditors.SimpleButton
End Class
