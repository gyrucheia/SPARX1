<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInventory))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderInventoryReport = New Label()
        PanelFilters = New PanelRound()
        PanelRound1 = New PanelRound()
        TextBox1 = New TextBox()
        ComboBoxReorderLevel = New ComboBox()
        ReorderLevel = New Label()
        ComboBoxStatus = New ComboBox()
        LabelStatus = New Label()
        ItemName = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PanelInProgress = New PanelRound()
        IconILowStockItem = New PictureBox()
        ValueLowStockItems = New Label()
        LabelLowStockItems = New Label()
        PanelCompleted = New PanelRound()
        IconTotalValue = New PictureBox()
        ValueTotalValue = New Label()
        LabelTotalValue = New Label()
        PanelPending = New PanelRound()
        IconOutOfStock = New PictureBox()
        ValueOutOfStock = New Label()
        LabelOutOfStcok = New Label()
        PanelInstallations = New PanelRound()
        IconTotalItems = New PictureBox()
        valueTotalItems = New Label()
        LabelTotalItems = New Label()
        PanelItemsRequiringAttention = New PanelRound()
        PanelItem4 = New PanelRound()
        StockValue4 = New Label()
        ItemName4 = New Label()
        Stock4 = New Label()
        PanelStock4 = New PanelRound()
        PanelItem2 = New PanelRound()
        StockValue2 = New Label()
        ItemName2 = New Label()
        Stock2 = New Label()
        PanelStock2 = New PanelRound()
        PanelItem3 = New PanelRound()
        StockValue3 = New Label()
        ItemName3 = New Label()
        Stock3 = New Label()
        PanelStock3 = New PanelRound()
        PanelItem1 = New PanelRound()
        StockValue1 = New Label()
        ItemName1 = New Label()
        Stock1 = New Label()
        PanelStock1 = New PanelRound()
        PictureBox7 = New PictureBox()
        LabelSystemAlert = New Label()
        PanelRound11 = New PanelRound()
        PanelStockLevelDistribution = New PanelRound()
        StockLevelDistribution = New Label()
        PanelInventoryDetails = New PanelRound()
        DataGridServiceRequestDetails = New DataGridView()
        ItemID = New DataGridViewTextBoxColumn()
        ItemNames = New DataGridViewTextBoxColumn()
        SerialNumber = New DataGridViewTextBoxColumn()
        UnitCost = New DataGridViewTextBoxColumn()
        CurrentStock = New DataGridViewTextBoxColumn()
        Brands = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        AddDelete = New DataGridViewTextBoxColumn()
        InventoryDetails = New Label()
        PanelRound3 = New PanelRound()
        DashboardBtn = New Button()
        PanelFilters.SuspendLayout()
        PanelRound1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelInProgress.SuspendLayout()
        CType(IconILowStockItem, ComponentModel.ISupportInitialize).BeginInit()
        PanelCompleted.SuspendLayout()
        CType(IconTotalValue, ComponentModel.ISupportInitialize).BeginInit()
        PanelPending.SuspendLayout()
        CType(IconOutOfStock, ComponentModel.ISupportInitialize).BeginInit()
        PanelInstallations.SuspendLayout()
        CType(IconTotalItems, ComponentModel.ISupportInitialize).BeginInit()
        PanelItemsRequiringAttention.SuspendLayout()
        PanelItem4.SuspendLayout()
        PanelItem2.SuspendLayout()
        PanelItem3.SuspendLayout()
        PanelItem1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        PanelStockLevelDistribution.SuspendLayout()
        PanelInventoryDetails.SuspendLayout()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderInventoryReport
        ' 
        HeaderInventoryReport.AutoSize = True
        HeaderInventoryReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderInventoryReport.Location = New Point(43, 18)
        HeaderInventoryReport.Name = "HeaderInventoryReport"
        HeaderInventoryReport.Size = New Size(167, 28)
        HeaderInventoryReport.TabIndex = 4
        HeaderInventoryReport.Text = "Inventory Report"
        ' 
        ' PanelFilters
        ' 
        PanelFilters.BackColor = Color.White
        PanelFilters.Controls.Add(PanelRound1)
        PanelFilters.Controls.Add(ComboBoxReorderLevel)
        PanelFilters.Controls.Add(ReorderLevel)
        PanelFilters.Controls.Add(ComboBoxStatus)
        PanelFilters.Controls.Add(LabelStatus)
        PanelFilters.Controls.Add(ItemName)
        PanelFilters.Controls.Add(Label1)
        PanelFilters.Controls.Add(PictureBox1)
        PanelFilters.CornerRadius = 12
        PanelFilters.Location = New Point(43, 60)
        PanelFilters.Name = "PanelFilters"
        PanelFilters.Size = New Size(1597, 165)
        PanelFilters.TabIndex = 13
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.WhiteSmoke
        PanelRound1.Controls.Add(TextBox1)
        PanelRound1.CornerRadius = 12
        PanelRound1.Location = New Point(22, 104)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(445, 33)
        PanelRound1.TabIndex = 15
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(5, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(437, 22)
        TextBox1.TabIndex = 14
        ' 
        ' ComboBoxReorderLevel
        ' 
        ComboBoxReorderLevel.BackColor = Color.WhiteSmoke
        ComboBoxReorderLevel.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxReorderLevel.Font = New Font("Segoe UI", 14F)
        ComboBoxReorderLevel.ForeColor = SystemColors.WindowText
        ComboBoxReorderLevel.FormattingEnabled = True
        ComboBoxReorderLevel.Location = New Point(860, 104)
        ComboBoxReorderLevel.MinimumSize = New Size(193, 0)
        ComboBoxReorderLevel.Name = "ComboBoxReorderLevel"
        ComboBoxReorderLevel.Size = New Size(308, 33)
        ComboBoxReorderLevel.TabIndex = 14
        ' 
        ' ReorderLevel
        ' 
        ReorderLevel.AutoSize = True
        ReorderLevel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ReorderLevel.Location = New Point(860, 80)
        ReorderLevel.Name = "ReorderLevel"
        ReorderLevel.Size = New Size(112, 21)
        ReorderLevel.TabIndex = 13
        ReorderLevel.Text = "Reorder Level"
        ' 
        ' ComboBoxStatus
        ' 
        ComboBoxStatus.BackColor = Color.WhiteSmoke
        ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxStatus.Font = New Font("Segoe UI", 14F)
        ComboBoxStatus.ForeColor = SystemColors.WindowText
        ComboBoxStatus.FormattingEnabled = True
        ComboBoxStatus.Location = New Point(512, 104)
        ComboBoxStatus.MinimumSize = New Size(193, 0)
        ComboBoxStatus.Name = "ComboBoxStatus"
        ComboBoxStatus.Size = New Size(308, 33)
        ComboBoxStatus.TabIndex = 10
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        LabelStatus.Location = New Point(512, 80)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(55, 21)
        LabelStatus.TabIndex = 8
        LabelStatus.Text = "Status"
        ' 
        ' ItemName
        ' 
        ItemName.AutoSize = True
        ItemName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ItemName.Location = New Point(22, 80)
        ItemName.Name = "ItemName"
        ItemName.Size = New Size(91, 21)
        ItemName.TabIndex = 7
        ItemName.Text = "Item Name"
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
        PanelInProgress.Controls.Add(IconILowStockItem)
        PanelInProgress.Controls.Add(ValueLowStockItems)
        PanelInProgress.Controls.Add(LabelLowStockItems)
        PanelInProgress.CornerRadius = 12
        PanelInProgress.Location = New Point(862, 267)
        PanelInProgress.Name = "PanelInProgress"
        PanelInProgress.Size = New Size(367, 167)
        PanelInProgress.TabIndex = 23
        ' 
        ' IconILowStockItem
        ' 
        IconILowStockItem.Image = CType(resources.GetObject("IconILowStockItem.Image"), Image)
        IconILowStockItem.Location = New Point(290, 59)
        IconILowStockItem.Name = "IconILowStockItem"
        IconILowStockItem.Size = New Size(48, 50)
        IconILowStockItem.SizeMode = PictureBoxSizeMode.Zoom
        IconILowStockItem.TabIndex = 14
        IconILowStockItem.TabStop = False
        ' 
        ' ValueLowStockItems
        ' 
        ValueLowStockItems.AutoSize = True
        ValueLowStockItems.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueLowStockItems.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        ValueLowStockItems.Location = New Point(28, 89)
        ValueLowStockItems.Name = "ValueLowStockItems"
        ValueLowStockItems.Size = New Size(37, 30)
        ValueLowStockItems.TabIndex = 13
        ValueLowStockItems.Text = "00"
        ' 
        ' LabelLowStockItems
        ' 
        LabelLowStockItems.AutoSize = True
        LabelLowStockItems.Font = New Font("Verdana", 12F)
        LabelLowStockItems.ForeColor = SystemColors.ControlDarkDark
        LabelLowStockItems.Location = New Point(28, 48)
        LabelLowStockItems.Name = "LabelLowStockItems"
        LabelLowStockItems.Size = New Size(144, 18)
        LabelLowStockItems.TabIndex = 12
        LabelLowStockItems.Text = "Low Stock Items"
        ' 
        ' PanelCompleted
        ' 
        PanelCompleted.BackColor = Color.White
        PanelCompleted.Controls.Add(IconTotalValue)
        PanelCompleted.Controls.Add(ValueTotalValue)
        PanelCompleted.Controls.Add(LabelTotalValue)
        PanelCompleted.CornerRadius = 12
        PanelCompleted.Location = New Point(453, 267)
        PanelCompleted.Name = "PanelCompleted"
        PanelCompleted.Size = New Size(367, 167)
        PanelCompleted.TabIndex = 22
        ' 
        ' IconTotalValue
        ' 
        IconTotalValue.Location = New Point(290, 59)
        IconTotalValue.Name = "IconTotalValue"
        IconTotalValue.Size = New Size(48, 50)
        IconTotalValue.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalValue.TabIndex = 13
        IconTotalValue.TabStop = False
        ' 
        ' ValueTotalValue
        ' 
        ValueTotalValue.AutoSize = True
        ValueTotalValue.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueTotalValue.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        ValueTotalValue.Location = New Point(28, 89)
        ValueTotalValue.Name = "ValueTotalValue"
        ValueTotalValue.Size = New Size(56, 30)
        ValueTotalValue.TabIndex = 12
        ValueTotalValue.Text = "₱ 00"
        ' 
        ' LabelTotalValue
        ' 
        LabelTotalValue.AutoSize = True
        LabelTotalValue.Font = New Font("Verdana", 12F)
        LabelTotalValue.ForeColor = SystemColors.ControlDarkDark
        LabelTotalValue.Location = New Point(28, 48)
        LabelTotalValue.Name = "LabelTotalValue"
        LabelTotalValue.Size = New Size(99, 18)
        LabelTotalValue.TabIndex = 11
        LabelTotalValue.Text = "Total Value"
        ' 
        ' PanelPending
        ' 
        PanelPending.BackColor = Color.White
        PanelPending.Controls.Add(IconOutOfStock)
        PanelPending.Controls.Add(ValueOutOfStock)
        PanelPending.Controls.Add(LabelOutOfStcok)
        PanelPending.CornerRadius = 12
        PanelPending.Location = New Point(1273, 267)
        PanelPending.Name = "PanelPending"
        PanelPending.Size = New Size(367, 167)
        PanelPending.TabIndex = 21
        ' 
        ' IconOutOfStock
        ' 
        IconOutOfStock.Location = New Point(290, 59)
        IconOutOfStock.Name = "IconOutOfStock"
        IconOutOfStock.Size = New Size(48, 50)
        IconOutOfStock.SizeMode = PictureBoxSizeMode.Zoom
        IconOutOfStock.TabIndex = 15
        IconOutOfStock.TabStop = False
        ' 
        ' ValueOutOfStock
        ' 
        ValueOutOfStock.AutoSize = True
        ValueOutOfStock.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        ValueOutOfStock.ForeColor = Color.Red
        ValueOutOfStock.Location = New Point(28, 89)
        ValueOutOfStock.Name = "ValueOutOfStock"
        ValueOutOfStock.Size = New Size(37, 30)
        ValueOutOfStock.TabIndex = 14
        ValueOutOfStock.Text = "00"
        ' 
        ' LabelOutOfStcok
        ' 
        LabelOutOfStcok.AutoSize = True
        LabelOutOfStcok.Font = New Font("Verdana", 12F)
        LabelOutOfStcok.ForeColor = SystemColors.ControlDarkDark
        LabelOutOfStcok.Location = New Point(28, 48)
        LabelOutOfStcok.Name = "LabelOutOfStcok"
        LabelOutOfStcok.Size = New Size(110, 18)
        LabelOutOfStcok.TabIndex = 13
        LabelOutOfStcok.Text = "Out of Stock"
        ' 
        ' PanelInstallations
        ' 
        PanelInstallations.BackColor = Color.White
        PanelInstallations.Controls.Add(IconTotalItems)
        PanelInstallations.Controls.Add(valueTotalItems)
        PanelInstallations.Controls.Add(LabelTotalItems)
        PanelInstallations.CornerRadius = 12
        PanelInstallations.Location = New Point(43, 267)
        PanelInstallations.Name = "PanelInstallations"
        PanelInstallations.Size = New Size(367, 167)
        PanelInstallations.TabIndex = 20
        ' 
        ' IconTotalItems
        ' 
        IconTotalItems.Location = New Point(290, 59)
        IconTotalItems.Name = "IconTotalItems"
        IconTotalItems.Size = New Size(48, 50)
        IconTotalItems.SizeMode = PictureBoxSizeMode.Zoom
        IconTotalItems.TabIndex = 12
        IconTotalItems.TabStop = False
        ' 
        ' valueTotalItems
        ' 
        valueTotalItems.AutoSize = True
        valueTotalItems.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        valueTotalItems.ForeColor = Color.Blue
        valueTotalItems.Location = New Point(28, 89)
        valueTotalItems.Name = "valueTotalItems"
        valueTotalItems.Size = New Size(37, 30)
        valueTotalItems.TabIndex = 10
        valueTotalItems.Text = "00"
        ' 
        ' LabelTotalItems
        ' 
        LabelTotalItems.AutoSize = True
        LabelTotalItems.Font = New Font("Verdana", 12F)
        LabelTotalItems.ForeColor = SystemColors.ControlDarkDark
        LabelTotalItems.Location = New Point(28, 48)
        LabelTotalItems.Name = "LabelTotalItems"
        LabelTotalItems.Size = New Size(102, 18)
        LabelTotalItems.TabIndex = 11
        LabelTotalItems.Text = "Total Items"
        ' 
        ' PanelItemsRequiringAttention
        ' 
        PanelItemsRequiringAttention.BackColor = Color.White
        PanelItemsRequiringAttention.Controls.Add(PanelItem4)
        PanelItemsRequiringAttention.Controls.Add(PanelItem2)
        PanelItemsRequiringAttention.Controls.Add(PanelItem3)
        PanelItemsRequiringAttention.Controls.Add(PanelItem1)
        PanelItemsRequiringAttention.Controls.Add(PictureBox7)
        PanelItemsRequiringAttention.Controls.Add(LabelSystemAlert)
        PanelItemsRequiringAttention.CornerRadius = 12
        PanelItemsRequiringAttention.Location = New Point(50, 479)
        PanelItemsRequiringAttention.Name = "PanelItemsRequiringAttention"
        PanelItemsRequiringAttention.Size = New Size(1590, 274)
        PanelItemsRequiringAttention.TabIndex = 38
        ' 
        ' PanelItem4
        ' 
        PanelItem4.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelItem4.Controls.Add(StockValue4)
        PanelItem4.Controls.Add(ItemName4)
        PanelItem4.Controls.Add(Stock4)
        PanelItem4.Controls.Add(PanelStock4)
        PanelItem4.CornerRadius = 12
        PanelItem4.Location = New Point(802, 164)
        PanelItem4.Name = "PanelItem4"
        PanelItem4.Size = New Size(759, 70)
        PanelItem4.TabIndex = 22
        ' 
        ' StockValue4
        ' 
        StockValue4.Anchor = AnchorStyles.Top
        StockValue4.AutoSize = True
        StockValue4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StockValue4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        StockValue4.Location = New Point(63, 34)
        StockValue4.Name = "StockValue4"
        StockValue4.Size = New Size(28, 21)
        StockValue4.TabIndex = 23
        StockValue4.Text = "00"
        ' 
        ' ItemName4
        ' 
        ItemName4.Anchor = AnchorStyles.Top
        ItemName4.AutoSize = True
        ItemName4.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        ItemName4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ItemName4.Location = New Point(6, 14)
        ItemName4.Name = "ItemName4"
        ItemName4.Size = New Size(109, 25)
        ItemName4.TabIndex = 22
        ItemName4.Text = "Item Name"
        ' 
        ' Stock4
        ' 
        Stock4.Anchor = AnchorStyles.Top
        Stock4.AutoSize = True
        Stock4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Stock4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Stock4.Location = New Point(8, 34)
        Stock4.Name = "Stock4"
        Stock4.Size = New Size(60, 21)
        Stock4.TabIndex = 19
        Stock4.Text = "Stock: "
        ' 
        ' PanelStock4
        ' 
        PanelStock4.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        PanelStock4.CornerRadius = 12
        PanelStock4.Location = New Point(627, 19)
        PanelStock4.Name = "PanelStock4"
        PanelStock4.Size = New Size(119, 36)
        PanelStock4.TabIndex = 3
        ' 
        ' PanelItem2
        ' 
        PanelItem2.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelItem2.Controls.Add(StockValue2)
        PanelItem2.Controls.Add(ItemName2)
        PanelItem2.Controls.Add(Stock2)
        PanelItem2.Controls.Add(PanelStock2)
        PanelItem2.CornerRadius = 12
        PanelItem2.Location = New Point(15, 164)
        PanelItem2.Name = "PanelItem2"
        PanelItem2.Size = New Size(759, 70)
        PanelItem2.TabIndex = 21
        ' 
        ' StockValue2
        ' 
        StockValue2.Anchor = AnchorStyles.Top
        StockValue2.AutoSize = True
        StockValue2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StockValue2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        StockValue2.Location = New Point(63, 34)
        StockValue2.Name = "StockValue2"
        StockValue2.Size = New Size(28, 21)
        StockValue2.TabIndex = 21
        StockValue2.Text = "00"
        ' 
        ' ItemName2
        ' 
        ItemName2.Anchor = AnchorStyles.Top
        ItemName2.AutoSize = True
        ItemName2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        ItemName2.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ItemName2.Location = New Point(6, 14)
        ItemName2.Name = "ItemName2"
        ItemName2.Size = New Size(109, 25)
        ItemName2.TabIndex = 20
        ItemName2.Text = "Item Name"
        ' 
        ' Stock2
        ' 
        Stock2.Anchor = AnchorStyles.Top
        Stock2.AutoSize = True
        Stock2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Stock2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Stock2.Location = New Point(6, 34)
        Stock2.Name = "Stock2"
        Stock2.Size = New Size(60, 21)
        Stock2.TabIndex = 19
        Stock2.Text = "Stock: "
        ' 
        ' PanelStock2
        ' 
        PanelStock2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        PanelStock2.CornerRadius = 12
        PanelStock2.Location = New Point(627, 19)
        PanelStock2.Name = "PanelStock2"
        PanelStock2.Size = New Size(119, 36)
        PanelStock2.TabIndex = 1
        ' 
        ' PanelItem3
        ' 
        PanelItem3.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelItem3.Controls.Add(StockValue3)
        PanelItem3.Controls.Add(ItemName3)
        PanelItem3.Controls.Add(Stock3)
        PanelItem3.Controls.Add(PanelStock3)
        PanelItem3.CornerRadius = 12
        PanelItem3.Location = New Point(802, 63)
        PanelItem3.Name = "PanelItem3"
        PanelItem3.Size = New Size(759, 70)
        PanelItem3.TabIndex = 20
        ' 
        ' StockValue3
        ' 
        StockValue3.Anchor = AnchorStyles.Top
        StockValue3.AutoSize = True
        StockValue3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StockValue3.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        StockValue3.Location = New Point(63, 34)
        StockValue3.Name = "StockValue3"
        StockValue3.Size = New Size(28, 21)
        StockValue3.TabIndex = 22
        StockValue3.Text = "00"
        ' 
        ' ItemName3
        ' 
        ItemName3.Anchor = AnchorStyles.Top
        ItemName3.AutoSize = True
        ItemName3.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        ItemName3.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ItemName3.Location = New Point(6, 14)
        ItemName3.Name = "ItemName3"
        ItemName3.Size = New Size(109, 25)
        ItemName3.TabIndex = 21
        ItemName3.Text = "Item Name"
        ' 
        ' Stock3
        ' 
        Stock3.Anchor = AnchorStyles.Top
        Stock3.AutoSize = True
        Stock3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Stock3.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Stock3.Location = New Point(8, 34)
        Stock3.Name = "Stock3"
        Stock3.Size = New Size(60, 21)
        Stock3.TabIndex = 19
        Stock3.Text = "Stock: "
        ' 
        ' PanelStock3
        ' 
        PanelStock3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        PanelStock3.CornerRadius = 12
        PanelStock3.Location = New Point(627, 19)
        PanelStock3.Name = "PanelStock3"
        PanelStock3.Size = New Size(119, 36)
        PanelStock3.TabIndex = 2
        ' 
        ' PanelItem1
        ' 
        PanelItem1.BackColor = Color.FromArgb(CByte(243), CByte(244), CByte(246))
        PanelItem1.Controls.Add(StockValue1)
        PanelItem1.Controls.Add(ItemName1)
        PanelItem1.Controls.Add(Stock1)
        PanelItem1.Controls.Add(PanelStock1)
        PanelItem1.CornerRadius = 12
        PanelItem1.Location = New Point(15, 63)
        PanelItem1.Name = "PanelItem1"
        PanelItem1.Size = New Size(759, 70)
        PanelItem1.TabIndex = 19
        ' 
        ' StockValue1
        ' 
        StockValue1.Anchor = AnchorStyles.Top
        StockValue1.AutoSize = True
        StockValue1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StockValue1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        StockValue1.Location = New Point(63, 34)
        StockValue1.Name = "StockValue1"
        StockValue1.Size = New Size(28, 21)
        StockValue1.TabIndex = 20
        StockValue1.Text = "00"
        ' 
        ' ItemName1
        ' 
        ItemName1.Anchor = AnchorStyles.Top
        ItemName1.AutoSize = True
        ItemName1.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        ItemName1.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ItemName1.Location = New Point(6, 14)
        ItemName1.Name = "ItemName1"
        ItemName1.Size = New Size(109, 25)
        ItemName1.TabIndex = 19
        ItemName1.Text = "Item Name"
        ' 
        ' Stock1
        ' 
        Stock1.Anchor = AnchorStyles.Top
        Stock1.AutoSize = True
        Stock1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Stock1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Stock1.Location = New Point(6, 34)
        Stock1.Name = "Stock1"
        Stock1.Size = New Size(60, 21)
        Stock1.TabIndex = 18
        Stock1.Text = "Stock: "
        ' 
        ' PanelStock1
        ' 
        PanelStock1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        PanelStock1.CornerRadius = 12
        PanelStock1.Location = New Point(627, 19)
        PanelStock1.Name = "PanelStock1"
        PanelStock1.Size = New Size(119, 36)
        PanelStock1.TabIndex = 0
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top
        PictureBox7.Location = New Point(15, 14)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(24, 24)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 18
        PictureBox7.TabStop = False
        ' 
        ' LabelSystemAlert
        ' 
        LabelSystemAlert.Anchor = AnchorStyles.Top
        LabelSystemAlert.AutoSize = True
        LabelSystemAlert.Font = New Font("Verdana", 11F)
        LabelSystemAlert.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        LabelSystemAlert.Location = New Point(45, 16)
        LabelSystemAlert.Name = "LabelSystemAlert"
        LabelSystemAlert.Size = New Size(196, 18)
        LabelSystemAlert.TabIndex = 17
        LabelSystemAlert.Text = "Items Requiring Attention"
        ' 
        ' PanelRound11
        ' 
        PanelRound11.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PanelRound11.CornerRadius = 12
        PanelRound11.Location = New Point(43, 479)
        PanelRound11.Name = "PanelRound11"
        PanelRound11.Size = New Size(46, 274)
        PanelRound11.TabIndex = 39
        ' 
        ' PanelStockLevelDistribution
        ' 
        PanelStockLevelDistribution.BackColor = Color.White
        PanelStockLevelDistribution.Controls.Add(StockLevelDistribution)
        PanelStockLevelDistribution.CornerRadius = 12
        PanelStockLevelDistribution.Location = New Point(43, 798)
        PanelStockLevelDistribution.Name = "PanelStockLevelDistribution"
        PanelStockLevelDistribution.Size = New Size(1597, 538)
        PanelStockLevelDistribution.TabIndex = 40
        ' 
        ' StockLevelDistribution
        ' 
        StockLevelDistribution.AutoSize = True
        StockLevelDistribution.Font = New Font("Verdana", 12F)
        StockLevelDistribution.Location = New Point(22, 21)
        StockLevelDistribution.Name = "StockLevelDistribution"
        StockLevelDistribution.Size = New Size(203, 18)
        StockLevelDistribution.TabIndex = 11
        StockLevelDistribution.Text = "Stock Level Distribution"
        ' 
        ' PanelInventoryDetails
        ' 
        PanelInventoryDetails.BackColor = Color.White
        PanelInventoryDetails.Controls.Add(DataGridServiceRequestDetails)
        PanelInventoryDetails.Controls.Add(InventoryDetails)
        PanelInventoryDetails.CornerRadius = 12
        PanelInventoryDetails.Location = New Point(43, 1380)
        PanelInventoryDetails.Name = "PanelInventoryDetails"
        PanelInventoryDetails.Size = New Size(1597, 651)
        PanelInventoryDetails.TabIndex = 41
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
        DataGridServiceRequestDetails.Columns.AddRange(New DataGridViewColumn() {ItemID, ItemNames, SerialNumber, UnitCost, CurrentStock, Brands, Status, AddDelete})
        DataGridServiceRequestDetails.EnableHeadersVisualStyles = False
        DataGridServiceRequestDetails.GridColor = Color.White
        DataGridServiceRequestDetails.Location = New Point(7, 60)
        DataGridServiceRequestDetails.Name = "DataGridServiceRequestDetails"
        DataGridServiceRequestDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridServiceRequestDetails.RowHeadersVisible = False
        DataGridServiceRequestDetails.RowTemplate.Height = 40
        DataGridServiceRequestDetails.ScrollBars = ScrollBars.Vertical
        DataGridServiceRequestDetails.Size = New Size(1578, 503)
        DataGridServiceRequestDetails.TabIndex = 28
        ' 
        ' ItemID
        ' 
        ItemID.Frozen = True
        ItemID.HeaderText = "Item ID"
        ItemID.Name = "ItemID"
        ItemID.ReadOnly = True
        ItemID.Width = 150
        ' 
        ' ItemNames
        ' 
        ItemNames.HeaderText = "Item Name"
        ItemNames.Name = "ItemNames"
        ItemNames.ReadOnly = True
        ItemNames.Width = 150
        ' 
        ' SerialNumber
        ' 
        SerialNumber.HeaderText = "Serial Number"
        SerialNumber.Name = "SerialNumber"
        SerialNumber.ReadOnly = True
        SerialNumber.Width = 200
        ' 
        ' UnitCost
        ' 
        UnitCost.HeaderText = "Unit Cost"
        UnitCost.Name = "UnitCost"
        UnitCost.ReadOnly = True
        UnitCost.Width = 250
        ' 
        ' CurrentStock
        ' 
        CurrentStock.HeaderText = "Current Stock"
        CurrentStock.Name = "CurrentStock"
        CurrentStock.ReadOnly = True
        CurrentStock.Width = 250
        ' 
        ' Brands
        ' 
        Brands.HeaderText = "Brand"
        Brands.Name = "Brands"
        Brands.ReadOnly = True
        Brands.Width = 350
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
        ' InventoryDetails
        ' 
        InventoryDetails.AutoSize = True
        InventoryDetails.Font = New Font("Verdana", 12F)
        InventoryDetails.Location = New Point(22, 21)
        InventoryDetails.Name = "InventoryDetails"
        InventoryDetails.Size = New Size(150, 18)
        InventoryDetails.TabIndex = 11
        InventoryDetails.Text = "Inventory Details"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.Location = New Point(43, 2060)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(1597, 49)
        PanelRound3.TabIndex = 44
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.FromArgb(CByte(21), CByte(93), CByte(252))
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Segoe UI", 12F)
        DashboardBtn.ForeColor = Color.Transparent
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(1479, 15)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(18, 0, 0, 0)
        DashboardBtn.Size = New Size(161, 31)
        DashboardBtn.TabIndex = 46
        DashboardBtn.Text = "Export Report"
        DashboardBtn.TextAlign = ContentAlignment.MiddleRight
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' AdminInventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = SystemColors.Control
        Controls.Add(DashboardBtn)
        Controls.Add(PanelRound3)
        Controls.Add(PanelInventoryDetails)
        Controls.Add(PanelStockLevelDistribution)
        Controls.Add(PanelItemsRequiringAttention)
        Controls.Add(PanelRound11)
        Controls.Add(PanelInProgress)
        Controls.Add(PanelFilters)
        Controls.Add(PanelCompleted)
        Controls.Add(HeaderInventoryReport)
        Controls.Add(PanelPending)
        Controls.Add(PanelInstallations)
        Name = "AdminInventory"
        Size = New Size(1940, 2289)
        PanelFilters.ResumeLayout(False)
        PanelFilters.PerformLayout()
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelInProgress.ResumeLayout(False)
        PanelInProgress.PerformLayout()
        CType(IconILowStockItem, ComponentModel.ISupportInitialize).EndInit()
        PanelCompleted.ResumeLayout(False)
        PanelCompleted.PerformLayout()
        CType(IconTotalValue, ComponentModel.ISupportInitialize).EndInit()
        PanelPending.ResumeLayout(False)
        PanelPending.PerformLayout()
        CType(IconOutOfStock, ComponentModel.ISupportInitialize).EndInit()
        PanelInstallations.ResumeLayout(False)
        PanelInstallations.PerformLayout()
        CType(IconTotalItems, ComponentModel.ISupportInitialize).EndInit()
        PanelItemsRequiringAttention.ResumeLayout(False)
        PanelItemsRequiringAttention.PerformLayout()
        PanelItem4.ResumeLayout(False)
        PanelItem4.PerformLayout()
        PanelItem2.ResumeLayout(False)
        PanelItem2.PerformLayout()
        PanelItem3.ResumeLayout(False)
        PanelItem3.PerformLayout()
        PanelItem1.ResumeLayout(False)
        PanelItem1.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        PanelStockLevelDistribution.ResumeLayout(False)
        PanelStockLevelDistribution.PerformLayout()
        PanelInventoryDetails.ResumeLayout(False)
        PanelInventoryDetails.PerformLayout()
        CType(DataGridServiceRequestDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderInventoryReport As Label
    Friend WithEvents PanelFilters As PanelRound
    Friend WithEvents ComboBoxReorderLevel As ComboBox
    Friend WithEvents ReorderLevel As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ItemName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PanelInProgress As PanelRound
    Friend WithEvents IconILowStockItem As PictureBox
    Friend WithEvents ValueLowStockItems As Label
    Friend WithEvents LabelLowStockItems As Label
    Friend WithEvents PanelCompleted As PanelRound
    Friend WithEvents IconTotalValue As PictureBox
    Friend WithEvents ValueTotalValue As Label
    Friend WithEvents LabelTotalValue As Label
    Friend WithEvents PanelPending As PanelRound
    Friend WithEvents IconOutOfStock As PictureBox
    Friend WithEvents ValueOutOfStock As Label
    Friend WithEvents LabelOutOfStcok As Label
    Friend WithEvents PanelInstallations As PanelRound
    Friend WithEvents IconTotalItems As PictureBox
    Friend WithEvents valueTotalItems As Label
    Friend WithEvents LabelTotalItems As Label
    Friend WithEvents PanelItemsRequiringAttention As PanelRound
    Friend WithEvents PanelItem1 As PanelRound
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LabelSystemAlert As Label
    Friend WithEvents PanelRound11 As PanelRound
    Friend WithEvents PanelItem4 As PanelRound
    Friend WithEvents PanelItem2 As PanelRound
    Friend WithEvents PanelItem3 As PanelRound
    Friend WithEvents PanelStock1 As PanelRound
    Friend WithEvents PanelStock4 As PanelRound
    Friend WithEvents PanelStock2 As PanelRound
    Friend WithEvents PanelStock3 As PanelRound
    Friend WithEvents Stock2 As Label
    Friend WithEvents Stock1 As Label
    Friend WithEvents Stock4 As Label
    Friend WithEvents Stock3 As Label
    Friend WithEvents ItemName4 As Label
    Friend WithEvents ItemName2 As Label
    Friend WithEvents ItemName3 As Label
    Friend WithEvents ItemName1 As Label
    Friend WithEvents StockValue1 As Label
    Friend WithEvents StockValue4 As Label
    Friend WithEvents StockValue2 As Label
    Friend WithEvents StockValue3 As Label
    Friend WithEvents PanelStockLevelDistribution As PanelRound
    Friend WithEvents StockLevelDistribution As Label
    Friend WithEvents PanelInventoryDetails As PanelRound
    Friend WithEvents InventoryDetails As Label
    Friend WithEvents DataGridServiceRequestDetails As DataGridView
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemNames As DataGridViewTextBoxColumn
    Friend WithEvents SerialNumber As DataGridViewTextBoxColumn
    Friend WithEvents UnitCost As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStock As DataGridViewTextBoxColumn
    Friend WithEvents Brands As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents AddDelete As DataGridViewTextBoxColumn
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents DashboardBtn As Button

End Class
