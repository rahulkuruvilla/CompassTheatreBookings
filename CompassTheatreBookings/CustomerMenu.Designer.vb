<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerMenu
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
        Me.lblCustomerMenu = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBookSeats = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'lblCustomerMenu
        '
        Me.lblCustomerMenu.AutoSize = True
        Me.lblCustomerMenu.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerMenu.Location = New System.Drawing.Point(29, 65)
        Me.lblCustomerMenu.Name = "lblCustomerMenu"
        Me.lblCustomerMenu.Size = New System.Drawing.Size(391, 45)
        Me.lblCustomerMenu.TabIndex = 12
        Me.lblCustomerMenu.Text = "Customer Account Menu"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 158
        Me.btnBack.Text = "Sign Out"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBookSeats
        '
        Me.btnBookSeats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookSeats.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBookSeats.Location = New System.Drawing.Point(410, 546)
        Me.btnBookSeats.Name = "btnBookSeats"
        Me.btnBookSeats.Size = New System.Drawing.Size(143, 85)
        Me.btnBookSeats.TabIndex = 159
        Me.btnBookSeats.Text = "Book Seats"
        Me.btnBookSeats.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFeedback.Location = New System.Drawing.Point(784, 546)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(143, 85)
        Me.btnFeedback.TabIndex = 160
        Me.btnFeedback.Text = "Give Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(28, 168)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(292, 52)
        Me.TextBox1.TabIndex = 161
        Me.TextBox1.Text = "Welcome back"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(108, 207)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(159, 40)
        Me.lblUsername.TabIndex = 162
        Me.lblUsername.Text = "(username)"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(28, 307)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(509, 125)
        Me.TextBox2.TabIndex = 164
        Me.TextBox2.Text = "You can book seats to any upcoming shows or alternatively provide feedback on how" &
    " your experience was."
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 157
        Me.picLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CompassTheatreBookings.My.Resources.Resources.masks
        Me.PictureBox1.Location = New System.Drawing.Point(611, 207)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 203)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 180
        Me.PictureBox1.TabStop = False
        '
        'CustomerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.btnBookSeats)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblCustomerMenu)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "CustomerMenu"
        Me.Text = "CustomerMenu"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomerMenu As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnBookSeats As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
