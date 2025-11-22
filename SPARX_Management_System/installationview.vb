Imports System.Configuration
Imports MySqlConnector
Imports LiveCharts.WinForms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Drawing
Imports System.Windows.Media
Imports System.Collections.Generic

Public Class installationview
	Private ReadOnly CONNECTION_STRING As String =
		ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString


	Private InstallationStatus As LiveCharts.WinForms.PieChart


	Private updateTimer As Timer

	' Fix 1: Modified installationview_Load
	Private Sub installationview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Create the pie chart
		CreateCharts()

		' Load data into the chart
		LoadInstallationStatusChart()

		' Setup timer for auto-refresh (every 30 seconds)
		updateTimer = New Timer()
		updateTimer.Interval = 30000  ' 30 seconds
		AddHandler updateTimer.Tick, AddressOf Timer_Tick
		updateTimer.Start()
	End Sub


	Private Sub CreateCharts()
		' Make sure Panel1 exists and is visible
		If Panel1 Is Nothing Then
			MessageBox.Show("Panel1 not found! Check your Designer file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Return
		End If

		' Create the pie chart
		InstallationStatus = New LiveCharts.WinForms.PieChart()
		InstallationStatus.Dock = DockStyle.Fill
		InstallationStatus.BackColor = System.Drawing.Color.White
		InstallationStatus.LegendLocation = LegendLocation.Bottom

		' Ensure Panel1 is visible and has a size
		Panel1.Visible = True
		If Panel1.Width = 0 Or Panel1.Height = 0 Then
			Panel1.Size = New Size(634, 434) ' Set default size from Designer
		End If

		' Add chart to panel
		Panel1.Controls.Add(InstallationStatus)
		InstallationStatus.BringToFront()

		' Force refresh
		InstallationStatus.Refresh()
		Panel1.Refresh()
	End Sub


	Private Sub LoadInstallationStatusChart()
		Try
			Using conn As New MySqlConnection(CONNECTION_STRING)
				conn.Open()

				' Query to get count of installations by status
				' Using services table where service_type = 'Installation'
				' Note: service_type enum is ('Installation',' Repair') - note the space before Repair
				Dim query As String = "SELECT status, COUNT(*) AS count " &
									  "FROM services " &
									  "WHERE service_type = 'Installation' " &
									  "GROUP BY status"

				' Debug: Check total count first
				Dim totalCheckQuery As String = "SELECT COUNT(*) FROM services WHERE service_type = 'Installation'"
				Using checkCmd As New MySqlCommand(totalCheckQuery, conn)
					Dim totalCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
					System.Diagnostics.Debug.WriteLine("=== DEBUG: Total installations found: " & totalCount.ToString())

					If totalCount = 0 Then
						' Check what service_types actually exist
						Dim typeCheckQuery As String = "SELECT DISTINCT service_type FROM services"
						Using typeCmd As New MySqlCommand(typeCheckQuery, conn)
							Using typeReader As MySqlDataReader = typeCmd.ExecuteReader()
								System.Diagnostics.Debug.WriteLine("=== DEBUG: Available service_types in database:")
								Dim hasData As Boolean = False
								While typeReader.Read()
									hasData = True
									System.Diagnostics.Debug.WriteLine("  - '" & typeReader("service_type").ToString() & "'")
								End While
								If Not hasData Then
									System.Diagnostics.Debug.WriteLine("  - No services table data found!")
								End If
							End Using
						End Using
					End If
				End Using

				Using cmd As New MySqlCommand(query, conn)
					Using reader As MySqlDataReader = cmd.ExecuteReader()
						' Create dictionary to store status data
						Dim statusData As New Dictionary(Of String, Integer)()

						' Read data from database
						While reader.Read()
							Dim status As String = reader("status").ToString()
							Dim count As Integer = Convert.ToInt32(reader("count"))
							statusData(status) = count
							Debug.WriteLine("Found status: " & status & " with count: " & count.ToString())
						End While

						Debug.WriteLine("Total statuses found: " & statusData.Count.ToString())

						' Check if we have data
						If statusData.Count = 0 Then
							' No data - show empty chart instead of message
							' You can add sample data for testing, or the chart will just be empty
							Dim emptySeries As New SeriesCollection()
							If Me.InvokeRequired Then
								Me.Invoke(New Action(Sub()
														 InstallationStatus.Series = emptySeries
														 InstallationStatus.Refresh()
													 End Sub))
							Else
								InstallationStatus.Series = emptySeries
								InstallationStatus.Refresh()
							End If
							Return
						End If

						' Calculate total for percentages
						Dim total As Integer = 0
						For Each value In statusData.Values
							total += value
						Next

						' Create pie chart series
						Dim pieSeries As New SeriesCollection()

						For Each kvp In statusData
							Dim percentage As Double = If(total > 0, (kvp.Value / total) * 100, 0)
							Dim displayText As String = String.Format("{0} ({1:F0}%)", kvp.Key, percentage)

							Dim pieSeriesItem As New PieSeries()
							pieSeriesItem.Title = displayText
							pieSeriesItem.Values = New ChartValues(Of Double)({kvp.Value})
							pieSeriesItem.DataLabels = False

							' Set colors based on status (matching the image)
							Select Case kvp.Key.ToLower().Trim()
								Case "completed"
									pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(34, 197, 94))    ' Green
								Case "in progress", "in-progress"
									pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(251, 146, 60)) ' Orange
								Case "requested", "pending"
									pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(253, 186, 116))     ' Light Orange
								Case "cancelled", "canceled"
									pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Color.FromRgb(239, 68, 68))    ' Red
								Case Else
									pieSeriesItem.Fill = New SolidColorBrush(System.Windows.Media.Colors.Gray)
							End Select

							pieSeries.Add(pieSeriesItem)
						Next

						' Update chart (thread-safe)
						If Me.InvokeRequired Then
							Me.Invoke(New Action(Sub()
													 InstallationStatus.Series = pieSeries
													 InstallationStatus.Refresh()
												 End Sub))
						Else
							InstallationStatus.Series = pieSeries
							InstallationStatus.Refresh()
						End If
					End Using
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Error loading installation status chart: " & ex.Message & vbCrLf & vbCrLf & "Stack trace: " & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	' Timer tick event - refreshes chart data every 30 seconds
	Private Sub Timer_Tick(sender As Object, e As EventArgs)
		LoadInstallationStatusChart()
	End Sub

End Class
