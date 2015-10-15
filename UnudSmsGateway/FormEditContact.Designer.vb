<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditContact
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.BPrivelege = New DevExpress.XtraEditors.SimpleButton
        Me.BDeleteContact = New DevExpress.XtraEditors.SimpleButton
        Me.BEditContact = New DevExpress.XtraEditors.SimpleButton
        Me.BNewContact = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCContact = New DevExpress.XtraGrid.GridControl
        Me.GVContact = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.BPrintContact = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCContact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BPrintContact)
        Me.GroupControl1.Controls.Add(Me.BRefresh)
        Me.GroupControl1.Controls.Add(Me.BPrivelege)
        Me.GroupControl1.Controls.Add(Me.BDeleteContact)
        Me.GroupControl1.Controls.Add(Me.BEditContact)
        Me.GroupControl1.Controls.Add(Me.BNewContact)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(662, 61)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Command"
        '
        'BRefresh
        '
        Me.BRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.BRefresh.Location = New System.Drawing.Point(344, 22)
        Me.BRefresh.Name = "BRefresh"
        Me.BRefresh.Size = New System.Drawing.Size(75, 37)
        Me.BRefresh.TabIndex = 6
        Me.BRefresh.Text = "Refresh"
        '
        'BPrivelege
        '
        Me.BPrivelege.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrivelege.Location = New System.Drawing.Point(269, 22)
        Me.BPrivelege.Name = "BPrivelege"
        Me.BPrivelege.Size = New System.Drawing.Size(75, 37)
        Me.BPrivelege.TabIndex = 5
        Me.BPrivelege.Text = "Privelege"
        '
        'BDeleteContact
        '
        Me.BDeleteContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDeleteContact.Location = New System.Drawing.Point(174, 22)
        Me.BDeleteContact.Name = "BDeleteContact"
        Me.BDeleteContact.Size = New System.Drawing.Size(95, 37)
        Me.BDeleteContact.TabIndex = 2
        Me.BDeleteContact.Text = "Delete Contact"
        '
        'BEditContact
        '
        Me.BEditContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEditContact.Location = New System.Drawing.Point(86, 22)
        Me.BEditContact.Name = "BEditContact"
        Me.BEditContact.Size = New System.Drawing.Size(88, 37)
        Me.BEditContact.TabIndex = 1
        Me.BEditContact.Text = "Edit Contact"
        '
        'BNewContact
        '
        Me.BNewContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BNewContact.Location = New System.Drawing.Point(2, 22)
        Me.BNewContact.Name = "BNewContact"
        Me.BNewContact.Size = New System.Drawing.Size(84, 37)
        Me.BNewContact.TabIndex = 0
        Me.BNewContact.Text = "New Contact"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCContact)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 61)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(662, 243)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Contact"
        '
        'GCContact
        '
        Me.GCContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCContact.Location = New System.Drawing.Point(2, 22)
        Me.GCContact.MainView = Me.GVContact
        Me.GCContact.Name = "GCContact"
        Me.GCContact.Size = New System.Drawing.Size(658, 219)
        Me.GCContact.TabIndex = 0
        Me.GCContact.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVContact})
        '
        'GVContact
        '
        Me.GVContact.GridControl = Me.GCContact
        Me.GVContact.Name = "GVContact"
        '
        'BPrintContact
        '
        Me.BPrintContact.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrintContact.Location = New System.Drawing.Point(419, 22)
        Me.BPrintContact.Name = "BPrintContact"
        Me.BPrintContact.Size = New System.Drawing.Size(86, 37)
        Me.BPrintContact.TabIndex = 7
        Me.BPrintContact.Text = "Print"
        Me.BPrintContact.Visible = False
        '
        'FormEditContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 304)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Contact"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCContact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BNewContact As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEditContact As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BDeleteContact As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCContact As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVContact As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BPrivelege As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BPrintContact As DevExpress.XtraEditors.SimpleButton
End Class
