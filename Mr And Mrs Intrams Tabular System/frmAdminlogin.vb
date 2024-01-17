Imports MySql.Data.MySqlClient
Public Class frmAdminlogin


 
 
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Static Dim counter As Integer
            If (txtUser.Text = "") Then
                MsgBox("Enter username.", MsgBoxStyle.Critical, "Required")
                txtUser.BackColor = Color.FromArgb(231, 22, 22)
                txtUser.Select()
                Exit Sub
            ElseIf (txtPass.Text = "") Then
                MsgBox("Enter password.", MsgBoxStyle.Critical, "Required")
                txtPass.BackColor = Color.FromArgb(231, 22, 22)
                txtPass.Select()
                Exit Sub
            Else
                counter = counter + 1 '3
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM admin WHERE USERNAME='" & txtUser.Text & "' AND PASSWORD='" & txtPass.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then '1

                    If counter = 3 Then
                        MessageBox.Show("You have reached your maximum login attempts.The program will now end.", "Error Login!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Application.Exit()
                    End If
                    MessageBox.Show("Invalid Username or Password!", "Error message.",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUser.Text = ""
                    txtPass.Text = ""
                    txtUser.Select()
                    MyCon.Close()
                    Exit Sub

                Else

                    MsgBox("You have successfully logged in.", MsgBoxStyle.Information, "Success")
                    frmAdmin.Show()
                    frmHome.Close()
                    Me.Close()
                    MyCon.Close()


                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = True
        Else
            txtPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

  

    Private Sub btnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        Label2.Visible = False
    End Sub


    Private Sub btnClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseEnter
        Label2.Visible = True
    End Sub

    Private Sub frmAdminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class