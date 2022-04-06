<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.WaterButton = New System.Windows.Forms.Button()
        Me.EatButton = New System.Windows.Forms.Button()
        Me.RestButton = New System.Windows.Forms.Button()
        Me.PCButton = New System.Windows.Forms.Button()
        Me.MapButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WaterButton
        '
        Me.WaterButton.Location = New System.Drawing.Point(12, 12)
        Me.WaterButton.Name = "WaterButton"
        Me.WaterButton.Size = New System.Drawing.Size(191, 65)
        Me.WaterButton.TabIndex = 1
        Me.WaterButton.Text = "Drink water"
        Me.WaterButton.UseVisualStyleBackColor = True
        '
        'EatButton
        '
        Me.EatButton.Location = New System.Drawing.Point(12, 117)
        Me.EatButton.Name = "EatButton"
        Me.EatButton.Size = New System.Drawing.Size(191, 65)
        Me.EatButton.TabIndex = 2
        Me.EatButton.Text = "Eat food from the fridge"
        Me.EatButton.UseVisualStyleBackColor = True
        '
        'RestButton
        '
        Me.RestButton.Location = New System.Drawing.Point(239, 12)
        Me.RestButton.Name = "RestButton"
        Me.RestButton.Size = New System.Drawing.Size(191, 65)
        Me.RestButton.TabIndex = 3
        Me.RestButton.Text = "Rest"
        Me.RestButton.UseVisualStyleBackColor = True
        '
        'PCButton
        '
        Me.PCButton.Location = New System.Drawing.Point(239, 117)
        Me.PCButton.Name = "PCButton"
        Me.PCButton.Size = New System.Drawing.Size(191, 65)
        Me.PCButton.TabIndex = 4
        Me.PCButton.Text = "PC"
        Me.PCButton.UseVisualStyleBackColor = True
        '
        'MapButton
        '
        Me.MapButton.Location = New System.Drawing.Point(359, 313)
        Me.MapButton.Name = "MapButton"
        Me.MapButton.Size = New System.Drawing.Size(191, 65)
        Me.MapButton.TabIndex = 5
        Me.MapButton.Text = "Back to map"
        Me.MapButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 390)
        Me.Controls.Add(Me.MapButton)
        Me.Controls.Add(Me.PCButton)
        Me.Controls.Add(Me.RestButton)
        Me.Controls.Add(Me.EatButton)
        Me.Controls.Add(Me.WaterButton)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WaterButton As Button
    Friend WithEvents EatButton As Button
    Friend WithEvents RestButton As Button
    Friend WithEvents PCButton As Button
    Friend WithEvents MapButton As Button
End Class
