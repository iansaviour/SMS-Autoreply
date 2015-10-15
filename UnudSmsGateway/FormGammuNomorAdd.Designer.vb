<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGammuNomorAdd
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
        Me.CBNo3 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CBNo2 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.CBNo1 = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BSimpan = New DevExpress.XtraEditors.SimpleButton
        CType(Me.CBNo3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBNo2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CBNo1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBNo3
        '
        Me.CBNo3.EditValue = ""
        Me.CBNo3.Location = New System.Drawing.Point(298, 14)
        Me.CBNo3.Name = "CBNo3"
        Me.CBNo3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNo3.Properties.Appearance.Options.UseFont = True
        Me.CBNo3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBNo3.Properties.Items.AddRange(New Object() {"*", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CBNo3.Size = New System.Drawing.Size(67, 22)
        Me.CBNo3.TabIndex = 37
        '
        'CBNo2
        '
        Me.CBNo2.EditValue = ""
        Me.CBNo2.Location = New System.Drawing.Point(225, 14)
        Me.CBNo2.Name = "CBNo2"
        Me.CBNo2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNo2.Properties.Appearance.Options.UseFont = True
        Me.CBNo2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBNo2.Properties.Items.AddRange(New Object() {"*", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CBNo2.Size = New System.Drawing.Size(67, 22)
        Me.CBNo2.TabIndex = 36
        '
        'CBNo1
        '
        Me.CBNo1.EditValue = ""
        Me.CBNo1.Location = New System.Drawing.Point(152, 14)
        Me.CBNo1.Name = "CBNo1"
        Me.CBNo1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNo1.Properties.Appearance.Options.UseFont = True
        Me.CBNo1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CBNo1.Properties.Items.AddRange(New Object() {"*", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CBNo1.Size = New System.Drawing.Size(67, 22)
        Me.CBNo1.TabIndex = 35
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl7.Location = New System.Drawing.Point(124, 17)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(22, 16)
        Me.LabelControl7.TabIndex = 39
        Me.LabelControl7.Text = "+62"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Location = New System.Drawing.Point(12, 17)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Nomor Ditangani"
        '
        'BCancel
        '
        Me.BCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCancel.Location = New System.Drawing.Point(0, 52)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(396, 23)
        Me.BCancel.TabIndex = 41
        Me.BCancel.Text = "Cancel"
        '
        'BSimpan
        '
        Me.BSimpan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSimpan.Location = New System.Drawing.Point(0, 75)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(396, 23)
        Me.BSimpan.TabIndex = 40
        Me.BSimpan.Text = "Simpan"
        '
        'FormGammuNomorAdd
        '
        Me.AcceptButton = Me.BSimpan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BCancel
        Me.ClientSize = New System.Drawing.Size(396, 98)
        Me.Controls.Add(Me.BCancel)
        Me.Controls.Add(Me.BSimpan)
        Me.Controls.Add(Me.CBNo3)
        Me.Controls.Add(Me.CBNo2)
        Me.Controls.Add(Me.CBNo1)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGammuNomorAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomor"
        CType(Me.CBNo3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBNo2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CBNo1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBNo3 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CBNo2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CBNo1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BSimpan As DevExpress.XtraEditors.SimpleButton
End Class
