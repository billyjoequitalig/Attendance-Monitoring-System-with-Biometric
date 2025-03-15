Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmMain
    Implements DPFP.Capture.EventHandler
    Dim sec As Integer = 4
    Dim tsec As Integer = 0
    Dim tmin As Integer = 0
    Dim thr As Integer = 0
    Public WhosPrint As String
    Public ID As String
    Public Access As String
    Public AdminId As String
    Dim open1, close1, start1, end1 As DateTime
    Dim open2, close2, start2, end2 As DateTime
    Dim open3, close3, start3, end3 As DateTime
    Dim open4, close4, start4, end4 As DateTime
    Dim open5, close5, start5, end5 As DateTime
    Dim open6, close6, start6, end6 As DateTime
    Dim open7, close7, start7, end7 As DateTime
    Dim open8, close8, start8, end8 As DateTime
    Public index As String
    Delegate Sub FunctionCall(ByVal param)
    Private Capturer As DPFP.Capture.Capture
    Private Verificator As DPFP.Verification.Verification
    Private Template As DPFP.Template

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        'MakeReport("The fingerprint sample was captured.")
        ' SetPrompt("Scan the same fingerprint again.")
        Process(Sample)
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        'MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        'MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        'MakeReport("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        'MakeReport("The fingerprint reader was disconnected.")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            'MakeReport("The quality of the fingerprint sample is good.")
        Else
            ' MakeReport("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Protected Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
                Verificator = New DPFP.Verification.Verification()
            Else
                'SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overridable Sub Process(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))
        If verify(Sample) Then
            sec = 4
            tmClear.Start()
            lblFingerError.Text = ""
        Else
            'MakeReport("The fingerprint was not VERIFIED.")
            PictureBox1.Image = My.Resources.NLCF_SEAL
            lblFingerError.Text = "Unregistered User!"
            lblName.Text = ""
            lblCategory.Text = ""
            lblStatus.Text = ""
            tmClear.Start()
            txtUserID.Text = ""
        End If
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)        ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Public Function verify(ByVal Sample As DPFP.Sample) As Boolean
        ' Process the sample and create a feature set for the enrollment purpose.
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)
        Try
            con.Close()
            con.Open()
            Connections.SelectFPuser()
            Dim templa8 As DPFP.Template = New DPFP.Template()
            Dim MemStream As IO.MemoryStream
            Dim found As Boolean = False
            If reader.HasRows Then
                tmSundaySched.Stop()
                While reader.Read
                    Dim fpBytes As Byte()
                    fpBytes = reader("FPrint")
                    MemStream = New IO.MemoryStream(fpBytes)
                    templa8.DeSerialize(MemStream)
                    Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
                    'Check quality of the sample and start verification if it's good
                    If Not features Is Nothing Then
                        'Compare the feature set with our template
                        Verificator.Verify(features, templa8, result)
                        If result.Verified Then
                            found = True
                            getID(reader.GetString(0))
                            con.Close()
                            Return found
                        End If
                    End If
                End While



            End If

            con.Close()
        Catch myerror As MySqlException
            lblFingerError.Text = myerror.Message
        End Try

        Return Nothing
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        con.Close()
        con.Open()
        Connections.Login()
        If reader.HasRows Then
            If reader.Read Then
                tmSundaySched.Stop()
                AdminId = reader.GetString(0).ToString()
                Access = reader.GetString(3).ToString()
                If Access = "Super Admin" Then
                    con.Close()
                    con.Open()
                    Connections.CurrentLogin()
                    If reader.Read Then
                        frmAdmin.lblCurrentLog.Text = reader.GetString(2) & " as " & Access
                        WhosPrint = reader.GetString(2)
                    End If
                    con.Close()
                    frmAdmin.btnBio.Show()
                    frmAdmin.Show()
                    StopCapture()
                    tmTimeDate.Stop()
                    Me.Hide()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    lblLoginError.Text = ""
                ElseIf Access = "Admin" Then
                    con.Close()
                    con.Open()
                    Connections.CurrentLogin()
                    If reader.Read Then
                        frmAdmin.lblCurrentLog.Text = reader.GetString(2) & " as " & Access
                    End If
                    con.Close()
                    frmAdmin.btnBio.Hide()
                    frmAdmin.Show()
                    StopCapture
                    tmTimeDate.Stop()
                    Me.Hide()
                    txtUsername.Clear()
                    txtPassword.Clear()
                    lblLoginError.Text = ""
                End If
            End If
        Else
            lblLoginError.Text = "Invalid Account"
            txtUsername.Clear()
            txtPassword.Clear()
            tmClear.Start()
        End If
        con.Close()

    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Init()
        tmSundaySched.Start()
        tmTimeDate.Start()
        Try
            con.Open()
        Catch ex As Exception
            MessageBox.Show("Unable To Connect From Database!")
            Me.Close()
            Return
        End Try
        SundayServices()
        con.Open()
        Connections.CountAttendToday()
        If reader.Read Then
            lblAttendCount.Text = reader.GetString(0)
        End If
        con.Close()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        tmTimeDate.Stop()
        tmSundaySched.Stop()
        StopCapture()
        frmAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            con.Open()
            Connections.SelectMainID()
            If reader.Read Then
                txtUserID.Text = reader.GetValue(0).ToString
                lblName.Text = reader.GetValue(1).ToString + " " + reader.GetValue(2).ToString + " " + reader.GetValue(3) + "."
                lblStatus.Text = reader.GetValue(5)
                lblCategory.Text = reader.GetValue(9).ToString
                'reader.Read()
                'Dim data As Byte() = DirectCast(reader("Image"), Byte())
                'Dim ms As New MemoryStream(data)
                'PictureBox1.Image = Image.FromStream(ms)
                con.Close()
                con.Open()
                Connections.TimeIn()
                con.Close()
                tmClear.Start()
            Else
                lblFinger.Text = "Unregistered User!"
                tmClear.Start()
            End If
            con.Close()
            con.Open()
            Connections.CountAttendToday()
            If reader.Read Then
                lblAttendCount.Text = reader.GetValue(0).ToString
            End If
            con.Close()
            ID = txtID.Text
            txtID.Clear()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Public Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                'SetPrompt("Using the fingerprint reader, scan your fingerprint.")
            Catch ex As Exception
                ' SetPrompt("Can't initiate capture!")
            End Try
        End If
    End Sub

    Public Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
            Catch ex As Exception
                'SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub

    Protected Sub getID(ByVal UserID)
        Invoke(New FunctionCall(AddressOf _getID), UserID)
    End Sub

    Private Sub getName(name As String)
        Invoke(New FunctionCall(AddressOf _getName), name)
    End Sub

    Private Sub _getName(ByVal name)
        lblName.Text = name
    End Sub

    Private Sub getcateg(category As String)
        Invoke(New FunctionCall(AddressOf _getcateg), category)
    End Sub
    Private Sub _getcateg(ByVal categgory)
        lblCategory.Text = categgory
    End Sub

    Private Sub btnBioLogin_Click(sender As Object, e As EventArgs) Handles btnBioLogin.Click
        If btnBioLogin.Text = "Bio Login" Then
            
            btnBioLogin.Text = "Time In"
        ElseIf btnBioLogin.Text = "Time In" Then

            btnBioLogin.Text = "Bio Login"
        End If
    End Sub

    Private Sub tmTimeDate_Tick(sender As Object, e As EventArgs) Handles tmTimeDate.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy")
        tmSundaySched.Start()
    End Sub

    Private Sub tmClear_Tick(sender As Object, e As EventArgs) Handles tmClear.Tick
        If sec = 0 Then
            Me.tmClear.Stop()
            lblLoginError.Text = ""
            lblFinger.Text = ""
            lblName.Text = ""
            lblStatus.Text = ""
            lblCategory.Text = ""
            txtUserID.Text = ""
            lblFingerError.Text = ""
            Picture.Image = Nothing
            PictureBox1.Image = My.Resources.NLCF_SEAL
            If sec = 0 Then
                sec = 4
            End If
            Exit Sub
        End If
        If sec > 0 Then
            sec = sec - 1
        End If
    End Sub

    Private Sub tmSundaySched_Tick(sender As Object, e As EventArgs) Handles tmSundaySched.Tick
        ScheduleServices.Service1()
        ScheduleServices.Service2()
        ScheduleServices.Service3()
        ScheduleServices.Service4()
        ScheduleServices.Service5()
        ScheduleServices.Service6()
        ScheduleServices.Service7()
        ScheduleServices.Service8()
    End Sub
End Class