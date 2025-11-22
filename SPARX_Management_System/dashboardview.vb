Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Configuration
Imports MySqlConnector
Imports System.Drawing
Imports System.Windows.Media
Imports System.Collections.Generic
Imports LiveCharts.WinForms

Public Class dashboardview

    ' Database connection
    Private _connectionString As String = Nothing
    Private ReadOnly Property CONNECTION_STRING As String
        Get
            If _connectionString Is Nothing AndAlso Not DesignMode Then
                Try
                    _connectionString = ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString
                Catch
                    _connectionString = String.Empty
                End Try
            End If
            Return If(_connectionString IsNot Nothing, _connectionString, String.Empty)
        End Get
    End Property

    ' Chart controls (use WinForms version explicitly)
    Private ChartSubscriberGrowth As LiveCharts.WinForms.CartesianChart
    Private ChartServiceStatus As LiveCharts.WinForms.PieChart
    Private ChartSubscribersByPlan As LiveCharts.WinForms.PieChart

    ' Timer
    Private updateTimer As Timer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub LblSubscribers_Click(sender As Object, e As EventArgs) Handles AmountSubscribers.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dashboardview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Create the charts
        CreateCharts()
        LoadKPIData()
        ' Load data
        LoadSubscriberChart()
        LoadServiceStatusChart()
        LoadSubscribersByPlanChart() ' Call the new function

        ' Setup timer
        updateTimer = New Timer()
        updateTimer.Interval = 30000  ' 30 seconds
        AddHandler updateTimer.Tick, AddressOf Timer_Tick
        updateTimer.Start()
    End Sub

    ' Create chart controls and add them to panels
    Private Sub CreateCharts()
        ' Create Subscriber Growth Bar Chart
        ChartSubscriberGrowth = New LiveCharts.WinForms.CartesianChart()
        ChartSubscriberGrowth.Dock = DockStyle.Fill
        ChartSubscriberGrowth.BackColor = System.Drawing.Color.White
        ' The following size/location properties might conflict with designer elements if Dock=Fill is used
        ' ChartSubscriberGrowth.Location = New Point(0, 40)
        ' ChartSubscriberGrowth.Size = New Size(PanelRound5.Width, PanelRound5.Height - 50)
        Panel1.Controls.Add(ChartSubscriberGrowth) ' Assuming Panel1 is where the chart goes inside the parent PanelRound5
        ChartSubscriberGrowth.BringToFront()

        ' Create Service Status Pie Chart
        ChartServiceStatus = New LiveCharts.WinForms.PieChart()
        ChartServiceStatus.Dock = DockStyle.Fill
        ChartServiceStatus.BackColor = System.Drawing.Color.White
        ' ChartServiceStatus.Location = New Point(0, 40)
        ' ChartServiceStatus.Size = New Size(PanelRound6.Width, PanelRound6.Height - 50)
        ChartServiceStatus.LegendLocation = LegendLocation.None ' Using custom designer labels for legend
        Panel2.Controls.Add(ChartServiceStatus) ' Assuming Panel2 is where the chart goes inside the parent PanelRound6
        ChartServiceStatus.BringToFront()

        ' Create Subscribers By Plan Pie Chart (for Panel3)
        ChartSubscribersByPlan = New LiveCharts.WinForms.PieChart()
        ChartSubscribersByPlan.Dock = DockStyle.Fill
        ChartSubscribersByPlan.BackColor = System.Drawing.Color.White
        ChartSubscribersByPlan.LegendLocation = LegendLocation.None ' Using custom designer labels for legend
        Panel3.Controls.Add(ChartSubscribersByPlan) ' Assuming Panel3 is where the chart goes inside the parent PanelSubscribersPlan
        ChartSubscribersByPlan.BringToFront()
    End Sub

    ' Timer tick event to refresh charts
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        LoadSubscriberChart()
        LoadServiceStatusChart()
        LoadSubscribersByPlanChart()
    End Sub

    Private Sub LoadKPIData()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' 1. Get Total Subscribers (Active)
                Dim totalSubscribersQuery As String = "SELECT COUNT(*) FROM customer WHERE account_status = 'Active'"
                Using cmd As New MySqlCommand(totalSubscribersQuery, conn)
                    Dim totalSubs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountSubscribers.Text = totalSubs.ToString("N0") ' Format with commas
                    PercentTotalSub.Text = "+12% from last month"
                    PercentTotalSub.ForeColor = System.Drawing.Color.FromArgb(0, 201, 80) ' Green
                End Using

                ' 2. Get Monthly Revenue
                ' Column name is 'date_of_payment'
                Dim revenueQuery As String = "SELECT COALESCE(SUM(amount_paid), 0) FROM payment WHERE MONTH(date_of_payment) = MONTH(CURDATE()) AND YEAR(date_of_payment) = YEAR(CURDATE())"
                Using cmd As New MySqlCommand(revenueQuery, conn)
                    Dim revenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    AmountMonthlyRev.Text = "₱" & revenue.ToString("N2")
                    PercentMonthlyRev.Text = "+8% from last month"
                    PercentMonthlyRev.ForeColor = System.Drawing.Color.FromArgb(0, 201, 80) ' Green
                End Using

                ' 3. Get Active Installations -> Using customer table status as 'installation' table doesn't exist
                Dim installationsQuery As String = "SELECT COUNT(*) FROM customer WHERE account_status IN ('In Progress', 'Pending')"
                Using cmd As New MySqlCommand(installationsQuery, conn)
                    Dim activeInstalls As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountActiveInstall.Text = activeInstalls.ToString()
                    PercentActiveInstall.Text = "+5% from last month"
                    PercentActiveInstall.ForeColor = System.Drawing.Color.FromArgb(0, 201, 80) ' Green
                End Using

                ' 4. Get Pending Services -> Using customer table status as 'Service.Request' table doesn't exist
                Dim pendingServicesQuery As String = "SELECT COUNT(*) FROM customer WHERE account_status = 'Pending'"
                Using cmd As New MySqlCommand(pendingServicesQuery, conn)
                    Dim pendingServices As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountPendingServices.Text = pendingServices.ToString()
                    PercentPendingService.Text = "-15% from last month"
                    PercentPendingService.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68) ' Red
                End Using
                ' Get Basic Plan Subscribers (PanelRound7)
                Dim basicQuery As String = "SELECT COUNT(*) FROM customer WHERE plan_type = 'Basic' AND account_status = 'Active'"
                Using cmd As New MySqlCommand(basicQuery, conn)
                    Dim basicSubs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountBasic.Text = basicSubs.ToString("N0")
                End Using

                ' Get Standard Plan Subscribers (PanelRound8)
                Dim standardQuery As String = "SELECT COUNT(*) FROM customer WHERE plan_type = 'Standard' AND account_status = 'Active'"
                Using cmd As New MySqlCommand(standardQuery, conn)
                    Dim standardSubs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountStandard.Text = standardSubs.ToString("N0")
                End Using

                ' Get Premium Plan Subscribers (PanelRound9)
                Dim premiumQuery As String = "SELECT COUNT(*) FROM customer WHERE plan_type = 'Premium' AND account_status = 'Active'"
                Using cmd As New MySqlCommand(premiumQuery, conn)
                    Dim premiumSubs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    AmountPremium.Text = premiumSubs.ToString("N0")
                End Using


            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading KPI data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSystemAlerts()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                Dim alerts As New List(Of String)()

                ' Check for low stock inventory
                Dim lowStockQuery As String = "SELECT COUNT(*) FROM inventory WHERE quantity <= 10"
                Using cmd As New MySqlCommand(lowStockQuery, conn)
                    Dim lowStockCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If lowStockCount > 0 Then
                        alerts.Add("Low Stock Inventory: " & lowStockCount & " items need restocking")
                    End If
                End Using

                ' Check pending installations -> Using customer table status/date installed
                Dim pendingInstallsQuery As String = "SELECT COUNT(*) FROM customer WHERE account_status = 'Pending' AND DATE(date_installed) = DATE_ADD(CURDATE(), INTERVAL 1 DAY)"
                Using cmd As New MySqlCommand(pendingInstallsQuery, conn)
                    Dim pendingCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If pendingCount > 0 Then
                        alerts.Add(pendingCount & " pending installations tomorrow")
                    End If
                End Using

                ' Check revenue target
                ' Column name is 'date_of_payment'
                Dim revenueQuery As String = "SELECT COALESCE(SUM(amount_paid), 0) FROM payment WHERE MONTH(date_of_payment) = MONTH(CURDATE()) AND YEAR(date_of_payment) = YEAR(CURDATE())"

                Using cmd As New MySqlCommand(revenueQuery, conn)
                    Dim revenue As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    Dim target As Decimal = 2000000
                    If revenue >= target Then
                        Dim percentage As Integer = CInt((revenue / target) * 100)
                        alerts.Add("Monthly revenue target reached (" & percentage & "%)")
                    End If
                End Using

                ' Display alerts (you'll need to add a ListBox or Label to PanelRound10)
                If alerts.Count > 0 Then
                    LabelSystemAlert.Text = String.Join(vbCrLf, alerts)
                Else
                    LabelSystemAlert.Text = "No alerts at this time"
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading alerts: " & ex.Message)
        End Try
    End Sub

    ' Load data into subscriber growth bar chart
    ' Load data into subscriber growth bar chart
    Private Sub LoadSubscriberChart()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' This query correctly selects data from the last 6 months dynamically
                Dim query As String = "SELECT MONTH(date_installed) AS month_num, MONTHNAME(date_installed) AS month_name, COUNT(*) AS subscriber_count FROM customer WHERE date_installed >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) GROUP BY MONTH(date_installed), MONTHNAME(date_installed) ORDER BY MONTH(date_installed)"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim monthlyData As New SortedDictionary(Of Integer, Integer)() ' Use month number as key

                        While reader.Read()
                            Dim monthNum As Integer = Convert.ToInt32(reader("month_num"))
                            Dim count As Integer = Convert.ToInt32(reader("subscriber_count"))
                            monthlyData(monthNum) = count
                        End While

                        ' --- DYNAMIC MONTH GENERATION ---
                        Dim labelsList As New List(Of String)
                        Dim valuesList As New ChartValues(Of Double)()
                        Dim today As DateTime = DateTime.Now

                        ' Iterate back 6 months from the current month
                        For i As Integer = -5 To 0
                            Dim monthDate As DateTime = today.AddMonths(i)
                            ' Get the short month name (e.g., "Nov")
                            Dim monthName As String = monthDate.ToString("MMM")
                            Dim monthKey As Integer = monthDate.Month

                            labelsList.Add(monthName)

                            ' Find the corresponding count in the fetched data
                            If monthlyData.ContainsKey(monthKey) Then
                                valuesList.Add(monthlyData(monthKey))
                            Else
                                valuesList.Add(0)
                            End If
                        Next

                        ' Convert dynamic list to array for updating the chart
                        Dim dynamicLabels() As String = labelsList.ToArray()

                        ' Update chart (thread-safe)
                        If Me.InvokeRequired Then
                            Me.Invoke(New Action(Sub() UpdateSubscriberChart(valuesList, dynamicLabels)))
                        Else
                            UpdateSubscriberChart(valuesList, dynamicLabels)
                        End If
                        ' ---------------------------------
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subscriber chart: " & ex.Message)
        End Try
    End Sub


    ' Helper function to update the subscriber chart
    ' Helper function to update the subscriber chart
    Private Sub UpdateSubscriberChart(values As ChartValues(Of Double), monthLabels() As String)
        If ChartSubscriberGrowth.Series.Count = 0 Then
            ' First time: setup chart
            Dim axisX As New Axis()
            axisX.Title = "Month"
            ' Use the dynamic labels passed in
            axisX.Labels = New List(Of String)(monthLabels)
            ' This formatter fixes the alignment issue we had previously:
            axisX.LabelFormatter = Function(value) axisX.Labels(CInt(value))
            ChartSubscriberGrowth.AxisX.Add(axisX)

            Dim axisY As New Axis()
            ' ... (Y-axis setup code remains the same, using 3000 max/750 step) ...
            axisY.Title = "Subscribers"
            axisY.MinValue = 0
            axisY.MaxValue = 3000.0
            axisY.Separator = New Separator() With {.Step = 750.0}
            axisY.LabelFormatter = Function(value) value.ToString("N0")
            ChartSubscriberGrowth.AxisY.Add(axisY)

            Dim series As New ColumnSeries()
            series.Title = "Subscribers"
            series.Values = values
            series.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(59, 130, 246))
            ChartSubscriberGrowth.Series.Add(series)
        Else
            ' Update existing chart
            ChartSubscriberGrowth.Series(0).Values = values
            ' Also update the labels on subsequent calls
            ChartSubscriberGrowth.AxisX(0).Labels = New List(Of String)(monthLabels)
        End If
    End Sub


    ' Load data into service status pie chart
    Private Sub LoadServiceStatusChart()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' Query reads the status directly from the 'customer' table
                Dim query As String = "SELECT account_status AS status, COUNT(*) AS count FROM customer GROUP BY account_status"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim statusData As New Dictionary(Of String, Integer)()

                        While reader.Read()
                            Dim status As String = reader("status").ToString()
                            Dim count As Integer = Convert.ToInt32(reader("count"))
                            statusData(status) = count
                        End While

                        ' Calculate total for percentages
                        Dim total As Integer = 0
                        For Each value In statusData.Values
                            total += value
                        Next

                        ' Create pie chart slices
                        Dim pieSeries As New SeriesCollection()

                        For Each kvp In statusData
                            Dim percentage As Double = If(total > 0, (kvp.Value / total) * 100, 0)

                            Dim pieSeriesItem As New PieSeries()
                            ' Format title: "Status (Percent%)"
                            pieSeriesItem.Title = String.Format("{0} ({1:F0}%)", kvp.Key, percentage)
                            pieSeriesItem.Values = New ChartValues(Of Double)({kvp.Value})
                            pieSeriesItem.DataLabels = False ' Use designer labels instead

                            ' Set colors based on status (matching image colors)
                            Select Case kvp.Key.ToLower().Trim()
                                Case "completed"
                                    ' Green color: RGB(34, 197, 94)
                                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 197, 94))
                                Case "in progress", "in-progress"
                                    ' Dark Orange color: RGB(251, 146, 60)
                                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(251, 146, 60))
                                Case "pending"
                                    ' Lighter Orange color: RGB(253, 186, 116)
                                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(253, 186, 116))
                            End Select

                            pieSeries.Add(pieSeriesItem)
                        Next

                        ' Update chart (thread-safe)
                        If Me.InvokeRequired Then
                            Me.Invoke(New Action(Sub() ChartServiceStatus.Series = pieSeries))
                        Else
                            ChartServiceStatus.Series = pieSeries
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading service status chart: " & ex.Message)
        End Try
    End Sub

    ' Load data into the Subscribers By Plan pie chart (uses customer data, optionally JOINs payment table)
    Private Sub LoadSubscribersByPlanChart()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' Query: Use customer table grouped by plan_type
                Dim query As String = "SELECT plan_type, COUNT(*) AS count FROM customer WHERE account_status = 'Active' GROUP BY plan_type"

                ' If you specifically need ONLY customers who have a record in the payment table:
                ' Dim query As String = "SELECT c.plan_type, COUNT(DISTINCT c.customer_id) AS count FROM customer c JOIN payment p ON c.customer_id = p.customer_id GROUP BY c.plan_type"


                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim planData As New Dictionary(Of String, Integer)()

                        While reader.Read()
                            planData(reader("plan_type").ToString()) = Convert.ToInt32(reader("count"))
                        End While

                        ' Update chart (thread-safe)
                        If Me.InvokeRequired Then
                            Me.Invoke(New Action(Sub() UpdateSubscribersByPlanChart(planData)))
                        Else
                            UpdateSubscribersByPlanChart(planData)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subscribers by plan chart: " & ex.Message)
        End Try
    End Sub

    ' Helper function to update the subscribers by plan chart
    Private Sub UpdateSubscribersByPlanChart(planData As Dictionary(Of String, Integer))
        Dim total As Integer = 0
        For Each value In planData.Values
            total += value
        Next

        Dim pieSeries As New SeriesCollection()

        For Each kvp In planData
            Dim percentage As Double = If(total > 0, (kvp.Value / total) * 100, 0)
            Dim displayText As String = String.Format("{0}: {1} subscribers ({2:F0}% of total)", kvp.Key, kvp.Value, percentage)

            Dim pieSeriesItem As New PieSeries()
            pieSeriesItem.Title = displayText
            pieSeriesItem.Values = New ChartValues(Of Double)({kvp.Value})
            pieSeriesItem.DataLabels = False

            ' Set colors based on plan type
            Select Case kvp.Key.ToLower().Trim()
                Case "basic"
                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(59, 130, 246))
                Case "standard"
                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 197, 94))
                Case "premium"
                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(139, 92, 246))
                Case Else
                    pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Colors.Gray)
            End Select

            pieSeries.Add(pieSeriesItem)
        Next

        Me.ChartSubscribersByPlan.Series = pieSeries
    End Sub

    Private Sub PanelRound2_Paint(sender As Object, e As PaintEventArgs) Handles PanelRound2.Paint

    End Sub
End Class
