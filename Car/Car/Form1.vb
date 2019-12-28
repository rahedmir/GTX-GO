Public Class gtx_go

    Dim line(9) As PictureBox
    Dim score As Integer = 0
    Dim speed As Integer = 0
    Dim time As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        line(0) = PictureBox1
        line(1) = PictureBox2
        line(2) = PictureBox3
        line(3) = PictureBox4
        line(4) = PictureBox5
        line(5) = PictureBox6
        line(6) = PictureBox7
        line(7) = PictureBox8
        line(8) = PictureBox9
        line(9) = PictureBox10
        

    End Sub
    Private Sub gtx_go_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.R Then
            right_mover.Start()
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.W Then
            left_mover.Start()
        End If
    End Sub
   
    Private Sub Mover_Tick(sender As Object, e As EventArgs) Handles Mover.Tick
        For i As Integer = 0 To 9
            line(i).Top += 2
            If line(i).Top >= Me.Height Then
                line(i).Top = -line(i).Height
            End If
        Next
        If (mycar.Bounds.IntersectsWith(car_1.Bounds)) Then

            mycar.BackColor = Color.Red
            car_1.BackColor = Color.Red
            game()
        End If
        If (mycar.Bounds.IntersectsWith(car_2.Bounds)) Then
            mycar.BackColor = Color.Red
            car_2.BackColor = Color.Red
            game()
        End If
        If (mycar.Bounds.IntersectsWith(car_3.Bounds)) Then

            mycar.BackColor = Color.Red
            car_3.BackColor = Color.Red
            game()
        End If
    End Sub

   

    Private Sub left_mover_Tick(sender As Object, e As EventArgs) Handles left_mover.Tick
        If mycar.Location.X >= 4 Then
            If speed = 1 Then
                left_mover.Stop()
            Else
                mycar.Left -= 5
            End If

        End If
    End Sub

    Private Sub right_mover_Tick(sender As Object, e As EventArgs) Handles right_mover.Tick
        If mycar.Location.X <= 306 Then
            If speed = 1 Then
                right_mover.Stop()
            Else
                mycar.Left += 5
            End If

        End If

    End Sub

    Private Sub gtx_go_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        left_mover.Stop()
        right_mover.Stop()
    End Sub

    Private Sub car_1_mover_Tick(sender As Object, e As EventArgs) Handles car_1_mover.Tick
        car_1.Top += 6.9
        If car_1.Top >= Me.Height Then
            score += 10
            Label1.Text = score
            car_1.Top = -car_1.Height
            car_1.Left = -(CInt(Math.Ceiling(Rnd() * -45)) + -210)
        End If
    End Sub

    Private Sub car_2_mover_Tick(sender As Object, e As EventArgs) Handles car_2_mover.Tick
        car_2.Top += 6.9
        If car_2.Top >= Me.Height Then
            score += 10
            Label1.Text = score
            car_2.Top = -car_2.Height
            car_2.Left = -(CInt(Math.Ceiling(Rnd() * -201)) + -69)
        End If

    End Sub

    Private Sub car_3_mover_Tick(sender As Object, e As EventArgs) Handles car_3_mover.Tick
        car_3.Top += 6
        If car_3.Top >= Me.Height Then
            score += 10
            Label1.Text = score
            car_3.Top = -car_3.Height
            car_3.Left = -(CInt(Math.Ceiling(Rnd() * -9)) + 2)
        End If
    End Sub

    

    Private Sub game()
        Mover.Stop()
        car_1_mover.Stop()
        car_2_mover.Stop()
        car_3_mover.Stop()

        game_over.Show()
        speed = 1
        lblPause.Enabled = False
        lblPlay.Enabled = False
        lblRestart.Enabled = True

    End Sub

    
    Private Sub lblPlay_Click_1(sender As Object, e As EventArgs) Handles lblPlay.Click
        car_1_mover.Start()
        car_2_mover.Start()
        car_3_mover.Start()
        Mover.Start()
        lblPause.Enabled = True
        lblPlay.Enabled = False
        lblStart.Hide()
    End Sub

    Private Sub lblPause_Click(sender As Object, e As EventArgs) Handles lblPause.Click
        car_1_mover.Stop()
        car_2_mover.Stop()
        car_3_mover.Stop()
        Mover.Stop()
        lblPause.Enabled = False
        lblPlay.Enabled = True
        lblStart.Hide()
    End Sub

    Private Sub lblRestart_Click(sender As Object, e As EventArgs) Handles lblRestart.Click
        time = 0
        speed = 0
        score = 0
        score_text.Text = 0

        Me.Controls.Clear()

        InitializeComponent()

        Form1_Load(e, e)
        lblPlay.Enabled = False

       
        lblStart.Hide()
        Timer1.Start()
        lblTimer.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblStart.Click

       
        lblStart.Hide()
        Timer1.Start()
        lblTimer.Visible = True
        lblPlay.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If lblTimer.Text = 4 Then
            lblPause.Enabled = True
            Timer1.Stop()
            lblTimer.Hide()
            car_1_mover.Start()
            car_2_mover.Start()
            car_3_mover.Start()
            Mover.Start()

        Else
            time = time + 1
            lblTimer.Text = time
            lblTimer.Show()
            car_1_mover.Stop()
            car_2_mover.Stop()
            car_3_mover.Stop()
            Mover.Stop()
            If lblTimer.Text = 1 Then
                lblRed.Visible = True
                lblGreen.Visible = False
                lblYellow.Visible = False
            End If
            If lblTimer.Text = 2 Then
                lblRed.Visible = False
                lblGreen.Visible = False
                lblYellow.Visible = True
            End If
            If lblTimer.Text = 3 Then
                lblRed.Visible = False
                lblGreen.Visible = True
                lblYellow.Visible = False
            End If
            If lblTimer.Text = 4 Then
                lblRed.Visible = False
                lblGreen.Visible = False
                lblYellow.Visible = False
            End If
          
        End If
       
    End Sub
End Class

