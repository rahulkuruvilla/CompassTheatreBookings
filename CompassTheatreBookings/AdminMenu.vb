Public Class AdminMenu
    'When the customer login button is clicked the relevant screen will be displayed
    Private Sub btnCancelSeatsClick(sender As Object, e As EventArgs) Handles btnCancelSeats.Click
        AdminCancellations.Show()
        Me.Hide()
    End Sub

    'When the customer login button is clicked the relevant screen will be displayed
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    'When the customer login button is clicked the relevant screen will be displayed
    Private Sub btnFeedbackViewerClick(sender As Object, e As EventArgs) Handles btnFeedbackViewer.Click
        AdminFeedbackControl.Show()
        Me.Hide()
    End Sub
End Class