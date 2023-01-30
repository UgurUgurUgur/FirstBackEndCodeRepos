Imports System.ComponentModel
Imports System.Reflection.Metadata
Imports System.Runtime.Intrinsics

Public Class Form1
    Public transacties(1) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.ForeColor() = Color.Red
        Label1.Hide()
        'Dim zichtsaldo As String
        'zichtsaldo = CDbl(Label5.Text)
        'zichtsaldo = TextBox4.Text
        'Dim spaarsaldo As String
        'spaarsaldo = CDbl(Label7.Text)
        'spaarsaldo = TextBox5.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim zichtrekening As Double
        zichtrekening = CDbl(TextBox4.Text)
        Math.Round(zichtrekening, 2)
        If zichtrekening < -250 Then
            Label1.Show()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim zichtrekening As Double
        zichtrekening = CDbl(TextBox4.Text)
        Dim geldStorten = InputBox("Hoeveel geld wil je op je zichtrekening zetten?")
        If IsNumeric(geldStorten) = False Then
            MsgBox("Enkel een cijfer ingeven aub")
        Else
            MsgBox("Er staat nu totaal " & geldStorten + zichtrekening & " " & ComboBox2.Text & " op je rekening.")
            Dim a = "Er staat nu totaal " & geldStorten + zichtrekening & " " & ComboBox2.Text & " op je rekening."
            transacties(transacties.Length - 1) = a
            Array.Resize(transacties, transacties.Length + 1)

        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim spaar As Double
        Dim zicht As Double
        spaar = CDbl(TextBox5.Text)
        zicht = CDbl(TextBox4.Text)
        Dim spaarToZicht = InputBox("Hoeveel geld wil je van je spaarrekening naar je zichtrekening overzetten?")
        Dim b = MsgBox("Er staat nu " & spaarToZicht + zicht & " " & ComboBox2.Text & " op je zicht rekening.")
        transacties(transacties.Length - 1) = b
        Array.Resize(transacties, transacties.Length + 1)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        'Dim zichtSaldo As String
        'zichtSaldo = CDbl(Label5.Text)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        'Dim spaarSaldo As String
        'spaarSaldo = CDbl(Label7.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim spaar As Double
        Dim zicht As Double
        spaar = CDbl(TextBox5.Text)
        zicht = CDbl(TextBox4.Text)
        Dim zichtToSpaar = InputBox("Hoeveel geld wil je van je zichtrekening naar je spaarrekening overzetten?")
        Dim c = MsgBox("Er staat nu " & zichtToSpaar + spaar & " " & ComboBox2.Text & " op je zicht rekening.")
        transacties(transacties.Length - 1) = c
        Array.Resize(transacties, transacties.Length + 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim saldoZicht As Double
        saldoZicht = CDbl(TextBox4.Text)
        Dim saldoSpaar As Double
        saldoSpaar = CDbl(TextBox5.Text)
        Dim valuta As String
        valuta = ComboBox2.Text
        Dim newValuta = InputBox("Welk valuta wilt u naar veranderen? (Dollar(USD)-Canadian Dollar(CAD)-Australian Dollar(AUD)-Euro(EUR)")
        If valuta = "Euro(EUR)" And newValuta = "Dollar(USD)" Then
            MsgBox(EuroToUSD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Euro(EUR)" And newValuta = "Canadian Dollar(CAD)" Then
            MsgBox(EuroToCAD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Euro(EUR)" And newValuta = "Australian Dollar(AUD)" Then
            MsgBox(EuroToAUD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Dollar(USD)" And newValuta = "Euro(EUR)" Then
            MsgBox(DollarToEUR(saldoSpaar, saldoZicht))
        ElseIf valuta = "Dollar(USD)" And newValuta = "Canadian Dollar(CAD)" Then
            MsgBox(DollarToCAD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Dollar(USD)" And newValuta = "Australian Dollar(AUD)" Then
            MsgBox(DollarToAUD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Canadian Dollar (CAD)" And newValuta = "Euro(EUR)" Then
            MsgBox(CADToEUR(saldoSpaar, saldoZicht))
        ElseIf valuta = "Canadian Dollar (CAD)" And newValuta = "Dollar(USD)" Then
            MsgBox(CADToUSD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Canadian Dollar (CAD)" And newValuta = "Australian Dollar(AUD)" Then
            MsgBox(CADToAUD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Australian Dollar(AUD)" And newValuta = "Euro(EUR)" Then
            MsgBox(AUDToEUR(saldoSpaar, saldoZicht))
        ElseIf valuta = "Australian Dollar(AUD)" And newValuta = "Dollar(USD)" Then
            MsgBox(AUDToUSD(saldoSpaar, saldoZicht))
        ElseIf valuta = "Australian Dollar(AUD)" And newValuta = "Canadian Dollar(CAD)" Then
            MsgBox(AUDToCAD(saldoSpaar, saldoZicht))
        Else
            MsgBox("Je hebt deze al als valuta of je koos geen van de opties!")
        End If
    End Sub

    Private Function EuroToUSD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.086555
        saldoSpaar = saldoSpaar * 1.086555
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function

    Private Function EuroToCAD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.45
        saldoSpaar = saldoSpaar * 1.45
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function EuroToAUD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.54
        saldoSpaar = saldoSpaar * 1.54
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function DollarToEUR(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.086555
        saldoSpaar = saldoSpaar * 0.086555
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function DollarToCAD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.33
        saldoSpaar = saldoSpaar * 1.33
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function DollarToAUD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.41
        saldoSpaar = saldoSpaar * 1.41
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function CADToEUR(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.69
        saldoSpaar = saldoSpaar * 0.69
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function CADToUSD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.75
        saldoSpaar = saldoSpaar * 0.75
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function CADToAUD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 1.06
        saldoSpaar = saldoSpaar * 1.06
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function AUDToEUR(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.65
        saldoSpaar = saldoSpaar * 0.65
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function AUDToUSD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.71
        saldoSpaar = saldoSpaar * 0.71
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function
    Private Function AUDToCAD(saldoZicht, saldoSpaar)
        saldoZicht = saldoZicht * 0.94
        saldoSpaar = saldoSpaar * 0.94
        Return Math.Round(saldoSpaar, 2) & " " & Math.Round(saldoZicht, 2)
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'MessageBox.Show(transacties(0), transacties(1)) ', transacties(2))
    End Sub
End Class
