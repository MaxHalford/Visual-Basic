Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        taillePop = 200
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = 0 : Label9.Text = 0 : Label7.Text = 0

        genererPopulation(Martiens)

        ListBox1.Items.Clear()

        Dim binaire() As String
        ReDim binaire(taillePop - 1)

        For i = 0 To taillePop - 1
            binaire(i) = Martiens.pop(i).fitness & " "
        Next

        For i = 0 To taillePop - 1
            For j = 0 To 49
                If Martiens.pop(i).ADN(j) = False Then
                    binaire(i) = binaire(i) & "0"
                Else : binaire(i) = binaire(i) & "1"
                End If
            Next
        Next

        For i = 0 To taillePop - 1
            ListBox1.Items.Add(binaire(i))
        Next

        Dim fitMax As Integer = 0
        For i = 0 To taillePop - 1
            If Martiens.pop(i).fitness > fitMax Then fitMax = Martiens.pop(i).fitness
        Next
        Dim fitMoy As Double = 0
        For i = 0 To taillePop - 1
            fitMoy = fitMoy + Martiens.pop(i).fitness
        Next
        fitMoy = fitMoy / taillePop
        Label7.Text = fitMax
        Label9.Text = fitMoy

        Dim x() As Integer : ReDim x(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            x(i) = i + 1
        Next
        Dim y() As Integer : ReDim y(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            y(i) = Martiens.pop(i).fitness
        Next
        Dim z() As Integer : ReDim z(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            z(i) = fitMax
        Next
        Dim t() As Integer : ReDim t(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            t(i) = fitMoy
        Next

        Chart1.Series("Fitness Individuelle").Points.DataBindXY(x, y)
        Chart1.Series("Fitness Maximale").Points.DataBindXY(x, z)
        Chart1.Series("Fitness Moyenne").Points.DataBindXY(x, t)
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label2.Text = Label2.Text + 1 : Label9.Text = 0 : Label7.Text = 0
        Dim tmp As Population
        tmp.taillePopulation = taillePop
        ReDim tmp.pop(taillePop - 1)

        For i = 0 To (tmp.taillePopulation / 2) - 1
            Dim paire As Individu() = selectionnerPaire(Martiens)
            'MsgBox("parent1 " & paire(0).toString)
            'MsgBox(paire(1).toString)
            paire = croiser(paire)
         

            tmp.pop(i) = paire(0) : tmp.pop(i + tmp.taillePopulation / 2) = paire(1)
        Next

        Martiens = tmp

        For i = 0 To Martiens.taillePopulation - 1
            muter(Martiens.pop(i))
        Next

        trier(Martiens)

        ListBox1.Items.Clear()

        Dim binaire() As String
        ReDim binaire(taillePop - 1)

        For i = 0 To taillePop - 1
            binaire(i) = Martiens.pop(i).fitness & " "
        Next

        For i = 0 To taillePop - 1
            For j = 0 To 49
                If Martiens.pop(i).ADN(j) = False Then
                    binaire(i) = binaire(i) & "0"
                Else : binaire(i) = binaire(i) & "1"
                End If
            Next
        Next

        For i = 0 To taillePop - 1
            ListBox1.Items.Add(binaire(i))
        Next

        Dim fitMax As Integer = 0
        For i = 0 To taillePop - 1
            If Martiens.pop(i).fitness > fitMax Then fitMax = Martiens.pop(i).fitness
        Next
        Dim fitMoy As Double = 0
        For i = 0 To taillePop - 1
            fitMoy = fitMoy + Martiens.pop(i).fitness
        Next
        fitMoy = fitMoy / taillePop
        Label7.Text = fitMax
        Label9.Text = fitMoy

        Dim x() As Integer : ReDim x(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            x(i) = i + 1
        Next
        Dim y() As Integer : ReDim y(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            y(i) = Martiens.pop(i).fitness
        Next
        Dim z() As Integer : ReDim z(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            z(i) = fitMax
        Next
        Dim t() As Integer : ReDim t(Martiens.taillePopulation - 1)
        For i = 0 To Martiens.taillePopulation - 1
            t(i) = fitMoy
        Next

        Chart1.Series("Fitness Individuelle").Points.DataBindXY(x, y)
        Chart1.Series("Fitness Maximale").Points.DataBindXY(x, z)
        Chart1.Series("Fitness Moyenne").Points.DataBindXY(x, t)

    End Sub

    Private Sub Chart1_Click(sender As System.Object, e As System.EventArgs) Handles Chart1.Click
        
    End Sub
End Class
