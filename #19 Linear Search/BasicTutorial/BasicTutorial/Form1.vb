Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnLinearSearch_Click(sender As Object, e As EventArgs) Handles btnLinearSearch.Click
        Dim sTarget As String

        Dim iaFruits(9) As String
        iaFruits(0) = "Apple"
        iaFruits(1) = "Mango"
        iaFruits(2) = "Orange"
        iaFruits(3) = "Apple"
        iaFruits(4) = "Pineapple"
        iaFruits(5) = "Watermelon"
        iaFruits(6) = "Guava"
        iaFruits(7) = "Strawberry"
        iaFruits(8) = "Banana"
        iaFruits(9) = "Tomato"

        sTarget = InputBox("What are you looking for?")

        For iIndex As Integer = 0 To iaFruits.Length - 1 Step 1

            If UCase(sTarget) = UCase(iaFruits(iIndex)) Then
                MessageBox.Show("Entry Found!")
                Exit Sub
            End If
        Next

        MessageBox.Show("ERROR: No Entries Found")


    End Sub
End Class
