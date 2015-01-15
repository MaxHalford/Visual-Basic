Module Module1
    Public Structure Coordonnees
        Dim x As Double
        Dim y As Double
    End Structure
    Public Structure Station
        Dim nom As String
        Dim position As Coordonnees
    End Structure
    Public Structure Ligne
        Dim nom As String
        Dim station() As Station
        Dim numeroligne As Integer
        Dim nbStations As Integer
    End Structure
    Public r(5) As Ligne
    Public nbLignes As Integer
    Public Depart As Station
    Public Arrivee As Station
End Module
