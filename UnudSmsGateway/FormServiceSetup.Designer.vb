<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormServiceSetup
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 73)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(315, 23)
        Me.BSimpan.TabIndex = 9
        Me.BSimpan.Text = "Simpan"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 96)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(315, 26)
        Me.BCancel.TabIndex = 10
        Me.BCancel.Text = "Cancel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Service"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.Location = New System.Drawing.Point(81, 7)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RadioGroup1.Properties.Appearance.Options.UseBackColor = True
        Me.RadioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Gammu"), New DevExpress.XtraEditors.Controls.RadioGroupItem("2", "Other")})
        Me.RadioGroup1.Size = New System.Drawing.Size(124, 60)
        Me.RadioGroup1.TabIndex = 13
        '
        'FormServiceSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 122)
        Me.Controls.Add(Me.RadioGroup1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormServiceSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Service"
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
End Class
