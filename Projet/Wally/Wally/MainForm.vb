Public Class MainForm
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        For i = 1 To 6
            ComboBox1.Items.Add(i)
        Next
        For i = 1 To 42
            ComboBox2.Items.Add(i)
        Next
    End Sub

    'PREMIERE PARTIE

    Private Sub Button_Initialiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Initialiser.Click
        ListBox_Individus.Items.Clear()
        genererPopulation()
        For i = 0 To pop.taille - 1
            For j = 0 To 5
                'Plateau
                Dim myBoard As Board = loadTrail(j)
                draw(TabPage2, myBoard)
                'Robot
                Dim myRobot As Robot = pop.robots(i)
                drawRobot(myRobot)
                If myBoard.matrix(myRobot.line, myRobot.column) = Square.Paint Then myRobot.fitness += 1
                myBoard.matrix(myRobot.line, myRobot.column) = Square.Empty
                updateSquareColor(myRobot.column, myRobot.line, Square.Empty)
                'Let's go!
                Dim nbEnchainements As Integer = Math.Floor(tempsImparti / myRobot.capacite)
                For k = 1 To nbEnchainements
                    letsgoBis(myRobot.rootNode, myRobot, myBoard)
                Next
                pop.robots(i).fitness = myRobot.fitness
            Next
            pop.robots(i).fitness = Math.Round(pop.robots(i).fitness / 6, 2)
            pop.robots(i).save(i)
            ListBox_Individus.Items.Add(pop.robots(i).treeAsString & " " & pop.robots(i).fitness)
        Next

        For i = 0 To pop.taille - 1
            If pop.robots(i).fitness > Label6.Text Then Label6.Text = pop.robots(i).fitness
        Next

        For i = 0 To pop.taille - 1
            Label7.Text = Label7.Text + pop.robots(i).fitness
        Next
        Label7.Text = Label7.Text / pop.taille

        Label8.Text = pop.robots(0).fitness
        For i = 0 To pop.taille - 1
            If pop.robots(i).fitness < Label8.Text Then Label8.Text = pop.robots(i).fitness
        Next

        Label9.Text += 1
    End Sub

    Private Sub Button_GenerationSuivante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GenerationSuivante.Click
        ListBox_Individus.Items.Clear()
        Dim tmp As Population
        tmp.taille = pop.taille
        ReDim tmp.robots(tmp.taille - 1)

        For i = 0 To (tmp.taille / 2) - 1
            Dim paire As Robot() : ReDim paire(1)
            paire = croiser(selectionnerPaire())
            tmp.robots(i) = paire(0) : tmp.robots(i + tmp.taille / 2) = paire(1)
        Next

        pop = tmp

        For i = 0 To pop.taille - 1
            For j = 0 To 5
                'Plateau
                Dim myBoard As Board = loadTrail(j)
                draw(TabPage2, myBoard)
                'Robot
                Dim myRobot As Robot = pop.robots(i)
                drawRobot(myRobot)
                If myBoard.matrix(myRobot.line, myRobot.column) = Square.Paint Then myRobot.fitness += 1
                myBoard.matrix(myRobot.line, myRobot.column) = Square.Empty
                updateSquareColor(myRobot.column, myRobot.line, Square.Empty)
                'Let's go!
                Dim nbEnchainements As Integer = Math.Floor(tempsImparti / myRobot.capacite)
                For k = 1 To nbEnchainements
                    letsgoBis(myRobot.rootNode, myRobot, myBoard)
                Next
                pop.robots(i).fitness = myRobot.fitness
            Next
            ListBox_Individus.Items.Add(pop.robots(i).treeAsString & " " & pop.robots(i).fitness)
        Next

        Dim meilleur As Double = 0
        For i = 0 To pop.taille - 1
            If pop.robots(i).fitness > meilleur Then meilleur = pop.robots(i).fitness
        Next
        Dim moyenne As Double = 0
        For i = 0 To pop.taille - 1
            moyenne = moyenne + pop.robots(i).fitness
        Next
        moyenne = moyenne / pop.taille
        Dim minimum As Double = pop.robots(0).fitness
        For i = 0 To pop.taille - 1
            If pop.robots(i).fitness < minimum Then meilleur = pop.robots(i).fitness
        Next
        Label9.Text += 1
        Label6.Text = meilleur
        Label7.Text = moyenne
        Label8.Text = minimum
    End Sub
    Private Sub Button_GenerationSuivantex20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_GenerationSuivantex20.Click

    End Sub

    Private Sub Button_VisualiserIndividu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_VisualiserIndividu.Click
        Dim orientation As String = ""
        If pop.robots(ListBox_Individus.SelectedIndex).orientation = 0 Then orientation = "north"
        If pop.robots(ListBox_Individus.SelectedIndex).orientation = 1 Then orientation = "west"
        If pop.robots(ListBox_Individus.SelectedIndex).orientation = 2 Then orientation = "south"
        If pop.robots(ListBox_Individus.SelectedIndex).orientation = 3 Then orientation = "east"
        MsgBox("Arbre: " & pop.robots(ListBox_Individus.SelectedIndex).treeAsString & "      Capacite: " & pop.robots(ListBox_Individus.SelectedIndex).capacite & "      Orientation: " & orientation & "      Fitness: " & pop.robots(ListBox_Individus.SelectedIndex).fitness)
    End Sub

    'DEUXIEME PARTIE

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim orientation As String = ""
        If pop.robots(ComboBox2.Text - 1).orientation = 0 Then orientation = "north"
        If pop.robots(ComboBox2.Text - 1).orientation = 1 Then orientation = "west"
        If pop.robots(ComboBox2.Text - 1).orientation = 2 Then orientation = "south"
        If pop.robots(ComboBox2.Text - 1).orientation = 3 Then orientation = "east"
        MsgBox("Arbre: " & pop.robots(ComboBox2.Text - 1).treeAsString & "      Capacite: " & pop.robots(ComboBox2.Text - 1).capacite & "      Orientation: " & orientation & "      Fitness: " & pop.robots(ComboBox2.Text - 1).fitness)
    End Sub
    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        'Plateau
        Dim myBoard As Board = loadTrail(ComboBox1.Text - 1)
        draw(TabPage2, myBoard)
        Dim nbPaint As Integer = 0
        For i = 0 To Math.Sqrt(myBoard.matrix.Length) - 1
            For j = 0 To Math.Sqrt(myBoard.matrix.Length) - 1
                If myBoard.matrix(i, j) = Square.Paint Then nbPaint += 1
            Next
        Next
        'Robot
        Dim myRobot As Robot = pop.robots(ComboBox2.Text - 1)
        myRobot.fitness = 0
        drawRobot(myRobot)
        If myBoard.matrix(myRobot.line, myRobot.column) = Square.Paint Then myRobot.fitness += 1
        myBoard.matrix(myRobot.line, myRobot.column) = Square.Empty
        updateSquareColor(myRobot.column, myRobot.line, Square.Empty)
        'Let's go!
        Dim nbEnchainements As Integer = Math.Floor(tempsImparti / myRobot.capacite)
        For i = 1 To nbEnchainements
            letsgo(myRobot.rootNode, myRobot, myBoard)
        Next
        Label11.Text = myRobot.fitness
        Label13.Text = Math.Round(100 * (myRobot.fitness / nbPaint), 2)
    End Sub
End Class