Public Class Home
    Private Sub MapButton_Click(sender As Object, e As EventArgs) Handles MapButton.Click
        Map.Show()
        Me.Close()
    End Sub

    Private Sub WaterButton_Click(sender As Object, e As EventArgs) Handles WaterButton.Click
        If (Thirst > 0) Then
            Thirst -= 1
            MsgBox("You drink water in your home. Nothing happens.", 0, "Atibaia")
        Else
            MsgBox("You're not thirsty", 0, "Atibaia")
        End If
    End Sub

    Private Sub RestButton_Click(sender As Object, e As EventArgs) Handles RestButton.Click
        If (Energy < 10) Then
            Energy = 10
            MsgBox("You take a good rest.", 0, "Atibaia")
        Else
            MsgBox("You're not tired", 0, "Atibaia")
        End If
    End Sub

    Private Sub EatButton_Click(sender As Object, e As EventArgs) Handles EatButton.Click
        If (Hunger > 0) Then
            Hunger -= 1
            MsgBox("You eat rice with chicken and broccoli. Delicious!", 0, "Atibaia")
        Else
            MsgBox("You're not hungry", 0, "Atibaia")
        End If
    End Sub

    Private Sub PCButton_Click(sender As Object, e As EventArgs) Handles PCButton.Click
        PC.Show()
        Me.Close()
    End Sub
End Class