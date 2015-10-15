<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewContact))
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.TEEmail = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.TENoTelp = New DevExpress.XtraEditors.TextEdit
        Me.TENamaContact = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEditIcon = New DevExpress.XtraEditors.PictureEdit
        CType(Me.TEEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENoTelp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TENamaContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEditIcon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCancel
        '
        Me.BCancel.Location = New System.Drawing.Point(377, 120)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(87, 22)
        Me.BCancel.TabIndex = 1
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Location = New System.Drawing.Point(470, 120)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(88, 22)
        Me.BSimpan.TabIndex = 0
        Me.BSimpan.Text = "Simpan"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Location = New System.Drawing.Point(512, 84)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "@yahoo"
        '
        'TEEmail
        '
        Me.TEEmail.Location = New System.Drawing.Point(275, 81)
        Me.TEEmail.Name = "TEEmail"
        Me.TEEmail.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TEEmail.Properties.Appearance.Options.UseFont = True
        Me.TEEmail.Size = New System.Drawing.Size(231, 23)
        Me.TEEmail.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Location = New System.Drawing.Point(275, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "+62"
        '
        'TENoTelp
        '
        Me.TENoTelp.Location = New System.Drawing.Point(303, 47)
        Me.TENoTelp.Name = "TENoTelp"
        Me.TENoTelp.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENoTelp.Properties.Appearance.Options.UseFont = True
        Me.TENoTelp.Size = New System.Drawing.Size(255, 23)
        Me.TENoTelp.TabIndex = 4
        '
        'TENamaContact
        '
        Me.TENamaContact.Location = New System.Drawing.Point(275, 11)
        Me.TENamaContact.Name = "TENamaContact"
        Me.TENamaContact.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENamaContact.Properties.Appearance.Options.UseFont = True
        Me.TENamaContact.Size = New System.Drawing.Size(283, 23)
        Me.TENamaContact.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Location = New System.Drawing.Point(152, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Id Yahoo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Location = New System.Drawing.Point(152, 50)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nomor Telepon"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(152, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nama"
        '
        'PictureEditIcon
        '
        Me.PictureEditIcon.EditValue = CType(resources.GetObject("PictureEditIcon.EditValue"), Object)
        Me.PictureEditIcon.Location = New System.Drawing.Point(12, 12)
        Me.PictureEditIcon.Name = "PictureEditIcon"
        Me.PictureEditIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEditIcon.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEditIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEditIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEditIcon.Size = New System.Drawing.Size(124, 113)
        Me.PictureEditIcon.TabIndex = 18
        '
        'FormNewContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 160)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureEditIcon)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TEEmail)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TENamaContact)
        Me.Controls.Add(Me.TENoTelp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNewContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Contact"
        CType(Me.TEEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENoTelp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TENamaContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEditIcon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TEEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TENoTelp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TENamaContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureEditIcon As DevExpress.XtraEditors.PictureEdit
End Class
