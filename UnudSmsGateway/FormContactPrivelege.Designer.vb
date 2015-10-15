<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormContactPrivelege
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
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        Me.CLBOperasi = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.BSAll = New DevExpress.XtraEditors.SimpleButton
        Me.BDSAll = New DevExpress.XtraEditors.SimpleButton
        CType(Me.CLBOperasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 250)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(454, 31)
        Me.BCancel.TabIndex = 7
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 219)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(454, 31)
        Me.BSimpan.TabIndex = 8
        Me.BSimpan.Text = "Simpan"
        '
        'CLBOperasi
        '
        Me.CLBOperasi.Dock = System.Windows.Forms.DockStyle.Top
        Me.CLBOperasi.Location = New System.Drawing.Point(0, 0)
        Me.CLBOperasi.Name = "CLBOperasi"
        Me.CLBOperasi.Size = New System.Drawing.Size(454, 185)
        Me.CLBOperasi.TabIndex = 9
        '
        'BSAll
        '
        Me.BSAll.Location = New System.Drawing.Point(0, 187)
        Me.BSAll.Name = "BSAll"
        Me.BSAll.Size = New System.Drawing.Size(227, 31)
        Me.BSAll.TabIndex = 10
        Me.BSAll.Text = "Select All"
        '
        'BDSAll
        '
        Me.BDSAll.Location = New System.Drawing.Point(224, 187)
        Me.BDSAll.Name = "BDSAll"
        Me.BDSAll.Size = New System.Drawing.Size(230, 31)
        Me.BDSAll.TabIndex = 11
        Me.BDSAll.Text = "Deselect All"
        '
        'FormContactPrivelege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.BDSAll)
        Me.Controls.Add(Me.BSAll)
        Me.Controls.Add(Me.CLBOperasi)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.BCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormContactPrivelege"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting Privelege"
        CType(Me.CLBOperasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CLBOperasi As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents BSAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDSAll As DevExpress.XtraEditors.SimpleButton
End Class
