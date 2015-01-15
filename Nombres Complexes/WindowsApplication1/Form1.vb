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
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Supprimer(1, TC)
        ListBox1.Items.RemoveAt(0)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Supprimer(TC.taille - 1, TC)
        ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Supprimer(ListBox1.SelectedIndex + 1, TC)
        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim z As Complexe
        z.a = TextBox1.Text
        z.b = TextBox2.Text
        Remplacer(z, ListBox1.SelectedIndex + 1, TC)
        Dim i As Integer
        i = ListBox1.SelectedIndex
        ListBox1.Items.RemoveAt(i)
        ListBox1.Items.Insert(i, z.a & " + " & z.b & "i")
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        MsgBox(Somme(TC))
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TC.taille = 0
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ListBox1.Items.Clear()

        Dim sorted As Boolean
        sorted = False
        Dim tmp As Complexe
        If TC.taille > 0 Then
            While sorted = False
                sorted = True
                For i = 0 To TC.taille - 2
                    If ModuleComplexe(TC.tab(i)) > ModuleComplexe(TC.tab(i + 1)) Then
                        tmp = TC.tab(i + 1)
                        TC.tab(i + 1) = TC.tab(i)
                        TC.tab(i) = tmp
                        sorted = False
                    End If
                Next
            End While
        End If

        For i = 0 To TC.taille - 1
            ListBox1.Items.Insert(i, TC.tab(i).a & " + " & TC.tab(i).b & "i")
        Next
    End Sub
End Class
