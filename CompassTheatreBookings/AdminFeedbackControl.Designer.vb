<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminFeedbackControl
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblAdminFeedback = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.dgvFeedback = New System.Windows.Forms.DataGridView()
        Me.FeedbackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblShowFeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookingSystemDataSet = New CompassTheatreBookings.BookingSystemDataSet()
        Me.TblShowFeedbackTableAdapter = New CompassTheatreBookings.BookingSystemDataSetTableAdapters.tblShowFeedbackTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.dgvFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblShowFeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAdminFeedback
        '
        Me.lblAdminFeedback.AutoSize = True
        Me.lblAdminFeedback.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminFeedback.Location = New System.Drawing.Point(20, 65)
        Me.lblAdminFeedback.Name = "lblAdminFeedback"
        Me.lblAdminFeedback.Size = New System.Drawing.Size(392, 45)
        Me.lblAdminFeedback.TabIndex = 165
        Me.lblAdminFeedback.Text = "Admin Feedback Control"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 35.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(17, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(717, 62)
        Me.lblTitle.TabIndex = 164
        Me.lblTitle.Text = "The Compass Theatre Bookings"
        '
        'dgvFeedback
        '
        Me.dgvFeedback.AllowUserToAddRows = False
        Me.dgvFeedback.AutoGenerateColumns = False
        Me.dgvFeedback.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FeedbackDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn})
        Me.dgvFeedback.DataSource = Me.TblShowFeedbackBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFeedback.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFeedback.Location = New System.Drawing.Point(165, 137)
        Me.dgvFeedback.Name = "dgvFeedback"
        Me.dgvFeedback.Size = New System.Drawing.Size(779, 233)
        Me.dgvFeedback.TabIndex = 167
        '
        'FeedbackDataGridViewTextBoxColumn
        '
        Me.FeedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn.HeaderText = "Feedback"
        Me.FeedbackDataGridViewTextBoxColumn.Name = "FeedbackDataGridViewTextBoxColumn"
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        '
        'TblShowFeedbackBindingSource
        '
        Me.TblShowFeedbackBindingSource.DataMember = "tblShowFeedback"
        Me.TblShowFeedbackBindingSource.DataSource = Me.BookingSystemDataSet
        '
        'BookingSystemDataSet
        '
        Me.BookingSystemDataSet.DataSetName = "BookingSystemDataSet"
        Me.BookingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblShowFeedbackTableAdapter
        '
        Me.TblShowFeedbackTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBack.Location = New System.Drawing.Point(28, 546)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 85)
        Me.btnBack.TabIndex = 302
        Me.btnBack.Text = "Back To Admin Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(722, 402)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(222, 49)
        Me.btnDelete.TabIndex = 304
        Me.btnDelete.Text = "Delete Feedback Message"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(445, 402)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(222, 49)
        Me.btnExport.TabIndex = 305
        Me.btnExport.Text = "Export feedback to pdf file"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picLogo.Image = Global.CompassTheatreBookings.My.Resources.Resources.logo
        Me.picLogo.Location = New System.Drawing.Point(784, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(160, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 166
        Me.picLogo.TabStop = False
        '
        'AdminFeedbackControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFeedback)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblAdminFeedback)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AdminFeedbackControl"
        Me.Text = "AdminFeedbackControl"
        CType(Me.dgvFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblShowFeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblAdminFeedback As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents dgvFeedback As DataGridView
    Friend WithEvents BookingSystemDataSet As BookingSystemDataSet
    Friend WithEvents TblShowFeedbackBindingSource As BindingSource
    Friend WithEvents TblShowFeedbackTableAdapter As BookingSystemDataSetTableAdapters.tblShowFeedbackTableAdapter
    Friend WithEvents FeedbackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnBack As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
