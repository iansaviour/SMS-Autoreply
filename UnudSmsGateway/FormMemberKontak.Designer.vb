<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMemberKontak
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GCKontak = New DevExpress.XtraGrid.GridControl
        Me.GVKontak = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RCEContact = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
        Me.BRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.BDelete = New DevExpress.XtraEditors.SimpleButton
        Me.BEdit = New DevExpress.XtraEditors.SimpleButton
        Me.Badd = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GCKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RCEContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GCKontak)
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(797, 267)
        Me.PanelControl1.TabIndex = 0
        '
        'GCKontak
        '
        Me.GCKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCKontak.Location = New System.Drawing.Point(2, 39)
        Me.GCKontak.MainView = Me.GVKontak
        Me.GCKontak.Name = "GCKontak"
        Me.GCKontak.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RCEContact})
        Me.GCKontak.Size = New System.Drawing.Size(793, 226)
        Me.GCKontak.TabIndex = 3
        Me.GCKontak.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVKontak})
        '
        'GVKontak
        '
        Me.GVKontak.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GVKontak.GridControl = Me.GCKontak
        Me.GVKontak.Name = "GVKontak"
        Me.GVKontak.OptionsFind.AlwaysVisible = True
        Me.GVKontak.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "*"
        Me.GridColumn1.ColumnEdit = Me.RCEContact
        Me.GridColumn1.FieldName = "checkbox"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 66
        '
        'RCEContact
        '
        Me.RCEContact.AutoHeight = False
        Me.RCEContact.Name = "RCEContact"
        Me.RCEContact.ValueChecked = "yes"
        Me.RCEContact.ValueUnchecked = "no"
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
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.BRefresh)
        Me.PanelControl3.Controls.Add(Me.BDelete)
        Me.PanelControl3.Controls.Add(Me.BEdit)
        Me.PanelControl3.Controls.Add(Me.Badd)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(793, 37)
        Me.PanelControl3.TabIndex = 2
        '
        'BRefresh
        '
        Me.BRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.BRefresh.Location = New System.Drawing.Point(2, 2)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(97, 33)
        Me.BRefresh.TabIndex = 11
        Me.BRefresh.Text = "Refresh"
        '
        'BDelete
        '
        Me.BDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.BDelete.Location = New System.Drawing.Point(500, 2)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(97, 33)
        Me.BDelete.TabIndex = 10
        Me.BDelete.Text = "Delete Contact"
        '
        'BEdit
        '
        Me.BEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BEdit.Location = New System.Drawing.Point(597, 2)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(97, 33)
        Me.BEdit.TabIndex = 9
        Me.BEdit.Text = "Edit Contact"
        '
        'Badd
        '
        Me.Badd.Dock = System.Windows.Forms.DockStyle.Right
        Me.Badd.Location = New System.Drawing.Point(694, 2)
        Me.Badd.Name = "Badd"
        Me.Badd.Size = New System.Drawing.Size(97, 33)
        Me.Badd.TabIndex = 8
        Me.Badd.Text = "New Contact"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.BCancel)
        Me.PanelControl2.Controls.Add(Me.BSimpan)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 267)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(797, 58)
        Me.PanelControl2.TabIndex = 1
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BCancel.Location = New System.Drawing.Point(2, 2)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(793, 26)
        Me.BCancel.TabIndex = 1
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(2, 28)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(793, 28)
        Me.BSimpan.TabIndex = 0
        Me.BSimpan.Text = "Simpan"
        '
        'FormMemberKontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 325)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMemberKontak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Member Kontak"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GCKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RCEContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCKontak As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVKontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Badd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RCEContact As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents BRefresh As DevExpress.XtraEditors.SimpleButton
End Class
