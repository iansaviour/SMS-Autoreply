<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScheduler
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
        Me.GCModem = New DevExpress.XtraGrid.GridControl
        Me.GVModem = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BHapusModem = New DevExpress.XtraEditors.SimpleButton
        Me.BEditModem = New DevExpress.XtraEditors.SimpleButton
        Me.BTambahModem = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCModem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVModem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCModem)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 59)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(720, 344)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Gammu"
        '
        'GCModem
        '
        Me.GCModem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCModem.Location = New System.Drawing.Point(2, 22)
        Me.GCModem.MainView = Me.GVModem
        Me.GCModem.Name = "GCModem"
        Me.GCModem.Size = New System.Drawing.Size(716, 320)
        Me.GCModem.TabIndex = 0
        Me.GCModem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVModem})
        '
        'GVModem
        '
        Me.GVModem.GridControl = Me.GCModem
        Me.GVModem.Name = "GVModem"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BHapusModem)
        Me.GroupControl1.Controls.Add(Me.BEditModem)
        Me.GroupControl1.Controls.Add(Me.BTambahModem)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(720, 59)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Command"
        '
        'BHapusModem
        '
        Me.BHapusModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BHapusModem.Location = New System.Drawing.Point(196, 22)
        Me.BHapusModem.Name = "BHapusModem"
        Me.BHapusModem.Size = New System.Drawing.Size(97, 35)
        Me.BHapusModem.TabIndex = 2
        Me.BHapusModem.Text = "Hapus"
        '
        'BEditModem
        '
        Me.BEditModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEditModem.Location = New System.Drawing.Point(99, 22)
        Me.BEditModem.Name = "BEditModem"
        Me.BEditModem.Size = New System.Drawing.Size(97, 35)
        Me.BEditModem.TabIndex = 1
        Me.BEditModem.Text = "Edit"
        '
        'BTambahModem
        '
        Me.BTambahModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTambahModem.Location = New System.Drawing.Point(2, 22)
        Me.BTambahModem.Name = "BTambahModem"
        Me.BTambahModem.Size = New System.Drawing.Size(97, 35)
        Me.BTambahModem.TabIndex = 0
        Me.BTambahModem.Text = "Tambah"
        '
        'FormScheduler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 403)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormScheduler"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scheduler"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCModem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVModem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCModem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVModem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BHapusModem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEditModem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTambahModem As DevExpress.XtraEditors.SimpleButton
End Class
