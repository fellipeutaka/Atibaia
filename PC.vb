Public Class PC
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        MsgBox("You spend some hours playing games", 0, "Atibaia")
    End Sub

    Private Sub CodeButton_Click(sender As Object, e As EventArgs) Handles CodeButton.Click
        If Energy = 1 Then
            Energy = 0
        Else
            Energy -= 2
        End If
        Hunger += 1
        Thirst += 1
        Intelligence += 1
        MsgBox("You start to code a little, but spend a lot of time, because you like to code a lot", 0, "Atibaia")
    End Sub

    Private Sub WorkButton_Click(sender As Object, e As EventArgs) Handles WorkButton.Click
        If Energy = 1 Then
            Energy = 0
        Else
            Energy -= 2
        End If
        Hunger += 1
        Thirst += 1
        Intelligence += 1
        Money += 4
        MsgBox("You work a little bit and make some money :)", 0, "Atibaia")
    End Sub

    Private Sub StudyButton_Click(sender As Object, e As EventArgs) Handles StudyButton.Click
        If Energy = 1 Then
            Energy = 0
        Else
            Energy -= 2
        End If
        Hunger += 1
        Thirst += 1
        Intelligence += 2
        MsgBox("You keep studying a lot, just like any other day", 0, "Atibaia")
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Close()
    End Sub
End Class