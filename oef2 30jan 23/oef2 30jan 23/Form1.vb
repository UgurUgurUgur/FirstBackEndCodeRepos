Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.ForeColor = Color.Red
        Label6.ForeColor = Color.Red
        Label8.ForeColor = Color.Red
        Label5.Hide()
        Label2.Hide()
        Label7.Hide()
        TextBox2.Hide()
        Label6.Hide()
        Label3.Hide()
        Label9.Hide()
        TextBox3.Hide()
        Label8.Hide()
        Button2.Hide()
        Button3.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text.ToLower()
        Dim input1 As String
        input1 = CDbl(Val(TextBox1.Text))
        Do While input1 <> "ja" Or input1 <> "nee"
            Label5.Show()
            TextBox1.Clear()
        Loop
        Label5.Hide()
        If input1 = "ja" Then
            Label2.Show()
            Label9.Show()
            TextBox2.Show()
        Else
            MsgBox("Je begint met looptraining. Succes!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text.ToLower()
        Dim input2 As String
        input2 = CDbl(Val(TextBox1.Text))
        If input2 <> "ja" Or TextBox1.Text <> "nee" Then
            Label3.Show()
            TextBox1.Clear()
        ElseIf input2 = "ja" Then
            Label2.Show()
            Label7.Show()
            TextBox3.Show()
        Else
            MsgBox("Je begint met Krachttraining. Succes!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text.ToLower()
        Dim input2 As String
        input2 = CDbl(Val(TextBox1.Text))
        If input2 <> "ja" Or TextBox1.Text <> "nee" Then
            Label5.Show()
            TextBox1.Clear()
        ElseIf input2 = "ja" Then
            Label2.Show()
            Label7.Show()
            TextBox2.Show()
        Else
            MsgBox("Je begint met versprinten. Succes!")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


End Class
