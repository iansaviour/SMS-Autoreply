<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOperasi
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GCOperasiEks = New DevExpress.XtraGrid.GridControl
        Me.GVOperasiEks = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GCOperasiEks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVOperasiEks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(608, 59)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Command"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.SimpleButton1.Location = New System.Drawing.Point(2, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(97, 35)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Eksekusi"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GCOperasiEks)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 59)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(608, 260)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Operasi"
        '
        'GCOperasiEks
        '
        Me.GCOperasiEks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCOperasiEks.Location = New System.Drawing.Point(2, 22)
        Me.GCOperasiEks.MainView = Me.GVOperasiEks
        Me.GCOperasiEks.Name = "GCOperasiEks"
        Me.GCOperasiEks.Size = New System.Drawing.Size(604, 236)
        Me.GCOperasiEks.TabIndex = 0
        Me.GCOperasiEks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVOperasiEks})
        '
        'GVOperasiEks
        '
        Me.GVOperasiEks.GridControl = Me.GCOperasiEks
        Me.GVOperasiEks.Name = "GVOperasiEks"
        '
        'FormOperasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 319)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOperasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operasi"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GCOperasiEks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVOperasiEks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCOperasiEks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVOperasiEks As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
