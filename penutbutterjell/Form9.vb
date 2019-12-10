Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = New Point(Me.Location.X + 10, Me.Location.Y - 10)
        Timer2.Enabled = True
        Timer1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Location = New Point(Me.Location.X - 10, Me.Location.Y + 10)
        Timer3.Enabled = True
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Location = New Point(Me.Location.X + 10, Me.Location.Y)
        Timer4.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.Location = New Point(Me.Location.X - 10, Me.Location.Y - 10)
        Timer5.Enabled = True
        Timer4.Enabled = False
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        Timer6.Enabled = True
        Timer5.Enabled = False
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Me.Location = New Point(Me.Location.X + 10, Me.Location.Y - 10)
        Timer6.Enabled = False
        Timer7.Enabled = True
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 10)
        Timer8.Enabled = True
        Timer7.Enabled = False
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Me.Location = New Point(Me.Location.X + 10, Me.Location.Y - 10)
        Timer9.Enabled = True
        Timer8.Enabled = False
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Me.Location = New Point(Me.Location.X - 10, Me.Location.Y + 10)
        Timer1.Enabled = True
        Timer9.Enabled = False
    End Sub

    Private Sub Pictureframe1_Tick(sender As Object, e As EventArgs) Handles Pictureframe1.Tick
        PictureBox1.Image = My.Resources.Annoy1
        Pictureframe2.Enabled = True
        Pictureframe1.Enabled = False
    End Sub

    Private Sub Pictureframe2_Tick(sender As Object, e As EventArgs) Handles Pictureframe2.Tick
        PictureBox1.Image = My.Resources.Annoy2
        Pictureframe3.Enabled = True
        Pictureframe2.Enabled = False
    End Sub

    Private Sub Pictureframe3_Tick(sender As Object, e As EventArgs) Handles Pictureframe3.Tick
        PictureBox1.Image = My.Resources.Annoy3
        Pictureframe4.Enabled = True
        Pictureframe3.Enabled = False
    End Sub

    Private Sub Pictureframe4_Tick(sender As Object, e As EventArgs) Handles Pictureframe4.Tick
        PictureBox1.Image = My.Resources.Annoy4
        Pictureframe1.Enabled = True
        Pictureframe4.Enabled = False
    End Sub
End Class