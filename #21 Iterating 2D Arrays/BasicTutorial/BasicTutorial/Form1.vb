﻿Imports System.Windows.Forms.Design

Public Class Form1
    Dim astPeople(4, 5) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize array value
        astPeople(0, 0) = "Barak"
        astPeople(1, 0) = "Obama"
        astPeople(2, 0) = "Male"
        astPeople(3, 0) = "American"
        astPeople(4, 0) = "President"

        astPeople(0, 1) = "Jacide"
        astPeople(1, 1) = "Ardern"
        astPeople(2, 1) = "Female"
        astPeople(3, 1) = "New Zeland"
        astPeople(4, 1) = "Prime Minister"

        astPeople(0, 2) = "Ada"
        astPeople(1, 2) = "Lovelace"
        astPeople(2, 2) = "Female"
        astPeople(3, 2) = "British"
        astPeople(4, 2) = "Mathematician"

        astPeople(0, 3) = "Albern"
        astPeople(1, 3) = "Einstein"
        astPeople(2, 3) = "Male"
        astPeople(3, 3) = "Swiss"
        astPeople(4, 3) = "Scientist"

        astPeople(0, 4) = "Mahatma"
        astPeople(1, 4) = "Gandi"
        astPeople(2, 4) = "Male"
        astPeople(3, 4) = "Indian"
        astPeople(4, 4) = "Lawyer"

        astPeople(0, 5) = "Vincent"
        astPeople(1, 5) = "van Gogh"
        astPeople(2, 5) = "Male"
        astPeople(3, 5) = "Dutch"
        astPeople(4, 5) = "Artist"
    End Sub

    Private Sub btnRowIterate_Click(sender As Object, e As EventArgs) Handles btnRowIterate.Click
        For x As Integer = 0 To 5 Step 1
            For y As Integer = 0 To 4 Step 1
                MessageBox.Show(astPeople(y, x))
            Next
        Next
    End Sub

    Private Sub btnColIterate_Click(sender As Object, e As EventArgs) Handles btnColIterate.Click
        For x As Integer = 0 To 4 Step 1
            For y As Integer = 0 To 5 Step 1
                MessageBox.Show(astPeople(x, y))
            Next
        Next
    End Sub

    Private Sub btnAllAtOnce_Click(sender As Object, e As EventArgs) Handles btnAllAtOnce.Click
        Dim stResult As String = ""
        For x As Integer = 0 To 5 Step 1
            For y As Integer = 0 To 4 Step 1
                stResult += astPeople(y, x) & ", "
            Next
            stResult += Environment.NewLine
        Next

        MessageBox.Show(stResult)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stResult As String = InputBox("Enter Name")
        For x As Integer = 0 To 5 Step 1
            For y As Integer = 0 To 1 Step 1

                If astPeople(y, x).ToLower = stResult.ToLower Then
                    MessageBox.Show($"{stResult} found")
                    Exit Sub
                End If

            Next
        Next
        MessageBox.Show($"ERROR: {stResult} not found")
    End Sub
End Class
