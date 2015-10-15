<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemisah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPemisah))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TEPemisah = New DevExpress.XtraEditors.TextEdit
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.TEBroadcastKw = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.TEBroadcastOperasi = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        CType(Me.TEPemisah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEBroadcastKw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEBroadcastOperasi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(131, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Karakter Pemisah"
        '
        'TEPemisah
        '
        Me.TEPemisah.Location = New System.Drawing.Point(265, 9)
        Me.TEPemisah.Name = "TEPemisah"
        Me.TEPemisah.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEPemisah.Properties.Appearance.Options.UseFont = True
        Me.TEPemisah.Size = New System.Drawing.Size(326, 23)
        Me.TEPemisah.TabIndex = 1
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 125)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(603, 26)
        Me.BCancel.TabIndex = 3
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 102)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(603, 23)
        Me.BSimpan.TabIndex = 2
        Me.BSimpan.Text = "Simpan"
        '
        'TEBroadcastKw
        '
        Me.TEBroadcastKw.Location = New System.Drawing.Point(265, 38)
        Me.TEBroadcastKw.Name = "TEBroadcastKw"
        Me.TEBroadcastKw.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEBroadcastKw.Properties.Appearance.Options.UseFont = True
        Me.TEBroadcastKw.Size = New System.Drawing.Size(326, 23)
        Me.TEBroadcastKw.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(131, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Broadcast"
        '
        'TEBroadcastOperasi
        '
        Me.TEBroadcastOperasi.Location = New System.Drawing.Point(265, 67)
        Me.TEBroadcastOperasi.Name = "TEBroadcastOperasi"
        Me.TEBroadcastOperasi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEBroadcastOperasi.Properties.Appearance.Options.UseFont = True
        Me.TEBroadcastOperasi.Size = New System.Drawing.Size(326, 23)
        Me.TEBroadcastOperasi.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(131, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(116, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Operasi + Broadcast"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.ContentImage = CType(resources.GetObject("PanelControl1.ContentImage"), System.Drawing.Image)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 11)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(113, 85)
        Me.PanelControl1.TabIndex = 8
        '
        'FormPemisah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 151)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.TEBroadcastOperasi)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TEBroadcastKw)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.TEPemisah)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPemisah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserved Character"
        CType(Me.TEPemisah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEBroadcastKw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEBroadcastOperasi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEPemisah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TEBroadcastKw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEBroadcastOperasi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
