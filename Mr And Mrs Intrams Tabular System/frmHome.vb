Imports MySql.Data.MySqlClient
Public Class frmHome

    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlReg.Visible = False
        pnlResult.Visible = False
        pnlClose.Visible = False
        pnlAdmin.Visible = False
        JudID()
        txtJudFname.Enabled = False
        txtJudMname.Enabled = False
        txtJudLname.Enabled = False
        btnNext.Enabled = False
    End Sub

    Private Sub btnRegister_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseHover
        pnlReg.Visible = True
    End Sub

    Private Sub btnRegister_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.MouseLeave
        pnlReg.Visible = False
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        pnlClose.Visible = False
    End Sub

    Private Sub btnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        pnlClose.Visible = True
    End Sub

    Private Sub btnAdmin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.MouseHover
        pnlAdmin.Visible = True
    End Sub

    Private Sub btnAdmin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.MouseLeave
        pnlAdmin.Visible = False
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        DialogResult = MessageBox.Show("Are you sure you want to close the program?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If DialogResult = DialogResult.OK Then
            Application.Exit()
        End If
    End Sub

    Private Sub cboJudID_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJudID.SelectionChangeCommitted
        Try
            If cboJudID.Text = Nothing Then
                labelDisplay.Visible = True
                btnNext.Enabled = False
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM judge WHERE J_ID = '" & cboJudID.Text & "'"

                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows Then
                    MySQLData.Read()
                    txtJudFname.Text = MySQLData("J_FNAME")
                    txtJudMname.Text = MySQLData("J_MNAME")
                    txtJudLname.Text = MySQLData("J_LNAME")
                    btnNext.Enabled = True
                End If
                MyCon.Close()
                MySQLData.Close() 
                labelDisplay.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub JudID()
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM judge Order by J_ID"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader

            While (MySQLData.Read())
                cboJudID.Items.Add(MySQLData("J_ID"))
            End While
            MyCon.Close()
            MySQLData.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        frmCanRegister.ShowDialog()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        DialogResult = MessageBox.Show("Would you like to proceed to Judge Board?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If DialogResult = DialogResult.OK Then
            frmJudgeBoard.Show()
            txtJudID.Text = Nothing
            Me.Close()
        Else
            txtJudID.Clear()
            txtJudFname.Clear()
            txtJudMname.Clear()
            txtJudLname.Clear()
        End If

    End Sub

    
     
    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        frmAdminlogin.ShowDialog()

    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        pnlResult.Show()
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        pnlResult.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmRanking.ShowDialog()
    End Sub

    Private Sub txtJudID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJudID.TextChanged
        Try
            If txtJudID.Text = Nothing Then
                labelDisplay.Visible = True
                btnNext.Enabled = False
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM judge WHERE J_ID = '" & txtJudID.Text & "'"

                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows Then
                    MySQLData.Read()
                    txtJudFname.Text = MySQLData("J_FNAME")
                    txtJudMname.Text = MySQLData("J_MNAME")
                    txtJudLname.Text = MySQLData("J_LNAME")
                    btnNext.Enabled = True
                End If
                MyCon.Close()
                MySQLData.Close()
                labelDisplay.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
