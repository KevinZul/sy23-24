Public Class Form1
    Dim movespeed As Integer = 10
    Dim isjumping As Boolean
    Dim coins As Integer = 0
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Start()
            Case Keys.Left
                tmrleft.Start()
            Case Keys.Up
                tmrup.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub tmrright_Tick(sender As Object, e As EventArgs) Handles tmrright.Tick
        picplayer.Left += movespeed
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrright.Stop()
            Case Keys.Left
                tmrleft.Stop()
            Case Keys.Up
                tmrup.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub tmrleft_Tick(sender As Object, e As EventArgs) Handles tmrleft.Tick
        picplayer.Left -= movespeed
    End Sub

    Private Sub tmrup_Tick(sender As Object, e As EventArgs) Handles tmrup.Tick
        picplayer.Top -= movespeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrgamelogic.Start()
        TextBox1.Select()
    End Sub

    Private Sub tmrgamelogic_Tick(sender As Object, e As EventArgs) Handles tmrgamelogic.Tick

        If picplayer.Bounds.IntersectsWith(picground.Bounds) Then
            tmrgravity.Stop()
        ElseIf picplayer.Bounds.IntersectsWith(picair.Bounds) Then
            If isjumping = False Then
                tmrgravity.Start()
            End If
        End If
            For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrgravity.Stop()
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        coins += 1
                        ScoreLabel.Text = coins
                    End If
                End If
                If b.Tag = "win" Then
                    If picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        WinPictureBox.Visible = False
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrgravity_Tick(sender As Object, e As EventArgs) Handles tmrgravity.Tick
        picplayer.Top += movespeed
    End Sub
End Class
