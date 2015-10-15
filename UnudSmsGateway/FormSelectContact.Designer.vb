<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectContact
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BCancel = New DevExpress.XtraEditors.SimpleButton
        Me.BOk = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.CLBContact = New DevExpress.XtraEditors.CheckedListBoxControl
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.BCancelGrup = New DevExpress.XtraEditors.SimpleButton
        Me.BOkGrupKontak = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.CLBGrupKontak = New DevExpress.XtraEditors.CheckedListBoxControl
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CLBContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.CLBGrupKontak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(472, 327)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.GroupControl2)
        Me.XtraTabPage1.Controls.Add(Me.GroupControl1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(467, 302)
        Me.XtraTabPage1.Text = "Kontak"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BCancel)
        Me.GroupControl2.Controls.Add(Me.BOk)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 225)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(467, 77)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Command"
        '
        'BCancel
        '
        Me.BCancel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCancel.Location = New System.Drawing.Point(2, 50)
        Me.BCancel.Name = "BCancel"
        Me.BCancel.Size = New System.Drawing.Size(463, 28)
        Me.BCancel.TabIndex = 1
        Me.BCancel.Text = "Cancel"
        '
        'BOk
        '
        Me.BOk.Dock = System.Windows.Forms.DockStyle.Top
        Me.BOk.Location = New System.Drawing.Point(2, 22)
        Me.BOk.Name = "BOk"
        Me.BOk.Size = New System.Drawing.Size(463, 28)
        Me.BOk.TabIndex = 0
        Me.BOk.Text = "OK"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CLBContact)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(467, 225)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Contact"
        '
        'CLBContact
        '
        Me.CLBContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLBContact.Location = New System.Drawing.Point(2, 22)
        Me.CLBContact.Name = "CLBContact"
        Me.CLBContact.Size = New System.Drawing.Size(463, 201)
        Me.CLBContact.TabIndex = 2
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GroupControl3)
        Me.XtraTabPage2.Controls.Add(Me.GroupControl4)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(467, 302)
        Me.XtraTabPage2.Text = "Grup Kontak"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.BCancelGrup)
        Me.GroupControl3.Controls.Add(Me.BOkGrupKontak)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 225)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(467, 77)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "Command"
        '
        'BCancelGrup
        '
        Me.BCancelGrup.Dock = System.Windows.Forms.DockStyle.Top
        Me.BCancelGrup.Location = New System.Drawing.Point(2, 50)
        Me.BCancelGrup.Name = "BCancelGrup"
        Me.BCancelGrup.Size = New System.Drawing.Size(463, 28)
        Me.BCancelGrup.TabIndex = 1
        Me.BCancelGrup.Text = "Cancel"
        '
        'BOkGrupKontak
        '
        Me.BOkGrupKontak.Dock = System.Windows.Forms.DockStyle.Top
        Me.BOkGrupKontak.Location = New System.Drawing.Point(2, 22)
        Me.BOkGrupKontak.Name = "BOkGrupKontak"
        Me.BOkGrupKontak.Size = New System.Drawing.Size(463, 28)
        Me.BOkGrupKontak.TabIndex = 0
        Me.BOkGrupKontak.Text = "OK"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.CLBGrupKontak)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(467, 225)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Grup Contact"
        '
        'CLBGrupKontak
        '
        Me.CLBGrupKontak.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CLBGrupKontak.Location = New System.Drawing.Point(2, 22)
        Me.CLBGrupKontak.Name = "CLBGrupKontak"
        Me.CLBGrupKontak.Size = New System.Drawing.Size(463, 201)
        Me.CLBGrupKontak.TabIndex = 2
        '
        'FormSelectContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormSelectContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Contact"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CLBContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.CLBGrupKontak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CLBContact As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BCancelGrup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BOkGrupKontak As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CLBGrupKontak As DevExpress.XtraEditors.CheckedListBoxControl
End Class
