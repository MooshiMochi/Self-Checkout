<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPictureBox
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
        Me.pbDefault = New System.Windows.Forms.PictureBox()
        Me.BtnSelect = New System.Windows.Forms.Button()
        CType(Me.pbDefault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDefault
        '
        Me.pbDefault.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.pbDefault.Location = New System.Drawing.Point(98, 32)
        Me.pbDefault.Name = "pbDefault"
        Me.pbDefault.Size = New System.Drawing.Size(770, 511)
        Me.pbDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDefault.TabIndex = 0
        Me.pbDefault.TabStop = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.BtnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSelect.FlatAppearance.BorderSize = 8
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelect.Font = New System.Drawing.Font("Lucida Sans", 7.875!)
        Me.BtnSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BtnSelect.Location = New System.Drawing.Point(409, 586)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(150, 72)
        Me.BtnSelect.TabIndex = 7
        Me.BtnSelect.Text = "Ok"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'ViewPictureBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(969, 690)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.pbDefault)
        Me.Name = "ViewPictureBox"
        Me.Text = "Picture"
        CType(Me.pbDefault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDefault As PictureBox
    Friend WithEvents BtnSelect As Button
End Class
