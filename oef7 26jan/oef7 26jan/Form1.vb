Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim time
        time = Now().ToString("hh:mm")
        Dim ddate
        ddate = Now().ToString("yyyy-MM-dd")

        Convert.ToDateTime(ddate)
        Dim editedTime
        editedTime = DateAdd(2, ddate)
        Dim editedDate
        editedDate = 

        MsgBox("The current date is: " & ddate & vbCrLf & "The current time is: " &
               time & "The edited time is: ")
    End Sub
End Class
