Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("C:" & "\Thing.txt") Then
            Me.Close()
        Else
            System.IO.File.Create("C:" & "\Thing.txt").Dispose()
            My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).SetValue(Application.ProductName, Application.ExecutablePath)
            Me.Close()
        End If

    End Sub
End Class