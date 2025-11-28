Imports System.Windows.Forms.Design

Public Class ForgotPassword
    Public Event SendCodeRequested()

    Private Sub ButtonRounded2_Click(sender As Object, e As EventArgs) Handles ButtonRounded2.Click
        ' Back button logic
        Dim parentContainer = TryCast(Me.Parent, Control)
        If parentContainer IsNot Nothing Then
            parentContainer.Controls.Remove(Me)
        End If
    End Sub

    Private Async Sub ButtonRounded1_Click(sender As Object, e As EventArgs) Handles ButtonRounded1.Click
        ' The "Send Code" button click handler

        ' 1. Validate Phone Number Input
        Dim phoneInput As String = If(EmailInput IsNot Nothing, EmailInput.Text.Trim(), String.Empty)

        If String.IsNullOrEmpty(phoneInput) OrElse phoneInput.Length <> 11 OrElse Not phoneInput.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Please enter a valid 11-digit phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ButtonRounded1.Enabled = False

        ' 2. Call the API to send the code to the phone number entered
        Dim purpose As String = "password_reset"
        Dim result = Await APIService.SendCodeAsync(phoneInput, purpose)
        Dim success = result.Item1
        Dim responseMessage = result.Item2

        ButtonRounded1.Enabled = True

        If success Then
            ' 3. Store phone number globally and transition to verification view
            GlobalState.UserPhoneNumber = phoneInput
            MessageBox.Show(responseMessage, "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RaiseEvent SendCodeRequested()
        Else
            ' 4. Show error message (e.g., phone number not found, network failure)
            MessageBox.Show(responseMessage, "Error Sending Code", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' (Original methods for Phone Number input handling, handles EmailInput.KeyPress/TextChanged)
    Private Sub EmailInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmailInput.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmailInput_TextChanged(sender As Object, e As EventArgs) Handles EmailInput.TextChanged
        Dim maxLen As Integer = 11
        If EmailInput.TextLength > maxLen Then
            EmailInput.Text = EmailInput.Text.Substring(0, maxLen)
            EmailInput.SelectionStart = EmailInput.TextLength
        End If
    End Sub

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Resize
        ' ... (Loading logic) ...
    End Sub

    ' (Other original methods retained for context)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click
    End Sub

End Class

