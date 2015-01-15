Module Fonctions_avancées
    Function Puissance(ByVal x As Double, ByVal y As Double) As Double
        Dim result As Double
        result = x ^ y
        Return result
    End Function
    Function Factorielle(ByVal x As Integer) As Double
        Dim result As Integer
        result = 1
        If x = 0 Then result = 1
        If x = 1 Then result = 1
        If x > 1 Then
            For i = 2 To x
                result = result * i
            Next
        End If
        Return result
    End Function
    Function PGCD(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim result As Integer
        Dim min As Integer
        Dim max As Integer
        Dim r As Integer
        Dim k As Integer
        k = 0
        If x < 0 And y > 0 Then x = x * -1 : k = 1
        If y < 0 And x > 0 Then y = y * -1 : k = 1
        If y < 0 And x < 0 Then y = y * -1 : x = x * -1
        If x < y Then
            min = x
            max = y
        End If
        If x > y Then
            min = y
            max = x
        End If
        r = 1
        While r > 0
            r = max Mod min
            max = min
            min = r
        End While
        result = max
        If k = 1 Then result = result * -1
        Return result
    End Function
    Function Premier(ByVal x As Integer) As Boolean
        Dim d As Integer
        Dim r As Boolean
        r = True
        For i = 2 To x - 1
            d = x Mod i
            If d = 0 Then r = False
        Next i
        Return r
    End Function
    Function Parfait(ByVal x As Integer) As Boolean
        Dim r As Boolean
        r = False
        Dim s As Integer
        s = 1
        For i = 2 To Math.Floor(x / 2)
            If x Mod i = 0 Then s = s + i
        Next
        If (x = s) Then r = False
        Return r
    End Function
End Module
