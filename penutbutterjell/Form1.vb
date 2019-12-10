Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = New Point(Me.Location.X + 5, Me.Location.Y)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Location.X = 2000 Then
            Me.Location = New Point(Me.Location.X - 2220, Me.Location.Y)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.o_h__g_o_d__n_o, AudioPlayMode.Background)
        Form11.Show()
        Form3.Show()
        Form3.TopMost = True
        Form2.Show()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer1.Enabled = True
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        My.Computer.Audio.Play(My.Resources.o_h__g_o_d__n_o, AudioPlayMode.Background)
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Bruh.Show()
        Timer6.Enabled = True
        Timer5.Enabled = False
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Form6.Show()
        Timer7.Enabled = True
        Timer6.Enabled = False
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Form7.Show()
        Timer8.Enabled = True
        Timer7.Enabled = False
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Form8.Show()
        Timer9.Enabled = True
        Timer8.Enabled = False
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Form9.Show()
        Timer10.Enabled = True
        Timer9.Enabled = False
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        Form10.Show()
        Timer11.Enabled = True
        Timer10.Enabled = False
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        Timer5.Enabled = True
        Timer11.Enabled = False
    End Sub
End Class
