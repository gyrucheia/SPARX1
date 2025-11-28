Imports System.Configuration
Imports MySqlConnector

Public Class EditInfo
    ' Public properties to receive the current data from the Profile form
    Public CustomerId As Integer
    Public FirstName As String
    Public LastName As String
    Public EmailAddress As String
    Public ContactNumber As String

    ' Private field for connection string (similar to Profile class)
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

    ' ... Designer generated code ...

    Private Sub EditInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the TextBoxes with the existing data
        FNTxtBox.Text = FirstName
        LNTxtBox.Text = LastName
        EmailTxtBox.Text = EmailAddress
        PhoneTxtBox.Text = ContactNumber
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        ' Logic to update the database
        If UpdateUserData() Then
            ' Update the public properties to reflect changes before closing
            FirstName = FNTxtBox.Text.Trim()
            LastName = LNTxtBox.Text.Trim()
            EmailAddress = EmailTxtBox.Text.Trim()
            ContactNumber = PhoneTxtBox.Text.Trim()

            MessageBox.Show("Personal information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK ' Set DialogResult for Profile to check
            Me.Close()
        Else
            ' Keep the form open if update failed
            Me.DialogResult = DialogResult.None
        End If
    End Sub

    Private Function UpdateUserData() As Boolean
        If CustomerId <= 0 Then
            MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                Dim updateQuery As String = "UPDATE customer SET first_name = @fn, last_name = @ln, email_address = @email, contact_number = @phone WHERE customer_id = @id"

                Using cmd As New MySqlCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@fn", FNTxtBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@ln", LNTxtBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", EmailTxtBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@phone", PhoneTxtBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", CustomerId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    Return rowsAffected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database update failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.DialogResult = DialogResult.Cancel ' Set DialogResult
        Me.Close()
    End Sub

End Class