Imports System.Net.Security
Imports System.Reflection.Emit

Public Class Form1
    Dim WithEvents Cs As New CoinSlot
    Private Sub Cs_coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles Cs.coinreturnevent
        If d > 0 Then
            DollarsReturn.Visible = True
        Else
            DollarsReturn.Visible = False
        End If
        If d > 0 Then
            QuarterReturn.Visible = True
        Else
            QuarterReturn.Visible = False
        End If
        If d > 0 Then
            DimesReturn.Visible = True
        Else
            DimesReturn.Visible = False
        End If
        If d > 0 Then
            NickelReturn.Visible = True
        Else
            NickelReturn.Visible = False
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox1.Text
            Case A1.ProductId
                Cs.Buy(A1)
            Case A3.ProductId
                Cs.Buy(A3)
            Case A5.ProductId
                Cs.Buy(A5)
            Case B1.ProductId
                Cs.Buy(B1)
            Case B3.ProductId
                Cs.Buy(B3)
            Case B5.ProductId
                Cs.Buy(B5)
            Case C1.ProductId
                Cs.Buy(C1)
            Case C3.ProductId
                Cs.Buy(C3)
            Case C5.ProductId
                Cs.Buy(C5)
            Case D1.ProductId
                Cs.Buy(D1)
            Case D3.ProductId
                Cs.Buy(D3)
            Case D5.ProductId
                Cs.Buy(D5)
            Case E1.ProductId
                Cs.Buy(E1)
            Case E3.ProductId
                Cs.Buy(E3)
            Case E5.ProductId
                Cs.Buy(E5)
            Case F1.ProductId
                Cs.Buy(F1)
            Case Else

        End Select
        Label1.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Cs_dispense(p As Image) Handles Cs.dispense
        ProductPictureBox.Image = p
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cs.insertdollars()
        Label1.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Cs.insertquarter()
        Label1.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Cs.insertdimes()
        Label1.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Cs.insertnickels()
        Label1.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Cs.coinreturn()
        Label1.Text = Cs.total.ToString("C2")
    End Sub
End Class
