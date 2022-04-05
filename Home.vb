Public Class Home
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Hello there! Welcome to my first game. This game is an attempt to simulate my new routine here in Atibaia, a city in São Paulo, Brazil. I hope you like it, thank you <3", "Atibaia")
        MessageBox.Show("Developed by Fellipe Utaka.", "Atibaia")
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Map As Map
        Map = New Map
        Map.Show()
    End Sub
End Class
