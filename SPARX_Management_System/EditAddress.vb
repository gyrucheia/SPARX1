Imports System.Configuration
Imports MySqlConnector

' This file contains the complete logic for the Address Editing Form.
' It is updated to correctly read from and write to the 5 new address columns 
' (country, province, municipality, barangay, landmark) in the 'customer' table.

Public Class EditAddress
    ' Connection string should be set publicly or passed from the main form
    Public Shared CONNECTION_STRING As String = "Server=localhost;Database=sparx;Uid=root;Pwd=;"

    ' Public property to receive the Customer ID from the Profile form
    Public CustomerId As Integer

    ' -----------------------------------------------------------------
    ' *** FIX: ADD THESE PUBLIC PROPERTIES TO RESOLVE ALL ERRORS ***
    ' -----------------------------------------------------------------
    Public Property Country As String = String.Empty
    Public Property Province As String = String.Empty
    Public Property Municipality As String = String.Empty
    Public Property Barangay As String = String.Empty
    Public Property Landmark As String = String.Empty
    ' -----------------------------------------------------------------
    Private Sub EditAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize all location data when the form loads
        LoadCountries() ' This calls LoadProvinces()

        ' --- NEW CODE TO SET DEFAULT PROVINCE (Camarines Norte) ---
        If CmbProvince.Items.Count > 1 Then
            ' Search for "Camarines Norte" in the province list
            Dim dt As DataTable = DirectCast(CmbProvince.DataSource, DataTable)
            For Each row As DataRow In dt.Rows
                If row("province_name").ToString().Equals("Camarines Norte", StringComparison.OrdinalIgnoreCase) Then
                    CmbProvince.SelectedValue = row("province_id")
                    Exit For
                End If
            Next
        End If
        ' -----------------------------------------------------------

        ' Check if we have a customer ID to load existing data
        If CustomerId > 0 Then
            ' Load the customer's existing address data from the database
            LoadExistingAddress(CustomerId)
        End If
    End Sub
    Private Sub CmbProvince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProvince.SelectedIndexChanged
        ' Triggered when a province is selected to load the municipalities within it
        If CmbProvince.SelectedIndex > 0 AndAlso CmbProvince.SelectedValue IsNot DBNull.Value Then
            Dim provinceId As Integer = CInt(CmbProvince.SelectedValue)
            LoadMunicipalities(provinceId)
        Else
            ' Clear Municipality and Barangay if Province is reset (e.g., set to "Select Province")
            CmbMunicipality.DataSource = Nothing
            CmbMunicipality.Items.Clear()
            CmbBarangay.DataSource = Nothing
            CmbBarangay.Items.Clear()
        End If
    End Sub

    Private Sub CmbMunicipality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMunicipality.SelectedIndexChanged
        ' Triggered when a municipality is selected to load the barangays within it
        If CmbMunicipality.SelectedIndex > 0 AndAlso CmbMunicipality.SelectedValue IsNot DBNull.Value Then
            Dim municipalityId As Integer = CInt(CmbMunicipality.SelectedValue)
            LoadBarangays(municipalityId)
        Else
            ' Clear Barangay if Municipality is reset
            CmbBarangay.DataSource = Nothing
            CmbBarangay.Items.Clear()
        End If
    End Sub


    Private Sub LoadCountries()
        ' NOTE: Assuming all customers are in the Philippines for this setup
        Dim dt As New DataTable()
        dt.Columns.Add("id", GetType(Integer))
        dt.Columns.Add("name", GetType(String))

        ' Add the Philippines as the only option
        dt.Rows.Add(1, "Philippines")

        CmbCountry.DataSource = dt
        CmbCountry.DisplayMember = "name"
        CmbCountry.ValueMember = "id"
        CmbCountry.SelectedIndex = 0 ' Automatically select Philippines

        ' Load Provinces for the selected country
        If dt.Rows.Count > 0 Then
            LoadProvinces()
        End If
    End Sub

    Private Sub LoadProvinces()
        ' NOTE: This requires a 'provinces' table in your database with 'country_id', 'province_id', and 'province_name'
        Dim conn As MySqlConnection = Nothing
        Try
            conn = New MySqlConnection(CONNECTION_STRING)
            conn.Open()

            ' Select all provinces, assume country_id 1 is Philippines
            Dim selectQuery As String = "SELECT province_id, province_name FROM provinces WHERE country_id = 1 ORDER BY province_name"
            Using cmd As New MySqlCommand(selectQuery, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Add a default selection row
                    Dim defaultRow As DataRow = dt.NewRow()
                    defaultRow("province_id") = 0
                    defaultRow("province_name") = "-- Select Province --"
                    dt.Rows.InsertAt(defaultRow, 0)

                    CmbProvince.DataSource = dt
                    CmbProvince.DisplayMember = "province_name"
                    CmbProvince.ValueMember = "province_id"
                    CmbProvince.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            ' Error handling for missing tables or connection issues
            MessageBox.Show("Database Error: Could not load Province data. Ensure the 'provinces' table exists and is correctly structured. Details: " & ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub LoadMunicipalities(ByVal provinceId As Integer)
        ' NOTE: This requires a 'municipalities' table with 'municipality_id', 'province_id', and 'municipality_name'
        Dim conn As MySqlConnection = Nothing
        Try
            conn = New MySqlConnection(CONNECTION_STRING)
            conn.Open()

            Dim selectQuery As String = "SELECT municipality_id, municipality_name FROM municipalities WHERE province_id = @provinceId ORDER BY municipality_name"
            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@provinceId", provinceId)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Add a default selection row
                    Dim defaultRow As DataRow = dt.NewRow()
                    defaultRow("municipality_id") = 0
                    defaultRow("municipality_name") = "-- Select Municipality --"
                    dt.Rows.InsertAt(defaultRow, 0)

                    CmbMunicipality.DataSource = dt
                    CmbMunicipality.DisplayMember = "municipality_name"
                    CmbMunicipality.ValueMember = "municipality_id"
                    CmbMunicipality.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: Could not load Municipality data. Ensure the 'municipalities' table exists. Details: " & ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub LoadBarangays(ByVal municipalityId As Integer)
        ' NOTE: This requires a 'barangays' table with 'barangay_id', 'municipality_id', and 'barangay_name'
        Dim conn As MySqlConnection = Nothing
        Try
            conn = New MySqlConnection(CONNECTION_STRING)
            conn.Open()

            Dim selectQuery As String = "SELECT barangay_id, barangay_name FROM barangays WHERE municipality_id = @municipalityId ORDER BY barangay_name"
            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@municipalityId", municipalityId)

                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Add a default selection row
                    Dim defaultRow As DataRow = dt.NewRow()
                    defaultRow("barangay_id") = 0
                    defaultRow("barangay_name") = "-- Select Barangay --"
                    dt.Rows.InsertAt(defaultRow, 0)

                    CmbBarangay.DataSource = dt
                    CmbBarangay.DisplayMember = "barangay_name"
                    CmbBarangay.ValueMember = "barangay_id"
                    CmbBarangay.SelectedIndex = 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: Could not load Barangay data. Ensure the 'barangays' table exists. Details: " & ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub



    ' *** UPDATED: Reads 5 separate columns directly from the database ***
    Private Sub LoadExistingAddress(ByVal customerId As Integer)
        If customerId = 0 OrElse CONNECTION_STRING = String.Empty Then Return

        Dim conn As MySqlConnection = Nothing
        Try
            conn = New MySqlConnection(CONNECTION_STRING)
            conn.Open()

            ' NEW QUERY: Selects the 5 separate address columns
            Dim selectQuery As String = "SELECT country, province, municipality, barangay, landmark " &
                                        "FROM customer WHERE customer_id = @customerId"

            Using cmd As New MySqlCommand(selectQuery, conn)
                cmd.Parameters.AddWithValue("@customerId", customerId)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' 1. Load values from the reader
                        Dim currentCountry As String = reader("country").ToString()
                        Dim currentProvince As String = reader("province").ToString()
                        Dim currentMunicipality As String = reader("municipality").ToString()
                        Dim currentBarangay As String = reader("barangay").ToString()
                        Dim currentLandmark As String = reader("landmark").ToString()

                        ' 2. Set the UI controls based on loaded values

                        CmbCountry.Text = currentCountry
                        CmbProvince.Text = currentProvince

                        ' Setting Municipality text first, then manually triggering the barangay load
                        CmbMunicipality.Text = currentMunicipality

                        ' 3. Manually trigger the barangay load using the selected Municipality ID
                        If CmbMunicipality.SelectedIndex > 0 AndAlso CmbMunicipality.SelectedValue IsNot DBNull.Value Then
                            Dim municipalityId As Integer = CInt(CmbMunicipality.SelectedValue)

                            ' Temporarily remove handler to prevent a recursive cascade while manually loading
                            RemoveHandler CmbMunicipality.SelectedIndexChanged, AddressOf CmbMunicipality_SelectedIndexChanged
                            LoadBarangays(municipalityId)
                            AddHandler CmbMunicipality.SelectedIndexChanged, AddressOf CmbMunicipality_SelectedIndexChanged

                            ' 4. Select the Barangay
                            CmbBarangay.Text = currentBarangay
                        End If

                        ' 5. Set the Landmark text
                        TxtLandmark.Text = currentLandmark

                    Else
                        MessageBox.Show("Existing customer address data not found.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading existing address data: " & ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    ' *** UPDATED: Update the 5 separate columns in the database ***
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        ' Validation checks
        If CmbCountry Is Nothing OrElse CmbProvince Is Nothing OrElse CmbMunicipality Is Nothing OrElse CmbBarangay Is Nothing OrElse TxtLandmark Is Nothing Then
            MessageBox.Show("UI controls are not initialized.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 1. Basic validation (Ensure selection is made, index 0 is "-- Select...")
        If CmbProvince.SelectedIndex <= 0 OrElse CmbMunicipality.SelectedIndex <= 0 OrElse CmbBarangay.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a valid Province, Municipality, and Barangay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim updateQuery As String = "UPDATE customer SET " &
                                    "country = @country, " &
                                    "province = @province, " &
                                    "municipality = @municipality, " &
                                    "barangay = @barangay, " &
                                    "landmark = @landmark " &
                                    "WHERE customer_id = @customerId"

        Try
            Using conn As New MySqlConnection(CONNECTION_STRING)
                conn.Open()

                Using cmd As New MySqlCommand(updateQuery, conn)
                    ' Add parameters for the 5 new separate columns
                    cmd.Parameters.AddWithValue("@country", CmbCountry.Text.Trim())
                    cmd.Parameters.AddWithValue("@province", CmbProvince.Text.Trim())
                    cmd.Parameters.AddWithValue("@municipality", CmbMunicipality.Text.Trim())
                    cmd.Parameters.AddWithValue("@barangay", CmbBarangay.Text.Trim())
                    cmd.Parameters.AddWithValue("@landmark", TxtLandmark.Text.Trim())
                    cmd.Parameters.AddWithValue("@customerId", CustomerId)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Address updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("Failed to update address. Customer ID may be invalid or no changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class