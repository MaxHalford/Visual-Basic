Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TC.taille = 0
        ReDim TC.tab(1000)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim z As Complexe
        z.a = TextBox1.Text
        z.b = TextBox2.Text
        TC.taille = TC.taille + 1
        TC.tab(TC.taille - 1) = z

        ListBox1.Items.Add(z.a & " + " & z.b & "i")
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim z As Complexe
        z.a = TextBox1.Text
        z.b = TextBox2.Text
        Ajouter(z, 1, TC)

        ListBox1.Items.Insert(0, z.a & " + " & z.b & "i")
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim z As Complexe
        z.a = TextBox1.Text
        z.b = TextBox2.Text
        Ajouter(z, ListBox1.SelectedIndex + 1, TC)

        ListBox1.Items.Insert(ListBox1.SelectedIndex, z.a & " + " & z.b & "i")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim z As Complexe
        z.a = TextBox1.Text
        z.b = TextBox2.Text
        Ajouter(z, ListBox1.SelectedIndex + 2, TC)

        ListBox1.Items.Insert(ListBox1.SelectedIndex + 1, z.a & " + " & z.b & "i")
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        MsgBox(Somme(TC))
    End Sub
End Class
