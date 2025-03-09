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


        If iScore < 0 Or iScore > 100 Then
            MessageBox.Show("INVALID INPUT: Score must be between 0 and 100 ")
            Exit Sub
        ElseIf iScore >= 50 Then
            MessageBox.Show($"You Passed!")
        Else
            MessageBox.Show($"You Failed")
        End If

        'If iScore < 0 Or iScore > 100 Then
        '    MessageBox.Show("INVALID INPUT: Score must be between 0 and 100 ")
        '    Exit Sub
        'End If

        'If iScore >= 50 Then
        '    MessageBox.Show($"You Passed!")
        'Else
        '    MessageBox.Show($"You Failed")
        'End If

        MessageBox.Show("All Done")

    End Sub
End Class
