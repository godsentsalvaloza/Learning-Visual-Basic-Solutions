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
        Label13 = New Label()
        btnRowIterate = New Button()
        btnColIterate = New Button()
        btnAllAtOnce = New Button()
        btnSearch = New Button()
        SuspendLayout()
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(295, 475)
        Label13.Name = "Label13"
        Label13.Size = New Size(502, 15)
        Label13.TabIndex = 30
        Label13.Text = "Replase each item in the array with a new value that is twice as big then output the new values"
        ' 
        ' btnRowIterate
        ' 
        btnRowIterate.Location = New Point(190, 19)
        btnRowIterate.Name = "btnRowIterate"
        btnRowIterate.Size = New Size(197, 102)
        btnRowIterate.TabIndex = 31
        btnRowIterate.Text = "Display items row wise"
        btnRowIterate.UseVisualStyleBackColor = True
        ' 
        ' btnColIterate
        ' 
        btnColIterate.Location = New Point(190, 127)
        btnColIterate.Name = "btnColIterate"
        btnColIterate.Size = New Size(197, 102)
        btnColIterate.TabIndex = 32
        btnColIterate.Text = "Display items column wise"
        btnColIterate.UseVisualStyleBackColor = True
        ' 
        ' btnAllAtOnce
        ' 
        btnAllAtOnce.Location = New Point(190, 235)
        btnAllAtOnce.Name = "btnAllAtOnce"
        btnAllAtOnce.Size = New Size(197, 102)
        btnAllAtOnce.TabIndex = 33
        btnAllAtOnce.Text = "Display all data items all at once"
        btnAllAtOnce.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(190, 343)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(197, 102)
        btnSearch.TabIndex = 34
        btnSearch.Text = "Search for a person"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(577, 465)
        Controls.Add(btnSearch)
        Controls.Add(btnAllAtOnce)
        Controls.Add(btnColIterate)
        Controls.Add(btnRowIterate)
        Controls.Add(Label13)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents btnRowIterate As Button
    Friend WithEvents btnColIterate As Button
    Friend WithEvents btnAllAtOnce As Button
    Friend WithEvents btnSearch As Button

End Class
