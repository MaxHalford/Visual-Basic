Module Fonctions_géométriques

    Function SurfaceSphère(ByVal x As Double) As Double
        Return 4 * Math.PI * x ^ 2
    End Function
    Function SurfaceCône(ByVal x As Double, ByVal y As Double) As Double
        Return x * Math.PI * Math.Sqrt(x ^ 2 + y ^ 2)
    End Function
    Function SurfaceCube(ByVal x As Double) As Double
        Return 6 * x ^ 2
    End Function
    Function SurfaceCylindre(ByVal x As Double, ByVal y As Double) As Double
        Return 2 * Math.PI * x * y
    End Function
    Function VolumeSphère(ByVal x As Double) As Double
        Return 4 / 3 * Math.PI * x ^ 3
    End Function
    Function VolumeCône(ByVal x As Double, ByVal y As Double) As Double
        Return 1 / 3 * x ^ 2 * Math.PI * y
    End Function
    Function VolumeCube(ByVal x As Double) As Double
        Return x ^ 3
    End Function
    Function VolumeCylindre(ByVal x As Double, ByVal y As Double) As Double
        Return Math.PI * x ^ 2 * y
    End Function
End Module
