Imports MySql.Data.MySqlClient

Public Class frmCandidate

    Sub DataGrid()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_ID AS 'CANDIDATE ID', CAN_TEAM AS 'TEAM', CAN_FNAME AS 'FIRST NAME', CAN_MNAME AS 'MIDDLE NAME', CAN_LNAME AS 'LAST NAME', CAN_AGE , CAN_GENDER , CAN_ADDRESS , CAN_CONTACT , CAN_TALENT, STUD_TYPE, STUD_COURSE, STUD_YEARLVL, STUD_GRADELVL, STUD_SECTION  FROM candidate INNER JOIN attainment on candidate.STUD_ID = attainment.STUD_ID "
                '.CommandText = "SELECT STUD_TYPE AS 'ATTAINMENT', STUD_COURSE AS 'COURSE', STUD_YEARLVL AS 'YEAR LEVEL', STUD_GRADELVL AS 'GRADE LEVEL', STUD_SECTION AS 'SECTION' FROM attainment"
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.RowHeadersVisible = False
            MyCommand.Dispose()
            MyCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
    End Sub

    Sub DisID()
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM candidate WHERE CAN_ID = '" & txtCanID.Text & "' "
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            If MySQLData.HasRows Then
                MySQLData.Read()
                txtAttainID.Text = MySQLData("STUD_ID")
            End If
            MySQLData.Close()
            MyCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub cleartxt()

        txtCanID.Text = ""
        cboTeam.Text = Nothing
        txtFname.Text = ""
        txtMname.Text = ""
        txtLname.Text = ""
        txtAge.Text = ""
        cboGender.Text = Nothing
        txtAddress.Text = ""
        txtContact.Text = ""
        txtTalent.Text = ""
        cboAttainment.Text = Nothing
        cboCourse.Text = Nothing
        cboYrLevel.Text = Nothing
        cboGrLevel.Text = Nothing
        cboSection.Text = Nothing
    End Sub
    Private Sub frmCandidate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False
        gbxCan.Enabled = False

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            DataGrid()
        Else
            If (MyCon.State = ConnectionState.Open) Then
                MyCon.Close()
            End If
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT CAN_ID AS 'CANDIDATE ID', CAN_TEAM AS 'TEAM', CAN_FNAME AS 'FIRST NAME', CAN_MNAME AS 'MIDDLE NAME', CAN_LNAME AS 'LAST NAME' FROM candidate WHERE CAN_NUM LIKE '%" & txtSearch.Text & "%' OR CAN_FNAME LIKE '%" & txtSearch.Text & "%' OR CAN_LNAME LIKE '%" & txtSearch.Text & "%';"
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable
            dt.Clear()
            MyAdapter.Fill(dt)
            DataGridView1.DataSource = dt
            MyCon.Close()
        End If
    End Sub


    Sub ShowGbx()
        If cboAttainment.Text = "COLLEGE" Then
            cboCourse.Text = Nothing
            cboYrLevel.Text = Nothing
            gbxCollege.BringToFront()
            gbxShs.Hide()
            gbxCollege.Show()
        ElseIf gbxShs.Text = "SENIOR HIGH SCHOOL" Then
            cboSection.Text = Nothing
            cboGrLevel.Text = Nothing
            gbxShs.BringToFront()
            gbxCollege.Hide()
            gbxShs.Show()
        ElseIf cboAttainment.Text = Nothing Then
            cboCourse.Text = Nothing
            cboYrLevel.Text = Nothing
            cboSection.Text = Nothing
            cboGrLevel.Text = Nothing
            gbxShs.Hide()
            gbxCollege.Hide()
        End If
    End Sub


    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        gbxCan.Enabled = True
        btnClear.Enabled = True
        On Error Resume Next
        Dim i As Integer
        Dim b As Integer = 0
        i = DataGridView1.CurrentRow.Index
        Me.txtCanID.Text = DataGridView1.Item(0, i).Value
        Me.cboTeam.Text = DataGridView1.Item(1, i).Value
        Me.txtFname.Text = DataGridView1.Item(2, i).Value
        Me.txtMname.Text = DataGridView1.Item(3, i).Value
        Me.txtLname.Text = DataGridView1.Item(4, i).Value
        Me.txtAge.Text = DataGridView1.Item(5, i).Value
        Me.cboGender.Text = DataGridView1.Item(6, i).Value
        Me.txtAddress.Text = DataGridView1.Item(7, i).Value
        Me.txtContact.Text = DataGridView1.Item(8, i).Value
        Me.txtTalent.Text = DataGridView1.Item(9, i).Value
        Me.cboAttainment.Text = DataGridView1.Item(10, i).Value
        Me.cboCourse.Text = DataGridView1.Item(11, i).Value
        Me.cboYrLevel.Text = DataGridView1.Item(12, i).Value
        Me.cboGrLevel.Text = DataGridView1.Item(13, i).Value
        Me.cboSection.Text = DataGridView1.Item(14, i).Value
        DisID()
    End Sub

    Private Sub cboAttainment_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAttainment.SelectionChangeCommitted
        ShowGbx()
    End Sub

    Private Sub cboAttainment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAttainment.TextChanged
        ShowGbx()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            If txtCanID.Text = "" And txtAttainID.Text = "" Then
                MessageBox.Show("Please select candidate in Table", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DialogResult = MessageBox.Show("Are you sure you want to update candidate?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If DialogResult = DialogResult.OK Then
                    ExecButton("UPDATE attainment SET STUD_TYPE = '" & cboAttainment.Text & "', STUD_COURSE = '" & cboCourse.Text & "', STUD_YEARLVL = '" & cboYrLevel.Text & "',STUD_GRADELVL = '" & cboGrLevel.Text & "',STUD_SECTION = '" & cboSection.Text & "' WHERE STUD_ID ='" & txtAttainID.Text & "'")
                    ExecButton("UPDATE candidate SET CAN_TEAM = '" & cboTeam.Text & "', CAN_FNAME = '" & txtFname.Text & "', CAN_MNAME = '" & txtMname.Text & "', CAN_LNAME = '" & txtLname.Text & "', 	CAN_AGE = '" & txtAge.Text & "', CAN_GENDER = '" & cboGender.Text & "',CAN_ADDRESS = '" & txtAddress.Text & "',CAN_CONTACT = '" & txtContact.Text & "', CAN_TALENT = '" & txtTalent.Text & "' WHERE CAN_ID ='" & txtCanID.Text & "'")
                    MsgBox("Records have been successfully updated.", MsgBoxStyle.Information, "Success")
                    DataGrid()
                    cleartxt()
                    gbxCan.Enabled = False
                    btnUpdate.Enabled = False
                    btnClear.Enabled = False
                    btnDelete.Enabled = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        cleartxt()
        gbxCan.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Please select candidate in Table", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DialogResult = MessageBox.Show("Are you sure you want to delete candidate?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If DialogResult = DialogResult.OK Then
                    ExecButton("DELETE FROM candidate WHERE CAN_ID ='" & txtCanID.Text & "'")
                    MsgBox("Records have been successfully deleted.", MsgBoxStyle.Information, "Success")
                    DataGrid()
                    cleartxt()
                    gbxCan.Enabled = False
                    btnUpdate.Enabled = False
                    btnClear.Enabled = False
                    btnDelete.Enabled = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class