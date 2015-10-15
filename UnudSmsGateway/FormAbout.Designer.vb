<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelNama = New DevExpress.XtraEditors.LabelControl
        Me.labelDeskripsi = New DevExpress.XtraEditors.LabelControl
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.UnudSmsGateway.My.Resources.Resources.message_icon
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(138, 136)
        Me.PictureEdit1.TabIndex = 0
        '
        'LabelNama
        '
        Me.LabelNama.Appearance.Font = New System.Drawing.Font("Arial", 14.0!)
        Me.LabelNama.Location = New System.Drawing.Point(156, 25)
        Me.LabelNama.MaximumSize = New System.Drawing.Size(300, 0)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(137, 22)
        Me.LabelNama.TabIndex = 1
        Me.LabelNama.Text = "UDAYANA SMS"
        '
        'labelDeskripsi
        '
        Me.labelDeskripsi.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.labelDeskripsi.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.labelDeskripsi.Location = New System.Drawing.Point(156, 53)
        Me.labelDeskripsi.MaximumSize = New System.Drawing.Size(300, 0)
        Me.labelDeskripsi.Name = "labelDeskripsi"
        Me.labelDeskripsi.Size = New System.Drawing.Size(101, 16)
        Me.labelDeskripsi.TabIndex = 2
        Me.labelDeskripsi.Text = "Divinkom @ 2012"
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(474, 160)
        Me.Controls.Add(Me.labelDeskripsi)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.PictureEdit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelNama As DevExpress.XtraEditors.LabelControl
    Friend WithEvents labelDeskripsi As DevExpress.XtraEditors.LabelControl
End Class
