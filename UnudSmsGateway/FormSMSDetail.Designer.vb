<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSMSDetail
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
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LCDatetime = New DevExpress.XtraEditors.LabelControl
        Me.TEIsiSMS = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl
        Me.TBNomor = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TEIsiSMS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.TBNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.PanelControl1)
        Me.GroupControl7.Controls.Add(Me.TEIsiSMS)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(0, 49)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(627, 302)
        Me.GroupControl7.TabIndex = 10
        Me.GroupControl7.Text = "SMS"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LCDatetime)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 22)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(623, 30)
        Me.PanelControl1.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelControl3.Location = New System.Drawing.Point(541, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelControl3.Size = New System.Drawing.Size(64, 21)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Date time"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelControl2.Location = New System.Drawing.Point(605, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.LabelControl2.Size = New System.Drawing.Size(11, 21)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = ":"
        '
        'LCDatetime
        '
        Me.LCDatetime.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LCDatetime.Dock = System.Windows.Forms.DockStyle.Right
        Me.LCDatetime.Location = New System.Drawing.Point(616, 2)
        Me.LCDatetime.Name = "LCDatetime"
        Me.LCDatetime.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LCDatetime.Size = New System.Drawing.Size(5, 21)
        Me.LCDatetime.TabIndex = 0
        Me.LCDatetime.Text = "-"
        '
        'TEIsiSMS
        '
        Me.TEIsiSMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TEIsiSMS.Location = New System.Drawing.Point(2, 53)
        Me.TEIsiSMS.Name = "TEIsiSMS"
        Me.TEIsiSMS.Properties.ReadOnly = True
        Me.TEIsiSMS.Size = New System.Drawing.Size(623, 247)
        Me.TEIsiSMS.TabIndex = 8
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.TBNomor)
        Me.GroupControl5.Controls.Add(Me.SimpleButton2)
        Me.GroupControl5.Controls.Add(Me.SimpleButton1)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(627, 49)
        Me.GroupControl5.TabIndex = 9
        Me.GroupControl5.Text = "Nomor"
        '
        'TBNomor
        '
        Me.TBNomor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBNomor.Location = New System.Drawing.Point(2, 22)
        Me.TBNomor.Name = "TBNomor"
        Me.TBNomor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TBNomor.Properties.Appearance.Options.UseFont = True
        Me.TBNomor.Properties.ReadOnly = True
        Me.TBNomor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TBNomor.Size = New System.Drawing.Size(513, 26)
        Me.TBNomor.TabIndex = 8
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton2.Location = New System.Drawing.Point(515, 22)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(55, 25)
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "Reply"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.Location = New System.Drawing.Point(570, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(55, 25)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Foward"
        '
        'FormSMSDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 351)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.GroupControl5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSMSDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail"
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TEIsiSMS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.TBNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TEIsiSMS As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TBNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LCDatetime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
