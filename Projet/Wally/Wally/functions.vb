Imports System.IO

Module functions
    Dim grid As Grid

    Sub draw(ByVal tab As TabPage, ByVal board As Board)
        grid = New Grid(tab, board)
    End Sub
    Sub updateSquareColor(ByVal line As Integer, ByVal column As Integer, ByVal square As Square)
        grid.fillInSquare(line, column, square)
    End Sub
    Sub drawRobot(ByVal robot As Robot)
        grid.updateRobot(robot)
    End Sub
    Sub pause(ByVal milliseconds As Integer)
        System.Threading.Thread.Sleep(500)
    End Sub
    Function loadTrail(ByVal index As Integer) As Board
        Dim board = New Board
        Dim fileName = "..\..\trails\trail_" + index.ToString + ".txt"
        Dim str As String = System.IO.File.ReadAllText(fileName)
        Dim lines As String() = str.Split(" ")
        board.init(lines(0).Length)
        For i = 0 To lines.GetLength(0) - 1
            Dim line = lines(i)
            For j = 0 To line.Length - 1
                If (line(j) = "F") Then
                    board.matrix(i, j) = Square.Paint
                ElseIf (line(j) = "W") Then
                    board.matrix(i, j) = Square.Obstacle
                Else
                    board.matrix(i, j) = Square.Empty
                End If
            Next
        Next
        Return board
    End Function
    Function loadRobot(ByVal index As Integer) As Robot
        Dim robot = New Robot
        Dim filePath = "..\..\robots\robot_" + index.ToString + ".txt"
        Dim sr As StreamReader = New StreamReader(filePath)
        robot.treeAsString = sr.ReadLine()
        sr.Close()
        robot.rootNode = robot.parseTree(0)
        Return robot
    End Function
End Module
