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

    Private ChartAccountStatus As LiveCharts.WinForms.PieChart
    Private ChartSubscribersByPlan As LiveCharts.WinForms.PieChart

    Private Sub subscriberview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the view   
    End Sub
End Class
