Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class frmAddUser

    Dim myconn As MySqlConnection

    Dim command As MySqlCommand

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        frmAdmin.txtSearch_TextChanged(sender, e)
        frmAddUser_Load(sender, e)
        If frmMain.Access = "Super Admin" Then
            Me.Hide()
            frmAdmin.Show()
        ElseIf frmMain.Access = "Admin" Then
            Me.Hide()
            frmAdmin.Show()
        Else
            Me.Hide()
            frmMain.tmTimeDate.Start()
            frmMain.Show()
        End If

        frmAdmin.PictureBox1.Image = My.Resources.NLCF_SEAL
        txtAddress.Clear()
        txtContact.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtMi.Clear()
        txtEmail.Clear()
        txtCategory.Clear()
        cbCivilStatus.SelectedIndex = -1
        cbGender.SelectedIndex = -1
        Template = Nothing
    End Sub

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dt As Date = Date.Today
        Dim id = dt.ToString("yy", CultureInfo.InvariantCulture)
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
                    lblIDResult.Text = nextid + 1
                Else
                    lblIDResult.Text = id & 1001
                End If
                con.Close()
            End If
        Else
            lblIDResult.Text = id & 1001
        End If
        con.Close()
        If txtLname.Text = "" Then
            MessageBox.Show("Insert Last Name")
        ElseIf txtFname.Text = "" Then
            MessageBox.Show("Insert First Name")
        ElseIf Template Is Nothing Then
            MessageBox.Show("Insert Bio!")
        ElseIf cbGender.SelectedIndex = -1 Then
            MessageBox.Show("Insert Gender")
        ElseIf cbCivilStatus.SelectedIndex = -1 Then
            MessageBox.Show("Insert Status")

        Else
            'Dim stream As New System.IO.MemoryStream()
            'PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'pic = stream.GetBuffer
            'stream.Close()
            con.Open()
            Connections.AddUser()
            cmd.Parameters.AddWithValue("@photo", pic)
            cmd.Parameters.Add(New MySqlParameter("@FP", Template.Bytes))
            reader = cmd.ExecuteReader()
            con.Close()
            Template = Nothing
            MessageBox.Show("Success fully Added")
            con.Open()
            Connections.nextID()
            If reader.HasRows Then
                If reader.Read Then
                    id = reader.GetString(0)
                    lblIDResult.Text = id + 1
                End If
            End If
            con.Close()
            frmAddUser_Load(sender, e)
            PictureBox1.Image = Nothing
            txtAddress.Clear()
            txtHouseNo.Clear()
            txtStreat.Clear()
            txtBarangay.Clear()
            txtCity.Clear()
            txtProvince.Clear()
            txtCountry.Clear()
            txtZip.Clear()
            txtContact.Clear()
            txtFname.Clear()
            txtLname.Clear()
            txtMi.Clear()
            txtEmail.Clear()
            txtCategory.Clear()
            cbCivilStatus.SelectedIndex = -1
            cbGender.SelectedIndex = -1
        End If
    End Sub

    Private Sub txtCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        frmWebcame.Show()
        frmWebcame.PictureBox1.Image = Nothing
        frmWebcame.PictureBox2.Image = Nothing
    End Sub

    Private Sub txtBrowse_Click(sender As Object, e As EventArgs) Handles txtBrowse.Click
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

    Private Sub frmAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As Date = Date.Today
        Dim id = dt.ToString("yy", CultureInfo.InvariantCulture)
        txtLname.Focus()
        con.Open()
        Connections.CountAllReg()
        If reader.Read Then
            lblRegCount.Text = reader.GetString(0)
            frmAdmin.lblCountAllUser.Text = reader.GetString(0)
        End If
        con.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLname.Clear()
        txtFname.Clear()
        txtMi.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        cbGender.SelectedIndex = -1
        cbCivilStatus.SelectedIndex = -1
        txtCategory.Clear()
        cbCellLeader.SelectedIndex = -1
        cbNetworkLeader.SelectedIndex = -1
        Template = Nothing
        PictureBox1.Image = Nothing
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

    Private Template As DPFP.Template
End Class