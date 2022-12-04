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

        Dim request As HttpWebRequest = WebRequest.Create("http://127.0.0.1:8000/login")
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim json As String = "{""username"":""" & username & """,""password"":""" & password & """}"
        Dim data As Byte() = Encoding.UTF8.GetBytes(json)

        request.ContentLength = data.Length

        Dim stream As Stream = request.GetRequestStream()
        stream.Write(data, 0, data.Length)
        stream.Close()

        Dim response As HttpWebResponse = request.GetResponse()
        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        response.Close()

        ' if the response is "true" then the login was successful
        ' if the response is "false" then the login was unsuccessful
        Console.WriteLine(responseString)

        ' parse the response string to a dict
        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(responseString)

        If dict.Item("success") = True Then
            MsgBox("Login successful")
        Else
            MsgBox("Login unsuccessful")
        End If

    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub
End Class