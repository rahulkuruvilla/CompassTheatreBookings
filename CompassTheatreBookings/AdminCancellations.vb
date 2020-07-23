'Required libraries are imported
Imports System.Data.SqlClient
Imports System.Data
Public Class AdminCancellations
    'variables are declared
    Dim bmpUnbooked As New System.Drawing.Bitmap(My.Resources.greenseat)
    Dim bmpTemporary As New System.Drawing.Bitmap(My.Resources.blueseat)
    Dim bmpBooked As New System.Drawing.Bitmap(My.Resources.redseat)

    Private Sub updateBookings()
        'Variables declared
        Dim strSQl As String
        Dim conBookings As New SqlConnection
        Dim comSelectBookings As New SqlCommand
        Dim dsBookings As New DataSet

        'Connection to database is initialized and made 
        strSQl = "SELECT * FROM tblBookings"
        conBookings.ConnectionString = SQLCONSTRING
        conBookings.Open()
        comSelectBookings.CommandText = strSQl
        comSelectBookings.Connection = conBookings

        'The bookings table is stored under a data adapter
        Dim daBookings As New SqlDataAdapter(comSelectBookings)
        daBookings.Fill(dsBookings, "Bookings")
        conBookings.Close()

        'For each booking made in the Bookings table, the linked seat 
        'displayed to the user becomes green.
        Dim tblBookings As DataTable = dsBookings.Tables("Bookings")
        Dim row As DataRow
        For Each row In tblBookings.Rows
            CType(gbTheatre.Controls("picSeat" & row(2)), PictureBox).Image = bmpBooked
        Next
    End Sub

    Private Sub btnCancelBookingsClick(sender As Object, e As EventArgs) Handles btnCancelBookings.Click
        'Variables declared
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
            MsgBox("Please select a booked seat to make a cancellation.")
            Exit Sub
        End If

        'The connection to the database is initialized and opened
        conBookings.ConnectionString = SQLCONSTRING
        conBookings.Open()
        comSaveBookings.Connection = conBookings

        'Each seat in the seat booking is checked to see if a provisional 
        'cancellation has been made. For provisionally cancelled seats, the booking 
        'record is deleted from the Bookings table. 
        Dim intSeatNum As Integer
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox Then
                If CType(obj, PictureBox).Image Is bmpTemporary Then
                    intSeatNum = Mid(CType(obj, PictureBox).Name, 8)
                    strSQLInsert = "DELETE FROM tblBookings WHERE Seat =" & intSeatNum
                    comSaveBookings.CommandText = strSQLInsert
                    comSaveBookings.ExecuteNonQuery()
                    CType(obj, PictureBox).Image = bmpUnbooked
                End If
            End If
        Next

        'The connection to the database is closed and the seating arrangement 
        'is redisplyed according to any new bookings, by calling the update bookings procedure.
        conBookings.Close()
        updateBookings()
    End Sub
    Private Sub AdminCancellationsLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'A local variable obj is defined through the control class for controls that can be represented visually.'
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
        updateBookings()
    End Sub

    'The temporary bookings are returned to their orginal unbooked state
    Private Sub btnResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim obj As Control

        'Each seat object is iterated through to see if it has been selected provisonally
        For Each obj In gbTheatre.Controls
            If TypeOf (obj) Is PictureBox Then
                If CType(obj, PictureBox).Image Is bmpTemporary Then
                    CType(obj, PictureBox).Image = bmpBooked
                End If
            End If
        Next
    End Sub

    'Upon clicking on a temporary booking, it returns back to being available.' 
    Private Sub picSeatClick(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is bmpBooked Then
            CType(sender, PictureBox).Image = bmpTemporary
        ElseIf CType(sender, PictureBox).Image Is bmpTemporary Then
            CType(sender, PictureBox).Image = bmpBooked
        End If
    End Sub

    'The previous screen is displayed and this screen is hidden
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub
End Class