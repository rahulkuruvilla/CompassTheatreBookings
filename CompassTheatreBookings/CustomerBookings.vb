'The relevant libraries are imported
Imports System.Data.SqlClient
Imports System.Data

Public Class CustomerBookings
    'The Bitmaps for seat booking state indicators are declared
    Dim bmpUnbooked As New System.Drawing.Bitmap(My.Resources.greenseat)
    Dim bmpTemporary As New System.Drawing.Bitmap(My.Resources.blueseat)
    Dim bmpBooked As New System.Drawing.Bitmap(My.Resources.redseat)

    Private Sub bookSeats(sender As Object, e As EventArgs) Handles btnBookSeats.Click
        'Variables to be used are declared 
        Dim obj As Control
        Dim blnSelection As Boolean
        Dim strSQLInsert As String
        Dim conBookings As New SqlConnection
        Dim comSaveBookings As New SqlCommand

        'Each seat item is checked to see if the user has made a temporary booking 
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox Then
                If CType(obj, PictureBox).Image Is bmpTemporary Then
                    blnSelection = True
                    Exit For
                End If
            End If
        Next

        'A message is given if no seats have been selected
        If blnSelection = False Then
            MsgBox("Please select an available seat to book to make a booking.")
            Exit Sub
        End If

        'The connection to the database is initialized and opened
        conBookings.ConnectionString = SQLCONSTRING
        conBookings.Open()
        comSaveBookings.Connection = conBookings

        'Each seat in the seat booking is checked to see if a provisional 
        'booking has been made. For provisionally booked seats, the booking 
        'is added to the Bookings table under the user's name and saved. 
        Dim intSeatNum As Integer
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox Then
                If CType(obj, PictureBox).Image Is bmpTemporary Then
                    intSeatNum = Mid(CType(obj, PictureBox).Name, 8)
                    strSQLInsert = "INSERT INTO tblBookings (Username, Seat)" &
                    "VALUES('" & strCustomerUsername & "'," & intSeatNum & ")"
                    comSaveBookings.CommandText = strSQLInsert
                    comSaveBookings.ExecuteNonQuery()
                End If
            End If
        Next

        'The connection to the database is closed and the seating arrangement 
        'is redisplyed according to any new bookings, by calling the update bookings procedure.
        conBookings.Close()
        updateBookings(gbTheatre)
    End Sub

    Private Sub UserBookingsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Variables declared
        Dim obj As Control
        Dim picLogo As String
        picLogo = "picLogo"

        'The iterative loop below initialises each Picture Box with the greenseat icon.'
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox And NameOf(obj) IsNot picLogo Then
                CType(obj, PictureBox).Image = bmpUnbooked
                'The AddHandler associates any seat being clicked to the event handler for any seat being clicked on.'
                AddHandler obj.Click, AddressOf picSeatClick
            End If
        Next

        updateBookings(gbTheatre)
    End Sub

    'Upon clicking on a temporary booking, it returns back to being available.' 
    Private Sub picSeatClick(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is bmpUnbooked Then
            CType(sender, PictureBox).Image = bmpTemporary
        ElseIf CType(sender, PictureBox).Image Is bmpTemporary Then
            CType(sender, PictureBox).Image = bmpUnbooked
        End If
    End Sub

    'The temporary bookings are returned to their orginal unbooked state
    Private Sub btnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim obj As Control

        'Each seat object is iterated through to see if it has been selected provisonally
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox Then
                If CType(obj, PictureBox).Image Is bmpTemporary Then
                    CType(obj, PictureBox).Image = bmpUnbooked
                End If
            End If
        Next
    End Sub

    'The previous screen is displayed and this screen is hidden
    Private Sub btnBackClick(sender As Object, e As EventArgs) Handles btnBack.Click
        CustomerMenu.Show()
        Me.Hide()
    End Sub
End Class