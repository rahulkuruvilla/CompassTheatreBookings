<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.title = New System.Windows.Forms.Label()
        Me.btnBackToWelcome = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.logo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(784, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(160, 98)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        Me.logo.UseWaitCursor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(17, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(717, 62)
        Me.title.TabIndex = 8
        Me.title.Text = "The Compass Theatre Bookings"
        Me.title.UseWaitCursor = True
        '
        'btnBackToWelcome
        '
        Me.btnBackToWelcome.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToWelcome.Location = New System.Drawing.Point(28, 546)
        Me.btnBackToWelcome.Name = "btnBackToWelcome"
        Me.btnBackToWelcome.Size = New System.Drawing.Size(143, 85)
        Me.btnBackToWelcome.TabIndex = 9
        Me.btnBackToWelcome.Text = "Back to Welcome Page"
        Me.btnBackToWelcome.UseVisualStyleBackColor = True
        Me.btnBackToWelcome.UseWaitCursor = True
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(29, 65)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(184, 45)
        Me.lblHelp.TabIndex = 153
        Me.lblHelp.Text = "Help/Legal"
        Me.lblHelp.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CompassTheatreBookings.My.Resources.Resources.DPA
        Me.PictureBox1.Location = New System.Drawing.Point(232, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 575)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnBackToWelcome)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.logo)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.UseWaitCursor = True
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents title As Label
    Friend WithEvents btnBackToWelcome As Button
    Friend WithEvents lblHelp As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
