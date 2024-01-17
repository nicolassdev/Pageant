Public Class frmTalentRank

    Sub GridView()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT CAN_TEAM AS 'TEAM', CONCAT(CAN_FNAME, ' ', CAN_MNAME, ' ', CAN_LNAME) AS 'CANDIDATE NAME', T_TOT AS 'TOTAL', CONCAT(J_FNAME, ' ', J_LNAME) AS 'JUDGE NAME' FROM talent INNER JOIN candidate ON talent.CAN_ID = candidate.CAN_ID INNER JOIN judge ON talent.J_ID = judge.J_ID ORDER BY T_TOT DESC"
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

    Private Sub frmTalentRank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView()
    End Sub
End Class