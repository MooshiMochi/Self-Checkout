
Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization

Public Class Request

    Public Sub MakeRequest(ByVal request As HttpWebRequest, ByVal method As String, ByVal contentType As String, ByVal data As String, ByVal callback As Action(Of String))

        If Not CheckAPIStatus() Then
            MessageBox.Show("The API is not running. Please try again later!")
            Return
        End If

        request.Method = method
        request.ContentType = contentType

        If data <> "" Then
            Dim dataStream As Stream = request.GetRequestStream()
            Dim writer As New StreamWriter(dataStream)
            writer.Write(data)
            writer.Close()
            dataStream.Close()
        End If

        Dim response As HttpWebResponse = request.GetResponse()
        Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
        response.Close()

        callback(responseString)

    End Sub

    ' before making the request, check whether the API is running.
    Public Function CheckAPIStatus() As Boolean

        Dim APIStatus As Boolean

        Try
            Dim request As HttpWebRequest = WebRequest.Create("http://localhost:8000/status")
            request.Method = "GET"
            request.ContentType = "application/json"

            Dim response As HttpWebResponse = request.GetResponse()
            Dim responseString As String = New StreamReader(response.GetResponseStream()).ReadToEnd()
            response.Close()

            Dim jss As New JavaScriptSerializer()
            Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(responseString)

            If dict("status") Then
                APIStatus = True
            Else
                APIStatus = False
            End If

        Catch ex As Exception
            APIStatus = False
        End Try

        Return APIStatus

    End Function


End Class