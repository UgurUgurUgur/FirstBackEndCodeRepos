Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1 As Integer = 520
        Dim num2 As Integer = 12
        Dim som As Double = num1 Mod num2
        Dim som2 As Integer = num1 / num2
        MsgBox("12 past " & som2 & " keer in 520 en de modulo hiervan is " & som)
    End Sub
End Class
