Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim decPrice As Decimal = 5
        Dim iQuantity As Integer = 10
        Dim decDiscount As Decimal = 2
        Dim decPostage As Decimal = 3
        Dim decTotalCost As Decimal


        decTotalCost = ((decPrice - decDiscount) * iQuantity) + decTotalCost
        MessageBox.Show(decTotalCost)

    End Sub
End Class
