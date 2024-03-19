<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picplayer = New System.Windows.Forms.PictureBox()
        Me.picground = New System.Windows.Forms.PictureBox()
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgamelogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrgravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.WinPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.picair = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Points = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Coin1 = New System.Windows.Forms.PictureBox()
        Me.Coin2 = New System.Windows.Forms.PictureBox()
        Me.Coin4 = New System.Windows.Forms.PictureBox()
        Me.Coin3 = New System.Windows.Forms.PictureBox()
        Me.Mover8 = New platformer.Mover()
        Me.Mover7 = New platformer.Mover()
        Me.Mover6 = New platformer.Mover()
        Me.Mover5 = New platformer.Mover()
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coin3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picplayer
        '
        Me.picplayer.BackColor = System.Drawing.Color.Teal
        Me.picplayer.Location = New System.Drawing.Point(12, 353)
        Me.picplayer.Name = "picplayer"
        Me.picplayer.Size = New System.Drawing.Size(38, 39)
        Me.picplayer.TabIndex = 0
        Me.picplayer.TabStop = False
        '
        'picground
        '
        Me.picground.BackColor = System.Drawing.Color.Green
        Me.picground.Location = New System.Drawing.Point(0, 398)
        Me.picground.Name = "picground"
        Me.picground.Size = New System.Drawing.Size(800, 50)
        Me.picground.TabIndex = 2
        Me.picground.TabStop = False
        '
        'tmrright
        '
        Me.tmrright.Interval = 30
        '
        'tmrleft
        '
        Me.tmrleft.Interval = 30
        '
        'tmrup
        '
        Me.tmrup.Interval = 30
        '
        'tmrgamelogic
        '
        '
        'tmrgravity
        '
        Me.tmrgravity.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(-14956, -15313)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 46)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "bound"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox2.Location = New System.Drawing.Point(496, 229)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(153, 11)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox3.Location = New System.Drawing.Point(108, 160)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 198)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Black
        Me.PictureBox4.Location = New System.Drawing.Point(483, 287)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(156, 21)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(82, 61)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(119, 27)
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "bound"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox7.Location = New System.Drawing.Point(651, 46)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 131)
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "bound"
        '
        'WinPictureBox
        '
        Me.WinPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.WinPictureBox.Location = New System.Drawing.Point(720, 80)
        Me.WinPictureBox.Name = "WinPictureBox"
        Me.WinPictureBox.Size = New System.Drawing.Size(45, 42)
        Me.WinPictureBox.TabIndex = 7
        Me.WinPictureBox.TabStop = False
        Me.WinPictureBox.Tag = "win"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(969, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(31, 22)
        Me.TextBox1.TabIndex = 11
        '
        'picair
        '
        Me.picair.BackgroundImage = Global.platformer.My.Resources.Resources.Capture
        Me.picair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picair.Location = New System.Drawing.Point(1, -7)
        Me.picair.Name = "picair"
        Me.picair.Size = New System.Drawing.Size(800, 399)
        Me.picair.TabIndex = 13
        Me.picair.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Black
        Me.PictureBox5.Location = New System.Drawing.Point(3993, 3965)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(102, 33)
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "bound"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.IndianRed
        Me.PictureBox8.Location = New System.Drawing.Point(266, 248)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox8.TabIndex = 15
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "bound"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Black
        Me.PictureBox10.Location = New System.Drawing.Point(262, 331)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(157, 31)
        Me.PictureBox10.TabIndex = 17
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Tag = "bound"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Black
        Me.PictureBox9.Location = New System.Drawing.Point(668, 241)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(60, 25)
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "bound"
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Black
        Me.PictureBox11.Location = New System.Drawing.Point(262, 121)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(108, 10)
        Me.PictureBox11.TabIndex = 19
        Me.PictureBox11.TabStop = False
        Me.PictureBox11.Tag = "bound"
        '
        'Points
        '
        Me.Points.AutoSize = True
        Me.Points.Location = New System.Drawing.Point(13, 13)
        Me.Points.Name = "Points"
        Me.Points.Size = New System.Drawing.Size(47, 16)
        Me.Points.TabIndex = 24
        Me.Points.Text = "Points:"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Location = New System.Drawing.Point(82, 13)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(48, 16)
        Me.ScoreLabel.TabIndex = 25
        Me.ScoreLabel.Text = "Label2"
        '
        'Coin1
        '
        Me.Coin1.Image = Global.platformer.My.Resources.Resources.images__3_
        Me.Coin1.Location = New System.Drawing.Point(318, 36)
        Me.Coin1.Name = "Coin1"
        Me.Coin1.Size = New System.Drawing.Size(34, 31)
        Me.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin1.TabIndex = 26
        Me.Coin1.TabStop = False
        Me.Coin1.Tag = "coin"
        '
        'Coin2
        '
        Me.Coin2.Image = Global.platformer.My.Resources.Resources.images__3_
        Me.Coin2.Location = New System.Drawing.Point(27, 46)
        Me.Coin2.Name = "Coin2"
        Me.Coin2.Size = New System.Drawing.Size(34, 31)
        Me.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin2.TabIndex = 27
        Me.Coin2.TabStop = False
        Me.Coin2.Tag = "coin"
        '
        'Coin4
        '
        Me.Coin4.Image = Global.platformer.My.Resources.Resources.images__3_
        Me.Coin4.Location = New System.Drawing.Point(615, 344)
        Me.Coin4.Name = "Coin4"
        Me.Coin4.Size = New System.Drawing.Size(34, 31)
        Me.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin4.TabIndex = 28
        Me.Coin4.TabStop = False
        Me.Coin4.Tag = "coin"
        '
        'Coin3
        '
        Me.Coin3.Image = Global.platformer.My.Resources.Resources.images__3_
        Me.Coin3.Location = New System.Drawing.Point(158, 353)
        Me.Coin3.Name = "Coin3"
        Me.Coin3.Size = New System.Drawing.Size(34, 31)
        Me.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Coin3.TabIndex = 29
        Me.Coin3.TabStop = False
        Me.Coin3.Tag = "coin"
        '
        'Mover8
        '
        Me.Mover8.BackColor = System.Drawing.Color.Transparent
        Me.Mover8.interval = 100
        Me.Mover8.Location = New System.Drawing.Point(486, 209)
        Me.Mover8.Name = "Mover8"
        Me.Mover8.Size = New System.Drawing.Size(15, 15)
        Me.Mover8.speed = 10
        Me.Mover8.sprite = Me.PictureBox2
        Me.Mover8.TabIndex = 23
        '
        'Mover7
        '
        Me.Mover7.BackColor = System.Drawing.Color.Transparent
        Me.Mover7.interval = 100
        Me.Mover7.Location = New System.Drawing.Point(631, 36)
        Me.Mover7.Name = "Mover7"
        Me.Mover7.Size = New System.Drawing.Size(18, 17)
        Me.Mover7.speed = 10
        Me.Mover7.sprite = Me.PictureBox7
        Me.Mover7.TabIndex = 22
        '
        'Mover6
        '
        Me.Mover6.BackColor = System.Drawing.Color.Transparent
        Me.Mover6.interval = 100
        Me.Mover6.Location = New System.Drawing.Point(108, 170)
        Me.Mover6.Name = "Mover6"
        Me.Mover6.Size = New System.Drawing.Size(11, 20)
        Me.Mover6.speed = 10
        Me.Mover6.sprite = Me.PictureBox3
        Me.Mover6.TabIndex = 21
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 100
        Me.Mover5.Location = New System.Drawing.Point(256, 258)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(16, 20)
        Me.Mover5.speed = 10
        Me.Mover5.sprite = Me.PictureBox8
        Me.Mover5.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 450)
        Me.Controls.Add(Me.Coin3)
        Me.Controls.Add(Me.Coin4)
        Me.Controls.Add(Me.Coin2)
        Me.Controls.Add(Me.Coin1)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Points)
        Me.Controls.Add(Me.Mover8)
        Me.Controls.Add(Me.Mover7)
        Me.Controls.Add(Me.Mover6)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.WinPictureBox)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picground)
        Me.Controls.Add(Me.picplayer)
        Me.Controls.Add(Me.picair)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coin3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picplayer As PictureBox
    Friend WithEvents picground As PictureBox
    Friend WithEvents tmrright As Timer
    Friend WithEvents tmrleft As Timer
    Friend WithEvents tmrup As Timer
    Friend WithEvents tmrgamelogic As Timer
    Friend WithEvents tmrgravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Mover1 As mover
    Friend WithEvents WinPictureBox As PictureBox
    Friend WithEvents Mover2 As mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Mover3 As mover
    Friend WithEvents picair As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Mover5 As Mover
    Friend WithEvents Mover6 As Mover
    Friend WithEvents Mover7 As Mover
    Friend WithEvents Mover8 As Mover
    Friend WithEvents Points As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Coin1 As PictureBox
    Friend WithEvents Coin2 As PictureBox
    Friend WithEvents Coin4 As PictureBox
    Friend WithEvents Coin3 As PictureBox
End Class
