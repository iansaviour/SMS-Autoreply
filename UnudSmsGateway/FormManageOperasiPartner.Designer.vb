<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageOperasiPartner
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
        Me.BPrint = New DevExpress.XtraEditors.SimpleButton
        Me.BEksekusi = New DevExpress.XtraEditors.SimpleButton
        Me.BDelete = New DevExpress.XtraEditors.SimpleButton
        Me.BImport = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCOperasiPartner = New DevExpress.XtraGrid.GridControl
        Me.GVOperasiPartner = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCOperasiPartner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOperasiPartner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BPrint)
        Me.GroupControl1.Controls.Add(Me.BEksekusi)
        Me.GroupControl1.Controls.Add(Me.BDelete)
        Me.GroupControl1.Controls.Add(Me.BImport)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(627, 68)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Command"
        '
        'BPrint
        '
        Me.BPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrint.Location = New System.Drawing.Point(269, 22)
        Me.BPrint.Name = "BPrint"
        Me.BPrint.Size = New System.Drawing.Size(86, 44)
        Me.BPrint.TabIndex = 9
        Me.BPrint.Text = "Print"
        '
        'BEksekusi
        '
        Me.BEksekusi.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEksekusi.Location = New System.Drawing.Point(180, 22)
        Me.BEksekusi.Name = "BEksekusi"
        Me.BEksekusi.Size = New System.Drawing.Size(89, 44)
        Me.BEksekusi.TabIndex = 2
        Me.BEksekusi.Text = "Eksekusi"
        '
        'BDelete
        '
        Me.BDelete.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDelete.Location = New System.Drawing.Point(91, 22)
        Me.BDelete.Name = "BDelete"
        Me.BDelete.Size = New System.Drawing.Size(89, 44)
        Me.BDelete.TabIndex = 1
        Me.BDelete.Text = "Delete"
        '
        'BImport
        '
        Me.BImport.Dock = System.Windows.Forms.DockStyle.Left
        Me.BImport.Location = New System.Drawing.Point(2, 22)
        Me.BImport.Name = "BImport"
        Me.BImport.Size = New System.Drawing.Size(89, 44)
        Me.BImport.TabIndex = 0
        Me.BImport.Text = "Import"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCOperasiPartner)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 68)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(627, 305)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Operasi"
        '
        'GCOperasiPartner
        '
        Me.GCOperasiPartner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOperasiPartner.Location = New System.Drawing.Point(2, 22)
        Me.GCOperasiPartner.MainView = Me.GVOperasiPartner
        Me.GCOperasiPartner.Name = "GCOperasiPartner"
        Me.GCOperasiPartner.Size = New System.Drawing.Size(623, 281)
        Me.GCOperasiPartner.TabIndex = 0
        Me.GCOperasiPartner.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOperasiPartner, Me.GridView2})
        '
        'GVOperasiPartner
        '
        Me.GVOperasiPartner.GridControl = Me.GCOperasiPartner
        Me.GVOperasiPartner.Name = "GVOperasiPartner"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCOperasiPartner
        Me.GridView2.Name = "GridView2"
        '
        'FormManageOperasiPartner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 373)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormManageOperasiPartner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Operasi Partner"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCOperasiPartner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOperasiPartner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCOperasiPartner As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOperasiPartner As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BEksekusi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BImport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BPrint As DevExpress.XtraEditors.SimpleButton
End Class
