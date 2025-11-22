Imports LiveCharts
Imports LiveCharts.Wpf
Imports System.Configuration
Imports MySqlConnector
Imports System.Drawing
Imports System.Windows.Media
Imports System.Collections.Generic
Imports LiveCharts.WinForms
Public Class subscriberview
    Inherits UserControl
    Private ReadOnly CONNECTION_STRING As String =
        ConfigurationManager.ConnectionStrings("SparxDb").ConnectionString



    Private ChartAccountStatus As LiveCharts.WinForms.PieChart
    Private ChartSubscribersByPlan As LiveCharts.WinForms.PieChart

    Private Sub subscriberview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the view   
    End Sub
End Class
