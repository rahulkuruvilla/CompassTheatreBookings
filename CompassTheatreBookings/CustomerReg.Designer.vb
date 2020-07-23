<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerReg
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
        Me.lblCustReg = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtPasswordReenter = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAccountCreate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustReg
        '
        Me.lblCustReg.AutoSize = True
        Me.lblCustReg.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustReg.Location = New System.Drawing.Point(29, 65)
        Me.lblCustReg.Name = "lblCustReg"
        Me.lblCustReg.Size = New System.Drawing.Size(355, 45)
        Me.lblCustReg.TabIndex = 163
        Me.lblCustReg.Text = "Customer Registration"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 162
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 161
        Me.picLogo.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 164
        Me.btnBack.Text = "Back To Customer Login"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.CausesValidation = False
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(269, 150)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(328, 37)
        Me.lbl.TabIndex = 174
        Me.lbl.Text = "Enter your details here..."
        '
        'txtPasswordReenter
        '
        Me.txtPasswordReenter.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPasswordReenter.Location = New System.Drawing.Point(617, 342)
        Me.txtPasswordReenter.MaxLength = 15
        Me.txtPasswordReenter.Name = "txtPasswordReenter"
        Me.txtPasswordReenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordReenter.Size = New System.Drawing.Size(271, 20)
        Me.txtPasswordReenter.TabIndex = 173
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPassword.Location = New System.Drawing.Point(617, 270)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(271, 20)
        Me.txtPassword.TabIndex = 172
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.CausesValidation = False
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(299, 248)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(160, 45)
        Me.lblPassword.TabIndex = 170
        Me.lblPassword.Text = "Password:"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(550, 545)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 85)
        Me.btnReset.TabIndex = 169
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAccountCreate
        '
        Me.btnAccountCreate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccountCreate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAccountCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAccountCreate.Location = New System.Drawing.Point(794, 545)
        Me.btnAccountCreate.Name = "btnAccountCreate"
        Me.btnAccountCreate.Size = New System.Drawing.Size(143, 85)
        Me.btnAccountCreate.TabIndex = 168
        Me.btnAccountCreate.Text = "Create Account"
        Me.btnAccountCreate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(299, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 45)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(252, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(702, 357)
        Me.Label2.TabIndex = 171
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.CausesValidation = False
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(299, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 45)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Re-enter Password:"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUsername.Location = New System.Drawing.Point(617, 209)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(271, 20)
        Me.txtUsername.TabIndex = 176
        '
        'CustomerReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtPasswordReenter)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAccountCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCustReg)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Name = "CustomerReg"
        Me.Text = "CustomerReg"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustReg As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lbl As Label
    Friend WithEvents txtPasswordReenter As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnAccountCreate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
End Class
