Public Class frmChangePass

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmAdminAccount.TopMost = False
        frmAdminAccount.Enabled = True
        frmAdminAccount.Show()

    End Sub

    Private Sub btnPSave_Click(sender As Object, e As EventArgs) Handles btnPSave.Click
        If txtCurrent.Text = "" Then
            MessageBox.Show("Please Insert Current Password")
        ElseIf txtNew.Text = "" Then
            MessageBox.Show("Please Insert New Password!")
        ElseIf txtReType.Text = "" Then
            MessageBox.Show("Please Insert Retype Password!")
        Else
            con.Open()
            Connections.SelectAdminPass()
            If reader.Read Then
                con.Close()
                If Not txtNew.Text = txtReType.Text Then
                    MessageBox.Show("Password Not Match")
                Else
                    con.Open()
                    Connections.UpdateAdminpass()
                    con.Close()
                    Me.Hide()
                    frmAdminAccount.TopMost = False
                    frmAdminAccount.Enabled = True
                    MessageBox.Show("Success Fully Change")
                    frmAdminAccount.Show()
                    con.Open()
                    Connections.loadadmin()
                    con.Close()
                    txtCurrent.Clear()
                    txtNew.Clear()
                    txtReType.Clear()
                End If
            Else
                MessageBox.Show("Current Password Is Incorrect!")
            End If
            con.Close()

        End If
    End Sub

    Private Sub btnUSave_Click(sender As Object, e As EventArgs) Handles btnUSave.Click
        con.Open()
        Connections.ChangeUser()
        MessageBox.Show("Successfuly")
        con.Close()
        con.Open()
        Connections.loadadmin()
        con.Close()

    End Sub

    Private Sub txtCurrent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrent.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnPSave_Click(sender, e)
        End If
    End Sub

    Private Sub txtReType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReType.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnPSave_Click(sender, e)
        End If
    End Sub

    Private Sub txtNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNew.KeyPress
        Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
        If tmp.KeyChar = ChrW(Keys.Enter) Then
            btnPSave_Click(sender, e)
        End If
    End Sub

    Private Sub frmChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub
End Class