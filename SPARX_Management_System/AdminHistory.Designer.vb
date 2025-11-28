<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHistory
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderIndividualCustomerHistory = New Label()
        PanelSelectCustomer = New PanelRound()
        ComboBox1 = New ComboBox()
        LabelCustomer = New Label()
        LabelSelectCustomer = New Label()
        PictureProfile = New PictureBox()
        PanelCustomerInformation = New PanelRound()
        Status = New PanelRound()
        LabelStatus = New Label()
        CurrentPlan = New PanelRound()
        PlanType = New Label()
        ServiceCompleted = New Label()
        TotalPaid = New Label()
        Email = New Label()
        FullName = New Label()
        PhoneNumber = New Label()
        CustomerID = New Label()
        LabelServiceCompleted = New Label()
        LabelAccountStatus = New Label()
        LabelTotalPaid = New Label()
        LabelCurrentPlan = New Label()
        LabelEmail = New Label()
        LabelFullName = New Label()
        LabelPhone = New Label()
        LabelCustomerID = New Label()
        Label2 = New Label()
        PanelPaymentServiceHistory = New PanelRound()
        DataGridInstallationDetails = New DataGridView()
        HistoryDate = New DataGridViewTextBoxColumn()
        Amount = New DataGridViewTextBoxColumn()
        PaymentMethod = New DataGridViewTextBoxColumn()
        HistoryStatus = New DataGridViewTextBoxColumn()
        Reference = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        ServiceHistory = New Label()
        IconServiceHistory = New PictureBox()
        PaymentHistory = New Label()
        IconPaymentHistory = New PictureBox()
        PanelTotalPayment = New PanelRound()
        PictureBox1 = New PictureBox()
        ValueTotalPayment = New Label()
        LabelTotalPayment = New Label()
        PanelServiceRequests = New PanelRound()
        PictureBox2 = New PictureBox()
        ValueServiceRequests = New Label()
        LabelServiceRequests = New Label()
        PanelAccountAge = New PanelRound()
        PictureBox3 = New PictureBox()
        Months = New Label()
        DurationMonths = New Label()
        LabelAccountAge = New Label()
        PanelRound1 = New PanelRound()
        PanelSelectCustomer.SuspendLayout()
        CType(PictureProfile, ComponentModel.ISupportInitialize).BeginInit()
        PanelCustomerInformation.SuspendLayout()
        Status.SuspendLayout()
        CurrentPlan.SuspendLayout()
        PanelPaymentServiceHistory.SuspendLayout()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconServiceHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconPaymentHistory, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalPayment.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelServiceRequests.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelAccountAge.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderIndividualCustomerHistory
        ' 
        HeaderIndividualCustomerHistory.AutoSize = True
        HeaderIndividualCustomerHistory.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderIndividualCustomerHistory.Location = New Point(43, 16)
        HeaderIndividualCustomerHistory.Name = "HeaderIndividualCustomerHistory"
        HeaderIndividualCustomerHistory.Size = New Size(267, 28)
        HeaderIndividualCustomerHistory.TabIndex = 12
        HeaderIndividualCustomerHistory.Text = "Individual Customer History"
        ' 
        ' PanelSelectCustomer
        ' 
        PanelSelectCustomer.BackColor = Color.White
        PanelSelectCustomer.Controls.Add(ComboBox1)
        PanelSelectCustomer.Controls.Add(LabelCustomer)
        PanelSelectCustomer.Controls.Add(LabelSelectCustomer)
        PanelSelectCustomer.Controls.Add(PictureProfile)
        PanelSelectCustomer.Location = New Point(43, 55)
        PanelSelectCustomer.Name = "PanelSelectCustomer"
        PanelSelectCustomer.Size = New Size(1597, 146)
        PanelSelectCustomer.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(25, 92)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(291, 29)
        ComboBox1.TabIndex = 15
        ' 
        ' LabelCustomer
        ' 
        LabelCustomer.AutoSize = True
        LabelCustomer.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelCustomer.Location = New Point(25, 68)
        LabelCustomer.Name = "LabelCustomer"
        LabelCustomer.Size = New Size(81, 21)
        LabelCustomer.TabIndex = 14
        LabelCustomer.Text = "Customer"
        ' 
        ' LabelSelectCustomer
        ' 
        LabelSelectCustomer.AutoSize = True
        LabelSelectCustomer.Font = New Font("Verdana", 12F)
        LabelSelectCustomer.Location = New Point(54, 27)
        LabelSelectCustomer.Name = "LabelSelectCustomer"
        LabelSelectCustomer.Size = New Size(142, 18)
        LabelSelectCustomer.TabIndex = 5
        LabelSelectCustomer.Text = "Select Customer"
        ' 
        ' PictureProfile
        ' 
        PictureProfile.Location = New Point(25, 23)
        PictureProfile.Name = "PictureProfile"
        PictureProfile.Size = New Size(24, 24)
        PictureProfile.SizeMode = PictureBoxSizeMode.Zoom
        PictureProfile.TabIndex = 4
        PictureProfile.TabStop = False
        ' 
        ' PanelCustomerInformation
        ' 
        PanelCustomerInformation.BackColor = Color.White
        PanelCustomerInformation.Controls.Add(Status)
        PanelCustomerInformation.Controls.Add(CurrentPlan)
        PanelCustomerInformation.Controls.Add(ServiceCompleted)
        PanelCustomerInformation.Controls.Add(TotalPaid)
        PanelCustomerInformation.Controls.Add(Email)
        PanelCustomerInformation.Controls.Add(FullName)
        PanelCustomerInformation.Controls.Add(PhoneNumber)
        PanelCustomerInformation.Controls.Add(CustomerID)
        PanelCustomerInformation.Controls.Add(LabelServiceCompleted)
        PanelCustomerInformation.Controls.Add(LabelAccountStatus)
        PanelCustomerInformation.Controls.Add(LabelTotalPaid)
        PanelCustomerInformation.Controls.Add(LabelCurrentPlan)
        PanelCustomerInformation.Controls.Add(LabelEmail)
        PanelCustomerInformation.Controls.Add(LabelFullName)
        PanelCustomerInformation.Controls.Add(LabelPhone)
        PanelCustomerInformation.Controls.Add(LabelCustomerID)
        PanelCustomerInformation.Controls.Add(Label2)
        PanelCustomerInformation.Location = New Point(43, 240)
        PanelCustomerInformation.Name = "PanelCustomerInformation"
        PanelCustomerInformation.Size = New Size(1597, 225)
        PanelCustomerInformation.TabIndex = 14
        ' 
        ' Status
        ' 
        Status.BackColor = Color.FromArgb(CByte(75), CByte(220), CByte(252), CByte(231))
        Status.Controls.Add(LabelStatus)
        Status.CornerRadius = 10
        Status.Location = New Point(1123, 97)
        Status.Name = "Status"
        Status.Size = New Size(122, 27)
        Status.TabIndex = 31
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatus.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        LabelStatus.Location = New Point(12, 3)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(55, 21)
        LabelStatus.TabIndex = 33
        LabelStatus.Text = "Status"
        ' 
        ' CurrentPlan
        ' 
        CurrentPlan.BackColor = Color.FromArgb(CByte(75), CByte(220), CByte(252), CByte(231))
        CurrentPlan.Controls.Add(PlanType)
        CurrentPlan.CornerRadius = 10
        CurrentPlan.Location = New Point(757, 97)
        CurrentPlan.Name = "CurrentPlan"
        CurrentPlan.Size = New Size(165, 27)
        CurrentPlan.TabIndex = 30
        ' 
        ' PlanType
        ' 
        PlanType.AutoSize = True
        PlanType.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PlanType.ForeColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        PlanType.Location = New Point(2, 3)
        PlanType.Name = "PlanType"
        PlanType.Size = New Size(79, 21)
        PlanType.TabIndex = 32
        PlanType.Text = "Plan Type"
        ' 
        ' ServiceCompleted
        ' 
        ServiceCompleted.AutoSize = True
        ServiceCompleted.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ServiceCompleted.Location = New Point(1123, 177)
        ServiceCompleted.Name = "ServiceCompleted"
        ServiceCompleted.Size = New Size(28, 21)
        ServiceCompleted.TabIndex = 29
        ServiceCompleted.Text = "00"
        ' 
        ' TotalPaid
        ' 
        TotalPaid.AutoSize = True
        TotalPaid.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        TotalPaid.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        TotalPaid.Location = New Point(757, 177)
        TotalPaid.Name = "TotalPaid"
        TotalPaid.Size = New Size(20, 21)
        TotalPaid.TabIndex = 27
        TotalPaid.Text = "₱"
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Email.Location = New Point(391, 177)
        Email.Name = "Email"
        Email.Size = New Size(170, 21)
        Email.TabIndex = 25
        Email.Text = "customer@gmail.com"
        ' 
        ' FullName
        ' 
        FullName.AutoSize = True
        FullName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        FullName.Location = New Point(391, 97)
        FullName.Name = "FullName"
        FullName.Size = New Size(138, 21)
        FullName.TabIndex = 24
        FullName.Text = "Customer's Name"
        ' 
        ' PhoneNumber
        ' 
        PhoneNumber.AutoSize = True
        PhoneNumber.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PhoneNumber.Location = New Point(25, 177)
        PhoneNumber.Name = "PhoneNumber"
        PhoneNumber.Size = New Size(106, 21)
        PhoneNumber.TabIndex = 23
        PhoneNumber.Text = "09123456789"
        ' 
        ' CustomerID
        ' 
        CustomerID.AutoSize = True
        CustomerID.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        CustomerID.Location = New Point(25, 97)
        CustomerID.Name = "CustomerID"
        CustomerID.Size = New Size(111, 21)
        CustomerID.TabIndex = 22
        CustomerID.Text = "Customer's ID"
        ' 
        ' LabelServiceCompleted
        ' 
        LabelServiceCompleted.AutoSize = True
        LabelServiceCompleted.Font = New Font("Segoe UI", 10F)
        LabelServiceCompleted.ForeColor = SystemColors.ControlDarkDark
        LabelServiceCompleted.Location = New Point(1123, 149)
        LabelServiceCompleted.Name = "LabelServiceCompleted"
        LabelServiceCompleted.Size = New Size(122, 19)
        LabelServiceCompleted.TabIndex = 21
        LabelServiceCompleted.Text = "Service Completed"
        ' 
        ' LabelAccountStatus
        ' 
        LabelAccountStatus.AutoSize = True
        LabelAccountStatus.Font = New Font("Segoe UI", 10F)
        LabelAccountStatus.ForeColor = SystemColors.ControlDarkDark
        LabelAccountStatus.Location = New Point(1123, 68)
        LabelAccountStatus.Name = "LabelAccountStatus"
        LabelAccountStatus.Size = New Size(101, 19)
        LabelAccountStatus.TabIndex = 20
        LabelAccountStatus.Text = "Account Status"
        ' 
        ' LabelTotalPaid
        ' 
        LabelTotalPaid.AutoSize = True
        LabelTotalPaid.Font = New Font("Segoe UI", 10F)
        LabelTotalPaid.ForeColor = SystemColors.ControlDarkDark
        LabelTotalPaid.Location = New Point(757, 149)
        LabelTotalPaid.Name = "LabelTotalPaid"
        LabelTotalPaid.Size = New Size(68, 19)
        LabelTotalPaid.TabIndex = 19
        LabelTotalPaid.Text = "Total Paid"
        ' 
        ' LabelCurrentPlan
        ' 
        LabelCurrentPlan.AutoSize = True
        LabelCurrentPlan.Font = New Font("Segoe UI", 10F)
        LabelCurrentPlan.ForeColor = SystemColors.ControlDarkDark
        LabelCurrentPlan.Location = New Point(757, 68)
        LabelCurrentPlan.Name = "LabelCurrentPlan"
        LabelCurrentPlan.Size = New Size(86, 19)
        LabelCurrentPlan.TabIndex = 18
        LabelCurrentPlan.Text = "Current Plan"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Font = New Font("Segoe UI", 10F)
        LabelEmail.ForeColor = SystemColors.ControlDarkDark
        LabelEmail.Location = New Point(391, 149)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(41, 19)
        LabelEmail.TabIndex = 17
        LabelEmail.Text = "Email"
        ' 
        ' LabelFullName
        ' 
        LabelFullName.AutoSize = True
        LabelFullName.Font = New Font("Segoe UI", 10F)
        LabelFullName.ForeColor = SystemColors.ControlDarkDark
        LabelFullName.Location = New Point(391, 68)
        LabelFullName.Name = "LabelFullName"
        LabelFullName.Size = New Size(70, 19)
        LabelFullName.TabIndex = 16
        LabelFullName.Text = "Full Name"
        ' 
        ' LabelPhone
        ' 
        LabelPhone.AutoSize = True
        LabelPhone.Font = New Font("Segoe UI", 10F)
        LabelPhone.ForeColor = SystemColors.ControlDarkDark
        LabelPhone.Location = New Point(25, 149)
        LabelPhone.Name = "LabelPhone"
        LabelPhone.Size = New Size(48, 19)
        LabelPhone.TabIndex = 15
        LabelPhone.Text = "Phone"
        ' 
        ' LabelCustomerID
        ' 
        LabelCustomerID.AutoSize = True
        LabelCustomerID.Font = New Font("Segoe UI", 10F)
        LabelCustomerID.ForeColor = SystemColors.ControlDarkDark
        LabelCustomerID.Location = New Point(25, 68)
        LabelCustomerID.Name = "LabelCustomerID"
        LabelCustomerID.Size = New Size(87, 19)
        LabelCustomerID.TabIndex = 14
        LabelCustomerID.Text = "Customer ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 12F)
        Label2.Location = New Point(25, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 18)
        Label2.TabIndex = 5
        Label2.Text = "Customer Information"
        ' 
        ' PanelPaymentServiceHistory
        ' 
        PanelPaymentServiceHistory.BackColor = Color.White
        PanelPaymentServiceHistory.Controls.Add(DataGridInstallationDetails)
        PanelPaymentServiceHistory.Controls.Add(Label1)
        PanelPaymentServiceHistory.Controls.Add(ServiceHistory)
        PanelPaymentServiceHistory.Controls.Add(IconServiceHistory)
        PanelPaymentServiceHistory.Controls.Add(PaymentHistory)
        PanelPaymentServiceHistory.Controls.Add(IconPaymentHistory)
        PanelPaymentServiceHistory.CornerRadius = 12
        PanelPaymentServiceHistory.Location = New Point(43, 506)
        PanelPaymentServiceHistory.Name = "PanelPaymentServiceHistory"
        PanelPaymentServiceHistory.Size = New Size(1597, 556)
        PanelPaymentServiceHistory.TabIndex = 15
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
        DataGridInstallationDetails.Columns.AddRange(New DataGridViewColumn() {HistoryDate, Amount, PaymentMethod, HistoryStatus, Reference})
        DataGridInstallationDetails.EnableHeadersVisualStyles = False
        DataGridInstallationDetails.GridColor = Color.White
        DataGridInstallationDetails.Location = New Point(25, 123)
        DataGridInstallationDetails.Name = "DataGridInstallationDetails"
        DataGridInstallationDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridInstallationDetails.RowHeadersVisible = False
        DataGridInstallationDetails.RowTemplate.Height = 40
        DataGridInstallationDetails.ScrollBars = ScrollBars.Vertical
        DataGridInstallationDetails.Size = New Size(1548, 426)
        DataGridInstallationDetails.TabIndex = 31
        ' 
        ' HistoryDate
        ' 
        HistoryDate.Frozen = True
        HistoryDate.HeaderText = "Date"
        HistoryDate.Name = "HistoryDate"
        HistoryDate.ReadOnly = True
        HistoryDate.Width = 309
        ' 
        ' Amount
        ' 
        Amount.HeaderText = "Amount"
        Amount.Name = "Amount"
        Amount.ReadOnly = True
        Amount.Width = 309
        ' 
        ' PaymentMethod
        ' 
        PaymentMethod.HeaderText = "Payment Method"
        PaymentMethod.Name = "PaymentMethod"
        PaymentMethod.ReadOnly = True
        PaymentMethod.Width = 309
        ' 
        ' HistoryStatus
        ' 
        HistoryStatus.HeaderText = "Status"
        HistoryStatus.Name = "HistoryStatus"
        HistoryStatus.ReadOnly = True
        HistoryStatus.Width = 309
        ' 
        ' Reference
        ' 
        Reference.HeaderText = "Reference"
        Reference.Name = "Reference"
        Reference.Width = 309
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        Label1.Location = New Point(37, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 30
        Label1.Text = "Payment History"
        ' 
        ' ServiceHistory
        ' 
        ServiceHistory.AutoSize = True
        ServiceHistory.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ServiceHistory.Location = New Point(943, 27)
        ServiceHistory.Name = "ServiceHistory"
        ServiceHistory.Size = New Size(122, 21)
        ServiceHistory.TabIndex = 28
        ServiceHistory.Text = "Service History"
        ' 
        ' IconServiceHistory
        ' 
        IconServiceHistory.Location = New Point(909, 24)
        IconServiceHistory.Name = "IconServiceHistory"
        IconServiceHistory.Size = New Size(28, 28)
        IconServiceHistory.SizeMode = PictureBoxSizeMode.Zoom
        IconServiceHistory.TabIndex = 27
        IconServiceHistory.TabStop = False
        ' 
        ' PaymentHistory
        ' 
        PaymentHistory.AutoSize = True
        PaymentHistory.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        PaymentHistory.Location = New Point(406, 27)
        PaymentHistory.Name = "PaymentHistory"
        PaymentHistory.Size = New Size(131, 21)
        PaymentHistory.TabIndex = 26
        PaymentHistory.Text = "Payment History"
        ' 
        ' IconPaymentHistory
        ' 
        IconPaymentHistory.Location = New Point(369, 24)
        IconPaymentHistory.Name = "IconPaymentHistory"
        IconPaymentHistory.Size = New Size(28, 28)
        IconPaymentHistory.SizeMode = PictureBoxSizeMode.Zoom
        IconPaymentHistory.TabIndex = 0
        IconPaymentHistory.TabStop = False
        ' 
        ' PanelTotalPayment
        ' 
        PanelTotalPayment.BackColor = Color.White
        PanelTotalPayment.Controls.Add(PictureBox1)
        PanelTotalPayment.Controls.Add(ValueTotalPayment)
        PanelTotalPayment.Controls.Add(LabelTotalPayment)
        PanelTotalPayment.CornerRadius = 12
        PanelTotalPayment.Location = New Point(43, 1106)
        PanelTotalPayment.Name = "PanelTotalPayment"
        PanelTotalPayment.Size = New Size(480, 177)
        PanelTotalPayment.TabIndex = 16
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(384, 62)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' ValueTotalPayment
        ' 
        ValueTotalPayment.AutoSize = True
        ValueTotalPayment.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ValueTotalPayment.ForeColor = Color.FromArgb(CByte(0), CByte(166), CByte(62))
        ValueTotalPayment.Location = New Point(25, 81)
        ValueTotalPayment.Name = "ValueTotalPayment"
        ValueTotalPayment.Size = New Size(58, 46)
        ValueTotalPayment.TabIndex = 32
        ValueTotalPayment.Text = "00"
        ' 
        ' LabelTotalPayment
        ' 
        LabelTotalPayment.AutoSize = True
        LabelTotalPayment.Font = New Font("Segoe UI", 14F)
        LabelTotalPayment.ForeColor = SystemColors.ControlDarkDark
        LabelTotalPayment.Location = New Point(25, 26)
        LabelTotalPayment.Name = "LabelTotalPayment"
        LabelTotalPayment.Size = New Size(129, 25)
        LabelTotalPayment.TabIndex = 31
        LabelTotalPayment.Text = "Total Payment"
        ' 
        ' PanelServiceRequests
        ' 
        PanelServiceRequests.BackColor = Color.White
        PanelServiceRequests.Controls.Add(PictureBox2)
        PanelServiceRequests.Controls.Add(ValueServiceRequests)
        PanelServiceRequests.Controls.Add(LabelServiceRequests)
        PanelServiceRequests.CornerRadius = 12
        PanelServiceRequests.Location = New Point(602, 1106)
        PanelServiceRequests.Name = "PanelServiceRequests"
        PanelServiceRequests.Size = New Size(480, 177)
        PanelServiceRequests.TabIndex = 17
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(384, 62)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(72, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 34
        PictureBox2.TabStop = False
        ' 
        ' ValueServiceRequests
        ' 
        ValueServiceRequests.AutoSize = True
        ValueServiceRequests.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ValueServiceRequests.ForeColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        ValueServiceRequests.Location = New Point(25, 81)
        ValueServiceRequests.Name = "ValueServiceRequests"
        ValueServiceRequests.Size = New Size(58, 46)
        ValueServiceRequests.TabIndex = 33
        ValueServiceRequests.Text = "00"
        ' 
        ' LabelServiceRequests
        ' 
        LabelServiceRequests.AutoSize = True
        LabelServiceRequests.Font = New Font("Segoe UI", 14F)
        LabelServiceRequests.ForeColor = SystemColors.ControlDarkDark
        LabelServiceRequests.Location = New Point(25, 26)
        LabelServiceRequests.Name = "LabelServiceRequests"
        LabelServiceRequests.Size = New Size(151, 25)
        LabelServiceRequests.TabIndex = 32
        LabelServiceRequests.Text = "Service Requests"
        ' 
        ' PanelAccountAge
        ' 
        PanelAccountAge.BackColor = Color.White
        PanelAccountAge.Controls.Add(PictureBox3)
        PanelAccountAge.Controls.Add(Months)
        PanelAccountAge.Controls.Add(DurationMonths)
        PanelAccountAge.Controls.Add(LabelAccountAge)
        PanelAccountAge.CornerRadius = 12
        PanelAccountAge.Location = New Point(1160, 1106)
        PanelAccountAge.Name = "PanelAccountAge"
        PanelAccountAge.Size = New Size(480, 177)
        PanelAccountAge.TabIndex = 18
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(384, 62)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(72, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 35
        PictureBox3.TabStop = False
        ' 
        ' Months
        ' 
        Months.AutoSize = True
        Months.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        Months.ForeColor = Color.FromArgb(CByte(254), CByte(73), CByte(0))
        Months.Location = New Point(89, 81)
        Months.Name = "Months"
        Months.Size = New Size(137, 46)
        Months.TabIndex = 35
        Months.Text = "months"
        ' 
        ' DurationMonths
        ' 
        DurationMonths.AutoSize = True
        DurationMonths.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        DurationMonths.ForeColor = Color.FromArgb(CByte(254), CByte(73), CByte(0))
        DurationMonths.Location = New Point(25, 81)
        DurationMonths.Name = "DurationMonths"
        DurationMonths.Size = New Size(58, 46)
        DurationMonths.TabIndex = 34
        DurationMonths.Text = "00"
        ' 
        ' LabelAccountAge
        ' 
        LabelAccountAge.AutoSize = True
        LabelAccountAge.Font = New Font("Segoe UI", 14F)
        LabelAccountAge.ForeColor = SystemColors.ControlDarkDark
        LabelAccountAge.Location = New Point(25, 26)
        LabelAccountAge.Name = "LabelAccountAge"
        LabelAccountAge.Size = New Size(119, 25)
        LabelAccountAge.TabIndex = 33
        LabelAccountAge.Text = "Account Age"
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Location = New Point(43, 1309)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 49)
        PanelRound1.TabIndex = 44
        ' 
        ' AdminHistory
        ' 
        AccessibleRole = AccessibleRole.TitleBar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound1)
        Controls.Add(PanelAccountAge)
        Controls.Add(PanelServiceRequests)
        Controls.Add(PanelTotalPayment)
        Controls.Add(PanelPaymentServiceHistory)
        Controls.Add(PanelCustomerInformation)
        Controls.Add(PanelSelectCustomer)
        Controls.Add(HeaderIndividualCustomerHistory)
        Name = "AdminHistory"
        Size = New Size(1940, 1692)
        PanelSelectCustomer.ResumeLayout(False)
        PanelSelectCustomer.PerformLayout()
        CType(PictureProfile, ComponentModel.ISupportInitialize).EndInit()
        PanelCustomerInformation.ResumeLayout(False)
        PanelCustomerInformation.PerformLayout()
        Status.ResumeLayout(False)
        Status.PerformLayout()
        CurrentPlan.ResumeLayout(False)
        CurrentPlan.PerformLayout()
        PanelPaymentServiceHistory.ResumeLayout(False)
        PanelPaymentServiceHistory.PerformLayout()
        CType(DataGridInstallationDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(IconServiceHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(IconPaymentHistory, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalPayment.ResumeLayout(False)
        PanelTotalPayment.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelServiceRequests.ResumeLayout(False)
        PanelServiceRequests.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelAccountAge.ResumeLayout(False)
        PanelAccountAge.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderIndividualCustomerHistory As Label
    Friend WithEvents PanelSelectCustomer As PanelRound
    Friend WithEvents LabelSelectCustomer As Label
    Friend WithEvents PictureProfile As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelCustomer As Label
    Friend WithEvents PanelCustomerInformation As PanelRound
    Friend WithEvents LabelCustomerID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelServiceCompleted As Label
    Friend WithEvents LabelAccountStatus As Label
    Friend WithEvents LabelTotalPaid As Label
    Friend WithEvents LabelCurrentPlan As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelFullName As Label
    Friend WithEvents LabelPhone As Label
    Friend WithEvents CustomerID As Label
    Friend WithEvents ServiceCompleted As Label
    Friend WithEvents TotalPaid As Label
    Friend WithEvents Email As Label
    Friend WithEvents FullName As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents CurrentPlan As PanelRound
    Friend WithEvents Status As PanelRound
    Friend WithEvents PlanType As Label
    Friend WithEvents LabelStatus As Label
    Friend WithEvents PanelPaymentServiceHistory As PanelRound
    Friend WithEvents ServiceHistory As Label
    Friend WithEvents IconServiceHistory As PictureBox
    Friend WithEvents PaymentHistory As Label
    Friend WithEvents IconPaymentHistory As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridInstallationDetails As DataGridView
    Friend WithEvents HistoryDate As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethod As DataGridViewTextBoxColumn
    Friend WithEvents HistoryStatus As DataGridViewTextBoxColumn
    Friend WithEvents Reference As DataGridViewTextBoxColumn
    Friend WithEvents PanelTotalPayment As PanelRound
    Friend WithEvents ValueTotalPayment As Label
    Friend WithEvents LabelTotalPayment As Label
    Friend WithEvents PanelServiceRequests As PanelRound
    Friend WithEvents ValueServiceRequests As Label
    Friend WithEvents LabelServiceRequests As Label
    Friend WithEvents PanelAccountAge As PanelRound
    Friend WithEvents Months As Label
    Friend WithEvents DurationMonths As Label
    Friend WithEvents LabelAccountAge As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PanelRound1 As PanelRound

End Class
