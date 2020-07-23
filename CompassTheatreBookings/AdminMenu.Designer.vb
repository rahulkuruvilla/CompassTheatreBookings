<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
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
        Me.lblAdminMenu = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFeedbackViewer = New System.Windows.Forms.Button()
        Me.btnCancelSeats = New System.Windows.Forms.Button()
        Me.txtGuestView = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdminMenu
        '
        Me.lblAdminMenu.AutoSize = True
        Me.lblAdminMenu.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminMenu.Location = New System.Drawing.Point(20, 65)
        Me.lblAdminMenu.Name = "lblAdminMenu"
        Me.lblAdminMenu.Size = New System.Drawing.Size(215, 45)
        Me.lblAdminMenu.TabIndex = 162
        Me.lblAdminMenu.Text = "Admin Menu"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 161
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 548)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 171
        Me.btnBack.Text = "Sign Out"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFeedbackViewer
        '
        Me.btnFeedbackViewer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedbackViewer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFeedbackViewer.Location = New System.Drawing.Point(784, 181)
        Me.btnFeedbackViewer.Name = "btnFeedbackViewer"
        Me.btnFeedbackViewer.Size = New System.Drawing.Size(143, 85)
        Me.btnFeedbackViewer.TabIndex = 172
        Me.btnFeedbackViewer.Text = "Feedback Control"
        Me.btnFeedbackViewer.UseVisualStyleBackColor = True
        '
        'btnCancelSeats
        '
        Me.btnCancelSeats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSeats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelSeats.Location = New System.Drawing.Point(784, 386)
        Me.btnCancelSeats.Name = "btnCancelSeats"
        Me.btnCancelSeats.Size = New System.Drawing.Size(143, 85)
        Me.btnCancelSeats.TabIndex = 173
        Me.btnCancelSeats.Text = "Cancel Bookings"
        Me.btnCancelSeats.UseVisualStyleBackColor = True
        '
        'txtGuestView
        '
        Me.txtGuestView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtGuestView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtGuestView.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestView.Location = New System.Drawing.Point(351, 366)
        Me.txtGuestView.Multiline = True
        Me.txtGuestView.Name = "txtGuestView"
        Me.txtGuestView.ReadOnly = True
        Me.txtGuestView.Size = New System.Drawing.Size(358, 131)
        Me.txtGuestView.TabIndex = 177
        Me.txtGuestView.Text = "Alternatively, you can access the Customer Guest view of the theatre to see how b" &
    "usy the booking is."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(351, 181)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(321, 74)
        Me.TextBox1.TabIndex = 174
        Me.TextBox1.Text = "Please select this option if you'd like to have a look at some of the feedback yo" &
    "ur customers have written about the theatre."
        '
        'lblBox
        '
        Me.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBox.Location = New System.Drawing.Point(325, 152)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(619, 150)
        Me.lblBox.TabIndex = 176
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(325, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(619, 177)
        Me.Label3.TabIndex = 178
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(52, 201)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(208, 54)
        Me.TextBox2.TabIndex = 180
        Me.TextBox2.Text = "Welcome back! Please select once the available options."
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(28, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 357)
        Me.Label1.TabIndex = 181
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CompassTheatreBookings.My.Resources.Resources.masks
        Me.PictureBox1.Location = New System.Drawing.Point(41, 357)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 132)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 179
        Me.PictureBox1.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 163
        Me.picLogo.TabStop = False
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtGuestView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCancelSeats)
        Me.Controls.Add(Me.btnFeedbackViewer)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblAdminMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminMenu"
        Me.Text = "AdminMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblAdminMenu As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFeedbackViewer As Button
    Friend WithEvents btnCancelSeats As Button
    Friend WithEvents txtGuestView As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBox As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
End Class
