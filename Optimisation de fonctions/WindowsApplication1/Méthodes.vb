Module Méthodes

    Function Fonction1(ByVal n As Integer, ByVal x As Double()) As Double
        Dim y() As Double : ReDim y(n - 1)
        For i = 0 To n - 1
            y(i) = 10 * n + x(i) ^ 2 + 10 * Math.Cos(2 * Math.PI * x(i))
        Next
        Dim z As Double = 0
        For i = 0 To n - 1
            z = z + y(i)
        Next
        Return z
    End Function
    Function Fonction2(ByVal n As Integer, ByVal x As Double()) As Double
        Dim y() As Double : ReDim y(n - 1)
        For i = 0 To n - 1
            y(i) = -x(i) * Math.Sin(Math.Sqrt(Math.Abs(x(i))))
        Next
        Dim z As Double = 0
        For i = 0 To n - 1
            z = z + y(i)
        Next
        Return z
    End Function
    'Generer un vecteur de n dimensions, chaque coordonnee etant comprise entre a et b
    Function genererVecteur(ByVal a As Double, ByVal b As Double, ByVal n As Integer) As Vecteur
        Dim p As Vecteur
        Dim q As Double
        ReDim p.coord(n - 1)
        For i = 0 To n - 1
            p.coord(i) = Rnd() * b : q = Rnd() : If q < 0.5 Then p.coord(i) = p.coord(i) * -1
        Next
        Return p
    End Function
    'Generer un ensemble de m vecteurs de dimensions equivalentes
    Sub genererEnsemble1(ByVal a As Double, ByVal b As Double, ByVal n As Integer, ByVal m As Integer)
        Ensemble1.nbVecteurs = m
        ReDim Ensemble1.vecteur(m - 1)
        For i = 0 To m - 1
            Ensemble1.vecteur(i) = genererVecteur(a, b, n) : Ensemble1.vecteur(i).fitness = Fonction1(n, Ensemble1.vecteur(i).coord) : Ensemble1.vecteur(i).fitness = Ensemble1.vecteur(i).fitness * -1
        Next
    End Sub
    Sub genererEnsemble2(ByVal a As Double, ByVal b As Double, ByVal n As Integer, ByVal m As Integer)
        Ensemble2.nbVecteurs = m
        ReDim Ensemble2.vecteur(m - 1)
        For i = 0 To m - 1
            Ensemble2.vecteur(i) = genererVecteur(a, b, n) : Ensemble2.vecteur(i).fitness = Fonction2(n, Ensemble2.vecteur(i).coord) : Ensemble2.vecteur(i).fitness = Ensemble2.vecteur(i).fitness * -1
        Next
    End Sub
    Sub transformerFitness(ByVal vecteur As Double())
        For i = 0 To taillePop - 1
            If vecteur(i) < 0 Then vecteur(i) = vecteur(i) = vecteur(i) - 1
        Next
        For i = 0 To taillePop - 1
            If vecteur(i) < 0 Then vecteur(i) = 1 / vecteur(i)
        Next
        For i = 0 To taillePop - 1
            If vecteur(i) < 0 Then vecteur(i) = vecteur(i) * -1
        Next

    End Sub
    Function selectionnerPaire(ByVal ens As Ensemble) As Vecteur()

        Dim vFitness() As Double : ReDim vFitness(ens.nbVecteurs - 1)
        For i = 0 To ens.nbVecteurs - 1
            vFitness(i) = ens.vecteur(i).fitness
        Next
        transformerFitness(vFitness) 'On transforme les fitness, on va ensuite les sommer pour faire la roulette pipée
        Dim proba As Double
        For i = 0 To ens.nbVecteurs - 1
            proba = proba + vFitness(i)
        Next
        proba = 1 / proba
        Dim vProba As Double() : ReDim vProba(ens.nbVecteurs - 1)
        For i = 0 To ens.nbVecteurs - 1
            vProba(i) = proba * vFitness(i)
        Next
        For i = 1 To ens.nbVecteurs - 1
            vProba(i) = vProba(i) + vProba(i - 1)
        Next
        Dim sFitness As Integer = vProba(ens.nbVecteurs - 1)
        Dim index1 As Integer = 0
        Dim index2 As Integer = 0
        Dim q As Integer = 0
        Dim r As Integer = 0
        While index1 = index2
            q = Math.Floor(Rnd() * sFitness) : r = Math.Floor(Rnd() * sFitness) : index1 = 0 : index2 = 0
            For i = 0 To ens.nbVecteurs - 1
                If q > vFitness(i) Then index1 = index1 + 1
                If r > vFitness(i) Then index2 = index2 + 1
            Next
        End While
        Dim sujets As Vecteur() : ReDim sujets(1)
        sujets(0) = ens.vecteur(index1) : sujets(1) = ens.vecteur(index2)
        Return sujets
    End Function
    Function croiser(ByVal sujets As Vecteur()) As Vecteur()
        Dim enfantUn As Vecteur
        ReDim enfantUn.coord(nbDimensions)
        Dim enfantDeux As Vecteur
        ReDim enfantDeux.coord(nbDimensions)
        For i = 0 To nbDimensions - 1
            enfantUn.coord(i) = sujets(0).coord(i) : enfantDeux.coord(i) = sujets(1).coord(i)
        Next
        enfantUn.fitness = Fonction1(nbDimensions, enfantUn.coord)
        enfantDeux.fitness = Fonction2(nbDimensions, enfantDeux.coord)

        Dim enfants As Vecteur() : ReDim enfants(1)
        Dim a As Integer
        Dim b As Integer
        If enfantUn.fitness > enfantDeux.fitness Then enfants(0) = enfantUn : a = 0 : b = 1 Else enfants(1) = enfantDeux : a = 0 : b = 1 'On assigne le meilleur parent

        For i = 0 To nbDimensions - 1
            Dim p As Double = Rnd()
            enfantUn.coord(i) = sujets(a).coord(i) + p * (sujets(a).coord(i) - sujets(b).coord(i))
        Next




















        Return enfants
    End Function
End Module
