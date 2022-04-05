<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EnergyBar = New System.Windows.Forms.ProgressBar()
        Me.HungerBar = New System.Windows.Forms.ProgressBar()
        Me.ThirstBar = New System.Windows.Forms.ProgressBar()
        Me.MoneyLabel = New System.Windows.Forms.Label()
        Me.IntelligenceLabel = New System.Windows.Forms.Label()
        Me.StrengthLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.StatusTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Me"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Energy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hunger"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Thirst"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Strength"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Money"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Intelligence"
        '
        'EnergyBar
        '
        Me.EnergyBar.Location = New System.Drawing.Point(98, 56)
        Me.EnergyBar.Maximum = 10
        Me.EnergyBar.Name = "EnergyBar"
        Me.EnergyBar.Size = New System.Drawing.Size(100, 15)
        Me.EnergyBar.TabIndex = 7
        Me.EnergyBar.Value = 10
        '
        'HungerBar
        '
        Me.HungerBar.Location = New System.Drawing.Point(98, 86)
        Me.HungerBar.Maximum = 10
        Me.HungerBar.Name = "HungerBar"
        Me.HungerBar.Size = New System.Drawing.Size(100, 15)
        Me.HungerBar.TabIndex = 8
        '
        'ThirstBar
        '
        Me.ThirstBar.Location = New System.Drawing.Point(98, 116)
        Me.ThirstBar.Maximum = 10
        Me.ThirstBar.Name = "ThirstBar"
        Me.ThirstBar.Size = New System.Drawing.Size(100, 15)
        Me.ThirstBar.TabIndex = 9
        '
        'MoneyLabel
        '
        Me.MoneyLabel.AutoSize = True
        Me.MoneyLabel.Location = New System.Drawing.Point(98, 206)
        Me.MoneyLabel.Name = "MoneyLabel"
        Me.MoneyLabel.Size = New System.Drawing.Size(44, 15)
        Me.MoneyLabel.TabIndex = 13
        Me.MoneyLabel.Text = "R$ 0.00"
        '
        'IntelligenceLabel
        '
        Me.IntelligenceLabel.AutoSize = True
        Me.IntelligenceLabel.Location = New System.Drawing.Point(98, 176)
        Me.IntelligenceLabel.Name = "IntelligenceLabel"
        Me.IntelligenceLabel.Size = New System.Drawing.Size(36, 15)
        Me.IntelligenceLabel.TabIndex = 14
        Me.IntelligenceLabel.Text = "0 / 20"
        '
        'StrengthLabel
        '
        Me.StrengthLabel.AutoSize = True
        Me.StrengthLabel.Location = New System.Drawing.Point(98, 146)
        Me.StrengthLabel.Name = "StrengthLabel"
        Me.StrengthLabel.Size = New System.Drawing.Size(36, 15)
        Me.StrengthLabel.TabIndex = 15
        Me.StrengthLabel.Text = "0 / 20"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Atibaia.My.Resources.Resources._me
        Me.PictureBox1.Location = New System.Drawing.Point(474, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 48)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(11, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 32)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Your stats:"
        '
        'StatusTimer
        '
        Me.StatusTimer.Enabled = True
        Me.StatusTimer.Interval = 1
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 342)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StrengthLabel)
        Me.Controls.Add(Me.IntelligenceLabel)
        Me.Controls.Add(Me.MoneyLabel)
        Me.Controls.Add(Me.ThirstBar)
        Me.Controls.Add(Me.HungerBar)
        Me.Controls.Add(Me.EnergyBar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Stats"
        Me.Text = "Atibaia"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents EnergyBar As ProgressBar
    Friend WithEvents HungerBar As ProgressBar
    Friend WithEvents ThirstBar As ProgressBar
    Friend WithEvents MoneyLabel As Label
    Friend WithEvents IntelligenceLabel As Label
    Friend WithEvents StrengthLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents StatusTimer As Timer
End Class
