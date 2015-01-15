Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub textN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim n As String
        Dim p As String
        Dim r As String
        Dim i As Integer

        n = txtN.Text
        p = txtP.Text
        r = 1
        For i = 1 To p
            r = n * r
        Next i
        lblR.Text = r
    End Sub
End Class
