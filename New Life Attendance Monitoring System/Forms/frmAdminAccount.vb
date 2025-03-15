Imports System.IO

Public Class frmAdminAccount
    Public reset As String
    Public id As String
    Public Property AccessType As String

    Private Sub Admin_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSearch.Focus()



        con.Open()
        Connections.loadadmin()
        con.Close()
        txtFname.Enabled = False
        txtLname.Enabled = False
        txtMi.Enabled = False
        txtAddress.Enabled = False
        txtCellLeader.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False
        txtNetLeader.Enabled = False
        txtCategory.Enabled = False
        cbGender.Enabled = False
        cbStatus.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        frmAdmin.Show()
        Me.Close()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        con.Open()
        Connections.SelectAdmin()
        If reader.Read Then
            frmChangePass.txtUsername.Text = reader.GetString("Username")
        End If
        con.Close()
        frmChangePass.Show()
        Me.Enabled = False
        frmChangePass.TopMost = True
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        PictureBox1.Image = My.Resources.NLCF_SEAL
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtIDNumber.Text = "" Then
            MessageBox.Show("Please Insert ID Number ")
        Else
            con.Open()
            Connections.SelectUserAccount()
            If reader.HasRows Then
                con.Close()
                con.Open()
                Connections.SelectAdminAccount()
                If reader.HasRows Then
                    MessageBox.Show("ID Number Already Registered")
                Else
                    con.Close()
                    con.Open()
                    Connections.SelectAdminAccount()
                    If reader.Read Then
                        reader.GetString(1)
                        MessageBox.Show("Username Already Taken")
                    Else
                        con.Close()
                        If frmMain.Access = "Super Admin" Then
                            If txtUsername.Text = "" Then
                                MessageBox.Show("Please Insert Username")
                            ElseIf txtPassword.Text = "" Then
                                MessageBox.Show("Please Insert Password")
                            ElseIf cbAccesstype.Text = "" Then
                                MessageBox.Show("Please Insert Access Type")
                            Else
                                con.Open()
                                Connections.AddAdminPastor()
                                con.Close()
                                MessageBox.Show("Successfully Added")
                                btnClear_Click(sender, e)
                                con.Open()
                                Connections.loadadmin()
                                con.Close()
                            End If
                        Else
                            If txtUsername.Text = "" Then
                                MessageBox.Show("Please Insert Username")
                            ElseIf txtPassword.Text = "" Then
                                MessageBox.Show("Please Insert Password")
                            Else
                                con.Open()
                                Connections.AddAdminUsher()
                                con.Close()
                                MessageBox.Show("Successfully Added")
                                txtIDNumber.Clear()
                                txtUsername.Clear()
                                txtPassword.Clear()
                                cbAccesstype.SelectedIndex = -1
                                con.Open()
                                Connections.loadadmin()
                                con.Close()
                            End If
                        End If
                    End If
                End If
            Else
                MessageBox.Show("ID Number Is Not Register")
            End If
        End If
        con.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If id = Nothing Then
            MessageBox.Show("Please Select")
        Else
            Dim result As Integer = MessageBox.Show("Delete This Account?!!", "DELETE", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                con.Open()
                Connections.DeleteAdmin()
                con.Close()
                loadadmin()
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub

    Private Sub txtIDNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDNumber.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex
        Dim status As String
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            lblID.Text = selectedRow.Cells(0).Value.ToString()
            id = lblID.Text
            lblUsername.Text = selectedRow.Cells(1).Value.ToString()
            lblStatus.Text = selectedRow.Cells(2).Value.ToString()
            status = selectedRow.Cells(3).Value.ToString()

            If status = "Activate" Then
                btnActivate.Text = "De-Activate"
            Else
                btnActivate.Text = "Activate"

            End If


            con.Open()
            Connections.ReadImageAdminAccount()
            If reader.HasRows Then
                reader.Read()
                Dim data As Byte() = DirectCast(reader("Image"), Byte())
                Dim ms As New MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                PictureBox1.Image = My.Resources.NLCF_SEAL
            End If
            con.Close()
        End If
        con.Open()
        Connections.SelectAdminID()
        If reader.Read Then
            txtLname.Text = reader.GetString(1).ToString()
            txtFname.Text = reader.GetString(2).ToString()
            txtMi.Text = reader.GetString(3).ToString()
            cbGender.Text = reader.GetString(4).ToString()
            cbStatus.Text = reader.GetString(5).ToString()
            DateTimePicker1.CustomFormat = reader.GetString(6).ToString()
            txtAddress.Text = reader.GetString(7).ToString()
            txtContact.Text = reader.GetString(8).ToString()
            txtCategory.Text = reader.GetString(9).ToString()
            txtEmail.Text = reader.GetString(10).ToString()
            txtCellLeader.Text = reader.GetString(11).ToString()
            txtNetLeader.Text = reader.GetString(12).ToString()
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        con.Open()
        Connections.SearchAllAdmin()
        con.Close()
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIDNumber.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cbAccesstype.SelectedIndex = -1
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If id = Nothing Then
            MessageBox.Show("Please Select")
        Else
            Dim Letters As New List(Of Integer)

            'add ASCII codes for numbers
            For i As Integer = 48 To 57
                Letters.Add(i)
            Next
            'lowercase letters
            For i As Integer = 97 To 122
                Letters.Add(i)
            Next
            'uppercase letters
            For i As Integer = 65 To 90
                Letters.Add(i)
            Next
            'select 5 random integers from number of items in Letters
            'then convert those random integers to characters and
            'add each to a string and display in Textbox
            Dim Rnd As New Random
            Dim SB As New System.Text.StringBuilder
            Dim Temp As Integer
            For count As Integer = 1 To 5
                Temp = Rnd.Next(0, Letters.Count)
                SB.Append(Chr(Letters(Temp)))
            Next
            Reset = SB.ToString
            Dim result As Integer = MessageBox.Show("Are you sure to reset your password", "Password Reset", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                con.Open()
                Connections.ResetAdminPass()
                con.Close()
                con.Open()
                Connections.loadadmin()
                con.Close()
            ElseIf result = DialogResult.No Then
            End If
        End If

    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        If btnActivate.Text = "Activate" Then
            con.Open()
            Connections.Activate()
            btnActivate.Text = "De-Activate"
            con.Close()
        Else
            con.Open()
            Connections.DeActivate()
            btnActivate.Text = "Activate"
            con.Close()
        End If
        con.Open()
        Connections.loadadmin()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class