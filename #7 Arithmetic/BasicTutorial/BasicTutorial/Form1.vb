Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iNumber1 As Integer = txtNumber1.Text
        Dim iNumber2 As Integer = txtNumber2.Text
        Dim dResult As Decimal

        dResult = iNumber1 + iNumber2
        MessageBox.Show($"Addition: {dResult}")

        dResult = iNumber1 - iNumber2
        MessageBox.Show($"Subtraction: {dResult}")

        dResult = iNumber1 * iNumber2
        MessageBox.Show($"Multiplication: {dResult}")

        dResult = iNumber1 / iNumber2
        MessageBox.Show($"Division: {dResult}")

        dResult = iNumber1 ^ iNumber2
        MessageBox.Show($"Exponent: {dResult}")

        dResult = iNumber1 Mod iNumber2
        MessageBox.Show($"Modulo: {dResult}")

        dResult = iNumber1 \ iNumber2
        MessageBox.Show($"Integer Division: {dResult}")

    End Sub
End Class
