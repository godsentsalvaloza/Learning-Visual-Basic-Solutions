Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry = "Australia" Then
            MessageBox.Show("G' day, mate!")
        ElseIf stCountry = "Germany" Then
            MessageBox.Show("Hallo, guten tag!")
        Else
            MessageBox.Show("Hello, There!")
        End If
    End Sub
End Class
