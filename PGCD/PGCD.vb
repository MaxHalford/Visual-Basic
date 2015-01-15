Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        Dim min As Integer
        Dim PGCD As Integer
        x = TextBox1.Text
        y = TextBox2.Text
        If x < y Then min = x
        If y < x Then min = y
        Dim i As Integer
        For i = 2 To min
            If x Mod i = 0 And y Mod i = 0 Then
                PGCD = i
            End If
        Next
        Label1.Text = PGCD
    End Sub
End Class
