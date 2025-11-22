<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billingview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billingview))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderBillingReport = New Label()
        InventoryFilterPanel = New PanelRound()
        ItemSearchTxtBox = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        DateRangeLbl = New Label()
        PaymentStatusLbl = New Label()
        CustomerNameLbl = New Label()
        LabelFilters = New Label()
        IconFilter = New PictureBox()
        TotalExpectedPanel = New PanelRound()
        BlueDollarIcon = New PictureBox()
        AmountExpectedLbl = New Label()
        TotalExpectedLbl = New Label()
        TotalReceivedPanel = New PanelRound()
        PictureBox1 = New PictureBox()
        AmoundReceivedLbl = New Label()
        TotalReceivedLbl = New Label()
        OutstandingPanel = New PanelRound()
        PictureBox2 = New PictureBox()
        AmountOutstandingLbl = New Label()
        OutsandingLbl = New Label()
        PaidBillsPanel = New PanelRound()
        PictureBox3 = New PictureBox()
        NumPaidLbl = New Label()
        PaidBillsLbl = New Label()
        UnpaidBillsPanel = New PanelRound()
        PictureBox4 = New PictureBox()
        NumUnpaidLbl = New Label()
        UnpaidBillsLbl = New Label()
        PaymentsummaryPanel = New PanelRound()
        DefaultRatePanel = New PanelRound()
        DefaultRateLbl = New Label()
        DefaultPercentLbl = New Label()
        CollectionRatePanel = New PanelRound()
        CollectionRateLbl = New Label()
        CollectionPercentLbl = New Label()
        PaymentSummaryLbl = New Label()
        RedPanel = New PanelRound()
        OustandingPanel = New PanelRound()
        PanelRound1 = New PanelRound()
        PanelRound2 = New PanelRound()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        OverduePanel = New PanelRound()
        PanelRound9 = New PanelRound()
        StatusLbl = New Label()
        PlanAmountLbl = New Label()
        NameOfCustomerLbl = New Label()
        PaymentAlertsLbl = New Label()
        PictureBox5 = New PictureBox()
        BillingDetailsPanel = New PanelRound()
        BillingDetailsDGV = New DataGridView()
        PaymentID = New DataGridViewTextBoxColumn()
        CustomerName = New DataGridViewTextBoxColumn()
        PlanType = New DataGridViewTextBoxColumn()
        MonthlyRate = New DataGridViewTextBoxColumn()
        AmountPaid = New DataGridViewTextBoxColumn()
        PaymentDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        ModeOfPayment = New DataGridViewTextBoxColumn()
        EditDelete = New DataGridViewTextBoxColumn()
        BillingDetailsLbl = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        InventoryFilterPanel.SuspendLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).BeginInit()
        TotalExpectedPanel.SuspendLayout()
        CType(BlueDollarIcon, ComponentModel.ISupportInitialize).BeginInit()
        TotalReceivedPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        OutstandingPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PaidBillsPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        UnpaidBillsPanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PaymentsummaryPanel.SuspendLayout()
        DefaultRatePanel.SuspendLayout()
        CollectionRatePanel.SuspendLayout()
        RedPanel.SuspendLayout()
        OustandingPanel.SuspendLayout()
        PanelRound1.SuspendLayout()
        PanelRound2.SuspendLayout()
        OverduePanel.SuspendLayout()
        PanelRound9.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        BillingDetailsPanel.SuspendLayout()
        CType(BillingDetailsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderBillingReport
        ' 
        HeaderBillingReport.AutoSize = True
        HeaderBillingReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderBillingReport.Location = New Point(43, 18)
        HeaderBillingReport.Name = "HeaderBillingReport"
        HeaderBillingReport.Size = New Size(135, 28)
        HeaderBillingReport.TabIndex = 2
        HeaderBillingReport.Text = "Billing Report"
        ' 
        ' InventoryFilterPanel
        ' 
        InventoryFilterPanel.Anchor = AnchorStyles.Top
        InventoryFilterPanel.BackColor = Color.White
        InventoryFilterPanel.Controls.Add(ItemSearchTxtBox)
        InventoryFilterPanel.Controls.Add(ComboBox2)
        InventoryFilterPanel.Controls.Add(ComboBox1)
        InventoryFilterPanel.Controls.Add(DateRangeLbl)
        InventoryFilterPanel.Controls.Add(PaymentStatusLbl)
        InventoryFilterPanel.Controls.Add(CustomerNameLbl)
        InventoryFilterPanel.Controls.Add(LabelFilters)
        InventoryFilterPanel.Controls.Add(IconFilter)
        InventoryFilterPanel.CornerRadius = 12
        InventoryFilterPanel.Location = New Point(43, 78)
        InventoryFilterPanel.Name = "InventoryFilterPanel"
        InventoryFilterPanel.Size = New Size(1597, 165)
        InventoryFilterPanel.TabIndex = 3
        ' 
        ' ItemSearchTxtBox
        ' 
        ItemSearchTxtBox.BackColor = SystemColors.ButtonFace
        ItemSearchTxtBox.Font = New Font("Segoe UI", 12F)
        ItemSearchTxtBox.Location = New Point(697, 108)
        ItemSearchTxtBox.Name = "ItemSearchTxtBox"
        ItemSearchTxtBox.Size = New Size(265, 29)
        ItemSearchTxtBox.TabIndex = 7
        ItemSearchTxtBox.Text = "Search by name..."
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ButtonFace
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 14F)
        ComboBox2.ForeColor = SystemColors.WindowText
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(23, 104)
        ComboBox2.MinimumSize = New Size(193, 0)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(265, 33)
        ComboBox2.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ButtonFace
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI", 14F)
        ComboBox1.ForeColor = SystemColors.WindowText
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Paid", "Unpaid"})
        ComboBox1.Location = New Point(364, 104)
        ComboBox1.MinimumSize = New Size(193, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(265, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' DateRangeLbl
        ' 
        DateRangeLbl.AutoSize = True
        DateRangeLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        DateRangeLbl.Location = New Point(23, 80)
        DateRangeLbl.Name = "DateRangeLbl"
        DateRangeLbl.Size = New Size(94, 21)
        DateRangeLbl.TabIndex = 4
        DateRangeLbl.Text = "Date Range"
        ' 
        ' PaymentStatusLbl
        ' 
        PaymentStatusLbl.AutoSize = True
        PaymentStatusLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PaymentStatusLbl.Location = New Point(364, 80)
        PaymentStatusLbl.Name = "PaymentStatusLbl"
        PaymentStatusLbl.Size = New Size(122, 21)
        PaymentStatusLbl.TabIndex = 3
        PaymentStatusLbl.Text = "Payment Status"
        ' 
        ' CustomerNameLbl
        ' 
        CustomerNameLbl.AutoSize = True
        CustomerNameLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CustomerNameLbl.Location = New Point(697, 84)
        CustomerNameLbl.Name = "CustomerNameLbl"
        CustomerNameLbl.Size = New Size(128, 21)
        CustomerNameLbl.TabIndex = 2
        CustomerNameLbl.Text = "Customer Name"
        ' 
        ' LabelFilters
        ' 
        LabelFilters.AutoSize = True
        LabelFilters.Font = New Font("Verdana", 12F)
        LabelFilters.Location = New Point(51, 23)
        LabelFilters.Name = "LabelFilters"
        LabelFilters.Size = New Size(59, 18)
        LabelFilters.TabIndex = 1
        LabelFilters.Text = "Filters"
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
        ' TotalExpectedPanel
        ' 
        TotalExpectedPanel.BackColor = Color.White
        TotalExpectedPanel.Controls.Add(BlueDollarIcon)
        TotalExpectedPanel.Controls.Add(AmountExpectedLbl)
        TotalExpectedPanel.Controls.Add(TotalExpectedLbl)
        TotalExpectedPanel.CornerRadius = 12
        TotalExpectedPanel.Location = New Point(43, 266)
        TotalExpectedPanel.Name = "TotalExpectedPanel"
        TotalExpectedPanel.Size = New Size(254, 125)
        TotalExpectedPanel.TabIndex = 15
        ' 
        ' BlueDollarIcon
        ' 
        BlueDollarIcon.Image = CType(resources.GetObject("BlueDollarIcon.Image"), Image)
        BlueDollarIcon.Location = New Point(165, 50)
        BlueDollarIcon.Name = "BlueDollarIcon"
        BlueDollarIcon.Size = New Size(48, 50)
        BlueDollarIcon.SizeMode = PictureBoxSizeMode.Zoom
        BlueDollarIcon.TabIndex = 9
        BlueDollarIcon.TabStop = False
        ' 
        ' AmountExpectedLbl
        ' 
        AmountExpectedLbl.AutoSize = True
        AmountExpectedLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        AmountExpectedLbl.ForeColor = Color.Blue
        AmountExpectedLbl.Location = New Point(24, 55)
        AmountExpectedLbl.Name = "AmountExpectedLbl"
        AmountExpectedLbl.Size = New Size(49, 30)
        AmountExpectedLbl.TabIndex = 8
        AmountExpectedLbl.Text = "000"
        ' 
        ' TotalExpectedLbl
        ' 
        TotalExpectedLbl.AutoSize = True
        TotalExpectedLbl.Font = New Font("Verdana", 12F)
        TotalExpectedLbl.ForeColor = SystemColors.ControlDarkDark
        TotalExpectedLbl.Location = New Point(24, 25)
        TotalExpectedLbl.Name = "TotalExpectedLbl"
        TotalExpectedLbl.Size = New Size(128, 18)
        TotalExpectedLbl.TabIndex = 8
        TotalExpectedLbl.Text = "Total Expected"
        ' 
        ' TotalReceivedPanel
        ' 
        TotalReceivedPanel.BackColor = Color.White
        TotalReceivedPanel.Controls.Add(PictureBox1)
        TotalReceivedPanel.Controls.Add(AmoundReceivedLbl)
        TotalReceivedPanel.Controls.Add(TotalReceivedLbl)
        TotalReceivedPanel.CornerRadius = 12
        TotalReceivedPanel.Location = New Point(374, 266)
        TotalReceivedPanel.Name = "TotalReceivedPanel"
        TotalReceivedPanel.Size = New Size(254, 125)
        TotalReceivedPanel.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(139, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' AmoundReceivedLbl
        ' 
        AmoundReceivedLbl.AutoSize = True
        AmoundReceivedLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        AmoundReceivedLbl.ForeColor = Color.LimeGreen
        AmoundReceivedLbl.Location = New Point(24, 55)
        AmoundReceivedLbl.Name = "AmoundReceivedLbl"
        AmoundReceivedLbl.Size = New Size(49, 30)
        AmoundReceivedLbl.TabIndex = 8
        AmoundReceivedLbl.Text = "000"
        ' 
        ' TotalReceivedLbl
        ' 
        TotalReceivedLbl.AutoSize = True
        TotalReceivedLbl.Font = New Font("Verdana", 12F)
        TotalReceivedLbl.ForeColor = SystemColors.ControlDarkDark
        TotalReceivedLbl.Location = New Point(24, 25)
        TotalReceivedLbl.Name = "TotalReceivedLbl"
        TotalReceivedLbl.Size = New Size(127, 18)
        TotalReceivedLbl.TabIndex = 8
        TotalReceivedLbl.Text = "Total Received"
        ' 
        ' OutstandingPanel
        ' 
        OutstandingPanel.BackColor = Color.White
        OutstandingPanel.Controls.Add(PictureBox2)
        OutstandingPanel.Controls.Add(AmountOutstandingLbl)
        OutstandingPanel.Controls.Add(OutsandingLbl)
        OutstandingPanel.CornerRadius = 12
        OutstandingPanel.Location = New Point(710, 266)
        OutstandingPanel.Name = "OutstandingPanel"
        OutstandingPanel.Size = New Size(254, 125)
        OutstandingPanel.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(139, 50)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' AmountOutstandingLbl
        ' 
        AmountOutstandingLbl.AutoSize = True
        AmountOutstandingLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        AmountOutstandingLbl.ForeColor = Color.Red
        AmountOutstandingLbl.Location = New Point(24, 55)
        AmountOutstandingLbl.Name = "AmountOutstandingLbl"
        AmountOutstandingLbl.Size = New Size(49, 30)
        AmountOutstandingLbl.TabIndex = 8
        AmountOutstandingLbl.Text = "000"
        ' 
        ' OutsandingLbl
        ' 
        OutsandingLbl.AutoSize = True
        OutsandingLbl.Font = New Font("Verdana", 12F)
        OutsandingLbl.ForeColor = SystemColors.ControlDarkDark
        OutsandingLbl.Location = New Point(24, 25)
        OutsandingLbl.Name = "OutsandingLbl"
        OutsandingLbl.Size = New Size(115, 18)
        OutsandingLbl.TabIndex = 8
        OutsandingLbl.Text = "Outstanding "
        ' 
        ' PaidBillsPanel
        ' 
        PaidBillsPanel.BackColor = Color.White
        PaidBillsPanel.Controls.Add(PictureBox3)
        PaidBillsPanel.Controls.Add(NumPaidLbl)
        PaidBillsPanel.Controls.Add(PaidBillsLbl)
        PaidBillsPanel.CornerRadius = 12
        PaidBillsPanel.Location = New Point(1050, 266)
        PaidBillsPanel.Name = "PaidBillsPanel"
        PaidBillsPanel.Size = New Size(254, 125)
        PaidBillsPanel.TabIndex = 18
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(139, 50)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' NumPaidLbl
        ' 
        NumPaidLbl.AutoSize = True
        NumPaidLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumPaidLbl.ForeColor = Color.LimeGreen
        NumPaidLbl.Location = New Point(24, 55)
        NumPaidLbl.Name = "NumPaidLbl"
        NumPaidLbl.Size = New Size(25, 30)
        NumPaidLbl.TabIndex = 8
        NumPaidLbl.Text = "0"
        ' 
        ' PaidBillsLbl
        ' 
        PaidBillsLbl.AutoSize = True
        PaidBillsLbl.Font = New Font("Verdana", 12F)
        PaidBillsLbl.ForeColor = SystemColors.ControlDarkDark
        PaidBillsLbl.Location = New Point(24, 25)
        PaidBillsLbl.Name = "PaidBillsLbl"
        PaidBillsLbl.Size = New Size(84, 18)
        PaidBillsLbl.TabIndex = 8
        PaidBillsLbl.Text = "Paid Bills"
        ' 
        ' UnpaidBillsPanel
        ' 
        UnpaidBillsPanel.BackColor = Color.White
        UnpaidBillsPanel.Controls.Add(PictureBox4)
        UnpaidBillsPanel.Controls.Add(NumUnpaidLbl)
        UnpaidBillsPanel.Controls.Add(UnpaidBillsLbl)
        UnpaidBillsPanel.CornerRadius = 12
        UnpaidBillsPanel.Location = New Point(1386, 266)
        UnpaidBillsPanel.Name = "UnpaidBillsPanel"
        UnpaidBillsPanel.Size = New Size(254, 125)
        UnpaidBillsPanel.TabIndex = 19
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(139, 50)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(48, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' NumUnpaidLbl
        ' 
        NumUnpaidLbl.AutoSize = True
        NumUnpaidLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumUnpaidLbl.ForeColor = Color.Red
        NumUnpaidLbl.Location = New Point(24, 55)
        NumUnpaidLbl.Name = "NumUnpaidLbl"
        NumUnpaidLbl.Size = New Size(25, 30)
        NumUnpaidLbl.TabIndex = 8
        NumUnpaidLbl.Text = "0"
        ' 
        ' UnpaidBillsLbl
        ' 
        UnpaidBillsLbl.AutoSize = True
        UnpaidBillsLbl.Font = New Font("Verdana", 12F)
        UnpaidBillsLbl.ForeColor = SystemColors.ControlDarkDark
        UnpaidBillsLbl.Location = New Point(24, 25)
        UnpaidBillsLbl.Name = "UnpaidBillsLbl"
        UnpaidBillsLbl.Size = New Size(106, 18)
        UnpaidBillsLbl.TabIndex = 8
        UnpaidBillsLbl.Text = "Unpaid Bills"
        ' 
        ' PaymentsummaryPanel
        ' 
        PaymentsummaryPanel.BackColor = Color.White
        PaymentsummaryPanel.Controls.Add(DefaultRatePanel)
        PaymentsummaryPanel.Controls.Add(CollectionRatePanel)
        PaymentsummaryPanel.Controls.Add(PaymentSummaryLbl)
        PaymentsummaryPanel.Location = New Point(43, 421)
        PaymentsummaryPanel.Name = "PaymentsummaryPanel"
        PaymentsummaryPanel.Size = New Size(1597, 219)
        PaymentsummaryPanel.TabIndex = 20
        ' 
        ' DefaultRatePanel
        ' 
        DefaultRatePanel.BackColor = Color.FromArgb(CByte(255), CByte(216), CByte(216))
        DefaultRatePanel.Controls.Add(DefaultRateLbl)
        DefaultRatePanel.Controls.Add(DefaultPercentLbl)
        DefaultRatePanel.ImeMode = ImeMode.NoControl
        DefaultRatePanel.Location = New Point(840, 59)
        DefaultRatePanel.Name = "DefaultRatePanel"
        DefaultRatePanel.Size = New Size(521, 145)
        DefaultRatePanel.TabIndex = 12
        ' 
        ' DefaultRateLbl
        ' 
        DefaultRateLbl.AutoSize = True
        DefaultRateLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DefaultRateLbl.ForeColor = Color.Red
        DefaultRateLbl.Location = New Point(219, 36)
        DefaultRateLbl.Name = "DefaultRateLbl"
        DefaultRateLbl.Size = New Size(95, 21)
        DefaultRateLbl.TabIndex = 12
        DefaultRateLbl.Text = "Default Rate"
        ' 
        ' DefaultPercentLbl
        ' 
        DefaultPercentLbl.AutoSize = True
        DefaultPercentLbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DefaultPercentLbl.ForeColor = Color.Red
        DefaultPercentLbl.Location = New Point(224, 63)
        DefaultPercentLbl.Name = "DefaultPercentLbl"
        DefaultPercentLbl.Size = New Size(93, 45)
        DefaultPercentLbl.TabIndex = 11
        DefaultPercentLbl.Text = "0.0%"
        ' 
        ' CollectionRatePanel
        ' 
        CollectionRatePanel.BackColor = Color.Ivory
        CollectionRatePanel.Controls.Add(CollectionRateLbl)
        CollectionRatePanel.Controls.Add(CollectionPercentLbl)
        CollectionRatePanel.ImeMode = ImeMode.NoControl
        CollectionRatePanel.Location = New Point(249, 59)
        CollectionRatePanel.Name = "CollectionRatePanel"
        CollectionRatePanel.Size = New Size(521, 145)
        CollectionRatePanel.TabIndex = 11
        ' 
        ' CollectionRateLbl
        ' 
        CollectionRateLbl.AutoSize = True
        CollectionRateLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CollectionRateLbl.ForeColor = Color.Green
        CollectionRateLbl.Location = New Point(196, 36)
        CollectionRateLbl.Name = "CollectionRateLbl"
        CollectionRateLbl.Size = New Size(114, 21)
        CollectionRateLbl.TabIndex = 10
        CollectionRateLbl.Text = "Collection Rate"
        ' 
        ' CollectionPercentLbl
        ' 
        CollectionPercentLbl.AutoSize = True
        CollectionPercentLbl.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CollectionPercentLbl.ForeColor = Color.Green
        CollectionPercentLbl.Location = New Point(210, 63)
        CollectionPercentLbl.Name = "CollectionPercentLbl"
        CollectionPercentLbl.Size = New Size(93, 45)
        CollectionPercentLbl.TabIndex = 9
        CollectionPercentLbl.Text = "0.0%"
        ' 
        ' PaymentSummaryLbl
        ' 
        PaymentSummaryLbl.AutoSize = True
        PaymentSummaryLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentSummaryLbl.ForeColor = Color.Black
        PaymentSummaryLbl.Location = New Point(22, 15)
        PaymentSummaryLbl.Name = "PaymentSummaryLbl"
        PaymentSummaryLbl.Size = New Size(215, 21)
        PaymentSummaryLbl.TabIndex = 10
        PaymentSummaryLbl.Text = "Payment Collection Summary"
        ' 
        ' RedPanel
        ' 
        RedPanel.BackColor = Color.Red
        RedPanel.Controls.Add(OustandingPanel)
        RedPanel.Location = New Point(43, 661)
        RedPanel.Name = "RedPanel"
        RedPanel.Size = New Size(1597, 265)
        RedPanel.TabIndex = 21
        ' 
        ' OustandingPanel
        ' 
        OustandingPanel.BackColor = Color.White
        OustandingPanel.Controls.Add(PanelRound1)
        OustandingPanel.Controls.Add(OverduePanel)
        OustandingPanel.Controls.Add(PaymentAlertsLbl)
        OustandingPanel.Controls.Add(PictureBox5)
        OustandingPanel.Location = New Point(13, 0)
        OustandingPanel.Name = "OustandingPanel"
        OustandingPanel.Size = New Size(1584, 265)
        OustandingPanel.TabIndex = 11
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        PanelRound1.Controls.Add(PanelRound2)
        PanelRound1.Controls.Add(Label2)
        PanelRound1.Controls.Add(Label3)
        PanelRound1.Location = New Point(33, 166)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1515, 67)
        PanelRound1.TabIndex = 13
        ' 
        ' PanelRound2
        ' 
        PanelRound2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelRound2.BackColor = Color.FromArgb(CByte(255), CByte(226), CByte(226))
        PanelRound2.Controls.Add(Label1)
        PanelRound2.Location = New Point(1397, 18)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(102, 35)
        PanelRound2.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label1.Location = New Point(20, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 17)
        Label1.TabIndex = 15
        Label1.Text = "Overdue"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 15)
        Label2.TabIndex = 13
        Label2.Text = "Standard 50Mbps - Due:  ?1,000"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(12, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 21)
        Label3.TabIndex = 12
        Label3.Text = "Jammy Buendia"
        ' 
        ' OverduePanel
        ' 
        OverduePanel.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        OverduePanel.Controls.Add(PanelRound9)
        OverduePanel.Controls.Add(PlanAmountLbl)
        OverduePanel.Controls.Add(NameOfCustomerLbl)
        OverduePanel.Location = New Point(32, 71)
        OverduePanel.Name = "OverduePanel"
        OverduePanel.Size = New Size(1515, 67)
        OverduePanel.TabIndex = 12
        ' 
        ' PanelRound9
        ' 
        PanelRound9.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelRound9.BackColor = Color.FromArgb(CByte(255), CByte(226), CByte(226))
        PanelRound9.Controls.Add(StatusLbl)
        PanelRound9.Location = New Point(1397, 18)
        PanelRound9.Name = "PanelRound9"
        PanelRound9.Size = New Size(102, 35)
        PanelRound9.TabIndex = 14
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        StatusLbl.Location = New Point(20, 9)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(60, 17)
        StatusLbl.TabIndex = 15
        StatusLbl.Text = "Overdue"
        ' 
        ' PlanAmountLbl
        ' 
        PlanAmountLbl.AutoSize = True
        PlanAmountLbl.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PlanAmountLbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        PlanAmountLbl.Location = New Point(12, 38)
        PlanAmountLbl.Name = "PlanAmountLbl"
        PlanAmountLbl.Size = New Size(180, 15)
        PlanAmountLbl.TabIndex = 13
        PlanAmountLbl.Text = "Premium 100Mbps - Due:  ?1,500"
        ' 
        ' NameOfCustomerLbl
        ' 
        NameOfCustomerLbl.AutoSize = True
        NameOfCustomerLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        NameOfCustomerLbl.ForeColor = Color.Maroon
        NameOfCustomerLbl.Location = New Point(12, 13)
        NameOfCustomerLbl.Name = "NameOfCustomerLbl"
        NameOfCustomerLbl.Size = New Size(82, 21)
        NameOfCustomerLbl.TabIndex = 12
        NameOfCustomerLbl.Text = "Erin Pablo"
        ' 
        ' PaymentAlertsLbl
        ' 
        PaymentAlertsLbl.AutoSize = True
        PaymentAlertsLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PaymentAlertsLbl.ForeColor = Color.Maroon
        PaymentAlertsLbl.Location = New Point(63, 17)
        PaymentAlertsLbl.Name = "PaymentAlertsLbl"
        PaymentAlertsLbl.Size = New Size(204, 21)
        PaymentAlertsLbl.TabIndex = 11
        PaymentAlertsLbl.Text = "Outstanding Payment Alerts"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(33, 14)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(21, 27)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' BillingDetailsPanel
        ' 
        BillingDetailsPanel.BackColor = Color.White
        BillingDetailsPanel.Controls.Add(TableLayoutPanel1)
        BillingDetailsPanel.Controls.Add(BillingDetailsDGV)
        BillingDetailsPanel.Controls.Add(BillingDetailsLbl)
        BillingDetailsPanel.Location = New Point(43, 956)
        BillingDetailsPanel.Name = "BillingDetailsPanel"
        BillingDetailsPanel.Size = New Size(1597, 494)
        BillingDetailsPanel.TabIndex = 22
        ' 
        ' BillingDetailsDGV
        ' 
        BillingDetailsDGV.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BillingDetailsDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        BillingDetailsDGV.BackgroundColor = Color.White
        BillingDetailsDGV.BorderStyle = BorderStyle.None
        BillingDetailsDGV.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        BillingDetailsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 10F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        BillingDetailsDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        BillingDetailsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BillingDetailsDGV.Columns.AddRange(New DataGridViewColumn() {PaymentID, CustomerName, PlanType, MonthlyRate, AmountPaid, PaymentDate, Status, ModeOfPayment, EditDelete})
        BillingDetailsDGV.GridColor = Color.Silver
        BillingDetailsDGV.Location = New Point(21, 74)
        BillingDetailsDGV.Name = "BillingDetailsDGV"
        BillingDetailsDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        BillingDetailsDGV.RowHeadersVisible = False
        BillingDetailsDGV.RowTemplate.Height = 40
        BillingDetailsDGV.ScrollBars = ScrollBars.Vertical
        BillingDetailsDGV.Size = New Size(1501, 393)
        BillingDetailsDGV.TabIndex = 24
        ' 
        ' PaymentID
        ' 
        PaymentID.Frozen = True
        PaymentID.HeaderText = "Payment ID "
        PaymentID.Name = "PaymentID"
        PaymentID.ReadOnly = True
        PaymentID.Width = 150
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Customer Name"
        CustomerName.Name = "CustomerName"
        CustomerName.ReadOnly = True
        CustomerName.Width = 150
        ' 
        ' PlanType
        ' 
        PlanType.HeaderText = "Plan Type"
        PlanType.Name = "PlanType"
        PlanType.ReadOnly = True
        PlanType.Width = 150
        ' 
        ' MonthlyRate
        ' 
        MonthlyRate.HeaderText = "Montly Rate"
        MonthlyRate.Name = "MonthlyRate"
        MonthlyRate.ReadOnly = True
        MonthlyRate.Width = 200
        ' 
        ' AmountPaid
        ' 
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.DarkGreen
        AmountPaid.DefaultCellStyle = DataGridViewCellStyle3
        AmountPaid.HeaderText = "Amount Paid"
        AmountPaid.Name = "AmountPaid"
        AmountPaid.ReadOnly = True
        AmountPaid.Width = 200
        ' 
        ' PaymentDate
        ' 
        PaymentDate.HeaderText = "Payment Date"
        PaymentDate.Name = "PaymentDate"
        PaymentDate.ReadOnly = True
        PaymentDate.Width = 350
        ' 
        ' Status
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.DarkGreen
        Status.DefaultCellStyle = DataGridViewCellStyle4
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' ModeOfPayment
        ' 
        ModeOfPayment.HeaderText = "Mode of Payment"
        ModeOfPayment.Name = "ModeOfPayment"
        ' 
        ' EditDelete
        ' 
        EditDelete.HeaderText = ""
        EditDelete.Name = "EditDelete"
        EditDelete.ReadOnly = True
        EditDelete.Width = 50
        ' 
        ' BillingDetailsLbl
        ' 
        BillingDetailsLbl.AutoSize = True
        BillingDetailsLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BillingDetailsLbl.ForeColor = Color.Black
        BillingDetailsLbl.Location = New Point(22, 23)
        BillingDetailsLbl.Name = "BillingDetailsLbl"
        BillingDetailsLbl.Size = New Size(104, 21)
        BillingDetailsLbl.TabIndex = 9
        BillingDetailsLbl.Text = "Billing Details"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 8
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 49.65035F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.34965F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 152F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 200F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 196F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 352F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 149F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 151F))
        TableLayoutPanel1.Location = New Point(27, 136)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1495, 316)
        TableLayoutPanel1.TabIndex = 25
        ' 
        ' billingview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(BillingDetailsPanel)
        Controls.Add(RedPanel)
        Controls.Add(PaymentsummaryPanel)
        Controls.Add(UnpaidBillsPanel)
        Controls.Add(PaidBillsPanel)
        Controls.Add(OutstandingPanel)
        Controls.Add(TotalReceivedPanel)
        Controls.Add(TotalExpectedPanel)
        Controls.Add(InventoryFilterPanel)
        Controls.Add(HeaderBillingReport)
        Name = "billingview"
        Size = New Size(1963, 1576)
        InventoryFilterPanel.ResumeLayout(False)
        InventoryFilterPanel.PerformLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).EndInit()
        TotalExpectedPanel.ResumeLayout(False)
        TotalExpectedPanel.PerformLayout()
        CType(BlueDollarIcon, ComponentModel.ISupportInitialize).EndInit()
        TotalReceivedPanel.ResumeLayout(False)
        TotalReceivedPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        OutstandingPanel.ResumeLayout(False)
        OutstandingPanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PaidBillsPanel.ResumeLayout(False)
        PaidBillsPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        UnpaidBillsPanel.ResumeLayout(False)
        UnpaidBillsPanel.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PaymentsummaryPanel.ResumeLayout(False)
        PaymentsummaryPanel.PerformLayout()
        DefaultRatePanel.ResumeLayout(False)
        DefaultRatePanel.PerformLayout()
        CollectionRatePanel.ResumeLayout(False)
        CollectionRatePanel.PerformLayout()
        RedPanel.ResumeLayout(False)
        OustandingPanel.ResumeLayout(False)
        OustandingPanel.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        OverduePanel.ResumeLayout(False)
        OverduePanel.PerformLayout()
        PanelRound9.ResumeLayout(False)
        PanelRound9.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        BillingDetailsPanel.ResumeLayout(False)
        BillingDetailsPanel.PerformLayout()
        CType(BillingDetailsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderBillingReport As Label
    Friend WithEvents InventoryFilterPanel As PanelRound
    Friend WithEvents ItemSearchTxtBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateRangeLbl As Label
    Friend WithEvents PaymentStatusLbl As Label
    Friend WithEvents CustomerNameLbl As Label
    Friend WithEvents LabelFilters As Label
    Friend WithEvents IconFilter As PictureBox
    Friend WithEvents TotalExpectedPanel As PanelRound
    Friend WithEvents BlueDollarIcon As PictureBox
    Friend WithEvents AmountExpectedLbl As Label
    Friend WithEvents TotalExpectedLbl As Label
    Friend WithEvents TotalReceivedPanel As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AmoundReceivedLbl As Label
    Friend WithEvents TotalReceivedLbl As Label
    Friend WithEvents OutstandingPanel As PanelRound
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents AmountOutstandingLbl As Label
    Friend WithEvents OutsandingLbl As Label
    Friend WithEvents PaidBillsPanel As PanelRound
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NumPaidLbl As Label
    Friend WithEvents PaidBillsLbl As Label
    Friend WithEvents UnpaidBillsPanel As PanelRound
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents NumUnpaidLbl As Label
    Friend WithEvents UnpaidBillsLbl As Label
    Friend WithEvents PaymentsummaryPanel As PanelRound
    Friend WithEvents CollectionRatePanel As PanelRound
    Friend WithEvents PaymentSummaryLbl As Label
    Friend WithEvents DefaultRatePanel As PanelRound
    Friend WithEvents DefaultRateLbl As Label
    Friend WithEvents DefaultPercentLbl As Label
    Friend WithEvents CollectionRateLbl As Label
    Friend WithEvents CollectionPercentLbl As Label
    Friend WithEvents RedPanel As PanelRound
    Friend WithEvents OustandingPanel As PanelRound
    Friend WithEvents PanelRound8 As PanelRound
    Friend WithEvents PanelRound9 As PanelRound
    Friend WithEvents StatusLbl As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents OverduePanel As PanelRound
    Friend WithEvents PlanAmountLbl As Label
    Friend WithEvents NameOfCustomerLbl As Label
    Friend WithEvents PaymentAlertsLbl As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BillingDetailsPanel As PanelRound
    Friend WithEvents BillingDetailsDGV As DataGridView
    Friend WithEvents BillingDetailsLbl As Label
    Friend WithEvents PaymentID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents PlanType As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents ModeOfPayment As DataGridViewTextBoxColumn
    Friend WithEvents EditDelete As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class

