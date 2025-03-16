Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim asFruits(9) As String
        Dim iIndex As Integer
        asFruits(0) = "Banana"
        asFruits(1) = "Apple"
        asFruits(2) = "Pineapple"
        asFruits(3) = "Watermelon"
        asFruits(4) = "Strawberry"
        asFruits(5) = "Peach"
        asFruits(6) = "Mango"
        asFruits(7) = "Grapes"
        asFruits(8) = "Guava"
        asFruits(9) = "Lemon"

        For iIndex = 0 To (asFruits.Length() - 1) Step 1
            MessageBox.Show(asFruits(iIndex))
        Next

    End Sub
End Class
