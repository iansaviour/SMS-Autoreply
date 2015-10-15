<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGrupKontak
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
        Me.BEdit = New DevExpress.XtraEditors.SimpleButton
        Me.BDelete = New DevExpress.XtraEditors.SimpleButton
        Me.BTambah = New DevExpress.XtraEditors.SimpleButton
        Me.GCGrupKontak = New DevExpress.XtraGrid.GridControl
        Me.GVGrupKontak = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XTCGrupKontak = New DevExpress.XtraTab.XtraTabControl
        Me.XTPGrup = New DevExpress.XtraTab.XtraTabPage
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.BRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.XTPMember = New DevExpress.XtraTab.XtraTabPage
        Me.GCKontak = New DevExpress.XtraGrid.GridControl
        Me.GVKontak = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCEContact = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BDeleteMember = New DevExpress.XtraEditors.SimpleButton
        Me.BAddMember = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GCGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTCGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCGrupKontak.SuspendLayout()
        Me.XTPGrup.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.XTPMember.SuspendLayout()
        CType(Me.GCKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RCEContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BEdit
        '
        Me.BEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BEdit.Location = New System.Drawing.Point(485, 2)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(104, 33)
        Me.BEdit.TabIndex = 2
        Me.BEdit.Text = "Edit Grup"
        '
        'BDelete
        '
        Me.BDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.BDelete.Location = New System.Drawing.Point(379, 2)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(106, 33)
        Me.BDelete.TabIndex = 1
        Me.BDelete.Text = "Delete Grup"
        '
        'BTambah
        '
        Me.BTambah.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTambah.Location = New System.Drawing.Point(589, 2)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(100, 33)
        Me.BTambah.TabIndex = 0
        Me.BTambah.Text = "Tambah Grup"
        '
        'GCGrupKontak
        '
        Me.GCGrupKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCGrupKontak.Location = New System.Drawing.Point(0, 37)
        Me.GCGrupKontak.MainView = Me.GVGrupKontak
        Me.GCGrupKontak.Name = "GCGrupKontak"
        Me.GCGrupKontak.Size = New System.Drawing.Size(691, 297)
        Me.GCGrupKontak.TabIndex = 0
        Me.GCGrupKontak.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGrupKontak, Me.GridView2})
        '
        'GVGrupKontak
        '
        Me.GVGrupKontak.GridControl = Me.GCGrupKontak
        Me.GVGrupKontak.Name = "GVGrupKontak"
        Me.GVGrupKontak.OptionsBehavior.ReadOnly = True
        Me.GVGrupKontak.OptionsFind.AlwaysVisible = True
        Me.GVGrupKontak.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCGrupKontak
        Me.GridView2.Name = "GridView2"
        '
        'XTCGrupKontak
        '
        Me.XTCGrupKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCGrupKontak.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left
        Me.XTCGrupKontak.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XTCGrupKontak.Location = New System.Drawing.Point(0, 0)
        Me.XTCGrupKontak.Name = "XTCGrupKontak"
        Me.XTCGrupKontak.SelectedTabPage = Me.XTPGrup
        Me.XTCGrupKontak.Size = New System.Drawing.Size(772, 339)
        Me.XTCGrupKontak.TabIndex = 2
        Me.XTCGrupKontak.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPGrup, Me.XTPMember})
        '
        'XTPGrup
        '
        Me.XTPGrup.Controls.Add(Me.GCGrupKontak)
        Me.XTPGrup.Controls.Add(Me.PanelControl1)
        Me.XTPGrup.Name = "XTPGrup"
        Me.XTPGrup.Size = New System.Drawing.Size(691, 334)
        Me.XTPGrup.Text = "Grup Kontak"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BRefresh)
        Me.PanelControl1.Controls.Add(Me.BDelete)
        Me.PanelControl1.Controls.Add(Me.BEdit)
        Me.PanelControl1.Controls.Add(Me.BTambah)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(691, 37)
        Me.PanelControl1.TabIndex = 3
        '
        'BRefresh
        '
        Me.BRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.BRefresh.Location = New System.Drawing.Point(2, 2)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(100, 33)
        Me.BRefresh.TabIndex = 3
        Me.BRefresh.Text = "Refresh"
        '
        'XTPMember
        '
        Me.XTPMember.Controls.Add(Me.GCKontak)
        Me.XTPMember.Controls.Add(Me.PanelControl2)
        Me.XTPMember.Name = "XTPMember"
        Me.XTPMember.Size = New System.Drawing.Size(691, 334)
        Me.XTPMember.Text = "Member Grup"
        '
        'GCKontak
        '
        Me.GCKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCKontak.Location = New System.Drawing.Point(0, 37)
        Me.GCKontak.MainView = Me.GVKontak
        Me.GCKontak.Name = "GCKontak"
        Me.GCKontak.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RCEContact})
        Me.GCKontak.Size = New System.Drawing.Size(691, 297)
        Me.GCKontak.TabIndex = 4
        Me.GCKontak.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVKontak})
        '
        'GVKontak
        '
        Me.GVKontak.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn1})
        Me.GVKontak.GridControl = Me.GCKontak
        Me.GVKontak.Name = "GVKontak"
        Me.GVKontak.OptionsBehavior.ReadOnly = True
        Me.GVKontak.OptionsFind.AlwaysVisible = True
        Me.GVKontak.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Id Kontak"
        Me.GridColumn2.FieldName = "id_kontak"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Nama"
        Me.GridColumn3.FieldName = "nama_kontak"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 369
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Nomor HP"
        Me.GridColumn4.FieldName = "no_hp"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 369
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Id Yahoo"
        Me.GridColumn5.FieldName = "email"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 373
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "No."
        Me.GridColumn1.FieldName = "no"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'RCEContact
        '
        Me.RCEContact.AutoHeight = False
        Me.RCEContact.Name = "RCEContact"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BDeleteMember)
        Me.PanelControl2.Controls.Add(Me.BAddMember)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(691, 37)
        Me.PanelControl2.TabIndex = 5
        '
        'BDeleteMember
        '
        Me.BDeleteMember.Dock = System.Windows.Forms.DockStyle.Right
        Me.BDeleteMember.Location = New System.Drawing.Point(483, 2)
        Me.BDeleteMember.Name = "BDeleteMember"
        Me.BDeleteMember.Size = New System.Drawing.Size(106, 33)
        Me.BDeleteMember.TabIndex = 1
        Me.BDeleteMember.Text = "Hapus Member"
        '
        'BAddMember
        '
        Me.BAddMember.Dock = System.Windows.Forms.DockStyle.Right
        Me.BAddMember.Location = New System.Drawing.Point(589, 2)
        Me.BAddMember.Name = "BAddMember"
        Me.BAddMember.Size = New System.Drawing.Size(100, 33)
        Me.BAddMember.TabIndex = 0
        Me.BAddMember.Text = "Tambah Member"
        '
        'FormGrupKontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 339)
        Me.Controls.Add(Me.XTCGrupKontak)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGrupKontak"
        Me.Text = "Grup Kontak"
        CType(Me.GCGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTCGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCGrupKontak.ResumeLayout(False)
        Me.XTPGrup.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.XTPMember.ResumeLayout(False)
        CType(Me.GCKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RCEContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTambah As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCGrupKontak As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVGrupKontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTCGrupKontak As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPGrup As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPMember As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCKontak As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVKontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RCEContact As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BDeleteMember As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BAddMember As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BRefresh As DevExpress.XtraEditors.SimpleButton
End Class
