<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditAddress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        TxtLandmark = New TextBox() ' CHANGED TYPE AND NAME: From Landmark1/ComboBox to TxtLandmark/TextBox
        CmbBarangay = New ComboBox() ' CHANGED NAME: From Barangay1
        CmbMunicipality = New ComboBox() ' CHANGED NAME: From Municipality1
        CmbProvince = New ComboBox() ' CHANGED NAME: From Province1
        CmbCountry = New ComboBox() ' CHANGED NAME: From Country1
        SaveBtn = New ButtonRounded() ' CHANGED NAME: From UpdateAddressBtn
        CancelBtn = New ButtonRounded() ' CHANGED NAME: From CancelAddressBtn
        EditLMLbl = New Label()
        EditBrgyLbl = New Label()
        EditMunLbl = New Label()
        EditProvineLbl = New Label()
        EditCountryLbl = New Label()
        EditAddressPnl = New Panel()
        Line3 = New Label()
        EditLbl = New Label()
        Panel1.SuspendLayout()
        EditAddressPnl.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TxtLandmark) ' Renamed
        Panel1.Controls.Add(CmbBarangay) ' Renamed
        Panel1.Controls.Add(CmbMunicipality) ' Renamed
        Panel1.Controls.Add(CmbProvince) ' Renamed
        Panel1.Controls.Add(CmbCountry) ' Renamed
        Panel1.Controls.Add(SaveBtn) ' Renamed
        Panel1.Controls.Add(CancelBtn) ' Renamed
        Panel1.Controls.Add(EditLMLbl)
        Panel1.Controls.Add(EditBrgyLbl)
        Panel1.Controls.Add(EditMunLbl)
        Panel1.Controls.Add(EditProvineLbl)
        Panel1.Controls.Add(EditCountryLbl)
        Panel1.Controls.Add(EditAddressPnl)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(375, 267)
        Panel1.TabIndex = 0
        ' 
        ' TxtLandmark
        ' 
        TxtLandmark.Location = New Point(127, 187) ' CHANGED FROM ComboBox TO TextBox
        TxtLandmark.Name = "TxtLandmark" ' Renamed from Landmark1
        TxtLandmark.Size = New Size(215, 23)
        TxtLandmark.TabIndex = 48
        ' 
        ' CmbBarangay
        ' 
        CmbBarangay.FormattingEnabled = True
        CmbBarangay.Location = New Point(127, 158)
        CmbBarangay.Name = "CmbBarangay" ' Renamed from Barangay1
        CmbBarangay.Size = New Size(215, 23)
        CmbBarangay.TabIndex = 47
        ' 
        ' CmbMunicipality
        ' 
        CmbMunicipality.FormattingEnabled = True
        CmbMunicipality.Location = New Point(127, 126)
        CmbMunicipality.Name = "CmbMunicipality" ' Renamed from Municipality1
        CmbMunicipality.Size = New Size(215, 23)
        CmbMunicipality.TabIndex = 46
        ' 
        ' CmbProvince
        ' 
        CmbProvince.FormattingEnabled = True
        CmbProvince.Location = New Point(127, 91)
        CmbProvince.Name = "CmbProvince" ' Renamed from Province1
        CmbProvince.Size = New Size(215, 23)
        CmbProvince.TabIndex = 45
        ' 
        ' CmbCountry
        ' 
        CmbCountry.FormattingEnabled = True
        CmbCountry.Location = New Point(127, 56)
        CmbCountry.Name = "CmbCountry" ' Renamed from Country1
        CmbCountry.Size = New Size(215, 23)
        CmbCountry.TabIndex = 44
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(70, 130, 255)
        SaveBtn.DialogResult = DialogResult.OK
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.ForeColor = Color.White
        SaveBtn.Location = New Point(254, 222)
        SaveBtn.Name = "SaveBtn" ' Renamed from UpdateAddressBtn
        SaveBtn.Size = New Size(88, 31)
        SaveBtn.TabIndex = 43
        SaveBtn.Text = "Update"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.FromArgb(70, 130, 255)
        CancelBtn.DialogResult = DialogResult.Cancel
        CancelBtn.FlatAppearance.BorderSize = 0
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.ForeColor = Color.White
        CancelBtn.Location = New Point(160, 222)
        CancelBtn.Name = "CancelBtn" ' Renamed from CancelAddressBtn
        CancelBtn.Size = New Size(88, 31)
        CancelBtn.TabIndex = 42
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' EditLMLbl
        ' 
        EditLMLbl.AutoSize = True
        EditLMLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditLMLbl.Location = New Point(15, 194)
        EditLMLbl.Name = "EditLMLbl"
        EditLMLbl.Size = New Size(69, 17)
        EditLMLbl.TabIndex = 37
        EditLMLbl.Text = "Landmark"
        EditLMLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditBrgyLbl
        ' 
        EditBrgyLbl.AutoSize = True
        EditBrgyLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditBrgyLbl.Location = New Point(15, 159)
        EditBrgyLbl.Name = "EditBrgyLbl"
        EditBrgyLbl.Size = New Size(65, 17)
        EditBrgyLbl.TabIndex = 36
        EditBrgyLbl.Text = "Barangay"
        EditBrgyLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditMunLbl
        ' 
        EditMunLbl.AutoSize = True
        EditMunLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditMunLbl.Location = New Point(15, 126)
        EditMunLbl.Name = "EditMunLbl"
        EditMunLbl.Size = New Size(85, 17)
        EditMunLbl.TabIndex = 35
        EditMunLbl.Text = "Municipality"
        EditMunLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditProvineLbl
        ' 
        EditProvineLbl.AutoSize = True
        EditProvineLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditProvineLbl.Location = New Point(15, 91)
        EditProvineLbl.Name = "EditProvineLbl"
        EditProvineLbl.Size = New Size(61, 17)
        EditProvineLbl.TabIndex = 34
        EditProvineLbl.Text = "Province"
        EditProvineLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditCountryLbl
        ' 
        EditCountryLbl.AutoSize = True
        EditCountryLbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditCountryLbl.Location = New Point(15, 57)
        EditCountryLbl.Name = "EditCountryLbl"
        EditCountryLbl.Size = New Size(58, 17)
        EditCountryLbl.TabIndex = 33
        EditCountryLbl.Text = "Country"
        EditCountryLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditAddressPnl
        ' 
        EditAddressPnl.Controls.Add(Line3)
        EditAddressPnl.Controls.Add(EditLbl)
        EditAddressPnl.Location = New Point(3, 2)
        EditAddressPnl.Name = "EditAddressPnl"
        EditAddressPnl.Size = New Size(509, 43)
        EditAddressPnl.TabIndex = 32
        ' 
        ' Line3
        ' 
        Line3.AutoSize = True
        Line3.Location = New Point(-3, 28)
        Line3.Name = "Line3"
        Line3.Size = New Size(517, 15)
        Line3.TabIndex = 4
        Line3.Text = "______________________________________________________________________________________________________"
        ' 
        ' EditLbl
        ' 
        EditLbl.AutoSize = True
        EditLbl.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        EditLbl.Location = New Point(12, 9)
        EditLbl.Name = "EditLbl"
        EditLbl.Size = New Size(104, 21)
        EditLbl.TabIndex = 2
        EditLbl.Text = "Edit Address"
        EditLbl.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' EditAddress
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(373, 263)
        Controls.Add(Panel1)
        Name = "EditAddress"
        Text = "EditAddress"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        EditAddressPnl.ResumeLayout(False)
        EditAddressPnl.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SaveBtn As ButtonRounded ' Renamed from UpdateAddressBtn
    Friend WithEvents CancelBtn As ButtonRounded ' Renamed from CancelAddressBtn
    Friend WithEvents EditLMLbl As Label
    Friend WithEvents EditBrgyLbl As Label
    Friend WithEvents EditMunLbl As Label
    Friend WithEvents EditProvineLbl As Label
    Friend WithEvents EditCountryLbl As Label
    Friend WithEvents EditAddressPnl As Panel
    Friend WithEvents Line3 As Label
    Friend WithEvents EditLbl As Label
    Friend WithEvents TxtLandmark As TextBox ' Changed Type and Name
    Friend WithEvents CmbBarangay As ComboBox ' Renamed from Barangay1
    Friend WithEvents CmbMunicipality As ComboBox ' Renamed from Municipality1
    Friend WithEvents CmbProvince As ComboBox ' Renamed from Province1
    Friend WithEvents CmbCountry As ComboBox ' Renamed from Country1
End Class