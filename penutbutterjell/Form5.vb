Public Class Bruh
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Form5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ProgressBar1.Value < 100 Then
            e.Cancel = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = (ProgressBar1.Value + 1)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            Label1.Text = "Finished."
        End If
    End Sub
End Class