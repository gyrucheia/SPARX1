<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubscriberUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        LblUpdate = New Label()
        lblCustomerId = New Label()
        LblName = New Label()
        LblAddress = New Label()
        LblDateInstalled = New Label()
        LblPlanType = New Label()
        LblStatus = New Label()
        LblMonthlyRate = New Label()
        txtID = New TextBox()
        txtName = New TextBox()
        TxtBoxAddress = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DropDownPlanType = New ComboBox()
        DropDownStatus = New ComboBox()
        MonthlyRate = New TextBox()
        btnCancel = New ButtonRounded()
        btnUpdate = New ButtonRounded()
        SuspendLayout()
        ' 
        ' LblUpdate
        ' 
        LblUpdate.AutoSize = True
        LblUpdate.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblUpdate.Location = New Point(12, 22)
        LblUpdate.Name = "LblUpdate"
        LblUpdate.Size = New Size(92, 31)
        LblUpdate.TabIndex = 2
        LblUpdate.Text = "Update"
        ' 
        ' lblCustomerId
        ' 
        lblCustomerId.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblCustomerId.AutoSize = True
        lblCustomerId.BackColor = Color.Transparent
        lblCustomerId.Font = New Font("Verdana", 11F)
        lblCustomerId.Location = New Point(16, 80)
        lblCustomerId.Name = "lblCustomerId"
        lblCustomerId.Size = New Size(131, 23)
        lblCustomerId.TabIndex = 6
        lblCustomerId.Text = "Customer ID"
        ' 
        ' LblName
        ' 
        LblName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Verdana", 11F)
        LblName.Location = New Point(18, 148)
        LblName.Name = "LblName"
        LblName.Size = New Size(64, 23)
        LblName.TabIndex = 7
        LblName.Text = "Name"
        ' 
        ' LblAddress
        ' 
        LblAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblAddress.AutoSize = True
        LblAddress.BackColor = Color.Transparent
        LblAddress.Font = New Font("Verdana", 11F)
        LblAddress.Location = New Point(18, 214)
        LblAddress.Name = "LblAddress"
        LblAddress.Size = New Size(86, 23)
        LblAddress.TabIndex = 8
        LblAddress.Text = "Address"
        ' 
        ' LblDateInstalled
        ' 
        LblDateInstalled.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblDateInstalled.AutoSize = True
        LblDateInstalled.BackColor = Color.Transparent
        LblDateInstalled.Font = New Font("Verdana", 11F)
        LblDateInstalled.Location = New Point(18, 281)
        LblDateInstalled.Name = "LblDateInstalled"
        LblDateInstalled.Size = New Size(144, 23)
        LblDateInstalled.TabIndex = 9
        LblDateInstalled.Text = "Date Installed"
        ' 
        ' LblPlanType
        ' 
        LblPlanType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblPlanType.AutoSize = True
        LblPlanType.BackColor = Color.Transparent
        LblPlanType.Font = New Font("Verdana", 11F)
        LblPlanType.Location = New Point(18, 342)
        LblPlanType.Name = "LblPlanType"
        LblPlanType.Size = New Size(101, 23)
        LblPlanType.TabIndex = 10
        LblPlanType.Text = "Plan Type"
        ' 
        ' LblStatus
        ' 
        LblStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblStatus.AutoSize = True
        LblStatus.BackColor = Color.Transparent
        LblStatus.Font = New Font("Verdana", 11F)
        LblStatus.Location = New Point(18, 403)
        LblStatus.Name = "LblStatus"
        LblStatus.Size = New Size(70, 23)
        LblStatus.TabIndex = 11
        LblStatus.Text = "Status"
        ' 
        ' LblMonthlyRate
        ' 
        LblMonthlyRate.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblMonthlyRate.AutoSize = True
        LblMonthlyRate.BackColor = Color.Transparent
        LblMonthlyRate.Font = New Font("Verdana", 11F)
        LblMonthlyRate.Location = New Point(18, 465)
        LblMonthlyRate.Name = "LblMonthlyRate"
        LblMonthlyRate.Size = New Size(135, 23)
        LblMonthlyRate.TabIndex = 12
        LblMonthlyRate.Text = "Monthly Rate"
        ' 
        ' txtID
        ' 
        txtID.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtID.BackColor = Color.WhiteSmoke
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Cursor = Cursors.Hand
        txtID.Enabled = False
        txtID.Font = New Font("Segoe UI", 12F)
        txtID.ForeColor = SystemColors.WindowText
        txtID.Location = New Point(187, 80)
        txtID.Margin = New Padding(3, 4, 3, 4)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(156, 34)
        txtID.TabIndex = 11
        txtID.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtName
        ' 
        txtName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtName.BackColor = Color.WhiteSmoke
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Cursor = Cursors.Hand
        txtName.Enabled = False
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.ForeColor = SystemColors.WindowText
        txtName.Location = New Point(187, 148)
        txtName.Margin = New Padding(3, 4, 3, 4)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(299, 34)
        txtName.TabIndex = 11
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' TxtBoxAddress
        ' 
        TxtBoxAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TxtBoxAddress.BackColor = Color.WhiteSmoke
        TxtBoxAddress.BorderStyle = BorderStyle.FixedSingle
        TxtBoxAddress.Cursor = Cursors.Hand
        TxtBoxAddress.Enabled = False
        TxtBoxAddress.Font = New Font("Segoe UI", 12F)
        TxtBoxAddress.ForeColor = SystemColors.WindowText
        TxtBoxAddress.Location = New Point(187, 214)
        TxtBoxAddress.Margin = New Padding(3, 4, 3, 4)
        TxtBoxAddress.Name = "TxtBoxAddress"
        TxtBoxAddress.ReadOnly = True
        TxtBoxAddress.Size = New Size(299, 34)
        TxtBoxAddress.TabIndex = 11
        TxtBoxAddress.TabStop = False
        TxtBoxAddress.TextAlign = HorizontalAlignment.Center
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(187, 281)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(305, 27)
        DateTimePicker1.TabIndex = 18
        ' 
        ' DropDownPlanType
        ' 
        DropDownPlanType.DropDownStyle = ComboBoxStyle.DropDownList
        DropDownPlanType.FormattingEnabled = True
        DropDownPlanType.Items.AddRange(New Object() {"All Plans", "Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})
        DropDownPlanType.Location = New Point(187, 341)
        DropDownPlanType.Name = "DropDownPlanType"
        DropDownPlanType.Size = New Size(140, 28)
        DropDownPlanType.TabIndex = 19
        ' 
        ' DropDownStatus
        ' 
        DropDownStatus.DropDownStyle = ComboBoxStyle.DropDownList
        DropDownStatus.FormattingEnabled = True
        DropDownStatus.Items.AddRange(New Object() {"Active", "Cancelled", "Suspended"})
        DropDownStatus.Location = New Point(187, 398)
        DropDownStatus.Name = "DropDownStatus"
        DropDownStatus.Size = New Size(140, 28)
        DropDownStatus.TabIndex = 20
        ' 
        ' MonthlyRate
        ' 
        MonthlyRate.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        MonthlyRate.BackColor = Color.WhiteSmoke
        MonthlyRate.BorderStyle = BorderStyle.FixedSingle
        MonthlyRate.Cursor = Cursors.Hand
        MonthlyRate.Enabled = False
        MonthlyRate.Font = New Font("Segoe UI", 12F)
        MonthlyRate.ForeColor = SystemColors.WindowText
        MonthlyRate.Location = New Point(187, 460)
        MonthlyRate.Margin = New Padding(3, 4, 3, 4)
        MonthlyRate.Name = "MonthlyRate"
        MonthlyRate.ReadOnly = True
        MonthlyRate.Size = New Size(290, 34)
        MonthlyRate.TabIndex = 11
        MonthlyRate.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnCancel.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        btnCancel.CornerRadius = 8
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 12F)
        btnCancel.ForeColor = Color.White
        'btnCancel.Image = My.Resources.exportReport
        btnCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnCancel.Location = New Point(239, 530)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(134, 37)
        btnCancel.TabIndex = 21
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        btnUpdate.BackColor = Color.FromArgb(CByte(70), CByte(130), CByte(255))
        btnUpdate.CornerRadius = 8
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 12F)
        btnUpdate.ForeColor = Color.White
        'btnUpdate.Image = My.Resources.exportReport
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(388, 530)
        btnUpdate.Margin = New Padding(3, 4, 3, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(134, 37)
        btnUpdate.TabIndex = 22
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' frmSubscriberUpdate
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(534, 599)
        Controls.Add(MonthlyRate)
        Controls.Add(TxtBoxAddress)
        Controls.Add(txtName)
        Controls.Add(txtID)
        Controls.Add(btnUpdate)
        Controls.Add(btnCancel)
        Controls.Add(DropDownStatus)
        Controls.Add(DropDownPlanType)
        Controls.Add(DateTimePicker1)
        Controls.Add(LblMonthlyRate)
        Controls.Add(LblStatus)
        Controls.Add(LblPlanType)
        Controls.Add(LblDateInstalled)
        Controls.Add(LblAddress)
        Controls.Add(LblName)
        Controls.Add(lblCustomerId)
        Controls.Add(LblUpdate)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSubscriberUpdate"
        StartPosition = FormStartPosition.CenterParent
        Text = "frmSubscriberUpdate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblUpdate As Label
    Friend WithEvents lblCustomerId As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblDateInstalled As Label
    Friend WithEvents LblPlanType As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblMonthlyRate As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents TxtBoxAddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DropDownPlanType As ComboBox
    Friend WithEvents DropDownStatus As ComboBox
    Friend WithEvents MonthlyRate As TextBox
    Friend WithEvents btnCancel As ButtonRounded
    Friend WithEvents btnUpdate As ButtonRounded
End Class

