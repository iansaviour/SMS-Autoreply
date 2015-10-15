<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TEUsername = New DevExpress.XtraEditors.TextEdit
        Me.TEPassword = New DevExpress.XtraEditors.TextEdit
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BLogin = New DevExpress.XtraEditors.SimpleButton
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(128, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Username"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(128, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Password"
        '
        'TEUsername
        '
        Me.TEUsername.Location = New System.Drawing.Point(226, 13)
        Me.TEUsername.Name = "TEUsername"
        Me.TEUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TEUsername.Properties.Appearance.Options.UseFont = True
        Me.TEUsername.Size = New System.Drawing.Size(295, 26)
        Me.TEUsername.TabIndex = 2
        '
        'TEPassword
        '
        Me.TEPassword.Location = New System.Drawing.Point(226, 45)
        Me.TEPassword.Name = "TEPassword"
        Me.TEPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TEPassword.Properties.Appearance.Options.UseFont = True
        Me.TEPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TEPassword.Size = New System.Drawing.Size(295, 26)
        Me.TEPassword.TabIndex = 3
        '
        'BCancel
        '
        Me.BCancel.Location = New System.Drawing.Point(446, 77)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(75, 32)
        Me.BCancel.TabIndex = 5
        Me.BCancel.Text = "Cancel"
        '
        'BLogin
        '
        Me.BLogin.Location = New System.Drawing.Point(365, 77)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(75, 32)
        Me.BLogin.TabIndex = 4
        Me.BLogin.Text = "Login"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.UnudSmsGateway.My.Resources.Resources.login_icon
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(100, 96)
        Me.PictureEdit1.TabIndex = 6
        '
        'FormLogin
        '
        Me.AcceptButton = Me.BLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 120)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.TEPassword)
        Me.Controls.Add(Me.TEUsername)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.LookAndFeel.SkinName = "Lilian"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
End Class
