<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBroadcast
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCGrupKontak = New DevExpress.XtraGrid.GridControl
        Me.GVGrupKontak = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BTambah = New DevExpress.XtraEditors.SimpleButton
        Me.BEdit = New DevExpress.XtraEditors.SimpleButton
        Me.BDelete = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCGrupKontak)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 61)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(948, 402)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Broadcast"
        '
        'GCGrupKontak
        '
        Me.GCGrupKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCGrupKontak.Location = New System.Drawing.Point(2, 22)
        Me.GCGrupKontak.MainView = Me.GVGrupKontak
        Me.GCGrupKontak.Name = "GCGrupKontak"
        Me.GCGrupKontak.Size = New System.Drawing.Size(944, 378)
        Me.GCGrupKontak.TabIndex = 0
        Me.GCGrupKontak.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVGrupKontak, Me.GridView2})
        '
        'GVGrupKontak
        '
        Me.GVGrupKontak.GridControl = Me.GCGrupKontak
        Me.GVGrupKontak.Name = "GVGrupKontak"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCGrupKontak
        Me.GridView2.Name = "GridView2"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BTambah)
        Me.GroupControl1.Controls.Add(Me.BEdit)
        Me.GroupControl1.Controls.Add(Me.BDelete)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(948, 61)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Command"
        '
        'BTambah
        '
        Me.BTambah.Dock = System.Windows.Forms.DockStyle.Right
        Me.BTambah.Location = New System.Drawing.Point(636, 22)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(100, 37)
        Me.BTambah.TabIndex = 0
        Me.BTambah.Text = "Tambah"
        '
        'BEdit
        '
        Me.BEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.BEdit.Location = New System.Drawing.Point(736, 22)
        Me.BEdit.Name = "BEdit"
        Me.BEdit.Size = New System.Drawing.Size(104, 37)
        Me.BEdit.TabIndex = 2
        Me.BEdit.Text = "Edit"
        '
        'BDelete
        '
        Me.BDelete.Dock = System.Windows.Forms.DockStyle.Right
        Me.BDelete.Location = New System.Drawing.Point(840, 22)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(106, 37)
        Me.BDelete.TabIndex = 1
        Me.BDelete.Text = "Delete"
        '
        'FormBroadcast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 463)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FormBroadcast"
        Me.Text = "Broadcast"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCGrupKontak As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVGrupKontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTambah As DevExpress.XtraEditors.SimpleButton
End Class
