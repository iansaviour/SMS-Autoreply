<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGammu
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
        Me.BNmr = New DevExpress.XtraEditors.SimpleButton
        Me.BNetwork = New DevExpress.XtraEditors.SimpleButton
        Me.BCekPulsa = New DevExpress.XtraEditors.SimpleButton
        Me.BDefault = New DevExpress.XtraEditors.SimpleButton
        Me.BHapusModem = New DevExpress.XtraEditors.SimpleButton
        Me.BEditModem = New DevExpress.XtraEditors.SimpleButton
        Me.BTambahModem = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCModem = New DevExpress.XtraGrid.GridControl
        Me.GVModem = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCModem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVModem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.BNmr)
        Me.GroupControl1.Controls.Add(Me.BNetwork)
        Me.GroupControl1.Controls.Add(Me.BCekPulsa)
        Me.GroupControl1.Controls.Add(Me.BDefault)
        Me.GroupControl1.Controls.Add(Me.BHapusModem)
        Me.GroupControl1.Controls.Add(Me.BEditModem)
        Me.GroupControl1.Controls.Add(Me.BTambahModem)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(718, 59)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Command"
        '
        'BNmr
        '
        Me.BNmr.Dock = System.Windows.Forms.DockStyle.Left
        Me.BNmr.Location = New System.Drawing.Point(584, 22)
        Me.BNmr.Name = "BNmr"
        Me.BNmr.Size = New System.Drawing.Size(134, 35)
        Me.BNmr.TabIndex = 6
        Me.BNmr.Text = "Set Nomor Yang Dibalas"
        '
        'BNetwork
        '
        Me.BNetwork.Dock = System.Windows.Forms.DockStyle.Left
        Me.BNetwork.Location = New System.Drawing.Point(487, 22)
        Me.BNetwork.Name = "BNetwork"
        Me.BNetwork.Size = New System.Drawing.Size(97, 35)
        Me.BNetwork.TabIndex = 5
        Me.BNetwork.Text = "Cek Network"
        '
        'BCekPulsa
        '
        Me.BCekPulsa.Dock = System.Windows.Forms.DockStyle.Left
        Me.BCekPulsa.Location = New System.Drawing.Point(390, 22)
        Me.BCekPulsa.Name = "BCekPulsa"
        Me.BCekPulsa.Size = New System.Drawing.Size(97, 35)
        Me.BCekPulsa.TabIndex = 4
        Me.BCekPulsa.Text = "Cek Pulsa"
        '
        'BDefault
        '
        Me.BDefault.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDefault.Location = New System.Drawing.Point(293, 22)
        Me.BDefault.Name = "BDefault"
        Me.BDefault.Size = New System.Drawing.Size(97, 35)
        Me.BDefault.TabIndex = 3
        Me.BDefault.Text = "Set Default"
        '
        'BHapusModem
        '
        Me.BHapusModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BHapusModem.Location = New System.Drawing.Point(196, 22)
        Me.BHapusModem.Name = "BHapusModem"
        Me.BHapusModem.Size = New System.Drawing.Size(97, 35)
        Me.BHapusModem.TabIndex = 2
        Me.BHapusModem.Text = "Hapus"
        '
        'BEditModem
        '
        Me.BEditModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BEditModem.Location = New System.Drawing.Point(99, 22)
        Me.BEditModem.Name = "BEditModem"
        Me.BEditModem.Size = New System.Drawing.Size(97, 35)
        Me.BEditModem.TabIndex = 1
        Me.BEditModem.Text = "Edit"
        '
        'BTambahModem
        '
        Me.BTambahModem.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTambahModem.Location = New System.Drawing.Point(2, 22)
        Me.BTambahModem.Name = "BTambahModem"
        Me.BTambahModem.Size = New System.Drawing.Size(97, 35)
        Me.BTambahModem.TabIndex = 0
        Me.BTambahModem.Text = "Tambah"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCModem)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 59)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(718, 259)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Gammu"
        '
        'GCModem
        '
        Me.GCModem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCModem.Location = New System.Drawing.Point(2, 22)
        Me.GCModem.MainView = Me.GVModem
        Me.GCModem.Name = "GCModem"
        Me.GCModem.Size = New System.Drawing.Size(714, 235)
        Me.GCModem.TabIndex = 0
        Me.GCModem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVModem})
        '
        'GVModem
        '
        Me.GVModem.GridControl = Me.GCModem
        Me.GVModem.Name = "GVModem"
        '
        'FormGammu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 318)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "FormGammu"
        Me.Text = "Setting Modem"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCModem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVModem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BTambahModem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BHapusModem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BEditModem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCModem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVModem As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BDefault As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BCekPulsa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BNetwork As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BNmr As DevExpress.XtraEditors.SimpleButton
End Class
