Public Class frmMinorRank


    Sub GridViewF()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_TEAM AS 'TEAM', CONCAT(CAN_FNAME, ' ', CAN_MNAME, ' ', CAN_LNAME) AS 'CANDIDATE NAME', MIN_FTOT AS 'TOTAL',  CONCAT(J_FNAME, ' ', J_LNAME) AS 'JUDGE NAME' FROM minorscore INNER JOIN candidate ON minorscore.CAN_ID = candidate.CAN_ID INNER JOIN judge ON minorscore.J_ID = judge.J_ID WHERE CAN_GENDER = 'FEMALE' ORDER BY MIN_FTOT DESC"
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

    Sub GridViewM()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_TEAM AS 'TEAM', CONCAT(CAN_FNAME, ' ', CAN_MNAME, ' ', CAN_LNAME) AS 'CANDIDATE NAME', MIN_MTOT AS 'TOTAL',  CONCAT(J_FNAME, ' ', J_LNAME) AS 'JUDGE NAME' FROM minorscore INNER JOIN candidate ON minorscore.CAN_ID = candidate.CAN_ID INNER JOIN judge ON minorscore.J_ID = judge.J_ID WHERE CAN_GENDER = 'MALE' ORDER BY MIN_MTOT DESC"
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
    Private Sub frmMinorRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridViewM()
        GridViewF()

    End Sub
End Class