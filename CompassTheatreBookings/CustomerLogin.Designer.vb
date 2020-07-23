<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerLogin
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCustomerLogin = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnGuestView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtGuestView = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'lblCustomerLogin
        '
        Me.lblCustomerLogin.AutoSize = True
        Me.lblCustomerLogin.CausesValidation = False
        Me.lblCustomerLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerLogin.Location = New System.Drawing.Point(29, 65)
        Me.lblCustomerLogin.Name = "lblCustomerLogin"
        Me.lblCustomerLogin.Size = New System.Drawing.Size(257, 45)
        Me.lblCustomerLogin.TabIndex = 12
        Me.lblCustomerLogin.Text = "Customer Login"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(37, 151)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(266, 127)
        Me.TextBox1.TabIndex = 155
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Please enter your username and password to access the system. The login details w" &
    "ill have been provided by an Administrator at the Compass Theatre."
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 156
        Me.btnBack.Text = "Back To Welcome Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnGuestView
        '
        Me.btnGuestView.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuestView.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuestView.Location = New System.Drawing.Point(197, 382)
        Me.btnGuestView.Name = "btnGuestView"
        Me.btnGuestView.Size = New System.Drawing.Size(143, 85)
        Me.btnGuestView.TabIndex = 157
        Me.btnGuestView.Text = "Sign Up"
        Me.btnGuestView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 45)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Username:"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.Location = New System.Drawing.Point(784, 546)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(143, 85)
        Me.btnLogin.TabIndex = 159
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(540, 546)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 85)
        Me.btnReset.TabIndex = 160
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblBox
        '
        Me.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBox.CausesValidation = False
        Me.lblBox.Location = New System.Drawing.Point(28, 141)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(312, 150)
        Me.lblBox.TabIndex = 161
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.CausesValidation = False
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(389, 249)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(160, 45)
        Me.lblPassword.TabIndex = 162
        Me.lblPassword.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(362, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 357)
        Me.Label2.TabIndex = 163
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUsername.Location = New System.Drawing.Point(567, 210)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(271, 20)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPassword.Location = New System.Drawing.Point(567, 271)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(271, 20)
        Me.txtPassword.TabIndex = 2
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.CausesValidation = False
        Me.lbl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(390, 151)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(328, 37)
        Me.lbl.TabIndex = 166
        Me.lbl.Text = "Enter your details here..."
        '
        'txtGuestView
        '
        Me.txtGuestView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGuestView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuestView.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestView.Location = New System.Drawing.Point(37, 382)
        Me.txtGuestView.Multiline = True
        Me.txtGuestView.Name = "txtGuestView"
        Me.txtGuestView.ReadOnly = True
        Me.txtGuestView.Size = New System.Drawing.Size(151, 102)
        Me.txtGuestView.TabIndex = 167
        Me.txtGuestView.Text = "Alternatively, you can sign  up by making an account with us."
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(28, 352)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 146)
        Me.Label3.TabIndex = 168
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 8
        Me.picLogo.TabStop = False
        '
        'CustomerLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.txtGuestView)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuestView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblCustomerLogin)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "CustomerLogin"
        Me.Text = "CustomerLogin"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblCustomerLogin As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnGuestView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblBox As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lbl As Label
    Friend WithEvents txtGuestView As TextBox
    Friend WithEvents Label3 As Label
End Class
