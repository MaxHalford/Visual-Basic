Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        taillePop = 50
        nbDimensions = 2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer = nbDimensions
        'Creation de l'ensemble
        Dim a As Integer = -5.12
        Dim b As Integer = 5.12
        Dim m As Integer = taillePop
        genererEnsemble1(a, b, n, m)
        Label3.Text = Ensemble1.vecteur(2).fitness
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n As Integer = nbDimensions
        'Creation de l'ensemble
        Dim a As Integer = -500
        Dim b As Integer = -500
        Dim m As Integer = taillePop
        genererEnsemble2(a, b, n, m)
        Label4.Text = Ensemble2.vecteur(2).fitness
    End Sub
End Class
