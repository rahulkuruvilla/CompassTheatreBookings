'Libraries imported
Imports System.Data.SqlClient
Public Class CustomerLogin
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomePage.Show()
        Me.Hide()
    End Sub

    'When the login button is clicked the relevant screen will be displayed if details are correct
    Private Sub btnLoginClick(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Variables declared
        Dim account As String
        Dim conLogin As New SqlConnection
        Dim cmdLogin As New SqlCommand
        Dim rdCustomer As SqlDataReader

        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username.")
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password.")
            Exit Sub
        End If

        'Connection made to database and query created
        account = "customer"
        cmdLogin.CommandText = "SELECT * FROM tblUserList WHERE (Type = '" & account & "')" &
        "AND ([Username] COLLATE Latin1_General_CS_AS = '" & txtUsername.Text & "') AND" &
        "([Password] COLLATE Latin1_General_CS_AS = '" & txtPassword.Text & "') "
        conLogin.ConnectionString = SQLCONSTRING
        conLogin.Open()
        cmdLogin.Connection = conLogin

        'Depending on what whether the correct username/ password has been entered 
        'an appropiate option is selected.
        rdCustomer = cmdLogin.ExecuteReader
        If rdCustomer.HasRows Then
            strCustomerUsername = txtUsername.Text
            MessageBox.Show("Login Successful")
            txtUsername.Text = ""
            txtPassword.Text = ""
            conLogin.Close()
            CustomerMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter a valid username and/or password.")
            conLogin.Close()
        End If
    End Sub

    'When the reset button the input is cleared
    Private Sub btnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    'When the guest view button is clicked the relevant screen will be displayed
    Private Sub btnGuestViewClick(sender As Object, e As EventArgs) Handles btnGuestView.Click
        CustomerReg.Show()
        Me.Hide()
    End Sub
End Class

