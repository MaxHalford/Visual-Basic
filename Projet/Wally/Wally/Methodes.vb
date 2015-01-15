Module Methodes
    'precisons le nombre de mouvements maximal que chaque robot peut faire
    Public tempsImparti As Integer = 60
    'precisons le nombre initial de mouvements pour chaque enchainement
    Public mouvementsEnchainement As Integer = 6
    'creons un nouveau robot
    Function genererRobot() As Robot
        Dim newRobot As Robot
        newRobot.fitness = 0
        newRobot.capacite = mouvementsEnchainement
        newRobot.line = 16
        newRobot.column = 16
        newRobot.rootNode = New Node
        'Orientation aleatoire
        Dim p As Double = Rnd()
        If p >= 0 And p < 0.25 Then newRobot.orientation = Direction.North
        If p >= 0.25 And p < 0.5 Then newRobot.orientation = Direction.East
        If p >= 0.5 And p < 0.75 Then newRobot.orientation = Direction.South
        If p >= 0.75 And p < 1 Then newRobot.orientation = Direction.West
        'Noeud Racine aleatoire
        newRobot.rootNode.profondeur = 0
        newRobot.rootNode.numero = 0
        Dim q As Double = Rnd()
        If q >= 0 And q < 0.25 Then newRobot.rootNode.type = NodeType.MoveOn
        If q >= 0.25 And q < 0.5 Then newRobot.rootNode.type = NodeType.Test
        If q >= 0.5 And q < 0.75 Then newRobot.rootNode.type = NodeType.TurnLeft
        If q >= 0.75 And q < 1 Then newRobot.rootNode.type = NodeType.TurnRight
        'Generons les noeuds successeurs
        genererSuccesseurs(newRobot.rootNode)
        'Modelisons l'arbre de decision du robot
        newRobot.treeAsString = ""
        newRobot.buildTreeAsString(newRobot.rootNode)
        Return newRobot
    End Function
    'Creeons une procedure pour creer les noeuds "successeurs" de facon recursive
    Sub genererSuccesseurs(ByRef noeud As Node)
        ReDim noeud.successors(0)
        'Si le noeud sur lequel on se base est de type "Test" il faut deux successeurs, mais pas de successeur "Test"
        If noeud.type = NodeType.Test Then
            ReDim noeud.successors(1)
            Dim tmpNoeud1 As Node = New Node
            tmpNoeud1.profondeur = noeud.profondeur + 1
            ReDim tmpNoeud1.successors(0)
            Dim r As Double = Rnd()
            If r >= 0 And r < 1 / 3 Then tmpNoeud1.type = NodeType.MoveOn
            If r >= 1 / 3 And r < 2 / 3 Then tmpNoeud1.type = NodeType.TurnLeft
            If r >= 2 / 3 And r < 1 Then tmpNoeud1.type = NodeType.TurnRight
            Dim tmpNoeud2 As Node = New Node
            tmpNoeud2.profondeur = noeud.profondeur + 1
            tmpNoeud2.type = NodeType.MoveOn
            ReDim tmpNoeud2.successors(0)
            'Si on a atteint le nombre de movements maximal, le noeud successeur est de type "EndDecision"
            If tmpNoeud1.profondeur = mouvementsEnchainement Then tmpNoeud1.type = NodeType.EndDecision : tmpNoeud1.successors = Nothing
            If tmpNoeud2.profondeur = mouvementsEnchainement Then tmpNoeud2.type = NodeType.EndDecision : tmpNoeud2.successors = Nothing
            noeud.successors(0) = tmpNoeud1
            noeud.successors(1) = tmpNoeud2
            noeud.successors(0).numero = noeud.numero + 1
            noeud.successors(1).numero = noeud.numero + 2
        Else : Dim tmpNoeud As Node = New Node
            tmpNoeud.profondeur = noeud.profondeur + 1
            ReDim tmpNoeud.successors(0)
            Dim s As Double = Rnd()
            If s >= 0 And s < 1 / 4 Then tmpNoeud.type = NodeType.MoveOn
            If s >= 1 / 4 And s < 2 / 4 Then tmpNoeud.type = NodeType.Test
            If s >= 2 / 4 And s < 3 / 4 Then tmpNoeud.type = NodeType.TurnLeft
            If s >= 3 / 4 And s < 1 Then tmpNoeud.type = NodeType.TurnRight
            If tmpNoeud.profondeur = mouvementsEnchainement Then tmpNoeud.type = NodeType.EndDecision : tmpNoeud.successors = Nothing
            noeud.successors(0) = tmpNoeud
            noeud.successors(0).numero = noeud.numero + 1
        End If
        'Recursivite
        For i = 0 To noeud.successors.Length - 1
            If noeud.successors(i).type <> NodeType.EndDecision Then genererSuccesseurs(noeud.successors(i))
        Next
    End Sub
    'Procedures pour bouger
    Sub turnRight(ByRef robot As Robot)
        If robot.orientation = Direction.North Then
            robot.orientation = Direction.East
        ElseIf robot.orientation = Direction.East Then
            robot.orientation = Direction.South
        ElseIf robot.orientation = Direction.South Then
            robot.orientation = Direction.West
        ElseIf robot.orientation = Direction.West Then
            robot.orientation = Direction.North
        End If
    End Sub
    Sub turnLeft(ByRef robot As Robot)
        If robot.orientation = Direction.North Then
            robot.orientation = Direction.West
        ElseIf robot.orientation = Direction.East Then
            robot.orientation = Direction.North
        ElseIf robot.orientation = Direction.South Then
            robot.orientation = Direction.East
        ElseIf robot.orientation = Direction.West Then
            robot.orientation = Direction.South
        End If
    End Sub
    Sub moveOn(ByRef robot As Robot, ByVal board As Board)
        Select Case robot.orientation
            Case Direction.North
                If robot.line = 0 Then
                    robot.line = Math.Sqrt(board.matrix.Length) - 1
                else : robot.line -= 1
                End If
            Case Direction.East
                If robot.column = Math.Sqrt(board.matrix.Length) - 1 Then
                    robot.column = 0
                Else : robot.column += 1
                End If
            Case Direction.South
                If robot.line = Math.Sqrt(board.matrix.Length) - 1 Then
                    robot.line = 0
                Else : robot.line += 1
                End If
            Case Direction.West
                If robot.column = 0 Then
                    robot.column = Math.Sqrt(board.matrix.Length) - 1
                Else : robot.column -= 1
                End If
        End Select
    End Sub
    Function test(ByVal robot As Robot, ByVal board As Board) As String
        Dim answer As String = ""
        Dim i As Integer = robot.line
        Dim j As Integer = robot.column
        Select Case robot.orientation
            Case Direction.North
                Select Case robot.line
                    Case 0
                        If board.matrix(Math.Sqrt(board.matrix.Length) - 1, j) = Square.Paint Then answer = "paint"
                        If board.matrix(Math.Sqrt(board.matrix.Length) - 1, j) = Square.Empty Then answer = "empty"
                        If board.matrix(Math.Sqrt(board.matrix.Length) - 1, j) = Square.Obstacle Then answer = "obstacle"
                    Case Else
                        If board.matrix(i - 1, j) = Square.Paint Then answer = "paint"
                        If board.matrix(i - 1, j) = Square.Empty Then answer = "empty"
                        If board.matrix(i - 1, j) = Square.Obstacle Then answer = "obstacle"
                End Select
            Case Direction.East
                Select Case robot.column
                    Case Math.Sqrt(board.matrix.Length) - 1
                        If board.matrix(i, 0) = Square.Paint Then answer = "paint"
                        If board.matrix(i, 0) = Square.Empty Then answer = "empty"
                        If board.matrix(i, 0) = Square.Obstacle Then answer = "obstacle"
                    Case Else
                        If board.matrix(i, j + 1) = Square.Paint Then answer = "paint"
                        If board.matrix(i, j + 1) = Square.Empty Then answer = "empty"
                        If board.matrix(i, j + 1) = Square.Obstacle Then answer = "obstacle"
                End Select
            Case Direction.South
                Select Case robot.line
                    Case Math.Sqrt(board.matrix.Length) - 1
                        If board.matrix(0, j) = Square.Paint Then answer = "paint"
                        If board.matrix(0, j) = Square.Empty Then answer = "empty"
                        If board.matrix(0, j) = Square.Obstacle Then answer = "obstacle"
                    Case Else
                        If board.matrix(i + 1, j) = Square.Paint Then answer = "paint"
                        If board.matrix(i + 1, j) = Square.Empty Then answer = "empty"
                        If board.matrix(i + 1, j) = Square.Obstacle Then answer = "obstacle"
                End Select
            Case Direction.West
                Select Case robot.column
                    Case 0
                        If board.matrix(i, Math.Sqrt(board.matrix.Length) - 1) = Square.Paint Then answer = "paint"
                        If board.matrix(i, Math.Sqrt(board.matrix.Length) - 1) = Square.Empty Then answer = "empty"
                        If board.matrix(i, Math.Sqrt(board.matrix.Length) - 1) = Square.Obstacle Then answer = "obstacle"
                    Case Else
                        If board.matrix(i, j - 1) = Square.Paint Then answer = "paint"
                        If board.matrix(i, j - 1) = Square.Empty Then answer = "empty"
                        If board.matrix(i, j - 1) = Square.Obstacle Then answer = "obstacle"
                End Select
        End Select
        Return answer
    End Function
    Sub letsgo(ByVal n As Node, ByRef robot As Robot, ByRef board As Board)
        pause(180)
        If n.type <> NodeType.EndDecision Then
            Select Case n.type
                Case NodeType.MoveOn
                    moveOn(robot, board)
                    'assignons la fitness
                    If board.matrix(robot.line, robot.column) = Square.Paint Then robot.fitness += 1
                    drawRobot(robot)
                    board.matrix(robot.line, robot.column) = Square.Empty
                    updateSquareColor(robot.line, robot.column, Square.Empty)
                    letsgo(n.successors(0), robot, board)
                Case NodeType.Test
                    If test(robot, board) = "paint" Then
                        letsgo(n.successors(1), robot, board)
                    Else : letsgo(n.successors(0), robot, board)
                    End If
                Case NodeType.TurnLeft
                    turnLeft(robot)
                    drawRobot(robot)
                    letsgo(n.successors(0), robot, board)
                Case NodeType.TurnRight
                    turnRight(robot)
                    drawRobot(robot)
                    letsgo(n.successors(0), robot, board)
            End Select
        End If
    End Sub
    'letsgo mais sans affichage graphique (moins de temps de calcul)
    Sub letsgoBis(ByVal n As Node, ByRef robot As Robot, ByRef board As Board)
        If n.type <> NodeType.EndDecision Then
            Select Case n.type
                Case NodeType.MoveOn
                    moveOn(robot, board)
                    'assignons la fitness
                    If board.matrix(robot.line, robot.column) = Square.Paint Then robot.fitness += 1
                    board.matrix(robot.line, robot.column) = Square.Empty
                    letsgoBis(n.successors(0), robot, board)
                Case NodeType.Test
                    If test(robot, board) = "paint" Then
                        letsgoBis(n.successors(1), robot, board)
                    Else : letsgoBis(n.successors(0), robot, board)
                    End If
                Case NodeType.TurnLeft
                    turnLeft(robot)
                    letsgoBis(n.successors(0), robot, board)
                Case NodeType.TurnRight
                    turnRight(robot)
                    letsgoBis(n.successors(0), robot, board)
            End Select
        End If
    End Sub
    'Good ?
    Sub genererPopulation()
        pop.taille = 42
        ReDim pop.robots(pop.taille - 1)
        For i = 0 To pop.taille - 1
            pop.robots(i) = genererRobot()
            pop.robots(i).save(i)
        Next
    End Sub
    Sub muter(ByVal robot As Robot)

    End Sub
    Function selectionnerPaire() As Robot()
        Dim proba As Double = 0
        For i = 0 To pop.taille - 1
            proba = proba + pop.robots(i).fitness
        Next
        proba = 1 / proba
        Dim vProba As Double() : ReDim vProba(pop.taille - 1)
        For i = 0 To pop.taille - 1
            vProba(i) = pop.robots(i).fitness * proba
        Next
        For i = 1 To pop.taille - 1
            vProba(i) = vProba(i) + vProba(i - 1)
        Next
        Dim q As Double = 0
        Dim r As Double = 0
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0
        While index1 = index2
            q = Rnd() : r = Rnd() : index1 = 0 : index2 = 0
            For i = 0 To pop.taille - 1
                If q > vProba(i) Then index1 = index1 + 1
                If r > vProba(i) Then index2 = index2 + 1
            Next
        End While

        Dim sujets As Robot() : ReDim sujets(1)
        sujets(0) = pop.robots(index1) : sujets(1) = pop.robots(index2)
        Return sujets
    End Function
    Function compterNoeuds(noeud As Node) As Integer
        Dim value As Integer = 1
        If noeud.successors Is Nothing Then
            Return value
        Else : For i = 0 To noeud.successors.Length - 1
                value = value + compterNoeuds(noeud.successors(i))
            Next
        End If
        Return value
    End Function
    Function findNode(ByVal noeud As Node, ByVal index As Integer) As Node
        Dim resultNode As Node : resultNode.type = Nothing : resultNode.type = Nothing : resultNode.successors = Nothing
        For i = 0 To noeud.successors.Length - 1
            If noeud.successors(i).numero = index Then
                resultNode = noeud.successors(i)
            Else : findNode(noeud.successors(i), index)
            End If
        Next
        Return resultNode
    End Function
    Sub replaceNode(ByVal noeud As Node, ByVal index As Integer, ByVal newNode As Node)
        For i = 0 To noeud.successors.Length - 1
            If noeud.successors(i).numero = index Then
                noeud.successors(i) = newNode
            Else : replaceNode(noeud.successors(i), index, newNode)
            End If
        Next
    End Sub
    Function getMaxDepth(ByVal noeud As Node, ByVal currentDepth As Integer) As Integer
        currentDepth += 1
        If Not (noeud.successors Is Nothing) Then
            For i = 0 To noeud.successors.Length - 1
                getMaxDepth(noeud.successors(i), currentDepth)
            Next
        End If
        Return currentDepth
    End Function
    Sub assignDepth(ByVal noeud As Node)
        If Not (noeud.successors Is Nothing) Then
            For i = 0 To noeud.successors.Length - 1
                noeud.successors(i).profondeur = noeud.profondeur + 1
                assignDepth(noeud.successors(i))
            Next
        End If
    End Sub
    Function croiser(ByVal sujets As Robot()) As Robot()
        Dim tmpRobotUn As Robot = genererRobot() : tmpRobotUn.rootNode = sujets(0).rootNode : tmpRobotUn.treeAsString = sujets(0).treeAsString
        Dim tmpRobotDeux As Robot = genererRobot() : tmpRobotDeux.rootNode = sujets(1).rootNode : tmpRobotDeux.treeAsString = sujets(1).treeAsString

        Dim robotUn As Robot = genererRobot() : robotUn.rootNode = tmpRobotUn.rootNode
        Dim robotDeux As Robot = genererRobot() : robotDeux.rootNode = tmpRobotDeux.rootNode

        Dim nbNoeudTransitionUn = Math.Round(compterNoeuds(tmpRobotUn.rootNode) * Rnd()) - 1
        Dim nbNoeudTransitionDeux = Math.Round(compterNoeuds(tmpRobotDeux.rootNode) * Rnd()) - 1

        Dim tmpNoeudUn As Node = findNode(tmpRobotUn.rootNode, nbNoeudTransitionUn)
        Dim tmpNoeudDeux As Node = findNode(tmpRobotDeux.rootNode, nbNoeudTransitionDeux)

        replaceNode(robotUn.rootNode, nbNoeudTransitionUn, tmpNoeudDeux)
        replaceNode(robotDeux.rootNode, nbNoeudTransitionDeux, tmpNoeudUn)

        Dim nouveauxRobots As Robot() : ReDim nouveauxRobots(1)

        nouveauxRobots(0) = robotUn
        nouveauxRobots(1) = robotDeux

        nouveauxRobots(0).rootNode.profondeur = 0
        nouveauxRobots(1).rootNode.profondeur = 0

        nouveauxRobots(0).capacite = getMaxDepth(nouveauxRobots(0).rootNode, nouveauxRobots(0).rootNode.profondeur)
        nouveauxRobots(1).capacite = getMaxDepth(nouveauxRobots(1).rootNode, nouveauxRobots(1).rootNode.profondeur)

        assignDepth(nouveauxRobots(0).rootNode)
        assignDepth(nouveauxRobots(1).rootNode)

        Return nouveauxRobots
    End Function
End Module
