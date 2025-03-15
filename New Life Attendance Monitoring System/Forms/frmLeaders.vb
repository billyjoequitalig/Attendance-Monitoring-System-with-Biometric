Public Class frmLeaders
    Public leaderID As String
    Private Sub frmLeaders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        cbSearchPosition.SelectedIndex = 0
        cbGeneration.Items.Add("All")
        cbGeneration.SelectedIndex = 0
        con.Open()
        Connections.CountCell()
        If reader.Read Then
            lblCountCell.Text = reader.GetString(0)
        End If
        con.Close()

        con.Open()
        Connections.CountNet()
        If reader.Read Then
            lblCountNet.Text = reader.GetString(0)
        End If
        con.Close()
   
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        frmAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            leaderID = selectedRow.Cells(0).Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtIDNum.Text = "" Then
            MessageBox.Show("Please Insert ID Number")
        Else  
            con.Open()
            Connections.SelectLeadNum()
            If reader.HasRows Then
                If txtGeneration.Text = "" Then
                    MessageBox.Show("Please Insert Generation")
                ElseIf cbPosition.SelectedIndex = -1 Then
                    MessageBox.Show("Please Select Position")
                Else
                    con.Close()
                    con.Open()
                    Connections.leaderExist()
                    If reader.HasRows Then
                        MessageBox.Show("Leader Already Exist")
                    Else
                        con.Close()
                        con.Open()
                        Connections.AddPosition()
                        con.Close()
                        con.Open()
                        Connections.UpdateLeadFullname()
                        con.Close()
                        frmLeaders_Load(sender, e)
                        MessageBox.Show("Successfuly")
                    End If
                End If
            Else
                MessageBox.Show("Invalid ID Number!")
            End If
            con.Close()
        End If



    End Sub

    Private Sub cbGeneration_DropDown(sender As Object, e As EventArgs) Handles cbGeneration.DropDown
        cbGeneration.Items.Clear()
        con.Open()
        Connections.Generation()
        cbGeneration.Items.Add("All")
        While reader.Read
            Dim gen = reader.GetString(0)
            For value As Integer = 1 To gen Step +1

                cbGeneration.Items.Add(value)
            Next
        End While
        con.Close()
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Delete This Account?!!", "DELETE", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            con.Open()
            Connections.DeleteLeaders()
            con.Close()
            MessageBox.Show("Successfuly")
        ElseIf result = DialogResult.No Then
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If cbSearchPosition.Text = "All" And cbGeneration.Text = "All" Then
            con.Open()
            Connections.SearchAllLeader()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 And cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosition()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchLeadGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Private Sub cbSearchPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchPosition.SelectedIndexChanged
        If cbSearchPosition.Text = "All" And cbGeneration.Text = "All" Then
            con.Open()
            Connections.SearchAllLeader()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 And cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosition()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchLeadGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Private Sub cbGeneration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGeneration.SelectedIndexChanged
        If cbSearchPosition.Text = "All" And cbGeneration.Text = "All" Then
            con.Open()
            Connections.SearchAllLeader()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 And cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchPosition.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchPosition()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbGeneration.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchLeadGen()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub
End Class