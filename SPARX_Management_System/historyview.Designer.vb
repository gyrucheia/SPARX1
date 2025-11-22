<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class historyview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(historyview))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderHistoryReport = New Label()
        CustomerFilterPanel = New PanelRound()
        ComboBox2 = New ComboBox()
        CustomerLbl = New Label()
        SelectCustomerLbl = New Label()
        IconFilter = New PictureBox()
        PanelRound1 = New PanelRound()
        NumServicesLbl = New Label()
        ServicesCompletedLbl = New Label()
        PanelRound3 = New PanelRound()
        StatusLbl = New Label()
        AccountStatusLbl = New Label()
        AmountPaidLbl = New Label()
        TotalPaidLbl = New Label()
        PanelRound2 = New PanelRound()
        PlanTypeLbl = New Label()
        CurrentPlanLbl = New Label()
        EmailAddLbl = New Label()
        EmailLbl = New Label()
        NameCustomerLbl = New Label()
        FullNameLbl = New Label()
        NumberLbl = New Label()
        PhoneLbl = New Label()
        IDLbl = New Label()
        CustomerIDLbl = New Label()
        CustomerInfoLbl = New Label()
        PaymentHistoryPanel = New PanelRound()
        PaymentHistoryDVG = New DataGridView()
        DateColumn = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        PaymentMethod = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Reference = New DataGridViewTextBoxColumn()
        EditDelete = New DataGridViewTextBoxColumn()
        PaymentLbl = New Label()
        PaymentHistoryBtn = New ButtonRounded()
        ServiceHistoryBtn = New ButtonRounded()
        TotalPaymentsPanel = New PanelRound()
        BlueDollarIcon = New PictureBox()
        NumPaymentsLbl = New Label()
        TotalPaymentsLbl = New Label()
        ServiceRequestsPanel = New PanelRound()
        PictureBox1 = New PictureBox()
        NumRequestServiceLbl = New Label()
        ServiceRequestsLbl = New Label()
        AccountAgePanel = New PanelRound()
        PictureBox2 = New PictureBox()
        AccAgeLbl = New Label()
        AccountAgeLbl = New Label()
        CustomerFilterPanel.SuspendLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound1.SuspendLayout()
        PanelRound3.SuspendLayout()
        PanelRound2.SuspendLayout()
        PaymentHistoryPanel.SuspendLayout()
        CType(PaymentHistoryDVG, ComponentModel.ISupportInitialize).BeginInit()
        TotalPaymentsPanel.SuspendLayout()
        CType(BlueDollarIcon, ComponentModel.ISupportInitialize).BeginInit()
        ServiceRequestsPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        AccountAgePanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderHistoryReport
        ' 
        HeaderHistoryReport.AutoSize = True
        HeaderHistoryReport.Font = New Font("Segoe UI Semibold", 15.0F, FontStyle.Bold)
        HeaderHistoryReport.Location = New Point(43, 18)
        HeaderHistoryReport.Name = "HeaderHistoryReport"
        HeaderHistoryReport.Size = New Size(267, 28)
        HeaderHistoryReport.TabIndex = 3
        HeaderHistoryReport.Text = "Individual Customer History"
        ' 
        ' CustomerFilterPanel
        ' 
        CustomerFilterPanel.Anchor = AnchorStyles.Top
        CustomerFilterPanel.BackColor = Color.White
        CustomerFilterPanel.Controls.Add(ComboBox2)
        CustomerFilterPanel.Controls.Add(CustomerLbl)
        CustomerFilterPanel.Controls.Add(SelectCustomerLbl)
        CustomerFilterPanel.Controls.Add(IconFilter)
        CustomerFilterPanel.CornerRadius = 12
        CustomerFilterPanel.Location = New Point(38, 58)
        CustomerFilterPanel.Name = "CustomerFilterPanel"
        CustomerFilterPanel.Size = New Size(1594, 227)
        CustomerFilterPanel.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ButtonFace
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 14.0F)
        ComboBox2.ForeColor = SystemColors.WindowText
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(23, 104)
        ComboBox2.MinimumSize = New Size(193, 0)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(469, 33)
        ComboBox2.TabIndex = 6
        ' 
        ' CustomerLbl
        ' 
        CustomerLbl.AutoSize = True
        CustomerLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        CustomerLbl.Location = New Point(23, 80)
        CustomerLbl.Name = "CustomerLbl"
        CustomerLbl.Size = New Size(81, 21)
        CustomerLbl.TabIndex = 4
        CustomerLbl.Text = "Customer"
        CustomerLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' SelectCustomerLbl
        ' 
        SelectCustomerLbl.AutoSize = True
        SelectCustomerLbl.Font = New Font("Verdana", 12.0F)
        SelectCustomerLbl.Location = New Point(51, 23)
        SelectCustomerLbl.Name = "SelectCustomerLbl"
        SelectCustomerLbl.Size = New Size(142, 18)
        SelectCustomerLbl.TabIndex = 1
        SelectCustomerLbl.Text = "Select Customer"
        ' 
        ' IconFilter
        ' 
        IconFilter.Image = CType(resources.GetObject("IconFilter.Image"), Image)
        IconFilter.Location = New Point(22, 19)
        IconFilter.Name = "IconFilter"
        IconFilter.Size = New Size(24, 24)
        IconFilter.SizeMode = PictureBoxSizeMode.Zoom
        IconFilter.TabIndex = 0
        IconFilter.TabStop = False
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(NumServicesLbl)
        PanelRound1.Controls.Add(ServicesCompletedLbl)
        PanelRound1.Controls.Add(PanelRound3)
        PanelRound1.Controls.Add(AccountStatusLbl)
        PanelRound1.Controls.Add(AmountPaidLbl)
        PanelRound1.Controls.Add(TotalPaidLbl)
        PanelRound1.Controls.Add(PanelRound2)
        PanelRound1.Controls.Add(CurrentPlanLbl)
        PanelRound1.Controls.Add(EmailAddLbl)
        PanelRound1.Controls.Add(EmailLbl)
        PanelRound1.Controls.Add(NameCustomerLbl)
        PanelRound1.Controls.Add(FullNameLbl)
        PanelRound1.Controls.Add(NumberLbl)
        PanelRound1.Controls.Add(PhoneLbl)
        PanelRound1.Controls.Add(IDLbl)
        PanelRound1.Controls.Add(CustomerIDLbl)
        PanelRound1.Controls.Add(CustomerInfoLbl)
        PanelRound1.Location = New Point(46, 316)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 264)
        PanelRound1.TabIndex = 5
        ' 
        ' NumServicesLbl
        ' 
        NumServicesLbl.AutoSize = True
        NumServicesLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        NumServicesLbl.ForeColor = Color.Blue
        NumServicesLbl.Location = New Point(1223, 194)
        NumServicesLbl.Name = "NumServicesLbl"
        NumServicesLbl.Size = New Size(19, 21)
        NumServicesLbl.TabIndex = 20
        NumServicesLbl.Text = "2"
        ' 
        ' ServicesCompletedLbl
        ' 
        ServicesCompletedLbl.AutoSize = True
        ServicesCompletedLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        ServicesCompletedLbl.ForeColor = SystemColors.GrayText
        ServicesCompletedLbl.Location = New Point(1222, 163)
        ServicesCompletedLbl.Name = "ServicesCompletedLbl"
        ServicesCompletedLbl.Size = New Size(147, 21)
        ServicesCompletedLbl.TabIndex = 19
        ServicesCompletedLbl.Text = "Services Completed"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.FromArgb(192, 255, 192)
        PanelRound3.Controls.Add(StatusLbl)
        PanelRound3.Location = New Point(1222, 98)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(71, 35)
        PanelRound3.TabIndex = 18
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        StatusLbl.ForeColor = Color.Green
        StatusLbl.Location = New Point(8, 7)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(56, 21)
        StatusLbl.TabIndex = 13
        StatusLbl.Text = "Active"
        ' 
        ' AccountStatusLbl
        ' 
        AccountStatusLbl.AutoSize = True
        AccountStatusLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        AccountStatusLbl.ForeColor = SystemColors.GrayText
        AccountStatusLbl.Location = New Point(1222, 67)
        AccountStatusLbl.Name = "AccountStatusLbl"
        AccountStatusLbl.Size = New Size(116, 21)
        AccountStatusLbl.TabIndex = 17
        AccountStatusLbl.Text = "Account Status "
        ' 
        ' AmountPaidLbl
        ' 
        AmountPaidLbl.AutoSize = True
        AmountPaidLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        AmountPaidLbl.ForeColor = Color.LimeGreen
        AmountPaidLbl.Location = New Point(836, 194)
        AmountPaidLbl.Name = "AmountPaidLbl"
        AmountPaidLbl.Size = New Size(60, 21)
        AmountPaidLbl.TabIndex = 16
        AmountPaidLbl.Text = "?2,800"
        ' 
        ' TotalPaidLbl
        ' 
        TotalPaidLbl.AutoSize = True
        TotalPaidLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TotalPaidLbl.ForeColor = SystemColors.GrayText
        TotalPaidLbl.Location = New Point(835, 163)
        TotalPaidLbl.Name = "TotalPaidLbl"
        TotalPaidLbl.Size = New Size(75, 21)
        TotalPaidLbl.TabIndex = 15
        TotalPaidLbl.Text = "Total Paid"
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = Color.FromArgb(192, 255, 192)
        PanelRound2.Controls.Add(PlanTypeLbl)
        PanelRound2.Location = New Point(835, 98)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(121, 35)
        PanelRound2.TabIndex = 14
        ' 
        ' PlanTypeLbl
        ' 
        PlanTypeLbl.AutoSize = True
        PlanTypeLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        PlanTypeLbl.ForeColor = Color.DarkBlue
        PlanTypeLbl.Location = New Point(5, 7)
        PlanTypeLbl.Name = "PlanTypeLbl"
        PlanTypeLbl.Size = New Size(111, 21)
        PlanTypeLbl.TabIndex = 13
        PlanTypeLbl.Text = "Basic 25Mbps"
        ' 
        ' CurrentPlanLbl
        ' 
        CurrentPlanLbl.AutoSize = True
        CurrentPlanLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        CurrentPlanLbl.ForeColor = SystemColors.GrayText
        CurrentPlanLbl.Location = New Point(835, 67)
        CurrentPlanLbl.Name = "CurrentPlanLbl"
        CurrentPlanLbl.Size = New Size(101, 21)
        CurrentPlanLbl.TabIndex = 12
        CurrentPlanLbl.Text = "Current Plan "
        ' 
        ' EmailAddLbl
        ' 
        EmailAddLbl.AutoSize = True
        EmailAddLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EmailAddLbl.ForeColor = Color.Black
        EmailAddLbl.Location = New Point(412, 194)
        EmailAddLbl.Name = "EmailAddLbl"
        EmailAddLbl.Size = New Size(150, 21)
        EmailAddLbl.TabIndex = 11
        EmailAddLbl.Text = "lyzette@gmail.com"
        ' 
        ' EmailLbl
        ' 
        EmailLbl.AutoSize = True
        EmailLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        EmailLbl.ForeColor = SystemColors.GrayText
        EmailLbl.Location = New Point(411, 163)
        EmailLbl.Name = "EmailLbl"
        EmailLbl.Size = New Size(48, 21)
        EmailLbl.TabIndex = 10
        EmailLbl.Text = "Email"
        ' 
        ' NameCustomerLbl
        ' 
        NameCustomerLbl.AutoSize = True
        NameCustomerLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        NameCustomerLbl.ForeColor = Color.Black
        NameCustomerLbl.Location = New Point(412, 98)
        NameCustomerLbl.Name = "NameCustomerLbl"
        NameCustomerLbl.Size = New Size(119, 21)
        NameCustomerLbl.TabIndex = 9
        NameCustomerLbl.Text = "Lyzette Asutilla"
        ' 
        ' FullNameLbl
        ' 
        FullNameLbl.AutoSize = True
        FullNameLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        FullNameLbl.ForeColor = SystemColors.GrayText
        FullNameLbl.Location = New Point(411, 67)
        FullNameLbl.Name = "FullNameLbl"
        FullNameLbl.Size = New Size(81, 21)
        FullNameLbl.TabIndex = 8
        FullNameLbl.Text = "Full Name"
        ' 
        ' NumberLbl
        ' 
        NumberLbl.AutoSize = True
        NumberLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        NumberLbl.ForeColor = Color.Black
        NumberLbl.Location = New Point(23, 194)
        NumberLbl.Name = "NumberLbl"
        NumberLbl.Size = New Size(105, 21)
        NumberLbl.TabIndex = 7
        NumberLbl.Text = "0912 123 1231"
        ' 
        ' PhoneLbl
        ' 
        PhoneLbl.AutoSize = True
        PhoneLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        PhoneLbl.ForeColor = SystemColors.GrayText
        PhoneLbl.Location = New Point(22, 163)
        PhoneLbl.Name = "PhoneLbl"
        PhoneLbl.Size = New Size(54, 21)
        PhoneLbl.TabIndex = 6
        PhoneLbl.Text = "Phone"
        ' 
        ' IDLbl
        ' 
        IDLbl.AutoSize = True
        IDLbl.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        IDLbl.ForeColor = Color.Black
        IDLbl.Location = New Point(23, 98)
        IDLbl.Name = "IDLbl"
        IDLbl.Size = New Size(51, 21)
        IDLbl.TabIndex = 5
        IDLbl.Text = "IN001"
        ' 
        ' CustomerIDLbl
        ' 
        CustomerIDLbl.AutoSize = True
        CustomerIDLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        CustomerIDLbl.ForeColor = SystemColors.GrayText
        CustomerIDLbl.Location = New Point(22, 67)
        CustomerIDLbl.Name = "CustomerIDLbl"
        CustomerIDLbl.Size = New Size(97, 21)
        CustomerIDLbl.TabIndex = 4
        CustomerIDLbl.Text = "Customer ID"
        ' 
        ' CustomerInfoLbl
        ' 
        CustomerInfoLbl.AutoSize = True
        CustomerInfoLbl.Font = New Font("Verdana", 12.0F)
        CustomerInfoLbl.Location = New Point(22, 20)
        CustomerInfoLbl.Name = "CustomerInfoLbl"
        CustomerInfoLbl.Size = New Size(188, 18)
        CustomerInfoLbl.TabIndex = 2
        CustomerInfoLbl.Text = "Customer Information"
        ' 
        ' PaymentHistoryPanel
        ' 
        PaymentHistoryPanel.BackColor = Color.White
        PaymentHistoryPanel.Controls.Add(PaymentHistoryDVG)
        PaymentHistoryPanel.Controls.Add(PaymentLbl)
        PaymentHistoryPanel.Location = New Point(43, 630)
        PaymentHistoryPanel.Name = "PaymentHistoryPanel"
        PaymentHistoryPanel.Size = New Size(1597, 494)
        PaymentHistoryPanel.TabIndex = 23
        ' 
        ' PaymentHistoryDVG
        ' 
        PaymentHistoryDVG.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        PaymentHistoryDVG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        PaymentHistoryDVG.BackgroundColor = Color.White
        PaymentHistoryDVG.BorderStyle = BorderStyle.None
        PaymentHistoryDVG.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        PaymentHistoryDVG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 10.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        PaymentHistoryDVG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        PaymentHistoryDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PaymentHistoryDVG.Columns.AddRange(New DataGridViewColumn() {DateColumn, Amount, PaymentMethod, Status, Reference, EditDelete})
        PaymentHistoryDVG.GridColor = Color.Silver
        PaymentHistoryDVG.Location = New Point(51, 61)
        PaymentHistoryDVG.Name = "PaymentHistoryDVG"
        PaymentHistoryDVG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        PaymentHistoryDVG.RowHeadersVisible = False
        PaymentHistoryDVG.RowTemplate.Height = 40
        PaymentHistoryDVG.ScrollBars = ScrollBars.Vertical
        PaymentHistoryDVG.Size = New Size(1334, 393)
        PaymentHistoryDVG.TabIndex = 24
        ' 
        ' DateColumn
        ' 
        DateColumn.Frozen = True
        DateColumn.HeaderText = "Date "
        DateColumn.Name = "DateColumn"
        DateColumn.ReadOnly = True
        DateColumn.Width = 250
        ' 
        ' Amount
        ' 
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(0, 192, 0)
        Amount.DefaultCellStyle = DataGridViewCellStyle3
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        Amount.ReadOnly = True
        Amount.Width = 230
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.HeaderText = "Payment Method"
        PaymentMethod.Name = "PaymentMethod"
        PaymentMethod.ReadOnly = True
        PaymentMethod.Width = 350
        ' 
        ' Status
        ' 
        DataGridViewCellStyle4.ForeColor = Color.DarkGreen
        Status.DefaultCellStyle = DataGridViewCellStyle4
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 200
        ' 
        ' Reference
        ' 
        Reference.HeaderText = "Reference"
        Reference.Name = "Reference"
        Reference.ReadOnly = True
        Reference.Width = 250
        ' 
        ' EditDelete
        ' 
        EditDelete.HeaderText = ""
        EditDelete.Name = "EditDelete"
        EditDelete.ReadOnly = True
        EditDelete.Width = 50
        ' 
        ' PaymentLbl
        ' 
        PaymentLbl.AutoSize = True
        PaymentLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        PaymentLbl.ForeColor = Color.Black
        PaymentLbl.Location = New Point(22, 23)
        PaymentLbl.Name = "PaymentLbl"
        PaymentLbl.Size = New Size(124, 21)
        PaymentLbl.TabIndex = 9
        PaymentLbl.Text = "Payment History"
        ' 
        ' PaymentHistoryBtn
        ' 
        PaymentHistoryBtn.BackColor = SystemColors.Control
        PaymentHistoryBtn.FlatAppearance.BorderSize = 0
        PaymentHistoryBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control
        PaymentHistoryBtn.FlatAppearance.MouseOverBackColor = Color.White
        PaymentHistoryBtn.FlatStyle = FlatStyle.Flat
        PaymentHistoryBtn.ForeColor = Color.Black
        PaymentHistoryBtn.ImageAlign = ContentAlignment.BottomLeft
        PaymentHistoryBtn.Location = New Point(43, 586)
        PaymentHistoryBtn.Name = "PaymentHistoryBtn"
        PaymentHistoryBtn.Size = New Size(798, 38)
        PaymentHistoryBtn.TabIndex = 24
        PaymentHistoryBtn.Text = "Payment History"
        PaymentHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' ServiceHistoryBtn
        ' 
        ServiceHistoryBtn.BackColor = SystemColors.Control
        ServiceHistoryBtn.FlatAppearance.BorderSize = 0
        ServiceHistoryBtn.FlatAppearance.MouseDownBackColor = SystemColors.Control
        ServiceHistoryBtn.FlatAppearance.MouseOverBackColor = Color.White
        ServiceHistoryBtn.FlatStyle = FlatStyle.Flat
        ServiceHistoryBtn.ForeColor = Color.Black
        ServiceHistoryBtn.Location = New Point(847, 586)
        ServiceHistoryBtn.Name = "ServiceHistoryBtn"
        ServiceHistoryBtn.Size = New Size(793, 38)
        ServiceHistoryBtn.TabIndex = 25
        ServiceHistoryBtn.Text = "Service History"
        ServiceHistoryBtn.UseVisualStyleBackColor = False
        ' 
        ' TotalPaymentsPanel
        ' 
        TotalPaymentsPanel.BackColor = Color.White
        TotalPaymentsPanel.Controls.Add(BlueDollarIcon)
        TotalPaymentsPanel.Controls.Add(NumPaymentsLbl)
        TotalPaymentsPanel.Controls.Add(TotalPaymentsLbl)
        TotalPaymentsPanel.CornerRadius = 12
        TotalPaymentsPanel.Location = New Point(43, 1160)
        TotalPaymentsPanel.Name = "TotalPaymentsPanel"
        TotalPaymentsPanel.Size = New Size(466, 125)
        TotalPaymentsPanel.TabIndex = 26
        ' 
        ' BlueDollarIcon
        ' 
        BlueDollarIcon.Image = CType(resources.GetObject("BlueDollarIcon.Image"), Image)
        BlueDollarIcon.Location = New Point(385, 55)
        BlueDollarIcon.Name = "BlueDollarIcon"
        BlueDollarIcon.Size = New Size(48, 50)
        BlueDollarIcon.SizeMode = PictureBoxSizeMode.Zoom
        BlueDollarIcon.TabIndex = 9
        BlueDollarIcon.TabStop = False
        ' 
        ' NumPaymentsLbl
        ' 
        NumPaymentsLbl.AutoSize = True
        NumPaymentsLbl.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumPaymentsLbl.ForeColor = Color.LimeGreen
        NumPaymentsLbl.Location = New Point(24, 55)
        NumPaymentsLbl.Name = "NumPaymentsLbl"
        NumPaymentsLbl.Size = New Size(25, 30)
        NumPaymentsLbl.TabIndex = 8
        NumPaymentsLbl.Text = "0"
        ' 
        ' TotalPaymentsLbl
        ' 
        TotalPaymentsLbl.AutoSize = True
        TotalPaymentsLbl.Font = New Font("Verdana", 12.0F)
        TotalPaymentsLbl.ForeColor = SystemColors.ControlDarkDark
        TotalPaymentsLbl.Location = New Point(24, 25)
        TotalPaymentsLbl.Name = "TotalPaymentsLbl"
        TotalPaymentsLbl.Size = New Size(134, 18)
        TotalPaymentsLbl.TabIndex = 8
        TotalPaymentsLbl.Text = "Total Payments"
        ' 
        ' ServiceRequestsPanel
        ' 
        ServiceRequestsPanel.BackColor = Color.White
        ServiceRequestsPanel.Controls.Add(PictureBox1)
        ServiceRequestsPanel.Controls.Add(NumRequestServiceLbl)
        ServiceRequestsPanel.Controls.Add(ServiceRequestsLbl)
        ServiceRequestsPanel.CornerRadius = 12
        ServiceRequestsPanel.Location = New Point(606, 1160)
        ServiceRequestsPanel.Name = "ServiceRequestsPanel"
        ServiceRequestsPanel.Size = New Size(466, 125)
        ServiceRequestsPanel.TabIndex = 27
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(385, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' NumRequestServiceLbl
        ' 
        NumRequestServiceLbl.AutoSize = True
        NumRequestServiceLbl.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        NumRequestServiceLbl.ForeColor = Color.Blue
        NumRequestServiceLbl.Location = New Point(24, 55)
        NumRequestServiceLbl.Name = "NumRequestServiceLbl"
        NumRequestServiceLbl.Size = New Size(25, 30)
        NumRequestServiceLbl.TabIndex = 8
        NumRequestServiceLbl.Text = "0"
        ' 
        ' ServiceRequestsLbl
        ' 
        ServiceRequestsLbl.AutoSize = True
        ServiceRequestsLbl.Font = New Font("Verdana", 12.0F)
        ServiceRequestsLbl.ForeColor = SystemColors.ControlDarkDark
        ServiceRequestsLbl.Location = New Point(24, 25)
        ServiceRequestsLbl.Name = "ServiceRequestsLbl"
        ServiceRequestsLbl.Size = New Size(148, 18)
        ServiceRequestsLbl.TabIndex = 8
        ServiceRequestsLbl.Text = "Service Requests"
        ' 
        ' AccountAgePanel
        ' 
        AccountAgePanel.BackColor = Color.White
        AccountAgePanel.Controls.Add(PictureBox2)
        AccountAgePanel.Controls.Add(AccAgeLbl)
        AccountAgePanel.Controls.Add(AccountAgeLbl)
        AccountAgePanel.CornerRadius = 12
        AccountAgePanel.Location = New Point(1174, 1160)
        AccountAgePanel.Name = "AccountAgePanel"
        AccountAgePanel.Size = New Size(466, 125)
        AccountAgePanel.TabIndex = 27
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(385, 55)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' AccAgeLbl
        ' 
        AccAgeLbl.AutoSize = True
        AccAgeLbl.Font = New Font("Segoe UI Semibold", 16.0F, FontStyle.Bold)
        AccAgeLbl.ForeColor = Color.OrangeRed
        AccAgeLbl.Location = New Point(24, 55)
        AccAgeLbl.Name = "AccAgeLbl"
        AccAgeLbl.Size = New Size(116, 30)
        AccAgeLbl.TabIndex = 8
        AccAgeLbl.Text = "10 Months"
        ' 
        ' AccountAgeLbl
        ' 
        AccountAgeLbl.AutoSize = True
        AccountAgeLbl.Font = New Font("Verdana", 12.0F)
        AccountAgeLbl.ForeColor = SystemColors.ControlDarkDark
        AccountAgeLbl.Location = New Point(24, 25)
        AccountAgeLbl.Name = "AccountAgeLbl"
        AccountAgeLbl.Size = New Size(109, 18)
        AccountAgeLbl.TabIndex = 8
        AccountAgeLbl.Text = "Account Age"
        ' 
        ' historyview
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = SystemColors.Control
        Controls.Add(AccountAgePanel)
        Controls.Add(ServiceRequestsPanel)
        Controls.Add(TotalPaymentsPanel)
        Controls.Add(ServiceHistoryBtn)
        Controls.Add(PaymentHistoryBtn)
        Controls.Add(PaymentHistoryPanel)
        Controls.Add(PanelRound1)
        Controls.Add(CustomerFilterPanel)
        Controls.Add(HeaderHistoryReport)
        Name = "historyview"
        Size = New Size(1662, 1288)
        CustomerFilterPanel.ResumeLayout(False)
        CustomerFilterPanel.PerformLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).EndInit()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        PaymentHistoryPanel.ResumeLayout(False)
        PaymentHistoryPanel.PerformLayout()
        CType(PaymentHistoryDVG, ComponentModel.ISupportInitialize).EndInit()
        TotalPaymentsPanel.ResumeLayout(False)
        TotalPaymentsPanel.PerformLayout()
        CType(BlueDollarIcon, ComponentModel.ISupportInitialize).EndInit()
        ServiceRequestsPanel.ResumeLayout(False)
        ServiceRequestsPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        AccountAgePanel.ResumeLayout(False)
        AccountAgePanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderHistoryReport As Label
    Friend WithEvents CustomerFilterPanel As PanelRound
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents CustomerLbl As Label
    Friend WithEvents SelectCustomerLbl As Label
    Friend WithEvents IconFilter As PictureBox
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents CustomerInfoLbl As Label
    Friend WithEvents IDLbl As Label
    Friend WithEvents CustomerIDLbl As Label
    Friend WithEvents PlanTypeLbl As Label
    Friend WithEvents CurrentPlanLbl As Label
    Friend WithEvents EmailAddLbl As Label
    Friend WithEvents EmailLbl As Label
    Friend WithEvents NameCustomerLbl As Label
    Friend WithEvents FullNameLbl As Label
    Friend WithEvents NumberLbl As Label
    Friend WithEvents PhoneLbl As Label
    Friend WithEvents AmountPaidLbl As Label
    Friend WithEvents TotalPaidLbl As Label
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents StatusLbl As Label
    Friend WithEvents AccountStatusLbl As Label
    Friend WithEvents NumServicesLbl As Label
    Friend WithEvents ServicesCompletedLbl As Label
    Friend WithEvents PaymentHistoryPanel As PanelRound
    Friend WithEvents PaymentHistoryDVG As DataGridView
    Friend WithEvents PaymentLbl As Label
    Friend WithEvents PaymentHistoryBtn As ButtonRounded
    Friend WithEvents ServiceHistoryBtn As ButtonRounded
    Friend WithEvents TotalPaymentsPanel As PanelRound
    Friend WithEvents BlueDollarIcon As PictureBox
    Friend WithEvents NumPaymentsLbl As Label
    Friend WithEvents TotalPaymentsLbl As Label
    Friend WithEvents ServiceRequestsPanel As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NumRequestServiceLbl As Label
    Friend WithEvents ServiceRequestsLbl As Label
    Friend WithEvents AccountAgePanel As PanelRound
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AccAgeLbl As Label
    Friend WithEvents AccountAgeLbl As Label
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Reference As DataGridViewTextBoxColumn
    Friend WithEvents EditDelete As DataGridViewTextBoxColumn

End Class

