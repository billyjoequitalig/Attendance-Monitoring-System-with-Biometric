Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Drawing.Imaging

Delegate Sub Functioncall(ByVal param)
Public Class frmAdmin
    Dim myconn As MySqlConnection
    Dim command As MySqlCommand
    Private com As SqlCommand
    Public searchid As String
    Public getid As String
    Public sortcateg As String
    Public sort As String
    Public pic() As Byte
    Private Template As DPFP.Template

    Public Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmMain.tmTimeDate.Start()
        frmMain.tmSundaySched.Start()
        frmMain.Show()
        frmMain.Access = ""
        frmMain.txtUsername.Focus()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dt As Date = Date.Today
        Dim id = dt.ToString("yy", CultureInfo.InvariantCulture)
        con.Open()
        Connections.CountAllReg()
        If reader.Read Then
            frmAddUser.Text = reader.GetValue(0).ToString
        End If
        con.Close()
        con.Open()
        Connections.CheckUser()
        If reader.HasRows Then
            con.Close()
            con.Open()
            Connections.nextID()
            If reader.Read Then
                Dim nextid As Integer
                Dim year As Integer
                nextid = reader.GetString(0)
                year = reader.GetString(0).Substring(0, 2)
                If year = id Then
                    frmAddUser.lblIDResult.Text = nextid + 1
                Else
                    frmAddUser.lblIDResult.Text = id & 1001
                End If
                con.Close()
            End If
        Else
            frmAddUser.lblIDResult.Text = id & 1001
        End If
        con.Close()
        txtLname.Focus()
        frmAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If getid = Nothing Then
            MessageBox.Show("Please Select User")
        Else
            Dim result As Integer = MessageBox.Show("Delete This Account?!!", "DELETE", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                con.Open()
                Connections.DeleteUser()
                con.Close()
                con.Open()
                Connections.DeleteUserAdmin()
                con.Close()
                txtSearch_TextChanged(sender, e)
                PictureBox1.Image = My.Resources.NLCF_SEAL
            ElseIf result = DialogResult.No Then
            End If
        End If
    End Sub

    Public Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        lblCountDatagrid.Text = DataGridView1.RowCount
        If cbSort.Text = "ID Number" Then
            sort = "User_Id"
        ElseIf cbSort.Text = "Last Name" Then
            sort = "Lname"
        ElseIf cbSort.Text = "First Name" Then
            sort = "Fname"
        End If
        If cbSort.Text = "All" And cbCategory.Text = "All" And cbSearchNet.Text = "All" And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.SearchAll()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSort.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchBy()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbCategory.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchCateg()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchNet.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByNetLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchCell.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByCellLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If

        'sortcateg = cbCategory.SelectedItem
        'If sort = "All" And sortcateg = "All" Then
        '    con.Open()
        '    Connections.SearchAll()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '        con.Close()
        '    End If
        'ElseIf sortcateg = "Adult" Then
        '    con.Open()
        '    Connections.SearchAdult()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sortcateg = "Youth" Then
        '    con.Open()
        '    Connections.SearchYouth()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sortcateg = "Kids" Then
        '    con.Open()
        '    Connections.SearchKids()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sortcateg = "Toddlers" Then
        '    con.Open()
        '    Connections.SearchToddler()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sort = "ID Number" Then
        '    sort = "User_id"
        '    con.Open()
        '    Connections.Search()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sort = "Last Name" Then
        '    sort = "Lname"
        '    con.Open()
        '    Connections.Search()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'ElseIf sort = "First Name" Then
        '    sort = "Fname"
        '    con.Open()
        '    Connections.Search()
        '    lblCountDatagrid.Text = DataGridView1.RowCount
        '    con.Close()
        '    con.Open()
        '    Connections.CountAllReg()
        '    If reader.Read Then
        '        lblCountAllUser.Text = reader.GetString(0)
        '    End If
        '    con.Close()
        'End If
    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Connections.CountAllReg()
        If reader.Read Then
            lblCountAllUser.Text = reader.GetString(0)
        End If
        con.Close()
        cbCategory.SelectedIndex = 0
        cbSort.SelectedIndex = 0
        cbSearchNet.Items.Add("All")
        cbSearchCell.Items.Add("All")
        cbSearchNet.SelectedIndex = 0
        cbSearchCell.SelectedIndex = 0
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
       If cbSort.Text = "ID Number" Then
            sort = "User_Id"
        ElseIf cbSort.Text = "Last Name" Then
            sort = "Lname"
        ElseIf cbSort.Text = "First Name" Then
            sort = "Fname"
        End If
        If cbSort.Text = "All" And cbCategory.Text = "All" And cbSearchNet.Text = "All" And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.SearchAll()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSort.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchBy()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbCategory.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchCateg()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchNet.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByNetLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchCell.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByCellLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Public Sub ViewAdminAccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAdminAccountToolStripMenuItem1.Click
        If frmMain.Access = "Super Admin" Then
            con.Open()
            Connections.loadadmin()
            con.Close()
            frmAdminAccount.Show()
            frmAdminAccount.btnActivate.Show()
            frmAdminAccount.btnReset.Show()
            frmAdminAccount.cbAccesstype.Show()
            frmAdminAccount.lblAccessType.Show()
        Else
            frmAdminAccount.btnActivate.Hide()
            frmAdminAccount.btnReset.Hide()
            frmAdminAccount.cbAccesstype.Hide()
            frmAdminAccount.lblAccessType.Hide()
            frmAdminAccount.Show()
        End If
    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        frmWebcame.Show()
    End Sub

    Private Sub txtBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim OpenImage As New OpenFileDialog
        With OpenImage
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
            .FilterIndex = 2
            If .ShowDialog = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(.FileName)
            End If
        End With
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If getid = "" Then
            MessageBox.Show("Please Select User!")
        Else
            If Not PictureBox1.Image Is Nothing Then
                con.Open()
                Dim result As Integer = MessageBox.Show("Update This Account?!!", "UPDATE", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Dim stream As New System.IO.MemoryStream()
                    Me.PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    pic = stream.GetBuffer
                    stream.Close()
                    Connections.UpdateUser()
                    cmd.Parameters.Add(New MySqlParameter("@FP", Template.Bytes))
                    cmd.Parameters.AddWithValue("@photo", pic)
                    reader = cmd.ExecuteReader
                    con.Close()
                    cbCategory_SelectedIndexChanged(sender, e)
                ElseIf result = DialogResult.No Then
                End If
                con.Close()
                btnEdit.Enabled = True
                btnSave.Enabled = False
                txtLname.Enabled = False
                txtFname.Enabled = False
                txtMi.Enabled = False
                cbGender.Enabled = False
                cbStatus.Enabled = False
                DateTimePicker1.Enabled = False
                txtAddress.Enabled = False
                txtContact.Enabled = False
                txtCategory.Enabled = False
                txtEmail.Enabled = False
                cbCellLeader.Enabled = False
                cbNetworkLeader.Enabled = False
                btnCamera.Enabled = False
                btnBrowse.Enabled = False
                btnBio.Enabled = False
            Else
                con.Open()
                Connections.UpdateUserWithoutImage()
                cmd.Parameters.Add(New MySqlParameter("@FP", Template.Bytes))
                reader = cmd.ExecuteReader
                con.Close()
                btnEdit.Enabled = True
                btnSave.Enabled = False
                txtLname.Enabled = False
                txtFname.Enabled = False
                txtMi.Enabled = False
                cbGender.Enabled = False
                cbStatus.Enabled = False
                DateTimePicker1.Enabled = False
                txtAddress.Enabled = False
                txtContact.Enabled = False
                txtCategory.Enabled = False
                txtEmail.Enabled = False
                cbCellLeader.Enabled = False
                cbNetworkLeader.Enabled = False
                btnCamera.Enabled = False
                btnBrowse.Enabled = False

                MessageBox.Show("Successfuly")
                cbCategory_SelectedIndexChanged(sender, e)
            End If

        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DateTimePicker1.Update()
        If getid = "" Then
            MessageBox.Show("Please Select User!")
        Else
            cbSort.SelectedIndex = 0
            cbCategory.SelectedIndex = 0
            btnEdit.Enabled = False
            btnSave.Enabled = True
            txtLname.Enabled = True
            txtFname.Enabled = True
            txtMi.Enabled = True
            cbGender.Enabled = True
            cbStatus.Enabled = True
            DateTimePicker1.Enabled = True
            txtAddress.Enabled = True
            txtContact.Enabled = True
            txtEmail.Enabled = True
            cbCellLeader.Enabled = True
            cbNetworkLeader.Enabled = True
            btnCamera.Enabled = True
            btnBrowse.Enabled = True
            btnBio.Enabled = True
        End If
    End Sub

    Private Sub LeadersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadersToolStripMenuItem.Click
        frmLeaders.Show()
    End Sub

    Public Sub SundayServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SundayServicesToolStripMenuItem.Click
        frmServices.Show()
        Me.Hide()
        frmServices.SundayServicesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ViewReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewReportToolStripMenuItem1.Click
        frmWeeklyReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnBio_Click(sender As Object, e As EventArgs) Handles btnBio.Click
        Dim Enroller As New EnrollmentForm()
        AddHandler Enroller.OnTemplate, AddressOf OnTemplate
        Enroller.ShowDialog()
    End Sub

    Private Sub OnTemplate(ByVal template)
        Invoke(New Functioncall(AddressOf _OnTemplate), template)
    End Sub

    Private Sub _OnTemplate(ByVal template)
        Me.Template = template
        If Not template Is Nothing Then
            'MessageBox.Show("The fingerprint template is ready for fingerprint .", "Fingerprint Capture")
        Else
            'MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim bday As String
        Dim index As Integer = e.RowIndex
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            getid = selectedRow.Cells(0).Value.ToString()
            txtLname.Text = selectedRow.Cells(1).Value.ToString()
            txtFname.Text = selectedRow.Cells(2).Value.ToString()
            txtMi.Text = selectedRow.Cells(3).Value.ToString()
            cbGender.Text = selectedRow.Cells(4).Value.ToString()
            cbStatus.Text = selectedRow.Cells(5).Value.ToString()
            bday = selectedRow.Cells(6).Value.ToString
            Dim expenddt As Date = Date.ParseExact(bday, "MM/dd/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            DateTimePicker1.Value = expenddt
            txtAddress.Text = selectedRow.Cells(7).Value.ToString()
            txtContact.Text = selectedRow.Cells(8).Value.ToString()
            txtCategory.Text = selectedRow.Cells(9).Value.ToString()
            txtEmail.Text = selectedRow.Cells(10).Value.ToString()
            cbCellLeader.Text = selectedRow.Cells(11).Value.ToString()
            cbNetworkLeader.Text = selectedRow.Cells(12).Value.ToString()
            con.Open()
            Connections.readimage()
            If reader.HasRows Then
                reader.Read()
                Dim data As Byte() = DirectCast(reader("Image"), Byte())
                Dim ms As New MemoryStream(data)
                PictureBox1.Image = Image.FromStream(ms)
            Else
                PictureBox1.Image = Nothing
            End If
            con.Close()

            con.Open()
            Connections.UpdateFP()
            Dim templa8 As DPFP.Template = New DPFP.Template()
            Dim MemStream As IO.MemoryStream
            Dim found As Boolean = False
            If reader.HasRows Then
                While reader.Read
                    Dim fpBytes As Byte()
                    fpBytes = reader("FPrint")
                    MemStream = New IO.MemoryStream(fpBytes)
                    templa8.DeSerialize(MemStream)
                    Template = templa8
                End While
            End If
            con.Close()
            btnSave.Enabled = False
            txtLname.Enabled = False
            txtFname.Enabled = False
            txtMi.Enabled = False
            cbGender.Enabled = False
            cbStatus.Enabled = False
            DateTimePicker1.Enabled = False
            txtAddress.Enabled = False
            txtContact.Enabled = False
            txtCategory.Enabled = False
            txtEmail.Enabled = False
            cbCellLeader.Enabled = False
            cbNetworkLeader.Enabled = False
            btnCamera.Enabled = False
            btnBrowse.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub cbCellLeader_DropDown(sender As Object, e As EventArgs) Handles cbCellLeader.DropDown
        cbCellLeader.Items.Clear()
        con.Open()
        Connections.SelectCellLeader()
        While reader.Read
            Dim fullname = reader.GetString(2)
            cbCellLeader.Items.Add(fullname)
        End While
        con.Close()
        con.Dispose()
    End Sub

    Private Sub cbNetworkLeader_DropDown(sender As Object, e As EventArgs) Handles cbNetworkLeader.DropDown
        cbNetworkLeader.Items.Clear()
        con.Open()
        Connections.SelectNetLeader()
        While reader.Read
            Dim fullname = reader.GetString(2)
            cbNetworkLeader.Items.Add(fullname)
        End While
        con.Close()
        con.Dispose()
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

    Private Sub cbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSort.SelectedIndexChanged
        If cbSort.Text = "ID Number" Then
            sort = "User_Id"
        ElseIf cbSort.Text = "Last Name" Then
            sort = "Lname"
        ElseIf cbSort.Text = "First Name" Then
            sort = "Fname"
        End If
        If cbSort.Text = "All" And cbCategory.Text = "All" And cbSearchNet.Text = "All" And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.SearchAll()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSort.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchBy()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbCategory.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchCateg()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchNet.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByNetLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchCell.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByCellLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Private Sub cbSearchNet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchNet.SelectedIndexChanged
        If cbSort.Text = "ID Number" Then
            sort = "User_Id"
        ElseIf cbSort.Text = "Last Name" Then
            sort = "Lname"
        ElseIf cbSort.Text = "First Name" Then
            sort = "Fname"
        End If
        If cbSort.Text = "All" And cbCategory.Text = "All" And cbSearchNet.Text = "All" And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.SearchAll()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSort.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchBy()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbCategory.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchCateg()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchNet.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByNetLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchCell.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByCellLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Private Sub cbSearchCell_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearchCell.SelectedIndexChanged
        If cbSort.Text = "ID Number" Then
            sort = "User_Id"
        ElseIf cbSort.Text = "Last Name" Then
            sort = "Lname"
        ElseIf cbSort.Text = "First Name" Then
            sort = "Fname"
        End If
        If cbSort.Text = "All" And cbCategory.Text = "All" And cbSearchNet.Text = "All" And cbSearchCell.Text = "All" Then
            con.Open()
            Connections.SearchAll()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSort.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchBy()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbCategory.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchCateg()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchNet.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByNetLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        ElseIf cbSearchCell.SelectedIndex >= 1 Then
            con.Open()
            Connections.SearchByCellLead()
            lblCountDatagrid.Text = DataGridView1.RowCount
            con.Close()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim year = DateTimePicker1.Value.ToString("yyyy")
        Dim yearnow = DateTime.Now.ToString("yyyy")
        Dim result = yearnow - year
        Select Case result
            Case 0 To 10
                txtCategory.Text = "Kids"
            Case 11 To 13
                txtCategory.Text = "Pre-Teen"
            Case 14 To 19
                txtCategory.Text = "Youth"
            Case 20 To 30
                txtCategory.Text = "Young Adult"
            Case 31 To 1000
                txtCategory.Text = "Adult"
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class