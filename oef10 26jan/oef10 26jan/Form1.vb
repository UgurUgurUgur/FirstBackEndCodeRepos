Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lengte As Double
        lengte = CDbl(Val(TextBox1.Text))
        Dim breedte As Double
        breedte = CDbl(Val(TextBox2.Text))
        Dim hoogte As Double
        hoogte = CDbl(Val(TextBox3.Text))
        Dim verfpotOppervlakte As Integer
        verfpotOppervlakte = CDbl(Val(TextBox5.Text))
        Dim verfPrijs As Double
        verfPrijs = CDbl(Val(TextBox4.Text))

        Dim oppervlakte As Double = (2 * lengte * hoogte) + (2 * breedte + hoogte)
        Dim pottenVerf As Double = oppervlakte / verfpotOppervlakte

        'Dim pottenVerfInt As Integer
        'pottenVerfInt = CInt(pottenVerf)

        Dim verfNodig As Double = Math.Ceiling(oppervlakte / verfpotOppervlakte)


        MsgBox("Aantal potten nodig: " & verfNodig & Environment.NewLine & "Prijs: " &
               Math.Round(verfPrijs * pottenVerf, 2) & " euro")
    End Sub
End Class
