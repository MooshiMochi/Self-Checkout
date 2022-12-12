Imports System.IO

Public Class ViewPictureBox


    Public Sub New(ByVal base64String As String)
        InitializeComponent()

        Dim pictureBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(pictureBytes)
        pbDefault.Image = Image.FromStream(ms)
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Me.Close()
    End Sub

End Class