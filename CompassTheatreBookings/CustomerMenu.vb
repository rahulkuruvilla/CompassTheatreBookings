Public Class CustomerMenu
    'When the Book Seats button is clicked the relevant screen will be displayed
    Private Sub btnBookSeats_Click(sender As Object, e As EventArgs) Handles btnBookSeats.Click
        CustomerBookings.Show()
        Me.Hide()
    End Sub

    'When the Back button is clicked the relevant screen will be displayed
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerLogin.Show()
        Me.Hide()
    End Sub

    'What happens when the page loads
    Private Sub CustomerMenuLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = strCustomerUsername & ". Please select an option."
    End Sub

    'When the Feedback button is clicked the relevant screen will be displayed
    Private Sub btnFeedbackClick(sender As Object, e As EventArgs) Handles btnFeedback.Click
        CustomerFeedback.Show()
        Me.Hide()
    End Sub

End Class






