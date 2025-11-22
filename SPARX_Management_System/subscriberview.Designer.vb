<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subscriberview
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subscriberview))
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        LblSubsReport = New Label()
        pnlFilters = New PanelRound()
        CBPlanType = New ComboBox()
        CBAccStat = New ComboBox()
        LblPlanType = New Label()
        LblAccStatus = New Label()
        LblFilters = New Label()
        pnlTotalSubs = New PanelRound()
        picTotalSubs = New PictureBox()
        totalSub = New Label()
        LblTotalSubs = New Label()
        pnlActiveSUBS = New PanelRound()
        picActiveSub = New PictureBox()
        ActiveSubs = New Label()
        Label2 = New Label()
        pnlMonthlyRev = New PanelRound()
        picMonthRev = New PictureBox()
        monthlyRevenues = New Label()
        LblMonthlyRevs = New Label()
        pnlAvgSub = New PanelRound()
        picAvgSub = New PictureBox()
        AvgRev = New Label()
        LblAvgRevPerSub = New Label()
        pnlSubsPlan = New PanelRound()
        LblSubsByPlan = New Label()
        pnlAccDistri = New PanelRound()
        LblAccDistri = New Label()
        GBSubsDetails = New GroupBox()
        dgvSubsDeets = New DataGridView()
        colCustomerID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colPlanType = New DataGridViewTextBoxColumn()
        colMonthlyRate = New DataGridViewTextBoxColumn()
        colDateInstalled = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colEditIcon = New DataGridViewImageColumn()
        colDeleteIcon = New DataGridViewImageColumn()
        colSelect = New DataGridViewCheckBoxColumn()
        btnExport = New ButtonRounded()
        Panel1 = New Panel()
        Panel2 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        pnlFilters.SuspendLayout()
        pnlTotalSubs.SuspendLayout()
        CType(picTotalSubs, ComponentModel.ISupportInitialize).BeginInit()
        pnlActiveSUBS.SuspendLayout()
        CType(picActiveSub, ComponentModel.ISupportInitialize).BeginInit()
        pnlMonthlyRev.SuspendLayout()
        CType(picMonthRev, ComponentModel.ISupportInitialize).BeginInit()
        pnlAvgSub.SuspendLayout()
        CType(picAvgSub, ComponentModel.ISupportInitialize).BeginInit()
        pnlSubsPlan.SuspendLayout()
        pnlAccDistri.SuspendLayout()
        GBSubsDetails.SuspendLayout()
        CType(dgvSubsDeets, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblSubsReport
        ' 
        LblSubsReport.AutoSize = True
        LblSubsReport.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSubsReport.Location = New Point(22, 20)
        LblSubsReport.Name = "LblSubsReport"
        LblSubsReport.Size = New Size(131, 20)
        LblSubsReport.TabIndex = 1
        LblSubsReport.Text = "Subscriber Report"
        ' 
        ' pnlFilters
        ' 
        pnlFilters.BackColor = Color.White
        pnlFilters.Controls.Add(CBPlanType)
        pnlFilters.Controls.Add(CBAccStat)
        pnlFilters.Controls.Add(LblPlanType)
        pnlFilters.Controls.Add(LblAccStatus)
        pnlFilters.Controls.Add(LblFilters)
        pnlFilters.Location = New Point(22, 62)
        pnlFilters.Margin = New Padding(3, 2, 3, 2)
        pnlFilters.Name = "pnlFilters"
        pnlFilters.Size = New Size(1354, 112)
        pnlFilters.TabIndex = 2
        ' 
        ' CBPlanType
        ' 
        CBPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        CBPlanType.FormattingEnabled = True
        CBPlanType.Items.AddRange(New Object() {"All Plans", "Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})
        CBPlanType.Location = New Point(26, 64)
        CBPlanType.Margin = New Padding(3, 2, 3, 2)
        CBPlanType.Name = "CBPlanType"
        CBPlanType.Size = New Size(151, 23)
        CBPlanType.TabIndex = 4
        ' 
        ' CBAccStat
        ' 
        CBAccStat.DropDownStyle = ComboBoxStyle.DropDownList
        CBAccStat.FormattingEnabled = True
        CBAccStat.Items.AddRange(New Object() {"All Status", "Active", "Suspended", "Cancelled"})
        CBAccStat.Location = New Point(219, 64)
        CBAccStat.Margin = New Padding(3, 2, 3, 2)
        CBAccStat.Name = "CBAccStat"
        CBAccStat.Size = New Size(151, 23)
        CBAccStat.TabIndex = 3
        ' 
        ' LblPlanType
        ' 
        LblPlanType.AutoSize = True
        LblPlanType.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPlanType.Location = New Point(26, 46)
        LblPlanType.Name = "LblPlanType"
        LblPlanType.Size = New Size(58, 15)
        LblPlanType.TabIndex = 2
        LblPlanType.Text = "Plan Type"
        ' 
        ' LblAccStatus
        ' 
        LblAccStatus.AutoSize = True
        LblAccStatus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAccStatus.Location = New Point(219, 46)
        LblAccStatus.Name = "LblAccStatus"
        LblAccStatus.Size = New Size(88, 15)
        LblAccStatus.TabIndex = 1
        LblAccStatus.Text = "Account Status"
        ' 
        ' LblFilters
        ' 
        LblFilters.AutoSize = True
        LblFilters.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblFilters.Image = CType(resources.GetObject("LblFilters.Image"), Image)
        LblFilters.ImageAlign = ContentAlignment.MiddleLeft
        LblFilters.Location = New Point(26, 15)
        LblFilters.Name = "LblFilters"
        LblFilters.Size = New Size(62, 15)
        LblFilters.TabIndex = 0
        LblFilters.Text = "        Filters"
        ' 
        ' pnlTotalSubs
        ' 
        pnlTotalSubs.BackColor = Color.White
        pnlTotalSubs.Controls.Add(picTotalSubs)
        pnlTotalSubs.Controls.Add(totalSub)
        pnlTotalSubs.Controls.Add(LblTotalSubs)
        pnlTotalSubs.Location = New Point(22, 198)
        pnlTotalSubs.Margin = New Padding(3, 2, 3, 2)
        pnlTotalSubs.Name = "pnlTotalSubs"
        pnlTotalSubs.Size = New Size(302, 112)
        pnlTotalSubs.TabIndex = 6
        ' 
        ' picTotalSubs
        ' 
        picTotalSubs.Image = CType(resources.GetObject("picTotalSubs.Image"), Image)
        picTotalSubs.Location = New Point(204, 35)
        picTotalSubs.Margin = New Padding(3, 2, 3, 2)
        picTotalSubs.Name = "picTotalSubs"
        picTotalSubs.Size = New Size(45, 38)
        picTotalSubs.TabIndex = 7
        picTotalSubs.TabStop = False
        ' 
        ' totalSub
        ' 
        totalSub.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        totalSub.AutoSize = True
        totalSub.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        totalSub.ForeColor = Color.Black
        totalSub.Location = New Point(29, 54)
        totalSub.Name = "totalSub"
        totalSub.Size = New Size(57, 20)
        totalSub.TabIndex = 6
        totalSub.Text = "999999"
        totalSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalSubs
        ' 
        LblTotalSubs.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTotalSubs.AutoSize = True
        LblTotalSubs.Location = New Point(26, 14)
        LblTotalSubs.Name = "LblTotalSubs"
        LblTotalSubs.Size = New Size(95, 15)
        LblTotalSubs.TabIndex = 5
        LblTotalSubs.Text = "Total Subscribers"
        ' 
        ' pnlActiveSUBS
        ' 
        pnlActiveSUBS.BackColor = Color.White
        pnlActiveSUBS.Controls.Add(picActiveSub)
        pnlActiveSUBS.Controls.Add(ActiveSubs)
        pnlActiveSUBS.Controls.Add(Label2)
        pnlActiveSUBS.Location = New Point(371, 198)
        pnlActiveSUBS.Margin = New Padding(3, 2, 3, 2)
        pnlActiveSUBS.Name = "pnlActiveSUBS"
        pnlActiveSUBS.Size = New Size(302, 112)
        pnlActiveSUBS.TabIndex = 7
        ' 
        ' picActiveSub
        ' 
        picActiveSub.Location = New Point(216, 35)
        picActiveSub.Margin = New Padding(3, 2, 3, 2)
        picActiveSub.Name = "picActiveSub"
        picActiveSub.Size = New Size(38, 38)
        picActiveSub.TabIndex = 8
        picActiveSub.TabStop = False
        ' 
        ' ActiveSubs
        ' 
        ActiveSubs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ActiveSubs.AutoSize = True
        ActiveSubs.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ActiveSubs.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ActiveSubs.Location = New Point(29, 54)
        ActiveSubs.Name = "ActiveSubs"
        ActiveSubs.Size = New Size(57, 20)
        ActiveSubs.TabIndex = 6
        ActiveSubs.Text = "999999"
        ActiveSubs.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(26, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 5
        Label2.Text = "Active Subscribers"
        ' 
        ' pnlMonthlyRev
        ' 
        pnlMonthlyRev.BackColor = Color.White
        pnlMonthlyRev.Controls.Add(picMonthRev)
        pnlMonthlyRev.Controls.Add(monthlyRevenues)
        pnlMonthlyRev.Controls.Add(LblMonthlyRevs)
        pnlMonthlyRev.Location = New Point(718, 198)
        pnlMonthlyRev.Margin = New Padding(3, 2, 3, 2)
        pnlMonthlyRev.Name = "pnlMonthlyRev"
        pnlMonthlyRev.Size = New Size(302, 112)
        pnlMonthlyRev.TabIndex = 7
        ' 
        ' picMonthRev
        ' 
        picMonthRev.Image = CType(resources.GetObject("picMonthRev.Image"), Image)
        picMonthRev.Location = New Point(213, 35)
        picMonthRev.Margin = New Padding(3, 2, 3, 2)
        picMonthRev.Name = "picMonthRev"
        picMonthRev.Size = New Size(45, 38)
        picMonthRev.TabIndex = 8
        picMonthRev.TabStop = False
        ' 
        ' monthlyRevenues
        ' 
        monthlyRevenues.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        monthlyRevenues.AutoSize = True
        monthlyRevenues.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        monthlyRevenues.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        monthlyRevenues.Location = New Point(29, 54)
        monthlyRevenues.Name = "monthlyRevenues"
        monthlyRevenues.Size = New Size(57, 20)
        monthlyRevenues.TabIndex = 6
        monthlyRevenues.Text = "999999"
        monthlyRevenues.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMonthlyRevs
        ' 
        LblMonthlyRevs.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblMonthlyRevs.AutoSize = True
        LblMonthlyRevs.Location = New Point(26, 14)
        LblMonthlyRevs.Name = "LblMonthlyRevs"
        LblMonthlyRevs.Size = New Size(105, 15)
        LblMonthlyRevs.TabIndex = 5
        LblMonthlyRevs.Text = "Monthly Revenues"
        LblMonthlyRevs.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlAvgSub
        ' 
        pnlAvgSub.BackColor = Color.White
        pnlAvgSub.Controls.Add(picAvgSub)
        pnlAvgSub.Controls.Add(AvgRev)
        pnlAvgSub.Controls.Add(LblAvgRevPerSub)
        pnlAvgSub.Location = New Point(1074, 198)
        pnlAvgSub.Margin = New Padding(3, 2, 3, 2)
        pnlAvgSub.Name = "pnlAvgSub"
        pnlAvgSub.Size = New Size(302, 112)
        pnlAvgSub.TabIndex = 7
        ' 
        ' picAvgSub
        ' 
        picAvgSub.Image = CType(resources.GetObject("picAvgSub.Image"), Image)
        picAvgSub.Location = New Point(214, 35)
        picAvgSub.Margin = New Padding(3, 2, 3, 2)
        picAvgSub.Name = "picAvgSub"
        picAvgSub.Size = New Size(45, 38)
        picAvgSub.TabIndex = 8
        picAvgSub.TabStop = False
        ' 
        ' AvgRev
        ' 
        AvgRev.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AvgRev.AutoSize = True
        AvgRev.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AvgRev.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        AvgRev.Location = New Point(29, 54)
        AvgRev.Name = "AvgRev"
        AvgRev.Size = New Size(57, 20)
        AvgRev.TabIndex = 6
        AvgRev.Text = "999999"
        AvgRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAvgRevPerSub
        ' 
        LblAvgRevPerSub.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblAvgRevPerSub.AutoSize = True
        LblAvgRevPerSub.Location = New Point(26, 14)
        LblAvgRevPerSub.Name = "LblAvgRevPerSub"
        LblAvgRevPerSub.Size = New Size(119, 15)
        LblAvgRevPerSub.TabIndex = 5
        LblAvgRevPerSub.Text = "Avg Revenue per Sub"
        LblAvgRevPerSub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlSubsPlan
        ' 
        pnlSubsPlan.BackColor = Color.White
        pnlSubsPlan.Controls.Add(Panel1)
        pnlSubsPlan.Controls.Add(LblSubsByPlan)
        pnlSubsPlan.Location = New Point(22, 338)
        pnlSubsPlan.Margin = New Padding(3, 2, 3, 2)
        pnlSubsPlan.Name = "pnlSubsPlan"
        pnlSubsPlan.Size = New Size(651, 459)
        pnlSubsPlan.TabIndex = 8
        ' 
        ' LblSubsByPlan
        ' 
        LblSubsByPlan.AutoSize = True
        LblSubsByPlan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSubsByPlan.ImageAlign = ContentAlignment.MiddleLeft
        LblSubsByPlan.Location = New Point(28, 19)
        LblSubsByPlan.Name = "LblSubsByPlan"
        LblSubsByPlan.Size = New Size(138, 15)
        LblSubsByPlan.TabIndex = 5
        LblSubsByPlan.Text = "Subscribers by Plan Type"
        ' 
        ' pnlAccDistri
        ' 
        pnlAccDistri.BackColor = Color.White
        pnlAccDistri.Controls.Add(Panel2)
        pnlAccDistri.Controls.Add(LblAccDistri)
        pnlAccDistri.Location = New Point(718, 338)
        pnlAccDistri.Margin = New Padding(3, 2, 3, 2)
        pnlAccDistri.Name = "pnlAccDistri"
        pnlAccDistri.Size = New Size(658, 459)
        pnlAccDistri.TabIndex = 9
        ' 
        ' LblAccDistri
        ' 
        LblAccDistri.AutoSize = True
        LblAccDistri.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblAccDistri.ImageAlign = ContentAlignment.MiddleLeft
        LblAccDistri.Location = New Point(28, 19)
        LblAccDistri.Name = "LblAccDistri"
        LblAccDistri.Size = New Size(154, 15)
        LblAccDistri.TabIndex = 5
        LblAccDistri.Text = "Account Status Distribution"
        ' 
        ' GBSubsDetails
        ' 
        GBSubsDetails.BackColor = Color.White
        GBSubsDetails.Controls.Add(TableLayoutPanel1)
        GBSubsDetails.Controls.Add(dgvSubsDeets)
        GBSubsDetails.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GBSubsDetails.Location = New Point(22, 827)
        GBSubsDetails.Margin = New Padding(3, 2, 3, 2)
        GBSubsDetails.Name = "GBSubsDetails"
        GBSubsDetails.Padding = New Padding(3, 2, 3, 2)
        GBSubsDetails.Size = New Size(1354, 497)
        GBSubsDetails.TabIndex = 10
        GBSubsDetails.TabStop = False
        GBSubsDetails.Text = "Subscriber Details"
        ' 
        ' dgvSubsDeets
        ' 
        dgvSubsDeets.AllowUserToAddRows = False
        dgvSubsDeets.AllowUserToDeleteRows = False
        dgvSubsDeets.AllowUserToResizeColumns = False
        dgvSubsDeets.AllowUserToResizeRows = False
        dgvSubsDeets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgvSubsDeets.BackgroundColor = Color.White
        dgvSubsDeets.BorderStyle = BorderStyle.None
        dgvSubsDeets.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvSubsDeets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Color.White
        DataGridViewCellStyle11.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle11.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle11.Padding = New Padding(5, 0, 10, 0)
        DataGridViewCellStyle11.SelectionBackColor = Color.White
        DataGridViewCellStyle11.SelectionForeColor = Color.Black
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        dgvSubsDeets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        dgvSubsDeets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSubsDeets.Columns.AddRange(New DataGridViewColumn() {colCustomerID, colName, colAddress, colPlanType, colMonthlyRate, colDateInstalled, colStatus, colEditIcon, colDeleteIcon, colSelect})
        DataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = SystemColors.Window
        DataGridViewCellStyle19.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle19.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = Color.White
        DataGridViewCellStyle19.SelectionForeColor = Color.Black
        DataGridViewCellStyle19.WrapMode = DataGridViewTriState.False
        dgvSubsDeets.DefaultCellStyle = DataGridViewCellStyle19
        dgvSubsDeets.Dock = DockStyle.Fill
        dgvSubsDeets.EnableHeadersVisualStyles = False
        dgvSubsDeets.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvSubsDeets.Location = New Point(3, 22)
        dgvSubsDeets.Margin = New Padding(3, 2, 3, 2)
        dgvSubsDeets.Name = "dgvSubsDeets"
        dgvSubsDeets.ReadOnly = True
        dgvSubsDeets.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = Color.White
        DataGridViewCellStyle20.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle20.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = Color.White
        DataGridViewCellStyle20.SelectionForeColor = Color.Black
        DataGridViewCellStyle20.WrapMode = DataGridViewTriState.True
        dgvSubsDeets.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        dgvSubsDeets.RowHeadersVisible = False
        dgvSubsDeets.RowHeadersWidth = 51
        dgvSubsDeets.RowTemplate.Height = 37
        dgvSubsDeets.Size = New Size(1348, 473)
        dgvSubsDeets.TabIndex = 0
        ' 
        ' colCustomerID
        ' 
        colCustomerID.DataPropertyName = "CustomerID"
        DataGridViewCellStyle12.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.Padding = New Padding(5, 0, 10, 0)
        colCustomerID.DefaultCellStyle = DataGridViewCellStyle12
        colCustomerID.FillWeight = 90.8002243F
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        colCustomerID.Width = 131
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colName.DataPropertyName = "Name"
        DataGridViewCellStyle13.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle13.Padding = New Padding(10, 0, 10, 0)
        colName.DefaultCellStyle = DataGridViewCellStyle13
        colName.FillWeight = 53.81019F
        colName.HeaderText = "Name"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colAddress
        ' 
        colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colAddress.DataPropertyName = "Address"
        DataGridViewCellStyle14.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        colAddress.DefaultCellStyle = DataGridViewCellStyle14
        colAddress.FillWeight = 59.00358F
        colAddress.HeaderText = "Address"
        colAddress.MinimumWidth = 6
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        ' 
        ' colPlanType
        ' 
        colPlanType.DataPropertyName = "PlanType"
        DataGridViewCellStyle15.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle15.Padding = New Padding(10, 0, 10, 0)
        colPlanType.DefaultCellStyle = DataGridViewCellStyle15
        colPlanType.FillWeight = 62.09049F
        colPlanType.HeaderText = "Plan Type"
        colPlanType.MinimumWidth = 6
        colPlanType.Name = "colPlanType"
        colPlanType.ReadOnly = True
        colPlanType.Width = 113
        ' 
        ' colMonthlyRate
        ' 
        colMonthlyRate.DataPropertyName = "MonthlyRate"
        DataGridViewCellStyle16.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle16.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.Padding = New Padding(10, 0, 10, 0)
        colMonthlyRate.DefaultCellStyle = DataGridViewCellStyle16
        colMonthlyRate.FillWeight = 79.3092346F
        colMonthlyRate.HeaderText = "Monthly Rate"
        colMonthlyRate.MinimumWidth = 6
        colMonthlyRate.Name = "colMonthlyRate"
        colMonthlyRate.ReadOnly = True
        colMonthlyRate.Width = 139
        ' 
        ' colDateInstalled
        ' 
        colDateInstalled.DataPropertyName = "DateInstalled"
        DataGridViewCellStyle17.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle17.Padding = New Padding(10, 0, 10, 0)
        colDateInstalled.DefaultCellStyle = DataGridViewCellStyle17
        colDateInstalled.FillWeight = 106.250275F
        colDateInstalled.HeaderText = "Date Installed"
        colDateInstalled.MinimumWidth = 6
        colDateInstalled.Name = "colDateInstalled"
        colDateInstalled.ReadOnly = True
        colDateInstalled.Width = 140
        ' 
        ' colStatus
        ' 
        colStatus.DataPropertyName = "Status"
        DataGridViewCellStyle18.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        colStatus.DefaultCellStyle = DataGridViewCellStyle18
        colStatus.FillWeight = 135.081757F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 88
        ' 
        ' colEditIcon
        ' 
        colEditIcon.FillWeight = 73.85386F
        colEditIcon.HeaderText = ""
        colEditIcon.Image = CType(resources.GetObject("colEditIcon.Image"), Image)
        colEditIcon.MinimumWidth = 6
        colEditIcon.Name = "colEditIcon"
        colEditIcon.ReadOnly = True
        colEditIcon.Width = 16
        ' 
        ' colDeleteIcon
        ' 
        colDeleteIcon.FillWeight = 88.8154F
        colDeleteIcon.HeaderText = ""
        colDeleteIcon.Image = CType(resources.GetObject("colDeleteIcon.Image"), Image)
        colDeleteIcon.MinimumWidth = 6
        colDeleteIcon.Name = "colDeleteIcon"
        colDeleteIcon.ReadOnly = True
        colDeleteIcon.Width = 16
        ' 
        ' colSelect
        ' 
        colSelect.FillWeight = 106.623955F
        colSelect.HeaderText = ""
        colSelect.MinimumWidth = 6
        colSelect.Name = "colSelect"
        colSelect.ReadOnly = True
        colSelect.Width = 16
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnExport.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        btnExport.CornerRadius = 8
        btnExport.Cursor = Cursors.Hand
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 12F)
        btnExport.ForeColor = Color.White
        btnExport.ImageAlign = ContentAlignment.MiddleLeft
        btnExport.Location = New Point(1249, 32)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(125, 26)
        btnExport.TabIndex = 15
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(13, 42)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(590, 292)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(24, 42)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(610, 292)
        Panel2.TabIndex = 6
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 38.98305F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 61.01695F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 449F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 170F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 144F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 102F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 126F))
        TableLayoutPanel1.Location = New Point(10, 50)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1320, 419)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' subscriberview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(btnExport)
        Controls.Add(GBSubsDetails)
        Controls.Add(pnlAccDistri)
        Controls.Add(pnlSubsPlan)
        Controls.Add(pnlAvgSub)
        Controls.Add(pnlMonthlyRev)
        Controls.Add(pnlActiveSUBS)
        Controls.Add(pnlTotalSubs)
        Controls.Add(pnlFilters)
        Controls.Add(LblSubsReport)
        Name = "subscriberview"
        Size = New Size(1426, 1473)
        pnlFilters.ResumeLayout(False)
        pnlFilters.PerformLayout()
        pnlTotalSubs.ResumeLayout(False)
        pnlTotalSubs.PerformLayout()
        CType(picTotalSubs, ComponentModel.ISupportInitialize).EndInit()
        pnlActiveSUBS.ResumeLayout(False)
        pnlActiveSUBS.PerformLayout()
        CType(picActiveSub, ComponentModel.ISupportInitialize).EndInit()
        pnlMonthlyRev.ResumeLayout(False)
        pnlMonthlyRev.PerformLayout()
        CType(picMonthRev, ComponentModel.ISupportInitialize).EndInit()
        pnlAvgSub.ResumeLayout(False)
        pnlAvgSub.PerformLayout()
        CType(picAvgSub, ComponentModel.ISupportInitialize).EndInit()
        pnlSubsPlan.ResumeLayout(False)
        pnlSubsPlan.PerformLayout()
        pnlAccDistri.ResumeLayout(False)
        pnlAccDistri.PerformLayout()
        GBSubsDetails.ResumeLayout(False)
        CType(dgvSubsDeets, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSubsReport As Label
    Friend WithEvents pnlFilters As PanelRound
    Friend WithEvents CBPlanType As ComboBox
    Friend WithEvents CBAccStat As ComboBox
    Friend WithEvents LblPlanType As Label
    Friend WithEvents LblAccStatus As Label
    Friend WithEvents LblFilters As Label
    Friend WithEvents pnlTotalSubs As PanelRound
    Friend WithEvents totalSub As Label
    Friend WithEvents LblTotalSubs As Label
    Friend WithEvents pnlActiveSUBS As PanelRound
    Friend WithEvents ActiveSubs As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMonthlyRev As PanelRound
    Friend WithEvents monthlyRevenues As Label
    Friend WithEvents LblMonthlyRevs As Label
    Friend WithEvents pnlAvgSub As PanelRound
    Friend WithEvents AvgRev As Label
    Friend WithEvents LblAvgRevPerSub As Label
    Friend WithEvents pnlSubsPlan As PanelRound
    Friend WithEvents LblSubsByPlan As Label
    Friend WithEvents pnlAccDistri As PanelRound
    Friend WithEvents LblAccDistri As Label
    Friend WithEvents GBSubsDetails As GroupBox
    Friend WithEvents dgvSubsDeets As DataGridView
    Friend WithEvents picTotalSubs As PictureBox
    Friend WithEvents picActiveSub As PictureBox
    Friend WithEvents picMonthRev As PictureBox
    Friend WithEvents picAvgSub As PictureBox
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colPlanType As DataGridViewTextBoxColumn
    Friend WithEvents colMonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents colDateInstalled As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colEditIcon As DataGridViewImageColumn
    Friend WithEvents colDeleteIcon As DataGridViewImageColumn
    Friend WithEvents colSelect As DataGridViewCheckBoxColumn
    Friend WithEvents btnExport As ButtonRounded
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class

