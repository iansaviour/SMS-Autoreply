<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewGrupKontak
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
        Me.TENamaGrup = New DevExpress.XtraEditors.TextEdit
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.TENamaGrup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Nama Grup"
        '
        'TENamaGrup
        '
        Me.TENamaGrup.Location = New System.Drawing.Point(104, 9)
        Me.TENamaGrup.Name = "TENamaGrup"
        Me.TENamaGrup.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.TENamaGrup.Properties.Appearance.Options.UseFont = True
        Me.TENamaGrup.Size = New System.Drawing.Size(282, 23)
        Me.TENamaGrup.TabIndex = 1
        '
        'BSimpan
        '
        Me.BSimpan.Location = New System.Drawing.Point(311, 43)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(75, 23)
        Me.BSimpan.TabIndex = 2
        Me.BSimpan.Text = "Simpan"
        '
        'BCancel
        '
        Me.BCancel.Location = New System.Drawing.Point(230, 43)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(75, 23)
        Me.BCancel.TabIndex = 3
        Me.BCancel.Text = "Cancel"
        '
        'FormNewGrupKontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 78)
        Me.ControlBox = False
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.TENamaGrup)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormNewGrupKontak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grup Kontak"
        CType(Me.TENamaGrup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TENamaGrup As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
End Class
