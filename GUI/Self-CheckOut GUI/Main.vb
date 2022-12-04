Public Class Main

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub
End Class
