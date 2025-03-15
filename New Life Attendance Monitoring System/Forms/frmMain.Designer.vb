<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblAttendCount = New System.Windows.Forms.Label()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tmTimeDate = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoginError = New System.Windows.Forms.Label()
        Me.lblFinger = New System.Windows.Forms.Label()
        Me.tmClear = New System.Windows.Forms.Timer(Me.components)
        Me.btnBioLogin = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblFingerError = New System.Windows.Forms.Label()
        Me.tmSundaySched = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(1237, 31)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(128, 92)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(1011, 75)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(215, 23)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.PictureBox1.Image = Global.New_Life_Attendance_Monitoring_System.My.Resources.Resources.NLCF_SEAL
        Me.PictureBox1.Location = New System.Drawing.Point(124, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 342)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(868, 251)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(265, 29)
        Me.lblName.TabIndex = 15
        Me.lblName.Text = "                                          "
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(868, 315)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(222, 25)
        Me.lblCategory.TabIndex = 16
        Me.lblCategory.Text = "                                          "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(868, 369)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(222, 25)
        Me.lblStatus.TabIndex = 17
        Me.lblStatus.Text = "                                          "
        '
        'lblAttendCount
        '
        Me.lblAttendCount.AutoSize = True
        Me.lblAttendCount.BackColor = System.Drawing.Color.Transparent
        Me.lblAttendCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblAttendCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblAttendCount.Location = New System.Drawing.Point(1066, 686)
        Me.lblAttendCount.Name = "lblAttendCount"
        Me.lblAttendCount.Size = New System.Drawing.Size(112, 31)
        Me.lblAttendCount.TabIndex = 19
        Me.lblAttendCount.Text = "              "
        '
        'btnSignup
        '
        Me.btnSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSignup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSignup.FlatAppearance.BorderSize = 0
        Me.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignup.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.Location = New System.Drawing.Point(905, 128)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(127, 23)
        Me.btnSignup.TabIndex = 3
        Me.btnSignup.Text = "Signup"
        Me.btnSignup.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Candara", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(141, 684)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(429, 33)
        Me.lblWelcome.TabIndex = 21
        Me.lblWelcome.Text = "                                                                     "
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Calibri Light", 80.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(495, 430)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(446, 131)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = "7:30 A.M"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Calibri Light", 45.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(501, 552)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(637, 73)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "Friday, February 17, 2017"
        '
        'tmTimeDate
        '
        Me.tmTimeDate.Interval = 1000
        '
        'lblLoginError
        '
        Me.lblLoginError.AutoSize = True
        Me.lblLoginError.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginError.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginError.ForeColor = System.Drawing.Color.Red
        Me.lblLoginError.Location = New System.Drawing.Point(1117, 129)
        Me.lblLoginError.Name = "lblLoginError"
        Me.lblLoginError.Size = New System.Drawing.Size(109, 19)
        Me.lblLoginError.TabIndex = 24
        Me.lblLoginError.Text = "                         "
        '
        'lblFinger
        '
        Me.lblFinger.AutoSize = True
        Me.lblFinger.BackColor = System.Drawing.Color.Transparent
        Me.lblFinger.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinger.ForeColor = System.Drawing.Color.Red
        Me.lblFinger.Location = New System.Drawing.Point(541, 411)
        Me.lblFinger.Name = "lblFinger"
        Me.lblFinger.Size = New System.Drawing.Size(109, 19)
        Me.lblFinger.TabIndex = 26
        Me.lblFinger.Text = "                         "
        '
        'tmClear
        '
        Me.tmClear.Interval = 1000
        '
        'btnBioLogin
        '
        Me.btnBioLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBioLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnBioLogin.FlatAppearance.BorderSize = 0
        Me.btnBioLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnBioLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBioLogin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBioLogin.ForeColor = System.Drawing.Color.White
        Me.btnBioLogin.Location = New System.Drawing.Point(774, 128)
        Me.btnBioLogin.Name = "btnBioLogin"
        Me.btnBioLogin.Size = New System.Drawing.Size(128, 23)
        Me.btnBioLogin.TabIndex = 27
        Me.btnBioLogin.Text = "Bio Login"
        Me.btnBioLogin.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(505, 413)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(183, 20)
        Me.txtID.TabIndex = 28
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(762, 75)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(215, 23)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri Light", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(715, 684)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 33)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Today's Number of Attendees :"
        '
        'Picture
        '
        Me.Picture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Picture.BackColor = System.Drawing.SystemColors.Window
        Me.Picture.Location = New System.Drawing.Point(514, 236)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(165, 158)
        Me.Picture.TabIndex = 30
        Me.Picture.TabStop = False
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtUserID.ForeColor = System.Drawing.Color.White
        Me.txtUserID.Location = New System.Drawing.Point(228, 600)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(242, 38)
        Me.txtUserID.TabIndex = 31
        '
        'lblFingerError
        '
        Me.lblFingerError.AutoSize = True
        Me.lblFingerError.BackColor = System.Drawing.Color.Transparent
        Me.lblFingerError.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFingerError.ForeColor = System.Drawing.Color.Red
        Me.lblFingerError.Location = New System.Drawing.Point(529, 205)
        Me.lblFingerError.Name = "lblFingerError"
        Me.lblFingerError.Size = New System.Drawing.Size(109, 19)
        Me.lblFingerError.TabIndex = 32
        Me.lblFingerError.Text = "                         "
        Me.lblFingerError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmSundaySched
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.New_Life_Attendance_Monitoring_System.My.Resources.Resources.newlifemainbg3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 766)
        Me.Controls.Add(Me.lblFingerError)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnBioLogin)
        Me.Controls.Add(Me.lblFinger)
        Me.Controls.Add(Me.lblLoginError)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.lblAttendCount)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblAttendCount As System.Windows.Forms.Label
    Friend WithEvents btnSignup As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents tmTimeDate As System.Windows.Forms.Timer
    Friend WithEvents lblLoginError As System.Windows.Forms.Label
    Friend WithEvents lblFinger As System.Windows.Forms.Label
    Friend WithEvents tmClear As System.Windows.Forms.Timer
    Friend WithEvents btnBioLogin As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Picture As System.Windows.Forms.PictureBox
    Friend WithEvents lblFingerError As System.Windows.Forms.Label
    Friend WithEvents tmSundaySched As System.Windows.Forms.Timer

End Class
