
Public Class Main

    Dim APIStatus As Boolean = True

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        APIStatus = New Request().CheckAPIStatus()

        If APIStatus = False Then
            labelAPIOffline.Show()
        End If

    End Sub
    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click

        If Not CheckAPIStatus() Then
            Return
        End If

        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If Not CheckAPIStatus() Then
            Return
        End If

        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        If Not CheckAPIStatus() Then
            Return
        End If

        Me.Hide()
        SignUp.Show()
    End Sub

    Private Function CheckAPIStatus() As Boolean
        If APIStatus = False Then
            MessageBox.Show("The API is not running. Please try again later.")
            Return False
        End If
        Return True
    End Function
End Class
