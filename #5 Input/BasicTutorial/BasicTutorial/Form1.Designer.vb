<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGo = New Button()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtHobby = New TextBox()
        lblHobby = New Label()
        lblResult = New Label()
        lstOccupation = New ListBox()
        lblOccupation = New Label()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(94, 157)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(114, 55)
        btnGo.TabIndex = 0
        btnGo.Text = "Go"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(105, 36)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(345, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(35, 44)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(64, 15)
        lblFirstName.TabIndex = 2
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(105, 79)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(345, 23)
        txtLastName.TabIndex = 3
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(35, 87)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(63, 15)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        ' 
        ' txtHobby
        ' 
        txtHobby.Location = New Point(105, 115)
        txtHobby.Name = "txtHobby"
        txtHobby.Size = New Size(345, 23)
        txtHobby.TabIndex = 5
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Location = New Point(35, 123)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(43, 15)
        lblHobby.TabIndex = 6
        lblHobby.Text = "Hobby"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(286, 157)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 15)
        lblResult.TabIndex = 7
        ' 
        ' lstOccupation
        ' 
        lstOccupation.FormattingEnabled = True
        lstOccupation.ItemHeight = 15
        lstOccupation.Items.AddRange(New Object() {"Doctor", "Engineer", "Lawyer", "Teacher", "Student", "Taylor", "Officer", "Agent", "N / A"})
        lstOccupation.Location = New Point(492, 36)
        lstOccupation.Name = "lstOccupation"
        lstOccupation.Size = New Size(141, 109)
        lstOccupation.TabIndex = 8
        ' 
        ' lblOccupation
        ' 
        lblOccupation.AutoSize = True
        lblOccupation.Location = New Point(492, 18)
        lblOccupation.Name = "lblOccupation"
        lblOccupation.Size = New Size(69, 15)
        lblOccupation.TabIndex = 9
        lblOccupation.Text = "Occupation"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(658, 224)
        Controls.Add(lblOccupation)
        Controls.Add(lstOccupation)
        Controls.Add(lblResult)
        Controls.Add(lblHobby)
        Controls.Add(txtHobby)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        Controls.Add(btnGo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtHobby As TextBox
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents lblOccupation As Label

End Class
