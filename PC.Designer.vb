<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.CodeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(12, 12)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(191, 65)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Play Games"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'CodeButton
        '
        Me.CodeButton.Location = New System.Drawing.Point(273, 12)
        Me.CodeButton.Name = "CodeButton"
        Me.CodeButton.Size = New System.Drawing.Size(191, 65)
        Me.CodeButton.TabIndex = 3
        Me.CodeButton.Text = "Code"
        Me.CodeButton.UseVisualStyleBackColor = True
        '
        'PC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CodeButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Name = "PC"
        Me.Text = "PC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayButton As Button
    Friend WithEvents CodeButton As Button
End Class
