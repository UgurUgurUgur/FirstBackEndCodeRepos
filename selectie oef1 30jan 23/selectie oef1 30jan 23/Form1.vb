Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label3.Hide()
        Label4.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim minLength As Integer = 8
        Dim username As String
        username = CDbl(Val(TextBox1.Text))
        Dim password As String
        password = CDbl(Val(TextBox2.Text))
        Dim chars() As Char = TextBox2.Text

        ' use if not while !!!

        For Each c As Char In chars

            If IsNumeric(c) = False Then
                Label4.Show()
                TextBox2.SelectedText = ""
            End If
        Next
        While Len(password) < minLength
            Label3.Show()
            TextBox2.SelectedText = ""
        End While



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
