Public Class frmSubscriberUpdate

    Private _subscriberID As Integer
    Private _subscriberName As String
    Private _subscriberAddress As String
    Private _subscriberPlan As String
    Private _subscriberStatus As String
    Private _subscriberDateInstalled As Date
    Private _subscriberMonthlyRate As Decimal
    Private Structure SubscriberData

        Dim CustomerID As String
        Dim Name As String
        Dim Address As String
        Dim PlanType As String
        Dim Status As String
        Dim DateInstalled As Date
        Dim MonthlyRate As Decimal

    End Structure


    Public Sub New(subscriberID As Object, subscriberName As Object, subscriberAddress As Object, subscriberPlan As Object, subscriberStatus As Object, subscriberDateInstalled As Object, subscriberMonthlyRate As Object)
        InitializeComponent()

        If Not subscriberID Is Nothing AndAlso IsNumeric(subscriberID) Then
            _subscriberID = CInt(subscriberID)
        Else
            _subscriberID = -1
        End If

        _subscriberName = If(subscriberName IsNot Nothing, subscriberName.ToString(), "")
        _subscriberAddress = If(subscriberAddress IsNot Nothing, subscriberAddress.ToString(), "")
        _subscriberPlan = If(subscriberPlan IsNot Nothing, subscriberPlan.ToString(), "")
        _subscriberStatus = If(subscriberStatus IsNot Nothing, subscriberStatus.ToString(), "")

        If Not subscriberDateInstalled Is Nothing AndAlso IsDate(subscriberDateInstalled) Then
            _subscriberDateInstalled = CDate(subscriberDateInstalled)
        Else
            _subscriberDateInstalled = DateTime.MinValue
        End If

        If Not subscriberMonthlyRate Is Nothing AndAlso IsNumeric(subscriberMonthlyRate) Then
            _subscriberMonthlyRate = CDec(subscriberMonthlyRate)
        Else
            _subscriberMonthlyRate = 0D
        End If


    End Sub

    Public Property UpdatedData As Hashtable
    Private Function GetRateForPlan(planName As String) As Decimal
        Select Case planName
            Case "Basic 25Mbps"
                Return 700D
            Case "Standard 50Mbps"
                Return 1500D
            Case "Premium 100Mbps"
                Return 1000D
            Case Else
                Return 0.00D
        End Select
    End Function

    ' MOCK DATA FETCHING FUNCTION (Simplified)
    Private Function FetchSubscriberDetailsFromDB(id As Integer) As SubscriberData
        Dim data As New SubscriberData()

        Select Case id
            Case 101, 102, 103
                data.CustomerID = id.ToString()
            Case Else
                Return data
        End Select

        Return data
    End Function


    Private Sub frmSubscriberUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _subscriberID <> -1 Then
            PopulateDropdowns()
            LoadSubscriberDetails()
        Else
            MessageBox.Show("Invalid Subscriber ID provided. Cannot load details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

    End Sub

    Private Sub PopulateDropdowns()

        Me.DropDownPlanType.Items.Clear()
        Me.DropDownPlanType.Items.AddRange(New String() {"Basic 25Mbps", "Standard 50Mbps", "Premium 100Mbps"})

        Me.DropDownStatus.Items.Clear()
        Me.DropDownStatus.Items.AddRange(New String() {"Active", "Suspended", "Cancelled"})
    End Sub

    Private Sub LoadSubscriberDetails()

        Dim subscriberData As SubscriberData = FetchSubscriberDetailsFromDB(_subscriberID)

        If subscriberData.CustomerID Is Nothing Then
            MessageBox.Show("Mock data not found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        txtID.Text = subscriberData.CustomerID
        txtID.ReadOnly = True
        txtID.TabStop = False
        txtID.BackColor = System.Drawing.Color.LightGray
        txtID.HideSelection = True

        txtName.Text = _subscriberName
        txtName.ReadOnly = True
        txtName.TabStop = False
        txtName.BackColor = System.Drawing.Color.LightGray
        txtName.HideSelection = True


        txtBoxAddress.Text = _subscriberAddress
        txtBoxAddress.ReadOnly = True
        txtBoxAddress.TabStop = False
        txtBoxAddress.BackColor = System.Drawing.Color.LightGray
        txtBoxAddress.HideSelection = True


        MonthlyRate.Text = _subscriberMonthlyRate.ToString("C2")
        MonthlyRate.ReadOnly = True
        MonthlyRate.TabStop = False
        MonthlyRate.BackColor = System.Drawing.Color.LightGray
        MonthlyRate.HideSelection = True


        DropDownPlanType.Text = _subscriberPlan
        DropDownStatus.Text = _subscriberStatus

        If _subscriberDateInstalled <> DateTime.MinValue And Me.Controls.Find("DateInstalledPicker", True).Length > 0 Then
            CType(Me.Controls.Find("DateInstalledPicker", True)(0), DateTimePicker).Value = _subscriberDateInstalled
        End If

    End Sub


    Private Sub DropDownPlanType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownPlanType.SelectedIndexChanged

        Dim newRate As Decimal = GetRateForPlan(Me.DropDownPlanType.Text)
        Me.MonthlyRate.Text = newRate.ToString("C2")
        _subscriberMonthlyRate = newRate

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Me.UpdatedData = New Hashtable()
        Me.UpdatedData.Add("customerID", _subscriberID)
        Me.UpdatedData.Add("Name", txtName.Text)
        Me.UpdatedData.Add("Address", TxtBoxAddress.Text)
        Me.UpdatedData.Add("PlanType", DropDownPlanType.Text)
        Me.UpdatedData.Add("Status", DropDownStatus.Text)
        Me.UpdatedData.Add("MonthlyRate", CDec(Me.MonthlyRate.Text.Replace("$", "").Replace("₱", "")))

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub
End Class