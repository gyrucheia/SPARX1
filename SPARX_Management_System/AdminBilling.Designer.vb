<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminBilling))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderBillingReport = New Label()
        PanelFilters = New PanelRound()
        PanelCustomerName = New PanelRound()
        TxtCustomerName = New TextBox()
        LabelCustomerName = New Label()
        ComboBoxPaymentStatus = New ComboBox()
        ComboBoxDateRange = New ComboBox()
        LabelPaymentStatus = New Label()
        LabelDateRange = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelTotalExpected = New PanelRound()
        ValueTotalExpected = New Label()
        PicTotalExpected = New PictureBox()
        BluePeso = New Label()
        LabelTotalExpected = New Label()
        PanelTotalReceived = New PanelRound()
        PicTotalReceived = New PictureBox()
        GreenPeso = New Label()
        ValueTotalRevenue = New Label()
        LabelTotalReceived = New Label()
        PanelOutstanding = New PanelRound()
        PicOutstanding = New PictureBox()
        RedPeso = New Label()
        ValueOutstanding = New Label()
        LabelOutstanding = New Label()
        PanelPaidBills = New PanelRound()
        PicPaidBills = New PictureBox()
        AmountPaidBills = New Label()
        LabelPaidbills = New Label()
        PanelUnpaidBills = New PanelRound()
        PicUnpaidBills = New PictureBox()
        AmountUnpaidBills = New Label()
        LabelUnpaidBills = New Label()
        PanelPaymentCollectionSummary = New PanelRound()
        LabelDefaultRate = New Label()
        LabelCollectionRate = New Label()
        DefaultRate = New Label()
        CollectionRate = New Label()
        LabelPaymentCollectionSummary = New Label()
        PanelItemsRequiringAttention = New PanelRound()
        PanelCustomer2 = New PanelRound()
        AmountDue2 = New Label()
        CustomerName2 = New Label()
        PlanType2 = New Label()
        PanelPaymentStatus2 = New PanelRound()
        LabelStatus2 = New Label()
        PanelCustomer1 = New PanelRound()
        AmountDue1 = New Label()
        CustomerName1 = New Label()
        PlanType1 = New Label()
        PanelPaymentStatus1 = New PanelRound()
        LabelStatus1 = New Label()
        PictureBox7 = New PictureBox()
        LabelOutstandingPaymentAlert = New Label()
        PanelRound11 = New PanelRound()
        PanelBillingDetails = New PanelRound()
        DataGridBillingDetails = New DataGridView()
        PaymentID = New DataGridViewTextBoxColumn()
        CustomerName = New DataGridViewTextBoxColumn()
        PlanType = New DataGridViewTextBoxColumn()
        MonthlyRate = New DataGridViewTextBoxColumn()
        AmountPaid = New DataGridViewTextBoxColumn()
        PaymentDate = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Balance = New DataGridViewTextBoxColumn()
        LabelBillingDetails = New Label()
        PanelRound1 = New PanelRound()
        PanelFilters.SuspendLayout()
        PanelCustomerName.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalExpected.SuspendLayout()
        CType(PicTotalExpected, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalReceived.SuspendLayout()
        CType(PicTotalReceived, ComponentModel.ISupportInitialize).BeginInit()
        PanelOutstanding.SuspendLayout()
        CType(PicOutstanding, ComponentModel.ISupportInitialize).BeginInit()
        PanelPaidBills.SuspendLayout()
        CType(PicPaidBills, ComponentModel.ISupportInitialize).BeginInit()
        PanelUnpaidBills.SuspendLayout()
        CType(PicUnpaidBills, ComponentModel.ISupportInitialize).BeginInit()
        PanelPaymentCollectionSummary.SuspendLayout()
        PanelItemsRequiringAttention.SuspendLayout()
        PanelCustomer2.SuspendLayout()
        PanelPaymentStatus2.SuspendLayout()
        PanelCustomer1.SuspendLayout()
        PanelPaymentStatus1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        PanelBillingDetails.SuspendLayout()
        CType(DataGridBillingDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderBillingReport
        ' 
        HeaderBillingReport.AutoSize = True
        HeaderBillingReport.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        HeaderBillingReport.Location = New Point(43, 16)
        HeaderBillingReport.Name = "HeaderBillingReport"
        HeaderBillingReport.Size = New Size(230, 46)
        HeaderBillingReport.TabIndex = 12
        HeaderBillingReport.Text = "Billing Report"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(PanelCustomerName)
        PanelFilters.Controls.Add(LabelCustomerName)
        PanelFilters.Controls.Add(ComboBoxPaymentStatus)
        PanelFilters.Controls.Add(ComboBoxDateRange)
        PanelFilters.Controls.Add(LabelPaymentStatus)
        PanelFilters.Controls.Add(LabelDateRange)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 55)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 13
        ' 
        ' PanelCustomerName
        ' 
        PanelCustomerName.BackColor = SystemColors.ButtonFace
        PanelCustomerName.Controls.Add(TxtCustomerName)
        PanelCustomerName.CornerRadius = 8
        PanelCustomerName.Location = New Point(1040, 104)
        PanelCustomerName.Name = "PanelCustomerName"
        PanelCustomerName.Size = New Size(473, 35)
        PanelCustomerName.TabIndex = 12
        ' 
        ' TxtCustomerName
        ' 
        TxtCustomerName.BackColor = SystemColors.ButtonFace
        TxtCustomerName.BorderStyle = BorderStyle.None
        TxtCustomerName.Font = New Font("Segoe UI", 11F)
        TxtCustomerName.Location = New Point(8, 7)
        TxtCustomerName.Name = "TxtCustomerName"
        TxtCustomerName.Size = New Size(459, 20)
        TxtCustomerName.TabIndex = 0
        ' 
        ' LabelCustomerName
        ' 
        LabelCustomerName.AutoSize = True
        LabelCustomerName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelCustomerName.Location = New Point(1040, 80)
        LabelCustomerName.Name = "LabelCustomerName"
        LabelCustomerName.Size = New Size(128, 21)
        LabelCustomerName.TabIndex = 21
        LabelCustomerName.Text = "Customer Name"
        ' 
        ' ComboBoxPaymentStatus
        ' 
        ComboBoxPaymentStatus.BackColor = SystemColors.ButtonFace
        ComboBoxPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPaymentStatus.Font = New Font("Segoe UI", 14F)
        ComboBoxPaymentStatus.ForeColor = SystemColors.WindowText
        ComboBoxPaymentStatus.FormattingEnabled = True
        ComboBoxPaymentStatus.Location = New Point(532, 104)
        ComboBoxPaymentStatus.MinimumSize = New Size(193, 0)
        ComboBoxPaymentStatus.Name = "ComboBoxPaymentStatus"
        ComboBoxPaymentStatus.Size = New Size(473, 33)
        ComboBoxPaymentStatus.TabIndex = 20
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
        ComboBoxDateRange.Size = New Size(473, 33)
        ComboBoxDateRange.TabIndex = 19
        ' 
        ' LabelPaymentStatus
        ' 
        LabelPaymentStatus.AutoSize = True
        LabelPaymentStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelPaymentStatus.Location = New Point(530, 80)
        LabelPaymentStatus.Name = "LabelPaymentStatus"
        LabelPaymentStatus.Size = New Size(122, 21)
        LabelPaymentStatus.TabIndex = 18
        LabelPaymentStatus.Text = "Payment Status"
        ' 
        ' LabelDateRange
        ' 
        LabelDateRange.AutoSize = True
        LabelDateRange.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelDateRange.Location = New Point(22, 80)
        LabelDateRange.Name = "LabelDateRange"
        LabelDateRange.Size = New Size(94, 21)
        LabelDateRange.TabIndex = 17
        LabelDateRange.Text = "Date Range"
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
        ' PanelTotalExpected
        ' 
        PanelTotalExpected.BackColor = Color.White
        PanelTotalExpected.Controls.Add(ValueTotalExpected)
        PanelTotalExpected.Controls.Add(PicTotalExpected)
        PanelTotalExpected.Controls.Add(BluePeso)
        PanelTotalExpected.Controls.Add(LabelTotalExpected)
        PanelTotalExpected.CornerRadius = 12
        PanelTotalExpected.Location = New Point(43, 256)
        PanelTotalExpected.Name = "PanelTotalExpected"
        PanelTotalExpected.Size = New Size(290, 143)
        PanelTotalExpected.TabIndex = 14
        ' 
        ' ValueTotalExpected
        ' 
        ValueTotalExpected.AutoSize = True
        ValueTotalExpected.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        ValueTotalExpected.ForeColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        ValueTotalExpected.Location = New Point(63, 59)
        ValueTotalExpected.Name = "ValueTotalExpected"
        ValueTotalExpected.Size = New Size(47, 37)
        ValueTotalExpected.TabIndex = 24
        ValueTotalExpected.Text = "00"
        ' 
        ' PicTotalExpected
        ' 
        PicTotalExpected.Image = CType(resources.GetObject("PicTotalExpected.Image"), Image)
        PicTotalExpected.Location = New Point(213, 54)
        PicTotalExpected.Name = "PicTotalExpected"
        PicTotalExpected.Size = New Size(48, 50)
        PicTotalExpected.SizeMode = PictureBoxSizeMode.Zoom
        PicTotalExpected.TabIndex = 23
        PicTotalExpected.TabStop = False
        ' 
        ' BluePeso
        ' 
        BluePeso.AutoSize = True
        BluePeso.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        BluePeso.ForeColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        BluePeso.Location = New Point(24, 59)
        BluePeso.Name = "BluePeso"
        BluePeso.Size = New Size(34, 37)
        BluePeso.TabIndex = 22
        BluePeso.Text = "₱"
        ' 
        ' LabelTotalExpected
        ' 
        LabelTotalExpected.AutoSize = True
        LabelTotalExpected.Font = New Font("Verdana", 12F)
        LabelTotalExpected.ForeColor = SystemColors.ControlDarkDark
        LabelTotalExpected.Location = New Point(24, 27)
        LabelTotalExpected.Name = "LabelTotalExpected"
        LabelTotalExpected.Size = New Size(128, 18)
        LabelTotalExpected.TabIndex = 12
        LabelTotalExpected.Text = "Total Expected"
        ' 
        ' PanelTotalReceived
        ' 
        PanelTotalReceived.BackColor = Color.White
        PanelTotalReceived.Controls.Add(PicTotalReceived)
        PanelTotalReceived.Controls.Add(GreenPeso)
        PanelTotalReceived.Controls.Add(ValueTotalRevenue)
        PanelTotalReceived.Controls.Add(LabelTotalReceived)
        PanelTotalReceived.CornerRadius = 12
        PanelTotalReceived.Location = New Point(373, 256)
        PanelTotalReceived.Name = "PanelTotalReceived"
        PanelTotalReceived.Size = New Size(290, 143)
        PanelTotalReceived.TabIndex = 15
        ' 
        ' PicTotalReceived
        ' 
        PicTotalReceived.Image = CType(resources.GetObject("PicTotalReceived.Image"), Image)
        PicTotalReceived.Location = New Point(213, 54)
        PicTotalReceived.Name = "PicTotalReceived"
        PicTotalReceived.Size = New Size(48, 50)
        PicTotalReceived.SizeMode = PictureBoxSizeMode.Zoom
        PicTotalReceived.TabIndex = 25
        PicTotalReceived.TabStop = False
        ' 
        ' GreenPeso
        ' 
        GreenPeso.AutoSize = True
        GreenPeso.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        GreenPeso.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        GreenPeso.Location = New Point(24, 59)
        GreenPeso.Name = "GreenPeso"
        GreenPeso.Size = New Size(34, 37)
        GreenPeso.TabIndex = 24
        GreenPeso.Text = "₱"
        ' 
        ' ValueTotalRevenue
        ' 
        ValueTotalRevenue.AutoSize = True
        ValueTotalRevenue.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        ValueTotalRevenue.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        ValueTotalRevenue.Location = New Point(63, 59)
        ValueTotalRevenue.Name = "ValueTotalRevenue"
        ValueTotalRevenue.Size = New Size(47, 37)
        ValueTotalRevenue.TabIndex = 23
        ValueTotalRevenue.Text = "00"
        ' 
        ' LabelTotalReceived
        ' 
        LabelTotalReceived.AutoSize = True
        LabelTotalReceived.Font = New Font("Verdana", 12F)
        LabelTotalReceived.ForeColor = SystemColors.ControlDarkDark
        LabelTotalReceived.Location = New Point(24, 27)
        LabelTotalReceived.Name = "LabelTotalReceived"
        LabelTotalReceived.Size = New Size(127, 18)
        LabelTotalReceived.TabIndex = 13
        LabelTotalReceived.Text = "Total Received"
        ' 
        ' PanelOutstanding
        ' 
        PanelOutstanding.BackColor = Color.White
        PanelOutstanding.Controls.Add(PicOutstanding)
        PanelOutstanding.Controls.Add(RedPeso)
        PanelOutstanding.Controls.Add(ValueOutstanding)
        PanelOutstanding.Controls.Add(LabelOutstanding)
        PanelOutstanding.CornerRadius = 12
        PanelOutstanding.Location = New Point(700, 256)
        PanelOutstanding.Name = "PanelOutstanding"
        PanelOutstanding.Size = New Size(290, 143)
        PanelOutstanding.TabIndex = 16
        ' 
        ' PicOutstanding
        ' 
        PicOutstanding.Image = CType(resources.GetObject("PicOutstanding.Image"), Image)
        PicOutstanding.Location = New Point(213, 54)
        PicOutstanding.Name = "PicOutstanding"
        PicOutstanding.Size = New Size(48, 50)
        PicOutstanding.SizeMode = PictureBoxSizeMode.Zoom
        PicOutstanding.TabIndex = 26
        PicOutstanding.TabStop = False
        ' 
        ' RedPeso
        ' 
        RedPeso.AutoSize = True
        RedPeso.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        RedPeso.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        RedPeso.Location = New Point(24, 59)
        RedPeso.Name = "RedPeso"
        RedPeso.Size = New Size(34, 37)
        RedPeso.TabIndex = 25
        RedPeso.Text = "₱"
        ' 
        ' ValueOutstanding
        ' 
        ValueOutstanding.AutoSize = True
        ValueOutstanding.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        ValueOutstanding.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        ValueOutstanding.Location = New Point(63, 59)
        ValueOutstanding.Name = "ValueOutstanding"
        ValueOutstanding.Size = New Size(47, 37)
        ValueOutstanding.TabIndex = 24
        ValueOutstanding.Text = "00"
        ' 
        ' LabelOutstanding
        ' 
        LabelOutstanding.AutoSize = True
        LabelOutstanding.Font = New Font("Verdana", 12F)
        LabelOutstanding.ForeColor = SystemColors.ControlDarkDark
        LabelOutstanding.Location = New Point(24, 27)
        LabelOutstanding.Name = "LabelOutstanding"
        LabelOutstanding.Size = New Size(109, 18)
        LabelOutstanding.TabIndex = 14
        LabelOutstanding.Text = "Outstanding"
        ' 
        ' PanelPaidBills
        ' 
        PanelPaidBills.BackColor = Color.White
        PanelPaidBills.Controls.Add(PicPaidBills)
        PanelPaidBills.Controls.Add(AmountPaidBills)
        PanelPaidBills.Controls.Add(LabelPaidbills)
        PanelPaidBills.CornerRadius = 12
        PanelPaidBills.Location = New Point(1025, 256)
        PanelPaidBills.Name = "PanelPaidBills"
        PanelPaidBills.Size = New Size(290, 143)
        PanelPaidBills.TabIndex = 17
        ' 
        ' PicPaidBills
        ' 
        PicPaidBills.Location = New Point(213, 54)
        PicPaidBills.Name = "PicPaidBills"
        PicPaidBills.Size = New Size(48, 50)
        PicPaidBills.SizeMode = PictureBoxSizeMode.Zoom
        PicPaidBills.TabIndex = 27
        PicPaidBills.TabStop = False
        ' 
        ' AmountPaidBills
        ' 
        AmountPaidBills.AutoSize = True
        AmountPaidBills.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        AmountPaidBills.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        AmountPaidBills.Location = New Point(24, 59)
        AmountPaidBills.Name = "AmountPaidBills"
        AmountPaidBills.Size = New Size(47, 37)
        AmountPaidBills.TabIndex = 25
        AmountPaidBills.Text = "00"
        ' 
        ' LabelPaidbills
        ' 
        LabelPaidbills.AutoSize = True
        LabelPaidbills.Font = New Font("Verdana", 12F)
        LabelPaidbills.ForeColor = SystemColors.ControlDarkDark
        LabelPaidbills.Location = New Point(24, 27)
        LabelPaidbills.Name = "LabelPaidbills"
        LabelPaidbills.Size = New Size(84, 18)
        LabelPaidbills.TabIndex = 15
        LabelPaidbills.Text = "Paid Bills"
        ' 
        ' PanelUnpaidBills
        ' 
        PanelUnpaidBills.BackColor = Color.White
        PanelUnpaidBills.Controls.Add(PicUnpaidBills)
        PanelUnpaidBills.Controls.Add(AmountUnpaidBills)
        PanelUnpaidBills.Controls.Add(LabelUnpaidBills)
        PanelUnpaidBills.CornerRadius = 12
        PanelUnpaidBills.Location = New Point(1350, 256)
        PanelUnpaidBills.Name = "PanelUnpaidBills"
        PanelUnpaidBills.Size = New Size(290, 143)
        PanelUnpaidBills.TabIndex = 18
        ' 
        ' PicUnpaidBills
        ' 
        PicUnpaidBills.Image = CType(resources.GetObject("PicUnpaidBills.Image"), Image)
        PicUnpaidBills.Location = New Point(213, 54)
        PicUnpaidBills.Name = "PicUnpaidBills"
        PicUnpaidBills.Size = New Size(48, 50)
        PicUnpaidBills.SizeMode = PictureBoxSizeMode.Zoom
        PicUnpaidBills.TabIndex = 28
        PicUnpaidBills.TabStop = False
        ' 
        ' AmountUnpaidBills
        ' 
        AmountUnpaidBills.AutoSize = True
        AmountUnpaidBills.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        AmountUnpaidBills.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        AmountUnpaidBills.Location = New Point(24, 59)
        AmountUnpaidBills.Name = "AmountUnpaidBills"
        AmountUnpaidBills.Size = New Size(47, 37)
        AmountUnpaidBills.TabIndex = 26
        AmountUnpaidBills.Text = "00"
        ' 
        ' LabelUnpaidBills
        ' 
        LabelUnpaidBills.AutoSize = True
        LabelUnpaidBills.Font = New Font("Verdana", 12F)
        LabelUnpaidBills.ForeColor = SystemColors.ControlDarkDark
        LabelUnpaidBills.Location = New Point(24, 27)
        LabelUnpaidBills.Name = "LabelUnpaidBills"
        LabelUnpaidBills.Size = New Size(106, 18)
        LabelUnpaidBills.TabIndex = 16
        LabelUnpaidBills.Text = "Unpaid Bills"
        ' 
        ' PanelPaymentCollectionSummary
        ' 
        PanelPaymentCollectionSummary.BackColor = Color.White
        PanelPaymentCollectionSummary.Controls.Add(LabelDefaultRate)
        PanelPaymentCollectionSummary.Controls.Add(LabelCollectionRate)
        PanelPaymentCollectionSummary.Controls.Add(DefaultRate)
        PanelPaymentCollectionSummary.Controls.Add(CollectionRate)
        PanelPaymentCollectionSummary.Controls.Add(LabelPaymentCollectionSummary)
        PanelPaymentCollectionSummary.CornerRadius = 12
        PanelPaymentCollectionSummary.Location = New Point(43, 430)
        PanelPaymentCollectionSummary.Name = "PanelPaymentCollectionSummary"
        PanelPaymentCollectionSummary.Size = New Size(1597, 200)
        PanelPaymentCollectionSummary.TabIndex = 19
        ' 
        ' LabelDefaultRate
        ' 
        LabelDefaultRate.AutoSize = True
        LabelDefaultRate.Font = New Font("Segoe UI", 12F)
        LabelDefaultRate.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        LabelDefaultRate.Location = New Point(880, 75)
        LabelDefaultRate.Name = "LabelDefaultRate"
        LabelDefaultRate.Size = New Size(95, 21)
        LabelDefaultRate.TabIndex = 27
        LabelDefaultRate.Text = "Default Rate"
        ' 
        ' LabelCollectionRate
        ' 
        LabelCollectionRate.AutoSize = True
        LabelCollectionRate.Font = New Font("Segoe UI", 12F)
        LabelCollectionRate.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        LabelCollectionRate.Location = New Point(567, 75)
        LabelCollectionRate.Name = "LabelCollectionRate"
        LabelCollectionRate.Size = New Size(114, 21)
        LabelCollectionRate.TabIndex = 26
        LabelCollectionRate.Text = "Collection Rate"
        ' 
        ' DefaultRate
        ' 
        DefaultRate.AutoSize = True
        DefaultRate.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold)
        DefaultRate.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        DefaultRate.Location = New Point(879, 96)
        DefaultRate.Name = "DefaultRate"
        DefaultRate.Size = New Size(101, 54)
        DefaultRate.TabIndex = 25
        DefaultRate.Text = "00%"
        ' 
        ' CollectionRate
        ' 
        CollectionRate.AutoSize = True
        CollectionRate.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold)
        CollectionRate.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        CollectionRate.Location = New Point(579, 96)
        CollectionRate.Name = "CollectionRate"
        CollectionRate.Size = New Size(101, 54)
        CollectionRate.TabIndex = 24
        CollectionRate.Text = "00%"
        ' 
        ' LabelPaymentCollectionSummary
        ' 
        LabelPaymentCollectionSummary.AutoSize = True
        LabelPaymentCollectionSummary.Font = New Font("Verdana", 12F)
        LabelPaymentCollectionSummary.Location = New Point(22, 21)
        LabelPaymentCollectionSummary.Name = "LabelPaymentCollectionSummary"
        LabelPaymentCollectionSummary.Size = New Size(247, 18)
        LabelPaymentCollectionSummary.TabIndex = 17
        LabelPaymentCollectionSummary.Text = "Payment Collection Summary"
        ' 
        ' PanelItemsRequiringAttention
        ' 
        PanelItemsRequiringAttention.BackColor = Color.White
        PanelItemsRequiringAttention.Controls.Add(PanelCustomer2)
        PanelItemsRequiringAttention.Controls.Add(PanelCustomer1)
        PanelItemsRequiringAttention.Controls.Add(PictureBox7)
        PanelItemsRequiringAttention.Controls.Add(LabelOutstandingPaymentAlert)
        PanelItemsRequiringAttention.CornerRadius = 12
        PanelItemsRequiringAttention.Location = New Point(50, 664)
        PanelItemsRequiringAttention.Name = "PanelItemsRequiringAttention"
        PanelItemsRequiringAttention.Size = New Size(1590, 237)
        PanelItemsRequiringAttention.TabIndex = 40
        ' 
        ' PanelCustomer2
        ' 
        PanelCustomer2.BackColor = Color.White
        PanelCustomer2.Controls.Add(AmountDue2)
        PanelCustomer2.Controls.Add(CustomerName2)
        PanelCustomer2.Controls.Add(PlanType2)
        PanelCustomer2.Controls.Add(PanelPaymentStatus2)
        PanelCustomer2.CornerRadius = 12
        PanelCustomer2.Location = New Point(15, 139)
        PanelCustomer2.Name = "PanelCustomer2"
        PanelCustomer2.Size = New Size(1558, 70)
        PanelCustomer2.TabIndex = 21
        ' 
        ' AmountDue2
        ' 
        AmountDue2.Anchor = AnchorStyles.Top
        AmountDue2.AutoSize = True
        AmountDue2.Font = New Font("Segoe UI", 10F)
        AmountDue2.ForeColor = Color.Red
        AmountDue2.Location = New Point(202, 40)
        AmountDue2.Name = "AmountDue2"
        AmountDue2.Size = New Size(37, 19)
        AmountDue2.TabIndex = 21
        AmountDue2.Text = "₱ 00"
        ' 
        ' CustomerName2
        ' 
        CustomerName2.Anchor = AnchorStyles.Top
        CustomerName2.AutoSize = True
        CustomerName2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        CustomerName2.ForeColor = Color.DarkRed
        CustomerName2.Location = New Point(21, 15)
        CustomerName2.Name = "CustomerName2"
        CustomerName2.Size = New Size(163, 25)
        CustomerName2.TabIndex = 20
        CustomerName2.Text = "Customer Name2"
        ' 
        ' PlanType2
        ' 
        PlanType2.Anchor = AnchorStyles.Top
        PlanType2.AutoSize = True
        PlanType2.Font = New Font("Segoe UI", 10F)
        PlanType2.ForeColor = Color.Red
        PlanType2.Location = New Point(23, 40)
        PlanType2.Name = "PlanType2"
        PlanType2.Size = New Size(109, 19)
        PlanType2.TabIndex = 19
        PlanType2.Text = "Plan Type - Due:"
        ' 
        ' PanelPaymentStatus2
        ' 
        PanelPaymentStatus2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        PanelPaymentStatus2.Controls.Add(LabelStatus2)
        PanelPaymentStatus2.CornerRadius = 10
        PanelPaymentStatus2.Location = New Point(1471, 23)
        PanelPaymentStatus2.Name = "PanelPaymentStatus2"
        PanelPaymentStatus2.Size = New Size(75, 26)
        PanelPaymentStatus2.TabIndex = 1
        ' 
        ' LabelStatus2
        ' 
        LabelStatus2.Anchor = AnchorStyles.Top
        LabelStatus2.AutoSize = True
        LabelStatus2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatus2.ForeColor = Color.DarkRed
        LabelStatus2.Location = New Point(2, 3)
        LabelStatus2.Name = "LabelStatus2"
        LabelStatus2.Size = New Size(73, 21)
        LabelStatus2.TabIndex = 22
        LabelStatus2.Text = "Overdue"
        ' 
        ' PanelCustomer1
        ' 
        PanelCustomer1.BackColor = Color.White
        PanelCustomer1.Controls.Add(AmountDue1)
        PanelCustomer1.Controls.Add(CustomerName1)
        PanelCustomer1.Controls.Add(PlanType1)
        PanelCustomer1.Controls.Add(PanelPaymentStatus1)
        PanelCustomer1.CornerRadius = 12
        PanelCustomer1.Location = New Point(15, 63)
        PanelCustomer1.Name = "PanelCustomer1"
        PanelCustomer1.Size = New Size(1558, 70)
        PanelCustomer1.TabIndex = 19
        ' 
        ' AmountDue1
        ' 
        AmountDue1.Anchor = AnchorStyles.Top
        AmountDue1.AutoSize = True
        AmountDue1.Font = New Font("Segoe UI", 10F)
        AmountDue1.ForeColor = Color.Red
        AmountDue1.Location = New Point(202, 40)
        AmountDue1.Name = "AmountDue1"
        AmountDue1.Size = New Size(37, 19)
        AmountDue1.TabIndex = 20
        AmountDue1.Text = "₱ 00"
        ' 
        ' CustomerName1
        ' 
        CustomerName1.Anchor = AnchorStyles.Top
        CustomerName1.AutoSize = True
        CustomerName1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        CustomerName1.ForeColor = Color.DarkRed
        CustomerName1.Location = New Point(21, 15)
        CustomerName1.Name = "CustomerName1"
        CustomerName1.Size = New Size(160, 25)
        CustomerName1.TabIndex = 19
        CustomerName1.Text = "Customer Name1"
        ' 
        ' PlanType1
        ' 
        PlanType1.Anchor = AnchorStyles.Top
        PlanType1.AutoSize = True
        PlanType1.Font = New Font("Segoe UI", 10F)
        PlanType1.ForeColor = Color.Red
        PlanType1.Location = New Point(23, 40)
        PlanType1.Name = "PlanType1"
        PlanType1.Size = New Size(109, 19)
        PlanType1.TabIndex = 18
        PlanType1.Text = "Plan Type - Due:"
        ' 
        ' PanelPaymentStatus1
        ' 
        PanelPaymentStatus1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        PanelPaymentStatus1.Controls.Add(LabelStatus1)
        PanelPaymentStatus1.CornerRadius = 10
        PanelPaymentStatus1.Location = New Point(1471, 24)
        PanelPaymentStatus1.Name = "PanelPaymentStatus1"
        PanelPaymentStatus1.Size = New Size(75, 25)
        PanelPaymentStatus1.TabIndex = 0
        ' 
        ' LabelStatus1
        ' 
        LabelStatus1.Anchor = AnchorStyles.Top
        LabelStatus1.AutoSize = True
        LabelStatus1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatus1.ForeColor = Color.DarkRed
        LabelStatus1.Location = New Point(2, 2)
        LabelStatus1.Name = "LabelStatus1"
        LabelStatus1.Size = New Size(73, 21)
        LabelStatus1.TabIndex = 21
        LabelStatus1.Text = "Overdue"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(15, 16)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 18
        PictureBox7.TabStop = False
        ' 
        ' LabelOutstandingPaymentAlert
        ' 
        LabelOutstandingPaymentAlert.Anchor = AnchorStyles.Top
        LabelOutstandingPaymentAlert.AutoSize = True
        LabelOutstandingPaymentAlert.Font = New Font("Verdana", 11F)
        LabelOutstandingPaymentAlert.ForeColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        LabelOutstandingPaymentAlert.Location = New Point(45, 18)
        LabelOutstandingPaymentAlert.Name = "LabelOutstandingPaymentAlert"
        LabelOutstandingPaymentAlert.Size = New Size(207, 18)
        LabelOutstandingPaymentAlert.TabIndex = 17
        LabelOutstandingPaymentAlert.Text = "Outstanding Payment Alert"
        ' 
        ' PanelRound11
        ' 
        PanelRound11.BackColor = Color.FromArgb(CByte(231), CByte(0), CByte(11))
        PanelRound11.CornerRadius = 12
        PanelRound11.Location = New Point(43, 664)
        PanelRound11.Name = "PanelRound11"
        PanelRound11.Size = New Size(46, 237)
        PanelRound11.TabIndex = 41
        ' 
        ' PanelBillingDetails
        ' 
        PanelBillingDetails.BackColor = Color.White
        PanelBillingDetails.Controls.Add(DataGridBillingDetails)
        PanelBillingDetails.Controls.Add(LabelBillingDetails)
        PanelBillingDetails.CornerRadius = 12
        PanelBillingDetails.Location = New Point(43, 937)
        PanelBillingDetails.Name = "PanelBillingDetails"
        PanelBillingDetails.Size = New Size(1595, 609)
        PanelBillingDetails.TabIndex = 42
        ' 
        ' DataGridBillingDetails
        ' 
        DataGridBillingDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridBillingDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridBillingDetails.BackgroundColor = Color.White
        DataGridBillingDetails.BorderStyle = BorderStyle.None
        DataGridBillingDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridBillingDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 11F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridBillingDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridBillingDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridBillingDetails.Columns.AddRange(New DataGridViewColumn() {PaymentID, CustomerName, PlanType, MonthlyRate, AmountPaid, PaymentDate, Status, Balance})
        DataGridBillingDetails.EnableHeadersVisualStyles = False
        DataGridBillingDetails.GridColor = Color.White
        DataGridBillingDetails.Location = New Point(8, 68)
        DataGridBillingDetails.Name = "DataGridBillingDetails"
        DataGridBillingDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridBillingDetails.RowHeadersVisible = False
        DataGridBillingDetails.RowTemplate.Height = 40
        DataGridBillingDetails.ScrollBars = ScrollBars.Vertical
        DataGridBillingDetails.Size = New Size(1578, 503)
        DataGridBillingDetails.TabIndex = 25
        ' 
        ' PaymentID
        ' 
        PaymentID.Frozen = True
        PaymentID.HeaderText = "Payment ID"
        PaymentID.Name = "PaymentID"
        PaymentID.ReadOnly = True
        PaymentID.Width = 150
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Customer Name"
        CustomerName.Name = "CustomerName"
        CustomerName.ReadOnly = True
        CustomerName.Width = 300
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
        MonthlyRate.Width = 150
        ' 
        ' AmountPaid
        ' 
        AmountPaid.HeaderText = "Amount Paid"
        AmountPaid.Name = "AmountPaid"
        AmountPaid.ReadOnly = True
        AmountPaid.Width = 150
        ' 
        ' PaymentDate
        ' 
        PaymentDate.HeaderText = "Payment Date"
        PaymentDate.Name = "PaymentDate"
        PaymentDate.ReadOnly = True
        PaymentDate.Width = 300
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' Balance
        ' 
        Balance.HeaderText = "Balance"
        Balance.Name = "Balance"
        Balance.Width = 150
        ' 
        ' LabelBillingDetails
        ' 
        LabelBillingDetails.AutoSize = True
        LabelBillingDetails.Font = New Font("Verdana", 12F)
        LabelBillingDetails.ForeColor = Color.Black
        LabelBillingDetails.Location = New Point(21, 19)
        LabelBillingDetails.Name = "LabelBillingDetails"
        LabelBillingDetails.Size = New Size(114, 18)
        LabelBillingDetails.TabIndex = 26
        LabelBillingDetails.Text = "Billing Detail"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Location = New Point(43, 1590)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 49)
        PanelRound1.TabIndex = 43
        ' 
        ' AdminBilling
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound1)
        Controls.Add(PanelBillingDetails)
        Controls.Add(PanelItemsRequiringAttention)
        Controls.Add(PanelRound11)
        Controls.Add(PanelPaymentCollectionSummary)
        Controls.Add(PanelUnpaidBills)
        Controls.Add(PanelPaidBills)
        Controls.Add(PanelOutstanding)
        Controls.Add(PanelTotalReceived)
        Controls.Add(PanelTotalExpected)
        Controls.Add(PanelFilters)
        Controls.Add(HeaderBillingReport)
        Name = "AdminBilling"
        Size = New Size(1940, 1933)
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        PanelCustomerName.ResumeLayout(False)
        PanelCustomerName.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalExpected.ResumeLayout(False)
        PanelTotalExpected.PerformLayout()
        CType(PicTotalExpected, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalReceived.ResumeLayout(False)
        PanelTotalReceived.PerformLayout()
        CType(PicTotalReceived, ComponentModel.ISupportInitialize).EndInit()
        PanelOutstanding.ResumeLayout(False)
        PanelOutstanding.PerformLayout()
        CType(PicOutstanding, ComponentModel.ISupportInitialize).EndInit()
        PanelPaidBills.ResumeLayout(False)
        PanelPaidBills.PerformLayout()
        CType(PicPaidBills, ComponentModel.ISupportInitialize).EndInit()
        PanelUnpaidBills.ResumeLayout(False)
        PanelUnpaidBills.PerformLayout()
        CType(PicUnpaidBills, ComponentModel.ISupportInitialize).EndInit()
        PanelPaymentCollectionSummary.ResumeLayout(False)
        PanelPaymentCollectionSummary.PerformLayout()
        PanelItemsRequiringAttention.ResumeLayout(False)
        PanelItemsRequiringAttention.PerformLayout()
        PanelCustomer2.ResumeLayout(False)
        PanelCustomer2.PerformLayout()
        PanelPaymentStatus2.ResumeLayout(False)
        PanelPaymentStatus2.PerformLayout()
        PanelCustomer1.ResumeLayout(False)
        PanelCustomer1.PerformLayout()
        PanelPaymentStatus1.ResumeLayout(False)
        PanelPaymentStatus1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        PanelBillingDetails.ResumeLayout(False)
        PanelBillingDetails.PerformLayout()
        CType(DataGridBillingDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderBillingReport As Label
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents PanelCustomerName As PanelRound
    Friend WithEvents TxtCustomerName As TextBox
    Friend WithEvents LabelCustomerName As Label
    Friend WithEvents ComboBoxPaymentStatus As ComboBox
    Friend WithEvents ComboBoxDateRange As ComboBox
    Friend WithEvents LabelPaymentStatus As Label
    Friend WithEvents LabelDateRange As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelTotalExpected As PanelRound
    Friend WithEvents PanelTotalReceived As PanelRound
    Friend WithEvents PanelOutstanding As PanelRound
    Friend WithEvents PanelPaidBills As PanelRound
    Friend WithEvents PanelUnpaidBills As PanelRound
    Friend WithEvents BluePeso As Label
    Friend WithEvents LabelTotalExpected As Label
    Friend WithEvents ValueTotalRevenue As Label
    Friend WithEvents LabelTotalReceived As Label
    Friend WithEvents LabelOutstanding As Label
    Friend WithEvents LabelPaidbills As Label
    Friend WithEvents LabelUnpaidBills As Label
    Friend WithEvents ValueOutstanding As Label
    Friend WithEvents AmountPaidBills As Label
    Friend WithEvents AmountUnpaidBills As Label
    Friend WithEvents PicTotalExpected As PictureBox
    Friend WithEvents ValueTotalExpected As Label
    Friend WithEvents GreenPeso As Label
    Friend WithEvents PicTotalReceived As PictureBox
    Friend WithEvents PicOutstanding As PictureBox
    Friend WithEvents RedPeso As Label
    Friend WithEvents PicPaidBills As PictureBox
    Friend WithEvents PicUnpaidBills As PictureBox
    Friend WithEvents PanelPaymentCollectionSummary As PanelRound
    Friend WithEvents LabelPaymentCollectionSummary As Label
    Friend WithEvents PanelAccount1 As PanelRound
    Friend WithEvents PanelAccount2 As PanelRound
    Friend WithEvents LabelCollectionRate As Label
    Friend WithEvents DefaultRate As Label
    Friend WithEvents CollectionRate As Label
    Friend WithEvents LabelDefaultRate As Label
    Friend WithEvents PanelItemsRequiringAttention As PanelRound
    Friend WithEvents PanelCustomer2 As PanelRound
    Friend WithEvents AmountDue2 As Label
    Friend WithEvents CustomerName2 As Label
    Friend WithEvents PlanType2 As Label
    Friend WithEvents PanelPaymentStatus2 As PanelRound
    Friend WithEvents PanelCustomer1 As PanelRound
    Friend WithEvents AmountDue1 As Label
    Friend WithEvents CustomerName1 As Label
    Friend WithEvents PlanType1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LabelOutstandingPaymentAlert As Label
    Friend WithEvents PanelRound11 As PanelRound
    Friend WithEvents PanelPaymentStatus1 As PanelRound
    Friend WithEvents LabelStatus2 As Label
    Friend WithEvents LabelStatus1 As Label
    Friend WithEvents PanelBillingDetails As PanelRound
    Friend WithEvents DataGridBillingDetails As DataGridView
    Friend WithEvents LabelBillingDetails As Label
    Friend WithEvents PaymentID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents PlanType As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents AmountPaid As DataGridViewTextBoxColumn
    Friend WithEvents PaymentDate As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Balance As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound1 As PanelRound
End Class
