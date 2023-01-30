Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Show()
        Dim number As Integer = TextBox1.Text
        Dim duizendtal As Integer = (number \ 1000) Mod 10
        Dim honderdtal As Integer = (number \ 100) Mod 10
        Dim tiental As Integer = (number \ 10) Mod 10
        Dim eenheid As Integer = number Mod 10

        Label3.Text = "Dit getal heeft: " & Environment.NewLine & duizendtal &
            " duizendtallen" & Environment.NewLine & honderdtal & " honderdtallen" &
            Environment.NewLine & tiental & " tientallen" & Environment.NewLine &
            eenheid & " eenheden"
    End Sub
End Class
