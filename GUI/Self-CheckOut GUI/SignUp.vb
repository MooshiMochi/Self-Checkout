
Imports System.Net
Imports System.Web.Script.Serialization

Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtPasswordConfirm.Text

        If password = confirmPassword Then

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