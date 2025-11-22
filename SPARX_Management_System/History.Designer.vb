<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Panel2 = New Panel()
        PanelRound1 = New PanelRound()
        HistoryTable = New DataGridView()
        FilterPanel = New PanelRound()
        StatusComboBox = New ComboBox()
        ServiceComboBox = New ComboBox()
        DateComboBox = New ComboBox()
        StatusLbl = New Label()
        ServiceLbl = New Label()
        DateRangeLbl = New Label()
        FilterLbl = New Label()
        PictureBox1 = New PictureBox()
        ColorDialog1 = New ColorDialog()
        DateColumn = New DataGridViewTextBoxColumn()
        TransactionColumn = New DataGridViewTextBoxColumn()
        ServiceIDColumn = New DataGridViewTextBoxColumn()
        StartDateColumn = New DataGridViewTextBoxColumn()
        EndDateColumn = New DataGridViewTextBoxColumn()
        MonthlyRateColumn = New DataGridViewTextBoxColumn()
        PaymentMethodColumn = New DataGridViewTextBoxColumn()
        StatusColumn = New DataGridViewTextBoxColumn()
        Panel2.SuspendLayout()
        PanelRound1.SuspendLayout()
        CType(HistoryTable, ComponentModel.ISupportInitialize).BeginInit()
        FilterPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Controls.Add(PanelRound1)
        Panel2.Controls.Add(FilterPanel)
        Panel2.Location = New Point(3, 7)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1291, 1215)
        Panel2.TabIndex = 9
        ' 
        ' PanelRound1
        ' 
        PanelRound1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelRound1.BackColor = Color.White
        PanelRound1.Controls.Add(HistoryTable)
        PanelRound1.Location = New Point(22, 142)
        PanelRound1.Name = "PanelRound1"
        PanelRound1.Size = New Size(1073, 800)
        PanelRound1.TabIndex = 1
        ' 
        ' HistoryTable
        ' 
        HistoryTable.BackgroundColor = SystemColors.ButtonHighlight
        HistoryTable.BorderStyle = BorderStyle.None
        HistoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        HistoryTable.Columns.AddRange(New DataGridViewColumn() {DateColumn, TransactionColumn, ServiceIDColumn, StartDateColumn, EndDateColumn, MonthlyRateColumn, PaymentMethodColumn, StatusColumn})
        HistoryTable.Dock = DockStyle.Fill
        HistoryTable.GridColor = Color.WhiteSmoke
        HistoryTable.Location = New Point(0, 0)
        HistoryTable.Margin = New Padding(20)
        HistoryTable.Name = "HistoryTable"
        HistoryTable.ReadOnly = True
        HistoryTable.RowHeadersVisible = False
        HistoryTable.Size = New Size(1073, 800)
        HistoryTable.TabIndex = 0
        ' 
        ' FilterPanel
        ' 
        FilterPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        FilterPanel.BackColor = Color.White
        FilterPanel.Controls.Add(StatusComboBox)
        FilterPanel.Controls.Add(ServiceComboBox)
        FilterPanel.Controls.Add(DateComboBox)
        FilterPanel.Controls.Add(StatusLbl)
        FilterPanel.Controls.Add(ServiceLbl)
        FilterPanel.Controls.Add(DateRangeLbl)
        FilterPanel.Controls.Add(FilterLbl)
        FilterPanel.Controls.Add(PictureBox1)
        FilterPanel.Location = New Point(22, 4)
        FilterPanel.Name = "FilterPanel"
        FilterPanel.Size = New Size(1073, 118)
        FilterPanel.TabIndex = 0
        ' 
        ' StatusComboBox
        ' 
        StatusComboBox.BackColor = Color.WhiteSmoke
        StatusComboBox.FlatStyle = FlatStyle.Flat
        StatusComboBox.FormattingEnabled = True
        StatusComboBox.Location = New Point(470, 77)
        StatusComboBox.Name = "StatusComboBox"
        StatusComboBox.Size = New Size(121, 23)
        StatusComboBox.TabIndex = 10
        ' 
        ' ServiceComboBox
        ' 
        ServiceComboBox.BackColor = Color.WhiteSmoke
        ServiceComboBox.FlatStyle = FlatStyle.Flat
        ServiceComboBox.FormattingEnabled = True
        ServiceComboBox.Location = New Point(236, 77)
        ServiceComboBox.Name = "ServiceComboBox"
        ServiceComboBox.Size = New Size(121, 23)
        ServiceComboBox.TabIndex = 9
        ' 
        ' DateComboBox
        ' 
        DateComboBox.BackColor = Color.WhiteSmoke
        DateComboBox.FlatStyle = FlatStyle.Flat
        DateComboBox.FormattingEnabled = True
        DateComboBox.Location = New Point(28, 77)
        DateComboBox.Name = "DateComboBox"
        DateComboBox.Size = New Size(121, 23)
        DateComboBox.TabIndex = 8
        ' 
        ' StatusLbl
        ' 
        StatusLbl.AutoSize = True
        StatusLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatusLbl.ForeColor = Color.Black
        StatusLbl.Location = New Point(467, 57)
        StatusLbl.Name = "StatusLbl"
        StatusLbl.Size = New Size(46, 17)
        StatusLbl.TabIndex = 7
        StatusLbl.Text = "Status"
        ' 
        ' ServiceLbl
        ' 
        ServiceLbl.AutoSize = True
        ServiceLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ServiceLbl.ForeColor = Color.Black
        ServiceLbl.Location = New Point(233, 57)
        ServiceLbl.Name = "ServiceLbl"
        ServiceLbl.Size = New Size(52, 17)
        ServiceLbl.TabIndex = 6
        ServiceLbl.Text = "Service"
        ' 
        ' DateRangeLbl
        ' 
        DateRangeLbl.AutoSize = True
        DateRangeLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateRangeLbl.ForeColor = Color.Black
        DateRangeLbl.Location = New Point(25, 57)
        DateRangeLbl.Name = "DateRangeLbl"
        DateRangeLbl.Size = New Size(79, 17)
        DateRangeLbl.TabIndex = 5
        DateRangeLbl.Text = "Date Range"
        ' 
        ' FilterLbl
        ' 
        FilterLbl.AutoSize = True
        FilterLbl.Font = New Font("Verdana", 12F)
        FilterLbl.Location = New Point(51, 16)
        FilterLbl.Name = "FilterLbl"
        FilterLbl.Size = New Size(59, 18)
        FilterLbl.TabIndex = 1
        FilterLbl.Text = "Filters"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(25, 14)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 20)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DateColumn
        ' 
        DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DateColumn.HeaderText = "Date"
        DateColumn.MinimumWidth = 40
        DateColumn.Name = "DateColumn"
        DateColumn.ReadOnly = True
        DateColumn.Width = 56
        ' 
        ' TransactionColumn
        ' 
        TransactionColumn.HeaderText = "Transaction Type"
        TransactionColumn.Name = "TransactionColumn"
        TransactionColumn.ReadOnly = True
        TransactionColumn.Width = 120
        ' 
        ' ServiceIDColumn
        ' 
        ServiceIDColumn.HeaderText = "Service ID"
        ServiceIDColumn.Name = "ServiceIDColumn"
        ServiceIDColumn.ReadOnly = True
        ' 
        ' StartDateColumn
        ' 
        StartDateColumn.HeaderText = "Start Date"
        StartDateColumn.Name = "StartDateColumn"
        StartDateColumn.ReadOnly = True
        StartDateColumn.Width = 105
        ' 
        ' EndDateColumn
        ' 
        EndDateColumn.HeaderText = "End Date"
        EndDateColumn.Name = "EndDateColumn"
        EndDateColumn.ReadOnly = True
        EndDateColumn.Width = 105
        ' 
        ' MonthlyRateColumn
        ' 
        MonthlyRateColumn.HeaderText = "Monthly Rate"
        MonthlyRateColumn.Name = "MonthlyRateColumn"
        MonthlyRateColumn.ReadOnly = True
        MonthlyRateColumn.Width = 110
        ' 
        ' PaymentMethodColumn
        ' 
        PaymentMethodColumn.HeaderText = "Payment Method"
        PaymentMethodColumn.Name = "PaymentMethodColumn"
        PaymentMethodColumn.ReadOnly = True
        PaymentMethodColumn.Width = 125
        ' 
        ' StatusColumn
        ' 
        StatusColumn.HeaderText = "Status"
        StatusColumn.Name = "StatusColumn"
        StatusColumn.ReadOnly = True
        StatusColumn.Width = 110
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        Controls.Add(Panel2)
        Name = "History"
        Size = New Size(1094, 730)
        Panel2.ResumeLayout(False)
        PanelRound1.ResumeLayout(False)
        CType(HistoryTable, ComponentModel.ISupportInitialize).EndInit()
        FilterPanel.ResumeLayout(False)
        FilterPanel.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FilterPanel As PanelRound
    Friend WithEvents FilterLbl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateRangeLbl As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents ServiceLbl As Label
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents ServiceComboBox As ComboBox
    Friend WithEvents DateComboBox As ComboBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents HistoryTable As DataGridView
    Friend WithEvents DateColumn As DataGridViewTextBoxColumn
    Friend WithEvents TransactionColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceIDColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndDateColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonthlyRateColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusColumn As DataGridViewTextBoxColumn

End Class