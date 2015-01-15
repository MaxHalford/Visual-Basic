Public Class Form1
    Structure Complexe
        Dim a As Integer
        Dim b As Integer
    End Structure
    Dim TailleM As Integer
    Dim M(TailleM) As Double
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        TailleM = Label1.Text


        Dim a As Double
        a = TextBox2.Text
        Dim b As Double
        b = TextBox3.Text
        Dim c As Complexe
        c.a = a
        c.b = b

        M(TailleM) = (c.a ^ 2 + c.b ^ 2) * (1 / 2)

        Dim sorted As Boolean
        sorted = False
        Dim tmp As Double
        If TailleM > 0 Then
            While sorted = False
                sorted = True
                For i = 0 To TailleM
                    If M(i) > M(i + 1) Then
                        tmp = M(i + 1)
                        M(i + 1) = M(i)
                        M(i) = tmp
                        sorted = False
                    End If
                Next
            End While
        End If

        Label1.Text = Label1.Text + 1





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim n As Integer
        n = TextBox4.Text
        n = n + 1
        TextBox4.Text = n
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim n As Integer

        n = TextBox4.Text
        If n = 0 Then MsgBox("On ne peut pas avoir un nombre negatif de valeurs!") : n = n + 1
        n = n - 1
        TextBox4.Text = n

    End Sub
End Class
