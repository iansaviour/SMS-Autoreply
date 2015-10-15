<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.MenuSMS = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.BBStartTimer = New DevExpress.XtraBars.BarButtonItem
        Me.STTimer = New DevExpress.XtraBars.BarStaticItem
        Me.BBStopTimer = New DevExpress.XtraBars.BarButtonItem
        Me.STDate = New DevExpress.XtraBars.BarStaticItem
        Me.BBContact = New DevExpress.XtraBars.BarButtonItem
        Me.BBUserManage = New DevExpress.XtraBars.BarButtonItem
        Me.BBStartService = New DevExpress.XtraBars.BarButtonItem
        Me.BBStopService = New DevExpress.XtraBars.BarButtonItem
        Me.BBManageOP = New DevExpress.XtraBars.BarButtonItem
        Me.BBLogin = New DevExpress.XtraBars.BarButtonItem
        Me.BBLogout = New DevExpress.XtraBars.BarButtonItem
        Me.BBServerConfig = New DevExpress.XtraBars.BarButtonItem
        Me.BBCharSpec = New DevExpress.XtraBars.BarButtonItem
        Me.BBContactGroup = New DevExpress.XtraBars.BarButtonItem
        Me.BBManageOperasiPartner = New DevExpress.XtraBars.BarButtonItem
        Me.BBHost = New DevExpress.XtraBars.BarButtonItem
        Me.BBHeader = New DevExpress.XtraBars.BarButtonItem
        Me.BBGammuConfig = New DevExpress.XtraBars.BarButtonItem
        Me.BBServerPartner = New DevExpress.XtraBars.BarButtonItem
        Me.BBSentMonitor = New DevExpress.XtraBars.BarButtonItem
        Me.BBRevievedMonitor = New DevExpress.XtraBars.BarButtonItem
        Me.BBAbout = New DevExpress.XtraBars.BarButtonItem
        Me.BBImportExport = New DevExpress.XtraBars.BarButtonItem
        Me.BBService = New DevExpress.XtraBars.BarButtonItem
        Me.BBScheduler = New DevExpress.XtraBars.BarButtonItem
        Me.IMGBarItem = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Login = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RPGManajemenUser = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RPOperasiAll = New DevExpress.XtraBars.Ribbon.RibbonPage
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RBPPartner = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RBPMonitor = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Me.RibbonPageCategory1 = New DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.SchedulerSMS = New System.Windows.Forms.Timer(Me.components)
        Me.TimerGeneral = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Me.BGWResponSMS = New System.ComponentModel.BackgroundWorker
        Me.ContextMenuStripYM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotifyIconSMS = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMGBarItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripYM.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonText = Nothing
        Me.RibbonControl.Controller = Me.BarAndDockingController1
        '
        '
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.ExpandCollapseItem.Name = ""
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.MenuSMS, Me.BarButtonItem1, Me.BBStartTimer, Me.STTimer, Me.BBStopTimer, Me.STDate, Me.BBContact, Me.BBUserManage, Me.BBStartService, Me.BBStopService, Me.BBManageOP, Me.BBLogin, Me.BBLogout, Me.BBServerConfig, Me.BBCharSpec, Me.BBContactGroup, Me.BBManageOperasiPartner, Me.BBHost, Me.BBHeader, Me.BBGammuConfig, Me.BBServerPartner, Me.BBSentMonitor, Me.BBRevievedMonitor, Me.BBAbout, Me.BBImportExport, Me.BBService, Me.BBScheduler})
        Me.RibbonControl.LargeImages = Me.IMGBarItem
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 44
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.Login, Me.RPOperasiAll})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTrackBar1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemCheckEdit3})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.RibbonControl.SelectedPage = Me.Login
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1168, 147)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        '
        'MenuSMS
        '
        Me.MenuSMS.Caption = "SMS"
        Me.MenuSMS.Id = 1
        Me.MenuSMS.LargeImageIndex = 3
        Me.MenuSMS.LargeWidth = 64
        Me.MenuSMS.Name = "MenuSMS"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Operasi"
        Me.BarButtonItem1.Id = 2
        Me.BarButtonItem1.LargeImageIndex = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BBStartTimer
        '
        Me.BBStartTimer.Caption = "Start Gammu"
        Me.BBStartTimer.Id = 3
        Me.BBStartTimer.Name = "BBStartTimer"
        '
        'STTimer
        '
        Me.STTimer.Caption = "Gammu Tidak Aktif"
        Me.STTimer.Id = 6
        Me.STTimer.Name = "STTimer"
        Me.STTimer.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BBStopTimer
        '
        Me.BBStopTimer.Caption = "Stop Gammu"
        Me.BBStopTimer.Enabled = False
        Me.BBStopTimer.Id = 7
        Me.BBStopTimer.Name = "BBStopTimer"
        '
        'STDate
        '
        Me.STDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.STDate.Id = 8
        Me.STDate.Name = "STDate"
        Me.STDate.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BBContact
        '
        Me.BBContact.Caption = "Contact"
        Me.BBContact.Id = 9
        Me.BBContact.LargeImageIndex = 4
        Me.BBContact.LargeWidth = 70
        Me.BBContact.Name = "BBContact"
        '
        'BBUserManage
        '
        Me.BBUserManage.Caption = "Manajemen User"
        Me.BBUserManage.Id = 10
        Me.BBUserManage.LargeImageIndex = 5
        Me.BBUserManage.LargeWidth = 100
        Me.BBUserManage.Name = "BBUserManage"
        '
        'BBStartService
        '
        Me.BBStartService.Caption = "Start"
        Me.BBStartService.Id = 12
        Me.BBStartService.LargeImageIndex = 8
        Me.BBStartService.LargeWidth = 64
        Me.BBStartService.Name = "BBStartService"
        '
        'BBStopService
        '
        Me.BBStopService.Caption = "Stop"
        Me.BBStopService.Enabled = False
        Me.BBStopService.Id = 13
        Me.BBStopService.LargeImageIndex = 0
        Me.BBStopService.LargeWidth = 64
        Me.BBStopService.Name = "BBStopService"
        '
        'BBManageOP
        '
        Me.BBManageOP.Caption = "Manage"
        Me.BBManageOP.Id = 14
        Me.BBManageOP.LargeImageIndex = 1
        Me.BBManageOP.LargeWidth = 64
        Me.BBManageOP.Name = "BBManageOP"
        '
        'BBLogin
        '
        Me.BBLogin.Caption = "Login"
        Me.BBLogin.Id = 15
        Me.BBLogin.LargeImageIndex = 6
        Me.BBLogin.LargeWidth = 64
        Me.BBLogin.Name = "BBLogin"
        '
        'BBLogout
        '
        Me.BBLogout.Caption = "Logout"
        Me.BBLogout.Enabled = False
        Me.BBLogout.Id = 16
        Me.BBLogout.LargeImageIndex = 7
        Me.BBLogout.LargeWidth = 64
        Me.BBLogout.Name = "BBLogout"
        '
        'BBServerConfig
        '
        Me.BBServerConfig.Caption = "Server Database"
        Me.BBServerConfig.Id = 17
        Me.BBServerConfig.LargeImageIndex = 9
        Me.BBServerConfig.LargeWidth = 100
        Me.BBServerConfig.Name = "BBServerConfig"
        '
        'BBCharSpec
        '
        Me.BBCharSpec.Caption = "Reserved String"
        Me.BBCharSpec.Id = 18
        Me.BBCharSpec.LargeImageIndex = 9
        Me.BBCharSpec.LargeWidth = 96
        Me.BBCharSpec.Name = "BBCharSpec"
        '
        'BBContactGroup
        '
        Me.BBContactGroup.Caption = "Grup Kontak"
        Me.BBContactGroup.Id = 19
        Me.BBContactGroup.LargeImageIndex = 10
        Me.BBContactGroup.LargeWidth = 70
        Me.BBContactGroup.Name = "BBContactGroup"
        '
        'BBManageOperasiPartner
        '
        Me.BBManageOperasiPartner.Caption = "Remote"
        Me.BBManageOperasiPartner.Id = 20
        Me.BBManageOperasiPartner.LargeImageIndex = 16
        Me.BBManageOperasiPartner.LargeWidth = 80
        Me.BBManageOperasiPartner.Name = "BBManageOperasiPartner"
        '
        'BBHost
        '
        Me.BBHost.Caption = "Server"
        Me.BBHost.Id = 21
        Me.BBHost.LargeImageIndex = 11
        Me.BBHost.LargeWidth = 80
        Me.BBHost.Name = "BBHost"
        '
        'BBHeader
        '
        Me.BBHeader.Caption = "General"
        Me.BBHeader.Id = 23
        Me.BBHeader.LargeImageIndex = 15
        Me.BBHeader.LargeWidth = 80
        Me.BBHeader.Name = "BBHeader"
        '
        'BBGammuConfig
        '
        Me.BBGammuConfig.Caption = "Modem"
        Me.BBGammuConfig.Id = 24
        Me.BBGammuConfig.LargeImageIndex = 9
        Me.BBGammuConfig.LargeWidth = 80
        Me.BBGammuConfig.Name = "BBGammuConfig"
        '
        'BBServerPartner
        '
        Me.BBServerPartner.Caption = "Partner"
        Me.BBServerPartner.Id = 28
        Me.BBServerPartner.LargeImageIndex = 11
        Me.BBServerPartner.LargeImageIndexDisabled = 11
        Me.BBServerPartner.LargeWidth = 80
        Me.BBServerPartner.Name = "BBServerPartner"
        '
        'BBSentMonitor
        '
        Me.BBSentMonitor.Caption = "Sent"
        Me.BBSentMonitor.Id = 30
        Me.BBSentMonitor.LargeImageIndex = 18
        Me.BBSentMonitor.LargeWidth = 80
        Me.BBSentMonitor.Name = "BBSentMonitor"
        '
        'BBRevievedMonitor
        '
        Me.BBRevievedMonitor.Caption = "Recieved"
        Me.BBRevievedMonitor.Id = 32
        Me.BBRevievedMonitor.LargeImageIndex = 17
        Me.BBRevievedMonitor.LargeWidth = 80
        Me.BBRevievedMonitor.Name = "BBRevievedMonitor"
        '
        'BBAbout
        '
        Me.BBAbout.Caption = "About"
        Me.BBAbout.Id = 33
        Me.BBAbout.LargeImageIndex = 19
        Me.BBAbout.LargeWidth = 80
        Me.BBAbout.Name = "BBAbout"
        '
        'BBImportExport
        '
        Me.BBImportExport.Caption = "Import Export Table"
        Me.BBImportExport.Id = 34
        Me.BBImportExport.LargeImageIndex = 20
        Me.BBImportExport.LargeWidth = 80
        Me.BBImportExport.Name = "BBImportExport"
        '
        'BBService
        '
        Me.BBService.Caption = "Setup"
        Me.BBService.Id = 41
        Me.BBService.LargeImageIndex = 15
        Me.BBService.LargeWidth = 70
        Me.BBService.Name = "BBService"
        '
        'BBScheduler
        '
        Me.BBScheduler.Caption = "Scheduler"
        Me.BBScheduler.Id = 42
        Me.BBScheduler.LargeImageIndex = 20
        Me.BBScheduler.LargeWidth = 64
        Me.BBScheduler.Name = "BBScheduler"
        '
        'IMGBarItem
        '
        Me.IMGBarItem.ImageSize = New System.Drawing.Size(32, 32)
        Me.IMGBarItem.ImageStream = CType(resources.GetObject("IMGBarItem.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.IMGBarItem.Images.SetKeyName(0, "18_32x32.png")
        Me.IMGBarItem.Images.SetKeyName(1, "checklist32.png")
        Me.IMGBarItem.Images.SetKeyName(2, "22_32x32.png")
        Me.IMGBarItem.Images.SetKeyName(3, "new-message32.png")
        Me.IMGBarItem.Images.SetKeyName(4, "Address Book-01 (3).png")
        Me.IMGBarItem.Images.SetKeyName(5, "Add-Male-User32.png")
        Me.IMGBarItem.Images.SetKeyName(6, "sign-in.png")
        Me.IMGBarItem.Images.SetKeyName(7, "sign-out.png")
        Me.IMGBarItem.Images.SetKeyName(8, "16_32x32.png")
        Me.IMGBarItem.Images.SetKeyName(9, "Gear Alt.png")
        Me.IMGBarItem.Images.SetKeyName(10, "Group.png")
        Me.IMGBarItem.Images.SetKeyName(11, "gnome_network_server.png")
        Me.IMGBarItem.Images.SetKeyName(12, "help_32.png")
        Me.IMGBarItem.Images.SetKeyName(13, "Warning1.png")
        Me.IMGBarItem.Images.SetKeyName(14, "Warning2.png")
        Me.IMGBarItem.Images.SetKeyName(15, "settings.png")
        Me.IMGBarItem.Images.SetKeyName(16, "remote.png")
        Me.IMGBarItem.Images.SetKeyName(17, "inbox.png")
        Me.IMGBarItem.Images.SetKeyName(18, "sent.png")
        Me.IMGBarItem.Images.SetKeyName(19, "about.png")
        Me.IMGBarItem.Images.SetKeyName(20, "Windows_Table_Icon_32.png")
        '
        'Login
        '
        Me.Login.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup3, Me.RPGManajemenUser, Me.RibbonPageGroup4})
        Me.Login.Name = "Login"
        Me.Login.Text = "General"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BBLogin)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BBLogout)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Login"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BBServerConfig)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BBImportExport)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Server"
        '
        'RPGManajemenUser
        '
        Me.RPGManajemenUser.ItemLinks.Add(Me.BBHeader)
        Me.RPGManajemenUser.ItemLinks.Add(Me.BBCharSpec)
        Me.RPGManajemenUser.ItemLinks.Add(Me.BBGammuConfig)
        Me.RPGManajemenUser.ItemLinks.Add(Me.BBUserManage)
        Me.RPGManajemenUser.Name = "RPGManajemenUser"
        Me.RPGManajemenUser.ShowCaptionButton = False
        Me.RPGManajemenUser.Text = "Setting"
        Me.RPGManajemenUser.Visible = False
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BBAbout)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "About"
        '
        'RPOperasiAll
        '
        Me.RPOperasiAll.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.RibbonPageGroup1, Me.RibbonPageGroup7, Me.RBPPartner, Me.RBPMonitor})
        Me.RPOperasiAll.Name = "RPOperasiAll"
        Me.RPOperasiAll.Text = "Operasi"
        Me.RPOperasiAll.Visible = False
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BBStartService)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BBStopService)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.BBService)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Service"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.MenuSMS)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BBContact)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BBContactGroup)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BBScheduler)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "SMS"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BBHost)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.BBManageOP)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Operasi"
        '
        'RBPPartner
        '
        Me.RBPPartner.ItemLinks.Add(Me.BBServerPartner)
        Me.RBPPartner.ItemLinks.Add(Me.BBManageOperasiPartner)
        Me.RBPPartner.Name = "RBPPartner"
        Me.RBPPartner.ShowCaptionButton = False
        Me.RBPPartner.Text = "Partner"
        '
        'RBPMonitor
        '
        Me.RBPMonitor.ItemLinks.Add(Me.BBSentMonitor)
        Me.RBPMonitor.ItemLinks.Add(Me.BBRevievedMonitor)
        Me.RBPMonitor.Name = "RBPMonitor"
        Me.RBPMonitor.Text = "Monitor"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemTrackBar1
        '
        Me.RepositoryItemTrackBar1.Name = "RepositoryItemTrackBar1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.STTimer)
        Me.RibbonStatusBar.ItemLinks.Add(Me.STDate)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 668)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1168, 31)
        '
        'RibbonPageCategory1
        '
        Me.RibbonPageCategory1.Color = System.Drawing.Color.Empty
        Me.RibbonPageCategory1.Name = "RibbonPageCategory1"
        Me.RibbonPageCategory1.Text = "RibbonPageCategory1"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.Controller = Me.BarAndDockingController1
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'SchedulerSMS
        '
        Me.SchedulerSMS.Interval = 3000
        '
        'TimerGeneral
        '
        Me.TimerGeneral.Interval = 10000
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Setting"
        '
        'BGWResponSMS
        '
        Me.BGWResponSMS.WorkerSupportsCancellation = True
        '
        'ContextMenuStripYM
        '
        Me.ContextMenuStripYM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.DashboardToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStripYM.Name = "ContextMenuStripYM"
        Me.ContextMenuStripYM.Size = New System.Drawing.Size(132, 70)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIconSMS
        '
        Me.NotifyIconSMS.ContextMenuStrip = Me.ContextMenuStripYM
        Me.NotifyIconSMS.Icon = CType(resources.GetObject("NotifyIconSMS.Icon"), System.Drawing.Icon)
        Me.NotifyIconSMS.Text = "Aplikasi SMS"
        Me.NotifyIconSMS.Visible = True
        '
        'RibbonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 699)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "RibbonForm"
        Me.Opacity = 0
        Me.Ribbon = Me.RibbonControl
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Udayana SMS"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMGBarItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripYM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents MenuSMS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageCategory1 As DevExpress.XtraBars.Ribbon.RibbonPageCategory
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SchedulerSMS As System.Windows.Forms.Timer
    Friend WithEvents BBStartTimer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents STTimer As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BBStopTimer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents STDate As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BBContact As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Login As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBUserManage As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RPGManajemenUser As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RPOperasiAll As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBStartService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBStopService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBManageOP As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBLogin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBLogout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBServerConfig As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBCharSpec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBContactGroup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBManageOperasiPartner As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RBPPartner As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBHost As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBHeader As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBGammuConfig As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TimerGeneral As System.Windows.Forms.Timer
    Friend WithEvents BBServerPartner As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RBPMonitor As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents IMGBarItem As DevExpress.Utils.ImageCollection
    Friend WithEvents BBSentMonitor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBRevievedMonitor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BGWResponSMS As System.ComponentModel.BackgroundWorker
    Friend WithEvents BBAbout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BBImportExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ContextMenuStripYM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIconSMS As System.Windows.Forms.NotifyIcon
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents BBService As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BBScheduler As DevExpress.XtraBars.BarButtonItem


End Class
