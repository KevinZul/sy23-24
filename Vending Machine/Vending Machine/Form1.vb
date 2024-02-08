Imports System.Reflection.Emit

Public Class Form1
    Dim Cs As New CoinSlot
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cs.insertquarter()
        Label1.Text = Cs.total
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cs.insertdimes()
        Label1.Text = Cs.total
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cs.insertnickels()
        Label1.Text = Cs.total
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cs.insertdollars()
        Label1.Text = Cs.total
    End Sub

End Class
