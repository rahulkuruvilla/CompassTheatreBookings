'Libraries imported
Imports System.Data.SqlClient
Public Class AdminLogin

    'When the login button is clicked the relevant screen will be displayed if 
    'details correct
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Variables declared
        Dim account As String
        Dim conLogin As New SqlConnection
        Dim cmdLogin As New SqlCommand
        Dim rdAdmin As SqlDataReader

        'The text fields are checked to see if they are empty
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username.")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password.")
        End If

        'Connection made to database and query created
        account = "admin"
        cmdLogin.CommandText = "SELECT * FROM tblUserList WHERE (Type = '" & account & "')" &
        "AND ([Username] COLLATE Latin1_General_CS_AS = '" & txtUsername.Text & "')" &
        "AND ([Password] COLLATE Latin1_General_CS_AS = '" & txtPassword.Text & "')"
        conLogin.ConnectionString = SQLCONSTRING
        conLogin.Open()
        cmdLogin.Connection = conLogin

        'Depending on what whether the correct username/ password has been entered 
        'an appropiate option is selected.
        rdAdmin = cmdLogin.ExecuteReader
        If rdAdmin.HasRows Then
            MessageBox.Show("Login Successful")
            txtUsername.Text = ""
            txtPassword.Text = ""
            conLogin.Close()
            AdminMenu.Show()
            Me.Hide()

        Else
            MessageBox.Show("Please enter a valid username and/or password.")
            conLogin.Close()
        End If
    End Sub

    'When the reset button the input is cleared
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    'When the back button is clicked the relevant screen will be displayed
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomePage.Show()
        Me.Hide()
    End Sub
End Class