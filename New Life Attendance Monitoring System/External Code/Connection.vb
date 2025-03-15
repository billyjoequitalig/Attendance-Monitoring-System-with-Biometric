Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO
Imports System.Data.SqlClient

Module Connections
    Dim Username As String
    Public host As String = "localhost"
    Public user As String = "root"
    Public pass As String = ""
    Public db As String = "attendancedb"
    Public con As New MySqlConnection("Server=" + host + ";User Id=" + user + ";Password=" + pass + ";database=" + db + ";")
    Public cmd As New MySqlCommand
    Public reader As MySqlDataReader
    Dim mydata As New MySqlDataAdapter
    Dim datatable As New DataTable
    Dim source As New BindingSource
    Public pic() As Byte
    Dim Query As String
    Public id As String
    Dim getUserID As String
    Public FromMainID As String
    Dim Status As String


    Sub Login()
        Query = "SELECT * FROM admin WHERE Username='" & frmMain.txtUsername.Text.Replace("'", "`").Replace("\", "/") & "' AND Password = '" & frmMain.txtPassword.Text.Replace("'", "`").Replace("\", "/") & "' AND Status = 'Activate'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub CurrentLogin()
        Query = "SELECT * FROM Users WHERE User_Id ='" & frmMain.AdminId & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub AddUser()
        Dim Gender As String = frmAddUser.cbGender.SelectedItem
        Dim Status As String = frmAddUser.cbCivilStatus.SelectedItem
        Query = "INSERT INTO users(User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader,Image,FPrint) VALUES ('" & frmAddUser.lblIDResult.Text.Replace("'", "`") & "','" & frmAddUser.txtLname.Text.Replace("'", "`") & "','" & frmAddUser.txtFname.Text.Replace("'", "`") & "','" & frmAddUser.txtMi.Text.Replace("'", "`") & "','" & frmAddUser.cbGender.SelectedItem & "','" & frmAddUser.cbCivilStatus.SelectedItem & "','" & frmAddUser.DateTimePicker1.Text.Replace("'", "`") & "','" & "P." & frmAddUser.txtAddress.Text.Replace("'", "`") & ", " & "#" & frmAddUser.txtHouseNo.Text & ", " & frmAddUser.txtStreat.Text & ", " & frmAddUser.txtBarangay.Text & ", " & frmAddUser.txtCity.Text & ", " & frmAddUser.txtProvince.Text & ", " & frmAddUser.txtZip.Text & ", " & frmAddUser.txtCountry.Text & "','" & frmAddUser.txtContact.Text.Replace("'", "`") & "','" & frmAddUser.txtCategory.Text.Replace("'", ("`")) & "','" & frmAddUser.txtEmail.Text.Replace("'", "`") & "','" & frmAddUser.cbCellLeader.Text.Replace("'", "`") & "','" & frmAddUser.cbNetworkLeader.Text.Replace("'", "`") & "',@photo,@FP)"
        cmd = New MySqlCommand(Query, con)

    End Sub

    Sub AddAdminPastor()
        Query = "INSERT INTO admin (Admin_Id,Username,Password,AccessType,Status) VALUES ('" & frmAdminAccount.txtIDNumber.Text & "','" & frmAdminAccount.txtUsername.Text & "','" & frmAdminAccount.txtPassword.Text & "','" & frmAdminAccount.cbAccesstype.Text & "','Activate')"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub AddAdminUsher()
        Query = "INSERT INTO admin (Admin_Id,Username,Password,AccessType,Status) VALUES ('" & frmAdminAccount.txtIDNumber.Text & "','" & frmAdminAccount.txtUsername.Text & "','" & frmAdminAccount.txtPassword.Text & "','Admin','De-Activate')"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub AddPosition()
        Query = "INSERT INTO leaders (User_Id,Generation,Position) VALUES ('" & frmLeaders.txtIDNum.Text.Replace("'", "`") & "','" & frmLeaders.txtGeneration.Text.Replace("'", "`") & "','" & frmLeaders.cbPosition.Text & "')"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub


    Sub Generation()
        Query = "SELECT MAX(Generation) FROM leaders"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SelectCellLeader()
        Query = "SELECT * FROM leaders WHERE Position = 'Cell Leader' ORDER BY FullName ASC"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SelectNetLeader()
        Query = "SELECT * FROM leaders WHERE Position = 'Network Leader' ORDER BY FullName ASC"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub UpdateLeadFullname()
        Query = "UPDATE leaders SET FullName = (SELECT CONCAT(Lname,' ',Fname,' ',MI,'.') FROM users WHERE User_id = '" & frmLeaders.txtIDNum.Text.Replace("'", "`") & "') WHERE User_Id = '" & frmLeaders.txtIDNum.Text.Replace("'", "`") & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SelectLeadNum()
        Query = "SELECT * FROM users WHERE User_id = '" & frmLeaders.txtIDNum.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub leaderExist()
        Query = "SELECT * FROM leaders WHERE User_id = '" & frmLeaders.txtIDNum.Text & "' AND Position = '" & frmLeaders.cbPosition.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SelectUserAccount()
        Query = "SELECT * FROM users WHERE User_id = '" & frmAdminAccount.txtIDNumber.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SelectAdminAccount()
        Query = "SELECT * FROM Admin WHERE Admin_Id = '" & frmAdminAccount.txtIDNumber.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub CheckExist()
        Query = "SELECT * FROM Admin"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub DeleteUser()
        Query = "DELETE FROM users WHERE User_Id NOT IN (SELECT * FROM (SELECT User_id FROM users ORDER BY User_id LIMIT 1)a) AND User_id = '" & frmAdmin.getid & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub DeleteUserAdmin()
        Query = "DELETE FROM admin WHERE Admin_Id NOT IN (SELECT * FROM (SELECT admin_id FROM admin ORDER BY admin_id LIMIT 1)a) AND Admin_id = '" & frmAdmin.getid & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub DeleteAdmin()
        Query = "DELETE FROM admin WHERE Admin_Id NOT IN (SELECT * FROM (SELECT admin_id FROM admin ORDER BY admin_id LIMIT 1)a) AND Admin_id = '" & frmAdminAccount.lblID.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub DeleteLeaders()
        Query = "DELETE FROM leaders WHERE Leaders_Id ='" & frmLeaders.leaderID & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub UpdateUser()
        Query = "UPDATE users SET Lname='" & frmAdmin.txtLname.Text.Replace("'", "`") & "', Fname='" & frmAdmin.txtFname.Text.Replace("'", "`") & "', MI='" & frmAdmin.txtMi.Text.Replace("'", "`") & "', Gender ='" & frmAdmin.cbGender.Text.Replace("'", "`") & "', Status ='" & frmAdmin.cbStatus.Text & "', Bday='" & frmAdmin.DateTimePicker1.Text & "', Address='" & frmAdmin.txtAddress.Text.Replace("'", "`") & "', Contact='" & frmAdmin.txtContact.Text.Replace("'", "`") & "', Category='" & frmAdmin.txtCategory.Text.Replace("'", "`") & "', Email='" & frmAdmin.txtEmail.Text.Replace("'", "`") & "',Cell_Leader='" & frmAdmin.cbCellLeader.Text.Replace("'", "`") & "',Network_Leader='" & frmAdmin.cbNetworkLeader.Text.Replace("'", "`") & "',Image=@photo,FPrint=@FP WHERE User_Id ='" & frmAdmin.getid & "'"
        cmd = New MySqlCommand(Query, con)
    End Sub

    Sub UpdateUserWithoutImage()
        Query = "UPDATE users SET Lname='" & frmAdmin.txtLname.Text.Replace("'", "`") & "', Fname='" & frmAdmin.txtFname.Text.Replace("'", "`") & "', MI='" & frmAdmin.txtMi.Text.Replace("'", "`") & "', Gender ='" & frmAdmin.cbGender.Text.Replace("'", "`") & "', Status ='" & frmAdmin.cbStatus.Text & "', Bday='" & frmAdmin.DateTimePicker1.Text & "', Address='" & frmAdmin.txtAddress.Text.Replace("'", "`") & "', Contact='" & frmAdmin.txtContact.Text.Replace("'", "`") & "', Category='" & frmAdmin.txtCategory.Text.Replace("'", "`") & "', Email='" & frmAdmin.txtEmail.Text.Replace("'", "`") & "',Cell_Leader='" & frmAdmin.cbCellLeader.Text.Replace("'", "`") & "',Network_Leader='" & frmAdmin.cbNetworkLeader.Text.Replace("'", "`") & "',FPrint=@FP WHERE User_Id ='" & frmAdmin.getid & "'"
        cmd = New MySqlCommand(Query, con)
    End Sub

    Sub DeActivate()
        Query = "UPDATE admin SET Status='De-Activate' WHERE Admin_Id = '" & frmAdminAccount.lblID.Text.Replace("'", "`") & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub Activate()
        Query = "UPDATE admin SET Status='Activate' WHERE Admin_Id = '" & frmAdminAccount.lblID.Text.Replace("'", "`") & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub ChangeUser()
        Query = "UPDATE admin SET Username ='" & frmChangePass.txtUsername.Text.Replace("'", "`") & "' WHERE Admin_Id = '" & frmMain.AdminId & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub


    Sub SelectAdmin()
        Query = "SELECT * FROM admin WHERE Admin_Id = '" & frmMain.AdminId & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub SelectAdminPass()
        Query = "SELECT * FROM admin WHERE Password = '" & frmChangePass.txtCurrent.Text.Replace("'", "`") & "' AND Admin_id ='" & frmMain.AdminId & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub UpdateAdminpass()
        Query = "UPDATE admin SET Password = '" & frmChangePass.txtReType.Text.Replace("'", "`") & "' WHERE Admin_Id = '" & frmMain.AdminId & "' AND Password = '" & frmChangePass.txtCurrent.Text.Replace("'", "`") & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub ResetAdminPass()
        Query = "UPDATE admin SET Password = '" & frmAdminAccount.reset & "' WHERE Admin_Id = '" & frmAdminAccount.id & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub readimage()
        Query = "SELECT Image FROM users WHERE User_Id='" & frmAdmin.getid & "' AND Image IS NOT NULL"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub ReadImageLogin()
        Query = "SELECT Image FROM users WHERE User_Id='" & getUserID & "' AND Image IS NOT NULL"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub ReadImageAdminAccount()
        Query = "SELECT Image FROM users WHERE User_Id='" & frmAdminAccount.lblID.Text & "' AND Image IS NOT NULL"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub CheckUser()
        Query = "SELECT * FROM users"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub SelectFPuser()
        Query = "SELECT * FROM users"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub UpdateFP()
        Query = "SELECT * FROM users WHERE User_Id = '" & frmAdmin.getid & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub nextID()
        Query = "SELECT Max(User_id) FROM Users"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()

    End Sub

    Sub loadUsers()
        Dim dataset As New DataSet
        Query = "SELECT User_id,Lname,Fname,MI,Gender,Status,Bday,address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub loadadmin()
        Dim dataset As New DataSet
        Query = "SELECT * FROM admin"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdminAccount.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SelectAdminID()
        Query = "SELECT * FROM users WHERE User_Id = '" & frmAdminAccount.lblID.Text & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub SearchAll()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users WHERE CONCAT(User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email) LIKE '%" & frmAdmin.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchBy()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users WHERE " & frmAdmin.sort & " LIKE '%" & frmAdmin.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchCateg()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users WHERE Category='" & frmAdmin.cbCategory.Text & "' AND CONCAT(User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email) LIKE '%" & frmAdmin.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchByNetLead()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users WHERE Network_Leader ='" & frmAdmin.cbSearchNet.Text & "' AND CONCAT(User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email) LIKE '%" & frmAdmin.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchByCellLead()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email,Cell_Leader,Network_Leader FROM Users WHERE Cell_Leader ='" & frmAdmin.cbSearchCell.Text & "' AND CONCAT(User_Id,Lname,Fname,MI,Gender,Status,Bday,Address,Contact,Category,Email) LIKE '%" & frmAdmin.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdmin.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchAllAdmin()
        Dim dataset As New DataSet
        Query = "SELECT * FROM admin WHERE CONCAT(Admin_Id,Username,Password,AccessType,Status) LIKE '%" & frmAdminAccount.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmAdminAccount.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchPosition()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,FullName,Generation,Position FROM leaders WHERE Position = '" & frmLeaders.cbSearchPosition.Text & "' AND CONCAT(User_Id,FullName,Position) LIKE '%" & frmLeaders.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmLeaders.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchPosGen()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,FullName,Generation,Position FROM leaders WHERE Position = '" & frmLeaders.cbSearchPosition.Text & "' AND Generation = '" & frmLeaders.cbGeneration.Text & "' AND CONCAT(User_Id,FullName,Position) LIKE '%" & frmLeaders.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmLeaders.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchAllLeader()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,FullName,Generation,Position FROM leaders WHERE CONCAT(User_Id,FullName,Position) LIKE '%" & frmLeaders.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmLeaders.DataGridView1.DataSource = dataset.Tables(0)
    End Sub

    Sub SearchLeadGen()
        Dim dataset As New DataSet
        Query = "SELECT User_Id,FullName,Generation,Position FROM leaders WHERE Generation = '" & frmLeaders.cbGeneration.Text & "' AND CONCAT(User_Id,FullName,Position) LIKE '%" & frmLeaders.txtSearch.Text.Replace("'", "`") & "%'"
        mydata.SelectCommand = New MySqlCommand(Query, con)
        mydata.Fill(dataset)
        frmLeaders.DataGridView1.DataSource = dataset.Tables(0)
    End Sub


    Sub CountCell()
        Query = "SELECT COUNT(*) FROM Leaders WHERE Position = 'Cell Leader'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub CountNet()
        Query = "SELECT COUNT(*) FROM Leaders WHERE Position = 'Network Leader'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub


    Sub CountAllReg()
        Query = "SELECT COUNT(*) FROM Users"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub CountAttendToday()
        Dim datenow As String = DateTime.Now.ToString("MMMM dd, yyyy")
        Query = "SELECT COUNT(*) AS total FROM(SELECT *  FROM attendance WHERE Date = '" & datenow & "' GROUP BY User_id) AS result"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader
    End Sub

    Sub SelectMainID()
        Query = "SELECT * FROM Users WHERE User_id = '" & getUserID & "'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub TimeIn()
        Dim timein As String = TimeOfDay.ToString("h:mm tt")
        Dim datenow As String = DateTime.Now.ToString("MMMM dd, yyyy")
        Query = "INSERT INTO attendance(User_Id,Service,TimeIn,TimeOut,Date,Late) VALUES ('" & getUserID & "','" & ScheduleServices.CurrService & "','" & timein & "','','" & datenow & "','" & Status & "')"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub timeout()
        Query = "UPDATE Attendance SET TimeOut = '7:30:00 PM' WHERE TimeOut=''"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services1()
        Query = "UPDATE services SET Open = '" & frmServices.open1 & "' ,Close = '" & frmServices.close1 & "', Start = '" & frmServices.dtp1S.Text & "',End = '" & frmServices.dtp1E.Text & "' WHERE Service_Id = '1'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services2()
        Query = "UPDATE services SET Open = '" & frmServices.open2 & "' ,Close = '" & frmServices.close2 & "', Start = '" & frmServices.dtp2S.Text & "',End = '" & frmServices.dtp2E.Text & "' WHERE Service_Id = '2'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub Services3()
        Query = "UPDATE services SET Open = '" & frmServices.open3 & "' ,Close = '" & frmServices.close3 & "', Start = '" & frmServices.dtp3S.Text & "',End = '" & frmServices.dtp3E.Text & "' WHERE Service_Id = '3'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services4()
        Query = "UPDATE services SET Open = '" & frmServices.open4 & "' ,Close = '" & frmServices.close4 & "', Start = '" & frmServices.dtp4S.Text & "',End = '" & frmServices.dtp4E.Text & "' WHERE Service_Id = '4'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services5()
        Query = "UPDATE services SET Open = '" & frmServices.open5 & "' ,Close = '" & frmServices.close5 & "', Start = '" & frmServices.dtp5S.Text & "',End = '" & frmServices.dtp5E.Text & "' WHERE Service_Id = '5'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services6()
        Query = "UPDATE services SET Open = '" & frmServices.open6 & "' ,Close = '" & frmServices.close6 & "', Start = '" & frmServices.dtp6S.Text & "',End = '" & frmServices.dtp6E.Text & "' WHERE Service_Id = '6'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services7()
        Query = "UPDATE services SET Open = '" & frmServices.open7 & "' ,Close = '" & frmServices.close7 & "', Start = '" & frmServices.dtp7S.Text & "',End = '" & frmServices.dtp7E.Text & "' WHERE Service_Id = '7'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Services8()
        Query = "UPDATE services SET Open = '" & frmServices.open8 & "' ,Close = '" & frmServices.close8 & "', Start = '" & frmServices.dtp8S.Text & "',End = '" & frmServices.dtp8E.Text & "' WHERE Service_Id = '8'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub NoOfServices()
        Query = "UPDATE services SET NoOfServices = IF(Service_Id = '" & frmServices.selectedindex & "','1',0)"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub CountOfServices()
        Query = "SELECT * FROM services WHERE NoOfServices = '1'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get1()
        Query = "SELECT * FROM services WHERE Service_Id = '1'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get2()
        Query = "SELECT * FROM services WHERE Service_Id = '2'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get3()
        Query = "SELECT * FROM services WHERE Service_Id = '3'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get4()
        Query = "SELECT * FROM services WHERE Service_Id = '4'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get5()
        Query = "SELECT * FROM services WHERE Service_Id = '5'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get6()
        Query = "SELECT * FROM services WHERE Service_Id = '6'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get7()
        Query = "SELECT * FROM services WHERE Service_Id = '7'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub Get8()
        Query = "SELECT * FROM services WHERE Service_Id = '8'"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyAll()
        Query = "SELECT COUNT(*), Category, Service FROM attendance INNER JOIN users ON users.User_Id = attendance.User_Id  WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' GROUP BY attendance.User_Id ORDER BY attendance.Service,Users.Category"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyByLead()
        Query = "SELECT COUNT(*), Category, Service FROM attendance INNER JOIN users ON users.User_Id = attendance.User_Id  WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Network_Leader = '" & frmWeeklyReport.cbSearchNet.Text & "' AND Cell_Leader = '" & frmWeeklyReport.cbSearchCell.Text & "' GROUP BY attendance.User_Id ORDER BY attendance.Service,Users.Category"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyByNetLead()
        Query = "SELECT COUNT(*), Category, Service FROM attendance INNER JOIN users ON users.User_Id = attendance.User_Id  WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Network_Leader = '" & frmWeeklyReport.cbSearchNet.Text & "' GROUP BY attendance.User_Id ORDER BY attendance.Service,Users.Category"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub
    Sub WeeklyByCelltLead()
        Query = "SELECT COUNT(*), Category, Service FROM attendance INNER JOIN users ON users.User_Id = attendance.User_Id  WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Cell_Leader = '" & frmWeeklyReport.cbSearchCell.Text & "' GROUP BY attendance.User_Id ORDER BY attendance.Service,Users.Category"
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyTotalAll()
        Query = "SELECT COUNT(*),SUM(Ontime) AS TotalOnTime,SUM(late) AS TotalLate FROM(SELECT late = 'On Time' AS Ontime,late = 'Late' AS late FROM attendance WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' GROUP BY User_id) AS a "
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyTotalbyLead()
        Query = "SELECT COUNT(*),SUM(Ontime) AS TotalOnTime,SUM(late) AS TotalLate FROM(SELECT late = 'On Time' AS Ontime,late = 'Late' AS late FROM attendance INNER JOIN users ON Users.User_Id = attendance.User_Id WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Network_Leader = '" & frmWeeklyReport.cbSearchNet.Text & "' AND Cell_Leader = '" & frmWeeklyReport.cbSearchCell.Text & "' GROUP BY attendance.User_id) AS a "
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyTotalbyNetLead()
        Query = "SELECT COUNT(*),SUM(Ontime) AS TotalOnTime,SUM(late) AS TotalLate FROM(SELECT late = 'On Time' AS Ontime,late = 'Late' AS late FROM attendance INNER JOIN users ON users.User_Id = attendance.User_Id WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Network_Leader = '" & frmWeeklyReport.cbSearchNet.Text & "' GROUP BY attendance.User_id) AS a "
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub

    Sub WeeklyTotalbyCellLead()
        Query = "SELECT COUNT(*),SUM(Ontime) AS TotalOnTime,SUM(late) AS TotalLate FROM(SELECT late = 'On Time' AS Ontime,late = 'Late' AS late FROM attendance INNER JOIN users ON Users.User_Id = attendance.User_Id WHERE Date = '" & frmWeeklyReport.DateTimePicker1.Text & "' AND Cell_Leader = '" & frmWeeklyReport.cbSearchCell.Text & "' GROUP BY attendance.User_id) AS a "
        cmd = New MySqlCommand(Query, con)
        reader = cmd.ExecuteReader()
    End Sub


    Public Sub _getID(ByVal UserID)
        getUserID = UserID
        con.Close()
        con.Open()
        Connections.SelectMainID()
        If reader.Read Then
            frmMain.txtUserID.Text = getUserID
            frmMain.lblName.Text = reader.GetString(1) & ", " & reader.GetString(2) & " " & reader.GetString(3) & "."
            frmMain.lblCategory.Text = reader.GetString(9)
            con.Close()
            con.Open()
            ReadImageLogin()
            If reader.HasRows Then
                reader.Read()
                Dim data As Byte() = DirectCast(reader("Image"), Byte())
                Dim ms As New MemoryStream(data)
                frmMain.PictureBox1.Image = Image.FromStream(ms)
                con.Close()
            Else
                frmMain.PictureBox1.Image = My.Resources.NLCF_SEAL
            End If
            con.Close()
            If TimeOfDay > ScheduleServices.Dopen And TimeOfDay <= ScheduleServices.Dstart Then
                frmMain.lblStatus.Text = "On Time"
                Status = "On Time"
                con.Open()
                TimeIn()
                con.Close()
            ElseIf TimeOfDay >= ScheduleServices.Dstart Then
                frmMain.lblStatus.Text = "Late"
                Status = "Late"
                con.Open()
                TimeIn()
                con.Close()
            End If
            con.Open()
            CountAttendToday()
            If reader.Read Then
                frmMain.lblAttendCount.Text = reader.GetValue(0).ToString
                con.Close()
            End If
            con.Close()
        End If
    End Sub
End Module