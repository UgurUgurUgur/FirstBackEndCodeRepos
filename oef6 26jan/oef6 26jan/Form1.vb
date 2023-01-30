Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        Label3.Font = New Font(Label1.Font, FontStyle.Bold)
        Label5.Font = New Font(Label1.Font, FontStyle.Bold)
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
        Dim overUren As Double
        overUren = CDbl(Val(TextBox3.Text))
        Dim overUrenLoon As Double
        overUrenLoon = (loon * overUren) / 2 * 3
        Dim weekLoon As Double = uren * loon + overUrenLoon
        Dim maandLoon As Double = weekLoon * 4 + overUrenLoon
        Dim jaarLoon As Double = weekLoon * 52 + overUrenLoon
        MsgBox("Je weekloon is: " & weekLoon & vbCrLf & "Je maandloon is: " & maandLoon & vbCrLf & "Je jaarloon is: " & jaarLoon)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
    End Sub
End Class
