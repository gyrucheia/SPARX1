Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.Design
Public Class ForgotVerification

    Private Async Sub ButtonRounded3_Click(sender As Object, e As EventArgs) Handles ButtonRounded3.Click
        ' The "Verify" button click handler

        Dim codeInput As String = If(Verifycode IsNot Nothing, Verifycode.Text.Trim(), String.Empty)
        ' Retrieve the stored phone number
        Dim userIdentifier As String = GlobalState.UserPhoneNumber

        If String.IsNullOrEmpty(userIdentifier) Then
            MessageBox.Show("Email context lost. Please return to the previous screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If codeInput.Length <> 6 OrElse Not codeInput.All(AddressOf Char.IsDigit) Then
            MessageBox.Show("Please enter the 6-digit code.", "Invalid Code Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ButtonRounded3.Enabled = False

        ' 1. Call API to verify the code
        Dim purpose As String = "password_reset"
        Dim result = Await APIService.VerifyCodeAsync(userIdentifier, purpose, codeInput)
        Dim success = result.Item1
        Dim responseMessage = result.Item2

        ButtonRounded3.Enabled = True

        If success Then
            MessageBox.Show(responseMessage, "Verification Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 2. Transition to NewPassword view
            Dim parentContainer = TryCast(Me.Parent, Control)
            If parentContainer Is Nothing Then Return

            Dim newPasswordView As New NewPassword()
            newPasswordView.Dock = DockStyle.Fill
            parentContainer.Controls.Add(newPasswordView)
            newPasswordView.BringToFront()

            parentContainer.Controls.Remove(Me)
        Else
            ' 3. Show error
            MessageBox.Show(responseMessage, "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonRounded5_Click_1(sender As Object, e As EventArgs) Handles ButtonRounded5.Click
        ' Go back to ForgotPassword view (Resend button)
        Dim parentContainer = Me.Parent
        If parentContainer Is Nothing Then Return

        parentContainer.Controls.Remove(Me)
        Dim fp = parentContainer.Controls.OfType(Of ForgotPassword).FirstOrDefault
        If fp Is Nothing Then
            fp = New ForgotPassword
            fp.Dock = DockStyle.Fill
            parentContainer.Controls.Add(fp)
        End If
        fp.BringToFront()
    End Sub

    Private Sub ForgotVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Display the phone number the code was sent to
            If lblEmail IsNot Nothing Then
                lblEmail.Text = $"Code sent to: {GlobalState.UserPhoneNumber}"
            End If

            ' ... (Control setup logic) ...
        Catch
        End Try

        ' (Other original load logic)
    End Sub

    ' (Original validation/limit handlers retained)
    Private Sub Verifycode_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Verifycode_TextChanged(sender As Object, e As EventArgs)
        Dim maxLen As Integer = 6
        If Verifycode.TextLength > maxLen Then
            Verifycode.Text = Verifycode.Text.Substring(0, maxLen)
            Verifycode.SelectionStart = Verifycode.TextLength
        End If
    End Sub

    ' (Original unused handlers)
    Private Sub pnlEmail_Paint(sender As Object, e As PaintEventArgs)
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
    Private Sub lblEmail_Click(sender As Object, e As EventArgs) Handles lblEmail.Click
    End Sub
    Private Sub ButtonRounded5_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub lblUserLevel_Click(sender As Object, e As EventArgs) Handles lblUserLevel.Click
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub ButtonRounded4_Click(sender As Object, e As EventArgs) Handles ButtonRounded4.Click
    End Sub
    Private Sub pnlEmail_Paint_1(sender As Object, e As PaintEventArgs) Handles pnlEmail.Paint
    End Sub
    Private Sub ApplyFlatNoHover(btn As Button)
    End Sub
End Class
