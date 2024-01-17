Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmJudgeBoard

    Sub DisID()
        MyCon.Close()
        Try
            MyCon.Open()
            MyCommand.Connection = MyCon
            MyCommand.CommandText = "SELECT * FROM candidate WHERE CAN_FNAME = '" & txtFname.Text & "' AND CAN_LNAME = '" & txtLname.Text & "'"
            MyAdapter.SelectCommand = MyCommand
            Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
            If MySQLData.HasRows Then
                MySQLData.Read()
                txtGender.Text = MySQLData("CAN_GENDER")
                txtTalent.Text = MySQLData("CAN_TALENT")
                txtPath.Text = MySQLData("CAN_PIC")
                If txtPath.Text = "" Then
                    PictureBox2.ImageLocation = "C:\Users\Admin\Downloads\img.png"
                Else
                    PictureBox2.ImageLocation = Replace(txtPath.Text, ";", "\")
                End If

            End If
            MySQLData.Close()
            MyCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub JudgeID()
        Me.labelJudID.Text = frmHome.txtJudID.Text
    End Sub

    Private Sub frmJudgeBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGrid()
        JudgeID()
        TalScore()
        btnEnMaj()
        btnEnMajM()
        btnEnMinF()
        btnEnMinM()
        PictureBox2.ImageLocation = "C:\Users\Admin\Downloads\img.png"

        panelTalbtn.Hide()
        panelMinbtn.Hide()
        panelMajbtn.Hide()
        panelLoad.Show()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Close()
    End Sub

    Sub DataGrid()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_ID AS 'CANDIDATE ID', CAN_TEAM AS 'TEAM', CAN_FNAME AS 'FIRST NAME', CAN_MNAME AS 'MIDDLE NAME', CAN_LNAME AS 'LAST NAME' FROM candidate "
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
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick

        On Error Resume Next
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Me.txtCanID.Text = DataGridView1.Item(0, i).Value
        Me.txtTeam.Text = DataGridView1.Item(1, i).Value
        Me.txtFname.Text = DataGridView1.Item(2, i).Value
        Me.txtMname.Text = DataGridView1.Item(3, i).Value
        Me.txtLname.Text = DataGridView1.Item(4, i).Value
        DisID()
        panelLoad.Show()
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
            MyCommand.CommandText = "SELECT CAN_ID AS 'CANDIDATE ID', CAN_TEAM AS 'TEAM', CAN_FNAME AS 'FIRST NAME', CAN_MNAME AS 'MIDDLE NAME', CAN_LNAME AS 'LAST NAME' FROM candidate WHERE CAN_NUM LIKE '%" & txtSearch.Text & "%' OR  CAN_FNAME LIKE '%" & txtSearch.Text & "%' OR CAN_LNAME LIKE '%" & txtSearch.Text & "%';"
            MyAdapter.SelectCommand = MyCommand
            dt = New DataTable
            dt.Clear()
            MyAdapter.Fill(dt)
            DataGridView1.DataSource = dt
            MyCon.Close()
        End If
    End Sub

    Private Sub btnClearTal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTal.Click
        txtOrigTal.Text = ""
        txtExecTal.Text = ""
        txtTaSTal.Text = ""
        txtCosTal.Text = ""
        txtTotTal.Text = ""
    End Sub

    Private Sub btnScoreTal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreTal.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Select first your candidate from Grid View!")
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM talent WHERE CAN_ID = '" & txtCanID.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then
                    MyCon.Close()
                    MySQLData.Close()
                    ExecButton("INSERT INTO talent VALUES('" & txtCanID.Text & "', '" & labelJudID.Text & "', '" & txtOrigTal.Text & "', '" & txtExecTal.Text & "',' " & txtTaSTal.Text & "', '" & txtCosTal.Text & "' , '" & txtTotTal.Text & "')")
                    MessageBox.Show("Score saved sucessfully")
                    txtOrigTal.Text = ""
                    txtExecTal.Text = ""
                    txtTaSTal.Text = ""
                    txtCosTal.Text = ""
                    txtTotTal.Text = ""
                    MyCon.Close()
                Else
                    MessageBox.Show("Candidate has already scored!, Please select other candidate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtOrigTal.Text = ""
                    txtExecTal.Text = ""
                    txtTaSTal.Text = ""
                    txtCosTal.Text = ""
                    txtTotTal.Text = ""
                    MyCon.Close()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub TalScore()
        If txtTotTal.Text = "" Then
            btnScoreTal.Enabled = False
        Else
            btnScoreTal.Enabled = True
        End If
    End Sub

    Private Sub txtTotTal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotTal.TextChanged
        TalScore()
    End Sub

    Private Sub txtOrigTal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrigTal.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtOrigTal.Text) Then
            txtOrigTal.Clear()
            Exit Sub
        End If
        Dim i As Integer = 30
        If Integer.Parse(txtOrigTal.Text) > i Then
            txtOrigTal.Clear()
        End If

        TotComp()
    End Sub

    Private Sub txtExecTal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExecTal.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtExecTal.Text) Then
            txtExecTal.Clear()
            Exit Sub
        End If
        Dim i As Integer = 30
        If Integer.Parse(txtExecTal.Text) > i Then
            txtExecTal.Clear()
        End If

        TotComp()
    End Sub

    Private Sub txtTaSTal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTaSTal.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtTaSTal.Text) Then
            txtTaSTal.Clear()
            Exit Sub
        End If
        Dim i As Integer = 30
        If Integer.Parse(txtTaSTal.Text) > i Then
            txtTaSTal.Clear()
        End If

        TotComp()
      
    End Sub

    Private Sub txtCosTal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCosTal.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtCosTal.Text) Then
            txtCosTal.Clear()
            Exit Sub
        End If

        Dim i As Integer = 10
        If Integer.Parse(txtCosTal.Text) > i Then
            txtCosTal.Clear()
        End If

        TotComp()
    End Sub

    Sub TotComp()
        If txtOrigTal.Text = "" Or txtExecTal.Text = "" Or txtTaSTal.Text = "" Or txtCosTal.Text = "" Then
            txtTotTal.Text = ""
        Else
            Dim Tot As Integer = Integer.Parse(txtOrigTal.Text) + Integer.Parse(txtExecTal.Text) + Integer.Parse(txtTaSTal.Text) + Integer.Parse(txtCosTal.Text)
            txtTotTal.Text = Tot.ToString
        End If

    End Sub

    Private Sub btnClearMinorM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMinorM.Click
        txtBesuM.Clear()
        txtBifaM.Clear()
        txtBiswM.Clear()
        txtMTotM.Clear()
    End Sub

    Private Sub btnScoreMinorM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreMinorM.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Select first your candidate from Grid View!")
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM minorscore WHERE CAN_ID = '" & txtCanID.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then
                    MyCon.Close()
                    MySQLData.Close()
                    ExecButton("INSERT INTO minorscore VALUES('" & txtCanID.Text & "', '" & labelJudID.Text & "', '" & txtBesuM.Text & "', '" & txtBiswM.Text & "',' " & txtBifaM.Text & "', '', '' , '" & txtMTotM.Text & "')")
                    MessageBox.Show("Score saved sucessfully")
                    txtBesuM.Clear()
                    txtBifaM.Clear()
                    txtBiswM.Clear()
                    txtMTotM.Clear()
                    MyCon.Close()
                Else
                    MessageBox.Show("Candidate has already scored!, Please select other candidate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBesuM.Clear()
                    txtBifaM.Clear()
                    txtBiswM.Clear()
                    txtMTotM.Clear()
                    MyCon.Close()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub MinTM()
        If txtBesuM.Text = "" Or txtBifaM.Text = "" Or txtBiswM.Text = "" Then
            txtMTotM.Text = ""
        Else
            Dim Tot As Integer = Integer.Parse(txtBesuM.Text) + Integer.Parse(txtBifaM.Text) + Integer.Parse(txtBiswM.Text)
            txtMTotM.Text = Tot.ToString
        End If
    End Sub

    Private Sub txtBesuM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBesuM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBesuM.Text) Then
            txtBesuM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBesuM.Text) > i Then
            txtBesuM.Clear()
        End If
        MinTM()
    End Sub

    Private Sub txtBiswM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiswM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBiswM.Text) Then
            txtBiswM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBiswM.Text) > i Then
            txtBiswM.Clear()
        End If
        MinTM()
    End Sub

    Private Sub txtBifaM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBifaM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBifaM.Text) Then
            txtBifaM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBifaM.Text) > i Then
            txtBifaM.Clear()
        End If
        MinTM()
    End Sub


    Sub btnEnMinM()
        If txtMTotM.Text = "" Then
            btnScoreMinorM.Enabled = False
        Else
            btnScoreMinorM.Enabled = True
        End If
    End Sub


    Private Sub txtMTotM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMTotM.TextChanged
        btnEnMinM()
    End Sub

    Private Sub btnClearMinorF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMinorF.Click
        txtBiegF.Clear()
        txtBisuF.Clear()
        txtBiswF.Clear()
        txtMTotF.Clear()

    End Sub

    Private Sub btnScoreMinorF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScoreMinorF.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Select first your candidate from Grid View!")
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM minorscore WHERE CAN_ID = '" & txtCanID.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then
                    MyCon.Close()
                    MySQLData.Close()
                    ExecButton("INSERT INTO minorscore VALUES('" & txtCanID.Text & "', '" & labelJudID.Text & "', '" & txtBisuF.Text & "', '" & txtBiswF.Text & "', '', '" & txtBiegF.Text & "', '" & txtMTotF.Text & "' , '')")
                    MessageBox.Show("Score saved sucessfully")
                    txtBiegF.Clear()
                    txtBisuF.Clear()
                    txtBiswF.Clear()
                    txtMTotF.Clear()
                    MyCon.Close()
                Else
                    MessageBox.Show("Candidate has already scored!, Please select other candidate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBiegF.Clear()
                    txtBisuF.Clear()
                    txtBiswF.Clear()
                    txtMTotF.Clear()
                    MyCon.Close()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub MinTF()
        If txtBisuF.Text = "" Or txtBiegF.Text = "" Or txtBiswF.Text = "" Then
            txtMTotF.Text = ""
        Else
            Dim Tot As Integer = Integer.Parse(txtBisuF.Text) + Integer.Parse(txtBiegF.Text) + Integer.Parse(txtBiswF.Text)
            txtMTotF.Text = Tot.ToString
        End If
    End Sub

    Private Sub txtBisuF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBisuF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBisuF.Text) Then
            txtBisuF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBisuF.Text) > i Then
            txtBisuF.Clear()
        End If
        MinTF()
    End Sub

    Private Sub txtBiswF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiswF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBiswF.Text) Then
            txtBiswF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBiswF.Text) > i Then
            txtBiswF.Clear()
        End If
        MinTF()
    End Sub

    Private Sub txtBiegF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiegF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBiegF.Text) Then
            txtBiegF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 10
        If Integer.Parse(txtBiegF.Text) > i Then
            txtBiegF.Clear()
        End If
        MinTF()
    End Sub

    Sub btnEnMinF()
        If txtMTotF.Text = "" Then
            btnScoreMinorF.Enabled = False
        Else
            btnScoreMinorF.Enabled = True
        End If
    End Sub

    Private Sub txtMTotF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMTotF.TextChanged
        btnEnMinF()
    End Sub

    Sub genderMajor()
        If txtGender.Text = "MALE" Then
            panelMinorFemale.Hide()
            txtBiegF.Clear()
            txtBisuF.Clear()
            txtBiswF.Clear()
            txtMTotF.Clear()

            panelTalent.Hide()
            txtOrigTal.Text = ""
            txtExecTal.Text = ""
            txtTaSTal.Text = ""
            txtCosTal.Text = ""
            txtTotTal.Text = ""

            panelMinorMale.Show()
            txtBesuM.Clear()
            txtBifaM.Clear()
            txtBiswM.Clear()
            txtMTotM.Clear()

            panelMajorFemale.Hide()
            txtBotfF.Clear()
            txtIntF.Clear()
            txtPaCF.Clear()
            txtMajTotF.Clear()


            panelMajorMale.Show()
        ElseIf txtGender.Text = "FEMALE" Then
            panelMinorMale.Hide()
            txtBesuM.Clear()
            txtBifaM.Clear()
            txtBiswM.Clear()
            txtMTotM.Clear()

            panelTalent.Hide()
            txtOrigTal.Text = ""
            txtExecTal.Text = ""
            txtTaSTal.Text = ""
            txtCosTal.Text = ""
            txtTotTal.Text = ""

            panelMajorMale.Hide()
            txtMuscM.Clear()
            txtIntM.Clear()
            txtSwM.Clear()
            txtMajTotM.Clear()

            panelMinorFemale.Hide()
            panelMinorFemale.Hide()
            txtBiegF.Clear()
            txtBisuF.Clear()
            txtBiswF.Clear()
            txtMTotF.Clear()

            panelMajorFemale.Show()
        ElseIf txtGender.Text = "" Then
            panelLoad.Show()
        End If

    End Sub

    Sub genderMinor()
        If txtGender.Text = "MALE" Then
            panelMinorFemale.Hide()
            txtBiegF.Clear()
            txtBisuF.Clear()
            txtBiswF.Clear()
            txtMTotF.Clear()

            panelTalent.Hide()
            txtOrigTal.Text = ""
            txtExecTal.Text = ""
            txtTaSTal.Text = ""
            txtCosTal.Text = ""
            txtTotTal.Text = ""

            panelMajorMale.Hide()
            txtMuscM.Clear()
            txtIntM.Clear()
            txtSwM.Clear()
            txtMajTotM.Clear()

            panelMajorFemale.Hide()
            txtBotfF.Clear()
            txtIntF.Clear()
            txtPaCF.Clear()
            txtMajTotF.Clear()

            panelMinorMale.Show()
        ElseIf txtGender.Text = "FEMALE" Then
            panelMinorMale.Hide()
            txtBesuM.Clear()
            txtBifaM.Clear()
            txtBiswM.Clear()
            txtMTotM.Clear()

            panelTalent.Hide()
            txtOrigTal.Text = ""
            txtExecTal.Text = ""
            txtTaSTal.Text = ""
            txtCosTal.Text = ""
            txtTotTal.Text = ""

            panelMajorMale.Hide()
            txtMuscM.Clear()
            txtIntM.Clear()
            txtSwM.Clear()
            txtMajTotM.Clear()

            panelMajorFemale.Hide()
            txtBotfF.Clear()
            txtIntF.Clear()
            txtPaCF.Clear()
            txtMajTotF.Clear()

            panelMinorFemale.Show()
        ElseIf txtGender.Text = "" Then
            panelLoad.Show()
        End If
    End Sub

    Private Sub btnMinor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinor.Click
        If txtGender.Text = "" Then
            panelLoad.Show()
        Else
            panelLoad.Hide()
            genderMinor()
        End If

    End Sub

    Private Sub btnTalent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.Click
        If Not txtTalent.Text = "" Then
            panelMinorMale.Hide()
            txtBesuM.Clear()
            txtBifaM.Clear()
            txtBiswM.Clear()
            txtMTotM.Clear()

            panelMinorFemale.Hide()
            txtBiegF.Clear()
            txtBisuF.Clear()
            txtBiswF.Clear()
            txtMTotF.Clear()

            panelMajorMale.Hide()
            txtMuscM.Clear()
            txtIntM.Clear()
            txtSwM.Clear()
            txtMajTotM.Clear()

            panelMajorFemale.Hide()
            txtBotfF.Clear()
            txtIntF.Clear()
            txtPaCF.Clear()
            txtMajTotF.Clear()

            panelLoad.Hide()

            panelTalent.Show()
        End If

    End Sub

    Private Sub txtTalent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTalent.TextChanged
        If txtTalent.Text = "" Then
            btnTalent.Enabled = False
        ElseIf txtGender.Text = "" Then
            panelLoad.Show()
        Else
            btnTalent.Enabled = True
        End If
    End Sub

    Private Sub btnMajor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajor.Click
        If txtGender.Text = "" Then
            panelLoad.Show()
        Else
            panelLoad.Hide()
            genderMajor()
        End If

    End Sub

    Private Sub btnMajor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajor.MouseHover
        panelMajbtn.Show()
    End Sub

    Private Sub btnMajor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajor.MouseLeave
        panelMajbtn.Hide()
    End Sub

    Private Sub btnMinor_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinor.MouseHover
        panelMinbtn.Show()
    End Sub

    Private Sub btnMinor_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinor.MouseLeave
        panelMinbtn.Hide()
    End Sub

    Private Sub btnTalent_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.MouseHover
        panelTalbtn.Show()
    End Sub

    Private Sub btnTalent_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.MouseLeave
        panelTalbtn.Hide()
    End Sub

    Private Sub btnClearMajorM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMajorM.Click
        txtMuscM.Clear()
        txtIntM.Clear()
        txtSwM.Clear()
        txtMajTotM.Clear()
    End Sub

    Private Sub btnMajorM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajorM.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Select first your candidate from Grid View!")
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM majorscore WHERE CAN_ID = '" & txtCanID.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then
                    MyCon.Close()
                    MySQLData.Close()
                    ExecButton("INSERT INTO majorscore VALUES('" & txtCanID.Text & "', '" & labelJudID.Text & "', '', '', '" & txtMuscM.Text & "', '" & txtSwM.Text & "', '" & txtIntM.Text & "', '', '" & txtMajTotM.Text & "')")
                    MessageBox.Show("Score saved sucessfully")
                    txtMuscM.Clear()
                    txtIntM.Clear()
                    txtSwM.Clear()
                    txtMajTotM.Clear()
                    MyCon.Close()
                Else
                    MessageBox.Show("Candidate has already scored!, Please select other candidate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtMuscM.Clear()
                    txtIntM.Clear()
                    txtSwM.Clear()
                    txtMajTotM.Clear()
                    MyCon.Close()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub MajTM()
        If txtMuscM.Text = "" Or txtIntM.Text = "" Or txtSwM.Text = "" Then
            txtMajTotM.Text = ""
        Else
            Dim Tot As Integer = Integer.Parse(txtMuscM.Text) + Integer.Parse(txtIntM.Text) + Integer.Parse(txtSwM.Text)
            txtMajTotM.Text = Tot.ToString
        End If
    End Sub

    Private Sub txtMuscM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMuscM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtMuscM.Text) Then
            txtMuscM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 40
        If Integer.Parse(txtMuscM.Text) > i Then
            txtMuscM.Clear()
        End If
        MajTM()
    End Sub

    Private Sub txtIntM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtIntM.Text) Then
            txtIntM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 40
        If Integer.Parse(txtIntM.Text) > i Then
            txtIntM.Clear()
        End If
        MajTM()
    End Sub

    Private Sub txtSwM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSwM.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtSwM.Text) Then
            txtSwM.Clear()
            Exit Sub
        End If
        Dim i As Integer = 20
        If Integer.Parse(txtSwM.Text) > i Then
            txtSwM.Clear()
        End If
        MajTM()
    End Sub

    Sub btnEnMajM()
        If txtMajTotM.Text = "" Then
            btnMajorM.Enabled = False
        Else
            btnMajorM.Enabled = True
        End If
    End Sub

    Private Sub txtMajTotM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMajTotM.TextChanged
        btnEnMajM()
    End Sub

    Private Sub btnClearMajorF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearMajorF.Click
        txtBotfF.Clear()
        txtIntF.Clear()
        txtPaCF.Clear()
        txtMajTotF.Clear()
    End Sub

    Private Sub btnMajorFemale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajorFemale.Click
        Try
            If txtCanID.Text = "" Then
                MessageBox.Show("Select first your candidate from Grid View!")
            Else
                MyCon.Open()
                MyCommand.Connection = MyCon
                MyCommand.CommandText = "SELECT * FROM majorscore WHERE CAN_ID = '" & txtCanID.Text & "'"
                MyAdapter.SelectCommand = MyCommand
                Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                If MySQLData.HasRows = 0 Then
                    MyCon.Close()
                    MySQLData.Close()
                    ExecButton("INSERT INTO majorscore VALUES('" & txtCanID.Text & "', '" & labelJudID.Text & "', '" & txtBotfF.Text & "', '" & txtPaCF.Text & "', '', '', '" & txtIntF.Text & "', '" & txtMajTotF.Text & "' , '')")
                    MessageBox.Show("Score saved sucessfully")
                    txtBotfF.Clear()
                    txtIntF.Clear()
                    txtPaCF.Clear()
                    txtMajTotF.Clear()
                    MyCon.Close()
                Else
                    MessageBox.Show("Candidate has already scored!, Please select other candidate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtBotfF.Clear()
                    txtIntF.Clear()
                    txtPaCF.Clear()
                    txtMajTotF.Clear()
                    MyCon.Close()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub MajTF()
        If txtBotfF.Text = "" Or txtIntF.Text = "" Or txtPaCF.Text = "" Then
            txtMajTotF.Text = ""
        Else
            Dim Tot As Integer = Integer.Parse(txtBotfF.Text) + Integer.Parse(txtIntF.Text) + Integer.Parse(txtPaCF.Text)
            txtMajTotF.Text = Tot.ToString
        End If
    End Sub

    Private Sub txtBotfF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBotfF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtBotfF.Text) Then
            txtBotfF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 40
        If Integer.Parse(txtBotfF.Text) > i Then
            txtBotfF.Clear()
        End If
        MajTF()
    End Sub

    Private Sub txtIntF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIntF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtIntF.Text) Then
            txtIntF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 40
        If Integer.Parse(txtIntF.Text) > i Then
            txtIntF.Clear()
        End If
        MajTF()
    End Sub

    Private Sub txtPaCF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaCF.TextChanged
        Dim strCP As String = "^[0-9]+$"
        Dim reCP As New Regex(strCP)
        If Not reCP.IsMatch(txtPaCF.Text) Then
            txtPaCF.Clear()
            Exit Sub
        End If
        Dim i As Integer = 20
        If Integer.Parse(txtPaCF.Text) > i Then
            txtPaCF.Clear()
        End If
        MajTF()
    End Sub

    Sub btnEnMaj()
        If txtMajTotF.Text = "" Then
            btnMajorFemale.Enabled = False
        Else
            btnMajorFemale.Enabled = True
        End If
    End Sub

    Private Sub txtMajTotF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMajTotF.TextChanged
        btnEnMaj()
    End Sub

    Private Sub txtGender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGender.TextChanged
        genderMajor()
        genderMinor()
    End Sub

  
End Class