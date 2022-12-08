Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Web.Script.Serialization

Public Class ForgotPassword

    Dim page As Integer = 0
    Dim enteredEmail As String
    Dim codeAttemptsLeft As Integer = 3
    Dim serverVerificationCode As Integer

    Private Sub runPage0Checks(ByRef page As Integer)
        If txtInput.Text = "" Then
            lblErrInput.Text = "⚠️ Please enter your email address."
            lblErrInput.Show()
        Else
            If Regex.IsMatch(txtInput.Text, "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") Then
                enteredEmail = txtInput.Text
                lblErrInput.Hide()
                page = 1
                lblInstruction.Text = "We've found the email ... linked to your account"
                lblInstruction.Text += vbNewLine + "Please enter the verification code sent"
                txtInput.Text = ""

                Dim location As Point = txtInput.Location
                location.Y += 15
                txtInput.Location = location

            End If
        End If
    End Sub

    Private Sub runPage1Checks(ByRef page As Integer)
        If txtInput.Text = "" Then
            lblErrInput.Text = "⚠️ Please enter the verification code!"
            lblErrInput.Show()
            Return
        End If

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

        ElseIf CInt(txtInput.Text) = verificationCode Then
            MessageBox.Show("Verification Successful!")
            page = 2

            lblInstruction.Text = "Please enter your new password" + vbNewLine
            lblInstruction.Text += "Password must be at least 6 characters long"
            txtInput.Text = ""

            ' MessageBox.Show(btnNext.Location.ToString())
            ' btnNext.Location.Offset(New Point(0, 120))
            btnNext.Location = New Point(52, 340)

            lblReEnterPass.Show()
            txtPassConfirm.Show()

        Else
            lblErrInput.Text = "⚠️ The verification code is incorrect!"
            lblErrInput.Show()
            codeAttemptsLeft -= 1
        End If
    End Sub

    Private Sub runPage2Checks()
        If txtInput.Text <> "" And txtPassConfirm.Text <> "" And txtInput.Text = txtPassConfirm.Text And txtInput.Text.Length >= 6 Then

            Dim RequestProxy As New Request()

            ' send a request to localhost:8080/forgotpassword with the following json body: 
            ' {email: enteredEmail, password: txtInput.Text}
            Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/renew-pass")
            Dim data As String = "{""email"":""" & enteredEmail & """,""password"":""" & txtInput.Text & """}"

            RequestProxy.MakeRequest(request, "POST", "application/json", data, AddressOf PasswordResetRequestCallback)
        Else
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
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If page = 0 Then
            runPage0Checks(page)
        ElseIf page = 1 Then
            runPage1Checks(page)
        ElseIf page = 2 Then
            runPage2Checks()
        End If

    End Sub

    Private Function GetVerificationCode(username As String) As Integer
        ' send a request to the API to check what the verification code that the user needs to enter is

        Dim RequestProxy As New Request()
        Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/code?email=" & username)
        request.Method = "GET"
        request.ContentType = "application/json"

        RequestProxy.MakeRequest(request, "GET", "application/json", Nothing, AddressOf CodeRequestCallback)

        Return serverVerificationCode

    End Function

    Private Function CodeRequestCallback(response As String) As Integer

        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(response)

        Console.WriteLine("Success status: " & dict("success"))

        If dict("success") Then
            serverVerificationCode = dict("code")
        Else
            serverVerificationCode = -1
        End If

        Console.WriteLine("Verification code received is " & serverVerificationCode)

        Return serverVerificationCode

    End Function

    Private Function PasswordResetRequestCallback(response As String)

        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(response)

        If dict("success") Then
            MessageBox.Show("Password successfully changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim login As New Login
            login.Show()
        Else
            MessageBox.Show("An API error occurred while trying to change your password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Return dict("success")

    End Function


End Class