Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        x = 1
        While x Mod 3 <> 2 Or x Mod 5 <> 3 Or x Mod 7 <> 2
            x = x + 1
        End While
        Label1.Text = x
    End Sub
End Class
