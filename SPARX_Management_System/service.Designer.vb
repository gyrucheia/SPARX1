<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class service
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderServiceReport = New Label()
        PanelFilters = New PanelRound()
        ComboServiceType = New ComboBox()
        ComboTechnician = New ComboBox()
        ComboDateRange = New ComboBox()
        LabelStatus = New Label()
        LabelTechnician = New Label()
        LabelDateRange = New Label()
        LabelFilters = New Label()
        IconFilter = New PictureBox()
        PanelExportReport = New PanelRound()
        Label4 = New Label()
        PanelPending = New PanelRound()
        IconPending = New PictureBox()
        NumPending = New Label()
        LabelPending = New Label()
        PanelInProgress = New PanelRound()
        IconInProgress = New PictureBox()
        NumInProgress = New Label()
        LabelInProgress = New Label()
        PanelCompleted = New PanelRound()
        IconComplete = New PictureBox()
        NumCompleted = New Label()
        LabelCompleted = New Label()
        PanelTotalRequest = New PanelRound()
        IconTotalRequest = New PictureBox()
        NumTotalInstalRequest = New Label()
        LabelTotalInstallations = New Label()
        PanelServiceStatusDistribution = New PanelRound()
        SSDPercentCancelled = New Label()
        SSDCancelled = New Label()
        SSDRedDot = New PictureBox()
        SSDPercentPending = New Label()
        SSDPercentInProgress = New Label()
        SSDPercentCompleted = New Label()
        SSDPending = New Label()
        SSDOrange1Dot = New PictureBox()
        SSDInProgress = New Label()
        SSDOrange2Dot = New PictureBox()
        SSDLabelCompleted = New Label()
        x = New PictureBox()
        SubscribersGrowth = New Label()
        ServiceStatusDistribution = New Label()
        PanelServiceTypeDistribution = New PanelRound()
        STDPercentUpgrade = New Label()
        LabelUpgrade = New Label()
        STDGreenDot = New PictureBox()
        STDPercentRelocation = New Label()
        STDPercentMaintenance = New Label()
        STDPercentRepair = New Label()
        LabelRelocation = New Label()
        STDOrange = New PictureBox()
        LabelMaintenance = New Label()
        STDBlueDot = New PictureBox()
        LabelRepair = New Label()
        STDRedDot = New PictureBox()
        LabelServiceRequestDetails = New Label()
        DataGridServiceRequestDetails = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        Customer = New DataGridViewTextBoxColumn()
        ServiceType = New DataGridViewTextBoxColumn()
        DateRequested = New DataGridViewTextBoxColumn()
        ServiceFee = New DataGridViewTextBoxColumn()
        Technician = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AddDelete = New DataGridViewTextBoxColumn()
        PanelInstallationDetails = New PanelRound()
        PictureBox1 = New PictureBox()
        PanelFilters.SuspendLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).BeginInit()
        PanelExportReport.SuspendLayout()
        PanelPending.SuspendLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).BeginInit()
        PanelInProgress.SuspendLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).BeginInit()
        PanelCompleted.SuspendLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalRequest.SuspendLayout()
        CType(IconTotalRequest, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceStatusDistribution.SuspendLayout()
        CType(SSDRedDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SSDOrange1Dot, ComponentModel.ISupportInitialize).BeginInit()
        CType(SSDOrange2Dot, ComponentModel.ISupportInitialize).BeginInit()
        CType(x, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceTypeDistribution.SuspendLayout()
        CType(STDGreenDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDOrange, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDBlueDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(STDRedDot, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).BeginInit()
        PanelInstallationDetails.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderServiceReport
        ' 
        HeaderServiceReport.AutoSize = True
        HeaderServiceReport.Font = New Font("Segoe UI Semibold", 15.0F, FontStyle.Bold)
        HeaderServiceReport.Location = New Point(43, 18)
        HeaderServiceReport.Name = "HeaderServiceReport"
        HeaderServiceReport.Size = New Size(144, 28)
        HeaderServiceReport.TabIndex = 6
        HeaderServiceReport.Text = "Service Report"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(ComboServiceType)
        PanelFilters.Controls.Add(ComboTechnician)
        PanelFilters.Controls.Add(ComboDateRange)
        PanelFilters.Controls.Add(LabelStatus)
        PanelFilters.Controls.Add(LabelTechnician)
        PanelFilters.Controls.Add(LabelDateRange)
        PanelFilters.Controls.Add(LabelFilters)
        PanelFilters.Controls.Add(IconFilter)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(47, 62)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 5
        ' 
        ' ComboServiceType
        ' 
        ComboServiceType.BackColor = SystemColors.ButtonFace
        ComboServiceType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboServiceType.Font = New Font("Segoe UI", 14.0F)
        ComboServiceType.ForeColor = SystemColors.WindowText
        ComboServiceType.FormattingEnabled = True
        ComboServiceType.Location = New Point(479, 107)
        ComboServiceType.MinimumSize = New Size(193, 0)
        ComboServiceType.Name = "ComboServiceType"
        ComboServiceType.Size = New Size(193, 33)
        ComboServiceType.TabIndex = 13
        ' 
        ' ComboTechnician
        ' 
        ComboTechnician.BackColor = SystemColors.ButtonFace
        ComboTechnician.DropDownStyle = ComboBoxStyle.DropDownList
        ComboTechnician.Font = New Font("Segoe UI", 14.0F)
        ComboTechnician.ForeColor = SystemColors.WindowText
        ComboTechnician.FormattingEnabled = True
        ComboTechnician.Location = New Point(247, 107)
        ComboTechnician.MinimumSize = New Size(193, 0)
        ComboTechnician.Name = "ComboTechnician"
        ComboTechnician.Size = New Size(193, 33)
        ComboTechnician.TabIndex = 12
        ' 
        ' ComboDateRange
        ' 
        ComboDateRange.BackColor = SystemColors.ButtonFace
        ComboDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        ComboDateRange.Font = New Font("Segoe UI", 14.0F)
        ComboDateRange.ForeColor = SystemColors.WindowText
        ComboDateRange.FormattingEnabled = True
        ComboDateRange.Location = New Point(20, 107)
        ComboDateRange.MinimumSize = New Size(193, 0)
        ComboDateRange.Name = "ComboDateRange"
        ComboDateRange.Size = New Size(193, 33)
        ComboDateRange.TabIndex = 11
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LabelStatus.Location = New Point(479, 83)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(103, 21)
        LabelStatus.TabIndex = 10
        LabelStatus.Text = "Service Type"
        ' 
        ' LabelTechnician
        ' 
        LabelTechnician.AutoSize = True
        LabelTechnician.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LabelTechnician.Location = New Point(247, 83)
        LabelTechnician.Name = "LabelTechnician"
        LabelTechnician.Size = New Size(85, 21)
        LabelTechnician.TabIndex = 9
        LabelTechnician.Text = "Technician"
        ' 
        ' LabelDateRange
        ' 
        LabelDateRange.AutoSize = True
        LabelDateRange.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        LabelDateRange.Location = New Point(18, 83)
        LabelDateRange.Name = "LabelDateRange"
        LabelDateRange.Size = New Size(94, 21)
        LabelDateRange.TabIndex = 8
        LabelDateRange.Text = "Date Range"
        ' 
        ' LabelFilters
        ' 
        LabelFilters.AutoSize = True
        LabelFilters.Font = New Font("Verdana", 12.0F)
        LabelFilters.Location = New Point(49, 24)
        LabelFilters.Name = "LabelFilters"
        LabelFilters.Size = New Size(59, 18)
        LabelFilters.TabIndex = 3
        LabelFilters.Text = "Filters"
        ' 
        ' IconFilter
        ' 
        IconFilter.Image = My.Resources.filter
        IconFilter.Location = New Point(20, 20)
        IconFilter.Name = "IconFilter"
        IconFilter.Size = New Size(24, 24)
        IconFilter.SizeMode = PictureBoxSizeMode.Zoom
        IconFilter.TabIndex = 2
        IconFilter.TabStop = False
        ' 
        ' PanelExportReport
        ' 
        PanelExportReport.BackColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        PanelExportReport.Controls.Add(PictureBox1)
        PanelExportReport.Controls.Add(Label4)
        PanelExportReport.CornerRadius = 8
        PanelExportReport.Location = New Point(1496, 18)
        PanelExportReport.Name = "PanelExportReport"
        PanelExportReport.Size = New Size(146, 30)
        PanelExportReport.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(27, 4)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 21)
        Label4.TabIndex = 11
        Label4.Text = "Export Report"
        ' 
        ' PanelPending
        ' 
        PanelPending.BackColor = Color.White
        PanelPending.Controls.Add(IconPending)
        PanelPending.Controls.Add(NumPending)
        PanelPending.Controls.Add(LabelPending)
        PanelPending.CornerRadius = 12
        PanelPending.Location = New Point(1278, 271)
        PanelPending.Name = "PanelPending"
        PanelPending.Size = New Size(367, 115)
        PanelPending.TabIndex = 20
        ' 
        ' IconPending
        ' 
        IconPending.Image = My.Resources.Pending
        IconPending.Location = New Point(286, 36)
        IconPending.Name = "IconPending"
        IconPending.Size = New Size(48, 50)
        IconPending.SizeMode = PictureBoxSizeMode.Zoom
        IconPending.TabIndex = 12
        IconPending.TabStop = False
        ' 
        ' NumPending
        ' 
        NumPending.AutoSize = True
        NumPending.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumPending.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        NumPending.Location = New Point(24, 66)
        NumPending.Name = "NumPending"
        NumPending.Size = New Size(37, 30)
        NumPending.TabIndex = 11
        NumPending.Text = "00"
        ' 
        ' LabelPending
        ' 
        LabelPending.AutoSize = True
        LabelPending.Font = New Font("Verdana", 12.0F)
        LabelPending.ForeColor = SystemColors.ControlDarkDark
        LabelPending.Location = New Point(24, 25)
        LabelPending.Name = "LabelPending"
        LabelPending.Size = New Size(73, 18)
        LabelPending.TabIndex = 8
        LabelPending.Text = "Pending"
        ' 
        ' PanelInProgress
        ' 
        PanelInProgress.BackColor = Color.White
        PanelInProgress.Controls.Add(IconInProgress)
        PanelInProgress.Controls.Add(NumInProgress)
        PanelInProgress.Controls.Add(LabelInProgress)
        PanelInProgress.CornerRadius = 12
        PanelInProgress.Location = New Point(867, 271)
        PanelInProgress.Name = "PanelInProgress"
        PanelInProgress.Size = New Size(367, 115)
        PanelInProgress.TabIndex = 19
        ' 
        ' IconInProgress
        ' 
        IconInProgress.Image = My.Resources.redInProgress
        IconInProgress.Location = New Point(286, 36)
        IconInProgress.Name = "IconInProgress"
        IconInProgress.Size = New Size(48, 50)
        IconInProgress.SizeMode = PictureBoxSizeMode.Zoom
        IconInProgress.TabIndex = 11
        IconInProgress.TabStop = False
        ' 
        ' NumInProgress
        ' 
        NumInProgress.AutoSize = True
        NumInProgress.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumInProgress.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        NumInProgress.Location = New Point(24, 66)
        NumInProgress.Name = "NumInProgress"
        NumInProgress.Size = New Size(37, 30)
        NumInProgress.TabIndex = 10
        NumInProgress.Text = "00"
        ' 
        ' LabelInProgress
        ' 
        LabelInProgress.AutoSize = True
        LabelInProgress.Font = New Font("Verdana", 12.0F)
        LabelInProgress.ForeColor = SystemColors.ControlDarkDark
        LabelInProgress.Location = New Point(24, 25)
        LabelInProgress.Name = "LabelInProgress"
        LabelInProgress.Size = New Size(101, 18)
        LabelInProgress.TabIndex = 8
        LabelInProgress.Text = "In Progress"
        ' 
        ' PanelCompleted
        ' 
        PanelCompleted.BackColor = Color.White
        PanelCompleted.Controls.Add(IconComplete)
        PanelCompleted.Controls.Add(NumCompleted)
        PanelCompleted.Controls.Add(LabelCompleted)
        PanelCompleted.CornerRadius = 12
        PanelCompleted.Location = New Point(459, 271)
        PanelCompleted.Name = "PanelCompleted"
        PanelCompleted.Size = New Size(367, 115)
        PanelCompleted.TabIndex = 18
        ' 
        ' IconComplete
        ' 
        IconComplete.Image = My.Resources.greenCompleted
        IconComplete.Location = New Point(286, 36)
        IconComplete.Name = "IconComplete"
        IconComplete.Size = New Size(48, 50)
        IconComplete.SizeMode = PictureBoxSizeMode.Zoom
        IconComplete.TabIndex = 10
        IconComplete.TabStop = False
        ' 
        ' NumCompleted
        ' 
        NumCompleted.AutoSize = True
        NumCompleted.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumCompleted.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        NumCompleted.Location = New Point(24, 66)
        NumCompleted.Name = "NumCompleted"
        NumCompleted.Size = New Size(37, 30)
        NumCompleted.TabIndex = 9
        NumCompleted.Text = "00"
        ' 
        ' LabelCompleted
        ' 
        LabelCompleted.AutoSize = True
        LabelCompleted.Font = New Font("Verdana", 12.0F)
        LabelCompleted.ForeColor = SystemColors.ControlDarkDark
        LabelCompleted.Location = New Point(24, 25)
        LabelCompleted.Name = "LabelCompleted"
        LabelCompleted.Size = New Size(96, 18)
        LabelCompleted.TabIndex = 8
        LabelCompleted.Text = "Completed"
        ' 
        ' PanelTotalRequest
        ' 
        PanelTotalRequest.BackColor = Color.White
        PanelTotalRequest.Controls.Add(IconTotalRequest)
        PanelTotalRequest.Controls.Add(NumTotalInstalRequest)
        PanelTotalRequest.Controls.Add(LabelTotalInstallations)
        PanelTotalRequest.CornerRadius = 12
        PanelTotalRequest.Location = New Point(47, 271)
        PanelTotalRequest.Name = "PanelTotalRequest"
        PanelTotalRequest.Size = New Size(367, 115)
        PanelTotalRequest.TabIndex = 17
        ' 
        ' IconTotalRequest
        ' 
        IconTotalRequest.Image = My.Resources.BLueWrench
        IconTotalRequest.Location = New Point(286, 36)
        IconTotalRequest.Name = "IconTotalRequest"
        IconTotalRequest.Size = New Size(48, 50)
        IconTotalRequest.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalRequest.TabIndex = 9
        IconTotalRequest.TabStop = False
        ' 
        ' NumTotalInstalRequest
        ' 
        NumTotalInstalRequest.AutoSize = True
        NumTotalInstalRequest.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumTotalInstalRequest.Location = New Point(24, 66)
        NumTotalInstalRequest.Name = "NumTotalInstalRequest"
        NumTotalInstalRequest.Size = New Size(37, 30)
        NumTotalInstalRequest.TabIndex = 8
        NumTotalInstalRequest.Text = "00"
        ' 
        ' LabelTotalInstallations
        ' 
        LabelTotalInstallations.AutoSize = True
        LabelTotalInstallations.Font = New Font("Verdana", 12.0F)
        LabelTotalInstallations.ForeColor = SystemColors.ControlDarkDark
        LabelTotalInstallations.Location = New Point(24, 25)
        LabelTotalInstallations.Name = "LabelTotalInstallations"
        LabelTotalInstallations.Size = New Size(116, 18)
        LabelTotalInstallations.TabIndex = 8
        LabelTotalInstallations.Text = "Total request"
        ' 
        ' PanelServiceStatusDistribution
        ' 
        PanelServiceStatusDistribution.Anchor = AnchorStyles.Top
        PanelServiceStatusDistribution.BackColor = Color.White
        PanelServiceStatusDistribution.Controls.Add(SSDPercentCancelled)
        PanelServiceStatusDistribution.Controls.Add(SSDCancelled)
        PanelServiceStatusDistribution.Controls.Add(SSDRedDot)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentPending)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentInProgress)
        PanelServiceStatusDistribution.Controls.Add(SSDPercentCompleted)
        PanelServiceStatusDistribution.Controls.Add(SSDPending)
        PanelServiceStatusDistribution.Controls.Add(SSDOrange1Dot)
        PanelServiceStatusDistribution.Controls.Add(SSDInProgress)
        PanelServiceStatusDistribution.Controls.Add(SSDOrange2Dot)
        PanelServiceStatusDistribution.Controls.Add(SSDLabelCompleted)
        PanelServiceStatusDistribution.Controls.Add(x)
        PanelServiceStatusDistribution.Controls.Add(SubscribersGrowth)
        PanelServiceStatusDistribution.CornerRadius = 12
        PanelServiceStatusDistribution.Location = New Point(173, 429)
        PanelServiceStatusDistribution.Name = "PanelServiceStatusDistribution"
        PanelServiceStatusDistribution.Size = New Size(778, 405)
        PanelServiceStatusDistribution.TabIndex = 21
        ' 
        ' SSDPercentCancelled
        ' 
        SSDPercentCancelled.Anchor = AnchorStyles.Top
        SSDPercentCancelled.AutoSize = True
        SSDPercentCancelled.Font = New Font("Segoe UI", 11.0F)
        SSDPercentCancelled.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentCancelled.Location = New Point(622, 358)
        SSDPercentCancelled.Name = "SSDPercentCancelled"
        SSDPercentCancelled.Size = New Size(31, 20)
        SSDPercentCancelled.TabIndex = 31
        SSDPercentCancelled.Text = "(%)"
        ' 
        ' SSDCancelled
        ' 
        SSDCancelled.Anchor = AnchorStyles.Top
        SSDCancelled.AutoSize = True
        SSDCancelled.Font = New Font("Segoe UI", 11.0F)
        SSDCancelled.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDCancelled.Location = New Point(530, 358)
        SSDCancelled.Name = "SSDCancelled"
        SSDCancelled.Size = New Size(77, 20)
        SSDCancelled.TabIndex = 30
        SSDCancelled.Text = "Cancelled:"
        ' 
        ' SSDRedDot
        ' 
        SSDRedDot.Anchor = AnchorStyles.Top
        SSDRedDot.Image = My.Resources.redDot
        SSDRedDot.Location = New Point(512, 361)
        SSDRedDot.Name = "SSDRedDot"
        SSDRedDot.Size = New Size(12, 12)
        SSDRedDot.SizeMode = PictureBoxSizeMode.Zoom
        SSDRedDot.TabIndex = 29
        SSDRedDot.TabStop = False
        ' 
        ' SSDPercentPending
        ' 
        SSDPercentPending.Anchor = AnchorStyles.Top
        SSDPercentPending.AutoSize = True
        SSDPercentPending.Font = New Font("Segoe UI", 11.0F)
        SSDPercentPending.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentPending.Location = New Point(199, 355)
        SSDPercentPending.Name = "SSDPercentPending"
        SSDPercentPending.Size = New Size(31, 20)
        SSDPercentPending.TabIndex = 28
        SSDPercentPending.Text = "(%)"
        ' 
        ' SSDPercentInProgress
        ' 
        SSDPercentInProgress.Anchor = AnchorStyles.Top
        SSDPercentInProgress.AutoSize = True
        SSDPercentInProgress.Font = New Font("Segoe UI", 11.0F)
        SSDPercentInProgress.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentInProgress.Location = New Point(622, 314)
        SSDPercentInProgress.Name = "SSDPercentInProgress"
        SSDPercentInProgress.Size = New Size(31, 20)
        SSDPercentInProgress.TabIndex = 27
        SSDPercentInProgress.Text = "(%)"
        ' 
        ' SSDPercentCompleted
        ' 
        SSDPercentCompleted.Anchor = AnchorStyles.Top
        SSDPercentCompleted.AutoSize = True
        SSDPercentCompleted.Font = New Font("Segoe UI", 11.0F)
        SSDPercentCompleted.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPercentCompleted.Location = New Point(214, 314)
        SSDPercentCompleted.Name = "SSDPercentCompleted"
        SSDPercentCompleted.Size = New Size(31, 20)
        SSDPercentCompleted.TabIndex = 26
        SSDPercentCompleted.Text = "(%)"
        ' 
        ' SSDPending
        ' 
        SSDPending.Anchor = AnchorStyles.Top
        SSDPending.AutoSize = True
        SSDPending.Font = New Font("Segoe UI", 11.0F)
        SSDPending.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDPending.Location = New Point(134, 355)
        SSDPending.Name = "SSDPending"
        SSDPending.Size = New Size(65, 20)
        SSDPending.TabIndex = 25
        SSDPending.Text = "Pending:"
        ' 
        ' SSDOrange1Dot
        ' 
        SSDOrange1Dot.Anchor = AnchorStyles.Top
        SSDOrange1Dot.Image = My.Resources.EcstacyDot
        SSDOrange1Dot.Location = New Point(116, 358)
        SSDOrange1Dot.Name = "SSDOrange1Dot"
        SSDOrange1Dot.Size = New Size(12, 12)
        SSDOrange1Dot.SizeMode = PictureBoxSizeMode.Zoom
        SSDOrange1Dot.TabIndex = 24
        SSDOrange1Dot.TabStop = False
        ' 
        ' SSDInProgress
        ' 
        SSDInProgress.Anchor = AnchorStyles.Top
        SSDInProgress.AutoSize = True
        SSDInProgress.Font = New Font("Segoe UI", 11.0F)
        SSDInProgress.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDInProgress.Location = New Point(530, 314)
        SSDInProgress.Name = "SSDInProgress"
        SSDInProgress.Size = New Size(84, 20)
        SSDInProgress.TabIndex = 23
        SSDInProgress.Text = "In Progress:"
        ' 
        ' SSDOrange2Dot
        ' 
        SSDOrange2Dot.Anchor = AnchorStyles.Top
        SSDOrange2Dot.Image = My.Resources.ButtercupDot
        SSDOrange2Dot.Location = New Point(512, 317)
        SSDOrange2Dot.Name = "SSDOrange2Dot"
        SSDOrange2Dot.Size = New Size(12, 12)
        SSDOrange2Dot.SizeMode = PictureBoxSizeMode.Zoom
        SSDOrange2Dot.TabIndex = 22
        SSDOrange2Dot.TabStop = False
        ' 
        ' SSDLabelCompleted
        ' 
        SSDLabelCompleted.Anchor = AnchorStyles.Top
        SSDLabelCompleted.AutoSize = True
        SSDLabelCompleted.Font = New Font("Segoe UI", 11.0F)
        SSDLabelCompleted.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        SSDLabelCompleted.Location = New Point(134, 314)
        SSDLabelCompleted.Name = "SSDLabelCompleted"
        SSDLabelCompleted.Size = New Size(86, 20)
        SSDLabelCompleted.TabIndex = 20
        SSDLabelCompleted.Text = "Completed:"
        ' 
        ' x
        ' 
        x.Anchor = AnchorStyles.Top
        x.Image = My.Resources.greenDot
        x.Location = New Point(116, 317)
        x.Name = "x"
        x.Size = New Size(12, 12)
        x.SizeMode = PictureBoxSizeMode.Zoom
        x.TabIndex = 21
        x.TabStop = False
        ' 
        ' SubscribersGrowth
        ' 
        SubscribersGrowth.Anchor = AnchorStyles.Top
        SubscribersGrowth.AutoSize = True
        SubscribersGrowth.Font = New Font("Verdana", 11.0F)
        SubscribersGrowth.ForeColor = Color.Black
        SubscribersGrowth.Location = New Point(23, 15)
        SubscribersGrowth.Name = "SubscribersGrowth"
        SubscribersGrowth.Size = New Size(203, 18)
        SubscribersGrowth.TabIndex = 10
        SubscribersGrowth.Text = "Service Status Distribution"
        ' 
        ' ServiceStatusDistribution
        ' 
        ServiceStatusDistribution.Anchor = AnchorStyles.Top
        ServiceStatusDistribution.AutoSize = True
        ServiceStatusDistribution.Font = New Font("Verdana", 11.0F)
        ServiceStatusDistribution.ForeColor = Color.Black
        ServiceStatusDistribution.Location = New Point(24, 24)
        ServiceStatusDistribution.Name = "ServiceStatusDistribution"
        ServiceStatusDistribution.Size = New Size(190, 18)
        ServiceStatusDistribution.TabIndex = 11
        ServiceStatusDistribution.Text = "Service Type Distribution"
        ' 
        ' PanelServiceTypeDistribution
        ' 
        PanelServiceTypeDistribution.Anchor = AnchorStyles.Top
        PanelServiceTypeDistribution.BackColor = Color.White
        PanelServiceTypeDistribution.Controls.Add(STDPercentUpgrade)
        PanelServiceTypeDistribution.Controls.Add(LabelUpgrade)
        PanelServiceTypeDistribution.Controls.Add(STDGreenDot)
        PanelServiceTypeDistribution.Controls.Add(STDPercentRelocation)
        PanelServiceTypeDistribution.Controls.Add(STDPercentMaintenance)
        PanelServiceTypeDistribution.Controls.Add(STDPercentRepair)
        PanelServiceTypeDistribution.Controls.Add(LabelRelocation)
        PanelServiceTypeDistribution.Controls.Add(STDOrange)
        PanelServiceTypeDistribution.Controls.Add(LabelMaintenance)
        PanelServiceTypeDistribution.Controls.Add(STDBlueDot)
        PanelServiceTypeDistribution.Controls.Add(LabelRepair)
        PanelServiceTypeDistribution.Controls.Add(STDRedDot)
        PanelServiceTypeDistribution.Controls.Add(ServiceStatusDistribution)
        PanelServiceTypeDistribution.CornerRadius = 12
        PanelServiceTypeDistribution.Location = New Point(997, 429)
        PanelServiceTypeDistribution.Name = "PanelServiceTypeDistribution"
        PanelServiceTypeDistribution.Size = New Size(778, 405)
        PanelServiceTypeDistribution.TabIndex = 22
        ' 
        ' STDPercentUpgrade
        ' 
        STDPercentUpgrade.Anchor = AnchorStyles.Top
        STDPercentUpgrade.AutoSize = True
        STDPercentUpgrade.Font = New Font("Segoe UI", 11.0F)
        STDPercentUpgrade.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentUpgrade.Location = New Point(643, 358)
        STDPercentUpgrade.Name = "STDPercentUpgrade"
        STDPercentUpgrade.Size = New Size(31, 20)
        STDPercentUpgrade.TabIndex = 22
        STDPercentUpgrade.Text = "(%)"
        ' 
        ' LabelUpgrade
        ' 
        LabelUpgrade.Anchor = AnchorStyles.Top
        LabelUpgrade.AutoSize = True
        LabelUpgrade.Font = New Font("Segoe UI", 11.0F)
        LabelUpgrade.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelUpgrade.Location = New Point(551, 358)
        LabelUpgrade.Name = "LabelUpgrade"
        LabelUpgrade.Size = New Size(70, 20)
        LabelUpgrade.TabIndex = 21
        LabelUpgrade.Text = "Upgrade:"
        ' 
        ' STDGreenDot
        ' 
        STDGreenDot.Anchor = AnchorStyles.Top
        STDGreenDot.Image = My.Resources.greenDot
        STDGreenDot.Location = New Point(533, 361)
        STDGreenDot.Name = "STDGreenDot"
        STDGreenDot.Size = New Size(12, 12)
        STDGreenDot.SizeMode = PictureBoxSizeMode.Zoom
        STDGreenDot.TabIndex = 20
        STDGreenDot.TabStop = False
        ' 
        ' STDPercentRelocation
        ' 
        STDPercentRelocation.Anchor = AnchorStyles.Top
        STDPercentRelocation.AutoSize = True
        STDPercentRelocation.Font = New Font("Segoe UI", 11.0F)
        STDPercentRelocation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRelocation.Location = New Point(214, 358)
        STDPercentRelocation.Name = "STDPercentRelocation"
        STDPercentRelocation.Size = New Size(31, 20)
        STDPercentRelocation.TabIndex = 19
        STDPercentRelocation.Text = "(%)"
        ' 
        ' STDPercentMaintenance
        ' 
        STDPercentMaintenance.Anchor = AnchorStyles.Top
        STDPercentMaintenance.AutoSize = True
        STDPercentMaintenance.Font = New Font("Segoe UI", 11.0F)
        STDPercentMaintenance.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentMaintenance.Location = New Point(649, 318)
        STDPercentMaintenance.Name = "STDPercentMaintenance"
        STDPercentMaintenance.Size = New Size(31, 20)
        STDPercentMaintenance.TabIndex = 18
        STDPercentMaintenance.Text = "(%)"
        ' 
        ' STDPercentRepair
        ' 
        STDPercentRepair.Anchor = AnchorStyles.Top
        STDPercentRepair.AutoSize = True
        STDPercentRepair.Font = New Font("Segoe UI", 11.0F)
        STDPercentRepair.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        STDPercentRepair.Location = New Point(206, 317)
        STDPercentRepair.Name = "STDPercentRepair"
        STDPercentRepair.Size = New Size(31, 20)
        STDPercentRepair.TabIndex = 17
        STDPercentRepair.Text = "(%)"
        ' 
        ' LabelRelocation
        ' 
        LabelRelocation.Anchor = AnchorStyles.Top
        LabelRelocation.AutoSize = True
        LabelRelocation.Font = New Font("Segoe UI", 11.0F)
        LabelRelocation.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelRelocation.Location = New Point(127, 358)
        LabelRelocation.Name = "LabelRelocation"
        LabelRelocation.Size = New Size(83, 20)
        LabelRelocation.TabIndex = 16
        LabelRelocation.Text = "Relocation:"
        ' 
        ' STDOrange
        ' 
        STDOrange.Anchor = AnchorStyles.Top
        STDOrange.Image = My.Resources.EcstacyDot
        STDOrange.Location = New Point(109, 361)
        STDOrange.Name = "STDOrange"
        STDOrange.Size = New Size(12, 12)
        STDOrange.SizeMode = PictureBoxSizeMode.Zoom
        STDOrange.TabIndex = 15
        STDOrange.TabStop = False
        ' 
        ' LabelMaintenance
        ' 
        LabelMaintenance.Anchor = AnchorStyles.Top
        LabelMaintenance.AutoSize = True
        LabelMaintenance.Font = New Font("Segoe UI", 11.0F)
        LabelMaintenance.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelMaintenance.Location = New Point(551, 317)
        LabelMaintenance.Name = "LabelMaintenance"
        LabelMaintenance.Size = New Size(97, 20)
        LabelMaintenance.TabIndex = 14
        LabelMaintenance.Text = "Maintenance:"
        ' 
        ' STDBlueDot
        ' 
        STDBlueDot.Anchor = AnchorStyles.Top
        STDBlueDot.Image = My.Resources.BlueDot
        STDBlueDot.Location = New Point(533, 320)
        STDBlueDot.Name = "STDBlueDot"
        STDBlueDot.Size = New Size(12, 12)
        STDBlueDot.SizeMode = PictureBoxSizeMode.Zoom
        STDBlueDot.TabIndex = 13
        STDBlueDot.TabStop = False
        ' 
        ' LabelRepair
        ' 
        LabelRepair.Anchor = AnchorStyles.Top
        LabelRepair.AutoSize = True
        LabelRepair.Font = New Font("Segoe UI", 11.0F)
        LabelRepair.ForeColor = Color.FromArgb(CByte(74), CByte(85), CByte(101))
        LabelRepair.Location = New Point(126, 317)
        LabelRepair.Name = "LabelRepair"
        LabelRepair.Size = New Size(55, 20)
        LabelRepair.TabIndex = 12
        LabelRepair.Text = "Repair:"
        ' 
        ' STDRedDot
        ' 
        STDRedDot.Anchor = AnchorStyles.Top
        STDRedDot.Image = My.Resources.redDot
        STDRedDot.Location = New Point(108, 320)
        STDRedDot.Name = "STDRedDot"
        STDRedDot.Size = New Size(12, 12)
        STDRedDot.SizeMode = PictureBoxSizeMode.Zoom
        STDRedDot.TabIndex = 12
        STDRedDot.TabStop = False
        ' 
        ' LabelServiceRequestDetails
        ' 
        LabelServiceRequestDetails.AutoSize = True
        LabelServiceRequestDetails.Font = New Font("Verdana", 12.0F)
        LabelServiceRequestDetails.ForeColor = SystemColors.ControlText
        LabelServiceRequestDetails.Location = New Point(24, 25)
        LabelServiceRequestDetails.Name = "LabelServiceRequestDetails"
        LabelServiceRequestDetails.Size = New Size(203, 18)
        LabelServiceRequestDetails.TabIndex = 24
        LabelServiceRequestDetails.Text = "Service Request Details"
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
        DataGridViewCellStyle2.Font = New Font("Verdana", 11.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridServiceRequestDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridServiceRequestDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridServiceRequestDetails.Columns.AddRange(New DataGridViewColumn() {ServiceID, Customer, ServiceType, DateRequested, ServiceFee, Technician, Status, AddDelete})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridServiceRequestDetails.DefaultCellStyle = DataGridViewCellStyle3
        DataGridServiceRequestDetails.EnableHeadersVisualStyles = False
        DataGridServiceRequestDetails.GridColor = Color.White
        DataGridServiceRequestDetails.Location = New Point(11, 74)
        DataGridServiceRequestDetails.Name = "DataGridServiceRequestDetails"
        DataGridServiceRequestDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridServiceRequestDetails.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridServiceRequestDetails.RowHeadersVisible = False
        DataGridServiceRequestDetails.RowTemplate.Height = 40
        DataGridServiceRequestDetails.ScrollBars = ScrollBars.Vertical
        DataGridServiceRequestDetails.Size = New Size(1578, 503)
        DataGridServiceRequestDetails.TabIndex = 23
        ' 
        ' ServiceID
        ' 
        ServiceID.Frozen = True
        ServiceID.HeaderText = "ServiceID"
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
        ServiceFee.HeaderText = "ServiceFee"
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
        ' PanelInstallationDetails
        ' 
        PanelInstallationDetails.BackColor = Color.White
        PanelInstallationDetails.Controls.Add(LabelServiceRequestDetails)
        PanelInstallationDetails.Controls.Add(DataGridServiceRequestDetails)
        PanelInstallationDetails.CornerRadius = 12
        PanelInstallationDetails.Location = New Point(47, 880)
        PanelInstallationDetails.Name = "PanelInstallationDetails"
        PanelInstallationDetails.Size = New Size(1595, 609)
        PanelInstallationDetails.TabIndex = 23
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.export
        PictureBox1.Location = New Point(4, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' service
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        Controls.Add(PanelInstallationDetails)
        Controls.Add(PanelServiceStatusDistribution)
        Controls.Add(PanelServiceTypeDistribution)
        Controls.Add(PanelPending)
        Controls.Add(PanelInProgress)
        Controls.Add(PanelCompleted)
        Controls.Add(PanelTotalRequest)
        Controls.Add(PanelExportReport)
        Controls.Add(HeaderServiceReport)
        Controls.Add(PanelFilters)
        Name = "service"
        Size = New Size(1940, 1912)
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).EndInit()
        PanelExportReport.ResumeLayout(False)
        PanelExportReport.PerformLayout()
        PanelPending.ResumeLayout(False)
        PanelPending.PerformLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).EndInit()
        PanelInProgress.ResumeLayout(False)
        PanelInProgress.PerformLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).EndInit()
        PanelCompleted.ResumeLayout(False)
        PanelCompleted.PerformLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalRequest.ResumeLayout(False)
        PanelTotalRequest.PerformLayout()
        CType(IconTotalRequest, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceStatusDistribution.ResumeLayout(False)
        PanelServiceStatusDistribution.PerformLayout()
        CType(SSDRedDot, ComponentModel.ISupportInitialize).EndInit()
        CType(SSDOrange1Dot, ComponentModel.ISupportInitialize).EndInit()
        CType(SSDOrange2Dot, ComponentModel.ISupportInitialize).EndInit()
        CType(x, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceTypeDistribution.ResumeLayout(False)
        PanelServiceTypeDistribution.PerformLayout()
        CType(STDGreenDot, ComponentModel.ISupportInitialize).EndInit()
        CType(STDOrange, ComponentModel.ISupportInitialize).EndInit()
        CType(STDBlueDot, ComponentModel.ISupportInitialize).EndInit()
        CType(STDRedDot, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).EndInit()
        PanelInstallationDetails.ResumeLayout(False)
        PanelInstallationDetails.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderServiceReport As Label
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents PanelExportReport As PanelRound
    Friend WithEvents LabelFilters As Label
    Friend WithEvents IconFilter As PictureBox
    Friend WithEvents ComboServiceType As ComboBox
    Friend WithEvents ComboTechnician As ComboBox
    Friend WithEvents ComboDateRange As ComboBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelTechnician As Label
    Friend WithEvents LabelDateRange As Label
    Friend WithEvents PanelPending As PanelRound
    Friend WithEvents IconPending As PictureBox
    Friend WithEvents NumPending As Label
    Friend WithEvents LabelPending As Label
    Friend WithEvents PanelInProgress As PanelRound
    Friend WithEvents IconInProgress As PictureBox
    Friend WithEvents NumInProgress As Label
    Friend WithEvents LabelInProgress As Label
    Friend WithEvents PanelCompleted As PanelRound
    Friend WithEvents IconComplete As PictureBox
    Friend WithEvents NumCompleted As Label
    Friend WithEvents LabelCompleted As Label
    Friend WithEvents PanelTotalRequest As PanelRound
    Friend WithEvents IconTotalRequest As PictureBox
    Friend WithEvents NumTotalInstalRequest As Label
    Friend WithEvents LabelTotalInstallations As Label
    Friend WithEvents PanelServiceStatusDistribution As PanelRound
    Friend WithEvents SubscribersGrowth As Label
    Friend WithEvents ServiceStatusDistribution As Label
    Friend WithEvents PanelServiceTypeDistribution As PanelRound
    Friend WithEvents STDPercentRelocation As Label
    Friend WithEvents STDPercentMaintenance As Label
    Friend WithEvents STDPercentRepair As Label
    Friend WithEvents LabelRelocation As Label
    Friend WithEvents STDOrange As PictureBox
    Friend WithEvents LabelMaintenance As Label
    Friend WithEvents STDBlueDot As PictureBox
    Friend WithEvents LabelRepair As Label
    Friend WithEvents STDRedDot As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelServiceRequestDetails As Label
    Friend WithEvents DataGridServiceRequestDetails As DataGridView
    Friend WithEvents PanelInstallationDetails As PanelRound
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents ServiceType As DataGridViewTextBoxColumn
    Friend WithEvents DateRequested As DataGridViewTextBoxColumn
    Friend WithEvents ServiceFee As DataGridViewTextBoxColumn
    Friend WithEvents Technician As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AddDelete As DataGridViewTextBoxColumn
    Friend WithEvents SSDPercentPending As Label
    Friend WithEvents SSDPercentInProgress As Label
    Friend WithEvents SSDPercentCompleted As Label
    Friend WithEvents SSDPending As Label
    Friend WithEvents SSDOrange1Dot As PictureBox
    Friend WithEvents SSDInProgress As Label
    Friend WithEvents SSDOrange2Dot As PictureBox
    Friend WithEvents SSDLabelCompleted As Label
    Friend WithEvents x As PictureBox
    Friend WithEvents SSDPercentCancelled As Label
    Friend WithEvents SSDCancelled As Label
    Friend WithEvents SSDRedDot As PictureBox
    Friend WithEvents STDPercentUpgrade As Label
    Friend WithEvents LabelUpgrade As Label
    Friend WithEvents STDGreenDot As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class