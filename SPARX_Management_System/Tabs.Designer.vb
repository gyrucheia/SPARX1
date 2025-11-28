<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tabs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tabs))
        PnlTabs = New Panel()
        HistoryBtn = New Button()
        BillingBtn = New Button()
        SubscriberBtn = New Button()
        InventoryBtn = New Button()
        ServiceBtn = New Button()
        InstallationBtn = New Button()
        SalesBtn = New Button()
        DashboardBtn = New Button()
        ImgLogo = New PictureBox()
        PnlHeader = New Panel()
        PanelRound2 = New PanelRound()
        ImgOnline = New PictureBox()
        LblSystemOnline = New Label()
        PictureBox1 = New PictureBox()
        ImgBell = New PictureBox()
        overview = New Label()
        lblDashboardSuperAdmin = New Label()
        LabelSystemOnline = New Label()
        ImgStatus = New PictureBox()
        Mainexchange = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        PnlTabs.SuspendLayout()
        CType(ImgLogo, ComponentModel.ISupportInitialize).BeginInit()
        PnlHeader.SuspendLayout()
        PanelRound2.SuspendLayout()
        CType(ImgOnline, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgBell, ComponentModel.ISupportInitialize).BeginInit()
        CType(ImgStatus, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlTabs
        ' 
        PnlTabs.BackColor = Color.FromArgb(CByte(29), CByte(41), CByte(61))
        PnlTabs.Controls.Add(Panel1)
        PnlTabs.Controls.Add(HistoryBtn)
        PnlTabs.Controls.Add(BillingBtn)
        PnlTabs.Controls.Add(SubscriberBtn)
        PnlTabs.Controls.Add(InventoryBtn)
        PnlTabs.Controls.Add(ServiceBtn)
        PnlTabs.Controls.Add(InstallationBtn)
        PnlTabs.Controls.Add(SalesBtn)
        PnlTabs.Controls.Add(DashboardBtn)
        PnlTabs.Controls.Add(ImgLogo)
        PnlTabs.Dock = DockStyle.Left
        PnlTabs.Location = New Point(0, 0)
        PnlTabs.Name = "PnlTabs"
        PnlTabs.Size = New Size(240, 1041)
        PnlTabs.TabIndex = 0
        ' 
        ' HistoryBtn
        ' 
        HistoryBtn.AllowDrop = True
        HistoryBtn.FlatAppearance.BorderSize = 0
        HistoryBtn.FlatStyle = FlatStyle.Flat
        HistoryBtn.ForeColor = Color.Transparent
        HistoryBtn.Image = CType(resources.GetObject("HistoryBtn.Image"), Image)
        HistoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        HistoryBtn.Location = New Point(0, 384)
        HistoryBtn.Margin = New Padding(3, 2, 3, 2)
        HistoryBtn.Name = "HistoryBtn"
        HistoryBtn.Padding = New Padding(18, 0, 0, 0)
        HistoryBtn.Size = New Size(240, 39)
        HistoryBtn.TabIndex = 20
        HistoryBtn.Text = "           History"
        HistoryBtn.TextAlign = ContentAlignment.MiddleLeft
        HistoryBtn.UseCompatibleTextRendering = True
        HistoryBtn.UseVisualStyleBackColor = True
        ' 
        ' BillingBtn
        ' 
        BillingBtn.AllowDrop = True
        BillingBtn.FlatAppearance.BorderSize = 0
        BillingBtn.FlatStyle = FlatStyle.Flat
        BillingBtn.ForeColor = Color.Transparent
        BillingBtn.Image = CType(resources.GetObject("BillingBtn.Image"), Image)
        BillingBtn.ImageAlign = ContentAlignment.MiddleLeft
        BillingBtn.Location = New Point(0, 340)
        BillingBtn.Margin = New Padding(3, 2, 3, 2)
        BillingBtn.Name = "BillingBtn"
        BillingBtn.Padding = New Padding(18, 0, 0, 0)
        BillingBtn.Size = New Size(240, 39)
        BillingBtn.TabIndex = 19
        BillingBtn.Text = "           Billing"
        BillingBtn.TextAlign = ContentAlignment.MiddleLeft
        BillingBtn.UseCompatibleTextRendering = True
        BillingBtn.UseVisualStyleBackColor = True
        ' 
        ' SubscriberBtn
        ' 
        SubscriberBtn.AllowDrop = True
        SubscriberBtn.FlatAppearance.BorderSize = 0
        SubscriberBtn.FlatStyle = FlatStyle.Flat
        SubscriberBtn.ForeColor = Color.Transparent
        SubscriberBtn.Image = CType(resources.GetObject("SubscriberBtn.Image"), Image)
        SubscriberBtn.ImageAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.Location = New Point(0, 290)
        SubscriberBtn.Margin = New Padding(3, 2, 3, 2)
        SubscriberBtn.Name = "SubscriberBtn"
        SubscriberBtn.Padding = New Padding(18, 0, 0, 0)
        SubscriberBtn.Size = New Size(240, 39)
        SubscriberBtn.TabIndex = 18
        SubscriberBtn.Text = "           Subscriber"
        SubscriberBtn.TextAlign = ContentAlignment.MiddleLeft
        SubscriberBtn.UseCompatibleTextRendering = True
        SubscriberBtn.UseVisualStyleBackColor = True
        ' 
        ' InventoryBtn
        ' 
        InventoryBtn.AllowDrop = True
        InventoryBtn.FlatAppearance.BorderSize = 0
        InventoryBtn.FlatStyle = FlatStyle.Flat
        InventoryBtn.ForeColor = Color.Transparent
        InventoryBtn.Image = CType(resources.GetObject("InventoryBtn.Image"), Image)
        InventoryBtn.ImageAlign = ContentAlignment.MiddleLeft
        InventoryBtn.Location = New Point(0, 246)
        InventoryBtn.Margin = New Padding(3, 2, 3, 2)
        InventoryBtn.Name = "InventoryBtn"
        InventoryBtn.Padding = New Padding(18, 0, 0, 0)
        InventoryBtn.Size = New Size(240, 39)
        InventoryBtn.TabIndex = 17
        InventoryBtn.Text = "           Inventory"
        InventoryBtn.TextAlign = ContentAlignment.MiddleLeft
        InventoryBtn.UseCompatibleTextRendering = True
        InventoryBtn.UseVisualStyleBackColor = True
        ' 
        ' ServiceBtn
        ' 
        ServiceBtn.AllowDrop = True
        ServiceBtn.FlatAppearance.BorderSize = 0
        ServiceBtn.FlatStyle = FlatStyle.Flat
        ServiceBtn.ForeColor = Color.Transparent
        ServiceBtn.Image = CType(resources.GetObject("ServiceBtn.Image"), Image)
        ServiceBtn.ImageAlign = ContentAlignment.MiddleLeft
        ServiceBtn.Location = New Point(0, 202)
        ServiceBtn.Margin = New Padding(3, 2, 3, 2)
        ServiceBtn.Name = "ServiceBtn"
        ServiceBtn.Padding = New Padding(18, 0, 0, 0)
        ServiceBtn.Size = New Size(240, 39)
        ServiceBtn.TabIndex = 16
        ServiceBtn.Text = "           Service"
        ServiceBtn.TextAlign = ContentAlignment.MiddleLeft
        ServiceBtn.UseCompatibleTextRendering = True
        ServiceBtn.UseVisualStyleBackColor = True
        ' 
        ' InstallationBtn
        ' 
        InstallationBtn.AllowDrop = True
        InstallationBtn.FlatAppearance.BorderSize = 0
        InstallationBtn.FlatStyle = FlatStyle.Flat
        InstallationBtn.ForeColor = Color.Transparent
        InstallationBtn.Image = Global.SPARX_Management_System.My.Resources.installation
        InstallationBtn.ImageAlign = ContentAlignment.MiddleLeft
        InstallationBtn.Location = New Point(0, 159)
        InstallationBtn.Margin = New Padding(3, 2, 3, 2)
        InstallationBtn.Name = "InstallationBtn"
        InstallationBtn.Padding = New Padding(18, 0, 0, 0)
        InstallationBtn.Size = New Size(240, 39)
        InstallationBtn.TabIndex = 15
        InstallationBtn.Text = "           Installation"
        InstallationBtn.TextAlign = ContentAlignment.MiddleLeft
        InstallationBtn.UseCompatibleTextRendering = True
        InstallationBtn.UseVisualStyleBackColor = True
        ' 
        ' SalesBtn
        ' 
        SalesBtn.FlatAppearance.BorderSize = 0
        SalesBtn.FlatStyle = FlatStyle.Flat
        SalesBtn.ForeColor = Color.Transparent
        SalesBtn.Image = CType(resources.GetObject("SalesBtn.Image"), Image)
        SalesBtn.ImageAlign = ContentAlignment.MiddleLeft
        SalesBtn.Location = New Point(0, 116)
        SalesBtn.Margin = New Padding(3, 2, 3, 2)
        SalesBtn.Name = "SalesBtn"
        SalesBtn.Padding = New Padding(18, 0, 0, 0)
        SalesBtn.Size = New Size(240, 39)
        SalesBtn.TabIndex = 14
        SalesBtn.Text = "           Sales"
        SalesBtn.TextAlign = ContentAlignment.MiddleLeft
        SalesBtn.UseVisualStyleBackColor = True
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.ForeColor = Color.Transparent
        DashboardBtn.Image = Global.SPARX_Management_System.My.Resources.dashboard
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(0, 72)
        DashboardBtn.Margin = New Padding(3, 2, 3, 2)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(18, 0, 0, 0)
        DashboardBtn.Size = New Size(240, 39)
        DashboardBtn.TabIndex = 13
        DashboardBtn.Text = "           Dashboard"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' ImgLogo
        ' 
        ImgLogo.Image = CType(resources.GetObject("ImgLogo.Image"), Image)
        ImgLogo.Location = New Point(41, 12)
        ImgLogo.Name = "ImgLogo"
        ImgLogo.Size = New Size(117, 55)
        ImgLogo.TabIndex = 1
        ImgLogo.TabStop = False
        ' 
        ' PnlHeader
        ' 
        PnlHeader.BackColor = Color.White
        PnlHeader.Controls.Add(PanelRound2)
        PnlHeader.Controls.Add(PictureBox1)
        PnlHeader.Controls.Add(ImgBell)
        PnlHeader.Controls.Add(overview)
        PnlHeader.Controls.Add(lblDashboardSuperAdmin)
        PnlHeader.Location = New Point(240, 0)
        PnlHeader.Name = "PnlHeader"
        PnlHeader.Size = New Size(1940, 67)
        PnlHeader.TabIndex = 1
        ' 
        ' PanelRound2
        ' 
        PanelRound2.BackColor = SystemColors.Control
        PanelRound2.Controls.Add(ImgOnline)
        PanelRound2.Controls.Add(LblSystemOnline)
        PanelRound2.CornerRadius = 8
        PanelRound2.Location = New Point(1412, 18)
        PanelRound2.Name = "PanelRound2"
        PanelRound2.Size = New Size(118, 31)
        PanelRound2.TabIndex = 12
        ' 
        ' ImgOnline
        ' 
        ImgOnline.Image = CType(resources.GetObject("ImgOnline.Image"), Image)
        ImgOnline.Location = New Point(6, 11)
        ImgOnline.Name = "ImgOnline"
        ImgOnline.Size = New Size(12, 10)
        ImgOnline.SizeMode = PictureBoxSizeMode.Zoom
        ImgOnline.TabIndex = 8
        ImgOnline.TabStop = False
        ' 
        ' LblSystemOnline
        ' 
        LblSystemOnline.AutoSize = True
        LblSystemOnline.Font = New Font("Verdana", 9F)
        LblSystemOnline.Location = New Point(20, 8)
        LblSystemOnline.Name = "LblSystemOnline"
        LblSystemOnline.Size = New Size(97, 14)
        LblSystemOnline.TabIndex = 7
        LblSystemOnline.Text = "System Online"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1578, 20)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(12, 10)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' ImgBell
        ' 
        ImgBell.Location = New Point(1566, 23)
        ImgBell.Name = "ImgBell"
        ImgBell.Size = New Size(24, 24)
        ImgBell.SizeMode = PictureBoxSizeMode.Zoom
        ImgBell.TabIndex = 10
        ImgBell.TabStop = False
        ' 
        ' overview
        ' 
        overview.AutoSize = True
        overview.ForeColor = SystemColors.ControlDarkDark
        overview.Location = New Point(26, 36)
        overview.Name = "overview"
        overview.Size = New Size(216, 15)
        overview.TabIndex = 4
        overview.Text = "Overview of Sparx Fiber Internet System"
        ' 
        ' lblDashboardSuperAdmin
        ' 
        lblDashboardSuperAdmin.AutoSize = True
        lblDashboardSuperAdmin.Font = New Font("Verdana", 12F)
        lblDashboardSuperAdmin.Location = New Point(26, 16)
        lblDashboardSuperAdmin.Name = "lblDashboardSuperAdmin"
        lblDashboardSuperAdmin.Size = New Size(95, 18)
        lblDashboardSuperAdmin.TabIndex = 3
        lblDashboardSuperAdmin.Text = "Dashboard"
        ' 
        ' LabelSystemOnline
        ' 
        LabelSystemOnline.AutoSize = True
        LabelSystemOnline.Font = New Font("Verdana", 9F)
        LabelSystemOnline.Location = New Point(20, 8)
        LabelSystemOnline.Name = "LabelSystemOnline"
        LabelSystemOnline.Size = New Size(97, 14)
        LabelSystemOnline.TabIndex = 7
        LabelSystemOnline.Text = "System Online"
        ' 
        ' ImgStatus
        ' 
        ImgStatus.Image = CType(resources.GetObject("ImgStatus.Image"), Image)
        ImgStatus.Location = New Point(6, 11)
        ImgStatus.Name = "ImgStatus"
        ImgStatus.Size = New Size(12, 10)
        ImgStatus.SizeMode = PictureBoxSizeMode.Zoom
        ImgStatus.TabIndex = 8
        ImgStatus.TabStop = False
        ' 
        ' Mainexchange
        ' 
        Mainexchange.BackColor = Color.White
        Mainexchange.Location = New Point(240, 67)
        Mainexchange.Name = "Mainexchange"
        Mainexchange.Size = New Size(1837, 1068)
        Mainexchange.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(7, 964)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(230, 65)
        Panel1.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(161, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 15
        Label1.Text = "         "
        ' 
        ' Button1
        ' 
        Button1.AllowDrop = True
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(-9, 19)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(18, 0, 0, 0)
        Button1.Size = New Size(231, 39)
        Button1.TabIndex = 14
        Button1.Text = "           admin@gmail.com"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseCompatibleTextRendering = True
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Tabs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1041)
        Controls.Add(Mainexchange)
        Controls.Add(PnlHeader)
        Controls.Add(PnlTabs)
        Name = "Tabs"
        Text = "AdminTabs"
        PnlTabs.ResumeLayout(False)
        CType(ImgLogo, ComponentModel.ISupportInitialize).EndInit()
        PnlHeader.ResumeLayout(False)
        PnlHeader.PerformLayout()
        PanelRound2.ResumeLayout(False)
        PanelRound2.PerformLayout()
        CType(ImgOnline, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgBell, ComponentModel.ISupportInitialize).EndInit()
        CType(ImgStatus, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlTabs As Panel
    Friend WithEvents ImgLogo As PictureBox
    Friend WithEvents PnlHeader As Panel
    Friend WithEvents Mainexchange As Panel
    Friend WithEvents HistoryBtn As Button
    Friend WithEvents BillingBtn As Button
    Friend WithEvents SubscriberBtn As Button
    Friend WithEvents InventoryBtn As Button
    Friend WithEvents ServiceBtn As Button
    Friend WithEvents InstallationBtn As Button
    Friend WithEvents SalesBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents overview As Label
    Friend WithEvents lblDashboardSuperAdmin As Label
    Friend WithEvents ImgStatus As PictureBox
    Friend WithEvents LabelSystemOnline As Label
    Friend WithEvents PanelRound1 As PanelRound
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImgBell As PictureBox
    Friend WithEvents PanelRound2 As PanelRound
    Friend WithEvents ImgOnline As PictureBox
    Friend WithEvents LblSystemOnline As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class

