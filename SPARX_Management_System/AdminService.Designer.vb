<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminService))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderServiceReport = New Label()
        PanelFilters = New PanelRound()
        ComboBoxServiceStatus = New ComboBox()
        Label3 = New Label()
        ComboBoxTechnician = New ComboBox()
        ComboBoxDateRange = New ComboBox()
        LabelTechnician = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelInProgress = New PanelRound()
        IconInProgress = New PictureBox()
        NumInProgress = New Label()
        LabelInProgress = New Label()
        PanelCompleted = New PanelRound()
        IconComplete = New PictureBox()
        NumCompleted = New Label()
        LabelCompleted = New Label()
        PanelPending = New PanelRound()
        IconPending = New PictureBox()
        NumPending = New Label()
        LabelPending = New Label()
        PanelInstallations = New PanelRound()
        IconTotalInstallations = New PictureBox()
        NumTotalInstallations = New Label()
        LabelTotalInstallations = New Label()
        PanelServiceTypeDistribution = New PanelRound()
        STDPercentUpgrade = New Label()
        STDGreenDot = New PictureBox()
        STDUpgrade = New Label()
        STDPercentRelocation = New Label()
        STDRepair = New Label()
        STDPercentMaintenance = New Label()
        ServiceTypeDistribution = New Label()
        STDPercentRepair = New Label()
        STDRedDot = New PictureBox()
        STDRelocation = New Label()
        STDBlueDot = New PictureBox()
        STDorangeDot = New PictureBox()
        STDMaintenance = New Label()
        PanelServiceStatusDistribution = New PanelRound()
        SSDCancel = New Label()
        SSDPercentCancelled = New Label()
        SSDRedDot = New PictureBox()
        SSDPercentProgress = New Label()
        SSDOrange1 = New PictureBox()
        SSDInProgress = New Label()
        SSDPercentPending = New Label()
        SSDPending = New Label()
        SSDOrangeDot = New PictureBox()
        SSDComplete = New Label()
        SSDPercentComplete = New Label()
        SSDGreenDot = New PictureBox()
        ServiceStatusDistribution = New Label()
        PanelServiceRequestDetails = New PanelRound()
        DataGridServiceRequestDetails = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        Customer = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        DateRequested = New DataGridViewTextBoxColumn()
        ServiceFee = New DataGridViewTextBoxColumn()
        Technician = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AddDelete = New DataGridViewTextBoxColumn()
        TitleServiceRequestDetails = New Label()
        PanelRound1 = New PanelRound()
        DashboardBtn = New Button()
        PanelFilters.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelInProgress.SuspendLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).BeginInit()
        PanelCompleted.SuspendLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).BeginInit()
        PanelPending.SuspendLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).BeginInit()
        PanelInstallations.SuspendLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceTypeDistribution.SuspendLayout()
        CType(STDGreenDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDRedDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDBlueDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDorangeDot, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceStatusDistribution.SuspendLayout()
        CType(SSDRedDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SSDOrange1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SSDOrangeDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SSDGreenDot, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceRequestDetails.SuspendLayout()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderServiceReport
        ' 
        HeaderServiceReport.AutoSize = True
        HeaderServiceReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderServiceReport.Location = New Point(43, 16)
        HeaderServiceReport.Name = "HeaderServiceReport"
        HeaderServiceReport.Size = New Size(144, 28)
        HeaderServiceReport.TabIndex = 11
        HeaderServiceReport.Text = "Service Report"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(ComboBoxServiceStatus)
        PanelFilters.Controls.Add(Label3)
        PanelFilters.Controls.Add(ComboBoxTechnician)
        PanelFilters.Controls.Add(ComboBoxDateRange)
        PanelFilters.Controls.Add(LabelTechnician)
        PanelFilters.Controls.Add(Label2)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 57)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 12
        ' 
        ' ComboBoxServiceStatus
        ' 
        ComboBoxServiceStatus.BackColor = SystemColors.ButtonFace
        ComboBoxServiceStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxServiceStatus.Font = New Font("Segoe UI", 14F)
        ComboBoxServiceStatus.ForeColor = SystemColors.WindowText
        ComboBoxServiceStatus.FormattingEnabled = True
        ComboBoxServiceStatus.Location = New Point(484, 104)
        ComboBoxServiceStatus.MinimumSize = New Size(193, 0)
        ComboBoxServiceStatus.Name = "ComboBoxServiceStatus"
        ComboBoxServiceStatus.Size = New Size(193, 33)
        ComboBoxServiceStatus.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(482, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 21)
        Label3.TabIndex = 13
        Label3.Text = "Service Status"
        ' 
        ' ComboBoxTechnician
        ' 
        ComboBoxTechnician.BackColor = SystemColors.ButtonFace
        ComboBoxTechnician.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxTechnician.Font = New Font("Segoe UI", 14F)
        ComboBoxTechnician.ForeColor = SystemColors.WindowText
        ComboBoxTechnician.FormattingEnabled = True
        ComboBoxTechnician.Location = New Point(253, 104)
        ComboBoxTechnician.MinimumSize = New Size(193, 0)
        ComboBoxTechnician.Name = "ComboBoxTechnician"
        ComboBoxTechnician.Size = New Size(193, 33)
        ComboBoxTechnician.TabIndex = 10
        ' 
        ' ComboBoxDateRange
        ' 
        ComboBoxDateRange.BackColor = SystemColors.ButtonFace
        ComboBoxDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxDateRange.Font = New Font("Segoe UI", 14F)
        ComboBoxDateRange.ForeColor = SystemColors.WindowText
        ComboBoxDateRange.FormattingEnabled = True
        ComboBoxDateRange.Location = New Point(24, 104)
        ComboBoxDateRange.MinimumSize = New Size(193, 0)
        ComboBoxDateRange.Name = "ComboBoxDateRange"
        ComboBoxDateRange.Size = New Size(193, 33)
        ComboBoxDateRange.TabIndex = 9
        ' 
        ' LabelTechnician
        ' 
        LabelTechnician.AutoSize = True
        LabelTechnician.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelTechnician.Location = New Point(251, 80)
        LabelTechnician.Name = "LabelTechnician"
        LabelTechnician.Size = New Size(85, 21)
        LabelTechnician.TabIndex = 8
        LabelTechnician.Text = "Technician"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.Location = New Point(22, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 21)
        Label2.TabIndex = 7
        Label2.Text = "Date Range"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 12F)
        Label1.Location = New Point(51, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 18)
        Label1.TabIndex = 3
        Label1.Text = "Filters"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(22, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(24, 24)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PanelInProgress
        ' 
        PanelInProgress.BackColor = Color.White
        PanelInProgress.Controls.Add(IconInProgress)
        PanelInProgress.Controls.Add(NumInProgress)
        PanelInProgress.Controls.Add(LabelInProgress)
        PanelInProgress.CornerRadius = 12
        PanelInProgress.Location = New Point(862, 258)
        PanelInProgress.Name = "PanelInProgress"
        PanelInProgress.Size = New Size(367, 167)
        PanelInProgress.TabIndex = 19
        ' 
        ' IconInProgress
        ' 
        IconInProgress.Image = CType(resources.GetObject("IconInProgress.Image"), Image)
        IconInProgress.Location = New Point(290, 59)
        IconInProgress.Name = "IconInProgress"
        IconInProgress.Size = New Size(48, 50)
        IconInProgress.SizeMode = PictureBoxSizeMode.Zoom
        IconInProgress.TabIndex = 14
        IconInProgress.TabStop = False
        ' 
        ' NumInProgress
        ' 
        NumInProgress.AutoSize = True
        NumInProgress.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumInProgress.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        NumInProgress.Location = New Point(28, 89)
        NumInProgress.Name = "NumInProgress"
        NumInProgress.Size = New Size(37, 30)
        NumInProgress.TabIndex = 13
        NumInProgress.Text = "00"
        ' 
        ' LabelInProgress
        ' 
        LabelInProgress.AutoSize = True
        LabelInProgress.Font = New Font("Verdana", 12F)
        LabelInProgress.ForeColor = SystemColors.ControlDarkDark
        LabelInProgress.Location = New Point(28, 48)
        LabelInProgress.Name = "LabelInProgress"
        LabelInProgress.Size = New Size(101, 18)
        LabelInProgress.TabIndex = 12
        LabelInProgress.Text = "In Progress"
        ' 
        ' PanelCompleted
        ' 
        PanelCompleted.BackColor = Color.White
        PanelCompleted.Controls.Add(IconComplete)
        PanelCompleted.Controls.Add(NumCompleted)
        PanelCompleted.Controls.Add(LabelCompleted)
        PanelCompleted.CornerRadius = 12
        PanelCompleted.Location = New Point(453, 258)
        PanelCompleted.Name = "PanelCompleted"
        PanelCompleted.Size = New Size(367, 167)
        PanelCompleted.TabIndex = 18
        ' 
        ' IconComplete
        ' 
        IconComplete.Image = CType(resources.GetObject("IconComplete.Image"), Image)
        IconComplete.Location = New Point(290, 59)
        IconComplete.Name = "IconComplete"
        IconComplete.Size = New Size(48, 50)
        IconComplete.SizeMode = PictureBoxSizeMode.Zoom
        IconComplete.TabIndex = 13
        IconComplete.TabStop = False
        ' 
        ' NumCompleted
        ' 
        NumCompleted.AutoSize = True
        NumCompleted.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumCompleted.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        NumCompleted.Location = New Point(28, 89)
        NumCompleted.Name = "NumCompleted"
        NumCompleted.Size = New Size(37, 30)
        NumCompleted.TabIndex = 12
        NumCompleted.Text = "00"
        ' 
        ' LabelCompleted
        ' 
        LabelCompleted.AutoSize = True
        LabelCompleted.Font = New Font("Verdana", 12F)
        LabelCompleted.ForeColor = SystemColors.ControlDarkDark
        LabelCompleted.Location = New Point(28, 48)
        LabelCompleted.Name = "LabelCompleted"
        LabelCompleted.Size = New Size(96, 18)
        LabelCompleted.TabIndex = 11
        LabelCompleted.Text = "Completed"
        ' 
        ' PanelPending
        ' 
        PanelPending.BackColor = Color.White
        PanelPending.Controls.Add(IconPending)
        PanelPending.Controls.Add(NumPending)
        PanelPending.Controls.Add(LabelPending)
        PanelPending.CornerRadius = 12
        PanelPending.Location = New Point(1273, 258)
        PanelPending.Name = "PanelPending"
        PanelPending.Size = New Size(367, 167)
        PanelPending.TabIndex = 17
        ' 
        ' IconPending
        ' 
        IconPending.Location = New Point(290, 59)
        IconPending.Name = "IconPending"
        IconPending.Size = New Size(48, 50)
        IconPending.SizeMode = PictureBoxSizeMode.Zoom
        IconPending.TabIndex = 15
        IconPending.TabStop = False
        ' 
        ' NumPending
        ' 
        NumPending.AutoSize = True
        NumPending.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumPending.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        NumPending.Location = New Point(28, 89)
        NumPending.Name = "NumPending"
        NumPending.Size = New Size(37, 30)
        NumPending.TabIndex = 14
        NumPending.Text = "00"
        ' 
        ' LabelPending
        ' 
        LabelPending.AutoSize = True
        LabelPending.Font = New Font("Verdana", 12F)
        LabelPending.ForeColor = SystemColors.ControlDarkDark
        LabelPending.Location = New Point(28, 48)
        LabelPending.Name = "LabelPending"
        LabelPending.Size = New Size(73, 18)
        LabelPending.TabIndex = 13
        LabelPending.Text = "Pending"
        ' 
        ' PanelInstallations
        ' 
        PanelInstallations.BackColor = Color.White
        PanelInstallations.Controls.Add(IconTotalInstallations)
        PanelInstallations.Controls.Add(NumTotalInstallations)
        PanelInstallations.Controls.Add(LabelTotalInstallations)
        PanelInstallations.CornerRadius = 12
        PanelInstallations.Location = New Point(43, 258)
        PanelInstallations.Name = "PanelInstallations"
        PanelInstallations.Size = New Size(367, 167)
        PanelInstallations.TabIndex = 16
        ' 
        ' IconTotalInstallations
        ' 
        IconTotalInstallations.Image = CType(resources.GetObject("IconTotalInstallations.Image"), Image)
        IconTotalInstallations.Location = New Point(290, 59)
        IconTotalInstallations.Name = "IconTotalInstallations"
        IconTotalInstallations.Size = New Size(48, 50)
        IconTotalInstallations.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalInstallations.TabIndex = 12
        IconTotalInstallations.TabStop = False
        ' 
        ' NumTotalInstallations
        ' 
        NumTotalInstallations.AutoSize = True
        NumTotalInstallations.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumTotalInstallations.Location = New Point(28, 89)
        NumTotalInstallations.Name = "NumTotalInstallations"
        NumTotalInstallations.Size = New Size(37, 30)
        NumTotalInstallations.TabIndex = 10
        NumTotalInstallations.Text = "00"
        ' 
        ' LabelTotalInstallations
        ' 
        LabelTotalInstallations.AutoSize = True
        LabelTotalInstallations.Font = New Font("Verdana", 12F)
        LabelTotalInstallations.ForeColor = SystemColors.ControlDarkDark
        LabelTotalInstallations.Location = New Point(28, 48)
        LabelTotalInstallations.Name = "LabelTotalInstallations"
        LabelTotalInstallations.Size = New Size(158, 18)
        LabelTotalInstallations.TabIndex = 11
        LabelTotalInstallations.Text = "Total Installations"
        ' 
        ' PanelServiceTypeDistribution
        ' 
        PanelServiceTypeDistribution.BackColor = Color.White
        PanelServiceTypeDistribution.Controls.Add(STDPercentUpgrade)
        PanelServiceTypeDistribution.Controls.Add(STDGreenDot)
        PanelServiceTypeDistribution.Controls.Add(STDUpgrade)
        PanelServiceTypeDistribution.Controls.Add(STDPercentRelocation)
        PanelServiceTypeDistribution.Controls.Add(STDRepair)
        PanelServiceTypeDistribution.Controls.Add(STDPercentMaintenance)
        PanelServiceTypeDistribution.Controls.Add(ServiceTypeDistribution)
        PanelServiceTypeDistribution.Controls.Add(STDPercentRepair)
        PanelServiceTypeDistribution.Controls.Add(STDRedDot)
        PanelServiceTypeDistribution.Controls.Add(STDRelocation)
        PanelServiceTypeDistribution.Controls.Add(STDBlueDot)
        PanelServiceTypeDistribution.Controls.Add(STDorangeDot)
        PanelServiceTypeDistribution.Controls.Add(STDMaintenance)
        PanelServiceTypeDistribution.CornerRadius = 12
        PanelServiceTypeDistribution.Location = New Point(862, 462)
        PanelServiceTypeDistribution.Name = "PanelServiceTypeDistribution"
        PanelServiceTypeDistribution.Size = New Size(778, 405)
        PanelServiceTypeDistribution.TabIndex = 36
        ' 
        ' STDPercentUpgrade
        ' 
        STDPercentUpgrade.Anchor = AnchorStyles.Top
        STDPercentUpgrade.AutoSize = True
        STDPercentUpgrade.Font = New Font("Segoe UI", 11F)
        STDPercentUpgrade.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentUpgrade.Location = New Point(639, 359)
        STDPercentUpgrade.Name = "STDPercentUpgrade"
        STDPercentUpgrade.Size = New Size(31, 20)
        STDPercentUpgrade.TabIndex = 47
        STDPercentUpgrade.Text = "(%)"
        ' 
        ' STDGreenDot
        ' 
        STDGreenDot.Anchor = AnchorStyles.Top
        STDGreenDot.Image = CType(resources.GetObject("STDGreenDot.Image"), Image)
        STDGreenDot.Location = New Point(529, 362)
        STDGreenDot.Name = "STDGreenDot"
        STDGreenDot.Size = New Size(12, 12)
        STDGreenDot.SizeMode = PictureBoxSizeMode.Zoom
        STDGreenDot.TabIndex = 45
        STDGreenDot.TabStop = False
        ' 
        ' STDUpgrade
        ' 
        STDUpgrade.Anchor = AnchorStyles.Top
        STDUpgrade.AutoSize = True
        STDUpgrade.Font = New Font("Segoe UI", 11F)
        STDUpgrade.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDUpgrade.Location = New Point(547, 359)
        STDUpgrade.Name = "STDUpgrade"
        STDUpgrade.Size = New Size(81, 20)
        STDUpgrade.TabIndex = 46
        STDUpgrade.Text = "In Progress"
        ' 
        ' STDPercentRelocation
        ' 
        STDPercentRelocation.Anchor = AnchorStyles.Top
        STDPercentRelocation.AutoSize = True
        STDPercentRelocation.Font = New Font("Segoe UI", 11F)
        STDPercentRelocation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRelocation.Location = New Point(177, 359)
        STDPercentRelocation.Name = "STDPercentRelocation"
        STDPercentRelocation.Size = New Size(31, 20)
        STDPercentRelocation.TabIndex = 35
        STDPercentRelocation.Text = "(%)"
        ' 
        ' STDRepair
        ' 
        STDRepair.Anchor = AnchorStyles.Top
        STDRepair.AutoSize = True
        STDRepair.Font = New Font("Segoe UI", 11F)
        STDRepair.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDRepair.Location = New Point(112, 316)
        STDRepair.Name = "STDRepair"
        STDRepair.Size = New Size(74, 20)
        STDRepair.TabIndex = 37
        STDRepair.Text = "Complete"
        ' 
        ' STDPercentMaintenance
        ' 
        STDPercentMaintenance.Anchor = AnchorStyles.Top
        STDPercentMaintenance.AutoSize = True
        STDPercentMaintenance.Font = New Font("Segoe UI", 11F)
        STDPercentMaintenance.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentMaintenance.Location = New Point(639, 316)
        STDPercentMaintenance.Name = "STDPercentMaintenance"
        STDPercentMaintenance.Size = New Size(31, 20)
        STDPercentMaintenance.TabIndex = 44
        STDPercentMaintenance.Text = "(%)"
        ' 
        ' ServiceTypeDistribution
        ' 
        ServiceTypeDistribution.Anchor = AnchorStyles.Top
        ServiceTypeDistribution.AutoSize = True
        ServiceTypeDistribution.Font = New Font("Verdana", 11F)
        ServiceTypeDistribution.ForeColor = Color.Black
        ServiceTypeDistribution.Location = New Point(28, 15)
        ServiceTypeDistribution.Name = "ServiceTypeDistribution"
        ServiceTypeDistribution.Size = New Size(190, 18)
        ServiceTypeDistribution.TabIndex = 36
        ServiceTypeDistribution.Text = "Service Type Distribution"
        ' 
        ' STDPercentRepair
        ' 
        STDPercentRepair.Anchor = AnchorStyles.Top
        STDPercentRepair.AutoSize = True
        STDPercentRepair.Font = New Font("Segoe UI", 11F)
        STDPercentRepair.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRepair.Location = New Point(192, 316)
        STDPercentRepair.Name = "STDPercentRepair"
        STDPercentRepair.Size = New Size(31, 20)
        STDPercentRepair.TabIndex = 43
        STDPercentRepair.Text = "(%)"
        ' 
        ' STDRedDot
        ' 
        STDRedDot.Anchor = AnchorStyles.Top
        STDRedDot.Image = CType(resources.GetObject("STDRedDot.Image"), Image)
        STDRedDot.Location = New Point(94, 319)
        STDRedDot.Name = "STDRedDot"
        STDRedDot.Size = New Size(12, 12)
        STDRedDot.SizeMode = PictureBoxSizeMode.Zoom
        STDRedDot.TabIndex = 38
        STDRedDot.TabStop = False
        ' 
        ' STDRelocation
        ' 
        STDRelocation.Anchor = AnchorStyles.Top
        STDRelocation.AutoSize = True
        STDRelocation.Font = New Font("Segoe UI", 11F)
        STDRelocation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDRelocation.Location = New Point(112, 359)
        STDRelocation.Name = "STDRelocation"
        STDRelocation.Size = New Size(62, 20)
        STDRelocation.TabIndex = 42
        STDRelocation.Text = "Pending"
        ' 
        ' STDBlueDot
        ' 
        STDBlueDot.Anchor = AnchorStyles.Top
        STDBlueDot.Image = CType(resources.GetObject("STDBlueDot.Image"), Image)
        STDBlueDot.Location = New Point(529, 319)
        STDBlueDot.Name = "STDBlueDot"
        STDBlueDot.Size = New Size(12, 12)
        STDBlueDot.SizeMode = PictureBoxSizeMode.Zoom
        STDBlueDot.TabIndex = 39
        STDBlueDot.TabStop = False
        ' 
        ' STDorangeDot
        ' 
        STDorangeDot.Anchor = AnchorStyles.Top
        STDorangeDot.Image = CType(resources.GetObject("STDorangeDot.Image"), Image)
        STDorangeDot.Location = New Point(94, 362)
        STDorangeDot.Name = "STDorangeDot"
        STDorangeDot.Size = New Size(12, 12)
        STDorangeDot.SizeMode = PictureBoxSizeMode.Zoom
        STDorangeDot.TabIndex = 41
        STDorangeDot.TabStop = False
        ' 
        ' STDMaintenance
        ' 
        STDMaintenance.Anchor = AnchorStyles.Top
        STDMaintenance.AutoSize = True
        STDMaintenance.Font = New Font("Segoe UI", 11F)
        STDMaintenance.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDMaintenance.Location = New Point(547, 316)
        STDMaintenance.Name = "STDMaintenance"
        STDMaintenance.Size = New Size(81, 20)
        STDMaintenance.TabIndex = 40
        STDMaintenance.Text = "In Progress"
        ' 
        ' PanelServiceStatusDistribution
        ' 
        PanelServiceStatusDistribution.BackColor = Color.White
        PanelServiceStatusDistribution.Controls.Add(SSDCancel)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentCancelled)
        PanelServiceStatusDistribution.Controls.Add(SSDRedDot)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentProgress)
        PanelServiceStatusDistribution.Controls.Add(SSDOrange1)
        PanelServiceStatusDistribution.Controls.Add(SSDInProgress)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentPending)
        PanelServiceStatusDistribution.Controls.Add(SSDPending)
        PanelServiceStatusDistribution.Controls.Add(SSDOrangeDot)
        PanelServiceStatusDistribution.Controls.Add(SSDComplete)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentComplete)
        PanelServiceStatusDistribution.Controls.Add(SSDGreenDot)
        PanelServiceStatusDistribution.Controls.Add(ServiceStatusDistribution)
        PanelServiceStatusDistribution.CornerRadius = 12
        PanelServiceStatusDistribution.Location = New Point(43, 462)
        PanelServiceStatusDistribution.Name = "PanelServiceStatusDistribution"
        PanelServiceStatusDistribution.Size = New Size(778, 405)
        PanelServiceStatusDistribution.TabIndex = 35
        ' 
        ' SSDCancel
        ' 
        SSDCancel.Anchor = AnchorStyles.Top
        SSDCancel.AutoSize = True
        SSDCancel.Font = New Font("Segoe UI", 11F)
        SSDCancel.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDCancel.Location = New Point(547, 359)
        SSDCancel.Name = "SSDCancel"
        SSDCancel.Size = New Size(74, 20)
        SSDCancel.TabIndex = 53
        SSDCancel.Text = "Cancelled"
        ' 
        ' SSDPercentCancelled
        ' 
        SSDPercentCancelled.Anchor = AnchorStyles.Top
        SSDPercentCancelled.AutoSize = True
        SSDPercentCancelled.Font = New Font("Segoe UI", 11F)
        SSDPercentCancelled.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentCancelled.Location = New Point(627, 359)
        SSDPercentCancelled.Name = "SSDPercentCancelled"
        SSDPercentCancelled.Size = New Size(31, 20)
        SSDPercentCancelled.TabIndex = 55
        SSDPercentCancelled.Text = "(%)"
        ' 
        ' SSDRedDot
        ' 
        SSDRedDot.Anchor = AnchorStyles.Top
        SSDRedDot.Image = CType(resources.GetObject("SSDRedDot.Image"), Image)
        SSDRedDot.Location = New Point(529, 362)
        SSDRedDot.Name = "SSDRedDot"
        SSDRedDot.Size = New Size(12, 12)
        SSDRedDot.SizeMode = PictureBoxSizeMode.Zoom
        SSDRedDot.TabIndex = 54
        SSDRedDot.TabStop = False
        ' 
        ' SSDPercentProgress
        ' 
        SSDPercentProgress.Anchor = AnchorStyles.Top
        SSDPercentProgress.AutoSize = True
        SSDPercentProgress.Font = New Font("Segoe UI", 11F)
        SSDPercentProgress.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentProgress.Location = New Point(639, 316)
        SSDPercentProgress.Name = "SSDPercentProgress"
        SSDPercentProgress.Size = New Size(31, 20)
        SSDPercentProgress.TabIndex = 52
        SSDPercentProgress.Text = "(%)"
        ' 
        ' SSDOrange1
        ' 
        SSDOrange1.Anchor = AnchorStyles.Top
        SSDOrange1.Image = CType(resources.GetObject("SSDOrange1.Image"), Image)
        SSDOrange1.Location = New Point(529, 319)
        SSDOrange1.Name = "SSDOrange1"
        SSDOrange1.Size = New Size(12, 12)
        SSDOrange1.SizeMode = PictureBoxSizeMode.Zoom
        SSDOrange1.TabIndex = 50
        SSDOrange1.TabStop = False
        ' 
        ' SSDInProgress
        ' 
        SSDInProgress.Anchor = AnchorStyles.Top
        SSDInProgress.AutoSize = True
        SSDInProgress.Font = New Font("Segoe UI", 11F)
        SSDInProgress.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDInProgress.Location = New Point(547, 316)
        SSDInProgress.Name = "SSDInProgress"
        SSDInProgress.Size = New Size(81, 20)
        SSDInProgress.TabIndex = 51
        SSDInProgress.Text = "In Progress"
        ' 
        ' SSDPercentPending
        ' 
        SSDPercentPending.Anchor = AnchorStyles.Top
        SSDPercentPending.AutoSize = True
        SSDPercentPending.Font = New Font("Segoe UI", 11F)
        SSDPercentPending.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentPending.Location = New Point(177, 356)
        SSDPercentPending.Name = "SSDPercentPending"
        SSDPercentPending.Size = New Size(31, 20)
        SSDPercentPending.TabIndex = 47
        SSDPercentPending.Text = "(%)"
        ' 
        ' SSDPending
        ' 
        SSDPending.Anchor = AnchorStyles.Top
        SSDPending.AutoSize = True
        SSDPending.Font = New Font("Segoe UI", 11F)
        SSDPending.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPending.Location = New Point(112, 356)
        SSDPending.Name = "SSDPending"
        SSDPending.Size = New Size(62, 20)
        SSDPending.TabIndex = 49
        SSDPending.Text = "Pending"
        ' 
        ' SSDOrangeDot
        ' 
        SSDOrangeDot.Anchor = AnchorStyles.Top
        SSDOrangeDot.Image = CType(resources.GetObject("SSDOrangeDot.Image"), Image)
        SSDOrangeDot.Location = New Point(94, 359)
        SSDOrangeDot.Name = "SSDOrangeDot"
        SSDOrangeDot.Size = New Size(12, 12)
        SSDOrangeDot.SizeMode = PictureBoxSizeMode.Zoom
        SSDOrangeDot.TabIndex = 48
        SSDOrangeDot.TabStop = False
        ' 
        ' SSDComplete
        ' 
        SSDComplete.Anchor = AnchorStyles.Top
        SSDComplete.AutoSize = True
        SSDComplete.Font = New Font("Segoe UI", 11F)
        SSDComplete.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDComplete.Location = New Point(112, 316)
        SSDComplete.Name = "SSDComplete"
        SSDComplete.Size = New Size(74, 20)
        SSDComplete.TabIndex = 44
        SSDComplete.Text = "Complete"
        ' 
        ' SSDPercentComplete
        ' 
        SSDPercentComplete.Anchor = AnchorStyles.Top
        SSDPercentComplete.AutoSize = True
        SSDPercentComplete.Font = New Font("Segoe UI", 11F)
        SSDPercentComplete.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentComplete.Location = New Point(192, 316)
        SSDPercentComplete.Name = "SSDPercentComplete"
        SSDPercentComplete.Size = New Size(31, 20)
        SSDPercentComplete.TabIndex = 46
        SSDPercentComplete.Text = "(%)"
        ' 
        ' SSDGreenDot
        ' 
        SSDGreenDot.Anchor = AnchorStyles.Top
        SSDGreenDot.Image = CType(resources.GetObject("SSDGreenDot.Image"), Image)
        SSDGreenDot.Location = New Point(94, 319)
        SSDGreenDot.Name = "SSDGreenDot"
        SSDGreenDot.Size = New Size(12, 12)
        SSDGreenDot.SizeMode = PictureBoxSizeMode.Zoom
        SSDGreenDot.TabIndex = 45
        SSDGreenDot.TabStop = False
        ' 
        ' ServiceStatusDistribution
        ' 
        ServiceStatusDistribution.Anchor = AnchorStyles.Top
        ServiceStatusDistribution.AutoSize = True
        ServiceStatusDistribution.Font = New Font("Verdana", 11F)
        ServiceStatusDistribution.ForeColor = Color.Black
        ServiceStatusDistribution.Location = New Point(22, 15)
        ServiceStatusDistribution.Name = "ServiceStatusDistribution"
        ServiceStatusDistribution.Size = New Size(203, 18)
        ServiceStatusDistribution.TabIndex = 35
        ServiceStatusDistribution.Text = "Service Status Distribution"
        ' 
        ' PanelServiceRequestDetails
        ' 
        PanelServiceRequestDetails.BackColor = Color.White
        PanelServiceRequestDetails.Controls.Add(DataGridServiceRequestDetails)
        PanelServiceRequestDetails.Controls.Add(TitleServiceRequestDetails)
        PanelServiceRequestDetails.Location = New Point(43, 906)
        PanelServiceRequestDetails.Name = "PanelServiceRequestDetails"
        PanelServiceRequestDetails.Size = New Size(1595, 609)
        PanelServiceRequestDetails.TabIndex = 37
        ' 
        ' DataGridServiceRequestDetails
        ' 
        DataGridServiceRequestDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridServiceRequestDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridServiceRequestDetails.BackgroundColor = Color.White
        DataGridServiceRequestDetails.BorderStyle = BorderStyle.None
        DataGridServiceRequestDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridServiceRequestDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 11F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridServiceRequestDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridServiceRequestDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridServiceRequestDetails.Columns.AddRange(New DataGridViewColumn() {ServiceID, Customer, ServiceType, DateRequested, ServiceFee, Technician, Status, AddDelete})
        DataGridServiceRequestDetails.EnableHeadersVisualStyles = False
        DataGridServiceRequestDetails.GridColor = Color.White
        DataGridServiceRequestDetails.Location = New Point(8, 77)
        DataGridServiceRequestDetails.Name = "DataGridServiceRequestDetails"
        DataGridServiceRequestDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridServiceRequestDetails.RowHeadersVisible = False
        DataGridServiceRequestDetails.RowTemplate.Height = 40
        DataGridServiceRequestDetails.ScrollBars = ScrollBars.Vertical
        DataGridServiceRequestDetails.Size = New Size(1578, 503)
        DataGridServiceRequestDetails.TabIndex = 27
        ' 
        ' ServiceID
        ' 
        ServiceID.Frozen = True
        ServiceID.HeaderText = "Service ID"
        ServiceID.Name = "ServiceID"
        ServiceID.ReadOnly = True
        ServiceID.Width = 150
        ' 
        ' Customer
        ' 
        Customer.HeaderText = "Customer"
        Customer.Name = "Customer"
        Customer.ReadOnly = True
        Customer.Width = 150
        ' 
        ' ServiceType
        ' 
        ServiceType.HeaderText = "Service Type"
        ServiceType.Name = "ServiceType"
        ServiceType.ReadOnly = True
        ServiceType.Width = 200
        ' 
        ' DateRequested
        ' 
        DateRequested.HeaderText = "Date Requested"
        DateRequested.Name = "DateRequested"
        DateRequested.ReadOnly = True
        DateRequested.Width = 250
        ' 
        ' ServiceFee
        ' 
        ServiceFee.HeaderText = "Service Fee"
        ServiceFee.Name = "ServiceFee"
        ServiceFee.ReadOnly = True
        ServiceFee.Width = 250
        ' 
        ' Technician
        ' 
        Technician.HeaderText = "Technician"
        Technician.Name = "Technician"
        Technician.ReadOnly = True
        Technician.Width = 350
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
        ' TitleServiceRequestDetails
        ' 
        TitleServiceRequestDetails.AutoSize = True
        TitleServiceRequestDetails.Font = New Font("Verdana", 12F)
        TitleServiceRequestDetails.ForeColor = Color.Black
        TitleServiceRequestDetails.Location = New Point(21, 28)
        TitleServiceRequestDetails.Name = "TitleServiceRequestDetails"
        TitleServiceRequestDetails.Size = New Size(203, 18)
        TitleServiceRequestDetails.TabIndex = 28
        TitleServiceRequestDetails.Text = "Service Request Details"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Location = New Point(43, 1541)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 49)
        PanelRound1.TabIndex = 44
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Segoe UI", 12F)
        DashboardBtn.ForeColor = Color.Transparent
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(1479, 13)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(18, 0, 0, 0)
        DashboardBtn.Size = New Size(161, 31)
        DashboardBtn.TabIndex = 47
        DashboardBtn.Text = "Export Report"
        DashboardBtn.TextAlign = ContentAlignment.MiddleRight
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' AdminService
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = SystemColors.Control
        Controls.Add(DashboardBtn)
        Controls.Add(PanelRound1)
        Controls.Add(PanelServiceRequestDetails)
        Controls.Add(PanelServiceTypeDistribution)
        Controls.Add(PanelServiceStatusDistribution)
        Controls.Add(PanelInProgress)
        Controls.Add(PanelCompleted)
        Controls.Add(PanelPending)
        Controls.Add(PanelInstallations)
        Controls.Add(PanelFilters)
        Controls.Add(HeaderServiceReport)
        Name = "AdminService"
        Size = New Size(1940, 1676)
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelInProgress.ResumeLayout(False)
        PanelInProgress.PerformLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).EndInit()
        PanelCompleted.ResumeLayout(False)
        PanelCompleted.PerformLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).EndInit()
        PanelPending.ResumeLayout(False)
        PanelPending.PerformLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).EndInit()
        PanelInstallations.ResumeLayout(False)
        PanelInstallations.PerformLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceTypeDistribution.ResumeLayout(False)
        PanelServiceTypeDistribution.PerformLayout()
        CType(STDGreenDot, ComponentModel.ISupportInitialize).EndInit()
        CType(STDRedDot, ComponentModel.ISupportInitialize).EndInit()
        CType(STDBlueDot, ComponentModel.ISupportInitialize).EndInit()
        CType(STDorangeDot, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceStatusDistribution.ResumeLayout(False)
        PanelServiceStatusDistribution.PerformLayout()
        CType(SSDRedDot, ComponentModel.ISupportInitialize).EndInit()
        CType(SSDOrange1, ComponentModel.ISupportInitialize).EndInit()
        CType(SSDOrangeDot, ComponentModel.ISupportInitialize).EndInit()
        CType(SSDGreenDot, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceRequestDetails.ResumeLayout(False)
        PanelServiceRequestDetails.PerformLayout()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderServiceReport As Label
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents ComboBoxServiceStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxTechnician As ComboBox
    Friend WithEvents ComboBoxDateRange As ComboBox
    Friend WithEvents LabelTechnician As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelInProgress As PanelRound
    Friend WithEvents IconInProgress As PictureBox
    Friend WithEvents NumInProgress As Label
    Friend WithEvents LabelInProgress As Label
    Friend WithEvents PanelCompleted As PanelRound
    Friend WithEvents IconComplete As PictureBox
    Friend WithEvents NumCompleted As Label
    Friend WithEvents LabelCompleted As Label
    Friend WithEvents PanelPending As PanelRound
    Friend WithEvents IconPending As PictureBox
    Friend WithEvents NumPending As Label
    Friend WithEvents LabelPending As Label
    Friend WithEvents PanelInstallations As PanelRound
    Friend WithEvents IconTotalInstallations As PictureBox
    Friend WithEvents NumTotalInstallations As Label
    Friend WithEvents LabelTotalInstallations As Label
    Friend WithEvents PanelServiceTypeDistribution As PanelRound
    Friend WithEvents STDPercentRelocation As Label
    Friend WithEvents STDRepair As Label
    Friend WithEvents ServiceTypeDistribution As Label
    Friend WithEvents STDPercentRepair As Label
    Friend WithEvents STDRedDot As PictureBox
    Friend WithEvents STDRelocation As Label
    Friend WithEvents STDorangeDot As PictureBox
    Friend WithEvents PanelServiceStatusDistribution As PanelRound
    Friend WithEvents ServiceStatusDistribution As Label
    Friend WithEvents SSDCancel As Label
    Friend WithEvents SSDPercentCancelled As Label
    Friend WithEvents SSDRedDot As PictureBox
    Friend WithEvents SSDPercentProgress As Label
    Friend WithEvents SSDOrange1 As PictureBox
    Friend WithEvents SSDInProgress As Label
    Friend WithEvents SSDPercentPending As Label
    Friend WithEvents SSDPending As Label
    Friend WithEvents SSDOrangeDot As PictureBox
    Friend WithEvents SSDComplete As Label
    Friend WithEvents SSDPercentComplete As Label
    Friend WithEvents SSDGreenDot As PictureBox
    Friend WithEvents STDPercentMaintenance As Label
    Friend WithEvents STDBlueDot As PictureBox
    Friend WithEvents STDMaintenance As Label
    Friend WithEvents STDPercentUpgrade As Label
    Friend WithEvents STDGreenDot As PictureBox
    Friend WithEvents STDUpgrade As Label
    Friend WithEvents PanelServiceRequestDetails As PanelRound
    Friend WithEvents DataGridServiceRequestDetails As DataGridView
    Friend WithEvents TitleServiceRequestDetails As Label
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents DateRequested As DataGridViewTextBoxColumn
    Friend WithEvents ServiceFee As DataGridViewTextBoxColumn
    Friend WithEvents Technician As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AddDelete As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents DashboardBtn As Button


End Class
