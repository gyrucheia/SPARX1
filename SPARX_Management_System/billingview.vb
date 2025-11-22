Public Class billingview
    Private Sub billingview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paymentId As String = "PAY001"
        Dim customerName As String = "Jasmine Raviz"
        Dim planType As String = "Basic 25Mbps"
        Dim amount As Decimal = 700.0
        Dim monthlyRate As String = "₱" & amount.ToString()
        Dim amoutPaid As String = "₱" & amount.ToString()
        Dim paymentDate As String = "2025-06-15"
        Dim status As String = "Paid"
        Dim mop As String = "GCash"


        BillingDetailsDGV.Rows.Add(paymentId, customerName, planType, monthlyRate, amoutPaid, paymentDate, status, mop)
    End Sub

    Private Sub BillingDetailsTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillingDetailsDGV.CellContentClick

    End Sub
End Class
