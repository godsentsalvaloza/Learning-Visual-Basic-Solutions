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
        txtCountry = New TextBox()
        lblCountry = New Label()
        btnGreet = New Button()
        SuspendLayout()
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(273, 70)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(93, 23)
        txtCountry.TabIndex = 0
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(112, 73)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(155, 15)
        lblCountry.TabIndex = 1
        lblCountry.Text = "What country are you from?"
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(194, 114)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(90, 37)
        btnGreet.TabIndex = 2
        btnGreet.Text = "Greet"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 264)
        Controls.Add(btnGreet)
        Controls.Add(lblCountry)
        Controls.Add(txtCountry)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents btnGreet As Button

End Class
