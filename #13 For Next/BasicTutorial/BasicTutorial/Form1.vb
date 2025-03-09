Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim iCount As Integer


        For iCount = 0 To 50 Step 5
            MsgBox(iCount)
        Next

        'For iCount = 1 To 5
        '    Beep()
        '    Threading.Thread.Sleep(3000)
        'Next

        'For iCount = 1 To 5
        '    MsgBox($"Hello {iCount}")
        'Next
    End Sub
End Class
