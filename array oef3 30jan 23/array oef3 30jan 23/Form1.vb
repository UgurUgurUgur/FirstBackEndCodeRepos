Imports System.Reflection.Metadata.Ecma335

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim students() As Integer
        For i = 1 To 10
            students(i) = TextBox1.Text
            TextBox1.Clear()
        Next i
        Dim gemiddelde As Double = (students(0) + students(1) + students(2) + students(3) + students(4) +
            students(5) + students(6) + students(7) + students(8) + students(9) / 10)
        MsgBox("Het gemiddelde van de cijfers is: ")
    End Sub
End Class
