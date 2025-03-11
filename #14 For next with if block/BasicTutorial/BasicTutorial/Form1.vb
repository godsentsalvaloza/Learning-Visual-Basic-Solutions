Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim sMax As String
        Dim iMax As Integer
        Dim sOddOrEvern As String
        Dim x As Integer

        sMax = InputBox("Enter maximum number")

        If Not IsNumeric(sMax) Then
            MessageBox.Show("ERROR: Invalid Input")
            Exit Sub
        End If

        iMax = sMax

        sOddOrEvern = InputBox("Enter odd or even")

        sOddOrEvern = sOddOrEvern.ToLower()
        If sOddOrEvern = "even" Then
            For x = 2 To iMax Step 2
                MessageBox.Show($"{x}")
            Next
        ElseIf sOddOrEvern = "odd" Then
            For x = 1 To iMax Step 2
                MessageBox.Show($"{x}")
            Next
        Else
            MessageBox.Show("ERROR: INVALID INPUT")
        End If

    End Sub
End Class
