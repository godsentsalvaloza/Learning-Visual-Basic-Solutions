Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MessageBox.Show("Welcome to VB.NET!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        Dim stFirstName As String
        Dim stLastName As String

        stLastName = "Malaguena"
        stFirstName = "Sentry"

        MessageBox.Show($"Hello, {stFirstName} {stLastName}")

        stLastName = "Creamy"
        stFirstName = "Crispy"

        MessageBox.Show($"Hello, {stFirstName} {stLastName}")
    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim strMake As String = "Mistubishi"
        Dim strModel As String = "Adventure"
        Dim iDoors As Integer = 5
        Dim strColor As String = "Red"
        Dim bTaxed As Boolean = False
        Dim iEngineSize As Integer = 1600
        Dim decPrice As Decimal = 1000000.99
        Dim dtDateRegistered As Date = #01/01/2025#

        MessageBox.Show("Car information:" & Environment.NewLine & Environment.NewLine & $"Make: {strMake}" & Environment.NewLine & $"Model: {strModel}" & Environment.NewLine & $"Doors: {iDoors}" & Environment.NewLine & $"Make: {strMake}" & Environment.NewLine & $"Color: {strColor}" & Environment.NewLine & $"Taxed: {bTaxed}" & Environment.NewLine & $"Engine: {iEngineSize}L" & Environment.NewLine & $"Price: {decPrice}" & Environment.NewLine & $"Date: {dtDateRegistered}")


    End Sub
End Class
