Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Text

Public Class Login


    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text = "" Then
            lblErrUsername.Show()
        Else
            lblErrUsername.Hide()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text = "" Then
            lblErrPassword.Show()
        Else
            lblErrPassword.Hide()
        End If
    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "" Or password = "" Then
            lblErrUsername.Show()
            lblErrPassword.Show()
            Return
        End If

        ' send a request to localhost:8080/login with the following json body: 
        ' {username: username, password: password}

        Dim RequestProxy As New Request()
        Dim data As String = "{""username"":""" & username & """,""password"":""" & password & """}"
        Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/login")
        RequestProxy.MakeRequest(request, "POST", "application/json", data, AddressOf RequestCallback)

    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Function RequestCallback(ByVal response As String) As Dictionary(Of String, String)

        Console.WriteLine(response)

        ' parse the response string to a dict
        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(response)

        If dict.Item("success") = True Then
            MsgBox("Login successful")
        Else
            MsgBox("Login unsuccessful")
        End If
        Return dict
    End Function

End Class