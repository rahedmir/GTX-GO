<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gtx_go
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gtx_go))
        Me.Mover = New System.Windows.Forms.Timer(Me.components)
        Me.left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.car_1_mover = New System.Windows.Forms.Timer(Me.components)
        Me.car_2_mover = New System.Windows.Forms.Timer(Me.components)
        Me.car_3_mover = New System.Windows.Forms.Timer(Me.components)
        Me.game_over = New System.Windows.Forms.Label()
        Me.car_3 = New System.Windows.Forms.PictureBox()
        Me.car_2 = New System.Windows.Forms.PictureBox()
        Me.car_1 = New System.Windows.Forms.PictureBox()
        Me.mycar = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.score_text = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.lblRestart = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        CType(Me.car_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mycar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Mover
        '
        Me.Mover.Interval = 10
        '
        'left_mover
        '
        Me.left_mover.Interval = 10
        '
        'right_mover
        '
        Me.right_mover.Interval = 10
        '
        'car_1_mover
        '
        Me.car_1_mover.Interval = 10
        '
        'car_2_mover
        '
        Me.car_2_mover.Interval = 10
        '
        'car_3_mover
        '
        Me.car_3_mover.Interval = 10
        '
        'game_over
        '
        Me.game_over.BackColor = System.Drawing.Color.White
        Me.game_over.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.game_over.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.game_over.ForeColor = System.Drawing.Color.Red
        Me.game_over.Location = New System.Drawing.Point(47, 181)
        Me.game_over.Name = "game_over"
        Me.game_over.Size = New System.Drawing.Size(255, 50)
        Me.game_over.TabIndex = 50
        Me.game_over.Text = "Game Over"
        Me.game_over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.game_over.Visible = False
        '
        'car_3
        '
        Me.car_3.Image = CType(resources.GetObject("car_3.Image"), System.Drawing.Image)
        Me.car_3.Location = New System.Drawing.Point(12, 41)
        Me.car_3.Name = "car_3"
        Me.car_3.Size = New System.Drawing.Size(50, 100)
        Me.car_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car_3.TabIndex = 47
        Me.car_3.TabStop = False
        '
        'car_2
        '
        Me.car_2.Image = CType(resources.GetObject("car_2.Image"), System.Drawing.Image)
        Me.car_2.Location = New System.Drawing.Point(293, 78)
        Me.car_2.Name = "car_2"
        Me.car_2.Size = New System.Drawing.Size(50, 100)
        Me.car_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car_2.TabIndex = 49
        Me.car_2.TabStop = False
        '
        'car_1
        '
        Me.car_1.Image = CType(resources.GetObject("car_1.Image"), System.Drawing.Image)
        Me.car_1.Location = New System.Drawing.Point(148, 315)
        Me.car_1.Name = "car_1"
        Me.car_1.Size = New System.Drawing.Size(50, 100)
        Me.car_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.car_1.TabIndex = 48
        Me.car_1.TabStop = False
        '
        'mycar
        '
        Me.mycar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.mycar.Image = CType(resources.GetObject("mycar.Image"), System.Drawing.Image)
        Me.mycar.Location = New System.Drawing.Point(12, 443)
        Me.mycar.Name = "mycar"
        Me.mycar.Size = New System.Drawing.Size(50, 100)
        Me.mycar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mycar.TabIndex = 46
        Me.mycar.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.White
        Me.PictureBox9.Location = New System.Drawing.Point(230, 634)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox9.TabIndex = 45
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.White
        Me.PictureBox10.Location = New System.Drawing.Point(110, 634)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox10.TabIndex = 44
        Me.PictureBox10.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(229, 443)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox7.TabIndex = 43
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(109, 443)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox8.TabIndex = 42
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(230, 305)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox5.TabIndex = 41
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(110, 305)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox6.TabIndex = 40
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(230, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(110, 170)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox4.TabIndex = 38
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(229, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(109, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(4, 87)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'score_text
        '
        Me.score_text.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_text.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.score_text.Location = New System.Drawing.Point(7, 4)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(92, 29)
        Me.score_text.TabIndex = 32
        Me.score_text.Text = "Score"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblPlay)
        Me.Panel1.Controls.Add(Me.lblPause)
        Me.Panel1.Controls.Add(Me.lblRestart)
        Me.Panel1.Controls.Add(Me.score_text)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 38)
        Me.Panel1.TabIndex = 51
        Me.Panel1.TabStop = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(99, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 29)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "0"
        '
        'lblPlay
        '
        Me.lblPlay.BackColor = System.Drawing.Color.White
        Me.lblPlay.Enabled = False
        Me.lblPlay.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPlay.Image = CType(resources.GetObject("lblPlay.Image"), System.Drawing.Image)
        Me.lblPlay.Location = New System.Drawing.Point(244, 2)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(33, 33)
        Me.lblPlay.TabIndex = 53
        '
        'lblPause
        '
        Me.lblPause.BackColor = System.Drawing.Color.White
        Me.lblPause.Enabled = False
        Me.lblPause.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPause.Image = CType(resources.GetObject("lblPause.Image"), System.Drawing.Image)
        Me.lblPause.Location = New System.Drawing.Point(283, 2)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(32, 33)
        Me.lblPause.TabIndex = 53
        '
        'lblRestart
        '
        Me.lblRestart.BackColor = System.Drawing.Color.White
        Me.lblRestart.Enabled = False
        Me.lblRestart.Font = New System.Drawing.Font("Broadway", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRestart.Image = CType(resources.GetObject("lblRestart.Image"), System.Drawing.Image)
        Me.lblRestart.Location = New System.Drawing.Point(319, 3)
        Me.lblRestart.Name = "lblRestart"
        Me.lblRestart.Size = New System.Drawing.Size(36, 33)
        Me.lblRestart.TabIndex = 52
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.Color.White
        Me.lblStart.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.Green
        Me.lblStart.Location = New System.Drawing.Point(96, 231)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(154, 50)
        Me.lblStart.TabIndex = 52
        Me.lblStart.Text = "Start"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblTimer.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTimer.Location = New System.Drawing.Point(133, 119)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(82, 59)
        Me.lblTimer.TabIndex = 53
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTimer.Visible = False
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYellow.Enabled = False
        Me.lblYellow.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYellow.ForeColor = System.Drawing.Color.Green
        Me.lblYellow.Location = New System.Drawing.Point(288, 44)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(25, 20)
        Me.lblYellow.TabIndex = 54
        Me.lblYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblYellow.Visible = False
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Lime
        Me.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreen.Enabled = False
        Me.lblGreen.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.ForeColor = System.Drawing.Color.Green
        Me.lblGreen.Location = New System.Drawing.Point(318, 44)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(25, 20)
        Me.lblGreen.TabIndex = 55
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGreen.Visible = False
        '
        'lblRed
        '
        Me.lblRed.BackColor = System.Drawing.Color.Red
        Me.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRed.Enabled = False
        Me.lblRed.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(257, 44)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(25, 20)
        Me.lblRed.TabIndex = 56
        Me.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRed.Visible = False
        '
        'gtx_go
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(357, 545)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblYellow)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.game_over)
        Me.Controls.Add(Me.mycar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.car_3)
        Me.Controls.Add(Me.car_2)
        Me.Controls.Add(Me.car_1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "gtx_go"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GTX GO"
        CType(Me.car_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mycar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Mover As System.Windows.Forms.Timer
    Friend WithEvents left_mover As System.Windows.Forms.Timer
    Friend WithEvents right_mover As System.Windows.Forms.Timer
    Friend WithEvents car_1_mover As System.Windows.Forms.Timer
    Friend WithEvents car_2_mover As System.Windows.Forms.Timer
    Friend WithEvents car_3_mover As System.Windows.Forms.Timer
    Friend WithEvents game_over As System.Windows.Forms.Label
    Friend WithEvents car_3 As System.Windows.Forms.PictureBox
    Friend WithEvents car_2 As System.Windows.Forms.PictureBox
    Friend WithEvents car_1 As System.Windows.Forms.PictureBox
    Friend WithEvents mycar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents score_text As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblPlay As System.Windows.Forms.Label
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents lblRestart As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblYellow As System.Windows.Forms.Label
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label

End Class
