<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServer
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
        Me.BSimpanHost = New DevExpress.XtraEditors.SimpleButton
        Me.CBDatabase = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.TBPassword = New DevExpress.XtraEditors.TextEdit
        Me.TBUsername = New DevExpress.XtraEditors.TextEdit
        Me.TBHost = New DevExpress.XtraEditors.TextEdit
        Me.BCekKoneksi = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CBDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.TBPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.BSimpanHost)
        Me.PanelControl1.Controls.Add(Me.CBDatabase)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 130)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(426, 81)
        Me.PanelControl1.TabIndex = 0
        '
        'BSimpanHost
        '
        Me.BSimpanHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpanHost.Enabled = False
        Me.BSimpanHost.Location = New System.Drawing.Point(2, 56)
        Me.BSimpanHost.Name = "BSimpanHost"
        Me.BSimpanHost.Size = New System.Drawing.Size(422, 23)
        Me.BSimpanHost.TabIndex = 6
        Me.BSimpanHost.Text = "Simpan"
        '
        'CBDatabase
        '
        Me.CBDatabase.Enabled = False
        Me.CBDatabase.Location = New System.Drawing.Point(99, 15)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.CBDatabase.Properties.Appearance.Options.UseFont = True
        Me.CBDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBDatabase.Size = New System.Drawing.Size(315, 23)
        Me.CBDatabase.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(9, 18)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Database"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.TBPassword)
        Me.PanelControl2.Controls.Add(Me.TBUsername)
        Me.PanelControl2.Controls.Add(Me.TBHost)
        Me.PanelControl2.Controls.Add(Me.BCekKoneksi)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(426, 130)
        Me.PanelControl2.TabIndex = 1
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(99, 69)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPassword.Properties.Appearance.Options.UseFont = True
        Me.TBPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(315, 22)
        Me.TBPassword.TabIndex = 3
        '
        'TBUsername
        '
        Me.TBUsername.Location = New System.Drawing.Point(99, 42)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.Properties.Appearance.Options.UseFont = True
        Me.TBUsername.Size = New System.Drawing.Size(315, 22)
        Me.TBUsername.TabIndex = 2
        '
        'TBHost
        '
        Me.TBHost.Location = New System.Drawing.Point(99, 15)
        Me.TBHost.Name = "TBHost"
        Me.TBHost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHost.Properties.Appearance.Options.UseFont = True
        Me.TBHost.Size = New System.Drawing.Size(315, 22)
        Me.TBHost.TabIndex = 1
        '
        'BCekKoneksi
        '
        Me.BCekKoneksi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCekKoneksi.Location = New System.Drawing.Point(2, 105)
        Me.BCekKoneksi.Name = "BCekKoneksi"
        Me.BCekKoneksi.Size = New System.Drawing.Size(422, 23)
        Me.BCekKoneksi.TabIndex = 4
        Me.BCekKoneksi.Text = "Cek Koneksi"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(9, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(9, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl2.TabIndex = 8
        Me.LabelControl2.Text = "Username"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(9, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Host"
        '
        'FormServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 211)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Konfigurasi Server"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CBDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.TBPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TBPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TBUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TBHost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCekKoneksi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BSimpanHost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBDatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
