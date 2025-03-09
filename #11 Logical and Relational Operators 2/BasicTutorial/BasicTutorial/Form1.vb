Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnGetGrade_Click(sender As Object, e As EventArgs) Handles btnGetGrade.Click
        Dim iScore As Integer

        If IsNumeric(txtExamScore.Text) Then
            iScore = CInt(txtExamScore.Text)
        Else
            MessageBox.Show($"INVALID INPUT: The input must be a number")
            Exit Sub
        End If


        If Not (iScore >= 0 And iScore <= 100) Then
            MessageBox.Show("This is not a valid score. Only between 0 and 100 are allowed")
            Exit Sub
        ElseIf (iScore <= 20) Then
            MessageBox.Show("GRADE F")
        ElseIf (iScore > 20 And iScore <= 30) Then
            MessageBox.Show("GRADE E")
        ElseIf (iScore > 30 And iScore <= 40) Then
            MessageBox.Show("Grade D")
        ElseIf (iScore > 40 And iScore <= 50) Then
            MessageBox.Show("GRADE C")
        ElseIf (iScore > 50 And iScore <= 70) Then
            MessageBox.Show("GRADE B")
        Else
            MessageBox.Show("GRADE A")
        End If

        MessageBox.Show("All Done")

    End Sub
End Class
