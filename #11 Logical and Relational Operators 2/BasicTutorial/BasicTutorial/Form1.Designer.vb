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
        lblExamScore = New Label()
        txtExamScore = New TextBox()
        btnGetGrade = New Button()
        SuspendLayout()
        ' 
        ' lblExamScore
        ' 
        lblExamScore.AutoSize = True
        lblExamScore.Location = New Point(123, 84)
        lblExamScore.Name = "lblExamScore"
        lblExamScore.Size = New Size(97, 15)
        lblExamScore.TabIndex = 0
        lblExamScore.Text = "Enter Exam Score"
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(226, 81)
        txtExamScore.MaxLength = 3
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(44, 23)
        txtExamScore.TabIndex = 1
        ' 
        ' btnGetGrade
        ' 
        btnGetGrade.Location = New Point(182, 131)
        btnGetGrade.Name = "btnGetGrade"
        btnGetGrade.Size = New Size(97, 61)
        btnGetGrade.TabIndex = 2
        btnGetGrade.Text = "Get Grade"
        btnGetGrade.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 264)
        Controls.Add(btnGetGrade)
        Controls.Add(txtExamScore)
        Controls.Add(lblExamScore)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents btnGetGrade As Button

End Class
