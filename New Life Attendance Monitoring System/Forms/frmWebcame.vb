Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Public Class frmWebcame
    Dim camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub frmWebcame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        camera.Stop()
        Me.Hide()
    End Sub

    Private Sub Captured(sender As Object, EventArgs As NewFrameEventArgs)
        bmp = DirectCast(EventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(EventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim Cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            camera = Cameras.VideoDevice
            AddHandler camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            camera.Start()
            btnStart.Enabled = False
        End If
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not PictureBox2.Image Is Nothing Then
            frmAddUser.PictureBox1.Image = PictureBox2.Image
            frmAdmin.PictureBox1.Image = PictureBox2.Image
            camera.Stop()
            btnStart.Enabled = True
            Me.Hide()
        Else
            MessageBox.Show("Cature First")
        End If
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not PictureBox1.Image Is Nothing Then
            camera.Stop()
            btnStart.Enabled = True
            Me.Hide()
        ElseIf PictureBox1.Image Is Nothing Then
            Me.Hide()
        End If
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub frmWebcame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class