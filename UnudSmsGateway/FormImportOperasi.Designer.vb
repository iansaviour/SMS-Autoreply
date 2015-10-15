<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportOperasi
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
        Me.LEServerPartner = New DevExpress.XtraEditors.LookUpEdit
        Me.TEAlamat = New DevExpress.XtraEditors.TextEdit
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.BBrowse = New DevExpress.XtraEditors.SimpleButton
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.LEServerPartner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEAlamat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Alamat File XML"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Server Partner"
        '
        'LEServerPartner
        '
        Me.LEServerPartner.Location = New System.Drawing.Point(131, 41)
        Me.LEServerPartner.Name = "LEServerPartner"
        Me.LEServerPartner.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LEServerPartner.Properties.Appearance.Options.UseFont = True
        Me.LEServerPartner.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEServerPartner.Size = New System.Drawing.Size(334, 23)
        Me.LEServerPartner.TabIndex = 2
        '
        'TEAlamat
        '
        Me.TEAlamat.Location = New System.Drawing.Point(131, 12)
        Me.TEAlamat.Name = "TEAlamat"
        Me.TEAlamat.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEAlamat.Properties.Appearance.Options.UseFont = True
        Me.TEAlamat.Size = New System.Drawing.Size(256, 23)
        Me.TEAlamat.TabIndex = 3
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 102)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(477, 23)
        Me.BSimpan.TabIndex = 4
        Me.BSimpan.Text = "Simpan"
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(390, 12)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BBrowse.TabIndex = 5
        Me.BBrowse.Text = "Browse"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 79)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(477, 23)
        Me.BCancel.TabIndex = 6
        Me.BCancel.Text = "Cancel"
        '
        'FormImportOperasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 125)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BBrowse)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.TEAlamat)
        Me.Controls.Add(Me.LEServerPartner)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormImportOperasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Operasi"
        CType(Me.LEServerPartner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEAlamat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LEServerPartner As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TEAlamat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BBrowse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
End Class
