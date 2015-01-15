Public Class Calculatrice

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Double
        Dim y As Double
        Dim s As Double
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        Else : x = TextBox1.Text : y = TextBox2.Text : s = x + y : TextBox3.Text = s
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As Double
        Dim y As Double
        Dim s As Double
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        Else : x = TextBox1.Text : y = TextBox2.Text : s = x - y : TextBox3.Text = s
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As Double
        Dim y As Double
        Dim s As Double
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        Else : x = TextBox1.Text : y = TextBox2.Text : s = x * y : TextBox3.Text = s
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'On admettra que la division par 0 et fait tendre vers plus ou moins l'infini
        Dim x As Double
        Dim y As Double
        Dim s As Double
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.") : y = 1
        Else : x = TextBox1.Text : y = TextBox2.Text : s = x / y : TextBox3.Text = s
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x As Double
        Dim y As Double
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.") : TextBox3.Text = ""
        ElseIf TextBox1.Text = 0 And TextBox2.Text < 0 Then
            Beep() : MsgBox("Erreur: tentative de division par 0.") : TextBox3.Text = ""
        Else : x = TextBox1.Text : y = TextBox2.Text : TextBox3.Text = Puissance(x, y)
        End If

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim x As Integer
        If IsNumeric(TextBox1.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite une opérande.")
        ElseIf TextBox1.Text < 0 Then
            Beep() : MsgBox("Erreur: veuillez rentrer une valeur positive.") : TextBox3.Text = ""
        Else : x = TextBox1.Text : TextBox3.Text = Factorielle(x)
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim x As Integer
        Dim y As Integer
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        Else : x = TextBox1.Text : y = TextBox2.Text : TextBox3.Text = PGCD(x, y)
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim x As Integer
        Dim y As Integer
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        ElseIf TextBox1.Text < 0 Or TextBox2.Text < 0 Then
            x = TextBox1.Text : y = TextBox2.Text : TextBox3.Text = ((x * y) / PGCD(x, y)) * -1
        Else : x = TextBox1.Text : y = TextBox2.Text : TextBox3.Text = (x * y) / PGCD(x, y)
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim x As Double
        Dim y As Double
        Dim r As Double

        If RadioButton3.Checked = True Or RadioButton5.Checked = True Then
            If IsNumeric(TextBox1.Text) = False Then
                Beep() : MsgBox("Erreur: le calcul nécessite une opérande.")
            Else : x = TextBox1.Text
            End If
        End If

        If RadioButton4.Checked = True Or RadioButton6.Checked = True Then
            If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
                Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
            Else : x = TextBox1.Text : y = TextBox2.Text
            End If
        End If

        If x < 0 Then x = x * -1 : TextBox1.Text = x
        If y < 0 Then y = y * -1 : TextBox2.Text = x
        If RadioButton1.Checked = True Then
            If RadioButton3.Checked = True Then r = SurfaceSphère(x)
            If RadioButton4.Checked = True Then r = SurfaceCône(x, y)
            If RadioButton5.Checked = True Then r = SurfaceCube(x)
            If RadioButton6.Checked = True Then r = SurfaceCylindre(x, y)
        End If
        If RadioButton2.Checked = True Then
            If RadioButton3.Checked = True Then r = VolumeSphère(x)
            If RadioButton4.Checked = True Then r = VolumeCône(x, y)
            If RadioButton5.Checked = True Then r = VolumeCube(x)
            If RadioButton6.Checked = True Then r = VolumeCylindre(x, y)
        End If
        TextBox3.Text = r
        If RadioButton3.Checked = True Or RadioButton5.Checked = True And IsNumeric(TextBox1.Text) = False Then TextBox3.Text = ""
        If RadioButton4.Checked = True Or RadioButton6.Checked = True And (IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False) Then TextBox3.Text = ""
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label1.Text = ""
        Label2.Text = ""
        If RadioButton3.Checked = True Then TextBox2.Visible = False
        If RadioButton5.Checked = True Then TextBox2.Visible = False
        If RadioButton3.Checked = True Then Label1.Text = "Rayon"
        If RadioButton4.Checked = True Then
            Label1.Text = "Rayon"
            Label2.Text = "Hauteur"
        End If
        If RadioButton5.Checked = True Then Label1.Text = "Hauteur"
        If RadioButton6.Checked = True Then
            Label1.Text = "Rayon"
            Label2.Text = "Hauteur"
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim r As Boolean
        Dim x As Integer

        If IsNumeric(TextBox1.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite une opérande.")
        ElseIf TextBox1.Text < 0 Then
            Beep() : MsgBox("Erreur: veuillez rentrer une valeur positive.") : TextBox3.Text = ""
        Else : x = TextBox1.Text : r = Premier(x) : MsgBox(r)
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim x As Integer
        Dim r As String

        If IsNumeric(TextBox1.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite une opérande.")
        ElseIf TextBox1.Text < 0 Then
            Beep() : MsgBox("Erreur: veuillez rentrer une valeur positive.")
        Else : x = TextBox1.Text : r = Parfait(x) : MsgBox(r)
        End If


    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim x As Integer
        Dim y As Integer
        Dim r As Integer

        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            Beep() : MsgBox("Erreur: le calcul nécessite deux opérandes.")
        ElseIf TextBox1.Text < 0 Or TextBox2.Text < 0 Then
            Beep() : MsgBox("Erreur: veuillez rentrer des valeurs positives.") : TextBox3.Text = " "
        ElseIf TextBox1.Text < TextBox2.Text Then : Beep() : MsgBox("Erreur: la première valeur doit être au moins plus grande que la deuxième.") : TextBox3.Text = " "
        Else : x = TextBox1.Text : y = TextBox2.Text : r = Factorielle(x) / (Factorielle(y) * Factorielle(x - y)) : TextBox3.Text = r
        End If


    End Sub
End Class
