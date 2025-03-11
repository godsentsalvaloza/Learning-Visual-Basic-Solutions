Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim iCount As Integer
        Do While iCount < 5
            iCount = iCount + 1
            MessageBox.Show($"Hello {iCount}")
        Loop
        MessageBox.Show("Done!")

    End Sub
End Class
