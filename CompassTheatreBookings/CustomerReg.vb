'Libraries imported
Imports System.Data.SqlClient
Public Class CustomerReg
    'Inputted text fields are emptied
    Private Sub btnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Text = ""
        txtPasswordReenter.Text = ""
        txtUsername.Text = ""
    End Sub

    'The Back button returns the user to the previous page
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerLogin.Show()
        Me.Hide()
    End Sub

    'The user account is created when the Create Account Button is clicked.
    'The input has to be validated first.
    Private Sub btnAccountCreateClick(sender As Object, e As EventArgs) Handles btnAccountCreate.Click
        'Variables declared
        Dim account As String = "customer"
        Dim conUserList As New SqlConnection
        Dim cmdCheck As New SqlCommand
        Dim cmdSignUp As New SqlCommand
        Dim rdCustomer As SqlDataReader

        'The text fields are validated  to ensure data has been inputted
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter a username.")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter a password.")
        ElseIf txtPasswordReenter.Text = "" Then
            MessageBox.Show("Please re-enter the same password.")
        ElseIf txtPassword.Text <> txtPasswordReenter.Text Then
            MessageBox.Show("Please enter matching passwords.")
        Else

            cmdCheck.CommandText = "SELECT username FROM tblUserList WHERE Username = '" & txtUsername.Text & "'"
            conUserList.ConnectionString = SQLCONSTRING
            conUserList.Open()
            cmdCheck.Connection = conUserList
            rdCustomer = cmdCheck.ExecuteReader

            'The User list table is checked to see if the username is already taken 
            If rdCustomer.HasRows Then
                MessageBox.Show("Username already taken, please choose another.")
                conUserList.Close()
            Else
                conUserList.Close()

                'A new query is made to insert the new user into the table 
                cmdSignUp.CommandText = "INSERT INTO tblUserList (Username, Password, Type) VALUES " &
                "('" & txtUsername.Text & "', '" & txtPassword.Text & "','" & account & "')"
                conUserList.Open()
                cmdSignUp.Connection = conUserList
                cmdSignUp.ExecuteNonQuery()
                MessageBox.Show("Registration Successful.")
                txtUsername.Text = ""
                txtPassword.Text = ""
                conUserList.Close()
            End If
        End If
    End Sub
End Class