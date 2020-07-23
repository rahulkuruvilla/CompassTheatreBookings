'External libraries are imported
Imports System.Data.SqlClient
Module TheatreDisplay
    Dim bmpBooked As New System.Drawing.Bitmap(My.Resources.redseat)
    Public Sub updateBookings(theatre As GroupBox)
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
            CType(theatre.Controls("picSeat" & row(2)), PictureBox).Image = bmpBooked
        Next
    End Sub
End Module
