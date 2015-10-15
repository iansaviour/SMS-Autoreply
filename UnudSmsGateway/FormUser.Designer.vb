<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
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
        Me.BDeleteUser = New DevExpress.XtraEditors.SimpleButton
        Me.BEditUser = New DevExpress.XtraEditors.SimpleButton
        Me.BNewUser = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCUser = New DevExpress.XtraGrid.GridControl
        Me.GVUser = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BDeleteUser)
        Me.GroupControl1.Controls.Add(Me.BEditUser)
        Me.GroupControl1.Controls.Add(Me.BNewUser)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(610, 60)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Command"
        '
        'BDeleteUser
        '
        Me.BDeleteUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDeleteUser.Location = New System.Drawing.Point(152, 22)
        Me.BDeleteUser.Name = "BDeleteUser"
        Me.BDeleteUser.Size = New System.Drawing.Size(75, 36)
        Me.BDeleteUser.TabIndex = 2
        Me.BDeleteUser.Text = "Delete User"
        '
        'BEditUser
        '
        Me.BEditUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEditUser.Location = New System.Drawing.Point(77, 22)
        Me.BEditUser.Name = "BEditUser"
        Me.BEditUser.Size = New System.Drawing.Size(75, 36)
        Me.BEditUser.TabIndex = 1
        Me.BEditUser.Text = "Edit User"
        '
        'BNewUser
        '
        Me.BNewUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.BNewUser.Location = New System.Drawing.Point(2, 22)
        Me.BNewUser.Name = "BNewUser"
        Me.BNewUser.Size = New System.Drawing.Size(75, 36)
        Me.BNewUser.TabIndex = 0
        Me.BNewUser.Text = "New User"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCUser)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 60)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(610, 216)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "User"
        '
        'GCUser
        '
        Me.GCUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCUser.Location = New System.Drawing.Point(2, 22)
        Me.GCUser.MainView = Me.GVUser
        Me.GCUser.Name = "GCUser"
        Me.GCUser.Size = New System.Drawing.Size(606, 192)
        Me.GCUser.TabIndex = 0
        Me.GCUser.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVUser})
        '
        'GVUser
        '
        Me.GVUser.GridControl = Me.GCUser
        Me.GVUser.Name = "GVUser"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 276)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUser"
        Me.Text = "Manajemen User"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BNewUser As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCUser As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BEditUser As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDeleteUser As DevExpress.XtraEditors.SimpleButton
End Class
