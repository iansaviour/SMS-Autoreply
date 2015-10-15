<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSettingHost
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
        Me.GCHost = New DevExpress.XtraGrid.GridControl
        Me.GVHost = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BDeleteHost = New DevExpress.XtraEditors.SimpleButton
        Me.BEditHost = New DevExpress.XtraEditors.SimpleButton
        Me.BNewHost = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCHost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVHost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCHost)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 62)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(661, 277)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Host"
        '
        'GCHost
        '
        Me.GCHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCHost.Location = New System.Drawing.Point(2, 22)
        Me.GCHost.MainView = Me.GVHost
        Me.GCHost.Name = "GCHost"
        Me.GCHost.Size = New System.Drawing.Size(657, 253)
        Me.GCHost.TabIndex = 0
        Me.GCHost.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVHost})
        '
        'GVHost
        '
        Me.GVHost.GridControl = Me.GCHost
        Me.GVHost.Name = "GVHost"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BDeleteHost)
        Me.GroupControl1.Controls.Add(Me.BEditHost)
        Me.GroupControl1.Controls.Add(Me.BNewHost)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(661, 62)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Command"
        '
        'BDeleteHost
        '
        Me.BDeleteHost.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDeleteHost.Location = New System.Drawing.Point(160, 22)
        Me.BDeleteHost.Name = "BDeleteHost"
        Me.BDeleteHost.Size = New System.Drawing.Size(75, 38)
        Me.BDeleteHost.TabIndex = 3
        Me.BDeleteHost.Text = "Delete"
        '
        'BEditHost
        '
        Me.BEditHost.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEditHost.Location = New System.Drawing.Point(85, 22)
        Me.BEditHost.Name = "BEditHost"
        Me.BEditHost.Size = New System.Drawing.Size(75, 38)
        Me.BEditHost.TabIndex = 2
        Me.BEditHost.Text = "Edit"
        '
        'BNewHost
        '
        Me.BNewHost.Dock = System.Windows.Forms.DockStyle.Left
        Me.BNewHost.Location = New System.Drawing.Point(2, 22)
        Me.BNewHost.Name = "BNewHost"
        Me.BNewHost.Size = New System.Drawing.Size(83, 38)
        Me.BNewHost.TabIndex = 0
        Me.BNewHost.Text = "Tambah"
        '
        'FormSettingHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 339)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormSettingHost"
        Me.Text = "Host Local"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCHost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVHost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCHost As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVHost As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BDeleteHost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEditHost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BNewHost As DevExpress.XtraEditors.SimpleButton
End Class
