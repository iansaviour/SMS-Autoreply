<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPanelOperasi
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCparameter = New DevExpress.XtraGrid.GridControl
        Me.GVParameter = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.TEIdOperasi = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GCViewOp = New DevExpress.XtraGrid.GridControl
        Me.GVViewOp = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GCLog = New DevExpress.XtraGrid.GridControl
        Me.GVLog = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BRefreshEksekusi = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCparameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVParameter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEIdOperasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GCViewOp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVViewOp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GCLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCparameter)
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(761, 224)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Parameter"
        '
        'GCparameter
        '
        Me.GCparameter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCparameter.Location = New System.Drawing.Point(2, 22)
        Me.GCparameter.MainView = Me.GVParameter
        Me.GCparameter.Name = "GCparameter"
        Me.GCparameter.Size = New System.Drawing.Size(757, 176)
        Me.GCparameter.TabIndex = 2
        Me.GCparameter.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVParameter})
        '
        'GVParameter
        '
        Me.GVParameter.GridControl = Me.GCparameter
        Me.GVParameter.Name = "GVParameter"
        Me.GVParameter.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 198)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(757, 24)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Eksekusi"
        '
        'TEIdOperasi
        '
        Me.TEIdOperasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.TEIdOperasi.Location = New System.Drawing.Point(0, 224)
        Me.TEIdOperasi.Name = "TEIdOperasi"
        Me.TEIdOperasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.TEIdOperasi.Properties.Appearance.Options.UseFont = True
        Me.TEIdOperasi.Size = New System.Drawing.Size(761, 15)
        Me.TEIdOperasi.TabIndex = 3
        Me.TEIdOperasi.Visible = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl3.Controls.Add(Me.BRefreshEksekusi)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 239)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(761, 369)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "View"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 22)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(757, 322)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GCViewOp)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(752, 297)
        Me.XtraTabPage1.Text = "View"
        '
        'GCViewOp
        '
        Me.GCViewOp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCViewOp.Location = New System.Drawing.Point(0, 0)
        Me.GCViewOp.MainView = Me.GVViewOp
        Me.GCViewOp.Name = "GCViewOp"
        Me.GCViewOp.Size = New System.Drawing.Size(752, 297)
        Me.GCViewOp.TabIndex = 1
        Me.GCViewOp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVViewOp})
        '
        'GVViewOp
        '
        Me.GVViewOp.GridControl = Me.GCViewOp
        Me.GVViewOp.Name = "GVViewOp"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GCLog)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(752, 297)
        Me.XtraTabPage2.Text = "Log"
        '
        'GCLog
        '
        Me.GCLog.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GCLog.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GCLog.Location = New System.Drawing.Point(0, 0)
        Me.GCLog.MainView = Me.GVLog
        Me.GCLog.Name = "GCLog"
        Me.GCLog.Size = New System.Drawing.Size(752, 297)
        Me.GCLog.TabIndex = 1
        Me.GCLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVLog, Me.GridView2})
        '
        'GVLog
        '
        Me.GVLog.GridControl = Me.GCLog
        Me.GVLog.Name = "GVLog"
        Me.GVLog.OptionsView.ShowGroupPanel = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCLog
        Me.GridView2.Name = "GridView2"
        '
        'BRefreshEksekusi
        '
        Me.BRefreshEksekusi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BRefreshEksekusi.Location = New System.Drawing.Point(2, 344)
        Me.BRefreshEksekusi.Name = "BRefreshEksekusi"
        Me.BRefreshEksekusi.Size = New System.Drawing.Size(757, 23)
        Me.BRefreshEksekusi.TabIndex = 0
        Me.BRefreshEksekusi.Text = "Refresh"
        '
        'FormPanelOperasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 608)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.TEIdOperasi)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPanelOperasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel Operasi"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCparameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVParameter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEIdOperasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GCViewOp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVViewOp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GCLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEIdOperasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCparameter As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVParameter As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BRefreshEksekusi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCViewOp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVViewOp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
