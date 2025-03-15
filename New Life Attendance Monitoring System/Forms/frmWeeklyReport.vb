Public Class frmWeeklyReport

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnWeek_Click_1(sender As Object, e As EventArgs) Handles btnWeek.Click
        DateTimePicker1.Show()
        lblDate1.Show()
        DateTimePicker3.Hide()
        Label70.Hide()
    End Sub

    Private Sub cbSearchNet_DropDown(sender As Object, e As EventArgs) Handles cbSearchNet.DropDown
        cbSearchNet.Items.Clear()
        cbSearchNet.Items.Add("All")
        con.Open()
        Connections.SelectNetLeader()
        While reader.Read
            Dim fullname = reader.GetString(2)
            cbSearchNet.Items.Add(fullname)
        End While
        con.Close()
        If cbSearchNet.Text = "" Then
            cbSearchNet.Text = "All"
        End If
    End Sub

    Private Sub cbSearchCell_DropDown(sender As Object, e As EventArgs) Handles cbSearchCell.DropDown
        cbSearchCell.Items.Clear()
        cbSearchCell.Items.Add("All")
        con.Open()
        Connections.SelectCellLeader()
        While reader.Read
            Dim fullname = reader.GetString(2)
            cbSearchCell.Items.Add(fullname)
        End While
        con.Close()
        If cbSearchCell.Text = "" Then
            cbSearchCell.Text = "All"
        End If
    End Sub

    Private Sub btnAnnual_Click(sender As Object, e As EventArgs) Handles btnAnnual.Click

    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click

    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSearchCell.SelectedIndex = 0
        cbSearchNet.SelectedIndex = 0
        DateTimePicker1.Value = DateTime.Now
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If lblGrandTotal.Text = "0" Then
            MessageBox.Show("Please generate")
        Else
            frmWeeklyPrint.Show()
        End If
    End Sub

    Private Sub frmReport_Click(sender As Object, e As EventArgs)
        frmWeeklyPrint.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label59_Click(sender As Object, e As EventArgs) Handles Label59.Click

    End Sub

    Private Sub tab2_Click(sender As Object, e As EventArgs) Handles tab2.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
       
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim kids1, adult1, youngAdult1, preteen1, youth1, total1 As Integer
        Dim kids2, adult2, youngAdult2, preteen2, youth2, total2 As Integer
        Dim kids3, adult3, youngAdult3, preteen3, youth3, total3 As Integer
        Dim kids4, adult4, youngAdult4, preteen4, youth4, total4 As Integer
        Dim kids5, adult5, youngAdult5, preteen5, youth5, total5 As Integer
        Dim kids6, adult6, youngAdult6, preteen6, youth6, total6 As Integer
        Dim kids7, adult7, youngAdult7, preteen7, youth7, total7 As Integer
        Dim kids8, adult8, youngAdult8, preteen8, youth8, total8 As Integer

        If cbSearchNet.SelectedIndex <= 0 And cbSearchCell.SelectedIndex <= 0 Then
            con.Open()
            Connections.WeeklyAll()
        ElseIf cbSearchNet.SelectedIndex >= 0 And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.WeeklyByNetLead()
        ElseIf cbSearchCell.SelectedIndex >= 0 And cbSearchNet.Text = "All" Then
            con.Open()
            Connections.WeeklyByCelltLead()
        ElseIf cbSearchNet.SelectedIndex >= 0 And cbSearchCell.SelectedIndex >= 0 Then
            con.Open()
            Connections.WeeklyByLead()
        End If
        While reader.Read
            Dim Category As String = reader("Category")
            ' Dim status As String = reader("late")
            If reader(2) = 1 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids1 = kids1 + 1
                    ElseIf Category = "Adult" Then
                        adult1 = adult1 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult1 = youngAdult1 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen1 = preteen1 + 1
                    ElseIf Category = "Youth" Then
                        youth1 = youth1 + 1
                    End If
                End If
            ElseIf reader(2) = 2 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids2 = adult2 + 1
                    ElseIf Category = "Adult" Then
                        adult2 = adult2 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult2 = youngAdult2 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen2 = preteen2 + 1
                    ElseIf Category = "Youth" Then
                        youth2 = youth2 + 1
                    End If
                End If
            ElseIf reader(2) = 3 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids3 = kids3 + 1
                    ElseIf Category = "Adult" Then
                        adult3 = adult3 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult3 = youngAdult3 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen3 = preteen3 + 1
                    ElseIf Category = "Youth" Then
                        youth3 = youth3 + 1
                    End If
                End If
            ElseIf reader(2) = 4 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids4 = kids4 + 1
                    ElseIf Category = "Adult" Then
                        adult4 = adult4 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult4 = youngAdult4 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen4 = preteen4 + 1
                    ElseIf Category = "Youth" Then
                        youth4 = youth4 + 1
                    End If
                End If
            ElseIf reader(2) = 5 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids5 = kids5 + 1
                    ElseIf Category = "Adult" Then
                        adult5 = adult5 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult5 = youngAdult5 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen5 = preteen5 + 1
                    ElseIf Category = "Youth" Then
                        youth5 = youth5 + 1
                    End If
                End If
            ElseIf reader(2) = 6 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids6 = kids6 + 1
                    ElseIf Category = "Adult" Then
                        adult6 = adult6 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult6 = youngAdult6 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen6 = preteen6 + 1
                    ElseIf Category = "Youth" Then
                        youth6 = youth6 + 1
                    End If
                End If
            ElseIf reader(2) = 7 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids7 = kids7 + 1
                    ElseIf Category = "Adult" Then
                        adult7 = adult7 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult7 = youngAdult7 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen7 = preteen7 + 1
                    ElseIf Category = "Youth" Then
                        youth7 = youth7 + 1
                    End If
                End If
            ElseIf reader(2) = 8 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids8 = kids8 + 1
                    ElseIf Category = "Adult" Then
                        adult8 = adult8 + 1
                    ElseIf Category = "Young Adult" Then
                        youngAdult8 = youngAdult8 + 1
                    ElseIf Category = "Pre-Teen" Then
                        preteen8 = preteen8 + 1
                    ElseIf Category = "Youth" Then
                        youth8 = youth8 + 1
                    End If
                End If
            End If

        End While
        con.Close()
        'one
        lblkids1.Text = kids1
        lblPreteen1.Text = preteen1
        lblYouth1.Text = youth1
        lblAdult1.Text = adult1
        lblYoungAdult1.Text = youngAdult1
        total1 = kids1 + preteen1 + youth1 + adult1 + youngAdult1
        lblTotal1.Text = total1
        'Two
        lblKids2.Text = kids2
        lblPreteen2.Text = preteen2
        lblYouth2.Text = youth2
        lblAdult2.Text = adult2
        lblYoungAdult2.Text = youngAdult2
        total2 = kids2 + preteen2 + youth2 + adult2 + youngAdult2
        lblTotal2.Text = total2
        'Three
        lblKids3.Text = kids3
        lblPreteen3.Text = preteen3
        lblYouth3.Text = youth3
        lblAdult3.Text = adult3
        lblYoungAdult3.Text = youngAdult3
        total3 = kids3 + preteen3 + youth3 + adult3 + youngAdult3
        lblTotal3.Text = total3
        'Four
        lblkids4.Text = kids4
        lblPreteen4.Text = preteen4
        lblYouth4.Text = youth4
        lblAdult4.Text = adult4
        lblYoungAdult4.Text = youngAdult4
        total4 = kids4 + preteen4 + youth4 + adult4 + youngAdult4
        lblTotal4.Text = total4
        'Five
        lblKids5.Text = kids5
        lblPreteen5.Text = preteen5
        lblYouth5.Text = youth5
        lblAdult5.Text = adult5
        lblYoungAdult5.Text = youngAdult5
        total5 = kids5 + preteen5 + youth5 + adult5 + youngAdult5
        lblTotal5.Text = total5
        'Six
        lblkids6.Text = kids6
        lblPreteen6.Text = preteen6
        lblYouth6.Text = youth6
        lblAdult6.Text = adult6
        lblYoungAdult6.Text = youngAdult6
        total6 = kids6 + preteen6 + youth6 + adult6 + youngAdult6
        lblTotal6.Text = total6
        'Seven
        lblKids7.Text = kids7
        lblPreteen7.Text = preteen7
        lblYouth7.Text = youth7
        lblAdult7.Text = adult7
        lblYoungAdult7.Text = youngAdult7
        total6 = kids7 + preteen7 + youth7 + adult7 + youngAdult7
        lblTotal7.Text = total7
        'Eight
        lblKids8.Text = kids8
        lblPreteen8.Text = preteen8
        lblYouth8.Text = youth8
        lblAdult8.Text = adult8
        lblYoungAdult8.Text = youngAdult8
        total6 = kids8 + preteen8 + youth8 + adult8 + youngAdult8
        lblTotal8.Text = total8
        'Total  Attendees'
        If cbSearchNet.SelectedIndex <= 0 And cbSearchCell.SelectedIndex <= 0 Then
            con.Open()
            Connections.WeeklyTotalAll()
        ElseIf cbSearchNet.SelectedIndex >= 0 And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.WeeklyTotalbyNetLead()
        ElseIf cbSearchCell.SelectedIndex >= 0 And cbSearchNet.Text = "All" Then
            con.Open()
            Connections.WeeklyTotalbyCellLead()
        ElseIf cbSearchNet.SelectedIndex >= 0 And cbSearchCell.SelectedIndex >= 0 Then
            con.Open()
            Connections.WeeklyTotalbyLead()
        End If
        If reader.Read Then
            lblGrandTotal.Text = reader.GetString(0)
            If lblGrandTotal.Text = "0" Then
                lblTotalLate.Text = "0"
                lblTotalOntime.Text = "0"
                lblGrandTotal.Text = "0"
                MessageBox.Show("No attendees from this Date " & DateTimePicker1.Text)
            Else
                lblTotalOntime.Text = reader.GetString(1)
                lblTotalLate.Text = reader.GetString(2)
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        btnMonth.BackColor = Color.Black
        DateTimePicker1.Hide()
        lblDate1.Hide()
        DateTimePicker3.Show()
        Label70.Show()
    End Sub

    Private Sub Label302_Click(sender As Object, e As EventArgs) Handles Label302.Click

    End Sub
End Class