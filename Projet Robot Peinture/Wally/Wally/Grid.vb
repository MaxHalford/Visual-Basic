
Public Class Grid
    Public anchorPixel As System.Drawing.Point
    Public pictureSize As Integer = 450
    Public squareMatrix As Square(,)
    Public startingPointLine As Integer
    Public startingPointColumn As Integer

    Public robotOrientation As Integer
    Public robotLine As Integer
    Public robotColumn As Integer
    ' the size of a single square of the grid (in pixels)
    Private squareSize As Integer
    Private emptySquareColor As Color
    Private foodColor As Color = Color.LimeGreen
    Private wallColor As Color = Color.Black
    Private gphx As Graphics
    Sub New(ByVal tab As TabPage, ByVal board As Board)
        Dim robot As Robot = New Robot
        Me.gphx = tab.CreateGraphics()
        Me.anchorPixel = New System.Drawing.Point(12, 12)
        Me.emptySquareColor = tab.BackColor
        ReDim Me.squareMatrix(board.matrix.GetLength(0) - 1, board.matrix.GetLength(0) - 1)
        updateTrail(board)
    End Sub


    Public Sub updateTrail(ByVal board As Board)
        Dim matrixSize As Integer = board.matrix.GetLength(0)
        For i As Integer = 0 To matrixSize - 1
            For j As Integer = 0 To matrixSize - 1
                squareMatrix(i, j) = board.matrix(i, j)
            Next
        Next
        colorSquares()
    End Sub


    Public Sub updateRobot(ByVal robot As Robot)
        drawRobot(False)
        Me.robotLine = robot.line
        Me.robotColumn = robot.column
        Me.robotOrientation = robot.orientation
        drawRobot(True)

    End Sub



    Public Sub fillInSquare(ByVal lineIndex As Integer, ByVal columnIndex As Integer, ByVal content As Square)
        Me.squareMatrix(lineIndex, columnIndex) = content
        Dim squareAnchorX = Me.anchorPixel.X + (columnIndex) * Me.squareSize
        Dim squareAnchorY = Me.anchorPixel.Y + (lineIndex) * Me.squareSize
        Dim brush As System.Drawing.SolidBrush
        If content = Square.Paint Then
            brush = New System.Drawing.SolidBrush(foodColor)
        ElseIf content = Square.Obstacle Then
            brush = New System.Drawing.SolidBrush(wallColor)
        Else
            brush = New System.Drawing.SolidBrush(emptySquareColor)
        End If
        gphx.FillRectangle(brush, New Rectangle(squareAnchorX + 1, squareAnchorY + 1, squareSize - 1, squareSize - 1))
        If Me.robotLine = lineIndex AndAlso Me.robotColumn = columnIndex Then
            drawRobot(True)
        End If
    End Sub


    Private Sub drawRobot(ByVal visible As Boolean)
        Dim squareAnchorX = Me.anchorPixel.X + (robotColumn) * Me.squareSize
        Dim squareAnchorY = Me.anchorPixel.Y + (robotLine) * Me.squareSize
        Dim leftBase, rightBase, head As Point
        If (robotOrientation = Direction.North) Then
            leftBase = New Point(squareAnchorX, squareAnchorY + Me.squareSize)
            rightBase = New Point(squareAnchorX + Me.squareSize, squareAnchorY + Me.squareSize)
            head = New Point(squareAnchorX + (Math.Floor(Me.squareSize / 2)), squareAnchorY)
        ElseIf (robotOrientation = Direction.East) Then
            leftBase = New Point(squareAnchorX, squareAnchorY)
            rightBase = New Point(squareAnchorX, squareAnchorY + Me.squareSize)
            head = New Point(squareAnchorX + Me.squareSize, squareAnchorY + (Math.Floor(Me.squareSize / 2)))
        ElseIf (robotOrientation = Direction.South) Then
            leftBase = New Point(squareAnchorX + Me.squareSize, squareAnchorY)
            rightBase = New Point(squareAnchorX, squareAnchorY)
            head = New Point(squareAnchorX + (Math.Floor(Me.squareSize / 2)), squareAnchorY + Me.squareSize)
        Else
            leftBase = New Point(squareAnchorX + Me.squareSize, squareAnchorY + Me.squareSize)
            rightBase = New Point(squareAnchorX + Me.squareSize, squareAnchorY)
            head = New Point(squareAnchorX, squareAnchorY + (Math.Floor(Me.squareSize / 2)))
        End If
        Dim brush As System.Drawing.SolidBrush

        If (visible = True) Then
            brush = New System.Drawing.SolidBrush(Color.Red)
        Else
            If squareMatrix(robotLine, robotColumn) = Square.Obstacle Then
                brush = New System.Drawing.SolidBrush(wallColor)
            ElseIf squareMatrix(robotLine, robotColumn) = Square.Paint Then
                brush = New System.Drawing.SolidBrush(foodColor)
            Else
                brush = New System.Drawing.SolidBrush(emptySquareColor)
            End If
        End If
        gphx.FillPolygon(brush, New Point() {leftBase, rightBase, head})

        drawLines()

    End Sub



    Private Sub eraseGrid()
        Dim brush = New System.Drawing.SolidBrush(emptySquareColor)
        gphx.FillRectangle(brush, New Rectangle(anchorPixel.X, anchorPixel.Y, pictureSize, pictureSize))
    End Sub


    Private Sub drawLines()
        Dim pen = New Pen(Brushes.Black)
        Me.squareSize = Math.Floor(Me.pictureSize / squareMatrix.GetLength(0))
        Dim gridLength As Integer = squareSize * squareMatrix.GetLength(0)
        Dim i As Integer = 0
        While i < squareMatrix.GetLength(0) + 1
            gphx.DrawLine(pen, anchorPixel.X + i * Me.squareSize, anchorPixel.Y, anchorPixel.X + i * Me.squareSize, anchorPixel.Y + gridLength)
            gphx.DrawLine(pen, anchorPixel.X, anchorPixel.Y + i * Me.squareSize, anchorPixel.X + gridLength, anchorPixel.Y + i * Me.squareSize)
            i += 1
        End While
    End Sub

    Private Sub colorSquares()
        eraseGrid()
        drawLines()
        Dim matrixSize As Integer = squareMatrix.GetLength(0)
        For i As Integer = 0 To matrixSize - 1
            For j As Integer = 0 To matrixSize - 1
                If (squareMatrix(i, j) <> Square.Empty) Then
                    fillInSquare(i, j, squareMatrix(i, j))
                End If
            Next
        Next
        drawLines()
    End Sub

 

End Class
