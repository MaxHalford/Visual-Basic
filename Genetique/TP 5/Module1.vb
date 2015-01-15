Module Module1
    Public taillePop As Integer
    Structure Individu
        Dim ADN() As Boolean
        Dim fitness As Integer
        Dim nbADN As Integer
        Overrides Function toString() As String
            Dim s As String = ""
            For j = 0 To 49
                If ADN(j) = False Then
                    s = s & "0"
                Else : s = s & "1"
                End If
            Next
            Return s & " : " & fitness
        End Function
    End Structure
    Structure Population
        Dim taillePopulation As Integer
        Dim pop() As Individu
    End Structure
    Public Martiens As Population
    Function evaluerIndividu(ByVal i As Individu) As Integer
        Dim v As Integer
        v = 0
        For j = 0 To i.nbADN - 1
            If i.ADN(j) = True Then v = v + 1
        Next
        Return v
    End Function
    Function GenererIndividu() As Individu
        Dim indi As Individu
        indi.nbADN = 50
        indi.fitness = -1
        ReDim indi.ADN(indi.nbADN - 1)
        For i = 0 To indi.nbADN - 1
            Dim r As Double = Rnd()
            If r >= 0.5 Then
                indi.ADN(i) = True
            Else : indi.ADN(i) = False
            End If
        Next
        indi.fitness = evaluerIndividu(indi)
        Return indi
    End Function
    Sub trier(p As Population)
        Dim sorted As Boolean
        sorted = False
        Dim tmp As Individu
        While sorted = False
            sorted = True
            For i = 0 To p.taillePopulation - 2
                If p.pop(i).fitness > p.pop(i + 1).fitness Then
                    tmp = p.pop(i)
                    p.pop(i) = p.pop(i + 1)
                    p.pop(i + 1) = tmp
                    sorted = False
                End If
            Next
        End While
    End Sub
    Sub genererPopulation(ByVal p As Population)
        Martiens.taillePopulation = taillePop
        ReDim Martiens.pop(Martiens.taillePopulation - 1)
        For i = 0 To taillePop - 1
            Martiens.pop(i) = GenererIndividu() : Martiens.pop(i).fitness = evaluerIndividu(Martiens.pop(i))
        Next
        trier(Martiens)
    End Sub
    Sub muter(ByVal i As Individu)
        Dim q As Double = 0
        For j = 0 To 49
            q = Rnd()
            If q < 0.02 Then
                If i.ADN(j) = True Then i.ADN(j) = False Else i.ADN(j) = True
            End If
        Next
    End Sub
    Function selectionnerPaire(ByVal p As Population) As Individu()
        Dim proba As Double = 0
        For i = 0 To p.taillePopulation - 1
            proba = proba + p.pop(i).fitness
        Next
        proba = 1 / proba
        Dim vProba As Double() : ReDim vProba(p.taillePopulation - 1)
        For i = 0 To p.taillePopulation - 1
            vProba(i) = p.pop(i).fitness * proba
        Next
        For i = 1 To p.taillePopulation - 1
            vProba(i) = vProba(i) + vProba(i - 1)
        Next
        Dim q As Double = 0
        Dim r As Double = 0
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0
        While index1 = index2
            q = Rnd() : r = Rnd() : index1 = 0 : index2 = 0
            For i = 0 To p.taillePopulation - 1
                If q > vProba(i) Then index1 = index1 + 1
                If r > vProba(i) Then index2 = index2 + 1
            Next
        End While

        Dim sujets As Individu() : ReDim sujets(1)
        sujets(0) = p.pop(index1) : sujets(1) = p.pop(index2)
        Return sujets
    End Function
    Function croiser(ByVal sujets As Individu()) As Individu()
        Dim enfantUn As Individu
        ReDim enfantUn.ADN(49)
        enfantUn.nbADN = 50
        Dim enfantDeux As Individu
        ReDim enfantDeux.ADN(49)
        enfantDeux.nbADN = 50



        Dim r As Double = Rnd()
        Dim index As Integer
        Dim q As Double = Rnd()
        If q > 0.1 Then
            index = 0
        Else
            index = Math.Floor(r * 50)
        End If
        For i = 0 To index
            enfantUn.ADN(i) = sujets(0).ADN(i)
            enfantDeux.ADN(i) = sujets(1).ADN(i)
        Next
        For i = index + 1 To 49
            enfantUn.ADN(i) = sujets(1).ADN(i)
            enfantDeux.ADN(i) = sujets(0).ADN(i)
        Next





        enfantUn.fitness = evaluerIndividu(enfantUn)

        enfantDeux.fitness = evaluerIndividu(enfantDeux)

        Dim bestParentClone As Individu
        Dim bestParent As Individu
        If sujets(0).fitness >= sujets(1).fitness Then bestParent = sujets(0) Else bestParent = sujets(1)

        ReDim bestParentClone.ADN(49)
        bestParentClone.nbADN = 50
        For i = 0 To 49
            bestParentClone.ADN(i) = bestParent.ADN(i)
        Next
        bestParentClone.fitness = evaluerIndividu(bestParentClone)

        Dim indi As Individu
        If enfantUn.fitness >= enfantDeux.fitness Then indi = enfantUn Else indi = enfantDeux


        Dim enfants As Individu() : ReDim enfants(1)
        enfants(0) = bestParentClone
        enfants(1) = indi

        Return enfants
    End Function
End Module
