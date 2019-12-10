Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Location = New Point(PictureBox1.Location.X + 340, PictureBox1.Location.Y)
        Timer1.Enabled = False
    End Sub
End Class