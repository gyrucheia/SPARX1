Imports System.Configuration
Imports MySqlConnector

Public Class Profile

    Public CurrentCustomerId As Integer
    Public CurrentFirstName As String
    Public CurrentLastName As String
    Public CurrentEmail As String
    Public CurrentContactNumber As String
    ' Address properties (these must hold the data for editing)
    Public CurrentCountry As String
    Public CurrentProvince As String
    Public CurrentMunicipality As String
    Public CurrentBarangay As String
    Public CurrentLandmark As String

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

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all subscriber data from database
        LoadSubscriberData()
    End Sub

    ' In Public Class Profile

    Private Sub LoadSubscriberData()
        If CurrentCustomerId > 0 Then
            Try
                Using conn As New MySqlConnection(CONNECTION_STRING)
                    conn.Open()

                    ' FIX 1: Update query to select the new 5 address columns, not the old installation_address column.
                    Dim query As String = "SELECT first_name, last_name, email_address, contact_number, " &
                                        "billing_address, plan_type, monthly_rate, account_status, " &
                                        "country, province, municipality, barangay, landmark " & ' <--- NEW ADDRESS COLUMNS
                                        "FROM customer WHERE customer_id = @customerId"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@customerId", CurrentCustomerId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' --- 1. PERSONAL INFORMATION ---
                                Dim firstName As String = If(reader("first_name") IsNot DBNull.Value, reader("first_name").ToString(), "")
                                Dim lastName As String = If(reader("last_name") IsNot DBNull.Value, reader("last_name").ToString(), "")
                                Dim email As String = If(reader("email_address") IsNot DBNull.Value, reader("email_address").ToString(), "")
                                Dim phone As String = If(reader("contact_number") IsNot DBNull.Value, reader("contact_number").ToString(), "")

                                ' REMOVE THIS LINE: Dim installationAddress As String = If(reader("installation_address") IsNot DBNull.Value, reader("installation_address").ToString(), "") ' <-- RETRIEVE ADDRESS

                                ' NEW: Read the 5 separate address columns directly
                                CurrentCountry = If(reader("country") IsNot DBNull.Value, reader("country").ToString(), "")
                                CurrentProvince = If(reader("province") IsNot DBNull.Value, reader("province").ToString(), "")
                                CurrentMunicipality = If(reader("municipality") IsNot DBNull.Value, reader("municipality").ToString(), "")
                                CurrentBarangay = If(reader("barangay") IsNot DBNull.Value, reader("barangay").ToString(), "")
                                CurrentLandmark = If(reader("landmark") IsNot DBNull.Value, reader("landmark").ToString(), "")

                                ' Set class variables for personal info
                                CurrentFirstName = firstName
                                CurrentLastName = lastName
                                CurrentEmail = email
                                CurrentContactNumber = phone

                                ' Update UI labels for personal info
                                HelloLbl.Text = "Hello, " & firstName & "!"
                                UserFNLbl.Text = firstName
                                UserLNLbl.Text = lastName
                                UserEmailLbl.Text = email
                                UserPhoneLbl.Text = phone

                                ' --- 2. ADDRESS INFORMATION ---
                                ' FIX 2: Call the new display function that uses the class variables
                                DisplayAddressLabels()

                                ' (Additional logic to display plan/billing info goes here)
                            Else
                                ' ... Fallback logic ...
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading subscriber data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DisplayFallbackData()
            End Try
        Else
            DisplayFallbackData()
        End If
    End Sub
    Private Sub DisplayAddressLabels()
        ' Update UI Labels using the class properties populated from the database
        UserCountryLbl.Text = CurrentCountry
        UserProvinceLbl.Text = CurrentProvince
        UserMunLbl.Text = CurrentMunicipality
        UserBrgyLbl.Text = CurrentBarangay
        UserLandmarkLbl.Text = CurrentLandmark
    End Sub
    Private Sub DisplayFallbackData()
        ' Sets UI labels using current class properties if DB loading fails
        HelloLbl.Text = "Hello, " & CurrentFirstName & "!"
        UserFNLbl.Text = CurrentFirstName
        UserLNLbl.Text = CurrentLastName
        UserEmailLbl.Text = CurrentEmail
        UserPhoneLbl.Text = CurrentContactNumber
        UserCountryLbl.Text = CurrentCountry
        UserProvinceLbl.Text = CurrentProvince
        UserMunLbl.Text = CurrentMunicipality
        UserBrgyLbl.Text = CurrentBarangay
        UserLandmarkLbl.Text = CurrentLandmark
    End Sub

    Private Sub ParseAndDisplayAddress(addressString As String)
        ' Parse address string and populate address fields and class variables

        Dim country As String = ""
        Dim province As String = ""
        Dim municipality As String = ""
        Dim barangay As String = ""
        Dim landmark As String = ""

        If String.IsNullOrEmpty(addressString) OrElse addressString = "Default Installation Address" Then
            ' All parts remain empty (initialized above)
        Else
            ' Try to parse address - common format is assumed to be comma-separated
            Dim addressParts As String() = addressString.Split(","c)

            If addressParts.Length >= 5 Then
                ' Assume format: Landmark, Barangay, Municipality, Province, Country (5 parts)
                landmark = addressParts(0).Trim()
                barangay = addressParts(1).Trim()
                municipality = addressParts(2).Trim()
                province = addressParts(3).Trim()
                country = addressParts(4).Trim()
            ElseIf addressParts.Length >= 4 Then
                ' Assume format: Barangay, Municipality, Province, Country (4 parts, no explicit Landmark/Street)
                barangay = addressParts(0).Trim()
                municipality = addressParts(1).Trim()
                province = addressParts(2).Trim()
                country = addressParts(3).Trim()
                landmark = ""
            Else
                ' Store entire address as landmark if format is unknown
                landmark = addressString.Trim()
            End If
        End If

        ' --- CRITICAL FIX: ASSIGN PARSED VALUES TO CLASS VARIABLES ---
        CurrentCountry = country
        CurrentProvince = province
        CurrentMunicipality = municipality
        CurrentBarangay = barangay
        CurrentLandmark = landmark

        ' Update UI Labels
        UserCountryLbl.Text = country
        UserProvinceLbl.Text = province
        UserMunLbl.Text = municipality
        UserBrgyLbl.Text = barangay
        UserLandmarkLbl.Text = landmark

    End Sub

    Private Sub PanelRound3_Paint(sender As Object, e As PaintEventArgs)
        ' Placeholder
    End Sub

    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs)
        ' Placeholder
    End Sub

    Private Sub EditInfoBtn_Click(sender As Object, e As EventArgs) Handles EditInfoBtn.Click
        Dim editInfoForm As New EditInfo()

        ' Pass the current data
        editInfoForm.CustomerId = CurrentCustomerId
        editInfoForm.FirstName = CurrentFirstName
        editInfoForm.LastName = CurrentLastName
        editInfoForm.EmailAddress = CurrentEmail
        editInfoForm.ContactNumber = CurrentContactNumber

        Dim result As DialogResult = editInfoForm.ShowDialog()

        If result = DialogResult.OK Then
            ' Update was successful, reload the data to refresh the Profile UI
            LoadSubscriberData()
        End If

        editInfoForm.Dispose()
    End Sub

    Private Sub EditAddressBtn_Click(sender As Object, e As EventArgs) Handles EditAddressBtn.Click
        Dim editAddressForm As New EditAddress()

        ' PASSING DATA TO THE EDIT FORM (Now correctly populated by ParseAndDisplayAddress)
        editAddressForm.CustomerId = CurrentCustomerId
        ' NOTE: The names of the properties below MUST match the Public/Friend properties
        ' declared in your EditAddress class (e.g., Public Property Country As String).
        ' Assuming these properties ARE correctly named in EditAddress, this is correct.
        editAddressForm.Country = CurrentCountry
        editAddressForm.Province = CurrentProvince
        editAddressForm.Municipality = CurrentMunicipality
        editAddressForm.Barangay = CurrentBarangay
        editAddressForm.Landmark = CurrentLandmark

        Dim result As DialogResult = editAddressForm.ShowDialog()

        ' ERROR FIX 1: Remove the undeclared 'cmd.ExecuteNonQuery()'.
        ' This line tries to use a command object ('cmd') which is neither
        ' declared in this method nor accessible from the class level.
        ' Database updates happen *inside* the EditAddress form, not here.
        ' Dim rowsAffected As Integer = cmd.ExecuteNonQuery() <--- REMOVE THIS

        If result = DialogResult.OK Then
            ' RELOAD DATA AFTER SUCCESSFUL UPDATE
            ' This refreshes the Profile screen with the newly saved data.
            LoadSubscriberData()
        End If

        editAddressForm.Dispose()
    End Sub
End Class