﻿Public Class frmServices
    Public open1, close1, start1, end1 As DateTime
    Public open2, close2, start2, end2 As DateTime
    Public open3, close3, start3, end3 As DateTime
    Public open4, close4, start4, end4 As DateTime
    Public open5, close5, start5, end5 As DateTime
    Public open6, close6, start6, end6 As DateTime
    Public open7, close7, start7, end7 As DateTime
    Public open8, close8, start8, end8 As DateTime
    Public selectedindex As String

    Public Sub frmServices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Connections.CountOfServices()
        If reader.Read Then
            cbMany.SelectedIndex = reader.GetString(0) - 1
        End If
        con.Close()
    End Sub
    Private Sub cbMany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMany.SelectedIndexChanged
        If cbMany.SelectedIndex = 0 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            lblSecondS.Hide()
            lbl2S.Hide()
            lbl2E.Hide()
            dtp2S.Hide()
            dtp2E.Hide()
            lblThirdS.Hide()
            lbl3S.Hide()
            lbl3E.Hide()
            dtp3S.Hide()
            dtp3E.Hide()
            lblFourthS.Hide()
            lbl4S.Hide()
            lbl4E.Hide()
            dtp4S.Hide()
            dtp4E.Hide()
            lblFiveS.Hide()
            lbl5S.Hide()
            lbl5E.Hide()
            dtp5S.Hide()
            dtp5E.Hide()
            lblSixS.Hide()
            lbl6S.Hide()
            lbl6E.Hide()
            dtp6S.Hide()
            dtp6E.Hide()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 1 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Hide()
            lbl3S.Hide()
            lbl3E.Hide()
            dtp3S.Hide()
            dtp3E.Hide()
            lblFourthS.Hide()
            lbl4S.Hide()
            lbl4E.Hide()
            dtp4S.Hide()
            dtp4E.Hide()
            lblFiveS.Hide()
            lbl5S.Hide()
            lbl5E.Hide()
            dtp5S.Hide()
            dtp5E.Hide()
            lblSixS.Hide()
            lbl6S.Hide()
            lbl6E.Hide()
            dtp6S.Hide()
            dtp6E.Hide()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 2 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Hide()
            lbl4S.Hide()
            lbl4E.Hide()
            dtp4S.Hide()
            dtp4E.Hide()
            lblFiveS.Hide()
            lbl5S.Hide()
            lbl5E.Hide()
            dtp5S.Hide()
            dtp5E.Hide()
            lblSixS.Hide()
            lbl6S.Hide()
            lbl6E.Hide()
            dtp6S.Hide()
            dtp6E.Hide()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 3 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get4()
            If reader.Read Then
                open4 = reader.GetString(1)
                close4 = reader.GetString(2)
                dtp4S.Text = reader.GetString(3)
                start4 = reader.GetString(3)
                end4 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Show()
            lbl4S.Show()
            lbl4E.Show()
            dtp4S.Show()
            dtp4E.Show()
            lblFiveS.Hide()
            lbl5S.Hide()
            lbl5E.Hide()
            dtp5S.Hide()
            dtp5E.Hide()
            lblSixS.Hide()
            lbl6S.Hide()
            lbl6E.Hide()
            dtp6S.Hide()
            dtp6E.Hide()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 4 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get4()
            If reader.Read Then
                open4 = reader.GetString(1)
                close4 = reader.GetString(2)
                dtp4S.Text = reader.GetString(3)
                start4 = reader.GetString(3)
                end4 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get5()
            If reader.Read Then
                open5 = reader.GetString(1)
                close5 = reader.GetString(2)
                dtp5S.Text = reader.GetString(3)
                start5 = reader.GetString(3)
                end5 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Show()
            lbl4S.Show()
            lbl4E.Show()
            dtp4S.Show()
            dtp4E.Show()
            lblFiveS.Show()
            lbl5S.Show()
            lbl5E.Show()
            dtp5S.Show()
            dtp5E.Show()
            lblSixS.Hide()
            lbl6S.Hide()
            lbl6E.Hide()
            dtp6S.Hide()
            dtp6E.Hide()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 5 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get4()
            If reader.Read Then
                open4 = reader.GetString(1)
                close4 = reader.GetString(2)
                dtp4S.Text = reader.GetString(3)
                start4 = reader.GetString(3)
                end4 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get5()
            If reader.Read Then
                open5 = reader.GetString(1)
                close5 = reader.GetString(2)
                dtp5S.Text = reader.GetString(3)
                start5 = reader.GetString(3)
                end5 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get6()
            If reader.Read Then
                open6 = reader.GetString(1)
                close6 = reader.GetString(2)
                dtp6S.Text = reader.GetString(3)
                start6 = reader.GetString(3)
                end6 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Show()
            lbl4S.Show()
            lbl4E.Show()
            dtp4S.Show()
            dtp4E.Show()
            lblFiveS.Show()
            lbl5S.Show()
            lbl5E.Show()
            dtp5S.Show()
            dtp5E.Show()
            lblSixS.Show()
            lbl6S.Show()
            lbl6E.Show()
            dtp6S.Show()
            dtp6E.Show()
            lblSevenS.Hide()
            lbl7S.Hide()
            lbl7E.Hide()
            dtp7S.Hide()
            dtp7E.Hide()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 6 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get4()
            If reader.Read Then
                open4 = reader.GetString(1)
                close4 = reader.GetString(2)
                dtp4S.Text = reader.GetString(3)
                start4 = reader.GetString(3)
                end4 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get5()
            If reader.Read Then
                open5 = reader.GetString(1)
                close5 = reader.GetString(2)
                dtp5S.Text = reader.GetString(3)
                start5 = reader.GetString(3)
                end5 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get6()
            If reader.Read Then
                open6 = reader.GetString(1)
                close6 = reader.GetString(2)
                dtp6S.Text = reader.GetString(3)
                start6 = reader.GetString(3)
                end6 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get7()
            If reader.Read Then
                open7 = reader.GetString(1)
                close7 = reader.GetString(2)
                dtp7S.Text = reader.GetString(3)
                start7 = reader.GetString(3)
                end7 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Show()
            lbl4S.Show()
            lbl4E.Show()
            dtp4S.Show()
            dtp4E.Show()
            lblFiveS.Show()
            lbl5S.Show()
            lbl5E.Show()
            dtp5S.Show()
            dtp5E.Show()
            lblSixS.Show()
            lbl6S.Show()
            lbl6E.Show()
            dtp6S.Show()
            dtp6E.Show()
            lblSevenS.Show()
            lbl7S.Show()
            lbl7E.Show()
            dtp7S.Show()
            dtp7E.Show()
            dtp8S.Hide()
            dtp8E.Hide()
            lblEightS.Hide()
            lbl8S.Hide()
            lbl8E.Hide()
        ElseIf cbMany.SelectedIndex = 7 Then
            con.Close()
            con.Open()
            Connections.Get1()
            If reader.Read Then
                open1 = reader.GetString(1)
                close1 = reader.GetString(2)
                dtp1S.Text = reader.GetString(3)
                start1 = reader.GetString(3)
                end1 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get2()
            If reader.Read Then
                open2 = reader.GetString(1)
                close2 = reader.GetString(2)
                dtp2S.Text = reader.GetString(3)
                start2 = reader.GetString(3)
                end2 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get3()
            If reader.Read Then
                open3 = reader.GetString(1)
                close3 = reader.GetString(2)
                dtp3S.Text = reader.GetString(3)
                start3 = reader.GetString(3)
                end3 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get4()
            If reader.Read Then
                open4 = reader.GetString(1)
                close4 = reader.GetString(2)
                dtp4S.Text = reader.GetString(3)
                start4 = reader.GetString(3)
                end4 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get5()
            If reader.Read Then
                open5 = reader.GetString(1)
                close5 = reader.GetString(2)
                dtp5S.Text = reader.GetString(3)
                start5 = reader.GetString(3)
                end5 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get6()
            If reader.Read Then
                open6 = reader.GetString(1)
                close6 = reader.GetString(2)
                dtp6S.Text = reader.GetString(3)
                start6 = reader.GetString(3)
                end6 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get7()
            If reader.Read Then
                open7 = reader.GetString(1)
                close7 = reader.GetString(2)
                dtp7S.Text = reader.GetString(3)
                start7 = reader.GetString(3)
                end7 = reader.GetString(4)
                con.Close()
            End If
            con.Close()
            con.Open()
            Connections.Get8()
            If reader.Read Then
                open8 = reader.GetString(1)
                close8 = reader.GetString(2)
                dtp8S.Text = reader.GetString(3)
                start8 = reader.GetString(3)
                end8 = reader.GetString(4)
                con.Close()
            End If
            lblFirstS.Show()
            lbl1E.Show()
            lbl1S.Show()
            dtp1E.Show()
            dtp1S.Show()
            lblSecondS.Show()
            lbl2S.Show()
            lbl2E.Show()
            dtp2S.Show()
            dtp2E.Show()
            lblThirdS.Show()
            lbl3S.Show()
            lbl3E.Show()
            dtp3S.Show()
            dtp3E.Show()
            lblFourthS.Show()
            lbl4S.Show()
            lbl4E.Show()
            dtp4S.Show()
            dtp4E.Show()
            lblFiveS.Show()
            lbl5S.Show()
            lbl5E.Show()
            dtp5S.Show()
            dtp5E.Show()
            lblSixS.Show()
            lbl6S.Show()
            lbl6E.Show()
            dtp6S.Show()
            dtp6E.Show()
            lblSevenS.Show()
            lbl7S.Show()
            lbl7E.Show()
            dtp7S.Show()
            dtp7E.Show()
            dtp8S.Show()
            dtp8E.Show()
            lblEightS.Show()
            lbl8S.Show()
            lbl8E.Show()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbMany.SelectedIndex = 0 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 1 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 2 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 3 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.Services4()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 4 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.Services4()
            con.Close()
            con.Open()
            Connections.Services5()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 5 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.Services4()
            con.Close()
            con.Open()
            Connections.Services5()
            con.Close()
            con.Open()
            Connections.Services6()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 6 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.Services4()
            con.Close()
            con.Open()
            Connections.Services5()
            con.Close()
            con.Open()
            Connections.Services6()
            con.Close()
            con.Open()
            Connections.Services7()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf cbMany.SelectedIndex = 7 Then
            selectedindex = cbMany.Text
            con.Open()
            Connections.Services1()
            con.Close()
            con.Open()
            Connections.Services2()
            con.Close()
            con.Open()
            Connections.Services3()
            con.Close()
            con.Open()
            Connections.Services4()
            con.Close()
            con.Open()
            Connections.Services5()
            con.Close()
            con.Open()
            Connections.Services6()
            con.Close()
            con.Open()
            Connections.Services7()
            con.Close()
            con.Open()
            Connections.Services8()
            con.Close()
            con.Open()
            Connections.NoOfServices()
            con.Close()
            MessageBox.Show("Successfuly")
        End If
    End Sub

    Private Sub dtp1S_ValueChanged_1(sender As Object, e As EventArgs) Handles dtp1S.ValueChanged
        dtp1E.Value = dtp1S.Value.AddHours(1).AddMinutes(30)
        open1 = dtp1S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close1 = dtp1S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp2S_ValueChanged(sender As Object, e As EventArgs) Handles dtp2S.ValueChanged
        dtp2E.Value = dtp2S.Value.AddHours(1).AddMinutes(30)
        open2 = dtp2S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close2 = dtp2S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp3S_ValueChanged(sender As Object, e As EventArgs) Handles dtp3S.ValueChanged
        dtp3E.Value = dtp3S.Value.AddHours(1).AddMinutes(30)
        open3 = dtp3S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close3 = dtp3S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp4S_ValueChanged(sender As Object, e As EventArgs) Handles dtp4S.ValueChanged
        dtp4E.Value = dtp4S.Value.AddHours(1).AddMinutes(30)
        open4 = dtp4S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close4 = dtp4S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp5S_ValueChanged(sender As Object, e As EventArgs) Handles dtp5S.ValueChanged
        dtp5E.Value = dtp5S.Value.AddHours(1).AddMinutes(30)
        open5 = dtp5S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close5 = dtp5S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp6S_ValueChanged(sender As Object, e As EventArgs) Handles dtp6S.ValueChanged
        dtp6E.Value = dtp6S.Value.AddHours(1).AddMinutes(30)
        open6 = dtp6S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close6 = dtp6S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp7S_ValueChanged(sender As Object, e As EventArgs) Handles dtp7S.ValueChanged
        dtp7E.Value = dtp7S.Value.AddHours(1).AddMinutes(30)
        open7 = dtp7S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close7 = dtp7S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub dtp8S_ValueChanged(sender As Object, e As EventArgs) Handles dtp8S.ValueChanged
        dtp8E.Value = dtp8S.Value.AddHours(1).AddMinutes(30)
        open8 = dtp8S.Value.AddHours(-1).ToString("h:mm:ss tt")
        close8 = dtp8S.Value.AddHours(1).ToString("h:mm:ss tt")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub ViewAdminAccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAdminAccountToolStripMenuItem1.Click
        If frmMain.Access = "Super Admin" Then
            frmAdminAccount.Show()
            frmAdminAccount.btnActivate.Show()
            frmAdminAccount.cbAccesstype.Show()
            frmAdminAccount.lblAccessType.Show()
        Else
            frmAdminAccount.btnActivate.Hide()
            frmAdminAccount.cbAccesstype.Hide()
            frmAdminAccount.lblAccessType.Hide()
            frmAdminAccount.Show()
        End If
    End Sub

    Private Sub LeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadersToolStripMenuItem.Click
        frmLeaders.Show()
    End Sub

    Private Sub SundayServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SundayServicesToolStripMenuItem.Click

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmMain.tmTimeDate.Start()
        frmMain.StartCapture()
        frmMain.Show()
        frmMain.Access = ""
        frmMain.txtUsername.Focus()
        Me.Hide()
    End Sub

    Private Sub ViewReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewReportToolStripMenuItem1.Click
        frmWeeklyReport.Show()
        Me.Hide()
    End Sub
End Class