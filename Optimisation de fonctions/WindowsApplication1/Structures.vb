Module Structures
    Public taillePop As Integer
    Public nbDimensions As Integer
    Structure Vecteur
        Dim coord() As Double
        Dim fitness As Double
    End Structure
    Structure Ensemble
        Dim vecteur() As Vecteur
        Dim nbVecteurs As Integer
    End Structure
    Public Ensemble1 As Ensemble
    Public Ensemble2 As Ensemble
End Module
