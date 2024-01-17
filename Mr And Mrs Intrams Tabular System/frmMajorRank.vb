Imports MySql.Data.MySqlClient

Public Class frmMajorRank


    Sub GridViewM()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_TEAM AS 'TEAMS', CONCAT(CAN_FNAME, ' ', CAN_MNAME, ' ', CAN_LNAME) AS 'CANDIDATE NAME', MJ_MTOT AS 'SCORE', CONCAT(J_FNAME, ' ', J_LNAME) AS 'JUDGE NAME' FROM majorscore INNER JOIN candidate ON majorscore.CAN_ID = candidate.CAN_ID INNER JOIN judge ON majorscore.J_ID = judge.J_ID WHERE CAN_GENDER = 'MALE' ORDER BY MJ_MTOT DESC"
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


    Sub GridViewF()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_TEAM AS 'TEAMS', CONCAT(CAN_FNAME, ' ', CAN_MNAME, ' ', CAN_LNAME) AS 'CANDIDATE NAME', MJ_FTOT AS 'SCORE', CONCAT(J_FNAME, ' ', J_LNAME) AS 'JUDGE NAME' FROM majorscore INNER JOIN candidate ON majorscore.CAN_ID = candidate.CAN_ID INNER JOIN judge ON majorscore.J_ID = judge.J_ID WHERE CAN_GENDER = 'FEMALE' ORDER BY MJ_FTOT DESC"
                '.CommandText = "SELECT STUD_TYPE AS 'ATTAINMENT', STUD_COURSE AS 'COURSE', STUD_YEARLVL AS 'YEAR LEVEL', STUD_GRADELVL AS 'GRADE LEVEL', STUD_SECTION AS 'SECTION' FROM attainment"
            End With
            MyAdapter.SelectCommand = MyCommand
            MyAdapter.Fill(dt)
            DataGridView2.DataSource = dt
            DataGridView2.RowHeadersVisible = False
            MyCommand.Dispose()
            MyCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   


    Private Sub frmMajorRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridViewM()
        GridViewF()
    End Sub

End Class