<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblCustomerLogin = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(246, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Please enter a password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(220, 113)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Please enter your email address"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.txtPassword.Location = New System.Drawing.Point(196, 222)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(312, 26)
        Me.txtPassword.TabIndex = 20
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(196, 134)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(312, 26)
        Me.txtEmail.TabIndex = 19
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSignUp
        '
        Me.btnSignUp.AutoSize = True
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignUp.FlatAppearance.BorderSize = 10
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.Font = New System.Drawing.Font("Lucida Sans", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSignUp.Location = New System.Drawing.Point(250, 385)
        Me.btnSignUp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(215, 55)
        Me.btnSignUp.TabIndex = 18
        Me.btnSignUp.Text = "Create Account"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblCustomerLogin
        '
        Me.lblCustomerLogin.AutoSize = True
        Me.lblCustomerLogin.Font = New System.Drawing.Font("Lucida Sans", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCustomerLogin.Location = New System.Drawing.Point(155, 36)
        Me.lblCustomerLogin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomerLogin.Name = "lblCustomerLogin"
        Me.lblCustomerLogin.Size = New System.Drawing.Size(381, 55)
        Me.lblCustomerLogin.TabIndex = 17
        Me.lblCustomerLogin.Text = "Create Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(227, 290)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Please re-enter the password"
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(196, 316)
        Me.txtPasswordConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(312, 26)
        Me.txtPasswordConfirm.TabIndex = 23
        Me.txtPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(699, 491)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblCustomerLogin)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "SignUp"
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblCustomerLogin As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPasswordConfirm As TextBox
End Class
