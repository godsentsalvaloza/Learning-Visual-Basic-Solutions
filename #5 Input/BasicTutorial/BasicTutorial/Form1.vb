Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Dim strFirstName As String
        'strFirstName = InputBox("Enter first Name")
        'MessageBox.Show($"Hello, {strFirstName}")

        Dim strFirstName As String
        Dim strLastName As String
        Dim strHobby As String
        Dim strOccupation As String

        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strHobby = txtHobby.Text
        strOccupation = lstOccupation.SelectedItem

        lblResult.Text = $"Hello, {strFirstName} {strLastName}" & Environment.NewLine & $"Hobby: {strHobby}" & Environment.NewLine & $"Occupation: {strOccupation}"


    End Sub


End Class
