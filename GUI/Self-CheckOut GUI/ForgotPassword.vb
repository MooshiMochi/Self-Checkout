Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Imports System.Text

Public Class ForgotPassword

    Dim page As Integer = 0
    Dim enteredEmail As String
    Dim codeAttemptsLeft As Integer = 3
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If page = 0 Then
            If txtInput.Text = "" Then
                lblErrInput.Text = "⚠️ Please enter your email address."
                lblErrInput.Show()
            Else
                If Regex.IsMatch(txtInput.Text, "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") Then
                    enteredEmail = txtInput.Text
                    page = 1
                    lblInstruction.Text = "We’ve found the email ... linked to your account"
                    lblInstruction.Text += vbNewLine + "Please enter the verification code sent"
                    txtInput.Text = ""
                End If
            End If

        ElseIf page = 1 Then
            If txtInput.Text = "" Then
                lblErrInput.Text = "⚠️ Please enter the verification code!"
                lblErrInput.Show()
            Else
                If codeAttemptsLeft <= 0 Then
                    lblErrInput.Text = "⚠️ You have exceeded the maximum number of attempts."
                    lblErrInput.Show()
                    Return
                End If
                ' request the verification code from the API
                Dim verificationCode As Integer = GetVerificationCode(enteredEmail)
                If verificationCode = -1 Then
                    MessageBox.Show("An error occurred while trying to get the verification code. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                If CInt(txtInput.Text) = verificationCode Then
                    MessageBox.Show("Verification Successful!")
                    page = 2

                    lblInstruction.Text = "Please enter your new password" + vbNewLine
                    lblInstruction.Text += "Password must be at least 6 characters long"

                    txtInput.Text = ""
                    MessageBox.Show(btnNext.Location.ToString())
                    ' btnNext.Location.Offset(New Point(0, 120))
                    btnNext.Location = New Point(52, 340)

                    lblReEnterPass.Show()
                    txtPassConfirm.Show()

                Else
                    lblErrInput.Text = "⚠️ The verification code is incorrect!"
                    lblErrInput.Show()
                    codeAttemptsLeft -= 1
                End If
            End If

        ElseIf page = 2 Then
            If txtInput.Text = "" Then
                lblErrInput.Text = "⚠️ Please enter your new password!"
                lblErrInput.Show()
            End If
            If txtPassConfirm.Text = "" Then
                lblErrPassConfirm.Text = "⚠️ Please confirm your password!"
                lblErrPassConfirm.Show()
            End If
            If txtInput.Text <> txtPassConfirm.Text Then
                lblErrPassConfirm.Text = "⚠️ Passwords do not match!"
                lblErrPassConfirm.Show()
            End If
            If txtInput.Text.Length < 6 Then
                lblErrInput.Text = "⚠️ Password must be at least 6 characters long!"
                lblErrInput.Show()
            End If

            If txtInput.Text <> "" And txtPassConfirm.Text <> "" And txtInput.Text = txtPassConfirm.Text And txtInput.Text.Length >= 6 Then
                ' send a request to localhost:8080/forgotpassword with the following json body: 
                ' {email: enteredEmail, password: txtInput.Text}
                Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/renew-pass")
                request.Method = "POST"
                request.ContentType = "application/json"

                Dim json As String = "{""email"":""" & enteredEmail & """,""password"":""" & txtInput.Text & """}"
                Dim data As Byte() = Encoding.UTF8.GetBytes(json)

                request.ContentLength = data.Length

                Dim stream As Stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
                stream.Close()

                Dim response As HttpWebResponse = request.GetResponse()
                Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
                response.Close()

                ' if the response is "true" then the password was successfully changed
                ' if the response is "false" then the password was not changed  

                Dim serializer As New JavaScriptSerializer()
                Dim result As Dictionary(Of String, String) = serializer.Deserialize(Of Dictionary(Of String, String))(responseString)

                If result("success") Then
                    MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    Dim login As New Login
                    login.Show()
                Else
                    MessageBox.Show("An error occurred while trying to change your password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' MessageBox.Show("An error occurred while trying to change your password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Function GetVerificationCode(username As String) As Integer
        ' send a request to the API to check what the verification code that the user needs to enter is

        ' return the verification code
        Dim requestUrl As String = "http://127.0.0.1:8000/code?email=" & username
        Dim request As HttpWebRequest = WebRequest.Create(requestUrl)
        request.Method = "GET"
        request.ContentType = "application/json"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        response.Close()

        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(responseString)

        If dict("success") Then
            Return dict("code")
        End If
        Return -1
    End Function


End Class