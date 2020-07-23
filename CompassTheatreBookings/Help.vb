Public Class Help
    'When the back button is clicked the welcome screen will be displayed
    Private Sub btnBackToWelcomeClick(sender As Object, e As EventArgs) Handles btnBackToWelcome.Click
        WelcomePage.Show()
        Me.Hide()
    End Sub
End Class