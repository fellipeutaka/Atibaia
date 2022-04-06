Public Class PC
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        MsgBox("You spend some hours playing games", 0, "Atibaia")
    End Sub

    Private Sub CodeButton_Click(sender As Object, e As EventArgs) Handles CodeButton.Click
        Energy -= 2
        Hunger += 1
        Thirst += 1
        Intelligence += 1
        MsgBox("You start to code a little, but spend a lot of time, because you like to code a lot", 0, "Atibaia")
    End Sub
End Class