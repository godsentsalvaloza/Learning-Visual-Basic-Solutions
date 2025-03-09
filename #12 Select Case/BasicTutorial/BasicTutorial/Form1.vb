Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnTemperature_Click(sender As Object, e As EventArgs) Handles btnTemperature.Click
        Dim iTemperature As Integer
        iTemperature = CInt(txtTemperature.Text)

        Select Case iTemperature
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 0
                MsgBox("Sub Zero")
            Case 1 To 10
                MsgBox("Cold")
            Case Else
                MsgBox("Hot")
        End Select
    End Sub
End Class
