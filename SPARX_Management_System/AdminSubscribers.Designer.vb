<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSubscribers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSubscribers))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelFilters = New PanelRound()
        PanelLocation = New PanelRound()
        TxtLocation = New TextBox()
        LabelLocation = New Label()
        ComboBoxAccountStatus = New ComboBox()
        ComboBoxPlanType = New ComboBox()
        LabelAccountStatus = New Label()
        LabelPlanType = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        HeaderSubscriberReport = New Label()
        PanelMonthlyRevenue = New PanelRound()
        IconMonthlyRevenue = New PictureBox()
        ValueMonthlyRevenue = New Label()
        LabelMonthlyRevenue = New Label()
        PanelActiveSubscribers = New PanelRound()
        IconActiveSubscribers = New PictureBox()
        ValueActiveSubscribers = New Label()
        LabelActiveSubscribers = New Label()
        PanelRevenueSub = New PanelRound()
        IconRevenueSub = New PictureBox()
        ValueRevenueSub = New Label()
        LabelRevenueSub = New Label()
        PanelTotalSubscribers = New PanelRound()
        IconTotalSubscribers = New PictureBox()
        ValueTotalSubscribers = New Label()
        LabelTotalSubscribers = New Label()
        PanelAccountStatusDistribution = New PanelRound()
        STDPercentUpgrade = New Label()
        ASDGreenDot = New PictureBox()
        ASDActive = New Label()
        STDPercentRelocation = New Label()
        ASDCancelled = New Label()
        AccountStatusDistribution = New Label()
        STDPercentRepair = New Label()
        ASDRedDot = New PictureBox()
        ASDSuspended = New Label()
        ASDOrangeDot = New PictureBox()
        SPTValueBasic = New Label()
        SPTBlueDot = New PictureBox()
        SPTBasic = New Label()
        PanelSubsPlanType = New PanelRound()
        SPTPercentPremium = New Label()
        SPTPercentStandard = New Label()
        SPTValuePremium = New Label()
        SPTPercentBasic = New Label()
        SPTPremium = New Label()
        SPTOrangeDot = New PictureBox()
        SPTValueStandard = New Label()
        SPTGreenDot = New PictureBox()
        SubscriberPlanType = New Label()
        SPTStandard = New Label()
        PanelSubscriberDetails = New PanelRound()
        LabelSubscriberDetails = New Label()
        DataGridSubscriberDetails = New DataGridView()
        CustomerID = New DataGridViewTextBoxColumn()
        CustomerName = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        PlanType = New DataGridViewTextBoxColumn()
        MonthlyRate = New DataGridViewTextBoxColumn()
        DateInstalled = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AddDelete = New DataGridViewTextBoxColumn()
        PanelRound1 = New PanelRound()
        PanelFilters.SuspendLayout()
        PanelLocation.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelMonthlyRevenue.SuspendLayout()
        CType(IconMonthlyRevenue, ComponentModel.ISupportInitialize).BeginInit()
        PanelActiveSubscribers.SuspendLayout()
        CType(IconActiveSubscribers, ComponentModel.ISupportInitialize).BeginInit()
        PanelRevenueSub.SuspendLayout()
        CType(IconRevenueSub, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalSubscribers.SuspendLayout()
        CType(IconTotalSubscribers, ComponentModel.ISupportInitialize).BeginInit()
        PanelAccountStatusDistribution.SuspendLayout()
        CType(ASDGreenDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(ASDRedDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(ASDOrangeDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SPTBlueDot, ComponentModel.ISupportInitialize).BeginInit()
        PanelSubsPlanType.SuspendLayout()
        CType(SPTOrangeDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SPTGreenDot, ComponentModel.ISupportInitialize).BeginInit()
        PanelSubscriberDetails.SuspendLayout()
        CType(DataGridSubscriberDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(PanelLocation)
        PanelFilters.Controls.Add(LabelLocation)
        PanelFilters.Controls.Add(ComboBoxAccountStatus)
        PanelFilters.Controls.Add(ComboBoxPlanType)
        PanelFilters.Controls.Add(LabelAccountStatus)
        PanelFilters.Controls.Add(LabelPlanType)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 55)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 0
        ' 
        ' PanelLocation
        ' 
        PanelLocation.BackColor = SystemColors.ButtonFace
        PanelLocation.Controls.Add(TxtLocation)
        PanelLocation.CornerRadius = 8
        PanelLocation.Location = New Point(1040, 104)
        PanelLocation.Name = "PanelLocation"
        PanelLocation.Size = New Size(473, 33)
        PanelLocation.TabIndex = 12
        ' 
        ' TxtLocation
        ' 
        TxtLocation.BackColor = SystemColors.ButtonFace
        TxtLocation.BorderStyle = BorderStyle.None
        TxtLocation.Font = New Font("Segoe UI", 11F)
        TxtLocation.Location = New Point(8, 6)
        TxtLocation.Name = "TxtLocation"
        TxtLocation.Size = New Size(459, 20)
        TxtLocation.TabIndex = 0
        ' 
        ' LabelLocation
        ' 
        LabelLocation.AutoSize = True
        LabelLocation.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelLocation.Location = New Point(1040, 80)
        LabelLocation.Name = "LabelLocation"
        LabelLocation.Size = New Size(73, 21)
        LabelLocation.TabIndex = 21
        LabelLocation.Text = "Location"
        ' 
        ' ComboBoxAccountStatus
        ' 
        ComboBoxAccountStatus.BackColor = SystemColors.ButtonFace
        ComboBoxAccountStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxAccountStatus.Font = New Font("Segoe UI", 14F)
        ComboBoxAccountStatus.ForeColor = SystemColors.WindowText
        ComboBoxAccountStatus.FormattingEnabled = True
        ComboBoxAccountStatus.Location = New Point(532, 104)
        ComboBoxAccountStatus.MinimumSize = New Size(193, 0)
        ComboBoxAccountStatus.Name = "ComboBoxAccountStatus"
        ComboBoxAccountStatus.Size = New Size(473, 33)
        ComboBoxAccountStatus.TabIndex = 20
        ' 
        ' ComboBoxPlanType
        ' 
        ComboBoxPlanType.BackColor = SystemColors.ButtonFace
        ComboBoxPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPlanType.Font = New Font("Segoe UI", 14F)
        ComboBoxPlanType.ForeColor = SystemColors.WindowText
        ComboBoxPlanType.FormattingEnabled = True
        ComboBoxPlanType.Location = New Point(24, 104)
        ComboBoxPlanType.MinimumSize = New Size(193, 0)
        ComboBoxPlanType.Name = "ComboBoxPlanType"
        ComboBoxPlanType.Size = New Size(473, 33)
        ComboBoxPlanType.TabIndex = 19
        ' 
        ' LabelAccountStatus
        ' 
        LabelAccountStatus.AutoSize = True
        LabelAccountStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelAccountStatus.Location = New Point(530, 80)
        LabelAccountStatus.Name = "LabelAccountStatus"
        LabelAccountStatus.Size = New Size(120, 21)
        LabelAccountStatus.TabIndex = 18
        LabelAccountStatus.Text = "Account Status"
        ' 
        ' LabelPlanType
        ' 
        LabelPlanType.AutoSize = True
        LabelPlanType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelPlanType.Location = New Point(22, 80)
        LabelPlanType.Name = "LabelPlanType"
        LabelPlanType.Size = New Size(79, 21)
        LabelPlanType.TabIndex = 17
        LabelPlanType.Text = "Plan Type"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F)
        Label1.Location = New Point(51, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 18)
        Label1.TabIndex = 16
        Label1.Text = "Filters"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' HeaderSubscriberReport
        ' 
        HeaderSubscriberReport.AutoSize = True
        HeaderSubscriberReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderSubscriberReport.Location = New Point(43, 16)
        HeaderSubscriberReport.Name = "HeaderSubscriberReport"
        HeaderSubscriberReport.Size = New Size(174, 28)
        HeaderSubscriberReport.TabIndex = 11
        HeaderSubscriberReport.Text = "Subscriber Report"
        ' 
        ' PanelMonthlyRevenue
        ' 
        PanelMonthlyRevenue.BackColor = Color.White
        PanelMonthlyRevenue.Controls.Add(IconMonthlyRevenue)
        PanelMonthlyRevenue.Controls.Add(ValueMonthlyRevenue)
        PanelMonthlyRevenue.Controls.Add(LabelMonthlyRevenue)
        PanelMonthlyRevenue.CornerRadius = 12
        PanelMonthlyRevenue.Location = New Point(862, 260)
        PanelMonthlyRevenue.Name = "PanelMonthlyRevenue"
        PanelMonthlyRevenue.Size = New Size(367, 167)
        PanelMonthlyRevenue.TabIndex = 19
        ' 
        ' IconMonthlyRevenue
        ' 
        IconMonthlyRevenue.Image = CType(resources.GetObject("IconMonthlyRevenue.Image"), Image)
        IconMonthlyRevenue.Location = New Point(290, 59)
        IconMonthlyRevenue.Name = "IconMonthlyRevenue"
        IconMonthlyRevenue.Size = New Size(48, 50)
        IconMonthlyRevenue.SizeMode = PictureBoxSizeMode.Zoom
        IconMonthlyRevenue.TabIndex = 14
        IconMonthlyRevenue.TabStop = False
        ' 
        ' ValueMonthlyRevenue
        ' 
        ValueMonthlyRevenue.AutoSize = True
        ValueMonthlyRevenue.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueMonthlyRevenue.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ValueMonthlyRevenue.Location = New Point(28, 89)
        ValueMonthlyRevenue.Name = "ValueMonthlyRevenue"
        ValueMonthlyRevenue.Size = New Size(37, 30)
        ValueMonthlyRevenue.TabIndex = 13
        ValueMonthlyRevenue.Text = "00"
        ' 
        ' LabelMonthlyRevenue
        ' 
        LabelMonthlyRevenue.AutoSize = True
        LabelMonthlyRevenue.Font = New Font("Verdana", 12F)
        LabelMonthlyRevenue.ForeColor = SystemColors.ControlDarkDark
        LabelMonthlyRevenue.Location = New Point(28, 48)
        LabelMonthlyRevenue.Name = "LabelMonthlyRevenue"
        LabelMonthlyRevenue.Size = New Size(148, 18)
        LabelMonthlyRevenue.TabIndex = 12
        LabelMonthlyRevenue.Text = "Monthly Revenue"
        ' 
        ' PanelActiveSubscribers
        ' 
        PanelActiveSubscribers.BackColor = Color.White
        PanelActiveSubscribers.Controls.Add(IconActiveSubscribers)
        PanelActiveSubscribers.Controls.Add(ValueActiveSubscribers)
        PanelActiveSubscribers.Controls.Add(LabelActiveSubscribers)
        PanelActiveSubscribers.CornerRadius = 12
        PanelActiveSubscribers.Location = New Point(453, 260)
        PanelActiveSubscribers.Name = "PanelActiveSubscribers"
        PanelActiveSubscribers.Size = New Size(367, 167)
        PanelActiveSubscribers.TabIndex = 18
        ' 
        ' IconActiveSubscribers
        ' 
        IconActiveSubscribers.Image = CType(resources.GetObject("IconActiveSubscribers.Image"), Image)
        IconActiveSubscribers.Location = New Point(290, 59)
        IconActiveSubscribers.Name = "IconActiveSubscribers"
        IconActiveSubscribers.Size = New Size(48, 50)
        IconActiveSubscribers.SizeMode = PictureBoxSizeMode.Zoom
        IconActiveSubscribers.TabIndex = 13
        IconActiveSubscribers.TabStop = False
        ' 
        ' ValueActiveSubscribers
        ' 
        ValueActiveSubscribers.AutoSize = True
        ValueActiveSubscribers.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueActiveSubscribers.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ValueActiveSubscribers.Location = New Point(28, 89)
        ValueActiveSubscribers.Name = "ValueActiveSubscribers"
        ValueActiveSubscribers.Size = New Size(37, 30)
        ValueActiveSubscribers.TabIndex = 12
        ValueActiveSubscribers.Text = "00"
        ' 
        ' LabelActiveSubscribers
        ' 
        LabelActiveSubscribers.AutoSize = True
        LabelActiveSubscribers.Font = New Font("Verdana", 12F)
        LabelActiveSubscribers.ForeColor = SystemColors.ControlDarkDark
        LabelActiveSubscribers.Location = New Point(28, 48)
        LabelActiveSubscribers.Name = "LabelActiveSubscribers"
        LabelActiveSubscribers.Size = New Size(157, 18)
        LabelActiveSubscribers.TabIndex = 11
        LabelActiveSubscribers.Text = "Active Susbcribers"
        ' 
        ' PanelRevenueSub
        ' 
        PanelRevenueSub.BackColor = Color.White
        PanelRevenueSub.Controls.Add(IconRevenueSub)
        PanelRevenueSub.Controls.Add(ValueRevenueSub)
        PanelRevenueSub.Controls.Add(LabelRevenueSub)
        PanelRevenueSub.CornerRadius = 12
        PanelRevenueSub.Location = New Point(1273, 260)
        PanelRevenueSub.Name = "PanelRevenueSub"
        PanelRevenueSub.Size = New Size(367, 167)
        PanelRevenueSub.TabIndex = 17
        ' 
        ' IconRevenueSub
        ' 
        IconRevenueSub.Image = CType(resources.GetObject("IconRevenueSub.Image"), Image)
        IconRevenueSub.Location = New Point(290, 59)
        IconRevenueSub.Name = "IconRevenueSub"
        IconRevenueSub.Size = New Size(48, 50)
        IconRevenueSub.SizeMode = PictureBoxSizeMode.Zoom
        IconRevenueSub.TabIndex = 15
        IconRevenueSub.TabStop = False
        ' 
        ' ValueRevenueSub
        ' 
        ValueRevenueSub.AutoSize = True
        ValueRevenueSub.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueRevenueSub.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        ValueRevenueSub.Location = New Point(28, 89)
        ValueRevenueSub.Name = "ValueRevenueSub"
        ValueRevenueSub.Size = New Size(37, 30)
        ValueRevenueSub.TabIndex = 14
        ValueRevenueSub.Text = "00"
        ' 
        ' LabelRevenueSub
        ' 
        LabelRevenueSub.AutoEllipsis = True
        LabelRevenueSub.AutoSize = True
        LabelRevenueSub.Font = New Font("Verdana", 12F)
        LabelRevenueSub.ForeColor = SystemColors.ControlDarkDark
        LabelRevenueSub.Location = New Point(28, 48)
        LabelRevenueSub.Name = "LabelRevenueSub"
        LabelRevenueSub.Size = New Size(182, 18)
        LabelRevenueSub.TabIndex = 13
        LabelRevenueSub.Text = "Avg Revenue per Sub"
        ' 
        ' PanelTotalSubscribers
        ' 
        PanelTotalSubscribers.BackColor = Color.White
        PanelTotalSubscribers.Controls.Add(IconTotalSubscribers)
        PanelTotalSubscribers.Controls.Add(ValueTotalSubscribers)
        PanelTotalSubscribers.Controls.Add(LabelTotalSubscribers)
        PanelTotalSubscribers.CornerRadius = 12
        PanelTotalSubscribers.Location = New Point(43, 260)
        PanelTotalSubscribers.Name = "PanelTotalSubscribers"
        PanelTotalSubscribers.Size = New Size(367, 167)
        PanelTotalSubscribers.TabIndex = 16
        ' 
        ' IconTotalSubscribers
        ' 
        IconTotalSubscribers.Image = CType(resources.GetObject("IconTotalSubscribers.Image"), Image)
        IconTotalSubscribers.Location = New Point(290, 59)
        IconTotalSubscribers.Name = "IconTotalSubscribers"
        IconTotalSubscribers.Size = New Size(48, 50)
        IconTotalSubscribers.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalSubscribers.TabIndex = 12
        IconTotalSubscribers.TabStop = False
        ' 
        ' ValueTotalSubscribers
        ' 
        ValueTotalSubscribers.AutoSize = True
        ValueTotalSubscribers.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueTotalSubscribers.Location = New Point(28, 89)
        ValueTotalSubscribers.Name = "ValueTotalSubscribers"
        ValueTotalSubscribers.Size = New Size(37, 30)
        ValueTotalSubscribers.TabIndex = 10
        ValueTotalSubscribers.Text = "00"
        ' 
        ' LabelTotalSubscribers
        ' 
        LabelTotalSubscribers.AutoSize = True
        LabelTotalSubscribers.Font = New Font("Verdana", 12F)
        LabelTotalSubscribers.ForeColor = SystemColors.ControlDarkDark
        LabelTotalSubscribers.Location = New Point(28, 48)
        LabelTotalSubscribers.Name = "LabelTotalSubscribers"
        LabelTotalSubscribers.Size = New Size(147, 18)
        LabelTotalSubscribers.TabIndex = 11
        LabelTotalSubscribers.Text = "Total Subscribers"
        ' 
        ' PanelAccountStatusDistribution
        ' 
        PanelAccountStatusDistribution.BackColor = Color.White
        PanelAccountStatusDistribution.Controls.Add(STDPercentUpgrade)
        PanelAccountStatusDistribution.Controls.Add(ASDGreenDot)
        PanelAccountStatusDistribution.Controls.Add(ASDActive)
        PanelAccountStatusDistribution.Controls.Add(STDPercentRelocation)
        PanelAccountStatusDistribution.Controls.Add(ASDCancelled)
        PanelAccountStatusDistribution.Controls.Add(AccountStatusDistribution)
        PanelAccountStatusDistribution.Controls.Add(STDPercentRepair)
        PanelAccountStatusDistribution.Controls.Add(ASDRedDot)
        PanelAccountStatusDistribution.Controls.Add(ASDSuspended)
        PanelAccountStatusDistribution.Controls.Add(ASDOrangeDot)
        PanelAccountStatusDistribution.CornerRadius = 12
        PanelAccountStatusDistribution.Location = New Point(862, 471)
        PanelAccountStatusDistribution.Name = "PanelAccountStatusDistribution"
        PanelAccountStatusDistribution.Size = New Size(778, 517)
        PanelAccountStatusDistribution.TabIndex = 38
        ' 
        ' STDPercentUpgrade
        ' 
        STDPercentUpgrade.Anchor = AnchorStyles.Top
        STDPercentUpgrade.AutoSize = True
        STDPercentUpgrade.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        STDPercentUpgrade.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentUpgrade.Location = New Point(682, 380)
        STDPercentUpgrade.Name = "STDPercentUpgrade"
        STDPercentUpgrade.Size = New Size(34, 20)
        STDPercentUpgrade.TabIndex = 47
        STDPercentUpgrade.Text = "(%)"
        ' 
        ' ASDGreenDot
        ' 
        ASDGreenDot.Anchor = AnchorStyles.Top
        ASDGreenDot.Image = CType(resources.GetObject("ASDGreenDot.Image"), Image)
        ASDGreenDot.Location = New Point(60, 380)
        ASDGreenDot.Name = "ASDGreenDot"
        ASDGreenDot.Size = New Size(12, 12)
        ASDGreenDot.SizeMode = PictureBoxSizeMode.Zoom
        ASDGreenDot.TabIndex = 45
        ASDGreenDot.TabStop = False
        ' 
        ' ASDActive
        ' 
        ASDActive.Anchor = AnchorStyles.Top
        ASDActive.AutoSize = True
        ASDActive.Font = New Font("Segoe UI", 11F)
        ASDActive.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        ASDActive.Location = New Point(78, 377)
        ASDActive.Name = "ASDActive"
        ASDActive.Size = New Size(50, 20)
        ASDActive.TabIndex = 46
        ASDActive.Text = "Active"
        ' 
        ' STDPercentRelocation
        ' 
        STDPercentRelocation.Anchor = AnchorStyles.Top
        STDPercentRelocation.AutoSize = True
        STDPercentRelocation.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        STDPercentRelocation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRelocation.Location = New Point(682, 418)
        STDPercentRelocation.Name = "STDPercentRelocation"
        STDPercentRelocation.Size = New Size(34, 20)
        STDPercentRelocation.TabIndex = 35
        STDPercentRelocation.Text = "(%)"
        ' 
        ' ASDCancelled
        ' 
        ASDCancelled.Anchor = AnchorStyles.Top
        ASDCancelled.AutoSize = True
        ASDCancelled.Font = New Font("Segoe UI", 11F)
        ASDCancelled.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        ASDCancelled.Location = New Point(78, 454)
        ASDCancelled.Name = "ASDCancelled"
        ASDCancelled.Size = New Size(74, 20)
        ASDCancelled.TabIndex = 37
        ASDCancelled.Text = "Cancelled"
        ' 
        ' AccountStatusDistribution
        ' 
        AccountStatusDistribution.Anchor = AnchorStyles.Top
        AccountStatusDistribution.AutoSize = True
        AccountStatusDistribution.Font = New Font("Verdana", 11F)
        AccountStatusDistribution.ForeColor = Color.Black
        AccountStatusDistribution.Location = New Point(24, 24)
        AccountStatusDistribution.Name = "AccountStatusDistribution"
        AccountStatusDistribution.Size = New Size(209, 18)
        AccountStatusDistribution.TabIndex = 36
        AccountStatusDistribution.Text = "Account Status Distribution"
        ' 
        ' STDPercentRepair
        ' 
        STDPercentRepair.Anchor = AnchorStyles.Top
        STDPercentRepair.AutoSize = True
        STDPercentRepair.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        STDPercentRepair.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRepair.Location = New Point(682, 457)
        STDPercentRepair.Name = "STDPercentRepair"
        STDPercentRepair.Size = New Size(34, 20)
        STDPercentRepair.TabIndex = 43
        STDPercentRepair.Text = "(%)"
        ' 
        ' ASDRedDot
        ' 
        ASDRedDot.Anchor = AnchorStyles.Top
        ASDRedDot.Image = CType(resources.GetObject("ASDRedDot.Image"), Image)
        ASDRedDot.Location = New Point(60, 457)
        ASDRedDot.Name = "ASDRedDot"
        ASDRedDot.Size = New Size(12, 12)
        ASDRedDot.SizeMode = PictureBoxSizeMode.Zoom
        ASDRedDot.TabIndex = 38
        ASDRedDot.TabStop = False
        ' 
        ' ASDSuspended
        ' 
        ASDSuspended.Anchor = AnchorStyles.Top
        ASDSuspended.AutoSize = True
        ASDSuspended.Font = New Font("Segoe UI", 11F)
        ASDSuspended.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        ASDSuspended.Location = New Point(78, 415)
        ASDSuspended.Name = "ASDSuspended"
        ASDSuspended.Size = New Size(82, 20)
        ASDSuspended.TabIndex = 42
        ASDSuspended.Text = "Suspended"
        ' 
        ' ASDOrangeDot
        ' 
        ASDOrangeDot.Anchor = AnchorStyles.Top
        ASDOrangeDot.Image = CType(resources.GetObject("ASDOrangeDot.Image"), Image)
        ASDOrangeDot.Location = New Point(60, 418)
        ASDOrangeDot.Name = "ASDOrangeDot"
        ASDOrangeDot.Size = New Size(12, 12)
        ASDOrangeDot.SizeMode = PictureBoxSizeMode.Zoom
        ASDOrangeDot.TabIndex = 41
        ASDOrangeDot.TabStop = False
        ' 
        ' SPTValueBasic
        ' 
        SPTValueBasic.Anchor = AnchorStyles.Top
        SPTValueBasic.AutoSize = True
        SPTValueBasic.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTValueBasic.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTValueBasic.Location = New Point(684, 380)
        SPTValueBasic.Name = "SPTValueBasic"
        SPTValueBasic.Size = New Size(26, 18)
        SPTValueBasic.TabIndex = 44
        SPTValueBasic.Text = "00"
        ' 
        ' SPTBlueDot
        ' 
        SPTBlueDot.Anchor = AnchorStyles.Top
        SPTBlueDot.Image = CType(resources.GetObject("SPTBlueDot.Image"), Image)
        SPTBlueDot.Location = New Point(51, 379)
        SPTBlueDot.Name = "SPTBlueDot"
        SPTBlueDot.Size = New Size(12, 12)
        SPTBlueDot.SizeMode = PictureBoxSizeMode.Zoom
        SPTBlueDot.TabIndex = 39
        SPTBlueDot.TabStop = False
        ' 
        ' SPTBasic
        ' 
        SPTBasic.Anchor = AnchorStyles.Top
        SPTBasic.AutoSize = True
        SPTBasic.Font = New Font("Segoe UI", 11F)
        SPTBasic.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTBasic.Location = New Point(69, 376)
        SPTBasic.Name = "SPTBasic"
        SPTBasic.Size = New Size(100, 20)
        SPTBasic.TabIndex = 40
        SPTBasic.Text = "Basic 25Mbps"
        ' 
        ' PanelSubsPlanType
        ' 
        PanelSubsPlanType.BackColor = Color.White
        PanelSubsPlanType.Controls.Add(SPTPercentPremium)
        PanelSubsPlanType.Controls.Add(SPTPercentStandard)
        PanelSubsPlanType.Controls.Add(SPTValuePremium)
        PanelSubsPlanType.Controls.Add(SPTValueBasic)
        PanelSubsPlanType.Controls.Add(SPTPercentBasic)
        PanelSubsPlanType.Controls.Add(SPTPremium)
        PanelSubsPlanType.Controls.Add(SPTOrangeDot)
        PanelSubsPlanType.Controls.Add(SPTBlueDot)
        PanelSubsPlanType.Controls.Add(SPTValueStandard)
        PanelSubsPlanType.Controls.Add(SPTGreenDot)
        PanelSubsPlanType.Controls.Add(SPTBasic)
        PanelSubsPlanType.Controls.Add(SubscriberPlanType)
        PanelSubsPlanType.Controls.Add(SPTStandard)
        PanelSubsPlanType.CornerRadius = 12
        PanelSubsPlanType.Location = New Point(43, 471)
        PanelSubsPlanType.Name = "PanelSubsPlanType"
        PanelSubsPlanType.Size = New Size(778, 517)
        PanelSubsPlanType.TabIndex = 37
        ' 
        ' SPTPercentPremium
        ' 
        SPTPercentPremium.Anchor = AnchorStyles.Top
        SPTPercentPremium.AutoSize = True
        SPTPercentPremium.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTPercentPremium.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTPercentPremium.Location = New Point(715, 448)
        SPTPercentPremium.Name = "SPTPercentPremium"
        SPTPercentPremium.Size = New Size(34, 18)
        SPTPercentPremium.TabIndex = 52
        SPTPercentPremium.Text = "(%)"
        ' 
        ' SPTPercentStandard
        ' 
        SPTPercentStandard.Anchor = AnchorStyles.Top
        SPTPercentStandard.AutoSize = True
        SPTPercentStandard.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTPercentStandard.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTPercentStandard.Location = New Point(715, 413)
        SPTPercentStandard.Name = "SPTPercentStandard"
        SPTPercentStandard.Size = New Size(34, 18)
        SPTPercentStandard.TabIndex = 51
        SPTPercentStandard.Text = "(%)"
        ' 
        ' SPTValuePremium
        ' 
        SPTValuePremium.Anchor = AnchorStyles.Top
        SPTValuePremium.AutoSize = True
        SPTValuePremium.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTValuePremium.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTValuePremium.Location = New Point(684, 449)
        SPTValuePremium.Name = "SPTValuePremium"
        SPTValuePremium.Size = New Size(26, 18)
        SPTValuePremium.TabIndex = 50
        SPTValuePremium.Text = "00"
        ' 
        ' SPTPercentBasic
        ' 
        SPTPercentBasic.Anchor = AnchorStyles.Top
        SPTPercentBasic.AutoSize = True
        SPTPercentBasic.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTPercentBasic.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTPercentBasic.Location = New Point(715, 380)
        SPTPercentBasic.Name = "SPTPercentBasic"
        SPTPercentBasic.Size = New Size(34, 18)
        SPTPercentBasic.TabIndex = 47
        SPTPercentBasic.Text = "(%)"
        ' 
        ' SPTPremium
        ' 
        SPTPremium.Anchor = AnchorStyles.Top
        SPTPremium.AutoSize = True
        SPTPremium.Font = New Font("Segoe UI", 11F)
        SPTPremium.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTPremium.Location = New Point(69, 453)
        SPTPremium.Name = "SPTPremium"
        SPTPremium.Size = New Size(133, 20)
        SPTPremium.TabIndex = 49
        SPTPremium.Text = "Premium 100Mbps"
        ' 
        ' SPTOrangeDot
        ' 
        SPTOrangeDot.Anchor = AnchorStyles.Top
        SPTOrangeDot.Image = CType(resources.GetObject("SPTOrangeDot.Image"), Image)
        SPTOrangeDot.Location = New Point(51, 456)
        SPTOrangeDot.Name = "SPTOrangeDot"
        SPTOrangeDot.Size = New Size(12, 12)
        SPTOrangeDot.SizeMode = PictureBoxSizeMode.Zoom
        SPTOrangeDot.TabIndex = 48
        SPTOrangeDot.TabStop = False
        ' 
        ' SPTValueStandard
        ' 
        SPTValueStandard.Anchor = AnchorStyles.Top
        SPTValueStandard.AutoSize = True
        SPTValueStandard.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold)
        SPTValueStandard.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTValueStandard.Location = New Point(684, 415)
        SPTValueStandard.Name = "SPTValueStandard"
        SPTValueStandard.Size = New Size(26, 18)
        SPTValueStandard.TabIndex = 46
        SPTValueStandard.Text = "00"
        ' 
        ' SPTGreenDot
        ' 
        SPTGreenDot.Anchor = AnchorStyles.Top
        SPTGreenDot.Image = CType(resources.GetObject("SPTGreenDot.Image"), Image)
        SPTGreenDot.Location = New Point(51, 416)
        SPTGreenDot.Name = "SPTGreenDot"
        SPTGreenDot.Size = New Size(12, 12)
        SPTGreenDot.SizeMode = PictureBoxSizeMode.Zoom
        SPTGreenDot.TabIndex = 45
        SPTGreenDot.TabStop = False
        ' 
        ' SubscriberPlanType
        ' 
        SubscriberPlanType.Anchor = AnchorStyles.Top
        SubscriberPlanType.AutoSize = True
        SubscriberPlanType.Font = New Font("Verdana", 11F)
        SubscriberPlanType.ForeColor = Color.Black
        SubscriberPlanType.Location = New Point(24, 20)
        SubscriberPlanType.Name = "SubscriberPlanType"
        SubscriberPlanType.Size = New Size(183, 18)
        SubscriberPlanType.TabIndex = 35
        SubscriberPlanType.Text = "Subscriber by Plan Type"
        ' 
        ' SPTStandard
        ' 
        SPTStandard.Anchor = AnchorStyles.Top
        SPTStandard.AutoSize = True
        SPTStandard.Font = New Font("Segoe UI", 11F)
        SPTStandard.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SPTStandard.Location = New Point(69, 413)
        SPTStandard.Name = "SPTStandard"
        SPTStandard.Size = New Size(126, 20)
        SPTStandard.TabIndex = 44
        SPTStandard.Text = "Standard 50Mbps"
        ' 
        ' PanelSubscriberDetails
        ' 
        PanelSubscriberDetails.BackColor = Color.White
        PanelSubscriberDetails.Controls.Add(LabelSubscriberDetails)
        PanelSubscriberDetails.Controls.Add(DataGridSubscriberDetails)
        PanelSubscriberDetails.CornerRadius = 12
        PanelSubscriberDetails.Location = New Point(43, 1024)
        PanelSubscriberDetails.Name = "PanelSubscriberDetails"
        PanelSubscriberDetails.Size = New Size(1595, 779)
        PanelSubscriberDetails.TabIndex = 39
        ' 
        ' LabelSubscriberDetails
        ' 
        LabelSubscriberDetails.Anchor = AnchorStyles.Top
        LabelSubscriberDetails.AutoSize = True
        LabelSubscriberDetails.Font = New Font("Verdana", 11F)
        LabelSubscriberDetails.ForeColor = Color.Black
        LabelSubscriberDetails.Location = New Point(21, 19)
        LabelSubscriberDetails.Name = "LabelSubscriberDetails"
        LabelSubscriberDetails.Size = New Size(139, 18)
        LabelSubscriberDetails.TabIndex = 36
        LabelSubscriberDetails.Text = "Subscriber Details"
        ' 
        ' DataGridSubscriberDetails
        ' 
        DataGridSubscriberDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridSubscriberDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridSubscriberDetails.BackgroundColor = Color.White
        DataGridSubscriberDetails.BorderStyle = BorderStyle.None
        DataGridSubscriberDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridSubscriberDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 11F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridSubscriberDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridSubscriberDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridSubscriberDetails.Columns.AddRange(New DataGridViewColumn() {CustomerID, CustomerName, Address, PlanType, MonthlyRate, DateInstalled, Status, AddDelete})
        DataGridSubscriberDetails.EnableHeadersVisualStyles = False
        DataGridSubscriberDetails.GridColor = Color.White
        DataGridSubscriberDetails.Location = New Point(10, 80)
        DataGridSubscriberDetails.Name = "DataGridSubscriberDetails"
        DataGridSubscriberDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridSubscriberDetails.RowHeadersVisible = False
        DataGridSubscriberDetails.RowTemplate.Height = 40
        DataGridSubscriberDetails.ScrollBars = ScrollBars.Vertical
        DataGridSubscriberDetails.Size = New Size(1578, 666)
        DataGridSubscriberDetails.TabIndex = 26
        ' 
        ' CustomerID
        ' 
        CustomerID.Frozen = True
        CustomerID.HeaderText = "CustomerID"
        CustomerID.Name = "CustomerID"
        CustomerID.ReadOnly = True
        CustomerID.Width = 150
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Name"
        CustomerName.Name = "CustomerName"
        CustomerName.ReadOnly = True
        CustomerName.Width = 150
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.Name = "Address"
        Address.ReadOnly = True
        Address.Width = 350
        ' 
        ' PlanType
        ' 
        PlanType.HeaderText = "Plan Type"
        PlanType.Name = "PlanType"
        PlanType.ReadOnly = True
        PlanType.Width = 200
        ' 
        ' MonthlyRate
        ' 
        MonthlyRate.HeaderText = "Monthly Rate"
        MonthlyRate.Name = "MonthlyRate"
        MonthlyRate.ReadOnly = True
        MonthlyRate.Width = 250
        ' 
        ' DateInstalled
        ' 
        DateInstalled.HeaderText = "Date Installed"
        DateInstalled.Name = "DateInstalled"
        DateInstalled.ReadOnly = True
        DateInstalled.Width = 250
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' AddDelete
        ' 
        AddDelete.HeaderText = ""
        AddDelete.Name = "AddDelete"
        AddDelete.Width = 75
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Location = New Point(43, 1832)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 49)
        PanelRound1.TabIndex = 44
        ' 
        ' AdminSubscribers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound1)
        Controls.Add(PanelSubscriberDetails)
        Controls.Add(PanelAccountStatusDistribution)
        Controls.Add(PanelSubsPlanType)
        Controls.Add(PanelMonthlyRevenue)
        Controls.Add(PanelActiveSubscribers)
        Controls.Add(PanelRevenueSub)
        Controls.Add(PanelTotalSubscribers)
        Controls.Add(HeaderSubscriberReport)
        Controls.Add(PanelFilters)
        Name = "AdminSubscribers"
        Size = New Size(1940, 1943)
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        PanelLocation.ResumeLayout(False)
        PanelLocation.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelMonthlyRevenue.ResumeLayout(False)
        PanelMonthlyRevenue.PerformLayout()
        CType(IconMonthlyRevenue, ComponentModel.ISupportInitialize).EndInit()
        PanelActiveSubscribers.ResumeLayout(False)
        PanelActiveSubscribers.PerformLayout()
        CType(IconActiveSubscribers, ComponentModel.ISupportInitialize).EndInit()
        PanelRevenueSub.ResumeLayout(False)
        PanelRevenueSub.PerformLayout()
        CType(IconRevenueSub, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalSubscribers.ResumeLayout(False)
        PanelTotalSubscribers.PerformLayout()
        CType(IconTotalSubscribers, ComponentModel.ISupportInitialize).EndInit()
        PanelAccountStatusDistribution.ResumeLayout(False)
        PanelAccountStatusDistribution.PerformLayout()
        CType(ASDGreenDot, ComponentModel.ISupportInitialize).EndInit()
        CType(ASDRedDot, ComponentModel.ISupportInitialize).EndInit()
        CType(ASDOrangeDot, ComponentModel.ISupportInitialize).EndInit()
        CType(SPTBlueDot, ComponentModel.ISupportInitialize).EndInit()
        PanelSubsPlanType.ResumeLayout(False)
        PanelSubsPlanType.PerformLayout()
        CType(SPTOrangeDot, ComponentModel.ISupportInitialize).EndInit()
        CType(SPTGreenDot, ComponentModel.ISupportInitialize).EndInit()
        PanelSubscriberDetails.ResumeLayout(False)
        PanelSubscriberDetails.PerformLayout()
        CType(DataGridSubscriberDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents HeaderSubscriberReport As Label
    Friend WithEvents ComboBoxPlanType As ComboBox
    Friend WithEvents ComboBoxAccountStatus As ComboBox
    Friend WithEvents LabelPlanType As Label
    Friend WithEvents LabelAccountStatus As Label
    Friend WithEvents LabelLocation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelLocation As PanelRound
    Friend WithEvents TxtLocation As TextBox
    Friend WithEvents PanelMonthlyRevenue As PanelRound
    Friend WithEvents IconMonthlyRevenue As PictureBox
    Friend WithEvents ValueMonthlyRevenue As Label
    Friend WithEvents LabelMonthlyRevenue As Label
    Friend WithEvents PanelActiveSubscribers As PanelRound
    Friend WithEvents IconActiveSubscribers As PictureBox
    Friend WithEvents ValueActiveSubscribers As Label
    Friend WithEvents LabelActiveSubscribers As Label
    Friend WithEvents PanelRevenueSub As PanelRound
    Friend WithEvents IconRevenueSub As PictureBox
    Friend WithEvents ValueRevenueSub As Label
    Friend WithEvents LabelRevenueSub As Label
    Friend WithEvents PanelTotalSubscribers As PanelRound
    Friend WithEvents IconTotalSubscribers As PictureBox
    Friend WithEvents ValueTotalSubscribers As Label
    Friend WithEvents LabelTotalSubscribers As Label
    Friend WithEvents PanelAccountStatusDistribution As PanelRound
    Friend WithEvents STDPercentUpgrade As Label
    Friend WithEvents ASDGreenDot As PictureBox
    Friend WithEvents ASDActive As Label
    Friend WithEvents STDPercentRelocation As Label
    Friend WithEvents ASDCancelled As Label
    Friend WithEvents SPTValueBasic As Label
    Friend WithEvents AccountStatusDistribution As Label
    Friend WithEvents STDPercentRepair As Label
    Friend WithEvents ASDRedDot As PictureBox
    Friend WithEvents ASDSuspended As Label
    Friend WithEvents SPTBlueDot As PictureBox
    Friend WithEvents ASDOrangeDot As PictureBox
    Friend WithEvents SPTBasic As Label
    Friend WithEvents PanelSubsPlanType As PanelRound
    Friend WithEvents SPTPercentBasic As Label
    Friend WithEvents SPTPremium As Label
    Friend WithEvents SPTOrangeDot As PictureBox
    Friend WithEvents SPTStandard As Label
    Friend WithEvents SPTValueStandard As Label
    Friend WithEvents SPTGreenDot As PictureBox
    Friend WithEvents SubscriberPlanType As Label
    Friend WithEvents SPTPercentPremium As Label
    Friend WithEvents SPTPercentStandard As Label
    Friend WithEvents SPTValuePremium As Label
    Friend WithEvents PanelSubscriberDetails As PanelRound
    Friend WithEvents LabelSubscriberDetails As Label
    Friend WithEvents DataGridSubscriberDetails As DataGridView
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents PlanType As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents DateInstalled As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AddDelete As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound1 As PanelRound
End Class
