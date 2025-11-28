<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryview))
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        HeaderInventoryReport = New Label()
        InventoryFilterPanel = New PanelRound()
        ItemSearchTxtBox = New TextBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        ReorderLbl = New Label()
        StatusLbl = New Label()
        ItemNameLbl = New Label()
        LabelFilters = New Label()
        IconFilter = New PictureBox()
        TotalItemsPanel = New PanelRound()
        ItemIcon = New PictureBox()
        NumItemsLbl = New Label()
        TotalItemLbl = New Label()
        TotalValuePanel = New PanelRound()
        PictureBox1 = New PictureBox()
        CurrencyLbl = New Label()
        TotalValueLbl = New Label()
        LowStockPanel = New PanelRound()
        PictureBox2 = New PictureBox()
        NumLowStockLbl = New Label()
        LowStockLbl = New Label()
        OutofStockPanel = New PanelRound()
        PictureBox3 = New PictureBox()
        NumOutStockLbl = New Label()
        OutOfStockLbl = New Label()
        PanelRound5 = New PanelRound()
        PanelRound1 = New PanelRound()
        PanelRound8 = New PanelRound()
        PanelRound9 = New PanelRound()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        PanelRound6 = New PanelRound()
        PanelRound7 = New PanelRound()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        PanelRound3 = New PanelRound()
        PanelRound4 = New PanelRound()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PanelRound2 = New PanelRound()
        StockTypePanel = New PanelRound()
        Label1 = New Label()
        StockNumbLbl = New Label()
        ItemModelLbl = New Label()
        ItemAttentionLbl = New Label()
        PictureBox4 = New PictureBox()
        StockLevelDisLbl = New PanelRound()
        Label11 = New Label()
        InventoryDetailsPanel = New PanelRound()
        InventoryDetailsDVG = New DataGridView()
        ItemID = New DataGridViewTextBoxColumn()
        ItemName = New DataGridViewTextBoxColumn()
        SerialNum = New DataGridViewTextBoxColumn()
        UnitCost = New DataGridViewTextBoxColumn()
        CurrentStock = New DataGridViewTextBoxColumn()
        TotalValue = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        EditDelete = New DataGridViewTextBoxColumn()
        InventoryDetailsLbl = New Label()
        InventoryFilterPanel.SuspendLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).BeginInit()
        TotalItemsPanel.SuspendLayout()
        CType(ItemIcon, ComponentModel.ISupportInitialize).BeginInit()
        TotalValuePanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        LowStockPanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        OutofStockPanel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PanelRound5.SuspendLayout()
        PanelRound1.SuspendLayout()
        PanelRound8.SuspendLayout()
        PanelRound9.SuspendLayout()
        PanelRound6.SuspendLayout()
        PanelRound7.SuspendLayout()
        PanelRound3.SuspendLayout()
        PanelRound4.SuspendLayout()
        PanelRound2.SuspendLayout()
        StockTypePanel.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        StockLevelDisLbl.SuspendLayout()
        InventoryDetailsPanel.SuspendLayout()
        CType(InventoryDetailsDVG, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HeaderInventoryReport
        ' 
        HeaderInventoryReport.AutoSize = True
        HeaderInventoryReport.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        HeaderInventoryReport.Location = New Point(43, 18)
        HeaderInventoryReport.Name = "HeaderInventoryReport"
        HeaderInventoryReport.Size = New Size(167, 28)
        HeaderInventoryReport.TabIndex = 1
        HeaderInventoryReport.Text = "Inventory Report"
        ' 
        ' InventoryFilterPanel
        ' 
        InventoryFilterPanel.BackColor = Color.White
        InventoryFilterPanel.Controls.Add(ItemSearchTxtBox)
        InventoryFilterPanel.Controls.Add(ComboBox2)
        InventoryFilterPanel.Controls.Add(ComboBox1)
        InventoryFilterPanel.Controls.Add(ReorderLbl)
        InventoryFilterPanel.Controls.Add(StatusLbl)
        InventoryFilterPanel.Controls.Add(ItemNameLbl)
        InventoryFilterPanel.Controls.Add(LabelFilters)
        InventoryFilterPanel.Controls.Add(IconFilter)
        InventoryFilterPanel.CornerRadius = 12
        InventoryFilterPanel.Location = New Point(43, 72)
        InventoryFilterPanel.Name = "InventoryFilterPanel"
        InventoryFilterPanel.Size = New Size(1597, 188)
        InventoryFilterPanel.TabIndex = 2
        ' 
        ' ItemSearchTxtBox
        ' 
        ItemSearchTxtBox.BackColor = SystemColors.ButtonFace
        ItemSearchTxtBox.Font = New Font("Segoe UI", 12F)
        ItemSearchTxtBox.Location = New Point(22, 104)
        ItemSearchTxtBox.Name = "ItemSearchTxtBox"
        ItemSearchTxtBox.Size = New Size(265, 29)
        ItemSearchTxtBox.TabIndex = 7
        ItemSearchTxtBox.Text = "Search by item name..."
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = SystemColors.ButtonFace
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI", 14F)
        ComboBox2.ForeColor = SystemColors.WindowText
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(713, 104)
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
        ComboBox1.Items.AddRange(New Object() {"In Stock", "Low Stock", "Critical low", "Out of Stock"})
        ComboBox1.Location = New Point(364, 104)
        ComboBox1.MinimumSize = New Size(193, 0)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(265, 33)
        ComboBox1.TabIndex = 5
        ' 
        ' ReorderLbl
        ' 
        ReorderLbl.AutoSize = True
        ReorderLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ReorderLbl.Location = New Point(713, 80)
        ReorderLbl.Name = "ReorderLbl"
        ReorderLbl.Size = New Size(112, 21)
        ReorderLbl.TabIndex = 4
        ReorderLbl.Text = "Reorder Level"
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        StatusLbl.Location = New Point(364, 80)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(55, 21)
        StatusLbl.TabIndex = 3
        StatusLbl.Text = "Status"
        ' 
        ' ItemNameLbl
        ' 
        ItemNameLbl.AutoSize = True
        ItemNameLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        ItemNameLbl.Location = New Point(22, 80)
        ItemNameLbl.Name = "ItemNameLbl"
        ItemNameLbl.Size = New Size(91, 21)
        ItemNameLbl.TabIndex = 2
        ItemNameLbl.Text = "Item Name"
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
        IconFilter.Image = Global.SPARX_Management_System.My.Resources.filter
        IconFilter.Location = New Point(22, 19)
        IconFilter.Name = "IconFilter"
        IconFilter.Size = New Size(24, 24)
        IconFilter.SizeMode = PictureBoxSizeMode.Zoom
        IconFilter.TabIndex = 0
        IconFilter.TabStop = False
        ' 
        ' TotalItemsPanel
        ' 
        TotalItemsPanel.BackColor = Color.White
        TotalItemsPanel.Controls.Add(ItemIcon)
        TotalItemsPanel.Controls.Add(NumItemsLbl)
        TotalItemsPanel.Controls.Add(TotalItemLbl)
        TotalItemsPanel.CornerRadius = 12
        TotalItemsPanel.Location = New Point(43, 280)
        TotalItemsPanel.Name = "TotalItemsPanel"
        TotalItemsPanel.Size = New Size(367, 115)
        TotalItemsPanel.TabIndex = 14
        ' 
        ' ItemIcon
        ' 
        ItemIcon.Image = CType(resources.GetObject("ItemIcon.Image"), Image)
        ItemIcon.Location = New Point(286, 36)
        ItemIcon.Name = "ItemIcon"
        ItemIcon.Size = New Size(48, 50)
        ItemIcon.SizeMode = PictureBoxSizeMode.Zoom
        ItemIcon.TabIndex = 9
        ItemIcon.TabStop = False
        ' 
        ' NumItemsLbl
        ' 
        NumItemsLbl.AutoSize = True
        NumItemsLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumItemsLbl.Location = New Point(24, 66)
        NumItemsLbl.Name = "NumItemsLbl"
        NumItemsLbl.Size = New Size(49, 30)
        NumItemsLbl.TabIndex = 8
        NumItemsLbl.Text = "000"
        ' 
        ' TotalItemLbl
        ' 
        TotalItemLbl.AutoSize = True
        TotalItemLbl.Font = New Font("Verdana", 12F)
        TotalItemLbl.ForeColor = SystemColors.ControlDarkDark
        TotalItemLbl.Location = New Point(24, 25)
        TotalItemLbl.Name = "TotalItemLbl"
        TotalItemLbl.Size = New Size(102, 18)
        TotalItemLbl.TabIndex = 8
        TotalItemLbl.Text = "Total Items"
        ' 
        ' TotalValuePanel
        ' 
        TotalValuePanel.BackColor = Color.White
        TotalValuePanel.Controls.Add(PictureBox1)
        TotalValuePanel.Controls.Add(CurrencyLbl)
        TotalValuePanel.Controls.Add(TotalValueLbl)
        TotalValuePanel.CornerRadius = 12
        TotalValuePanel.Location = New Point(455, 280)
        TotalValuePanel.Name = "TotalValuePanel"
        TotalValuePanel.Size = New Size(367, 115)
        TotalValuePanel.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(286, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' CurrencyLbl
        ' 
        CurrencyLbl.AutoSize = True
        CurrencyLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        CurrencyLbl.ForeColor = Color.Green
        CurrencyLbl.Location = New Point(24, 66)
        CurrencyLbl.Name = "CurrencyLbl"
        CurrencyLbl.Size = New Size(49, 30)
        CurrencyLbl.TabIndex = 8
        CurrencyLbl.Text = "000"
        ' 
        ' TotalValueLbl
        ' 
        TotalValueLbl.AutoSize = True
        TotalValueLbl.Font = New Font("Verdana", 12F)
        TotalValueLbl.ForeColor = SystemColors.ControlDarkDark
        TotalValueLbl.Location = New Point(24, 25)
        TotalValueLbl.Name = "TotalValueLbl"
        TotalValueLbl.Size = New Size(99, 18)
        TotalValueLbl.TabIndex = 8
        TotalValueLbl.Text = "Total Value"
        ' 
        ' LowStockPanel
        ' 
        LowStockPanel.BackColor = Color.White
        LowStockPanel.Controls.Add(PictureBox2)
        LowStockPanel.Controls.Add(NumLowStockLbl)
        LowStockPanel.Controls.Add(LowStockLbl)
        LowStockPanel.CornerRadius = 12
        LowStockPanel.Location = New Point(864, 280)
        LowStockPanel.Name = "LowStockPanel"
        LowStockPanel.Size = New Size(367, 115)
        LowStockPanel.TabIndex = 16
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(286, 36)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(48, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' NumLowStockLbl
        ' 
        NumLowStockLbl.AutoSize = True
        NumLowStockLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumLowStockLbl.ForeColor = Color.OrangeRed
        NumLowStockLbl.Location = New Point(24, 66)
        NumLowStockLbl.Name = "NumLowStockLbl"
        NumLowStockLbl.Size = New Size(25, 30)
        NumLowStockLbl.TabIndex = 8
        NumLowStockLbl.Text = "0"
        ' 
        ' LowStockLbl
        ' 
        LowStockLbl.AutoSize = True
        LowStockLbl.Font = New Font("Verdana", 12F)
        LowStockLbl.ForeColor = SystemColors.ControlDarkDark
        LowStockLbl.Location = New Point(24, 25)
        LowStockLbl.Name = "LowStockLbl"
        LowStockLbl.Size = New Size(144, 18)
        LowStockLbl.TabIndex = 8
        LowStockLbl.Text = "Low Stock Items"
        ' 
        ' OutofStockPanel
        ' 
        OutofStockPanel.BackColor = Color.White
        OutofStockPanel.Controls.Add(PictureBox3)
        OutofStockPanel.Controls.Add(NumOutStockLbl)
        OutofStockPanel.Controls.Add(OutOfStockLbl)
        OutofStockPanel.CornerRadius = 12
        OutofStockPanel.Location = New Point(1273, 280)
        OutofStockPanel.Name = "OutofStockPanel"
        OutofStockPanel.Size = New Size(367, 115)
        OutofStockPanel.TabIndex = 17
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(286, 36)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(48, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' NumOutStockLbl
        ' 
        NumOutStockLbl.AutoSize = True
        NumOutStockLbl.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        NumOutStockLbl.ForeColor = Color.Red
        NumOutStockLbl.Location = New Point(24, 66)
        NumOutStockLbl.Name = "NumOutStockLbl"
        NumOutStockLbl.Size = New Size(25, 30)
        NumOutStockLbl.TabIndex = 8
        NumOutStockLbl.Text = "0"
        ' 
        ' OutOfStockLbl
        ' 
        OutOfStockLbl.AutoSize = True
        OutOfStockLbl.Font = New Font("Verdana", 12F)
        OutOfStockLbl.ForeColor = SystemColors.ControlDarkDark
        OutOfStockLbl.Location = New Point(24, 25)
        OutOfStockLbl.Name = "OutOfStockLbl"
        OutOfStockLbl.Size = New Size(110, 18)
        OutOfStockLbl.TabIndex = 8
        OutOfStockLbl.Text = "Out of Stock"
        ' 
        ' PanelRound5
        ' 
        PanelRound5.BackColor = Color.OrangeRed
        PanelRound5.Controls.Add(PanelRound1)
        PanelRound5.Location = New Point(43, 426)
        PanelRound5.Name = "PanelRound5"
        PanelRound5.Size = New Size(1597, 265)
        PanelRound5.TabIndex = 10
        ' 
        ' PanelRound1
        ' 
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(PanelRound8)
        PanelRound1.Controls.Add(PanelRound6)
        PanelRound1.Controls.Add(PanelRound3)
        PanelRound1.Controls.Add(PanelRound2)
        PanelRound1.Controls.Add(ItemAttentionLbl)
        PanelRound1.Controls.Add(PictureBox4)
        PanelRound1.Location = New Point(0, 0)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1597, 265)
        PanelRound1.TabIndex = 11
        ' 
        ' PanelRound8
        ' 
        PanelRound8.BackColor = SystemColors.ButtonFace
        PanelRound8.Controls.Add(PanelRound9)
        PanelRound8.Controls.Add(Label9)
        PanelRound8.Controls.Add(Label10)
        PanelRound8.Location = New Point(31, 170)
        PanelRound8.Name = "PanelRound8"
        PanelRound8.Size = New Size(735, 67)
        PanelRound8.TabIndex = 15
        ' 
        ' PanelRound9
        ' 
        PanelRound9.AutoSizeMode = AutoSizeMode.GrowAndShrink
        PanelRound9.BackColor = Color.FromArgb(CByte(255), CByte(226), CByte(226))
        PanelRound9.Controls.Add(Label8)
        PanelRound9.Location = New Point(618, 18)
        PanelRound9.Name = "PanelRound9"
        PanelRound9.Size = New Size(102, 35)
        PanelRound9.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(159), CByte(7), CByte(18))
        Label8.Location = New Point(9, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 17)
        Label8.TabIndex = 15
        Label8.Text = "Out of Stock"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label9.Location = New Point(12, 38)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 15)
        Label9.TabIndex = 13
        Label9.Text = "Stock: 0 units"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label10.Location = New Point(12, 13)
        Label10.Name = "Label10"
        Label10.Size = New Size(193, 21)
        Label10.TabIndex = 12
        Label10.Text = "Item Requiring Attention"
        ' 
        ' PanelRound6
        ' 
        PanelRound6.BackColor = SystemColors.ButtonFace
        PanelRound6.Controls.Add(PanelRound7)
        PanelRound6.Controls.Add(Label6)
        PanelRound6.Controls.Add(Label7)
        PanelRound6.Location = New Point(816, 170)
        PanelRound6.Name = "PanelRound6"
        PanelRound6.Size = New Size(735, 67)
        PanelRound6.TabIndex = 14
        ' 
        ' PanelRound7
        ' 
        PanelRound7.BackColor = Color.FromArgb(CByte(255), CByte(237), CByte(212))
        PanelRound7.Controls.Add(Label5)
        PanelRound7.Location = New Point(618, 18)
        PanelRound7.Name = "PanelRound7"
        PanelRound7.Size = New Size(102, 35)
        PanelRound7.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(159), CByte(45), CByte(0))
        Label5.Location = New Point(13, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 17)
        Label5.TabIndex = 15
        Label5.Text = "Critical Low"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label6.Location = New Point(12, 38)
        Label6.Name = "Label6"
        Label6.Size = New Size(77, 15)
        Label6.TabIndex = 13
        Label6.Text = "Stock: 3 units"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label7.Location = New Point(12, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(193, 21)
        Label7.TabIndex = 12
        Label7.Text = "Item Requiring Attention"
        ' 
        ' PanelRound3
        ' 
        PanelRound3.BackColor = SystemColors.ButtonFace
        PanelRound3.Controls.Add(PanelRound4)
        PanelRound3.Controls.Add(Label3)
        PanelRound3.Controls.Add(Label4)
        PanelRound3.Location = New Point(816, 71)
        PanelRound3.Name = "PanelRound3"
        PanelRound3.Size = New Size(735, 67)
        PanelRound3.TabIndex = 13
        ' 
        ' PanelRound4
        ' 
        PanelRound4.BackColor = Color.FromArgb(CByte(254), CByte(249), CByte(194))
        PanelRound4.Controls.Add(Label2)
        PanelRound4.Location = New Point(618, 18)
        PanelRound4.Name = "PanelRound4"
        PanelRound4.Size = New Size(102, 35)
        PanelRound4.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Brown
        Label2.Location = New Point(18, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 15
        Label2.Text = "Low Stock"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label3.Location = New Point(12, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 13
        Label3.Text = "Stock: 5 units"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        Label4.Location = New Point(12, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(193, 21)
        Label4.TabIndex = 12
        Label4.Text = "Item Requiring Attention"
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = SystemColors.ButtonFace
        PanelRound2.Controls.Add(StockTypePanel)
        PanelRound2.Controls.Add(StockNumbLbl)
        PanelRound2.Controls.Add(ItemModelLbl)
        PanelRound2.Location = New Point(32, 71)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(735, 67)
        PanelRound2.TabIndex = 12
        ' 
        ' StockTypePanel
        ' 
        StockTypePanel.BackColor = Color.FromArgb(CByte(254), CByte(249), CByte(194))
        StockTypePanel.Controls.Add(Label1)
        StockTypePanel.Location = New Point(618, 18)
        StockTypePanel.Name = "StockTypePanel"
        StockTypePanel.Size = New Size(102, 35)
        StockTypePanel.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Brown
        Label1.Location = New Point(18, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 17)
        Label1.TabIndex = 15
        Label1.Text = "Low Stock"
        ' 
        ' StockNumbLbl
        ' 
        StockNumbLbl.AutoSize = True
        StockNumbLbl.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StockNumbLbl.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        StockNumbLbl.Location = New Point(12, 38)
        StockNumbLbl.Name = "StockNumbLbl"
        StockNumbLbl.Size = New Size(77, 15)
        StockNumbLbl.TabIndex = 13
        StockNumbLbl.Text = "Stock: 5 units"
        ' 
        ' ItemModelLbl
        ' 
        ItemModelLbl.AutoSize = True
        ItemModelLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ItemModelLbl.ForeColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        ItemModelLbl.Location = New Point(12, 13)
        ItemModelLbl.Name = "ItemModelLbl"
        ItemModelLbl.Size = New Size(193, 21)
        ItemModelLbl.TabIndex = 12
        ItemModelLbl.Text = "Item Requiring Attention"
        ' 
        ' ItemAttentionLbl
        ' 
        ItemAttentionLbl.AutoSize = True
        ItemAttentionLbl.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ItemAttentionLbl.ForeColor = Color.Maroon
        ItemAttentionLbl.Location = New Point(63, 17)
        ItemAttentionLbl.Name = "ItemAttentionLbl"
        ItemAttentionLbl.Size = New Size(193, 21)
        ItemAttentionLbl.TabIndex = 11
        ItemAttentionLbl.Text = "Item Requiring Attention"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(33, 14)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(21, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' StockLevelDisLbl
        ' 
        StockLevelDisLbl.BackColor = Color.White
        StockLevelDisLbl.Controls.Add(Label11)
        StockLevelDisLbl.Location = New Point(43, 719)
        StockLevelDisLbl.Name = "StockLevelDisLbl"
        StockLevelDisLbl.Size = New Size(1597, 363)
        StockLevelDisLbl.TabIndex = 18
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(22, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(173, 21)
        Label11.TabIndex = 9
        Label11.Text = "Stock Level Distribution"
        ' 
        ' InventoryDetailsPanel
        ' 
        InventoryDetailsPanel.BackColor = Color.White
        InventoryDetailsPanel.Controls.Add(InventoryDetailsDVG)
        InventoryDetailsPanel.Controls.Add(InventoryDetailsLbl)
        InventoryDetailsPanel.Location = New Point(43, 1103)
        InventoryDetailsPanel.Name = "InventoryDetailsPanel"
        InventoryDetailsPanel.Size = New Size(1597, 494)
        InventoryDetailsPanel.TabIndex = 19
        ' 
        ' InventoryDetailsDVG
        ' 
        InventoryDetailsDVG.AllowUserToOrderColumns = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InventoryDetailsDVG.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        InventoryDetailsDVG.BackgroundColor = Color.White
        InventoryDetailsDVG.BorderStyle = BorderStyle.None
        InventoryDetailsDVG.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        InventoryDetailsDVG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Verdana", 10F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        InventoryDetailsDVG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        InventoryDetailsDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InventoryDetailsDVG.Columns.AddRange(New DataGridViewColumn() {ItemID, ItemName, SerialNum, UnitCost, CurrentStock, TotalValue, Status, EditDelete})
        InventoryDetailsDVG.GridColor = Color.Silver
        InventoryDetailsDVG.Location = New Point(21, 74)
        InventoryDetailsDVG.Name = "InventoryDetailsDVG"
        InventoryDetailsDVG.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        InventoryDetailsDVG.RowHeadersVisible = False
        InventoryDetailsDVG.RowTemplate.Height = 40
        InventoryDetailsDVG.ScrollBars = ScrollBars.Vertical
        InventoryDetailsDVG.Size = New Size(1401, 393)
        InventoryDetailsDVG.TabIndex = 24
        ' 
        ' ItemID
        ' 
        ItemID.Frozen = True
        ItemID.HeaderText = "Item ID"
        ItemID.Name = "ItemID"
        ItemID.ReadOnly = True
        ItemID.Width = 150
        ' 
        ' ItemName
        ' 
        ItemName.HeaderText = "Item Name"
        ItemName.Name = "ItemName"
        ItemName.ReadOnly = True
        ItemName.Width = 150
        ' 
        ' SerialNum
        ' 
        SerialNum.HeaderText = "Serial Number"
        SerialNum.Name = "SerialNum"
        SerialNum.ReadOnly = True
        SerialNum.Width = 150
        ' 
        ' UnitCost
        ' 
        UnitCost.HeaderText = "Unit Cost"
        UnitCost.Name = "UnitCost"
        UnitCost.ReadOnly = True
        UnitCost.Width = 200
        ' 
        ' CurrentStock
        ' 
        CurrentStock.HeaderText = "Current Stock"
        CurrentStock.Name = "CurrentStock"
        CurrentStock.ReadOnly = True
        CurrentStock.Width = 200
        ' 
        ' TotalValue
        ' 
        TotalValue.HeaderText = "Total Value"
        TotalValue.Name = "TotalValue"
        TotalValue.ReadOnly = True
        TotalValue.Width = 350
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 150
        ' 
        ' EditDelete
        ' 
        EditDelete.HeaderText = ""
        EditDelete.Name = "EditDelete"
        EditDelete.ReadOnly = True
        EditDelete.Width = 50
        ' 
        ' InventoryDetailsLbl
        ' 
        InventoryDetailsLbl.AutoSize = True
        InventoryDetailsLbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InventoryDetailsLbl.ForeColor = Color.Black
        InventoryDetailsLbl.Location = New Point(22, 23)
        InventoryDetailsLbl.Name = "InventoryDetailsLbl"
        InventoryDetailsLbl.Size = New Size(127, 21)
        InventoryDetailsLbl.TabIndex = 9
        InventoryDetailsLbl.Text = "Inventory Details"
        ' 
        ' inventoryview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSize = True
        BackColor = SystemColors.Control
        Controls.Add(InventoryDetailsPanel)
        Controls.Add(StockLevelDisLbl)
        Controls.Add(PanelRound5)
        Controls.Add(OutofStockPanel)
        Controls.Add(LowStockPanel)
        Controls.Add(TotalValuePanel)
        Controls.Add(TotalItemsPanel)
        Controls.Add(InventoryFilterPanel)
        Controls.Add(HeaderInventoryReport)
        Name = "inventoryview"
        Size = New Size(1793, 1600)
        InventoryFilterPanel.ResumeLayout(False)
        InventoryFilterPanel.PerformLayout()
        CType(IconFilter, ComponentModel.ISupportInitialize).EndInit()
        TotalItemsPanel.ResumeLayout(False)
        TotalItemsPanel.PerformLayout()
        CType(ItemIcon, ComponentModel.ISupportInitialize).EndInit()
        TotalValuePanel.ResumeLayout(False)
        TotalValuePanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        LowStockPanel.ResumeLayout(False)
        LowStockPanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        OutofStockPanel.ResumeLayout(False)
        OutofStockPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PanelRound5.ResumeLayout(False)
        PanelRound1.ResumeLayout(False)
        PanelRound1.PerformLayout()
        PanelRound8.ResumeLayout(False)
        PanelRound8.PerformLayout()
        PanelRound9.ResumeLayout(False)
        PanelRound9.PerformLayout()
        PanelRound6.ResumeLayout(False)
        PanelRound6.PerformLayout()
        PanelRound7.ResumeLayout(False)
        PanelRound7.PerformLayout()
        PanelRound3.ResumeLayout(False)
        PanelRound3.PerformLayout()
        PanelRound4.ResumeLayout(False)
        PanelRound4.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        StockTypePanel.ResumeLayout(False)
        StockTypePanel.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        StockLevelDisLbl.ResumeLayout(False)
        StockLevelDisLbl.PerformLayout()
        InventoryDetailsPanel.ResumeLayout(False)
        InventoryDetailsPanel.PerformLayout()
        CType(InventoryDetailsDVG, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HeaderInventoryReport As Label
    Friend WithEvents InventoryFilterPanel As PanelRound
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ReorderLbl As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents ItemNameLbl As Label
    Friend WithEvents LabelFilters As Label
    Friend WithEvents IconFilter As PictureBox
    Friend WithEvents ItemSearchTxtBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TotalItemsPanel As PanelRound
    Friend WithEvents ItemIcon As PictureBox
    Friend WithEvents NumItemsLbl As Label
    Friend WithEvents TotalItemLbl As Label
    Friend WithEvents TotalValuePanel As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CurrencyLbl As Label
    Friend WithEvents TotalValueLbl As Label
    Friend WithEvents LowStockPanel As PanelRound
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NumLowStockLbl As Label
    Friend WithEvents LowStockLbl As Label
    Friend WithEvents OutofStockPanel As PanelRound
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents NumOutStockLbl As Label
    Friend WithEvents OutOfStockLbl As Label
    Friend WithEvents PanelRound5 As PanelRound
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents ItemAttentionLbl As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents ItemModelLbl As Label
    Friend WithEvents StockNumbLbl As Label
    Friend WithEvents PanelRound3 As PanelRound
    Friend WithEvents PanelRound4 As PanelRound
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents StockTypePanel As PanelRound
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelRound6 As PanelRound
    Friend WithEvents PanelRound7 As PanelRound
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelRound8 As PanelRound
    Friend WithEvents PanelRound9 As PanelRound
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents StockLevelDisLbl As PanelRound
    Friend WithEvents Label11 As Label
    Friend WithEvents InventoryDetailsPanel As PanelRound
    Friend WithEvents InventoryDetailsLbl As Label
    Friend WithEvents InventoryDetailsDVG As DataGridView
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents SerialNum As DataGridViewTextBoxColumn
    Friend WithEvents UnitCost As DataGridViewTextBoxColumn
    Friend WithEvents CurrentStock As DataGridViewTextBoxColumn
    Friend WithEvents TotalValue As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents EditDelete As DataGridViewTextBoxColumn

End Class

