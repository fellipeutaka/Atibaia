Public Class Stats
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Hello there! Welcome to my first game. This game is an attempt to simulate my new routine here in Atibaia, a city in São Paulo, Brazil. I hope you like it, thank you <3", "Atibaia")
        MessageBox.Show("Developed by Fellipe Utaka.", "Atibaia")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Map.Show()
    End Sub

    Private Sub StatusTimer_Tick(sender As Object, e As EventArgs) Handles StatusTimer.Tick
        EnergyBar.Value = Energy
        HungerBar.Value = Hunger
        ThirstBar.Value = Thirst
        StrengthLabel.Text = Strength & " / 20"
        IntelligenceLabel.Text = Intelligence & " / 20"
        MoneyLabel.Text = "R$ " & String.Format("{0:n}", Money)
    End Sub

    Private Sub DeathTimer_Tick(sender As Object, e As EventArgs) Handles DeathTimer.Tick
        If Energy = 0 Then
            DeathTimer.Stop()
            MsgBox("You died", 0, "Atibaia")
            Me.Close()
        ElseIf Hunger = 10 Then
            DeathTimer.Stop()
            MsgBox("You died", 0, "Atibaia")
            Me.Close()
        ElseIf Thirst = 10 Then
            DeathTimer.Stop()
            MsgBox("You died", 0, "Atibaia")
            Me.Close()
        End If
    End Sub
End Class
