<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerFeedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerFeedback))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCustomerFeedback = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtInfo1 = New System.Windows.Forms.TextBox()
        Me.txtFeedbackForm = New System.Windows.Forms.TextBox()
        Me.txtInfo2 = New System.Windows.Forms.TextBox()
        Me.txtInfo3 = New System.Windows.Forms.TextBox()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.lblBox = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.lblTitle.TabIndex = 159
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'lblCustomerFeedback
        '
        Me.lblCustomerFeedback.AutoSize = True
        Me.lblCustomerFeedback.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerFeedback.Location = New System.Drawing.Point(29, 65)
        Me.lblCustomerFeedback.Name = "lblCustomerFeedback"
        Me.lblCustomerFeedback.Size = New System.Drawing.Size(314, 45)
        Me.lblCustomerFeedback.TabIndex = 160
        Me.lblCustomerFeedback.Text = "Customer Feedback"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 161
        Me.btnBack.Text = "Back to Customer Account Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFeedback
        '
        Me.btnFeedback.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFeedback.Location = New System.Drawing.Point(780, 546)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(143, 85)
        Me.btnFeedback.TabIndex = 162
        Me.btnFeedback.Text = "Send Feedback"
        Me.btnFeedback.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReset.Location = New System.Drawing.Point(501, 546)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(143, 85)
        Me.btnReset.TabIndex = 163
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtInfo1
        '
        Me.txtInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo1.Location = New System.Drawing.Point(28, 143)
        Me.txtInfo1.Multiline = True
        Me.txtInfo1.Name = "txtInfo1"
        Me.txtInfo1.ReadOnly = True
        Me.txtInfo1.Size = New System.Drawing.Size(404, 111)
        Me.txtInfo1.TabIndex = 165
        Me.txtInfo1.Text = resources.GetString("txtInfo1.Text")
        '
        'txtFeedbackForm
        '
        Me.txtFeedbackForm.Location = New System.Drawing.Point(501, 172)
        Me.txtFeedbackForm.MaxLength = 150
        Me.txtFeedbackForm.Multiline = True
        Me.txtFeedbackForm.Name = "txtFeedbackForm"
        Me.txtFeedbackForm.Size = New System.Drawing.Size(422, 326)
        Me.txtFeedbackForm.TabIndex = 166
        '
        'txtInfo2
        '
        Me.txtInfo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo2.Location = New System.Drawing.Point(28, 360)
        Me.txtInfo2.Multiline = True
        Me.txtInfo2.Name = "txtInfo2"
        Me.txtInfo2.ReadOnly = True
        Me.txtInfo2.Size = New System.Drawing.Size(404, 76)
        Me.txtInfo2.TabIndex = 167
        Me.txtInfo2.Text = "If there's anything you'd like to talk to us about in person please feel free to " &
    "speak to one of our members of staff and they'd be available to listen."
        '
        'txtInfo3
        '
        Me.txtInfo3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtInfo3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo3.Location = New System.Drawing.Point(28, 273)
        Me.txtInfo3.Multiline = True
        Me.txtInfo3.Name = "txtInfo3"
        Me.txtInfo3.ReadOnly = True
        Me.txtInfo3.Size = New System.Drawing.Size(404, 68)
        Me.txtInfo3.TabIndex = 168
        Me.txtInfo3.Text = "With this tool you can send feedback to one of our administrators under your user" &
    "name and they will gladly recieve it."
        '
        'txtFeedback
        '
        Me.txtFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFeedback.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFeedback.Location = New System.Drawing.Point(501, 143)
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.ReadOnly = True
        Me.txtFeedback.Size = New System.Drawing.Size(85, 22)
        Me.txtFeedback.TabIndex = 169
        Me.txtFeedback.Text = "Feedback:"
        '
        'lblBox
        '
        Me.lblBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBox.Location = New System.Drawing.Point(12, 129)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(429, 405)
        Me.lblBox.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(475, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 405)
        Me.Label1.TabIndex = 171
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 158
        Me.picLogo.TabStop = False
        '
        'CustomerFeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.txtInfo3)
        Me.Controls.Add(Me.txtInfo2)
        Me.Controls.Add(Me.txtFeedbackForm)
        Me.Controls.Add(Me.txtInfo1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblCustomerFeedback)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CustomerFeedback"
        Me.Text = "CustomerFeedback"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCustomerFeedback As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtInfo1 As TextBox
    Friend WithEvents txtFeedbackForm As TextBox
    Friend WithEvents txtInfo2 As TextBox
    Friend WithEvents txtInfo3 As TextBox
    Friend WithEvents txtFeedback As TextBox
    Friend WithEvents lblBox As Label
    Friend WithEvents Label1 As Label
End Class
