Public Class frmReport

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btnWeek_Click_1(sender As Object, e As EventArgs) Handles btnWeek.Click
        btnWeek.BackColor = Color.Black
        btnMonth.BackColor = Color.Transparent
        btnAnnual.BackColor = Color.Transparent
        btnIndividual.BackColor = Color.Transparent
        GroupBox1.Text = "Weekly"
        lblDate1.Text = "Set Date:"
        lblDate2.Hide()
        DateTimePicker2.Hide()
    End Sub

    Private Sub btnMonth_Click(sender As Object, e As EventArgs) Handles btnMonth.Click
        btnMonth.BackColor = Color.Black
        btnWeek.BackColor = Color.Transparent
        btnAnnual.BackColor = Color.Transparent
        btnIndividual.BackColor = Color.Transparent
        GroupBox1.Text = "Monthly"
        lblDate1.Text = "From :"
        lblDate2.Show()
        DateTimePicker2.Show()
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
    End Sub

    Private Sub btnAnnual_Click(sender As Object, e As EventArgs) Handles btnAnnual.Click
        btnAnnual.BackColor = Color.Black
        btnMonth.BackColor = Color.Transparent
        btnWeek.BackColor = Color.Transparent
        btnIndividual.BackColor = Color.Transparent
        GroupBox1.Text = "Annualy"
    End Sub

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
        btnIndividual.BackColor = Color.Black
        btnAnnual.BackColor = Color.Transparent
        btnMonth.BackColor = Color.Transparent
        btnWeek.BackColor = Color.Transparent
        GroupBox1.Text = "Individual"
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim kids1, adult1, youngAdult1, preteen1, youth1, total1 As Integer
        Dim kids2, adult2, youngAdult2, preteen2, youth2, total2 As Integer
        Dim kids3, adult3, youngAdult3, preteen3, youth3, total3 As Integer
        Dim kids4, adult4, youngAdult4, preteen4, youth4, total4 As Integer
        Dim kids5, adult5, youngAdult5, preteen5, youth5, total5 As Integer
        Dim kids6, adult6, youngAdult6, preteen6, youth6, total6 As Integer
        'Dim kids7, adult7, youngAdult7, preteen7, youth7, total7 As Integer
        'Dim kids8, adult8, youngAdult8, preteen8, youth8, total8 As Integer
        'Dim Late As Integer
        'Dim OnTime As Integer
        con.Open()
        Connections.WeeklyAll()
        While reader.Read
            Dim Category As String = reader("Category")
            ' Dim status As String = reader("late")
            If reader(2) = 1 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids1 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult1 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult1 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen1 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth1 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 2 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids2 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult2 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult2 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen2 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth2 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 3 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids3 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult3 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult3 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen3 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth3 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 4 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids4 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult4 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult4 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen4 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth4 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 5 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids5 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult5 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult5 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen5 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth5 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 6 Then
                If Category = reader("Category") Then
                    If Category = "Kids" Then
                        kids6 = reader.GetString(0)
                    ElseIf Category = "Adult" Then
                        adult6 = reader.GetString(0)
                    ElseIf Category = "Young Adult" Then
                        youngAdult6 = reader.GetString(0)
                    ElseIf Category = "Pre-Teen" Then
                        preteen6 = reader.GetString(0)
                    ElseIf Category = "Youth" Then
                        youth6 = reader.GetString(0)
                    End If
                End If
            ElseIf reader(2) = 7 Then

            ElseIf reader(2) = 8 Then

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

        lblGrandTotal.Text = total1 + total2 + total3 + total4 + total5 + total6
        If lblGrandTotal.Text = "0" Then
            MessageBox.Show("No Attendance from this Date")
        End If
    End Sub

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbSearchCell.SelectedIndex = 0
        cbSearchNet.SelectedIndex = 0
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmReportWeekly.Show()
    End Sub

    Private Sub frmReport_Click(sender As Object, e As EventArgs)
        frmReportWeekly.Close()
    End Sub
End Class