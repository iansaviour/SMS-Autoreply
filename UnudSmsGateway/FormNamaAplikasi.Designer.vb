<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNamaAplikasi
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
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.TEPemisah = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.CEBalasSpam = New DevExpress.XtraEditors.CheckEdit
        Me.TEHariHapus = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.CEStartStartup = New DevExpress.XtraEditors.CheckEdit
        Me.TEAlamatBackup = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.BBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.MEDeskripsi = New DevExpress.XtraEditors.MemoEdit
        Me.CEDeliveryReport = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.TESMSSetelah = New DevExpress.XtraEditors.TextEdit
        CType(Me.TEPemisah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEBalasSpam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHariHapus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEStartStartup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEAlamatBackup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEDeskripsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CEDeliveryReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TESMSSetelah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 262)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(548, 23)
        Me.BSimpan.TabIndex = 7
        Me.BSimpan.Text = "Simpan"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 285)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(548, 26)
        Me.BCancel.TabIndex = 8
        Me.BCancel.Text = "Cancel"
        '
        'TEPemisah
        '
        Me.TEPemisah.Location = New System.Drawing.Point(201, 7)
        Me.TEPemisah.Name = "TEPemisah"
        Me.TEPemisah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEPemisah.Properties.Appearance.Options.UseFont = True
        Me.TEPemisah.Size = New System.Drawing.Size(335, 23)
        Me.TEPemisah.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Nama Aplikasi"
        '
        'CEBalasSpam
        '
        Me.CEBalasSpam.Location = New System.Drawing.Point(199, 176)
        Me.CEBalasSpam.Name = "CEBalasSpam"
        Me.CEBalasSpam.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.CEBalasSpam.Properties.Appearance.Options.UseFont = True
        Me.CEBalasSpam.Properties.Caption = "Aktifkan Balas SMS Spam"
        Me.CEBalasSpam.Size = New System.Drawing.Size(172, 21)
        Me.CEBalasSpam.TabIndex = 5
        '
        'TEHariHapus
        '
        Me.TEHariHapus.Location = New System.Drawing.Point(201, 89)
        Me.TEHariHapus.Name = "TEHariHapus"
        Me.TEHariHapus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEHariHapus.Properties.Appearance.Options.UseFont = True
        Me.TEHariHapus.Size = New System.Drawing.Size(301, 23)
        Me.TEHariHapus.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(183, 16)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Hapus SMS Berumur Lebih Dari "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(513, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 16)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Hari"
        '
        'CEStartStartup
        '
        Me.CEStartStartup.Location = New System.Drawing.Point(199, 203)
        Me.CEStartStartup.Name = "CEStartStartup"
        Me.CEStartStartup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.CEStartStartup.Properties.Appearance.Options.UseFont = True
        Me.CEStartStartup.Properties.Caption = "Start Saat Windows Booting"
        Me.CEStartStartup.Size = New System.Drawing.Size(202, 21)
        Me.CEStartStartup.TabIndex = 6
        '
        'TEAlamatBackup
        '
        Me.TEAlamatBackup.Location = New System.Drawing.Point(201, 147)
        Me.TEAlamatBackup.Name = "TEAlamatBackup"
        Me.TEAlamatBackup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEAlamatBackup.Properties.Appearance.Options.UseFont = True
        Me.TEAlamatBackup.Properties.ReadOnly = True
        Me.TEAlamatBackup.Size = New System.Drawing.Size(243, 23)
        Me.TEAlamatBackup.TabIndex = 14
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(12, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(126, 16)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Lokasi Simpan Backup"
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(450, 148)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(86, 20)
        Me.BBrowse.TabIndex = 4
        Me.BBrowse.Text = "Browse"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Deskripsi Aplikasi"
        '
        'MEDeskripsi
        '
        Me.MEDeskripsi.Location = New System.Drawing.Point(201, 36)
        Me.MEDeskripsi.Name = "MEDeskripsi"
        Me.MEDeskripsi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.MEDeskripsi.Properties.Appearance.Options.UseFont = True
        Me.MEDeskripsi.Properties.MaxLength = 253
        Me.MEDeskripsi.Size = New System.Drawing.Size(335, 47)
        Me.MEDeskripsi.TabIndex = 2
        '
        'CEDeliveryReport
        '
        Me.CEDeliveryReport.Location = New System.Drawing.Point(199, 230)
        Me.CEDeliveryReport.Name = "CEDeliveryReport"
        Me.CEDeliveryReport.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.CEDeliveryReport.Properties.Appearance.Options.UseFont = True
        Me.CEDeliveryReport.Properties.Caption = "Aktifkan delivery report"
        Me.CEDeliveryReport.Size = New System.Drawing.Size(202, 21)
        Me.CEDeliveryReport.TabIndex = 16
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(12, 121)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(177, 16)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Kirim SMS Selanjutnya Setelah"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl7.Location = New System.Drawing.Point(508, 121)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(28, 16)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Detik"
        '
        'TESMSSetelah
        '
        Me.TESMSSetelah.Location = New System.Drawing.Point(201, 118)
        Me.TESMSSetelah.Name = "TESMSSetelah"
        Me.TESMSSetelah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TESMSSetelah.Properties.Appearance.Options.UseFont = True
        Me.TESMSSetelah.Size = New System.Drawing.Size(301, 23)
        Me.TESMSSetelah.TabIndex = 17
        '
        'FormNamaAplikasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.TESMSSetelah)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.CEDeliveryReport)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.BBrowse)
        Me.Controls.Add(Me.TEAlamatBackup)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.CEStartStartup)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TEHariHapus)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.CEBalasSpam)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.TEPemisah)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.MEDeskripsi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormNamaAplikasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Setting Aplikasi"
        CType(Me.TEPemisah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEBalasSpam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHariHapus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEStartStartup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEAlamatBackup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEDeskripsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CEDeliveryReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TESMSSetelah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEPemisah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEBalasSpam As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TEHariHapus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CEStartStartup As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TEAlamatBackup As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MEDeskripsi As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CEDeliveryReport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TESMSSetelah As DevExpress.XtraEditors.TextEdit
End Class
