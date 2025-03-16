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
        btn2dArray = New Button()
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
        ' btn2dArray
        ' 
        btn2dArray.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn2dArray.Location = New Point(251, 125)
        btn2dArray.Name = "btn2dArray"
        btn2dArray.Size = New Size(345, 177)
        btn2dArray.TabIndex = 31
        btn2dArray.Text = "2D Array"
        btn2dArray.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(871, 465)
        Controls.Add(btn2dArray)
        Controls.Add(Label13)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label13 As Label
    Friend WithEvents btn2dArray As Button

End Class
