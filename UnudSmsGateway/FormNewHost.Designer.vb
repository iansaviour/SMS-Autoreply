<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewHost
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
        Me.TEIdHost = New DevExpress.XtraEditors.TextEdit
        Me.TBPassword = New DevExpress.XtraEditors.TextEdit
        Me.TBUsername = New DevExpress.XtraEditors.TextEdit
        Me.TBHost = New DevExpress.XtraEditors.TextEdit
        Me.BCekKoneksi = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BSimpanHost = New DevExpress.XtraEditors.SimpleButton
        Me.BBatal = New DevExpress.XtraEditors.SimpleButton
        Me.TBNamaHost = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.CBDatabase = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TEIdHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TBNamaHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TEIdHost)
        Me.GroupControl1.Controls.Add(Me.TBPassword)
        Me.GroupControl1.Controls.Add(Me.TBUsername)
        Me.GroupControl1.Controls.Add(Me.TBHost)
        Me.GroupControl1.Controls.Add(Me.BCekKoneksi)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(281, 146)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Host"
        '
        'TEIdHost
        '
        Me.TEIdHost.Location = New System.Drawing.Point(172, 104)
        Me.TEIdHost.Name = "TEIdHost"
        Me.TEIdHost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.TEIdHost.Properties.Appearance.Options.UseFont = True
        Me.TEIdHost.Size = New System.Drawing.Size(100, 15)
        Me.TEIdHost.TabIndex = 0
        Me.TEIdHost.Visible = False
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(99, 81)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPassword.Properties.Appearance.Options.UseFont = True
        Me.TBPassword.Size = New System.Drawing.Size(173, 22)
        Me.TBPassword.TabIndex = 3
        '
        'TBUsername
        '
        Me.TBUsername.Location = New System.Drawing.Point(99, 54)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.Properties.Appearance.Options.UseFont = True
        Me.TBUsername.Size = New System.Drawing.Size(173, 22)
        Me.TBUsername.TabIndex = 2
        '
        'TBHost
        '
        Me.TBHost.Location = New System.Drawing.Point(99, 27)
        Me.TBHost.Name = "TBHost"
        Me.TBHost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBHost.Properties.Appearance.Options.UseFont = True
        Me.TBHost.Size = New System.Drawing.Size(173, 22)
        Me.TBHost.TabIndex = 1
        '
        'BCekKoneksi
        '
        Me.BCekKoneksi.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCekKoneksi.Location = New System.Drawing.Point(2, 121)
        Me.BCekKoneksi.Name = "BCekKoneksi"
        Me.BCekKoneksi.Size = New System.Drawing.Size(277, 23)
        Me.BCekKoneksi.TabIndex = 4
        Me.BCekKoneksi.Text = "Cek Koneksi"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(9, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(9, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Username"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(9, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Host"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BSimpanHost)
        Me.GroupControl2.Controls.Add(Me.BBatal)
        Me.GroupControl2.Controls.Add(Me.TBNamaHost)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.CBDatabase)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 146)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(281, 145)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Detail Host"
        '
        'BSimpanHost
        '
        Me.BSimpanHost.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpanHost.Location = New System.Drawing.Point(2, 97)
        Me.BSimpanHost.Name = "BSimpanHost"
        Me.BSimpanHost.Size = New System.Drawing.Size(277, 23)
        Me.BSimpanHost.TabIndex = 7
        Me.BSimpanHost.Text = "Simpan"
        '
        'BBatal
        '
        Me.BBatal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BBatal.Location = New System.Drawing.Point(2, 120)
        Me.BBatal.Name = "BBatal"
        Me.BBatal.Size = New System.Drawing.Size(277, 23)
        Me.BBatal.TabIndex = 8
        Me.BBatal.Text = "Batal"
        '
        'TBNamaHost
        '
        Me.TBNamaHost.Enabled = False
        Me.TBNamaHost.Location = New System.Drawing.Point(99, 61)
        Me.TBNamaHost.Name = "TBNamaHost"
        Me.TBNamaHost.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNamaHost.Properties.Appearance.Options.UseFont = True
        Me.TBNamaHost.Size = New System.Drawing.Size(173, 22)
        Me.TBNamaHost.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(9, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Nama Host"
        '
        'CBDatabase
        '
        Me.CBDatabase.Enabled = False
        Me.CBDatabase.Location = New System.Drawing.Point(99, 29)
        Me.CBDatabase.Name = "CBDatabase"
        Me.CBDatabase.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.CBDatabase.Properties.Appearance.Options.UseFont = True
        Me.CBDatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBDatabase.Size = New System.Drawing.Size(173, 23)
        Me.CBDatabase.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(9, 32)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Database"
        '
        'FormNewHost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewHost"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Host"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TEIdHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TBNamaHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TBPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TBUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TBHost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCekKoneksi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CBDatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BSimpanHost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BBatal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TBNamaHost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEIdHost As DevExpress.XtraEditors.TextEdit
End Class
