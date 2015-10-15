<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewUser
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
        Me.TERepeat = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TEPassword = New DevExpress.XtraEditors.TextEdit
        Me.TEUsername = New DevExpress.XtraEditors.TextEdit
        Me.TENamaUser = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TERepeat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENamaUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TERepeat)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.TEPassword)
        Me.GroupControl1.Controls.Add(Me.TEUsername)
        Me.GroupControl1.Controls.Add(Me.TENamaUser)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(479, 167)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "User"
        '
        'TERepeat
        '
        Me.TERepeat.Location = New System.Drawing.Point(122, 130)
        Me.TERepeat.Name = "TERepeat"
        Me.TERepeat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TERepeat.Properties.Appearance.Options.UseFont = True
        Me.TERepeat.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TERepeat.Size = New System.Drawing.Size(345, 23)
        Me.TERepeat.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(12, 133)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(99, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Repeat Password"
        '
        'TEPassword
        '
        Me.TEPassword.Location = New System.Drawing.Point(122, 96)
        Me.TEPassword.Name = "TEPassword"
        Me.TEPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEPassword.Properties.Appearance.Options.UseFont = True
        Me.TEPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TEPassword.Size = New System.Drawing.Size(345, 23)
        Me.TEPassword.TabIndex = 3
        '
        'TEUsername
        '
        Me.TEUsername.Location = New System.Drawing.Point(122, 62)
        Me.TEUsername.Name = "TEUsername"
        Me.TEUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEUsername.Properties.Appearance.Options.UseFont = True
        Me.TEUsername.Size = New System.Drawing.Size(345, 23)
        Me.TEUsername.TabIndex = 2
        '
        'TENamaUser
        '
        Me.TENamaUser.Location = New System.Drawing.Point(122, 26)
        Me.TENamaUser.Name = "TENamaUser"
        Me.TENamaUser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENamaUser.Properties.Appearance.Options.UseFont = True
        Me.TENamaUser.Size = New System.Drawing.Size(345, 23)
        Me.TENamaUser.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Username"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nama User"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BCancel)
        Me.GroupControl2.Controls.Add(Me.BSimpan)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 167)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(479, 70)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Command"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BCancel.Location = New System.Drawing.Point(2, 45)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(475, 23)
        Me.BCancel.TabIndex = 6
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BSimpan.Location = New System.Drawing.Point(2, 22)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(475, 23)
        Me.BSimpan.TabIndex = 5
        Me.BSimpan.Text = "Simpan"
        '
        'FormNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 237)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TERepeat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENamaUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TENamaUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TERepeat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
