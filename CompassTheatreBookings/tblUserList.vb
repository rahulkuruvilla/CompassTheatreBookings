'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblUserList
    Public Property Username As String
    Public Property Password As String
    Public Property Type As String

    Public Overridable Property tblBookings As ICollection(Of tblBooking) = New HashSet(Of tblBooking)

End Class
