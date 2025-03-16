Imports System.Windows.Forms.Design

Public Class Form1
    Dim aiData(4) As Integer
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        lblDescription1.Text = "begin each procedure with the following code " & Environment.NewLine & "to declare and initialize an array of integers"
    End Sub

    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click
        For i As Integer = 0 To aiData.Length() - 1 Step 1
            Beep()
            MessageBox.Show($"Value: {aiData(i)}")
        Next

    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click
        Dim sValue As String = ""
        For i As Integer = 0 To aiData.Length() - 1 Step 1
            sValue = sValue + $"Value: {aiData(i)}" & Environment.NewLine
        Next
        Beep()
        MessageBox.Show(sValue)
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click
        Dim iSum As Integer = 0
        For i As Integer = 0 To aiData.Length() - 1 Step 1
            iSum += aiData(i)
        Next

        Beep()
        MessageBox.Show($"Summation of values: {iSum}")
    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click
        Dim iResult As Integer = 0
        For i As Integer = 0 To aiData.Length() - 1 Step 1
            iResult += aiData(i)
        Next

        Beep()
        MessageBox.Show($"Average of values: {iResult / aiData.Length()}")
    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click
        Dim iResult As Integer = 0
        For i As Integer = 0 To aiData.Length() - 1 Step 1

            If aiData(i) > 20 Then
                iResult += aiData(i)
            End If

        Next

        Beep()
        MessageBox.Show($"Result of items greater than 20 : {iResult}")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iMaxValue As Integer = aiData.Max()
        Beep()
        MessageBox.Show($"Maximum value: {iMaxValue}")
    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click
        Dim iMinValue As Integer = aiData.Min()
        Beep()
        MessageBox.Show($"Maximum value: {iMinValue}")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sValue As String = ""
        For i As Integer = 0 To aiData.Length() - 1 Step 1
            sValue = sValue + $"Value: {aiData(i) * 2}" & Environment.NewLine
        Next
        Beep()
        MessageBox.Show(sValue)
    End Sub
End Class
