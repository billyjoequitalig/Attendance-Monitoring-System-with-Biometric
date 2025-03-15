Module ScheduleServices
    Public Dopen, Dclose, Dstart, Dend As DateTime
    Public open1, close1, start1, end1 As DateTime
    Dim open2, close2, start2, end2 As DateTime
    Dim open3, close3, start3, end3 As DateTime
    Dim open4, close4, start4, end4 As DateTime
    Dim open5, close5, start5, end5 As DateTime
    Dim open6, close6, start6, end6 As DateTime
    Dim open7, close7, start7, end7 As DateTime
    Dim open8, close8, start8, end8 As DateTime
    Dim day As String = DateTime.Now.ToString("dddd")
    Public NoOfServices As String
    Public CurrService As String

    Sub SundayServices()
        con.Close()
        con.Open()
        Connections.CountOfServices()
        If reader.Read Then
            frmServices.cbMany.SelectedIndex = reader.GetInt32(0) - 1
            NoOfServices = frmServices.cbMany.Text
            con.Close()
        End If
        con.Close()

    End Sub

    Sub Service1()
        If NoOfServices = "1" Then
            If TimeOfDay >= frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                frmMain.StopCapture()
                frmMain.lblWelcome.Text = "NO Service"
                frmMain.lblAttendCount.Text = "0"
            End If
        End If
    End Sub

    Sub Service2()
        If NoOfServices = "2" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    frmMain.StopCapture()
                    frmMain.lblWelcome.Text = "NO Service"
                    If Not day = "Sunday" Then
                        frmMain.lblAttendCount.Text = "0"
                    End If

                End If
            End If
        End If
    End Sub
    Sub Service3()
        If NoOfServices = "3" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        frmMain.StopCapture()
                        frmMain.lblWelcome.Text = "NO Service"
                        If Not day = "Sunday" Then
                            frmMain.lblAttendCount.Text = "0"
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub Service4()
        If NoOfServices = "4" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        If TimeOfDay > frmServices.open4 And TimeOfDay <= frmServices.end4 And day = "Sunday" Then
                            CurrService = "4"
                            Dopen = frmServices.open4
                            Dclose = frmServices.close4
                            Dstart = frmServices.start4.AddMinutes(1)
                            Dend = frmServices.end4
                            frmMain.StartCapture()
                            frmMain.lblWelcome.Text = "Welcome To Third Service"
                        Else
                            frmMain.StopCapture()
                            frmMain.lblWelcome.Text = "NO Service"
                            If Not day = "Sunday" Then
                                frmMain.lblAttendCount.Text = "0"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub Service5()
        If NoOfServices = "5" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        If TimeOfDay > frmServices.open4 And TimeOfDay <= frmServices.end4 And day = "Sunday" Then
                            CurrService = "4"
                            Dopen = frmServices.open4
                            Dclose = frmServices.close4
                            Dstart = frmServices.start4.AddMinutes(1)
                            Dend = frmServices.end4
                            frmMain.StartCapture()
                            frmMain.lblWelcome.Text = "Welcome To Fourth Service"
                        Else
                            If TimeOfDay > frmServices.open5 And TimeOfDay <= frmServices.end5 And day = "Sunday" Then
                                CurrService = "5"
                                Dopen = frmServices.open5
                                Dclose = frmServices.close5
                                Dstart = frmServices.start5.AddMinutes(1)
                                Dend = frmServices.end5
                                frmMain.StartCapture()
                                frmMain.lblWelcome.Text = "Welcome To Fifth Service"
                            Else
                                frmMain.StopCapture()
                                frmMain.lblWelcome.Text = "NO SERVICE FOR TODAY"
                                If Not day = "Sunday" Then
                                    frmMain.lblAttendCount.Text = "0"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub Service6()
        If NoOfServices = "6" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
               
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        If TimeOfDay > frmServices.open4 And TimeOfDay <= frmServices.end4 And day = "Sunday" Then
                            CurrService = "4"
                            Dopen = frmServices.open4
                            Dclose = frmServices.close4
                            Dstart = frmServices.start4.AddMinutes(1)
                            Dend = frmServices.end4
                            frmMain.StartCapture()
                            frmMain.lblWelcome.Text = "Welcome To Fourth Service"
                        Else
                            If TimeOfDay > frmServices.open5 And TimeOfDay <= frmServices.end5 And day = "Sunday" Then
                                CurrService = "5"
                                Dopen = frmServices.open5
                                Dclose = frmServices.close5
                                Dstart = frmServices.start5.AddMinutes(1)
                                Dend = frmServices.end5
                                frmMain.StartCapture()
                                frmMain.lblWelcome.Text = "Welcome To Fifth Service"
                            Else
                                If TimeOfDay > frmServices.open6 And TimeOfDay <= frmServices.end6 And day = "Sunday" Then
                                    CurrService = "6"
                                    Dopen = frmServices.open6
                                    Dclose = frmServices.close6
                                    Dstart = frmServices.start6.AddMinutes(1)
                                    Dend = frmServices.end6
                                    frmMain.StartCapture()
                                    frmMain.lblWelcome.Text = "Welcome To Sixth Service"
                                Else
                                    frmMain.StopCapture()
                                    frmMain.lblWelcome.Text = "NO Service"
                                    If Not day = "Sunday" Then
                                        frmMain.lblAttendCount.Text = "0"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub Service7()
        If NoOfServices = "7" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        If TimeOfDay > frmServices.open4 And TimeOfDay <= frmServices.end4 And day = "Sunday" Then
                            CurrService = "4"
                            Dopen = frmServices.open4
                            Dclose = frmServices.close4
                            Dstart = frmServices.start4.AddMinutes(1)
                            Dend = frmServices.end4
                            frmMain.StartCapture()
                            frmMain.lblWelcome.Text = "Welcome To Fourth Service"
                        Else
                            If TimeOfDay > frmServices.open5 And TimeOfDay <= frmServices.end5 And day = "Sunday" Then
                                CurrService = "5"
                                Dopen = frmServices.open5
                                Dclose = frmServices.close5
                                Dstart = frmServices.start5.AddMinutes(1)
                                Dend = frmServices.end5
                                frmMain.StartCapture()
                                frmMain.lblWelcome.Text = "Welcome To Fifth Service"
                            Else
                                If TimeOfDay > frmServices.open6 And TimeOfDay <= frmServices.end6 And day = "Sunday" Then
                                    CurrService = "6"
                                    Dopen = frmServices.open6
                                    Dclose = frmServices.close6
                                    Dstart = frmServices.start6.AddMinutes(1)
                                    Dend = frmServices.end6
                                    frmMain.StartCapture()
                                    frmMain.lblWelcome.Text = "Welcome To Sixth Service"
                                Else
                                    If TimeOfDay > frmServices.open7 And TimeOfDay <= frmServices.end7 And day = "Sunday" Then
                                        CurrService = "7"
                                        Dopen = frmServices.open7
                                        Dclose = frmServices.close7
                                        Dstart = frmServices.start7.AddMinutes(1)
                                        Dend = frmServices.end7
                                        frmMain.StartCapture()
                                        frmMain.lblWelcome.Text = "Welcome To Seventh Service"
                                    Else
                                        frmMain.StopCapture()
                                        frmMain.lblWelcome.Text = "NO Service"
                                        If Not day = "Sunday" Then
                                            frmMain.lblAttendCount.Text = "0"
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Sub Service8()
        If NoOfServices = "8" Then
            If TimeOfDay > frmServices.open1 And TimeOfDay <= frmServices.end1 And day = "Sunday" Then
                CurrService = "1"
                Dopen = frmServices.open1
                Dclose = frmServices.close1
                Dstart = frmServices.start1.AddMinutes(1)
                Dend = frmServices.end1
                frmMain.StartCapture()
                frmMain.lblWelcome.Text = "Welcome To First Service"
            Else
                If TimeOfDay > frmServices.open2 And TimeOfDay <= frmServices.end2 And day = "Sunday" Then
                    CurrService = "2"
                    Dopen = frmServices.open2
                    Dclose = frmServices.close2
                    Dstart = frmServices.start2.AddMinutes(1)
                    Dend = frmServices.end2
                    frmMain.StartCapture()
                    frmMain.lblWelcome.Text = "Welcome To Second Service"
                Else
                    If TimeOfDay > frmServices.open3 And TimeOfDay <= frmServices.end3 And day = "Sunday" Then
                        CurrService = "3"
                        Dopen = frmServices.open3
                        Dclose = frmServices.close3
                        Dstart = frmServices.start3.AddMinutes(1)
                        Dend = frmServices.end3
                        frmMain.StartCapture()
                        frmMain.lblWelcome.Text = "Welcome To Third Service"
                    Else
                        If TimeOfDay > frmServices.open4 And TimeOfDay <= frmServices.end4 And day = "Sunday" Then
                            CurrService = "4"
                            Dopen = frmServices.open4
                            Dclose = frmServices.close4
                            Dstart = frmServices.start4.AddMinutes(1)
                            Dend = frmServices.end4
                            frmMain.StartCapture()
                            frmMain.lblWelcome.Text = "Welcome To Fourth Service"
                        Else
                            If TimeOfDay > frmServices.open5 And TimeOfDay <= frmServices.end5 And day = "Sunday" Then
                                CurrService = "5"
                                Dopen = frmServices.open5
                                Dclose = frmServices.close5
                                Dstart = frmServices.start5.AddMinutes(1)
                                Dend = frmServices.end5
                                frmMain.StartCapture()
                                frmMain.lblWelcome.Text = "Welcome To Fifth Service"
                            Else
                                If TimeOfDay > frmServices.open6 And TimeOfDay <= frmServices.end6 And day = "Sunday" Then
                                    CurrService = "6"
                                    Dopen = frmServices.open6
                                    Dclose = frmServices.close6
                                    Dstart = frmServices.start6.AddMinutes(1)
                                    Dend = frmServices.end6
                                    frmMain.StartCapture()
                                    frmMain.lblWelcome.Text = "Welcome To Sixth Service"
                                Else
                                    If TimeOfDay > frmServices.open7 And TimeOfDay <= frmServices.end7 And day = "Sunday" Then
                                        CurrService = "7"
                                        Dopen = frmServices.open7
                                        Dclose = frmServices.close7
                                        Dstart = frmServices.start7.AddMinutes(1)
                                        Dend = frmServices.end7
                                        frmMain.StartCapture()
                                        frmMain.lblWelcome.Text = "Welcome To Seventh Service"
                                    Else
                                        If TimeOfDay > frmServices.open8 And TimeOfDay <= frmServices.end8 And day = "Sunday" Then
                                            CurrService = "8"
                                            Dopen = frmServices.open8
                                            Dclose = frmServices.close8
                                            Dstart = frmServices.start8.AddMinutes(1)
                                            Dend = frmServices.end8
                                            frmMain.StartCapture()
                                            frmMain.lblWelcome.Text = "Welcome To Eighth Service"
                                        Else
                                            frmMain.StopCapture()
                                            frmMain.lblWelcome.Text = "NO Service"
                                            If Not day = "Sunday" Then
                                                frmMain.lblAttendCount.Text = "0"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Module
