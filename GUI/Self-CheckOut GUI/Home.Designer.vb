<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pbQR = New System.Windows.Forms.PictureBox()
        Me.pbID = New System.Windows.Forms.PictureBox()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPersonalDetails = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.GroupAddressBG = New System.Windows.Forms.PictureBox()
        Me.GroupPersonalDetailsBG = New System.Windows.Forms.PictureBox()
        Me.GroupPersonalDetails = New System.Windows.Forms.PictureBox()
        Me.GroupAddress = New System.Windows.Forms.PictureBox()
        Me.selectPictureDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lblSelectedFile = New System.Windows.Forms.Label()
        Me.lblPDName = New System.Windows.Forms.Label()
        Me.lblPDDoB = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblHAHouseNumber = New System.Windows.Forms.Label()
        Me.lblHAStreetName = New System.Windows.Forms.Label()
        Me.lblHACity = New System.Windows.Forms.Label()
        Me.lblHAPostCode = New System.Windows.Forms.Label()
        Me.BtnSetupAuthenticator = New System.Windows.Forms.Button()
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupAddressBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupPersonalDetailsBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupPersonalDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbQR
        '
        Me.pbQR.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pbQR.Location = New System.Drawing.Point(46, 37)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(333, 333)
        Me.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbQR.TabIndex = 0
        Me.pbQR.TabStop = False
        '
        'pbID
        '
        Me.pbID.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pbID.Location = New System.Drawing.Point(687, 439)
        Me.pbID.Name = "pbID"
        Me.pbID.Size = New System.Drawing.Size(333, 333)
        Me.pbID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbID.TabIndex = 1
        Me.pbID.TabStop = False
        Me.pbID.WaitOnLoad = True
        '
        'BtnUpload
        '
        Me.BtnUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnUpload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnUpload.FlatAppearance.BorderSize = 8
        Me.BtnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpload.Font = New System.Drawing.Font("Lucida Sans", 7.875!)
        Me.BtnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnUpload.Location = New System.Drawing.Point(1086, 630)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(240, 73)
        Me.BtnUpload.TabIndex = 5
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.UseVisualStyleBackColor = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSelect.FlatAppearance.BorderSize = 8
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelect.Font = New System.Drawing.Font("Lucida Sans", 7.875!)
        Me.BtnSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnSelect.Location = New System.Drawing.Point(1086, 498)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(240, 73)
        Me.BtnSelect.TabIndex = 6
        Me.BtnSelect.Text = "Select an Image"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnLogOut
        '
        Me.BtnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnLogOut.FlatAppearance.BorderSize = 8
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.Font = New System.Drawing.Font("Lucida Sans", 7.875!)
        Me.BtnLogOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnLogOut.Location = New System.Drawing.Point(1196, 115)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(173, 76)
        Me.BtnLogOut.TabIndex = 7
        Me.BtnLogOut.Text = "Log Out"
        Me.BtnLogOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(53, 837)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1273, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "If your personal details or home address are not filled then it is likely that yo" &
    "ur ID is not suppoted or the picture is blurry."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(440, 861)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Please re-upload a clearer picture of your ID."
        '
        'lblPersonalDetails
        '
        Me.lblPersonalDetails.AutoSize = True
        Me.lblPersonalDetails.Font = New System.Drawing.Font("Lucida Sans", 13.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPersonalDetails.Location = New System.Drawing.Point(450, 37)
        Me.lblPersonalDetails.Name = "lblPersonalDetails"
        Me.lblPersonalDetails.Size = New System.Drawing.Size(311, 43)
        Me.lblPersonalDetails.TabIndex = 10
        Me.lblPersonalDetails.Text = "Personal Details"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Lucida Sans", 13.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAddress.Location = New System.Drawing.Point(49, 439)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(282, 43)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Home Address"
        '
        'GroupAddressBG
        '
        Me.GroupAddressBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupAddressBG.Location = New System.Drawing.Point(58, 488)
        Me.GroupAddressBG.Name = "GroupAddressBG"
        Me.GroupAddressBG.Size = New System.Drawing.Size(568, 284)
        Me.GroupAddressBG.TabIndex = 12
        Me.GroupAddressBG.TabStop = False
        '
        'GroupPersonalDetailsBG
        '
        Me.GroupPersonalDetailsBG.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupPersonalDetailsBG.Location = New System.Drawing.Point(458, 90)
        Me.GroupPersonalDetailsBG.Name = "GroupPersonalDetailsBG"
        Me.GroupPersonalDetailsBG.Size = New System.Drawing.Size(648, 280)
        Me.GroupPersonalDetailsBG.TabIndex = 13
        Me.GroupPersonalDetailsBG.TabStop = False
        '
        'GroupPersonalDetails
        '
        Me.GroupPersonalDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GroupPersonalDetails.Location = New System.Drawing.Point(468, 100)
        Me.GroupPersonalDetails.Name = "GroupPersonalDetails"
        Me.GroupPersonalDetails.Size = New System.Drawing.Size(628, 260)
        Me.GroupPersonalDetails.TabIndex = 14
        Me.GroupPersonalDetails.TabStop = False
        '
        'GroupAddress
        '
        Me.GroupAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GroupAddress.Location = New System.Drawing.Point(67, 498)
        Me.GroupAddress.Name = "GroupAddress"
        Me.GroupAddress.Size = New System.Drawing.Size(548, 264)
        Me.GroupAddress.TabIndex = 15
        Me.GroupAddress.TabStop = False
        '
        'selectPictureDialog
        '
        Me.selectPictureDialog.FileName = "unknown"
        Me.selectPictureDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        Me.selectPictureDialog.Title = "Select Picture"
        '
        'lblSelectedFile
        '
        Me.lblSelectedFile.AutoSize = True
        Me.lblSelectedFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSelectedFile.Location = New System.Drawing.Point(1090, 574)
        Me.lblSelectedFile.Name = "lblSelectedFile"
        Me.lblSelectedFile.Size = New System.Drawing.Size(108, 25)
        Me.lblSelectedFile.TabIndex = 16
        Me.lblSelectedFile.Text = "Selected: "
        Me.lblSelectedFile.Visible = False
        '
        'lblPDName
        '
        Me.lblPDName.AutoSize = True
        Me.lblPDName.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblPDName.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPDName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblPDName.Location = New System.Drawing.Point(480, 148)
        Me.lblPDName.Name = "lblPDName"
        Me.lblPDName.Size = New System.Drawing.Size(103, 31)
        Me.lblPDName.TabIndex = 17
        Me.lblPDName.Text = "Name:"
        '
        'lblPDDoB
        '
        Me.lblPDDoB.AutoSize = True
        Me.lblPDDoB.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblPDDoB.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPDDoB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblPDDoB.Location = New System.Drawing.Point(480, 210)
        Me.lblPDDoB.Name = "lblPDDoB"
        Me.lblPDDoB.Size = New System.Drawing.Size(202, 31)
        Me.lblPDDoB.TabIndex = 18
        Me.lblPDDoB.Text = "Date of Birth:"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblCustomerID.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblCustomerID.Location = New System.Drawing.Point(480, 274)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(199, 31)
        Me.lblCustomerID.TabIndex = 19
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'lblHAHouseNumber
        '
        Me.lblHAHouseNumber.AutoSize = True
        Me.lblHAHouseNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblHAHouseNumber.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHAHouseNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblHAHouseNumber.Location = New System.Drawing.Point(79, 534)
        Me.lblHAHouseNumber.Name = "lblHAHouseNumber"
        Me.lblHAHouseNumber.Size = New System.Drawing.Size(235, 31)
        Me.lblHAHouseNumber.TabIndex = 20
        Me.lblHAHouseNumber.Text = "House Number:"
        '
        'lblHAStreetName
        '
        Me.lblHAStreetName.AutoSize = True
        Me.lblHAStreetName.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblHAStreetName.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHAStreetName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblHAStreetName.Location = New System.Drawing.Point(79, 587)
        Me.lblHAStreetName.Name = "lblHAStreetName"
        Me.lblHAStreetName.Size = New System.Drawing.Size(194, 31)
        Me.lblHAStreetName.TabIndex = 21
        Me.lblHAStreetName.Text = "Street Name:"
        '
        'lblHACity
        '
        Me.lblHACity.AutoSize = True
        Me.lblHACity.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblHACity.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHACity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblHACity.Location = New System.Drawing.Point(79, 643)
        Me.lblHACity.Name = "lblHACity"
        Me.lblHACity.Size = New System.Drawing.Size(79, 31)
        Me.lblHACity.TabIndex = 22
        Me.lblHACity.Text = "City:"
        '
        'lblHAPostCode
        '
        Me.lblHAPostCode.AutoSize = True
        Me.lblHAPostCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblHAPostCode.Font = New System.Drawing.Font("Lucida Sans", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHAPostCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.lblHAPostCode.Location = New System.Drawing.Point(79, 695)
        Me.lblHAPostCode.Name = "lblHAPostCode"
        Me.lblHAPostCode.Size = New System.Drawing.Size(160, 31)
        Me.lblHAPostCode.TabIndex = 23
        Me.lblHAPostCode.Text = "Post Code:"
        '
        'BtnSetupAuthenticator
        '
        Me.BtnSetupAuthenticator.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnSetupAuthenticator.FlatAppearance.BorderSize = 8
        Me.BtnSetupAuthenticator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetupAuthenticator.Font = New System.Drawing.Font("Lucida Sans", 7.875!)
        Me.BtnSetupAuthenticator.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSetupAuthenticator.Location = New System.Drawing.Point(1138, 254)
        Me.BtnSetupAuthenticator.Name = "BtnSetupAuthenticator"
        Me.BtnSetupAuthenticator.Size = New System.Drawing.Size(309, 76)
        Me.BtnSetupAuthenticator.TabIndex = 24
        Me.BtnSetupAuthenticator.Text = "Setup Authenticator"
        Me.BtnSetupAuthenticator.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1483, 936)
        Me.Controls.Add(Me.BtnSetupAuthenticator)
        Me.Controls.Add(Me.lblHAPostCode)
        Me.Controls.Add(Me.lblHACity)
        Me.Controls.Add(Me.lblHAStreetName)
        Me.Controls.Add(Me.lblHAHouseNumber)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.lblPDDoB)
        Me.Controls.Add(Me.lblPDName)
        Me.Controls.Add(Me.lblSelectedFile)
        Me.Controls.Add(Me.GroupAddress)
        Me.Controls.Add(Me.GroupPersonalDetails)
        Me.Controls.Add(Me.GroupPersonalDetailsBG)
        Me.Controls.Add(Me.GroupAddressBG)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblPersonalDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnUpload)
        Me.Controls.Add(Me.pbID)
        Me.Controls.Add(Me.pbQR)
        Me.Name = "Home"
        Me.Text = "Home"
        CType(Me.pbQR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupAddressBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupPersonalDetailsBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupPersonalDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbQR As PictureBox
    Friend WithEvents pbID As PictureBox
    Friend WithEvents BtnUpload As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnLogOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPersonalDetails As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents GroupAddressBG As PictureBox
    Friend WithEvents GroupPersonalDetailsBG As PictureBox
    Friend WithEvents GroupPersonalDetails As PictureBox
    Friend WithEvents GroupAddress As PictureBox
    Friend WithEvents selectPictureDialog As OpenFileDialog
    Friend WithEvents lblSelectedFile As Label
    Friend WithEvents lblPDName As Label
    Friend WithEvents lblPDDoB As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblHAHouseNumber As Label
    Friend WithEvents lblHAStreetName As Label
    Friend WithEvents lblHACity As Label
    Friend WithEvents lblHAPostCode As Label
    Friend WithEvents BtnSetupAuthenticator As Button
End Class
