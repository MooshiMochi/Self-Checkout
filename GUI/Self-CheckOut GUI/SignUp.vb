
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Web.Script.Serialization

Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtPasswordConfirm.Text

        If Not Regex.IsMatch(email, "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$") Then
            MessageBox.Show("The email you entered is not valid." & vbNewLine & "Please enter a valid email address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf password = confirmPassword And password <> "" And confirmPassword <> "" Then

            Dim request As HttpWebRequest = WebRequest.Create(Constants.BASE_API_URL & "/register")

            Dim data As String = "{""email"":""" & email & """,""password"":""" & password & """}"

            Dim requestProxy As New Request()
            requestProxy.MakeRequest(request, "POST", "application/json", data, AddressOf SignUpCallback)

        Else
            MessageBox.Show("Password does not match")
        End If

    End Sub

    Private Function SignUpCallback(response As String)

        Dim jss As New JavaScriptSerializer()
        Dim responseDict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(response)

        If responseDict("status") = "success" Then
            MessageBox.Show("Sign up successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Dim login As New Login
            login.Show()
        Else
            MessageBox.Show("The email you entered is already in use!")
        End If
        Return Nothing
    End Function
    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress, txtPassword.KeyPress, txtPasswordConfirm.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnSignUp.PerformClick()
        End If
    End Sub

End Class