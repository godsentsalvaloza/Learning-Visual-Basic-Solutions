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
        lblTemperature = New Label()
        txtTemperature = New TextBox()
        btnTemperature = New Button()
        SuspendLayout()
        ' 
        ' lblTemperature
        ' 
        lblTemperature.AutoSize = True
        lblTemperature.Location = New Point(116, 88)
        lblTemperature.Name = "lblTemperature"
        lblTemperature.Size = New Size(74, 15)
        lblTemperature.TabIndex = 0
        lblTemperature.Text = "Temperature"
        ' 
        ' txtTemperature
        ' 
        txtTemperature.Location = New Point(196, 85)
        txtTemperature.Name = "txtTemperature"
        txtTemperature.Size = New Size(167, 23)
        txtTemperature.TabIndex = 1
        ' 
        ' btnTemperature
        ' 
        btnTemperature.Location = New Point(191, 127)
        btnTemperature.Name = "btnTemperature"
        btnTemperature.Size = New Size(96, 50)
        btnTemperature.TabIndex = 2
        btnTemperature.Text = "Check Temperature"
        btnTemperature.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 264)
        Controls.Add(btnTemperature)
        Controls.Add(txtTemperature)
        Controls.Add(lblTemperature)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTemperature As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents btnTemperature As Button

End Class
