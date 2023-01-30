Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num1 As Double = 5
        Dim num2 As Double = 15
        MsgBox("Nummer 1 gedeelt door nummer 2 is: " & BerekenNum(num1, num2))

        Dim txt1 As String = "Ugur"
        Dim txt2 As String = "PyjamaPrince"
        MsgBox(NaamEnIGN(txt1, txt2))
    End Sub

    Public Function BerekenNum(num1 As Double, num2 As Double)
        Return Math.Round(num1 / num2, 2)
    End Function

    Public Function NaamEnIGN(txt1 As String, txt2 As String)
        Return "Je naam is " & txt1 & " en je IGN is " & txt2
    End Function
End Class
