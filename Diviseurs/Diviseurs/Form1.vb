Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        n = tb.Text
        Dim T(n) As Integer
        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 1 To n
                If n Mod i = 0 Then
                T(j) = n / i
                j = j + 1
                End If
        Next

        For i = 0 To j - 1

            ListBox1.Items.Add(T(i))
        Next

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
