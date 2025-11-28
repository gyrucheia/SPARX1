<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        PercentTotalSubs = New Label()
        AmountSubs = New Label()
        ImgTotalSubs = New PictureBox()
        LabelTotalSubscribers = New Label()
        PercentMonthlyRevenue = New Label()
        AmountRevenue = New Label()
        ImgMonthlyRevenue = New PictureBox()
        LabelMonthlyRevenue = New Label()
        PercentActiveInstallation = New Label()
        AmountIntstall = New Label()
        ImgActiveInstall = New PictureBox()
        LabelActiveInstallation = New Label()
        PercentPendingService = New Label()
        AmountPendingServices = New Label()
        ImgPendingService = New PictureBox()
        LabelPendingService = New Label()
        PanelRound1 = New PanelRound()
        PanelRound2 = New PanelRound()
        PictureBox1 = New PictureBox()
        PanelRound3 = New PanelRound()
        PanelRound4 = New PanelRound()
        PanelRound5 = New PanelRound()
        SubscribersGrowth = New Label()
        PanelRound6 = New PanelRound()
        Label3 = New Label()
        LabelComplete = New Label()
        Label2 = New Label()
        ServiceStatusDistribution = New Label()
        Label1 = New Label()
        GreenDotComplete = New PictureBox()
        LblPending = New Label()
        OrangeDotProgress = New PictureBox()
        OrangePending = New PictureBox()
        LabelProgress = New Label()
        PanelSubscribersByPlan = New PanelRound()
        LabelSubscribersByPlan = New Label()
        PanelPremium = New PanelRound()
        PercentPremium = New Label()
        TotalPremium = New Label()
        AmountPremium = New Label()
        PremiumSubscribers = New Label()
        LabelPremium = New Label()
        PictureBox5 = New PictureBox()
        PanelStandard = New PanelRound()
        PercentStandard = New Label()
        LabelStandard = New Label()
        TotalStandard = New Label()
        PictureBox4 = New PictureBox()
        AmountStandard = New Label()
        StandardSubscribers = New Label()
        PanelBasic = New PanelRound()
        PercentBasic = New Label()
        BasicTotal = New Label()
        AmountBasic = New Label()
        BasicSubscribers = New Label()
        LabelBasic = New Label()
        PictureBox6 = New PictureBox()
        PanelRound7 = New PanelRound()
        PanelRound10 = New PanelRound()
        LabelMonthlyRevenueReached = New Label()
        PanelRound9 = New PanelRound()
        LabelPendingInstallations = New Label()
        PanelRound8 = New PanelRound()
        LabelLowStockInventory = New Label()
        PictureBox7 = New PictureBox()
        LabelSystemAlert = New Label()
        PanelRound11 = New PanelRound()
        PanelRound12 = New PanelRound()
        CType(ImgTotalSubs, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgMonthlyRevenue, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgActiveInstall, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgPendingService, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound1.SuspendLayout()
        PanelRound2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound3.SuspendLayout()
        PanelRound4.SuspendLayout()
        PanelRound5.SuspendLayout()
        PanelRound6.SuspendLayout()
        CType(GreenDotComplete, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrangeDotProgress, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrangePending, ComponentModel.ISupportInitialize).BeginInit()
        PanelSubscribersByPlan.SuspendLayout()
        PanelPremium.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PanelStandard.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PanelBasic.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound7.SuspendLayout()
        PanelRound10.SuspendLayout()
        PanelRound9.SuspendLayout()
        PanelRound8.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PercentTotalSubs
        ' 
        PercentTotalSubs.Anchor = AnchorStyles.Top
        PercentTotalSubs.AutoSize = True
        PercentTotalSubs.Font = New Font("Segoe UI", 10F)
        PercentTotalSubs.ForeColor = Color.FromArgb(CByte(0), CByte(201), CByte(80))
        PercentTotalSubs.Location = New Point(16, 80)
        PercentTotalSubs.Name = "PercentTotalSubs"
        PercentTotalSubs.Size = New Size(87, 19)
        PercentTotalSubs.TabIndex = 25
        PercentTotalSubs.Text = "[Placeholder]"
        ' 
        ' AmountSubs
        ' 
        AmountSubs.Anchor = AnchorStyles.Top
        AmountSubs.AutoSize = True
        AmountSubs.Font = New Font("Verdana", 16F)
        AmountSubs.Location = New Point(16, 47)
        AmountSubs.Name = "AmountSubs"
        AmountSubs.Size = New Size(68, 26)
        AmountSubs.TabIndex = 21
        AmountSubs.Text = "0000"
        ' 
        ' ImgTotalSubs
        ' 
        ImgTotalSubs.Anchor = AnchorStyles.Top
        ImgTotalSubs.Image = CType(resources.GetObject("ImgTotalSubs.Image"), Image)
        ImgTotalSubs.Location = New Point(300, 47)
        ImgTotalSubs.Name = "ImgTotalSubs"
        ImgTotalSubs.Size = New Size(45, 48)
        ImgTotalSubs.SizeMode = PictureBoxSizeMode.Zoom
        ImgTotalSubs.TabIndex = 18
        ImgTotalSubs.TabStop = False
        ' 
        ' LabelTotalSubscribers
        ' 
        LabelTotalSubscribers.Anchor = AnchorStyles.Top
        LabelTotalSubscribers.AutoSize = True
        LabelTotalSubscribers.Font = New Font("Verdana", 11F)
        LabelTotalSubscribers.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelTotalSubscribers.Location = New Point(16, 12)
        LabelTotalSubscribers.Name = "LabelTotalSubscribers"
        LabelTotalSubscribers.Size = New Size(133, 18)
        LabelTotalSubscribers.TabIndex = 14
        LabelTotalSubscribers.Text = "Total Subscribers"
        ' 
        ' PercentMonthlyRevenue
        ' 
        PercentMonthlyRevenue.Anchor = AnchorStyles.Top
        PercentMonthlyRevenue.AutoSize = True
        PercentMonthlyRevenue.Font = New Font("Segoe UI", 10F)
        PercentMonthlyRevenue.ForeColor = Color.FromArgb(CByte(0), CByte(201), CByte(80))
        PercentMonthlyRevenue.Location = New Point(18, 80)
        PercentMonthlyRevenue.Name = "PercentMonthlyRevenue"
        PercentMonthlyRevenue.Size = New Size(87, 19)
        PercentMonthlyRevenue.TabIndex = 27
        PercentMonthlyRevenue.Text = "[Placeholder]"
        ' 
        ' AmountRevenue
        ' 
        AmountRevenue.Anchor = AnchorStyles.Top
        AmountRevenue.AutoSize = True
        AmountRevenue.Font = New Font("Verdana", 16F)
        AmountRevenue.Location = New Point(18, 47)
        AmountRevenue.Name = "AmountRevenue"
        AmountRevenue.Size = New Size(68, 26)
        AmountRevenue.TabIndex = 23
        AmountRevenue.Text = "0000"
        ' 
        ' ImgMonthlyRevenue
        ' 
        ImgMonthlyRevenue.Anchor = AnchorStyles.Top
        ImgMonthlyRevenue.Image = CType(resources.GetObject("ImgMonthlyRevenue.Image"), Image)
        ImgMonthlyRevenue.Location = New Point(295, 47)
        ImgMonthlyRevenue.Name = "ImgMonthlyRevenue"
        ImgMonthlyRevenue.Size = New Size(45, 48)
        ImgMonthlyRevenue.SizeMode = PictureBoxSizeMode.Zoom
        ImgMonthlyRevenue.TabIndex = 19
        ImgMonthlyRevenue.TabStop = False
        ' 
        ' LabelMonthlyRevenue
        ' 
        LabelMonthlyRevenue.Anchor = AnchorStyles.Top
        LabelMonthlyRevenue.AutoSize = True
        LabelMonthlyRevenue.Font = New Font("Verdana", 11F)
        LabelMonthlyRevenue.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelMonthlyRevenue.Location = New Point(18, 12)
        LabelMonthlyRevenue.Name = "LabelMonthlyRevenue"
        LabelMonthlyRevenue.Size = New Size(136, 18)
        LabelMonthlyRevenue.TabIndex = 15
        LabelMonthlyRevenue.Text = "Monthly Revenue"
        ' 
        ' PercentActiveInstallation
        ' 
        PercentActiveInstallation.Anchor = AnchorStyles.Top
        PercentActiveInstallation.AutoSize = True
        PercentActiveInstallation.Font = New Font("Segoe UI", 10F)
        PercentActiveInstallation.ForeColor = Color.FromArgb(CByte(0), CByte(201), CByte(80))
        PercentActiveInstallation.Location = New Point(18, 80)
        PercentActiveInstallation.Name = "PercentActiveInstallation"
        PercentActiveInstallation.Size = New Size(87, 19)
        PercentActiveInstallation.TabIndex = 24
        PercentActiveInstallation.Text = "[Placeholder]"
        ' 
        ' AmountIntstall
        ' 
        AmountIntstall.Anchor = AnchorStyles.Top
        AmountIntstall.AutoSize = True
        AmountIntstall.Font = New Font("Verdana", 16F)
        AmountIntstall.Location = New Point(18, 47)
        AmountIntstall.Name = "AmountIntstall"
        AmountIntstall.Size = New Size(68, 26)
        AmountIntstall.TabIndex = 20
        AmountIntstall.Text = "0000"
        ' 
        ' ImgActiveInstall
        ' 
        ImgActiveInstall.Anchor = AnchorStyles.Top
        ImgActiveInstall.Image = CType(resources.GetObject("ImgActiveInstall.Image"), Image)
        ImgActiveInstall.Location = New Point(298, 47)
        ImgActiveInstall.Name = "ImgActiveInstall"
        ImgActiveInstall.Size = New Size(45, 48)
        ImgActiveInstall.SizeMode = PictureBoxSizeMode.Zoom
        ImgActiveInstall.TabIndex = 17
        ImgActiveInstall.TabStop = False
        ' 
        ' LabelActiveInstallation
        ' 
        LabelActiveInstallation.Anchor = AnchorStyles.Top
        LabelActiveInstallation.AutoSize = True
        LabelActiveInstallation.Font = New Font("Verdana", 11F)
        LabelActiveInstallation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelActiveInstallation.Location = New Point(18, 12)
        LabelActiveInstallation.Name = "LabelActiveInstallation"
        LabelActiveInstallation.Size = New Size(138, 18)
        LabelActiveInstallation.TabIndex = 13
        LabelActiveInstallation.Text = "Active Installation"
        ' 
        ' PercentPendingService
        ' 
        PercentPendingService.Anchor = AnchorStyles.Top
        PercentPendingService.AutoSize = True
        PercentPendingService.Font = New Font("Segoe UI", 10F)
        PercentPendingService.ForeColor = Color.FromArgb(CByte(0), CByte(201), CByte(80))
        PercentPendingService.Location = New Point(18, 80)
        PercentPendingService.Name = "PercentPendingService"
        PercentPendingService.Size = New Size(87, 19)
        PercentPendingService.TabIndex = 28
        PercentPendingService.Text = "[Placeholder]"
        ' 
        ' AmountPendingServices
        ' 
        AmountPendingServices.Anchor = AnchorStyles.Top
        AmountPendingServices.AutoSize = True
        AmountPendingServices.Font = New Font("Verdana", 16F)
        AmountPendingServices.Location = New Point(18, 47)
        AmountPendingServices.Name = "AmountPendingServices"
        AmountPendingServices.Size = New Size(68, 26)
        AmountPendingServices.TabIndex = 26
        AmountPendingServices.Text = "0000"
        ' 
        ' ImgPendingService
        ' 
        ImgPendingService.Anchor = AnchorStyles.Top
        ImgPendingService.Image = CType(resources.GetObject("ImgPendingService.Image"), Image)
        ImgPendingService.Location = New Point(300, 47)
        ImgPendingService.Name = "ImgPendingService"
        ImgPendingService.Size = New Size(45, 48)
        ImgPendingService.SizeMode = PictureBoxSizeMode.Zoom
        ImgPendingService.TabIndex = 22
        ImgPendingService.TabStop = False
        ' 
        ' LabelPendingService
        ' 
        LabelPendingService.Anchor = AnchorStyles.Top
        LabelPendingService.AutoSize = True
        LabelPendingService.Font = New Font("Verdana", 11F)
        LabelPendingService.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelPendingService.Location = New Point(18, 12)
        LabelPendingService.Name = "LabelPendingService"
        LabelPendingService.Size = New Size(132, 18)
        LabelPendingService.TabIndex = 16
        LabelPendingService.Text = "Pending Services"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(LabelTotalSubscribers)
        PanelRound1.Controls.Add(PercentTotalSubs)
        PanelRound1.Controls.Add(ImgTotalSubs)
        PanelRound1.Controls.Add(AmountSubs)
        PanelRound1.CornerRadius = 12
        PanelRound1.Location = New Point(38, 26)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(367, 142)
        PanelRound1.TabIndex = 29
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = Color.White
        PanelRound2.Controls.Add(PictureBox1)
        PanelRound2.Controls.Add(LabelMonthlyRevenue)
        PanelRound2.Controls.Add(PercentMonthlyRevenue)
        PanelRound2.Controls.Add(ImgMonthlyRevenue)
        PanelRound2.Controls.Add(AmountRevenue)
        PanelRound2.CornerRadius = 12
        PanelRound2.Location = New Point(449, 26)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(367, 142)
        PanelRound2.TabIndex = 30
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.Location = New Point(383, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 48)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.White
        PanelRound3.Controls.Add(LabelActiveInstallation)
        PanelRound3.Controls.Add(ImgActiveInstall)
        PanelRound3.Controls.Add(AmountIntstall)
        PanelRound3.Controls.Add(PercentActiveInstallation)
        PanelRound3.CornerRadius = 12
        PanelRound3.Location = New Point(857, 26)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(367, 142)
        PanelRound3.TabIndex = 31
        ' 
        ' PanelRound4
        ' 
        PanelRound4.BackColor = Color.White
        PanelRound4.Controls.Add(LabelPendingService)
        PanelRound4.Controls.Add(ImgPendingService)
        PanelRound4.Controls.Add(AmountPendingServices)
        PanelRound4.Controls.Add(PercentPendingService)
        PanelRound4.CornerRadius = 12
        PanelRound4.Location = New Point(1268, 26)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(367, 142)
        PanelRound4.TabIndex = 32
        ' 
        ' PanelRound5
        ' 
        PanelRound5.BackColor = Color.White
        PanelRound5.Controls.Add(SubscribersGrowth)
        PanelRound5.CornerRadius = 12
        PanelRound5.Location = New Point(38, 195)
        PanelRound5.Name = "PanelRound5"
        PanelRound5.Size = New Size(778, 405)
        PanelRound5.TabIndex = 33
        ' 
        ' SubscribersGrowth
        ' 
        SubscribersGrowth.Anchor = AnchorStyles.Top
        SubscribersGrowth.AutoSize = True
        SubscribersGrowth.Font = New Font("Verdana", 11F)
        SubscribersGrowth.ForeColor = Color.Black
        SubscribersGrowth.Location = New Point(27, 15)
        SubscribersGrowth.Name = "SubscribersGrowth"
        SubscribersGrowth.Size = New Size(154, 18)
        SubscribersGrowth.TabIndex = 35
        SubscribersGrowth.Text = "Subscribers Growth"
        ' 
        ' PanelRound6
        ' 
        PanelRound6.BackColor = Color.White
        PanelRound6.Controls.Add(Label3)
        PanelRound6.Controls.Add(LabelComplete)
        PanelRound6.Controls.Add(Label2)
        PanelRound6.Controls.Add(ServiceStatusDistribution)
        PanelRound6.Controls.Add(Label1)
        PanelRound6.Controls.Add(GreenDotComplete)
        PanelRound6.Controls.Add(LblPending)
        PanelRound6.Controls.Add(OrangeDotProgress)
        PanelRound6.Controls.Add(OrangePending)
        PanelRound6.Controls.Add(LabelProgress)
        PanelRound6.CornerRadius = 12
        PanelRound6.Location = New Point(857, 195)
        PanelRound6.Name = "PanelRound6"
        PanelRound6.Size = New Size(778, 405)
        PanelRound6.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        Label3.Location = New Point(692, 361)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 20)
        Label3.TabIndex = 35
        Label3.Text = "(%)"
        ' 
        ' LabelComplete
        ' 
        LabelComplete.Anchor = AnchorStyles.Top
        LabelComplete.AutoSize = True
        LabelComplete.Font = New Font("Segoe UI", 11F)
        LabelComplete.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelComplete.Location = New Point(59, 361)
        LabelComplete.Name = "LabelComplete"
        LabelComplete.Size = New Size(74, 20)
        LabelComplete.TabIndex = 37
        LabelComplete.Text = "Complete"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        Label2.Location = New Point(432, 361)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 20)
        Label2.TabIndex = 44
        Label2.Text = "(%)"
        ' 
        ' ServiceStatusDistribution
        ' 
        ServiceStatusDistribution.Anchor = AnchorStyles.Top
        ServiceStatusDistribution.AutoSize = True
        ServiceStatusDistribution.Font = New Font("Verdana", 11F)
        ServiceStatusDistribution.ForeColor = Color.Black
        ServiceStatusDistribution.Location = New Point(27, 15)
        ServiceStatusDistribution.Name = "ServiceStatusDistribution"
        ServiceStatusDistribution.Size = New Size(203, 18)
        ServiceStatusDistribution.TabIndex = 36
        ServiceStatusDistribution.Text = "Service Status Distribution"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        Label1.Location = New Point(139, 361)
        Label1.Name = "Label1"
        Label1.Size = New Size(31, 20)
        Label1.TabIndex = 43
        Label1.Text = "(%)"
        ' 
        ' GreenDotComplete
        ' 
        GreenDotComplete.Anchor = AnchorStyles.Top
        GreenDotComplete.Image = CType(resources.GetObject("GreenDotComplete.Image"), Image)
        GreenDotComplete.Location = New Point(41, 364)
        GreenDotComplete.Name = "GreenDotComplete"
        GreenDotComplete.Size = New Size(12, 12)
        GreenDotComplete.SizeMode = PictureBoxSizeMode.Zoom
        GreenDotComplete.TabIndex = 38
        GreenDotComplete.TabStop = False
        ' 
        ' LblPending
        ' 
        LblPending.Anchor = AnchorStyles.Top
        LblPending.AutoSize = True
        LblPending.Font = New Font("Segoe UI", 11F)
        LblPending.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LblPending.Location = New Point(627, 361)
        LblPending.Name = "LblPending"
        LblPending.Size = New Size(62, 20)
        LblPending.TabIndex = 42
        LblPending.Text = "Pending"
        ' 
        ' OrangeDotProgress
        ' 
        OrangeDotProgress.Anchor = AnchorStyles.Top
        OrangeDotProgress.Image = CType(resources.GetObject("OrangeDotProgress.Image"), Image)
        OrangeDotProgress.Location = New Point(322, 364)
        OrangeDotProgress.Name = "OrangeDotProgress"
        OrangeDotProgress.Size = New Size(12, 12)
        OrangeDotProgress.SizeMode = PictureBoxSizeMode.Zoom
        OrangeDotProgress.TabIndex = 39
        OrangeDotProgress.TabStop = False
        ' 
        ' OrangePending
        ' 
        OrangePending.Anchor = AnchorStyles.Top
        OrangePending.Image = CType(resources.GetObject("OrangePending.Image"), Image)
        OrangePending.Location = New Point(609, 364)
        OrangePending.Name = "OrangePending"
        OrangePending.Size = New Size(12, 12)
        OrangePending.SizeMode = PictureBoxSizeMode.Zoom
        OrangePending.TabIndex = 41
        OrangePending.TabStop = False
        ' 
        ' LabelProgress
        ' 
        LabelProgress.Anchor = AnchorStyles.Top
        LabelProgress.AutoSize = True
        LabelProgress.Font = New Font("Segoe UI", 11F)
        LabelProgress.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelProgress.Location = New Point(340, 361)
        LabelProgress.Name = "LabelProgress"
        LabelProgress.Size = New Size(81, 20)
        LabelProgress.TabIndex = 40
        LabelProgress.Text = "In Progress"
        ' 
        ' PanelSubscribersByPlan
        ' 
        PanelSubscribersByPlan.BackColor = Color.White
        PanelSubscribersByPlan.Controls.Add(LabelSubscribersByPlan)
        PanelSubscribersByPlan.Controls.Add(PanelPremium)
        PanelSubscribersByPlan.Controls.Add(PanelStandard)
        PanelSubscribersByPlan.Controls.Add(PanelBasic)
        PanelSubscribersByPlan.Location = New Point(38, 632)
        PanelSubscribersByPlan.Name = "PanelSubscribersByPlan"
        PanelSubscribersByPlan.Size = New Size(1597, 481)
        PanelSubscribersByPlan.TabIndex = 35
        ' 
        ' LabelSubscribersByPlan
        ' 
        LabelSubscribersByPlan.Anchor = AnchorStyles.Top
        LabelSubscribersByPlan.AutoSize = True
        LabelSubscribersByPlan.Font = New Font("Verdana", 11F)
        LabelSubscribersByPlan.ForeColor = Color.Black
        LabelSubscribersByPlan.Location = New Point(27, 20)
        LabelSubscribersByPlan.Name = "LabelSubscribersByPlan"
        LabelSubscribersByPlan.Size = New Size(203, 18)
        LabelSubscribersByPlan.TabIndex = 16
        LabelSubscribersByPlan.Text = "Service Status Distribution"
        ' 
        ' PanelPremium
        ' 
        PanelPremium.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelPremium.Controls.Add(PercentPremium)
        PanelPremium.Controls.Add(TotalPremium)
        PanelPremium.Controls.Add(AmountPremium)
        PanelPremium.Controls.Add(PremiumSubscribers)
        PanelPremium.Controls.Add(LabelPremium)
        PanelPremium.Controls.Add(PictureBox5)
        PanelPremium.CornerRadius = 12
        PanelPremium.Location = New Point(697, 292)
        PanelPremium.Name = "PanelPremium"
        PanelPremium.Size = New Size(861, 74)
        PanelPremium.TabIndex = 2
        ' 
        ' PercentPremium
        ' 
        PercentPremium.Anchor = AnchorStyles.Top
        PercentPremium.AutoSize = True
        PercentPremium.Font = New Font("Segoe UI", 11F)
        PercentPremium.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        PercentPremium.Location = New Point(747, 40)
        PercentPremium.Name = "PercentPremium"
        PercentPremium.Size = New Size(37, 20)
        PercentPremium.TabIndex = 33
        PercentPremium.Text = "00%"
        ' 
        ' TotalPremium
        ' 
        TotalPremium.Anchor = AnchorStyles.Top
        TotalPremium.AutoSize = True
        TotalPremium.Font = New Font("Segoe UI", 11F)
        TotalPremium.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        TotalPremium.Location = New Point(787, 40)
        TotalPremium.Name = "TotalPremium"
        TotalPremium.Size = New Size(58, 20)
        TotalPremium.TabIndex = 31
        TotalPremium.Text = "of total"
        ' 
        ' AmountPremium
        ' 
        AmountPremium.Anchor = AnchorStyles.Top
        AmountPremium.AutoSize = True
        AmountPremium.Font = New Font("Segoe UI", 11F)
        AmountPremium.ForeColor = Color.Black
        AmountPremium.Location = New Point(725, 15)
        AmountPremium.Name = "AmountPremium"
        AmountPremium.Size = New Size(25, 20)
        AmountPremium.TabIndex = 32
        AmountPremium.Text = "00"
        ' 
        ' PremiumSubscribers
        ' 
        PremiumSubscribers.Anchor = AnchorStyles.Top
        PremiumSubscribers.AutoSize = True
        PremiumSubscribers.Font = New Font("Segoe UI", 11F)
        PremiumSubscribers.ForeColor = Color.Black
        PremiumSubscribers.Location = New Point(762, 15)
        PremiumSubscribers.Name = "PremiumSubscribers"
        PremiumSubscribers.Size = New Size(84, 20)
        PremiumSubscribers.TabIndex = 30
        PremiumSubscribers.Text = "Subscribers"
        ' 
        ' LabelPremium
        ' 
        LabelPremium.Anchor = AnchorStyles.Top
        LabelPremium.AutoSize = True
        LabelPremium.Font = New Font("Segoe UI", 11F)
        LabelPremium.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        LabelPremium.Location = New Point(32, 24)
        LabelPremium.Name = "LabelPremium"
        LabelPremium.Size = New Size(133, 20)
        LabelPremium.TabIndex = 29
        LabelPremium.Text = "Premium 100Mbps"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(14, 28)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(12, 12)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 28
        PictureBox5.TabStop = False
        ' 
        ' PanelStandard
        ' 
        PanelStandard.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelStandard.Controls.Add(PercentStandard)
        PanelStandard.Controls.Add(LabelStandard)
        PanelStandard.Controls.Add(TotalStandard)
        PanelStandard.Controls.Add(PictureBox4)
        PanelStandard.Controls.Add(AmountStandard)
        PanelStandard.Controls.Add(StandardSubscribers)
        PanelStandard.CornerRadius = 12
        PanelStandard.Location = New Point(697, 196)
        PanelStandard.Name = "PanelStandard"
        PanelStandard.Size = New Size(861, 74)
        PanelStandard.TabIndex = 1
        ' 
        ' PercentStandard
        ' 
        PercentStandard.Anchor = AnchorStyles.Top
        PercentStandard.AutoSize = True
        PercentStandard.Font = New Font("Segoe UI", 11F)
        PercentStandard.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        PercentStandard.Location = New Point(743, 40)
        PercentStandard.Name = "PercentStandard"
        PercentStandard.Size = New Size(37, 20)
        PercentStandard.TabIndex = 33
        PercentStandard.Text = "00%"
        ' 
        ' LabelStandard
        ' 
        LabelStandard.Anchor = AnchorStyles.Top
        LabelStandard.AutoSize = True
        LabelStandard.Font = New Font("Segoe UI", 11F)
        LabelStandard.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        LabelStandard.Location = New Point(32, 24)
        LabelStandard.Name = "LabelStandard"
        LabelStandard.Size = New Size(126, 20)
        LabelStandard.TabIndex = 29
        LabelStandard.Text = "Standard 50Mbps"
        ' 
        ' TotalStandard
        ' 
        TotalStandard.Anchor = AnchorStyles.Top
        TotalStandard.AutoSize = True
        TotalStandard.Font = New Font("Segoe UI", 11F)
        TotalStandard.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        TotalStandard.Location = New Point(787, 40)
        TotalStandard.Name = "TotalStandard"
        TotalStandard.Size = New Size(58, 20)
        TotalStandard.TabIndex = 31
        TotalStandard.Text = "of total"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(14, 28)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 12)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 28
        PictureBox4.TabStop = False
        ' 
        ' AmountStandard
        ' 
        AmountStandard.Anchor = AnchorStyles.Top
        AmountStandard.AutoSize = True
        AmountStandard.Font = New Font("Segoe UI", 11F)
        AmountStandard.ForeColor = Color.Black
        AmountStandard.Location = New Point(725, 15)
        AmountStandard.Name = "AmountStandard"
        AmountStandard.Size = New Size(25, 20)
        AmountStandard.TabIndex = 32
        AmountStandard.Text = "00"
        ' 
        ' StandardSubscribers
        ' 
        StandardSubscribers.Anchor = AnchorStyles.Top
        StandardSubscribers.AutoSize = True
        StandardSubscribers.Font = New Font("Segoe UI", 11F)
        StandardSubscribers.ForeColor = Color.Black
        StandardSubscribers.Location = New Point(762, 15)
        StandardSubscribers.Name = "StandardSubscribers"
        StandardSubscribers.Size = New Size(84, 20)
        StandardSubscribers.TabIndex = 30
        StandardSubscribers.Text = "Subscribers"
        ' 
        ' PanelBasic
        ' 
        PanelBasic.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelBasic.Controls.Add(PercentBasic)
        PanelBasic.Controls.Add(BasicTotal)
        PanelBasic.Controls.Add(AmountBasic)
        PanelBasic.Controls.Add(BasicSubscribers)
        PanelBasic.Controls.Add(LabelBasic)
        PanelBasic.Controls.Add(PictureBox6)
        PanelBasic.CornerRadius = 12
        PanelBasic.Location = New Point(697, 99)
        PanelBasic.Name = "PanelBasic"
        PanelBasic.Size = New Size(861, 74)
        PanelBasic.TabIndex = 0
        ' 
        ' PercentBasic
        ' 
        PercentBasic.Anchor = AnchorStyles.Top
        PercentBasic.AutoSize = True
        PercentBasic.Font = New Font("Segoe UI", 11F)
        PercentBasic.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        PercentBasic.Location = New Point(747, 40)
        PercentBasic.Name = "PercentBasic"
        PercentBasic.Size = New Size(37, 20)
        PercentBasic.TabIndex = 29
        PercentBasic.Text = "00%"
        ' 
        ' BasicTotal
        ' 
        BasicTotal.Anchor = AnchorStyles.Top
        BasicTotal.AutoSize = True
        BasicTotal.Font = New Font("Segoe UI", 11F)
        BasicTotal.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        BasicTotal.Location = New Point(787, 40)
        BasicTotal.Name = "BasicTotal"
        BasicTotal.Size = New Size(58, 20)
        BasicTotal.TabIndex = 25
        BasicTotal.Text = "of total"
        ' 
        ' AmountBasic
        ' 
        AmountBasic.Anchor = AnchorStyles.Top
        AmountBasic.AutoSize = True
        AmountBasic.Font = New Font("Segoe UI", 11F)
        AmountBasic.ForeColor = Color.Black
        AmountBasic.Location = New Point(724, 15)
        AmountBasic.Name = "AmountBasic"
        AmountBasic.Size = New Size(25, 20)
        AmountBasic.TabIndex = 28
        AmountBasic.Text = "00"
        ' 
        ' BasicSubscribers
        ' 
        BasicSubscribers.Anchor = AnchorStyles.Top
        BasicSubscribers.AutoSize = True
        BasicSubscribers.Font = New Font("Segoe UI", 11F)
        BasicSubscribers.ForeColor = Color.Black
        BasicSubscribers.Location = New Point(762, 15)
        BasicSubscribers.Name = "BasicSubscribers"
        BasicSubscribers.Size = New Size(84, 20)
        BasicSubscribers.TabIndex = 24
        BasicSubscribers.Text = "Subscribers"
        ' 
        ' LabelBasic
        ' 
        LabelBasic.Anchor = AnchorStyles.Top
        LabelBasic.AutoSize = True
        LabelBasic.Font = New Font("Segoe UI", 11F)
        LabelBasic.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        LabelBasic.Location = New Point(32, 28)
        LabelBasic.Name = "LabelBasic"
        LabelBasic.Size = New Size(100, 20)
        LabelBasic.TabIndex = 26
        LabelBasic.Text = "Basic 25Mbps"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(14, 32)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 12)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 27
        PictureBox6.TabStop = False
        ' 
        ' PanelRound7
        ' 
        PanelRound7.BackColor = Color.White
        PanelRound7.Controls.Add(PanelRound10)
        PanelRound7.Controls.Add(PanelRound9)
        PanelRound7.Controls.Add(PanelRound8)
        PanelRound7.Controls.Add(PictureBox7)
        PanelRound7.Controls.Add(LabelSystemAlert)
        PanelRound7.CornerRadius = 12
        PanelRound7.Location = New Point(45, 1142)
        PanelRound7.Name = "PanelRound7"
        PanelRound7.Size = New Size(1590, 306)
        PanelRound7.TabIndex = 36
        ' 
        ' PanelRound10
        ' 
        PanelRound10.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelRound10.Controls.Add(LabelMonthlyRevenueReached)
        PanelRound10.CornerRadius = 12
        PanelRound10.Location = New Point(39, 226)
        PanelRound10.Name = "PanelRound10"
        PanelRound10.Size = New Size(1519, 59)
        PanelRound10.TabIndex = 21
        ' 
        ' LabelMonthlyRevenueReached
        ' 
        LabelMonthlyRevenueReached.Anchor = AnchorStyles.Top
        LabelMonthlyRevenueReached.AutoSize = True
        LabelMonthlyRevenueReached.Font = New Font("Segoe UI", 11F)
        LabelMonthlyRevenueReached.ForeColor = Color.FromArgb(CByte(1), CByte(102), CByte(48))
        LabelMonthlyRevenueReached.Location = New Point(6, 20)
        LabelMonthlyRevenueReached.Name = "LabelMonthlyRevenueReached"
        LabelMonthlyRevenueReached.Size = New Size(97, 20)
        LabelMonthlyRevenueReached.TabIndex = 31
        LabelMonthlyRevenueReached.Text = "[Placeholder]"
        ' 
        ' PanelRound9
        ' 
        PanelRound9.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelRound9.Controls.Add(LabelPendingInstallations)
        PanelRound9.CornerRadius = 12
        PanelRound9.Location = New Point(39, 145)
        PanelRound9.Name = "PanelRound9"
        PanelRound9.Size = New Size(1519, 59)
        PanelRound9.TabIndex = 20
        ' 
        ' LabelPendingInstallations
        ' 
        LabelPendingInstallations.Anchor = AnchorStyles.Top
        LabelPendingInstallations.AutoSize = True
        LabelPendingInstallations.Font = New Font("Segoe UI", 11F)
        LabelPendingInstallations.ForeColor = Color.FromArgb(CByte(25), CByte(60), CByte(184))
        LabelPendingInstallations.Location = New Point(6, 19)
        LabelPendingInstallations.Name = "LabelPendingInstallations"
        LabelPendingInstallations.Size = New Size(97, 20)
        LabelPendingInstallations.TabIndex = 30
        LabelPendingInstallations.Text = "[Placeholder]"
        ' 
        ' PanelRound8
        ' 
        PanelRound8.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelRound8.Controls.Add(LabelLowStockInventory)
        PanelRound8.CornerRadius = 12
        PanelRound8.Location = New Point(39, 63)
        PanelRound8.Name = "PanelRound8"
        PanelRound8.Size = New Size(1519, 59)
        PanelRound8.TabIndex = 19
        ' 
        ' LabelLowStockInventory
        ' 
        LabelLowStockInventory.Anchor = AnchorStyles.Top
        LabelLowStockInventory.AutoSize = True
        LabelLowStockInventory.Font = New Font("Segoe UI", 11F)
        LabelLowStockInventory.ForeColor = Color.FromArgb(CByte(159), CByte(45), CByte(0))
        LabelLowStockInventory.Location = New Point(6, 20)
        LabelLowStockInventory.Name = "LabelLowStockInventory"
        LabelLowStockInventory.Size = New Size(144, 20)
        LabelLowStockInventory.TabIndex = 29
        LabelLowStockInventory.Text = "Low Stcok Inventory:"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(29, 14)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 18
        PictureBox7.TabStop = False
        ' 
        ' LabelSystemAlert
        ' 
        LabelSystemAlert.Anchor = AnchorStyles.Top
        LabelSystemAlert.AutoSize = True
        LabelSystemAlert.Font = New Font("Verdana", 11F)
        LabelSystemAlert.ForeColor = Color.Black
        LabelSystemAlert.Location = New Point(59, 15)
        LabelSystemAlert.Name = "LabelSystemAlert"
        LabelSystemAlert.Size = New Size(104, 18)
        LabelSystemAlert.TabIndex = 17
        LabelSystemAlert.Text = "System Alert"
        ' 
        ' PanelRound11
        ' 
        PanelRound11.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PanelRound11.CornerRadius = 12
        PanelRound11.Location = New Point(38, 1142)
        PanelRound11.Name = "PanelRound11"
        PanelRound11.Size = New Size(46, 306)
        PanelRound11.TabIndex = 37
        ' 
        ' PanelRound12
        ' 
        PanelRound12.Location = New Point(38, 1475)
        PanelRound12.Name = "PanelRound12"
        PanelRound12.Size = New Size(1597, 49)
        PanelRound12.TabIndex = 44
        ' 
        ' AdminDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound12)
        Controls.Add(PanelRound7)
        Controls.Add(PanelSubscribersByPlan)
        Controls.Add(PanelRound6)
        Controls.Add(PanelRound5)
        Controls.Add(PanelRound4)
        Controls.Add(PanelRound3)
        Controls.Add(PanelRound2)
        Controls.Add(PanelRound1)
        Controls.Add(PanelRound11)
        Name = "AdminDashboard"
        Size = New Size(1980, 1886)
        CType(ImgTotalSubs, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgMonthlyRevenue, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgActiveInstall, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgPendingService, ComponentModel.ISupportInitialize).EndInit()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        PanelRound5.ResumeLayout(False)
        PanelRound5.PerformLayout()
        PanelRound6.ResumeLayout(False)
        PanelRound6.PerformLayout()
        CType(GreenDotComplete, ComponentModel.ISupportInitialize).EndInit()
        CType(OrangeDotProgress, ComponentModel.ISupportInitialize).EndInit()
        CType(OrangePending, ComponentModel.ISupportInitialize).EndInit()
        PanelSubscribersByPlan.ResumeLayout(False)
        PanelSubscribersByPlan.PerformLayout()
        PanelPremium.ResumeLayout(False)
        PanelPremium.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PanelStandard.ResumeLayout(False)
        PanelStandard.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PanelBasic.ResumeLayout(False)
        PanelBasic.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        PanelRound7.ResumeLayout(False)
        PanelRound7.PerformLayout()
        PanelRound10.ResumeLayout(False)
        PanelRound10.PerformLayout()
        PanelRound9.ResumeLayout(False)
        PanelRound9.PerformLayout()
        PanelRound8.ResumeLayout(False)
        PanelRound8.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PercentTotalSubs As Label
    Friend WithEvents AmountSubs As Label
    Friend WithEvents ImgTotalSubs As PictureBox
    Friend WithEvents LabelTotalSubscribers As Label
    Friend WithEvents PercentMonthlyRevenue As Label
    Friend WithEvents AmountRevenue As Label
    Friend WithEvents ImgMonthlyRevenue As PictureBox
    Friend WithEvents LabelMonthlyRevenue As Label
    Friend WithEvents PercentActiveInstallation As Label
    Friend WithEvents AmountIntstall As Label
    Friend WithEvents ImgActiveInstall As PictureBox
    Friend WithEvents LabelActiveInstallation As Label
    Friend WithEvents PercentPendingService As Label
    Friend WithEvents AmountPendingServices As Label
    Friend WithEvents ImgPendingService As PictureBox
    Friend WithEvents LabelPendingService As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents PanelRound5 As PanelRound
    Friend WithEvents PanelRound6 As PanelRound
    Friend WithEvents SubscribersGrowth As Label
    Friend WithEvents LabelComplete As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ServiceStatusDistribution As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GreenDotComplete As PictureBox
    Friend WithEvents LblPending As Label
    Friend WithEvents OrangeDotProgress As PictureBox
    Friend WithEvents OrangePending As PictureBox
    Friend WithEvents LabelProgress As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelSubscribersByPlan As PanelRound
    Friend WithEvents PanelPremium As PanelRound
    Friend WithEvents PanelStandard As PanelRound
    Friend WithEvents PanelBasic As PanelRound
    Friend WithEvents LabelSubscribersByPlan As Label
    Friend WithEvents PercentPremium As Label
    Friend WithEvents TotalPremium As Label
    Friend WithEvents AmountPremium As Label
    Friend WithEvents PremiumSubscribers As Label
    Friend WithEvents LabelPremium As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PercentStandard As Label
    Friend WithEvents LabelStandard As Label
    Friend WithEvents TotalStandard As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents AmountStandard As Label
    Friend WithEvents StandardSubscribers As Label
    Friend WithEvents PercentBasic As Label
    Friend WithEvents BasicTotal As Label
    Friend WithEvents AmountBasic As Label
    Friend WithEvents BasicSubscribers As Label
    Friend WithEvents LabelBasic As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PanelRound7 As PanelRound
    Friend WithEvents LabelMonthlyRevenueReached As Label
    Friend WithEvents LabelPendingInstallations As Label
    Friend WithEvents LabelLowStockInventory As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LabelSystemAlert As Label
    Friend WithEvents PanelRound8 As PanelRound
    Friend WithEvents PanelRound10 As PanelRound
    Friend WithEvents PanelRound9 As PanelRound
    Friend WithEvents PanelRound11 As PanelRound
    Friend WithEvents PanelRound12 As PanelRound
End Class

