
' create a constants class that will hold the base api url and allow the url to be referenced without initiating a new constant object

Public Class Constants
    ' make sure the url does not end in /
    Public Const BASE_API_URL As String = "http://localhost:8000"
End Class
