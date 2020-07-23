'The relevant libraries are imported into the program
Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class AdminFeedbackControl
    Private Sub AdminFeedbackControlLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        'The variables used to display the feedback data
        Dim sqlStr As String
        Dim conFeedback As New SqlConnection
        Dim cmdFeedback As New SqlCommand
        Dim daFeedback As New SqlDataAdapter(cmdFeedback)
        Dim tblFeedback As New DataTable()
        Dim ds As New DataSet()
        Dim dgvCheckBox As New DataGridViewCheckBoxColumn()

        'The SQL query and connection string are declared
        sqlStr = "SELECT Feedback, Customer FROM tblShowFeedback"

        'The connection to the database is initialsed and made
        conFeedback.ConnectionString = SQLCONSTRING
        cmdFeedback.Connection = conFeedback
        cmdFeedback.CommandText = sqlStr
        conFeedback.Open()

        'The data source is filled with the table 
        daFeedback.Fill(ds, "tblFeedback")
        dgvFeedback.DataSource = ds
        dgvFeedback.DataMember = "tblFeedback"

        'Another column allowing the user to delete rows is added
        dgvCheckBox.HeaderText = "Delete"
        dgvFeedback.Columns.Add(dgvCheckBox)
        dgvFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        conFeedback.Close()
    End Sub

    'The Back button returns the user to the previous page 
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    'Any selected rows will be deleted from the DGV and database table
    Private Sub btnDeleteClick(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Variables declared
        Dim sqlStrDelete As String
        Dim conFeedback As New SqlConnection
        Dim cmdFeedback As New SqlCommand
        Dim delete As Boolean

        'The connection to the database is initialsed and made
        conFeedback.ConnectionString = SQLCONSTRING
        cmdFeedback.Connection = conFeedback
        conFeedback.Open()

        'Each row of the DGV is iterated through to check if it needs to be deleted
        'if the delete box is checked then it is deleted from the table and 
        'DGV as well.
        For i As Integer = (dgvFeedback.Rows.Count() - 1) To 0 Step -1
            delete = dgvFeedback.Rows(i).Cells(2).Value
            If delete Then
                Dim row As DataGridViewRow

                'The query for deleting the record is ran
                'A temp table is made so that the records can be ordered in the same way the 
                ' DGV is ordered.
                sqlStrDelete = "WITH tblTempFeedback AS(SELECT *, row = ROW_NUMBER() OVER" &
                "(ORDER BY ID) FROM tblShowFeedback) DELETE FROM tblTempFeedback WHERE row =" & (i + 1)
                cmdFeedback.CommandText = sqlStrDelete
                cmdFeedback.ExecuteNonQuery()

                'The row is deleted from the DGV
                row = dgvFeedback.Rows(i)
                dgvFeedback.Rows.Remove(row)
            End If
        Next

        'If no feedback is selected to be deleted then a message is displayed
        If delete = False Then
            MsgBox("Please select some feedback to delete.")
        End If
    End Sub

    Private Sub btnExportClick(sender As Object, e As EventArgs) Handles btnExport.Click
        'The user will select a folder
        Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()
        dialog.Description = "Select a folder to save the pdf file"
        dialog.ShowDialog(Me)
        Dim strLocation As String = dialog.SelectedPath & "\"

        'A temp table is created using the existing Data Grid View tool'
        Dim pdfTable As New PdfPTable(dgvFeedback.ColumnCount)
        pdfTable.DefaultCell.Padding = 5
        pdfTable.WidthPercentage = 90
        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
        pdfTable.DefaultCell.BorderWidth = 2

        'Each header is given its own cell
        For Each column As DataGridViewColumn In dgvFeedback.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            pdfTable.AddCell(cell)
        Next

        'Each item in the Data Grid is allocated to a cell in the to-be pdf file
        For Each row As DataGridViewRow In dgvFeedback.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString <> "" Then
                    pdfTable.AddCell(cell.Value.ToString())
                Else
                    pdfTable.AddCell("")
                End If
            Next
        Next

        'The pdftable is saved as a file on the storage location
        Using pdfstream As New FileStream(strLocation & "feedback_listings.pdf", FileMode.Create)
            Dim file As New Document(PageSize.A2, 10.0F, 10.0F, 10.0F, 0.0F)
            PdfWriter.GetInstance(file, pdfstream)
            file.Open()
            file.Add(pdfTable)
            file.Close()
            pdfstream.Close()
        End Using
        MessageBox.Show("PDF export successful. Exists at " & strLocation & "feedback_listings.pdf")
    End Sub
End Class