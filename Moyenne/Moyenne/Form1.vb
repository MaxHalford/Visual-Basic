Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim list() As Integer
        Dim n As Integer
        n = txt.Text
        ReDim list(n)
        Dim i As Integer
        For i = 0 To n - 1
            list(i) = i + 1
        Next i
        Dim m As Integer
        m = (list(0) + list(n - 1)) / 2
        lbl.Text = m

    End Sub
End Class
