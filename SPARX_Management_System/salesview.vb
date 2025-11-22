Imports System.Configuration
Imports MySqlConnector
Imports LiveCharts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Drawing
Imports System.Windows.Media
Imports System.Collections.Generic
Public Class salesview
    Private ReadOnly CONNECTION_STRING As String =
        ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString

    ' Chart control
    Private ChartMonthlySales As LiveCharts.WinForms.CartesianChart

    ' Timer for real-time updates
    Private updateTimer As Timer

    Private Sub dgvRecentSales_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If dgvRecentSales.Columns(e.ColumnIndex).DataPropertyName = "MonthlyRate" Then
            If e.Value IsNot Nothing Then
                Dim rate As Decimal = Convert.ToDecimal(e.Value)
                e.Value = "P" & rate.ToString("N0") ' Format as P700, P1,000, etc.
                e.FormattingApplied = True
            End If
        End If
        If dgvRecentSales.Columns(e.ColumnIndex).DataPropertyName = "DateInstalled" Then
            If e.Value IsNot Nothing Then
                Dim installDate As DateTime = Convert.ToDateTime(e.Value)
                e.Value = installDate.ToString("yyyy-MM-dd")
                e.FormattingApplied = True
            End If
        End If
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgvRecentSales.Columns(e.ColumnIndex).DataPropertyName = "PlanType" Then

                Select Case e.Value.ToString

                    Case "Basic 25Mbps"
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240) ' Light Gray
                        e.CellStyle.ForeColor = System.Drawing.Color.Black

                    Case "Standard 50Mbps"
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(204, 229, 255) ' Light Blue
                        e.CellStyle.ForeColor = System.Drawing.Color.MidnightBlue

                    Case "Premium 100Mbps"
                        e.CellStyle.BackColor = System.Drawing.Color.FromArgb(204, 255, 204) ' Light Green
                        e.CellStyle.ForeColor = System.Drawing.Color.DarkGreen

                    Case Else
                        e.CellStyle.BackColor = System.Drawing.Color.White

                End Select

                e.CellStyle.Font = New Font(e.CellStyle.Font, FontStyle.Regular)
                e.CellStyle.SelectionBackColor = e.CellStyle.BackColor
                e.FormattingApplied = True

            End If
        End If

    End Sub
    Private Sub AdjustDGVHeight()
        If dgvRecentSales.Rows.Count > 0 Then
            ' Calculate the total height needed:
            Dim headerHeight As Integer = dgvRecentSales.ColumnHeadersHeight
            Dim totalRowHeight As Integer = 0

            ' Sum the height of all rows
            For Each row As DataGridViewRow In dgvRecentSales.Rows
                totalRowHeight += row.Height
            Next

            ' Add some padding (e.g., 5 pixels)
            Dim newHeight As Integer = headerHeight + totalRowHeight + 5

            ' Apply the new height to the DataGridView
            ' CRITICAL: Ensure the GroupBox is also large enough, 
            ' or dock the DGV/change the anchor.
            dgvRecentSales.Height = newHeight

            ' You might need to adjust the height of the parent GroupBox too:
            ' GBRecentSalesDetails.Height = newHeight + (GroupBox Title Area)
        Else
            ' Set a default height if there are no records
            dgvRecentSales.Height = 50
        End If

        ' Force a layout update
        dgvRecentSales.Refresh()
        Me.PerformLayout()
    End Sub
    Private Function GetTotalSales() As Integer
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM installation WHERE MONTH(installation_date) = MONTH(CURDATE()) AND YEAR(installation_date) = YEAR(CURDATE())"
                Using cmd As New MySqlCommand(query, conn)
                    Return Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Function GetMonthlyRevenue() As Decimal
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()
                Dim query As String = "SELECT COALESCE(SUM(amount_paid), 0) FROM payment WHERE MONTH(date_of_payment) = MONTH(CURDATE()) AND YEAR(date_of_payment) = YEAR(CURDATE())"
                Using cmd As New MySqlCommand(query, conn)
                    Return Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Function GetAvgRevenue() As Decimal
        Try
            Dim totalSales As Integer = GetTotalSales()
            If totalSales > 0 Then
                Dim revenue As Decimal = GetMonthlyRevenue()
                Return revenue / totalSales
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Private Sub UpdateSalesLabel()
        Dim salesValue As Integer = GetTotalSales()
        TotalSales.Text = salesValue.ToString() ' Just number, no currency

        Dim monthlyRevenue As Decimal = GetMonthlyRevenue()
        MonthlyRev.Text = "₱" & monthlyRevenue.ToString("N2") ' Format with peso sign

        Dim avgRevenue As Decimal = GetAvgRevenue()
        AvgRev.Text = "₱" & avgRevenue.ToString("N2") ' Format with peso sign
    End Sub
    Private Sub PopulateDropdowns()

        Me.CBDateRange.Items.Clear()
        Me.CBDateRange.Items.Add("All Time")
        Me.CBDateRange.Items.AddRange(New String() {
        "January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
        })

        Me.CBPlanType.Items.Clear()
        Me.CBPlanType.Items.Add("All Plans")
        Me.CBPlanType.Items.AddRange(New String() {"Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})

    End Sub
    Private Sub salesview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateDropdowns()
        Me.CBDateRange.SelectedIndex = 0
        Me.CBPlanType.SelectedIndex = 0

        ' Create chart
        CreateSalesChart()

        ' Load data
        UpdateSalesLabel()
        LoadMonthlySalesChart()
        LoadRecentSales()

        ' Add event handlers for filters
        AddHandler CBDateRange.SelectedIndexChanged, AddressOf Filters_Changed
        AddHandler CBPlanType.SelectedIndexChanged, AddressOf Filters_Changed

        ' Setup timer for real-time updates (every 30 seconds)
        updateTimer = New Timer()
        updateTimer.Interval = 30000  ' 30 seconds
        AddHandler updateTimer.Tick, AddressOf Timer_Tick
        updateTimer.Start()
    End Sub

    ' Timer tick - refresh chart and data automatically
    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        UpdateSalesLabel()
        LoadMonthlySalesChart()
        LoadRecentSales()
    End Sub
    ' Create the monthly sales volume bar chart
    Private Sub CreateSalesChart()
        ChartMonthlySales = New LiveCharts.WinForms.CartesianChart()
        ChartMonthlySales.Dock = DockStyle.Fill
        ChartMonthlySales.BackColor = System.Drawing.Color.White
        ChartMonthlySales.Location = New Point(0, 40)
        ChartMonthlySales.Size = New Size(pnlMonthlySalesVol.Width, pnlMonthlySalesVol.Height - 50)
        PanelRound1.Controls.Add(ChartMonthlySales)
        ChartMonthlySales.BringToFront()
    End Sub
    ' Load monthly sales volume data into chart
    ' Load monthly sales volume data into chart
    Private Sub LoadMonthlySalesChart()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' Build query using customer table (it has date_installed)
                Dim query As String = "SELECT MONTHNAME(date_installed) AS month_name, COUNT(*) AS sales_count FROM customer WHERE date_installed IS NOT NULL"

                ' Apply date filter if selected
                If CBDateRange.SelectedItem IsNot Nothing AndAlso CBDateRange.SelectedItem.ToString() <> "All Time" Then
                    Dim monthName As String = CBDateRange.SelectedItem.ToString()
                    query &= " AND MONTHNAME(date_installed) = '" & monthName & "'"
                Else
                    ' If "All Time", get data for current year
                    query &= " AND YEAR(date_installed) = YEAR(CURDATE())"
                End If

                ' Apply plan type filter if selected
                If CBPlanType.SelectedItem IsNot Nothing AndAlso CBPlanType.SelectedItem.ToString() <> "All Plans" Then
                    Dim planFilter As String = CBPlanType.SelectedItem.ToString()
                    If planFilter.StartsWith("Basic") Then
                        query &= " AND plan_type = 'Basic'"
                    ElseIf planFilter.StartsWith("Standard") Then
                        query &= " AND plan_type = 'Standard'"
                    ElseIf planFilter.StartsWith("Premium") Then
                        query &= " AND plan_type = 'Premium'"
                    End If
                End If

                query &= " GROUP BY MONTH(date_installed), MONTHNAME(date_installed) ORDER BY MONTH(date_installed)"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim monthlyData As New Dictionary(Of String, Integer)()

                        While reader.Read()
                            Dim monthName As String = reader("month_name").ToString()
                            Dim count As Integer = Convert.ToInt32(reader("sales_count"))
                            monthlyData(monthName) = count
                        End While

                        ' Get current month and show 6 months before and 6 months after (13 months total)
                        Dim currentMonth As Integer = DateTime.Now.Month
                        Dim currentYear As Integer = DateTime.Now.Year
                        Dim monthLabels As New List(Of String)()
                        Dim monthNumbers As New List(Of Integer)()

                        ' Generate month labels starting from 6 months ago to 6 months ahead
                        For i As Integer = -6 To 6
                            Dim monthIndex As Integer = currentMonth + i
                            Dim yearOffset As Integer = 0

                            ' Handle year rollover
                            While monthIndex < 1
                                monthIndex += 12
                                yearOffset -= 1
                            End While
                            While monthIndex > 12
                                monthIndex -= 12
                                yearOffset += 1
                            End While

                            Dim monthName As String = New DateTime(currentYear + yearOffset, monthIndex, 1).ToString("MMM")
                            monthLabels.Add(monthName)
                            monthNumbers.Add(monthIndex)
                        Next

                        ' Convert to chart format
                        Dim values As New ChartValues(Of Double)()
                        Dim displayLabels As New List(Of String)()

                        For i As Integer = 0 To monthLabels.Count - 1
                            Dim monthLabel As String = monthLabels(i)
                            Dim found As Boolean = False

                            For Each kvp In monthlyData
                                If kvp.Key.StartsWith(monthLabel, StringComparison.OrdinalIgnoreCase) Then
                                    values.Add(kvp.Value)
                                    found = True
                                    Exit For
                                End If
                            Next

                            If Not found Then
                                values.Add(0)
                            End If

                            displayLabels.Add(monthLabel)
                        Next

                        ' Update chart
                        If Me.InvokeRequired Then
                            Me.Invoke(New Action(Sub() UpdateSalesChart(values, displayLabels)))
                        Else
                            UpdateSalesChart(values, displayLabels)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales chart: " & ex.Message)
        End Try
    End Sub

    ' Helper to update the sales chart with horizontal scrolling
    Private Sub UpdateSalesChart(values As ChartValues(Of Double), labels As List(Of String))
        If ChartMonthlySales.Series.Count = 0 Then
            ' First time: setup chart
            Dim axisX As New Axis()
            axisX.Title = "Month"
            axisX.Labels = labels
            axisX.MinValue = 0
            axisX.MaxValue = labels.Count - 1
            ChartMonthlySales.AxisX.Add(axisX)

            Dim axisY As New Axis()
            axisY.Title = "Sales Volume"
            axisY.MinValue = 0
            ChartMonthlySales.AxisY.Add(axisY)

            Dim series As New ColumnSeries()
            series.Title = "Sales"
            series.Values = values
            series.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(59, 130, 246))
            ChartMonthlySales.Series.Add(series)

            ' Enable horizontal scrolling/zooming
            ChartMonthlySales.Zoom = ZoomingOptions.X
            ChartMonthlySales.Pan = PanningOptions.X
        Else
            ' Update existing chart
            ChartMonthlySales.Series(0).Values = values
            If ChartMonthlySales.AxisX.Count > 0 Then
                ChartMonthlySales.AxisX(0).Labels = labels
            End If
        End If
    End Sub
    ' Load recent sales from database
    Private Sub LoadRecentSales()
        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                ' Build query - use customer table directly since it has date_installed
                ' Get ALL customers, not just recent ones
                Dim query As String = "SELECT customer_id, first_name, last_name, date_installed, plan_type, monthly_rate FROM customer WHERE 1=1"

                ' Add date filter (only if date_installed is not NULL)
                If CBDateRange.SelectedItem IsNot Nothing AndAlso CBDateRange.SelectedItem.ToString() <> "All Time" Then
                    Dim monthName As String = CBDateRange.SelectedItem.ToString()
                    query &= " AND date_installed IS NOT NULL AND MONTHNAME(date_installed) = '" & monthName & "'"
                End If

                ' Add plan type filter - convert display name to enum value
                If CBPlanType.SelectedItem IsNot Nothing AndAlso CBPlanType.SelectedItem.ToString() <> "All Plans" Then
                    Dim planFilter As String = CBPlanType.SelectedItem.ToString()
                    ' Convert "Basic 25Mbps" to "Basic", etc.
                    If planFilter.StartsWith("Basic") Then
                        query &= " AND plan_type = 'Basic'"
                    ElseIf planFilter.StartsWith("Standard") Then
                        query &= " AND plan_type = 'Standard'"
                    ElseIf planFilter.StartsWith("Premium") Then
                        query &= " AND plan_type = 'Premium'"
                    End If
                End If

                ' Order by date_installed, but handle NULLs (put them last)
                ' Show all customers (remove LIMIT or set to higher number)
                query &= " ORDER BY CASE WHEN date_installed IS NULL THEN 1 ELSE 0 END, date_installed DESC, customer_id DESC"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim salesRecords As New List(Of SalesRecord)()

                        ' Debug: Check column names in the result set
                        For i As Integer = 0 To reader.FieldCount - 1
                            Debug.WriteLine($"Column {i}: {reader.GetName(i)}")
                        Next

                        Dim recordCount As Integer = 0
                        While reader.Read()
                            recordCount += 1
                            Try
                                Debug.WriteLine($"Processing record #{recordCount}")
                                Dim record As New SalesRecord()

                                ' Debug: Log all column values for this record
                                For i As Integer = 0 To reader.FieldCount - 1
                                    Dim colName = reader.GetName(i)
                                    Dim colValue = If(reader.IsDBNull(i), "<NULL>", reader.GetValue(i).ToString())
                                    Debug.WriteLine($"  {colName} = {colValue}")
                                Next

                                ' Format Customer ID as C001, C002, etc.
                                Dim customerId As Integer = 0
                                If Not reader.IsDBNull(reader.GetOrdinal("customer_id")) Then
                                    customerId = Convert.ToInt32(reader("customer_id"))
                                    record.CustomerID = "C" & customerId.ToString().PadLeft(3, "0"c)
                                End If

                                ' Combine first and last name
                                Dim firstName As String = ""
                                Dim lastName As String = ""

                                If Not reader.IsDBNull(reader.GetOrdinal("first_name")) Then
                                    firstName = reader("first_name").ToString()
                                End If

                                If Not reader.IsDBNull(reader.GetOrdinal("last_name")) Then
                                    lastName = reader("last_name").ToString()
                                End If

                                record.Name = (firstName & " " & lastName).Trim()

                                ' Get date installed (handle NULL)
                                If Not reader.IsDBNull(reader.GetOrdinal("date_installed")) Then
                                    record.DateInstalled = Convert.ToDateTime(reader("date_installed"))
                                Else
                                    record.DateInstalled = DateTime.Now ' Default to today if NULL
                                End If

                                ' Convert plan_type enum to display format
                                Dim planType As String = ""
                                If Not reader.IsDBNull(reader.GetOrdinal("plan_type")) Then
                                    planType = reader("plan_type").ToString()
                                End If

                                Select Case planType
                                    Case "Basic"
                                        record.PlanType = "Basic 25Mbps"
                                    Case "Standard"
                                        record.PlanType = "Standard 50Mbps"
                                    Case "Premium"
                                        record.PlanType = "Premium 100Mbps"
                                    Case Else
                                        record.PlanType = If(String.IsNullOrEmpty(planType), "Unknown Plan", planType)
                                End Select

                                ' Get monthly rate
                                If Not reader.IsDBNull(reader.GetOrdinal("monthly_rate")) Then
                                    record.MonthlyRate = Convert.ToDecimal(reader("monthly_rate"))
                                Else
                                    record.MonthlyRate = 0
                                End If

                                salesRecords.Add(record)
                                Debug.WriteLine($"Successfully added record for {record.Name}")
                            Catch ex As Exception
                                ' Log error for this specific record but continue
                                Debug.WriteLine($"Error processing record #{recordCount}: {ex.Message}")
                                Debug.WriteLine($"Stack trace: {ex.StackTrace}")
                            End Try
                        End While
                        Debug.WriteLine($"Total records processed: {recordCount}, Records added: {salesRecords.Count}")

                        ' Debug: Log the final record count
                        Debug.WriteLine($"About to bind {salesRecords.Count} records to DataGridView")

                        ' Clear the current data source
                        dgvRecentSales.DataSource = Nothing
                        Application.DoEvents()

                        ' Set the new data source
                        Try
                            ' Ensure we have records to display
                            If salesRecords.Count = 0 Then
                                Debug.WriteLine("No records to display")
                                dgvRecentSales.DataSource = Nothing
                                Return
                            End If

                            ' Create a new BindingSource and set its DataSource
                            Dim bindingSource As New BindingSource()
                            bindingSource.DataSource = salesRecords
                            bindingSource.AllowNew = False ' Prevent adding new rows

                            ' Set the DataGridView's DataSource to the BindingSource
                            dgvRecentSales.DataSource = bindingSource
                            dgvRecentSales.ClearSelection()

                            ' Enable scrolling for the DataGridView
                            dgvRecentSales.ScrollBars = ScrollBars.Vertical

                            ' Ensure all rows are visible (don't limit height)
                            dgvRecentSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None

                            ' Log the actual number of rows in the DataGridView
                            Debug.WriteLine($"DataGridView row count after binding: {dgvRecentSales.Rows.Count}")
                            Debug.WriteLine($"Expected row count: {salesRecords.Count}")

                            ' Force the DataGridView to update and refresh
                            dgvRecentSales.Refresh()
                            dgvRecentSales.Update()
                            dgvRecentSales.Invalidate()
                            dgvRecentSales.PerformLayout()

                            ' Ensure the DataGridView is visible and enabled for scrolling
                            dgvRecentSales.Visible = True

                            ' Force the parent GroupBox to refresh as well
                            If dgvRecentSales.Parent IsNot Nothing Then
                                dgvRecentSales.Parent.Refresh()
                            End If

                            ' Ensure scrolling is enabled
                            dgvRecentSales.ScrollBars = ScrollBars.Vertical

                            ' Make sure all rows are visible (check if there's a display issue)
                            If dgvRecentSales.Rows.Count <> salesRecords.Count Then
                                Debug.WriteLine($"WARNING: Row count mismatch! DGV shows {dgvRecentSales.Rows.Count} but we loaded {salesRecords.Count}")
                            End If

                        Catch ex As Exception
                            Debug.WriteLine($"Error binding data to DataGridView: {ex.Message}")
                            Debug.WriteLine($"Stack trace: {ex.StackTrace}")
                            MessageBox.Show($"Error displaying data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                        ' Force a layout update
                        dgvRecentSales.PerformLayout()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recent sales: " & ex.Message)
        End Try
    End Sub

    ' When filters change, reload data
    Private Sub Filters_Changed(sender As Object, e As EventArgs)
        UpdateSalesLabel()
        LoadMonthlySalesChart()
        LoadRecentSales()
    End Sub
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' You can implement export to CSV/Excel here
        MessageBox.Show("Export functionality - to be implemented")
    End Sub

    ' Mock Functions - For Testing Only - Replace with Actual Data Retrieval Logic

    Private Function GetTotalSales_MOCK() As Decimal

        Return 10.99

    End Function

    Private Function GetMonthlyRevenue_MOCK() As Decimal

        Return 45873.5D

    End Function

    Private Function GetAvgRevenue_MOCK() As Decimal

        Return 145.75D

    End Function




    Private Sub dgvRecentSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    ' Clean up timer when form is disposed

End Class
Public Class SalesRecord

    Public Property CustomerID As String

    Public Property Name As String

    Public Property DateInstalled As Date

    Public Property PlanType As String

    Public Property MonthlyRate As Decimal

End Class
