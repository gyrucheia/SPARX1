<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminSales))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderSalesReport = New Label()
        ComboBoxTechnician = New ComboBox()
        ComboBoxDateRange = New ComboBox()
        LabelTechnician = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelFilters = New PanelRound()
        PanelRound1 = New PanelRound()
        ValueNewSales = New Label()
        TotalNewSales = New Label()
        PanelRound2 = New PanelRound()
        ValueRevenuePerSale = New Label()
        Label4 = New Label()
        PanelRound3 = New PanelRound()
        ValueMonthlyRevenue = New Label()
        Label3 = New Label()
        PanelMonthlySalesVolume = New PanelRound()
        MonthlySalesVolume = New Label()
        PanelRecentSalesDetails = New PanelRound()
        DataGridrecentSalesDetails = New DataGridView()
        CustomerID = New DataGridViewTextBoxColumn()
        CustomerName = New DataGridViewTextBoxColumn()
        DateInstalled = New DataGridViewTextBoxColumn()
        PlanType = New DataGridViewTextBoxColumn()
        MonthlyRate = New DataGridViewTextBoxColumn()
        LabelRecentSalesDetails = New Label()
        PanelRound4 = New PanelRound()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelFilters.SuspendLayout()
        PanelRound1.SuspendLayout()
        PanelRound2.SuspendLayout()
        PanelRound3.SuspendLayout()
        PanelMonthlySalesVolume.SuspendLayout()
        PanelRecentSalesDetails.SuspendLayout()
        CType(DataGridrecentSalesDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderSalesReport
        ' 
        HeaderSalesReport.AutoSize = True
        HeaderSalesReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderSalesReport.Location = New Point(43, 18)
        HeaderSalesReport.Name = "HeaderSalesReport"
        HeaderSalesReport.Size = New Size(125, 28)
        HeaderSalesReport.TabIndex = 3
        HeaderSalesReport.Text = "Sales Report"
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
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(ComboBoxTechnician)
        PanelFilters.Controls.Add(ComboBoxDateRange)
        PanelFilters.Controls.Add(LabelTechnician)
        PanelFilters.Controls.Add(Label2)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 65)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 4
        ' 
        ' PanelRound1
        ' 
        PanelRound1.AutoScroll = True
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(ValueNewSales)
        PanelRound1.Controls.Add(TotalNewSales)
        PanelRound1.CornerRadius = 12
        PanelRound1.Location = New Point(36, 272)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(505, 245)
        PanelRound1.TabIndex = 5
        ' 
        ' ValueNewSales
        ' 
        ValueNewSales.AutoSize = True
        ValueNewSales.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ValueNewSales.ForeColor = Color.Blue
        ValueNewSales.Location = New Point(211, 104)
        ValueNewSales.Name = "ValueNewSales"
        ValueNewSales.Size = New Size(58, 46)
        ValueNewSales.TabIndex = 11
        ValueNewSales.Text = "00"
        ' 
        ' TotalNewSales
        ' 
        TotalNewSales.AutoSize = True
        TotalNewSales.Font = New Font("Verdana", 12F)
        TotalNewSales.ForeColor = SystemColors.ControlDarkDark
        TotalNewSales.Location = New Point(173, 63)
        TotalNewSales.Name = "TotalNewSales"
        TotalNewSales.Size = New Size(139, 18)
        TotalNewSales.TabIndex = 9
        TotalNewSales.Text = "Total New Sales"
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = Color.White
        PanelRound2.Controls.Add(ValueRevenuePerSale)
        PanelRound2.Controls.Add(Label4)
        PanelRound2.CornerRadius = 12
        PanelRound2.Location = New Point(1135, 269)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(505, 245)
        PanelRound2.TabIndex = 6
        ' 
        ' ValueRevenuePerSale
        ' 
        ValueRevenuePerSale.AutoSize = True
        ValueRevenuePerSale.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ValueRevenuePerSale.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ValueRevenuePerSale.Location = New Point(240, 104)
        ValueRevenuePerSale.Name = "ValueRevenuePerSale"
        ValueRevenuePerSale.Size = New Size(41, 46)
        ValueRevenuePerSale.TabIndex = 13
        ValueRevenuePerSale.Text = "₱"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 12F)
        Label4.ForeColor = SystemColors.ControlDarkDark
        Label4.Location = New Point(164, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 18)
        Label4.TabIndex = 11
        Label4.Text = "Ave Revenue Per Sale"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = Color.White
        PanelRound3.Controls.Add(ValueMonthlyRevenue)
        PanelRound3.Controls.Add(Label3)
        PanelRound3.CornerRadius = 12
        PanelRound3.Location = New Point(592, 269)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(505, 245)
        PanelRound3.TabIndex = 7
        ' 
        ' ValueMonthlyRevenue
        ' 
        ValueMonthlyRevenue.AutoSize = True
        ValueMonthlyRevenue.Font = New Font("Segoe UI Semibold", 25F, FontStyle.Bold)
        ValueMonthlyRevenue.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ValueMonthlyRevenue.Location = New Point(215, 104)
        ValueMonthlyRevenue.Name = "ValueMonthlyRevenue"
        ValueMonthlyRevenue.Size = New Size(41, 46)
        ValueMonthlyRevenue.TabIndex = 12
        ValueMonthlyRevenue.Text = "₱"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 12F)
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(152, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 18)
        Label3.TabIndex = 10
        Label3.Text = "Total Monthly Revenue"
        ' 
        ' PanelMonthlySalesVolume
        ' 
        PanelMonthlySalesVolume.BackColor = Color.White
        PanelMonthlySalesVolume.Controls.Add(MonthlySalesVolume)
        PanelMonthlySalesVolume.CornerRadius = 12
        PanelMonthlySalesVolume.Location = New Point(43, 556)
        PanelMonthlySalesVolume.Name = "PanelMonthlySalesVolume"
        PanelMonthlySalesVolume.Size = New Size(1597, 512)
        PanelMonthlySalesVolume.TabIndex = 10
        ' 
        ' MonthlySalesVolume
        ' 
        MonthlySalesVolume.AutoSize = True
        MonthlySalesVolume.Font = New Font("Verdana", 12F)
        MonthlySalesVolume.Location = New Point(22, 21)
        MonthlySalesVolume.Name = "MonthlySalesVolume"
        MonthlySalesVolume.Size = New Size(188, 18)
        MonthlySalesVolume.TabIndex = 11
        MonthlySalesVolume.Text = "Monthly Sales Volume"
        ' 
        ' PanelRecentSalesDetails
        ' 
        PanelRecentSalesDetails.BackColor = Color.White
        PanelRecentSalesDetails.Controls.Add(DataGridrecentSalesDetails)
        PanelRecentSalesDetails.Controls.Add(LabelRecentSalesDetails)
        PanelRecentSalesDetails.CornerRadius = 12
        PanelRecentSalesDetails.Location = New Point(43, 1107)
        PanelRecentSalesDetails.Name = "PanelRecentSalesDetails"
        PanelRecentSalesDetails.Size = New Size(1597, 606)
        PanelRecentSalesDetails.TabIndex = 11
        ' 
        ' DataGridrecentSalesDetails
        ' 
        DataGridrecentSalesDetails.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridrecentSalesDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridrecentSalesDetails.BackgroundColor = Color.White
        DataGridrecentSalesDetails.BorderStyle = BorderStyle.None
        DataGridrecentSalesDetails.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridrecentSalesDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Verdana", 11F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridrecentSalesDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridrecentSalesDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridrecentSalesDetails.Columns.AddRange(New DataGridViewColumn() {CustomerID, CustomerName, DateInstalled, PlanType, MonthlyRate})
        DataGridrecentSalesDetails.EnableHeadersVisualStyles = False
        DataGridrecentSalesDetails.GridColor = Color.White
        DataGridrecentSalesDetails.Location = New Point(9, 56)
        DataGridrecentSalesDetails.Name = "DataGridrecentSalesDetails"
        DataGridrecentSalesDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridrecentSalesDetails.RowHeadersVisible = False
        DataGridrecentSalesDetails.RowTemplate.Height = 40
        DataGridrecentSalesDetails.ScrollBars = ScrollBars.Vertical
        DataGridrecentSalesDetails.Size = New Size(1578, 503)
        DataGridrecentSalesDetails.TabIndex = 24
        ' 
        ' CustomerID
        ' 
        CustomerID.Frozen = True
        CustomerID.HeaderText = "Customer ID"
        CustomerID.Name = "CustomerID"
        CustomerID.ReadOnly = True
        CustomerID.Width = 315
        ' 
        ' CustomerName
        ' 
        CustomerName.HeaderText = "Name"
        CustomerName.Name = "CustomerName"
        CustomerName.ReadOnly = True
        CustomerName.Width = 315
        ' 
        ' DateInstalled
        ' 
        DateInstalled.HeaderText = "Date Installed"
        DateInstalled.Name = "DateInstalled"
        DateInstalled.ReadOnly = True
        DateInstalled.Width = 315
        ' 
        ' PlanType
        ' 
        PlanType.HeaderText = "Plan Type"
        PlanType.Name = "PlanType"
        PlanType.ReadOnly = True
        PlanType.Width = 315
        ' 
        ' MonthlyRate
        ' 
        MonthlyRate.HeaderText = "Monthly Rate"
        MonthlyRate.Name = "MonthlyRate"
        MonthlyRate.ReadOnly = True
        MonthlyRate.Width = 315
        ' 
        ' LabelRecentSalesDetails
        ' 
        LabelRecentSalesDetails.AutoSize = True
        LabelRecentSalesDetails.Font = New Font("Verdana", 12F)
        LabelRecentSalesDetails.Location = New Point(22, 21)
        LabelRecentSalesDetails.Name = "LabelRecentSalesDetails"
        LabelRecentSalesDetails.Size = New Size(178, 18)
        LabelRecentSalesDetails.TabIndex = 11
        LabelRecentSalesDetails.Text = "Recent Sales Details"
        ' 
        ' PanelRound4
        ' 
        PanelRound4.Location = New Point(43, 1732)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(1597, 49)
        PanelRound4.TabIndex = 44
        ' 
        ' AdminSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(PanelRound4)
        Controls.Add(PanelRecentSalesDetails)
        Controls.Add(PanelMonthlySalesVolume)
        Controls.Add(PanelRound3)
        Controls.Add(PanelRound2)
        Controls.Add(PanelRound1)
        Controls.Add(HeaderSalesReport)
        Controls.Add(PanelFilters)
        Name = "AdminSales"
        Size = New Size(1940, 1867)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelMonthlySalesVolume.ResumeLayout(False)
        PanelMonthlySalesVolume.PerformLayout()
        PanelRecentSalesDetails.ResumeLayout(False)
        PanelRecentSalesDetails.PerformLayout()
        CType(DataGridrecentSalesDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelTotalNewSales As PanelRound
    Friend WithEvents PanelTotalMonthlyRevenue As PanelRound
    Friend WithEvents PanelRevenuePerSale As PanelRound
    Friend WithEvents PanelMonthlySalesVolume As PanelRound
    Friend WithEvents PanelRecentSalesDetails As PanelRound
    Friend WithEvents HeaderSalesReport As Label
    Friend WithEvents ComboBoxTechnician As ComboBox
    Friend WithEvents ComboBoxDateRange As ComboBox
    Friend WithEvents LabelTechnician As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents TotalNewSales As Label
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ValueNewSales As Label
    Friend WithEvents ValueRevenuePerSale As Label
    Friend WithEvents ValueMonthlyRevenue As Label
    Friend WithEvents MonthlySalesVolume As Label
    Friend WithEvents LabelRecentSalesDetails As Label
    Friend WithEvents DataGridrecentSalesDetails As DataGridView
    Friend WithEvents CustomerID As DataGridViewTextBoxColumn
    Friend WithEvents CustomerName As DataGridViewTextBoxColumn
    Friend WithEvents DateInstalled As DataGridViewTextBoxColumn
    Friend WithEvents PlanType As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyRate As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound4 As PanelRound
    Public Property ColumnName As String

End Class

