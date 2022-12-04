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
        Me.Label2.Location = New System.Drawing.Point(492, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(418, 37)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Please enter a password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(440, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 37)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Please enter your email address"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(391, 451)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(621, 80)
        Me.txtPassword.TabIndex = 20
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(391, 258)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(621, 80)
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
        Me.btnSignUp.Location = New System.Drawing.Point(499, 789)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(394, 113)
        Me.btnSignUp.TabIndex = 18
        Me.btnSignUp.Text = "Create Account"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblCustomerLogin
        '
        Me.lblCustomerLogin.AutoSize = True
        Me.lblCustomerLogin.Font = New System.Drawing.Font("Lucida Sans", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCustomerLogin.Location = New System.Drawing.Point(310, 69)
        Me.lblCustomerLogin.Name = "lblCustomerLogin"
        Me.lblCustomerLogin.Size = New System.Drawing.Size(756, 109)
        Me.lblCustomerLogin.TabIndex = 17
        Me.lblCustomerLogin.Text = "Create Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(453, 599)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(493, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Please re-enter the password"
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(391, 639)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(621, 80)
        Me.txtPasswordConfirm.TabIndex = 23
        Me.txtPasswordConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1398, 1020)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPasswordConfirm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblCustomerLogin)
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
