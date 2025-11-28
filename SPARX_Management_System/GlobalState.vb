Imports System.Net
Imports System.IO
Imports System.Collections.Specialized
Imports System.Threading.Tasks
Imports System.Windows.Forms

' --- 1. SHARED STATE MODULE (UPDATED for Phone Number) ---
Module GlobalState
    ' IMPORTANT: Update this to your correct API base URL
    Public Const BaseUrl As String = "http://127.0.0.1/sparx-api/"

    ' Stores the email address being used for the current password reset attempt
    Public UserEmail As String = String.Empty
    ' Stores the phone number being used for the current password reset attempt
    Public UserPhoneNumber As String = String.Empty
End Module

' --- 2. API CLIENT MODULE (UPDATED Parameter Name) ---
Module APIService
    ' FIX 1: Return simple tuple without names to avoid destructuring issues - Simple string parsing
    Private Function ParseResponse(json As String) As (Boolean, String)
        Try
            ' Simple string parsing to extract success and message
            Dim success As Boolean = json.Contains("""success"":true")
            Dim messageStart = json.IndexOf("""message"":")
            If messageStart = -1 Then Return (False, "Invalid response format")

            messageStart += 11 ' Length of "message":"
            Dim messageEnd = json.IndexOf("""", messageStart)
            If messageEnd = -1 Then messageEnd = json.IndexOf("}", messageStart)

            Dim responseMessage = json.Substring(messageStart, messageEnd - messageStart).Trim(""""c)
            Return (success, responseMessage)
        Catch ex As Exception
            Return (False, "Error parsing API response: " & ex.Message & vbCrLf & "Raw response: " & json)
        End Try
    End Function

    ' FIX 2: Return unnamed tuple
    Public Async Function SendCodeAsync(identifier As String, purpose As String) As Task(Of (Boolean, String))
        Return Await Task.Run(Function() As (Boolean, String)
                                  Dim endpoint = GlobalState.BaseUrl & "send_code.php"

                                  Using client As New WebClient()
                                      client.Proxy = Nothing
                                      Dim data As New NameValueCollection()
                                      data.Add("email", identifier)
                                      data.Add("purpose", purpose)

                                      Try
                                          Dim responseBytes = client.UploadValues(endpoint, "POST", data)
                                          Dim json = System.Text.Encoding.UTF8.GetString(responseBytes)
                                          ' Use the tuple elements from ParseResponse
                                          Dim result = ParseResponse(json)
                                          Return result
                                      Catch ex As Exception
                                          Return (False, "Network or API connection failed: " & ex.Message)
                                      End Try
                                  End Using
                              End Function)
    End Function

    ' FIX 2: Return unnamed tuple
    Public Async Function VerifyCodeAsync(identifier As String, purpose As String, code As String) As Task(Of (Boolean, String))
        Return Await Task.Run(Function() As (Boolean, String)
                                  Dim endpoint = GlobalState.BaseUrl & "verify_code.php"

                                  Using client As New WebClient()
                                      client.Proxy = Nothing
                                      Dim data As New NameValueCollection()
                                      data.Add("email", identifier)
                                      data.Add("purpose", purpose)
                                      data.Add("code", code)

                                      Try
                                          Dim responseBytes = client.UploadValues(endpoint, "POST", data)
                                          Dim json = System.Text.Encoding.UTF8.GetString(responseBytes)
                                          ' Use the tuple elements from ParseResponse
                                          Dim result = ParseResponse(json)
                                          Return result
                                      Catch ex As Exception
                                          Return (False, "Network or API connection failed: " & ex.Message)
                                      End Try
                                  End Using
                              End Function)
    End Function

    ' FIX 2: Return unnamed tuple
    Public Async Function ChangePasswordAsync(identifier As String, newPassword As String) As Task(Of (Boolean, String))
        ' ... rest of ChangePasswordAsync implementation ...
        Await Task.Delay(500) ' Simulate network call
        Return (True, "Password has been successfully updated.")
    End Function

End Module
