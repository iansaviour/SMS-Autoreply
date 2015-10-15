<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMonitorSent
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
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.BPrintResult = New DevExpress.XtraEditors.SimpleButton
        Me.BPrint = New DevExpress.XtraEditors.SimpleButton
        Me.BDeleteInbox = New DevExpress.XtraEditors.SimpleButton
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.GCRequest = New DevExpress.XtraGrid.GridControl
        Me.GVRequest = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.id_op_in = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_hp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_message = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_operasi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GCResult = New DevExpress.XtraGrid.GridControl
        Me.GVResult = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GCRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GCResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.BPrintResult)
        Me.GroupControl2.Controls.Add(Me.BPrint)
        Me.GroupControl2.Controls.Add(Me.BDeleteInbox)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(737, 60)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Command"
        '
        'BPrintResult
        '
        Me.BPrintResult.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrintResult.Location = New System.Drawing.Point(163, 22)
        Me.BPrintResult.Name = "BPrintResult"
        Me.BPrintResult.Size = New System.Drawing.Size(86, 36)
        Me.BPrintResult.TabIndex = 10
        Me.BPrintResult.Text = "Print Result"
        '
        'BPrint
        '
        Me.BPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.BPrint.Location = New System.Drawing.Point(77, 22)
        Me.BPrint.Name = "BPrint"
        Me.BPrint.Size = New System.Drawing.Size(86, 36)
        Me.BPrint.TabIndex = 9
        Me.BPrint.Text = "Print Request"
        '
        'BDeleteInbox
        '
        Me.BDeleteInbox.Dock = System.Windows.Forms.DockStyle.Left
        Me.BDeleteInbox.Location = New System.Drawing.Point(2, 22)
        Me.BDeleteInbox.Name = "BDeleteInbox"
        Me.BDeleteInbox.Size = New System.Drawing.Size(75, 36)
        Me.BDeleteInbox.TabIndex = 0
        Me.BDeleteInbox.Text = "Delete"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl3)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(737, 359)
        Me.SplitContainerControl1.SplitterPosition = 172
        Me.SplitContainerControl1.TabIndex = 3
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GCRequest)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(737, 172)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Request"
        '
        'GCRequest
        '
        Me.GCRequest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCRequest.Location = New System.Drawing.Point(2, 22)
        Me.GCRequest.MainView = Me.GVRequest
        Me.GCRequest.Name = "GCRequest"
        Me.GCRequest.Size = New System.Drawing.Size(733, 148)
        Me.GCRequest.TabIndex = 0
        Me.GCRequest.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVRequest})
        '
        'GVRequest
        '
        Me.GVRequest.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id_op_in, Me.col_date, Me.col_time, Me.no_hp, Me.col_message, Me.col_operasi})
        Me.GVRequest.GridControl = Me.GCRequest
        Me.GVRequest.Name = "GVRequest"
        Me.GVRequest.OptionsBehavior.Editable = False
        '
        'id_op_in
        '
        Me.id_op_in.Caption = "Id Operasi In"
        Me.id_op_in.FieldName = "id_op_in"
        Me.id_op_in.Name = "id_op_in"
        '
        'col_date
        '
        Me.col_date.Caption = "Tanggal"
        Me.col_date.FieldName = "date"
        Me.col_date.Name = "col_date"
        Me.col_date.Visible = True
        Me.col_date.VisibleIndex = 0
        '
        'col_time
        '
        Me.col_time.Caption = "Waktu"
        Me.col_time.FieldName = "time"
        Me.col_time.Name = "col_time"
        Me.col_time.Visible = True
        Me.col_time.VisibleIndex = 1
        '
        'no_hp
        '
        Me.no_hp.Caption = "Nomor"
        Me.no_hp.FieldName = "no_hp"
        Me.no_hp.Name = "no_hp"
        Me.no_hp.Visible = True
        Me.no_hp.VisibleIndex = 3
        '
        'col_message
        '
        Me.col_message.Caption = "Message"
        Me.col_message.FieldName = "message"
        Me.col_message.Name = "col_message"
        Me.col_message.Visible = True
        Me.col_message.VisibleIndex = 2
        '
        'col_operasi
        '
        Me.col_operasi.Caption = "Operasi"
        Me.col_operasi.FieldName = "operasi"
        Me.col_operasi.Name = "col_operasi"
        Me.col_operasi.Visible = True
        Me.col_operasi.VisibleIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GCResult)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(737, 181)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Result"
        '
        'GCResult
        '
        Me.GCResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCResult.Location = New System.Drawing.Point(2, 22)
        Me.GCResult.MainView = Me.GVResult
        Me.GCResult.Name = "GCResult"
        Me.GCResult.Size = New System.Drawing.Size(733, 157)
        Me.GCResult.TabIndex = 0
        Me.GCResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVResult})
        '
        'GVResult
        '
        Me.GVResult.GridControl = Me.GCResult
        Me.GVResult.Name = "GVResult"
        Me.GVResult.OptionsBehavior.Editable = False
        '
        'FormMonitorSent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 419)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.LookAndFeel.SkinName = "Blue"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMonitorSent"
        Me.Text = "Monitor Sent Data"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GCRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GCResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BDeleteInbox As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCRequest As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVRequest As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVResult As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id_op_in As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_message As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_hp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_operasi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BPrintResult As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BPrint As DevExpress.XtraEditors.SimpleButton
End Class
