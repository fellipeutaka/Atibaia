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
        Me.WorkButton = New System.Windows.Forms.Button()
        Me.StudyButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
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
        'WorkButton
        '
        Me.WorkButton.Location = New System.Drawing.Point(12, 122)
        Me.WorkButton.Name = "WorkButton"
        Me.WorkButton.Size = New System.Drawing.Size(191, 65)
        Me.WorkButton.TabIndex = 4
        Me.WorkButton.Text = "Work"
        Me.WorkButton.UseVisualStyleBackColor = True
        '
        'StudyButton
        '
        Me.StudyButton.Location = New System.Drawing.Point(273, 122)
        Me.StudyButton.Name = "StudyButton"
        Me.StudyButton.Size = New System.Drawing.Size(191, 65)
        Me.StudyButton.TabIndex = 5
        Me.StudyButton.Text = "Study"
        Me.StudyButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(357, 289)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(191, 65)
        Me.HomeButton.TabIndex = 6
        Me.HomeButton.Text = "Back to home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'PC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 366)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.StudyButton)
        Me.Controls.Add(Me.WorkButton)
        Me.Controls.Add(Me.CodeButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Name = "PC"
        Me.Text = "PC"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayButton As Button
    Friend WithEvents CodeButton As Button
    Friend WithEvents WorkButton As Button
    Friend WithEvents StudyButton As Button
    Friend WithEvents HomeButton As Button
End Class
