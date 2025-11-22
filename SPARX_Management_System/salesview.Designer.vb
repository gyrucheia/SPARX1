<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesview
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing Then
                ' Clean up timer
                If updateTimer IsNot Nothing Then
                    updateTimer.Stop()
                    updateTimer.Dispose()
                End If

                ' Clean up components
                If components IsNot Nothing Then
                    components.Dispose()
                End If
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesview))
        GBRecentSalesDetails = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        dgvRecentSales = New DataGridView()
        colCustomerID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colDateInstalled = New DataGridViewTextBoxColumn()
        colPlanType = New DataGridViewTextBoxColumn()
        colMonthlyRate = New DataGridViewTextBoxColumn()
        AvgRev = New Label()
        LblAvgRev = New Label()
        pnlAvgRev = New PanelRound()
        MonthlyRev = New Label()
        LblTotalMonthlyRev = New Label()
        TotalSales = New Label()
        LblTotalNewSales = New Label()
        pnlTotalNewSales = New PanelRound()
        LblMonthlySalesVolume = New Label()
        pnlTotalMonthlyRev = New PanelRound()
        CBPlanType = New ComboBox()
        CBDateRange = New ComboBox()
        LblPlanType = New Label()
        LblDateRange = New Label()
        LblFilters = New Label()
        btnExport = New ButtonRounded()
        pnlMonthlySalesVol = New PanelRound()
        PanelRound1 = New PanelRound()
        PnlFilters = New PanelRound()
        LblSalesReport = New Label()
        GBRecentSalesDetails.SuspendLayout()
        CType(dgvRecentSales, ComponentModel.ISupportInitialize).BeginInit()
        pnlAvgRev.SuspendLayout()
        pnlTotalNewSales.SuspendLayout()
        pnlTotalMonthlyRev.SuspendLayout()
        pnlMonthlySalesVol.SuspendLayout()
        PnlFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' GBRecentSalesDetails
        ' 
        GBRecentSalesDetails.BackColor = Color.White
        GBRecentSalesDetails.Controls.Add(dgvRecentSales)
        GBRecentSalesDetails.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        GBRecentSalesDetails.Location = New Point(24, 853)
        GBRecentSalesDetails.Margin = New Padding(3, 2, 3, 2)
        GBRecentSalesDetails.Name = "GBRecentSalesDetails"
        GBRecentSalesDetails.Padding = New Padding(3, 2, 3, 2)
        GBRecentSalesDetails.Size = New Size(1349, 497)
        GBRecentSalesDetails.TabIndex = 18
        GBRecentSalesDetails.TabStop = False
        GBRecentSalesDetails.Text = "Recent Sales Details"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 5
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.2953033F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.7046967F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 281.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 261.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 347.0F))
        TableLayoutPanel1.Location = New Point(6, 76)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 128.0F))
        TableLayoutPanel1.Size = New Size(1325, 416)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' dgvRecentSales
        ' 
        dgvRecentSales.AllowUserToAddRows = False
        dgvRecentSales.AllowUserToDeleteRows = False
        dgvRecentSales.AllowUserToResizeColumns = False
        dgvRecentSales.AllowUserToResizeRows = False
        dgvRecentSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentSales.BackgroundColor = Color.White
        dgvRecentSales.BorderStyle = BorderStyle.None
        dgvRecentSales.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgvRecentSales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(10, 0, 10, 0)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvRecentSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRecentSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentSales.Columns.AddRange(New DataGridViewColumn() {colCustomerID, colName, colDateInstalled, colPlanType, colMonthlyRate})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Window
        DataGridViewCellStyle7.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.White
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgvRecentSales.DefaultCellStyle = DataGridViewCellStyle7
        dgvRecentSales.Enabled = False
        dgvRecentSales.EnableHeadersVisualStyles = False
        dgvRecentSales.GridColor = Color.FromArgb(224, 224, 224)
        dgvRecentSales.Dock = DockStyle.Fill
        dgvRecentSales.Margin = New Padding(3, 2, 3, 2)
        dgvRecentSales.Name = "dgvRecentSales"
        dgvRecentSales.ReadOnly = True
        dgvRecentSales.ScrollBars = ScrollBars.Vertical
        dgvRecentSales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.White
        DataGridViewCellStyle8.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.White
        DataGridViewCellStyle8.SelectionForeColor = Color.Black
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvRecentSales.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvRecentSales.RowHeadersVisible = False
        dgvRecentSales.RowHeadersWidth = 51
        dgvRecentSales.RowTemplate.Height = 37
        dgvRecentSales.Size = New Size(1344, 450)
        dgvRecentSales.TabIndex = 0
        dgvRecentSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ' 
        ' colCustomerID
        ' 
        colCustomerID.DataPropertyName = "CustomerID"
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle2.Padding = New Padding(10, 0, 10, 0)
        colCustomerID.DefaultCellStyle = DataGridViewCellStyle2
        colCustomerID.HeaderText = "Customer ID"
        colCustomerID.MinimumWidth = 6
        colCustomerID.Name = "colCustomerID"
        colCustomerID.ReadOnly = True
        ' 
        ' colName
        ' 
        colName.DataPropertyName = "Name"
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle3.Padding = New Padding(10, 0, 10, 0)
        colName.DefaultCellStyle = DataGridViewCellStyle3
        colName.HeaderText = "Name"
        colName.MinimumWidth = 6
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colDateInstalled
        ' 
        colDateInstalled.DataPropertyName = "DateInstalled"
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle4.Padding = New Padding(10, 0, 10, 0)
        colDateInstalled.DefaultCellStyle = DataGridViewCellStyle4
        colDateInstalled.HeaderText = "Date Installed"
        colDateInstalled.MinimumWidth = 6
        colDateInstalled.Name = "colDateInstalled"
        colDateInstalled.ReadOnly = True
        ' 
        ' colPlanType
        ' 
        colPlanType.DataPropertyName = "PlanType"
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle5.Padding = New Padding(10, 0, 10, 0)
        colPlanType.DefaultCellStyle = DataGridViewCellStyle5
        colPlanType.HeaderText = "Plan Type"
        colPlanType.MinimumWidth = 6
        colPlanType.Name = "colPlanType"
        colPlanType.ReadOnly = True
        ' 
        ' colMonthlyRate
        ' 
        colMonthlyRate.DataPropertyName = "MonthlyRate"
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(0, 192, 0)
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.Padding = New Padding(10, 0, 10, 0)
        colMonthlyRate.DefaultCellStyle = DataGridViewCellStyle6
        colMonthlyRate.HeaderText = "Monthly Rate"
        colMonthlyRate.MinimumWidth = 6
        colMonthlyRate.Name = "colMonthlyRate"
        colMonthlyRate.ReadOnly = True
        ' 
        ' AvgRev
        ' 
        AvgRev.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        AvgRev.AutoSize = True
        AvgRev.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        AvgRev.ForeColor = Color.FromArgb(255, 128, 0)
        AvgRev.Location = New Point(172, 52)
        AvgRev.Name = "AvgRev"
        AvgRev.Size = New Size(57, 20)
        AvgRev.TabIndex = 8
        AvgRev.Text = "999999"
        AvgRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblAvgRev
        ' 
        LblAvgRev.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblAvgRev.AutoSize = True
        LblAvgRev.Location = New Point(142, 12)
        LblAvgRev.Name = "LblAvgRev"
        LblAvgRev.Size = New Size(120, 15)
        LblAvgRev.TabIndex = 8
        LblAvgRev.Text = "Avg Revenue Per Sale"
        LblAvgRev.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlAvgRev
        ' 
        pnlAvgRev.BackColor = Color.White
        pnlAvgRev.Controls.Add(AvgRev)
        pnlAvgRev.Controls.Add(LblAvgRev)
        pnlAvgRev.Location = New Point(965, 205)
        pnlAvgRev.Margin = New Padding(3, 2, 3, 2)
        pnlAvgRev.Name = "pnlAvgRev"
        pnlAvgRev.Size = New Size(412, 112)
        pnlAvgRev.TabIndex = 20
        ' 
        ' MonthlyRev
        ' 
        MonthlyRev.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MonthlyRev.AutoSize = True
        MonthlyRev.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        MonthlyRev.ForeColor = Color.FromArgb(0, 192, 0)
        MonthlyRev.Location = New Point(165, 52)
        MonthlyRev.Name = "MonthlyRev"
        MonthlyRev.Size = New Size(57, 20)
        MonthlyRev.TabIndex = 7
        MonthlyRev.Text = "999999"
        MonthlyRev.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalMonthlyRev
        ' 
        LblTotalMonthlyRev.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTotalMonthlyRev.AutoSize = True
        LblTotalMonthlyRev.Location = New Point(130, 12)
        LblTotalMonthlyRev.Name = "LblTotalMonthlyRev"
        LblTotalMonthlyRev.Size = New Size(128, 15)
        LblTotalMonthlyRev.TabIndex = 7
        LblTotalMonthlyRev.Text = "Total Monthly Revenue"
        LblTotalMonthlyRev.TextAlign = ContentAlignment.TopCenter
        ' 
        ' TotalSales
        ' 
        TotalSales.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TotalSales.AutoSize = True
        TotalSales.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        TotalSales.ForeColor = Color.Blue
        TotalSales.Location = New Point(165, 52)
        TotalSales.Name = "TotalSales"
        TotalSales.Size = New Size(57, 20)
        TotalSales.TabIndex = 6
        TotalSales.Text = "999999"
        TotalSales.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTotalNewSales
        ' 
        LblTotalNewSales.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        LblTotalNewSales.AutoSize = True
        LblTotalNewSales.Location = New Point(144, 12)
        LblTotalNewSales.Name = "LblTotalNewSales"
        LblTotalNewSales.Size = New Size(88, 15)
        LblTotalNewSales.TabIndex = 5
        LblTotalNewSales.Text = "Total New Sales"
        LblTotalNewSales.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlTotalNewSales
        ' 
        pnlTotalNewSales.BackColor = Color.White
        pnlTotalNewSales.Controls.Add(TotalSales)
        pnlTotalNewSales.Controls.Add(LblTotalNewSales)
        pnlTotalNewSales.Location = New Point(27, 205)
        pnlTotalNewSales.Margin = New Padding(3, 2, 3, 2)
        pnlTotalNewSales.Name = "pnlTotalNewSales"
        pnlTotalNewSales.Size = New Size(412, 112)
        pnlTotalNewSales.TabIndex = 19
        ' 
        ' LblMonthlySalesVolume
        ' 
        LblMonthlySalesVolume.AutoSize = True
        LblMonthlySalesVolume.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LblMonthlySalesVolume.ImageAlign = ContentAlignment.MiddleLeft
        LblMonthlySalesVolume.Location = New Point(28, 19)
        LblMonthlySalesVolume.Name = "LblMonthlySalesVolume"
        LblMonthlySalesVolume.Size = New Size(126, 15)
        LblMonthlySalesVolume.TabIndex = 5
        LblMonthlySalesVolume.Text = "Monthly Sales Volume"
        ' 
        ' pnlTotalMonthlyRev
        ' 
        pnlTotalMonthlyRev.BackColor = Color.White
        pnlTotalMonthlyRev.Controls.Add(MonthlyRev)
        pnlTotalMonthlyRev.Controls.Add(LblTotalMonthlyRev)
        pnlTotalMonthlyRev.Location = New Point(496, 205)
        pnlTotalMonthlyRev.Margin = New Padding(3, 2, 3, 2)
        pnlTotalMonthlyRev.Name = "pnlTotalMonthlyRev"
        pnlTotalMonthlyRev.Size = New Size(412, 112)
        pnlTotalMonthlyRev.TabIndex = 21
        ' 
        ' CBPlanType
        ' 
        CBPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        CBPlanType.FormattingEnabled = True
        CBPlanType.Items.AddRange(New Object() {"All Plans", "Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})
        CBPlanType.Location = New Point(228, 64)
        CBPlanType.Margin = New Padding(3, 2, 3, 2)
        CBPlanType.Name = "CBPlanType"
        CBPlanType.Size = New Size(151, 23)
        CBPlanType.TabIndex = 4
        ' 
        ' CBDateRange
        ' 
        CBDateRange.DropDownStyle = ComboBoxStyle.DropDownList
        CBDateRange.FormattingEnabled = True
        CBDateRange.Items.AddRange(New Object() {"All Time", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        CBDateRange.Location = New Point(30, 64)
        CBDateRange.Margin = New Padding(3, 2, 3, 2)
        CBDateRange.Name = "CBDateRange"
        CBDateRange.Size = New Size(151, 23)
        CBDateRange.TabIndex = 3
        ' 
        ' LblPlanType
        ' 
        LblPlanType.AutoSize = True
        LblPlanType.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LblPlanType.Location = New Point(228, 46)
        LblPlanType.Name = "LblPlanType"
        LblPlanType.Size = New Size(58, 15)
        LblPlanType.TabIndex = 2
        LblPlanType.Text = "Plan Type"
        ' 
        ' LblDateRange
        ' 
        LblDateRange.AutoSize = True
        LblDateRange.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LblDateRange.Location = New Point(30, 46)
        LblDateRange.Name = "LblDateRange"
        LblDateRange.Size = New Size(68, 15)
        LblDateRange.TabIndex = 1
        LblDateRange.Text = "Date Range"
        ' 
        ' LblFilters
        ' 
        LblFilters.AutoSize = True
        LblFilters.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LblFilters.Image = CType(resources.GetObject("LblFilters.Image"), Image)
        LblFilters.ImageAlign = ContentAlignment.MiddleLeft
        LblFilters.Location = New Point(26, 15)
        LblFilters.Name = "LblFilters"
        LblFilters.Size = New Size(62, 15)
        LblFilters.TabIndex = 0
        LblFilters.Text = "        Filters"
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnExport.BackColor = Color.FromArgb(70, 130, 255)
        btnExport.CornerRadius = 8
        btnExport.Cursor = Cursors.Hand
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Font = New Font("Segoe UI", 12.0F)
        btnExport.ForeColor = Color.White
        btnExport.ImageAlign = ContentAlignment.MiddleLeft
        btnExport.Location = New Point(1255, 29)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(125, 26)
        btnExport.TabIndex = 22
        btnExport.Text = "Export Report"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' pnlMonthlySalesVol
        ' 
        pnlMonthlySalesVol.BackColor = Color.White
        pnlMonthlySalesVol.Controls.Add(PanelRound1)
        pnlMonthlySalesVol.Controls.Add(LblMonthlySalesVolume)
        pnlMonthlySalesVol.Location = New Point(27, 357)
        pnlMonthlySalesVol.Margin = New Padding(3, 2, 3, 2)
        pnlMonthlySalesVol.Name = "pnlMonthlySalesVol"
        pnlMonthlySalesVol.Size = New Size(1353, 459)
        pnlMonthlySalesVol.TabIndex = 17
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Location = New Point(3, 51)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1354, 365)
        PanelRound1.TabIndex = 23
        ' 
        ' PnlFilters
        ' 
        PnlFilters.BackColor = Color.White
        PnlFilters.Controls.Add(CBPlanType)
        PnlFilters.Controls.Add(CBDateRange)
        PnlFilters.Controls.Add(LblPlanType)
        PnlFilters.Controls.Add(LblDateRange)
        PnlFilters.Controls.Add(LblFilters)
        PnlFilters.Location = New Point(30, 59)
        PnlFilters.Margin = New Padding(3, 2, 3, 2)
        PnlFilters.Name = "PnlFilters"
        PnlFilters.Size = New Size(1354, 112)
        PnlFilters.TabIndex = 16
        ' 
        ' LblSalesReport
        ' 
        LblSalesReport.AutoSize = True
        LblSalesReport.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0)
        LblSalesReport.Location = New Point(24, 17)
        LblSalesReport.Name = "LblSalesReport"
        LblSalesReport.Size = New Size(93, 20)
        LblSalesReport.TabIndex = 15
        LblSalesReport.Text = "Sales Report"
        ' 
        ' salesview
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = SystemColors.Control
        Controls.Add(GBRecentSalesDetails)
        Controls.Add(pnlAvgRev)
        Controls.Add(pnlTotalNewSales)
        Controls.Add(pnlTotalMonthlyRev)
        Controls.Add(btnExport)
        Controls.Add(pnlMonthlySalesVol)
        Controls.Add(PnlFilters)
        Controls.Add(LblSalesReport)
        Name = "salesview"
        Size = New Size(1408, 1367)
        GBRecentSalesDetails.ResumeLayout(False)
        CType(dgvRecentSales, ComponentModel.ISupportInitialize).EndInit()
        pnlAvgRev.ResumeLayout(False)
        pnlAvgRev.PerformLayout()
        pnlTotalNewSales.ResumeLayout(False)
        pnlTotalNewSales.PerformLayout()
        pnlTotalMonthlyRev.ResumeLayout(False)
        pnlTotalMonthlyRev.PerformLayout()
        pnlMonthlySalesVol.ResumeLayout(False)
        pnlMonthlySalesVol.PerformLayout()
        PnlFilters.ResumeLayout(False)
        PnlFilters.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblSalesReport As Label
    Friend WithEvents PnlFilters As PanelRound
    Friend WithEvents CBDateRange As ComboBox
    Friend WithEvents LblPlanType As Label
    Friend WithEvents LblDateRange As Label
    Friend WithEvents LblFilters As Label
    Friend WithEvents CBPlanType As ComboBox
    Friend WithEvents pnlMonthlySalesVol As PanelRound
    Friend WithEvents dgvRecentSales As DataGridView
    Friend WithEvents pnlTotalNewSales As PanelRound
    Friend WithEvents pnlTotalMonthlyRev As PanelRound
    Friend WithEvents pnlAvgRev As PanelRound
    Friend WithEvents TotalSales As Label
    Friend WithEvents LblTotalNewSales As Label
    Friend WithEvents MonthlyRev As Label
    Friend WithEvents LblTotalMonthlyRev As Label
    Friend WithEvents AvgRev As Label
    Friend WithEvents LblAvgRev As Label
    Friend WithEvents btnExport As ButtonRounded
    Friend WithEvents LblMonthlySalesVolume As Label
    Friend WithEvents GBRecentSalesDetails As GroupBox
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colDateInstalled As DataGridViewTextBoxColumn
    Friend WithEvents colPlanType As DataGridViewTextBoxColumn
    Friend WithEvents colMonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
