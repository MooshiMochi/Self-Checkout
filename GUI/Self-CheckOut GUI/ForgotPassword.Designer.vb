﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblErrInput = New System.Windows.Forms.Label()
        Me.lblErrPassConfirm = New System.Windows.Forms.Label()
        Me.lblReEnterPass = New System.Windows.Forms.Label()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblInstruction.Location = New System.Drawing.Point(96, 202)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(545, 37)
        Me.lblInstruction.TabIndex = 29
        Me.lblInstruction.Text = "Please enter your email address"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(103, 266)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(705, 80)
        Me.txtInput.TabIndex = 27
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNext.FlatAppearance.BorderSize = 10
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(103, 419)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(205, 79)
        Me.btnNext.TabIndex = 26
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(84, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(816, 109)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Forgot Password"
        '
        'lblErrInput
        '
        Me.lblErrInput.AutoSize = True
        Me.lblErrInput.Font = New System.Drawing.Font("Lucida Sans", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrInput.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrInput.Location = New System.Drawing.Point(97, 349)
        Me.lblErrInput.Name = "lblErrInput"
        Me.lblErrInput.Size = New System.Drawing.Size(339, 32)
        Me.lblErrInput.TabIndex = 30
        Me.lblErrInput.Text = "⚠️ Invalid email address"
        Me.lblErrInput.Visible = False
        '
        'lblErrPassConfirm
        '
        Me.lblErrPassConfirm.AutoSize = True
        Me.lblErrPassConfirm.Font = New System.Drawing.Font("Lucida Sans", 10.125!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrPassConfirm.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrPassConfirm.Location = New System.Drawing.Point(97, 571)
        Me.lblErrPassConfirm.Name = "lblErrPassConfirm"
        Me.lblErrPassConfirm.Size = New System.Drawing.Size(339, 32)
        Me.lblErrPassConfirm.TabIndex = 33
        Me.lblErrPassConfirm.Text = "⚠️ Invalid email address"
        Me.lblErrPassConfirm.Visible = False
        '
        'lblReEnterPass
        '
        Me.lblReEnterPass.AutoSize = True
        Me.lblReEnterPass.Font = New System.Drawing.Font("Lucida Sans", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReEnterPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblReEnterPass.Location = New System.Drawing.Point(96, 424)
        Me.lblReEnterPass.Name = "lblReEnterPass"
        Me.lblReEnterPass.Size = New System.Drawing.Size(321, 37)
        Me.lblReEnterPass.TabIndex = 32
        Me.lblReEnterPass.Text = "Re-enter Password"
        Me.lblReEnterPass.Visible = False
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassConfirm.Location = New System.Drawing.Point(103, 488)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.Size = New System.Drawing.Size(705, 80)
        Me.txtPassConfirm.TabIndex = 31
        Me.txtPassConfirm.Visible = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1398, 815)
        Me.Controls.Add(Me.lblErrPassConfirm)
        Me.Controls.Add(Me.lblReEnterPass)
        Me.Controls.Add(Me.txtPassConfirm)
        Me.Controls.Add(Me.lblErrInput)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "ForgotPassword"
        Me.Text = "Forgot Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblErrInput As Label
    Friend WithEvents lblErrPassConfirm As Label
    Friend WithEvents lblReEnterPass As Label
    Friend WithEvents txtPassConfirm As TextBox
End Class
