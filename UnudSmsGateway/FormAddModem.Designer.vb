<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddModem
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
        Me.BBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.TEAlamat = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TEPin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.TEConnDev = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TEPortDev = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TENamaGammu = New DevExpress.XtraEditors.TextEdit
        Me.Nama = New DevExpress.XtraEditors.LabelControl
        Me.TENomor = New DevExpress.XtraEditors.TextEdit
        Me.LNomor = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.TECekPulsa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.TEAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEConnDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPortDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENamaGammu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECekPulsa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(431, 12)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(86, 23)
        Me.BBrowse.TabIndex = 1
        Me.BBrowse.Text = "Browse"
        '
        'TEAlamat
        '
        Me.TEAlamat.Location = New System.Drawing.Point(122, 12)
        Me.TEAlamat.Name = "TEAlamat"
        Me.TEAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEAlamat.Properties.Appearance.Options.UseFont = True
        Me.TEAlamat.Properties.ReadOnly = True
        Me.TEAlamat.Size = New System.Drawing.Size(303, 23)
        Me.TEAlamat.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 16)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Lokasi Service"
        '
        'TEPin
        '
        Me.TEPin.Location = New System.Drawing.Point(121, 138)
        Me.TEPin.Name = "TEPin"
        Me.TEPin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEPin.Properties.Appearance.Options.UseFont = True
        Me.TEPin.Size = New System.Drawing.Size(395, 23)
        Me.TEPin.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(9, 141)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(19, 16)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "PIN"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 234)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(528, 23)
        Me.BCancel.TabIndex = 12
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 257)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(528, 23)
        Me.BSimpan.TabIndex = 11
        Me.BSimpan.Text = "Simpan"
        '
        'TEConnDev
        '
        Me.TEConnDev.Location = New System.Drawing.Point(121, 108)
        Me.TEConnDev.Name = "TEConnDev"
        Me.TEConnDev.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEConnDev.Properties.Appearance.Options.UseFont = True
        Me.TEConnDev.Size = New System.Drawing.Size(395, 23)
        Me.TEConnDev.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(9, 111)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Connection"
        '
        'TEPortDev
        '
        Me.TEPortDev.Location = New System.Drawing.Point(121, 75)
        Me.TEPortDev.Name = "TEPortDev"
        Me.TEPortDev.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEPortDev.Properties.Appearance.Options.UseFont = True
        Me.TEPortDev.Size = New System.Drawing.Size(395, 23)
        Me.TEPortDev.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(9, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Port"
        '
        'TENamaGammu
        '
        Me.TENamaGammu.Location = New System.Drawing.Point(122, 44)
        Me.TENamaGammu.Name = "TENamaGammu"
        Me.TENamaGammu.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENamaGammu.Properties.Appearance.Options.UseFont = True
        Me.TENamaGammu.Size = New System.Drawing.Size(395, 23)
        Me.TENamaGammu.TabIndex = 2
        '
        'Nama
        '
        Me.Nama.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Nama.Location = New System.Drawing.Point(10, 47)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(33, 16)
        Me.Nama.TabIndex = 29
        Me.Nama.Text = "Nama"
        '
        'TENomor
        '
        Me.TENomor.Location = New System.Drawing.Point(149, 169)
        Me.TENomor.Name = "TENomor"
        Me.TENomor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENomor.Properties.Appearance.Options.UseFont = True
        Me.TENomor.Size = New System.Drawing.Size(367, 23)
        Me.TENomor.TabIndex = 6
        '
        'LNomor
        '
        Me.LNomor.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LNomor.Location = New System.Drawing.Point(9, 172)
        Me.LNomor.Name = "LNomor"
        Me.LNomor.Size = New System.Drawing.Size(38, 16)
        Me.LNomor.TabIndex = 31
        Me.LNomor.Text = "Nomor"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl8.Location = New System.Drawing.Point(122, 172)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "+62"
        '
        'TECekPulsa
        '
        Me.TECekPulsa.Location = New System.Drawing.Point(121, 198)
        Me.TECekPulsa.Name = "TECekPulsa"
        Me.TECekPulsa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TECekPulsa.Properties.Appearance.Options.UseFont = True
        Me.TECekPulsa.Size = New System.Drawing.Size(395, 23)
        Me.TECekPulsa.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(9, 201)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "Cek Pulsa"
        '
        'FormAddModem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.TECekPulsa)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.TENomor)
        Me.Controls.Add(Me.LNomor)
        Me.Controls.Add(Me.TENamaGammu)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.TEPin)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.TEConnDev)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TEPortDev)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.BBrowse)
        Me.Controls.Add(Me.TEAlamat)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormAddModem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Modem"
        CType(Me.TEAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEConnDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPortDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENamaGammu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECekPulsa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEConnDev As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPortDev As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TENamaGammu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TENomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LNomor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TECekPulsa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
