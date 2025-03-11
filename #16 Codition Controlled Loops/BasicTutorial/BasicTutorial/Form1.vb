Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim stName As String

        Do While True
            stName = InputBox("Enter name")
            If stName = "Sentry" Then
                Exit Do
            End If
        Loop

        Beep()
        MessageBox.Show($"Hello {stName}")


        'Do While stName <> "Kevin"
        '    stName = InputBox("Enter name")
        'Loop

        'Beep()
        'MessageBox.Show($"Hello {stName}")
    End Sub
End Class
