Public Class WelcomePage

    'When the admin login button is clicked the relevant screen will be displayed
    Private Sub adminLoginClick(sender As Object, e As EventArgs) Handles btnALogin.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    'When the help button is clicked the relevant screen will be displayed
    Private Sub helpButtonClick(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.Show()
        Me.Hide()
    End Sub

    'When the customer login button is clicked the relevant screen will be displayed
    Private Sub customerLoginClick(sender As Object, e As EventArgs) Handles btnCLogin.Click
        CustomerLogin.Show()
        Me.Hide()
    End Sub
End Class

'The global variables used will be declared below
Public Module Globals
    Public strCustomerUsername As String
    Public SQLCONSTRING As String = "Data Source=(LocalDB)\MSSQLLocalDB;" &
    "AttachDbFilename=C:\Users\Rahul\Desktop\CompassTheatreBookings\CompassTheatreBookings\BookingSystemData.mdf;" &
    "Integrated Security=True"
End Module