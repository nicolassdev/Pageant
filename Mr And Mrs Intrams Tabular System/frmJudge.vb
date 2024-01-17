Imports MySql.Data.MySqlClient

Public Class frmJudge
    'Generate Judge ID
    Sub GenJudgeID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim Jud As String
        Dim maxnum As Integer
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxnum = Convert.ToInt32(getMaxJudge()) '1
        idnum = maxnum + 1 '1 + 1 
        Jud = "JUDGE-" & Year & "-" & idnum 'CUS-2023-2
        txtJudID.Text = Jud
    End Sub

    Sub DataGrid()
        Try
            If (MyCon.State = ConnectionState.Open) Then MyCon.Close()
            MyCon.Open()
            dt = New DataTable
            With MyCommand
                .Connection = MyCon
                .CommandText = "SELECT J_NUM, J_ID as 'Judge ID', J_FNAME as 'Firstname', J_MNAME as 'Middlename', J_LNAME as 'Lastname', J_CONTACT as 'Contact', J_ADDRESS as 'Address' FROM judge  "
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
        DataGridView1.Columns(0).Visible = False
    End Sub

    Sub ClearTxt()
        txtJudID.Clear()
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtContact.Clear()
        txtAddress.Clear()
    End Sub


    Private Sub frmJudge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gbxJudge.Enabled = False
        DataGrid()
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        
        Try
            If btnAdd.Text = "Add" Then
                GenJudgeID()
                btnAdd.Text = "Save"
                gbxJudge.Enabled = True
                btnAdd.Enabled = True
                btnClear.Enabled = True
                btnDelete.Enabled = False
                btnUpdate.Enabled = False
                DataGridView1.Enabled = False

            ElseIf txtFname.Text = "" Or txtMname.Text = "" Or txtLname.Text = "" Or txtContact.Text = "" Or txtAddress.Text = "" Then
                MessageBox.Show("All fields are required", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                If btnAdd.Text = "Save" Then
                    MyCon.Open()
                    MyCommand.Connection = MyCon
                    MyCommand.CommandText = "SELECT * FROM judge WHERE J_ID = '" & txtJudID.Text & "'"
                    MyAdapter.SelectCommand = MyCommand
                    Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                    If MySQLData.HasRows = 0 Then
                        MyCon.Close()
                        MySQLData.Close()
                        ExecButton("INSERT INTO judge VALUES ('','" & txtJudID.Text & "','" & txtFname.Text & "','" & txtMname.Text & "','" & txtLname.Text & "', '" & txtContact.Text & "','" & txtAddress.Text & "')")
                        MsgBox("Records have been successfully saved.", MsgBoxStyle.Information, "Success")
                        ClearTxt()
                        DataGrid()
                        btnAdd.Text = "Add"
                        gbxJudge.Enabled = False
                        btnUpdate.Enabled = False
                        btnClear.Enabled = False
                        btnDelete.Enabled = False
                        MyCon.Close()

                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearTxt()
        DataGridView1.Enabled = True
        gbxJudge.Enabled = False
        btnAdd.Text = "Add"
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnClear.Enabled = False
        btnAdd.Enabled = True

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            If txtJudID.Text = "" Then
                MessageBox.Show("Please select candidate in Table", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DialogResult = MessageBox.Show("Are you sure you want to update judge?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If DialogResult = DialogResult.OK Then
                    ExecButton("UPDATE judge SET J_FNAME = '" & txtFname.Text & "', J_MNAME = '" & txtMname.Text & "', J_LNAME = '" & txtLname.Text & "',J_CONTACT = '" & txtContact.Text & "',J_ADDRESS = '" & txtAddress.Text & "' WHERE J_ID ='" & txtJudID.Text & "'")
                    MsgBox("Records have been successfully updated.", MsgBoxStyle.Information, "Success")
                    DataGrid()
                    ClearTxt()
                    gbxJudge.Enabled = False
                    btnUpdate.Enabled = False
                    btnClear.Enabled = False
                    btnDelete.Enabled = False
                    btnAdd.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        gbxJudge.Enabled = True
        btnAdd.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnClear.Enabled = True
        On Error Resume Next
        Dim i As Integer
        Dim b As Integer = 0
        i = DataGridView1.CurrentRow.Index
        Me.txtJudID.Text = DataGridView1.Item(1, i).Value
        Me.txtFname.Text = DataGridView1.Item(2, i).Value
        Me.txtMname.Text = DataGridView1.Item(3, i).Value
        Me.txtLname.Text = DataGridView1.Item(4, i).Value
        Me.txtContact.Text = DataGridView1.Item(5, i).Value
        Me.txtAddress.Text = DataGridView1.Item(6, i).Value

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If txtJudID.Text = "" Then
                MessageBox.Show("Please select judge in Table", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                DialogResult = MessageBox.Show("Are you sure you want to delete candidate?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If DialogResult = DialogResult.OK Then
                    ExecButton("DELETE FROM judge WHERE J_ID ='" & txtJudID.Text & "'")
                    MsgBox("Records have been successfully deleted.", MsgBoxStyle.Information, "Success")
                    DataGrid()
                    ClearTxt()
                    gbxJudge.Enabled = False
                    btnUpdate.Enabled = False
                    btnClear.Enabled = False
                    btnDelete.Enabled = False
                    btnAdd.Enabled = True
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class