Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uren As Double
        uren = CDbl(Val(TextBox1.Text))
        Dim loon As Double
        loon = CDbl(Val(TextBox2.Text))
        Dim weekLoon As Double = uren * loon
        Dim maandLoon As Double = weekLoon * 4
        Dim jaarLoon As Double = weekLoon * 52
        MsgBox("Je weekloon is: " & weekLoon & vbCrLf & "Je maandloon is: " & maandLoon & vbCrLf & "Je jaarloon is: " & jaarLoon)
    End Sub
End Class
