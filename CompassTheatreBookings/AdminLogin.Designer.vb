<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLogin
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
        Me.lblAdminLogin = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdminLogin
        '
        Me.lblAdminLogin.AutoSize = True
        Me.lblAdminLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminLogin.Location = New System.Drawing.Point(20, 65)
        Me.lblAdminLogin.Name = "lblAdminLogin"
        Me.lblAdminLogin.Size = New System.Drawing.Size(213, 45)
        Me.lblAdminLogin.TabIndex = 159
        Me.lblAdminLogin.Text = "Admin Login"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 158
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
        Me.picLogo.TabIndex = 160
        Me.picLogo.TabStop = False
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.CausesValidation = False
        Me.lblInstruction.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(406, 228)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(328, 37)
        Me.lblInstruction.TabIndex = 180
        Me.lblInstruction.Text = "Enter your details here..."
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPassword.Location = New System.Drawing.Point(583, 348)
        Me.txtPassword.MaxLength = 15
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(271, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUsername.Location = New System.Drawing.Point(583, 287)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(271, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.CausesValidation = False
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(405, 326)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(160, 45)
        Me.lblPassword.TabIndex = 176
        Me.lblPassword.Text = "Password:"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(540, 546)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 85)
        Me.btnReset.TabIndex = 174
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.Location = New System.Drawing.Point(784, 546)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(143, 85)
        Me.btnLogin.TabIndex = 173
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.CausesValidation = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 45)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Username:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 170
        Me.btnBack.Text = "Back To the Welcome Page"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(40, 256)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(266, 69)
        Me.TextBox1.TabIndex = 169
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Please enter your username and password to access the system for further function" &
    "ality."
        '
        'lblBox
        '
        Me.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBox.Location = New System.Drawing.Point(28, 244)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(312, 99)
        Me.lblBox.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(381, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(563, 212)
        Me.Label2.TabIndex = 177
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblAdminLogin)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblAdminLogin As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBox As Label
    Friend WithEvents Label2 As Label
End Class
