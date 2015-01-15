Imports System.IO
Public Module structures
    Structure Population
        Dim taille As Integer
        Dim robots As Robot()
    End Structure
    Public pop As Population
    Structure Board
        Dim size As Integer
        Dim matrix As Square(,)
        Sub init(ByVal a As Integer)
            size = a
            ReDim matrix(size - 1, size - 1)
        End Sub
    End Structure
    Structure Robot
        Dim line As Integer
        Dim column As Integer
        Dim orientation As Direction
        Dim treeAsString As String
        Dim rootNode As Node
        Dim capacite As Integer
        Dim fitness As Double
        Sub save(ByVal index As Integer)
            Dim filePath = "..\..\robots\robot_" + index.ToString + ".txt"
            Dim writer As New StreamWriter(filePath)
            treeAsString = ""
            buildTreeAsString(rootNode)
            writer.Write(treeAsString)
            writer.Close()
        End Sub
        Sub buildTreeAsString(ByVal n As Node)
            If (n.type = NodeType.EndDecision) Then
                treeAsString = treeAsString & "E"
            ElseIf (n.type = NodeType.MoveOn) Then
                treeAsString = treeAsString & "M"
            ElseIf (n.type = NodeType.Test) Then
                treeAsString = treeAsString & "T"
            ElseIf (n.type = NodeType.TurnLeft) Then
                treeAsString = treeAsString & "L"
            ElseIf (n.type = NodeType.TurnRight) Then
                treeAsString = treeAsString & "R"
            End If
            If Not (n.successors Is Nothing) Then
                treeAsString = treeAsString & "("
                For i = 0 To n.successors.Length - 1
                    buildTreeAsString(n.successors(i))
                Next
                treeAsString = treeAsString & ")"
            End If
        End Sub

        Function parseTree(ByRef stringIndex As Integer) As Node
            Dim successorsIndex As Integer = 0
            Dim n As Node = New Node
            If (treeAsString(stringIndex) = ("E")) Then
                n.type = NodeType.EndDecision
            ElseIf (treeAsString(stringIndex) = ("M")) Then
                n.type = NodeType.MoveOn
                ReDim n.successors(0)
            ElseIf (treeAsString(stringIndex) = ("T")) Then
                n.type = NodeType.Test
                ReDim n.successors(1)
            ElseIf (treeAsString(stringIndex) = ("L")) Then
                n.type = NodeType.TurnLeft
                ReDim n.successors(0)
            ElseIf (treeAsString(stringIndex) = ("R")) Then
                n.type = NodeType.TurnRight
                ReDim n.successors(0)
            End If

            If (treeAsString(stringIndex + 1) = ("(")) Then
                successorsIndex = 0
                stringIndex += 2
                While stringIndex < treeAsString.Length - 1 And Not treeAsString(stringIndex) = (")")
                    n.successors(successorsIndex) = parseTree(stringIndex)
                    stringIndex += 1
                    successorsIndex += 1
                End While
            End If
            Return n
        End Function
    End Structure

    Structure Node
        Dim type As NodeType
        Dim successors As Node()
        Dim profondeur As Integer
        Dim numero As Integer
    End Structure

End Module
