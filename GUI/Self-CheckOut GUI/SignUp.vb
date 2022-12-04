
Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization

Imports System.Text

Public Class SignUp
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtPasswordConfirm.Text

        If password = confirmPassword Then
            Dim response As Dictionary(Of String, String) = SendSignUpRequest(email, password)
            If response("status") = "success" Then
                MessageBox.Show("Sign up successful")
                Me.Close()
                Dim login As New Login
                login.Show()
            Else
                MessageBox.Show("The email you entered is already in use!")
            End If

        Else
            MessageBox.Show("Password does not match")
        End If

    End Sub

    Private Function SendSignUpRequest(email As String, password As String)
        Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/register")
        request.Method = "POST"
        request.ContentType = "application/json"

        Dim data As String = "{""email"":""" & email & """,""password"":""" & password & """}"
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(data)
        request.ContentLength = byteArray.Length

        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        Dim response As HttpWebResponse = request.GetResponse()
        dataStream = response.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        reader.Close()
        dataStream.Close()
        response.Close()

        Dim serializer As New JavaScriptSerializer()
        Dim result As Dictionary(Of String, String) = serializer.Deserialize(Of Dictionary(Of String, String))(responseFromServer)

        Return result
    End Function

End Class