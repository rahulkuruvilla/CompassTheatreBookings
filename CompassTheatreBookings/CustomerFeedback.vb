'Libraries imported 
Imports System.Data.SqlClient
Imports System.Data
Public Class CustomerFeedback
    'When the reset button is cliekc the text field becomes empty
    Private Sub btnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFeedbackForm.Text = ""
    End Sub

    'When the Feedback button is clicked, the entered text is added to the feedback database
    Private Sub btnFeedbackClick(sender As Object, e As EventArgs) Handles btnFeedback.Click
        'Variables declared
        Dim userFeedback As String
        Dim strSQl As String
        Dim conFeedback As New SqlConnection
        Dim cmdSendFeedback As New SqlCommand

        'The input is validated to see if any text was entered, if nothing was entered, nothing will be added
        If txtFeedbackForm.Text = "" Then
            MessageBox.Show("Please enter some text as your feedback.")
        End If

        'The connection to the database And table are made 
        userFeedback = txtFeedbackForm.Text
        strSQl = "INSERT INTO tblShowFeedback (Feedback,Customer) VALUES('" & userFeedback & "','" & strCustomerUsername & "')"
        conFeedback.ConnectionString = SQLCONSTRING
        cmdSendFeedback.Connection = conFeedback
        cmdSendFeedback.CommandText = strSQl
        conFeedback.Open()

        'The query to insert the data into the table is ran
        cmdSendFeedback.ExecuteNonQuery()
        conFeedback.Close()
        MessageBox.Show("Feedback successfully sent.")
        txtFeedbackForm.Text = ""
    End Sub

    'The Back button returns the user to the Customer menu page
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerMenu.Show()
        Me.Hide()
    End Sub

End Class





