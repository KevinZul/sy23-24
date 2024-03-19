Public Class Form1
    Dim Cs As New Coinslot
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cs.total >= 1 Then
            R11.spin()
            R12.spin()
            R13.spin()
            Cs.spin()
            Label4.Text = Cs.total.ToString("C2")
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = R11.ItemValue
        Label2.Text = R12.ItemValue
        Label3.Text = R13.ItemValue
        Timer1.Enabled = False
        If R11.ItemValue = R12.ItemValue And R12.ItemValue = R13.ItemValue Then
            Me.BackColor = Color.Gold
            Cs.insertdollars()
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Cs.insertdollars()
        Label4.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Cs.insertquarter()
        Label4.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Cs.insertdimes()
        Label4.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Cs.insertnickels()
        Label4.Text = Cs.total.ToString("C2")
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Cs.coinreturn()
        Label4.Text = Cs.total.ToString("C2")
    End Sub
End Class