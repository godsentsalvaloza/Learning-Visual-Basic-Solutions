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
End Class
