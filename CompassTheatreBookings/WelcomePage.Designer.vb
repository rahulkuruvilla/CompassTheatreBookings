<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomePage
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
        Me.btnALogin = New System.Windows.Forms.Button()
        Me.btnCLogin = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtWelcome = New System.Windows.Forms.TextBox()
        Me.picWelcome = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnALogin
        '
        Me.btnALogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnALogin.Location = New System.Drawing.Point(28, 546)
        Me.btnALogin.Name = "btnALogin"
        Me.btnALogin.Size = New System.Drawing.Size(143, 85)
        Me.btnALogin.TabIndex = 3
        Me.btnALogin.Text = "Administrator Login"
        Me.btnALogin.UseVisualStyleBackColor = True
        '
        'btnCLogin
        '
        Me.btnCLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCLogin.Location = New System.Drawing.Point(414, 546)
        Me.btnCLogin.Name = "btnCLogin"
        Me.btnCLogin.Size = New System.Drawing.Size(143, 85)
        Me.btnCLogin.TabIndex = 5
        Me.btnCLogin.Text = "Customer Login"
        Me.btnCLogin.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(800, 546)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(143, 85)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "Legal/Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'txtWelcome
        '
        Me.txtWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWelcome.Location = New System.Drawing.Point(160, 134)
        Me.txtWelcome.Multiline = True
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.ReadOnly = True
        Me.txtWelcome.Size = New System.Drawing.Size(641, 79)
        Me.txtWelcome.TabIndex = 4
        Me.txtWelcome.Text = "Welcome to The Compass Theatre Bookings, please select an appropiate login method" &
    "."
        Me.txtWelcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picWelcome
        '
        Me.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picWelcome.Image = Global.CompassTheatreBookings.My.Resources.Resources.welcomePage
        Me.picWelcome.Location = New System.Drawing.Point(236, 232)
        Me.picWelcome.Name = "picWelcome"
        Me.picWelcome.Size = New System.Drawing.Size(486, 277)
        Me.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWelcome.TabIndex = 2
        Me.picWelcome.TabStop = False
        '
        'logo
        '
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(784, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(160, 98)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnCLogin)
        Me.Controls.Add(Me.txtWelcome)
        Me.Controls.Add(Me.btnALogin)
        Me.Controls.Add(Me.picWelcome)
        Me.Controls.Add(Me.logo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WelcomePage"
        Me.Text = "WelcomePage"
        CType(Me.picWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logo As PictureBox
    Friend WithEvents picWelcome As PictureBox
    Friend WithEvents btnALogin As Button
    Friend WithEvents btnCLogin As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtWelcome As TextBox
End Class
