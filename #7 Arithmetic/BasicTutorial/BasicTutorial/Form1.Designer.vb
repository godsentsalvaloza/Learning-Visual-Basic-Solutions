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
        txtNumber1 = New TextBox()
        txtNumber2 = New TextBox()
        lblNumber1 = New Label()
        lblNumber2 = New Label()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' txtNumber1
        ' 
        txtNumber1.Location = New Point(175, 52)
        txtNumber1.Name = "txtNumber1"
        txtNumber1.Size = New Size(205, 23)
        txtNumber1.TabIndex = 0
        ' 
        ' txtNumber2
        ' 
        txtNumber2.Location = New Point(175, 93)
        txtNumber2.Name = "txtNumber2"
        txtNumber2.Size = New Size(205, 23)
        txtNumber2.TabIndex = 1
        ' 
        ' lblNumber1
        ' 
        lblNumber1.AutoSize = True
        lblNumber1.Location = New Point(109, 55)
        lblNumber1.Name = "lblNumber1"
        lblNumber1.Size = New Size(60, 15)
        lblNumber1.TabIndex = 2
        lblNumber1.Text = "Number 1"
        ' 
        ' lblNumber2
        ' 
        lblNumber2.AutoSize = True
        lblNumber2.Location = New Point(109, 101)
        lblNumber2.Name = "lblNumber2"
        lblNumber2.Size = New Size(60, 15)
        lblNumber2.TabIndex = 3
        lblNumber2.Text = "Number 2"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(187, 142)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(104, 46)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 264)
        Controls.Add(btnCalculate)
        Controls.Add(lblNumber2)
        Controls.Add(lblNumber1)
        Controls.Add(txtNumber2)
        Controls.Add(txtNumber1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblNumber2 As Label
    Friend WithEvents btnCalculate As Button

End Class
