Imports System.Windows.Forms.Design

Public Class NewPassword

    ' Assuming New Password input is txtNewPassword and Confirm is txtConfirmPassword
    Public txtNewPassword As TextBox ' Placeholder
    Public txtConfirmPassword As TextBox ' Placeholder

    Private Async Sub ButtonRounded1_Click(sender As Object, e As EventArgs) Handles ButtonRounded1.Click
        ' The "Set New Password" button click handler

        Dim newPw As String = If(txtNewPassword IsNot Nothing, txtNewPassword.Text.Trim(), String.Empty)
        Dim confirm As String = If(txtConfirmPassword IsNot Nothing, txtConfirmPassword.Text.Trim(), String.Empty)

        ' ... (Validation check) ...

        ButtonRounded1.Enabled = False

        ' 1. Call API to actually change the password (using the stored email)
        Dim userIdentifier As String = GlobalState.UserEmail
        Dim result = Await APIService.ChangePasswordAsync(userIdentifier, newPw)
        Dim success = result.Item1
        Dim responseMessage = result.Item2

        ButtonRounded1.Enabled = True

        If success Then
            MessageBox.Show("Password updated successfully. Please log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' 2. Navigate back to the main login view
            ButtonRounded4_Click(sender, e)
        Else
            ' Handle API failure for password update
            MessageBox.Show(responseMessage, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' (Other original methods retained for context)
    Private Sub ButtonRounded4_Click(sender As Object, e As EventArgs) Handles ButtonRounded4.Click
        ' Back button / Return to Login logic
        Dim parentContainer = TryCast(Me.Parent, Control)
        If parentContainer Is Nothing Then Return
        parentContainer.Controls.Remove(Me)

        ' Logic to restore the main Login view (assuming it's named sparxLogin)
        Dim parentForm = TryCast(Me.FindForm(), sparxLogin)
        If parentForm IsNot Nothing Then
            Dim restore = parentForm.GetType().GetMethod("RestoreLoginView", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Public)
            If restore IsNot Nothing Then
                restore.Invoke(parentForm, Nothing)
            End If
        End If
    End Sub

    Private Sub NewPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
End Class