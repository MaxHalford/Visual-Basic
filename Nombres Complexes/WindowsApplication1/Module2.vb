Module Module2
    Sub Ajouter(ByVal x As Complexe, ByVal pos As Integer, ByRef t As TabComplexe)
        t.taille = t.taille + 1
        For i = t.taille - 1 To pos Step -1
            t.tab(i) = t.tab(i - 1)
        Next
        t.tab(pos - 1) = x
    End Sub
    Sub Supprimer(ByVal pos As Integer, ByRef t As TabComplexe)
        For i = pos - 1 To t.taille - 2
            t.tab(i) = t.tab(i + 1)
        Next
        t.taille = t.taille - 1
    End Sub
    Sub Remplacer(ByVal x As Complexe, ByVal pos As Integer, ByVal t As TabComplexe)
        t.tab(pos - 1) = x
    End Sub
    Function Somme(ByVal t As TabComplexe) As String
        Dim s As Complexe
        s.a = 0
        s.b = 0
        For i = 0 To t.taille - 1
            s.a = s.a + t.tab(i).a
            s.b = s.b + t.tab(i).b
        Next
        Return ("Somme = " & s.a & " + " & s.b & "i")
    End Function
    Sub Effacer(ByRef t As TabComplexe)
        t.taille = 0
    End Sub
    Function ModuleComplexe(ByVal x As Complexe) As Double
        Dim r As Double
        r = Math.Sqrt(x.a ^ 2 + x.b ^ 2)
        Return r
    End Function
End Module
