<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInstallation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInstallation))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label11 = New Label()
        Label7 = New Label()
        Completed = New Label()
        PictureBox6 = New PictureBox()
        PercentComplete = New Label()
        InProgress = New Label()
        PictureBox2 = New PictureBox()
        Label8 = New Label()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        PictureBox4 = New PictureBox()
        PanelRound8 = New PanelRound()
        PanelRound7 = New PanelRound()
        Label9 = New Label()
        PanelRound6 = New PanelRound()
        PanelRound5 = New PanelRound()
        Label5 = New Label()
        PanelRound4 = New PanelRound()
        HeaderInstallationReport = New Label()
        PanelFilters = New PanelRound()
        ComboBoxStatus = New ComboBox()
        Label3 = New Label()
        ComboBoxPlanType = New ComboBox()
        ComboBoxDateRange = New ComboBox()
        LabelPlanType = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelRound1 = New PanelRound()
        IconTotalInstallations = New PictureBox()
        NumTotalInstallations = New Label()
        LabelTotalInstallations = New Label()
        PanelRound2 = New PanelRound()
        IconPending = New PictureBox()
        NumPending = New Label()
        LabelPending = New Label()
        PanelRound3 = New PanelRound()
        IconComplete = New PictureBox()
        NumCompleted = New Label()
        LabelCompleted = New Label()
        PanelRound9 = New PanelRound()
        IconInProgress = New PictureBox()
        NumInProgress = New Label()
        LabelInProgress = New Label()
        LabelInstallationDetails = New Label()
        DataGridInstallationDetails = New DataGridView()
        ServiceID = New DataGridViewTextBoxColumn()
        Customer = New DataGridViewTextBoxColumn()
        ContactNo = New DataGridViewTextBoxColumn()
        DateRequested = New DataGridViewTextBoxColumn()
        Technician = New DataGridViewTextBoxColumn()
        Address = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AddDelete = New DataGridViewTextBoxColumn()
        PanelRound10 = New PanelRound()
        PanelRound11 = New PanelRound()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound8.SuspendLayout()
        PanelRound7.SuspendLayout()
        PanelRound6.SuspendLayout()
        PanelRound5.SuspendLayout()
        PanelRound4.SuspendLayout()
        PanelFilters.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound1.SuspendLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound2.SuspendLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound3.SuspendLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound9.SuspendLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(781, 30)
        Label11.Name = "Label11"
        Label11.Size = New Size(41, 21)
        Label11.TabIndex = 25
        Label11.Text = "00%"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(781, 29)
        Label7.Name = "Label7"
        Label7.Size = New Size(41, 21)
        Label7.TabIndex = 25
        Label7.Text = "00%"
        ' 
        ' Completed
        ' 
        Completed.Anchor = AnchorStyles.Top
        Completed.AutoSize = True
        Completed.Font = New Font("Segoe UI", 11F)
        Completed.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Completed.Location = New Point(38, 29)
        Completed.Name = "Completed"
        Completed.Size = New Size(83, 20)
        Completed.TabIndex = 23
        Completed.Text = "Completed"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(20, 33)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(12, 12)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 24
        PictureBox6.TabStop = False
        ' 
        ' PercentComplete
        ' 
        PercentComplete.Anchor = AnchorStyles.Top
        PercentComplete.AutoSize = True
        PercentComplete.Font = New Font("Segoe UI Semibold", 12F)
        PercentComplete.ForeColor = Color.Black
        PercentComplete.Location = New Point(781, 28)
        PercentComplete.Name = "PercentComplete"
        PercentComplete.Size = New Size(41, 21)
        PercentComplete.TabIndex = 25
        PercentComplete.Text = "00%"
        ' 
        ' InProgress
        ' 
        InProgress.Anchor = AnchorStyles.Top
        InProgress.AutoSize = True
        InProgress.Font = New Font("Segoe UI", 11F)
        InProgress.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        InProgress.Location = New Point(38, 30)
        InProgress.Name = "InProgress"
        InProgress.Size = New Size(81, 20)
        InProgress.TabIndex = 23
        InProgress.Text = "In Progress"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(20, 34)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(12, 12)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F)
        Label8.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Label8.Location = New Point(38, 29)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 20)
        Label8.TabIndex = 23
        Label8.Text = "Pending"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(20, 33)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(12, 12)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 24
        PictureBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 11F)
        Label10.ForeColor = Color.FromArgb(CByte(54), CByte(65), CByte(83))
        Label10.Location = New Point(38, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 20)
        Label10.TabIndex = 23
        Label10.Text = "Cancelled"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(20, 35)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(12, 12)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' PanelRound8
        ' 
        PanelRound8.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelRound8.Controls.Add(Label10)
        PanelRound8.Controls.Add(PictureBox4)
        PanelRound8.Controls.Add(Label11)
        PanelRound8.Location = New Point(695, 358)
        PanelRound8.Name = "PanelRound8"
        PanelRound8.Size = New Size(861, 74)
        PanelRound8.TabIndex = 15
        ' 
        ' PanelRound7
        ' 
        PanelRound7.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelRound7.Controls.Add(Label8)
        PanelRound7.Controls.Add(PictureBox3)
        PanelRound7.Controls.Add(Label9)
        PanelRound7.Location = New Point(695, 263)
        PanelRound7.Name = "PanelRound7"
        PanelRound7.Size = New Size(861, 74)
        PanelRound7.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(781, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(41, 21)
        Label9.TabIndex = 25
        Label9.Text = "00%"
        ' 
        ' PanelRound6
        ' 
        PanelRound6.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelRound6.Controls.Add(InProgress)
        PanelRound6.Controls.Add(PictureBox2)
        PanelRound6.Controls.Add(Label7)
        PanelRound6.Location = New Point(695, 170)
        PanelRound6.Name = "PanelRound6"
        PanelRound6.Size = New Size(861, 74)
        PanelRound6.TabIndex = 13
        ' 
        ' PanelRound5
        ' 
        PanelRound5.BackColor = Color.FromArgb(CByte(249), CByte(250), CByte(251))
        PanelRound5.Controls.Add(Completed)
        PanelRound5.Controls.Add(PictureBox6)
        PanelRound5.Controls.Add(PercentComplete)
        PanelRound5.Location = New Point(695, 75)
        PanelRound5.Name = "PanelRound5"
        PanelRound5.Size = New Size(861, 74)
        PanelRound5.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 12F)
        Label5.Location = New Point(22, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(257, 18)
        Label5.TabIndex = 11
        Label5.Text = "Insallation Status Distribution"
        ' 
        ' PanelRound4
        ' 
        PanelRound4.BackColor = Color.White
        PanelRound4.Controls.Add(PanelRound8)
        PanelRound4.Controls.Add(PanelRound7)
        PanelRound4.Controls.Add(PanelRound6)
        PanelRound4.Controls.Add(PanelRound5)
        PanelRound4.Controls.Add(Label5)
        PanelRound4.CornerRadius = 12
        PanelRound4.Location = New Point(43, 463)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(1597, 512)
        PanelRound4.TabIndex = 9
        ' 
        ' HeaderInstallationReport
        ' 
        HeaderInstallationReport.AutoSize = True
        HeaderInstallationReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderInstallationReport.Location = New Point(43, 16)
        HeaderInstallationReport.Name = "HeaderInstallationReport"
        HeaderInstallationReport.Size = New Size(179, 28)
        HeaderInstallationReport.TabIndex = 10
        HeaderInstallationReport.Text = "Installation Report"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(ComboBoxStatus)
        PanelFilters.Controls.Add(Label3)
        PanelFilters.Controls.Add(ComboBoxPlanType)
        PanelFilters.Controls.Add(ComboBoxDateRange)
        PanelFilters.Controls.Add(LabelPlanType)
        PanelFilters.Controls.Add(Label2)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 55)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 11
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.BackColor = SystemColors.ButtonFace
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Segoe UI", 14F)
        ComboBoxStatus.ForeColor = SystemColors.WindowText
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Location = New Point(484, 104)
        ComboBoxStatus.MinimumSize = New Size(193, 0)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(193, 33)
        ComboBoxStatus.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.Location = New Point(482, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 21)
        Label3.TabIndex = 13
        Label3.Text = "Status"
        ' 
        ' ComboBoxPlanType
        ' 
        ComboBoxPlanType.BackColor = SystemColors.ButtonFace
        ComboBoxPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPlanType.Font = New Font("Segoe UI", 14F)
        ComboBoxPlanType.ForeColor = SystemColors.WindowText
        ComboBoxPlanType.FormattingEnabled = True
        ComboBoxPlanType.Location = New Point(253, 104)
        ComboBoxPlanType.MinimumSize = New Size(193, 0)
        ComboBoxPlanType.Name = "ComboBoxPlanType"
        ComboBoxPlanType.Size = New Size(193, 33)
        ComboBoxPlanType.TabIndex = 10
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
        ' LabelPlanType
        ' 
        LabelPlanType.AutoSize = True
        LabelPlanType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelPlanType.Location = New Point(251, 80)
        LabelPlanType.Name = "LabelPlanType"
        LabelPlanType.Size = New Size(79, 21)
        LabelPlanType.TabIndex = 8
        LabelPlanType.Text = "Plan Type"
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
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(IconTotalInstallations)
        PanelRound1.Controls.Add(NumTotalInstallations)
        PanelRound1.Controls.Add(LabelTotalInstallations)
        PanelRound1.CornerRadius = 12
        PanelRound1.Location = New Point(43, 256)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(367, 167)
        PanelRound1.TabIndex = 12
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
        ' PanelRound2
        ' 
        PanelRound2.BackColor = Color.White
        PanelRound2.Controls.Add(IconPending)
        PanelRound2.Controls.Add(NumPending)
        PanelRound2.Controls.Add(LabelPending)
        PanelRound2.CornerRadius = 12
        PanelRound2.Location = New Point(1273, 256)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(367, 167)
        PanelRound2.TabIndex = 13
        ' 
        ' IconPending
        ' 
        IconPending.Image = CType(resources.GetObject("IconPending.Image"), Image)
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
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.White
        PanelRound3.Controls.Add(IconComplete)
        PanelRound3.Controls.Add(NumCompleted)
        PanelRound3.Controls.Add(LabelCompleted)
        PanelRound3.CornerRadius = 12
        PanelRound3.Location = New Point(453, 256)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(367, 167)
        PanelRound3.TabIndex = 14
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
        ' PanelRound9
        ' 
        PanelRound9.BackColor = Color.White
        PanelRound9.Controls.Add(IconInProgress)
        PanelRound9.Controls.Add(NumInProgress)
        PanelRound9.Controls.Add(LabelInProgress)
        PanelRound9.CornerRadius = 12
        PanelRound9.Location = New Point(862, 256)
        PanelRound9.Name = "PanelRound9"
        PanelRound9.Size = New Size(367, 167)
        PanelRound9.TabIndex = 15
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
        ' LabelInstallationDetails
        ' 
        LabelInstallationDetails.AutoSize = True
        LabelInstallationDetails.Font = New Font("Verdana", 12F)
        LabelInstallationDetails.ForeColor = Color.Black
        LabelInstallationDetails.Location = New Point(21, 19)
        LabelInstallationDetails.Name = "LabelInstallationDetails"
        LabelInstallationDetails.Size = New Size(167, 18)
        LabelInstallationDetails.TabIndex = 26
        LabelInstallationDetails.Text = "Installation Details"
        ' 
        ' DataGridInstallationDetails
        ' 
        DataGridInstallationDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridInstallationDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridInstallationDetails.BackgroundColor = Color.White
        DataGridInstallationDetails.BorderStyle = BorderStyle.None
        DataGridInstallationDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridInstallationDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 11F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridInstallationDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridInstallationDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridInstallationDetails.Columns.AddRange(New DataGridViewColumn() {ServiceID, Customer, ContactNo, DateRequested, Technician, Address, Status, AddDelete})
        DataGridInstallationDetails.EnableHeadersVisualStyles = False
        DataGridInstallationDetails.GridColor = Color.White
        DataGridInstallationDetails.Location = New Point(8, 68)
        DataGridInstallationDetails.Name = "DataGridInstallationDetails"
        DataGridInstallationDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridInstallationDetails.RowHeadersVisible = False
        DataGridInstallationDetails.RowTemplate.Height = 40
        DataGridInstallationDetails.ScrollBars = ScrollBars.Vertical
        DataGridInstallationDetails.Size = New Size(1578, 503)
        DataGridInstallationDetails.TabIndex = 25
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
        ' ContactNo
        ' 
        ContactNo.HeaderText = "Contact No."
        ContactNo.Name = "ContactNo"
        ContactNo.ReadOnly = True
        ContactNo.Width = 200
        ' 
        ' DateRequested
        ' 
        DateRequested.HeaderText = "Date Requested"
        DateRequested.Name = "DateRequested"
        DateRequested.ReadOnly = True
        DateRequested.Width = 250
        ' 
        ' Technician
        ' 
        Technician.HeaderText = "Technician"
        Technician.Name = "Technician"
        Technician.ReadOnly = True
        Technician.Width = 250
        ' 
        ' Address
        ' 
        Address.HeaderText = "Address"
        Address.Name = "Address"
        Address.ReadOnly = True
        Address.Width = 350
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
        ' PanelRound10
        ' 
        PanelRound10.BackColor = Color.White
        PanelRound10.Controls.Add(DataGridInstallationDetails)
        PanelRound10.Controls.Add(LabelInstallationDetails)
        PanelRound10.CornerRadius = 12
        PanelRound10.Location = New Point(43, 1013)
        PanelRound10.Name = "PanelRound10"
        PanelRound10.Size = New Size(1595, 609)
        PanelRound10.TabIndex = 27
        ' 
        ' PanelRound11
        ' 
        PanelRound11.Location = New Point(43, 1646)
        PanelRound11.Name = "PanelRound11"
        PanelRound11.Size = New Size(1597, 49)
        PanelRound11.TabIndex = 44
        ' 
        ' AdminInstallation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound11)
        Controls.Add(PanelRound10)
        Controls.Add(PanelRound9)
        Controls.Add(PanelRound3)
        Controls.Add(PanelRound2)
        Controls.Add(PanelRound1)
        Controls.Add(PanelFilters)
        Controls.Add(HeaderInstallationReport)
        Controls.Add(PanelRound4)
        Name = "AdminInstallation"
        Size = New Size(1940, 1773)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PanelRound8.ResumeLayout(False)
        PanelRound8.PerformLayout()
        PanelRound7.ResumeLayout(False)
        PanelRound7.PerformLayout()
        PanelRound6.ResumeLayout(False)
        PanelRound6.PerformLayout()
        PanelRound5.ResumeLayout(False)
        PanelRound5.PerformLayout()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        CType(IconTotalInstallations, ComponentModel.ISupportInitialize).EndInit()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        CType(IconPending, ComponentModel.ISupportInitialize).EndInit()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        CType(IconComplete, ComponentModel.ISupportInitialize).EndInit()
        PanelRound9.ResumeLayout(False)
        PanelRound9.PerformLayout()
        CType(IconInProgress, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).EndInit()
        PanelRound10.ResumeLayout(False)
        PanelRound10.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Completed As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PercentComplete As Label
    Friend WithEvents InProgress As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PanelRound8 As PanelRound
    Friend WithEvents PanelRound7 As PanelRound
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelRound6 As PanelRound
    Friend WithEvents PanelRound5 As PanelRound
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents HeaderInstallationReport As Label
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents ComboBoxPlanType As ComboBox
    Friend WithEvents ComboBoxDateRange As ComboBox
    Friend WithEvents LabelPlanType As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents IconTotalInstallations As PictureBox
    Friend WithEvents NumTotalInstallations As Label
    Friend WithEvents LabelTotalInstallations As Label
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents IconPending As PictureBox
    Friend WithEvents NumPending As Label
    Friend WithEvents LabelPending As Label
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents IconComplete As PictureBox
    Friend WithEvents NumCompleted As Label
    Friend WithEvents LabelCompleted As Label
    Friend WithEvents PanelRound9 As PanelRound
    Friend WithEvents IconInProgress As PictureBox
    Friend WithEvents NumInProgress As Label
    Friend WithEvents LabelInProgress As Label
    Friend WithEvents LabelInstallationDetails As Label
    Friend WithEvents DataGridInstallationDetails As DataGridView
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents Customer As DataGridViewTextBoxColumn
    Friend WithEvents ContactNo As DataGridViewTextBoxColumn
    Friend WithEvents DateRequested As DataGridViewTextBoxColumn
    Friend WithEvents Technician As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AddDelete As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound10 As PanelRound
    Friend WithEvents PanelRound11 As PanelRound

End Class

