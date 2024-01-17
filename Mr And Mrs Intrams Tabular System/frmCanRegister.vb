Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmCanRegister

    Sub Clear()
        cboTeam.Text = Nothing
        txtFname.Clear()
        txtMname.Clear()
        txtLname.Clear()
        txtAge.Value = 1
        cboGender.Text = Nothing
        txtAddress.Clear()
        txtContact.Clear()
        txtTalent.Clear()
        cboAttainment.Text = Nothing
        btnReset.Enabled = False
        btnSave.Enabled = False
        txtAge.Enabled = False
        cboGender.Enabled = False
        txtAddress.Enabled = False
        txtContact.Enabled = False
        txtTalent.Enabled = False
        cboAttainment.Enabled = False
        txtPath.Clear()
        PictureBox1.ImageLocation = "C:\Users\Admin\Documents\123.png"
    End Sub

    'Manipulate GroupBox Attainment
    Sub Attain()
        If cboAttainment.Text = "COLLEGE" Then
            gbxShs.Visible = False
            gbxCollege.Visible = True
            cboGrLevel.Text = Nothing
            cboSection.Text = Nothing
            panelAdd.Show()
        ElseIf cboAttainment.Text = "SENIOR HIGH SCHOOL" Then
            gbxCollege.Visible = False
            gbxShs.Visible = True
            cboYrLevel.Text = Nothing
            cboCourse.Text = Nothing
            panelAdd.Show()
        ElseIf cboAttainment.Text = Nothing Then
            gbxCollege.Visible = False
            cboGrLevel.Text = Nothing
            cboSection.Text = Nothing
            gbxShs.Visible = False
            cboYrLevel.Text = Nothing
            cboCourse.Text = Nothing
            panelAdd.Hide()
        End If
    End Sub

    'Generate Candidate ID
    Sub GenCanID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim Candidate As String
        Dim maxnum As Integer
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxnum = Convert.ToInt32(getMaxCan()) '1
        idnum = maxnum + 1 '1 + 1 
        Candidate = "CSI-" & Year & "-" & idnum 'CUS-2023-2
        txtCanID.Text = Candidate
    End Sub

    'Generate Student Attainment ID
    Sub GenAttainID()
        Dim Year As Integer
        Dim idnum As Integer
        Dim Stud As String
        Dim maxnum As Integer
        Year = Convert.ToInt32(Now.ToString("yyyy")) '2023
        maxnum = Convert.ToInt32(getMaxAttain()) '1
        idnum = maxnum + 1 '1 + 1 
        Stud = "STUDENT-" & Year & "-" & idnum 'CUS-2023-2
        txtAttainID.Text = Stud
    End Sub

    Sub Disabletxtbox()
        cboTeam.Enabled = False
        txtFname.Enabled = False
        txtMname.Enabled = False
        txtLname.Enabled = False
        txtAge.Enabled = False
        cboGender.Enabled = False
        txtAddress.Enabled = False
        txtContact.Enabled = False
        txtTalent.Enabled = False
        cboAttainment.Enabled = False
        cboCourse.Enabled = False
        cboYrLevel.Enabled = False
        cboGrLevel.Enabled = False
        cboSection.Enabled = False
    End Sub

    Sub Enabletxtbox()
        cboTeam.Enabled = True
        txtFname.Enabled = True
        txtMname.Enabled = True
        txtLname.Enabled = True
        txtAge.Enabled = True
        cboGender.Enabled = True
        txtAddress.Enabled = True
        txtContact.Enabled = True
        txtTalent.Enabled = True
        cboAttainment.Enabled = True
        cboCourse.Enabled = True
        cboYrLevel.Enabled = True
        cboGrLevel.Enabled = True
        cboSection.Enabled = True
        PictureBox1.ImageLocation = "C:\Users\Admin\Documents\123.png"
    End Sub

    Sub NameDisable()
        If txtFname.Text = "" Then
            txtAge.Enabled = False
            cboGender.Enabled = False
            txtAddress.Enabled = False
            txtContact.Enabled = False
            txtTalent.Enabled = False
            cboAttainment.Enabled = False
        Else
            txtAge.Enabled = True
            cboGender.Enabled = True
            txtAddress.Enabled = True
            txtContact.Enabled = True
            txtTalent.Enabled = True
            cboAttainment.Enabled = True
        End If
    End Sub

    Private Sub frmCanRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlClose.Visible = False
        GenCanID()
        GenAttainID()
        panelPhoto.Hide()
        btnSave.Enabled = False
        btnReset.Enabled = False
        txtAge.Enabled = False
        cboGender.Enabled = False
        txtAddress.Enabled = False
        txtContact.Enabled = False
        txtTalent.Enabled = False
        cboAttainment.Enabled = False
        panelAdd.Hide()
        PictureBox1.ImageLocation = "C:\Users\Admin\Documents\123.png"
    End Sub

    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged
        NameDisable()
        btnReset.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        checkPhoto.Checked = False
        Clear()
        Attain()
        Me.Close()

    End Sub

    Private Sub btnClose_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseHover
        pnlClose.Visible = True
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.MouseLeave
        pnlClose.Visible = False
    End Sub

    Private Sub checkPhoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkPhoto.CheckedChanged
        If checkPhoto.Checked Then
            panelPhoto.Show()
            gbxCollege.SendToBack()
            gbxShs.SendToBack()
            Disabletxtbox()
            btnReset.Enabled = False
            btnSave.Enabled = False
        Else
            panelPhoto.Hide()
            Enabletxtbox()
            gbxCollege.BringToFront()
            gbxShs.BringToFront()
        End If
    End Sub

    Private Sub cboAttainment_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAttainment.SelectionChangeCommitted
        Attain()
    End Sub

    Private Sub checkPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkPhoto.Click
        checkPhoto.Checked = True
    End Sub

    Private Sub btnPhotoClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhotoClose.Click
        If txtPath.Text = "" Then
            MessageBox.Show("Please upload your photo!", "Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            panelPhoto.Hide()
            btnReset.Enabled = True
            btnSave.Enabled = True
            Enabletxtbox()
        End If
    End Sub

    Private Sub txtPath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPath.TextChanged
        txtPath.Text = (Replace(txtPath.Text, "\", ";"))
        Enabletxtbox()
        btnReset.Enabled = True
        btnSave.Enabled = True
        If txtPath.Text = "" Then
            checkPhoto.Text = "ADD PHOTO"
        Else
            checkPhoto.Text = "PHOTO ADDED"
            btnReset.Enabled = True
            btnSave.Enabled = True
            Enabletxtbox()
        End If
    End Sub

    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        OpenFileDialog1.Filter = "Jpeg|*.JPG|Bitmap|*.BMP|GIF|*.GIF"
        OpenFileDialog1.RestoreDirectory = True


        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtPath.Text = OpenFileDialog1.FileName
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Clear()
        Attain()
        panelPhoto.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If cboTeam.Text = Nothing Or cboGender.Text = Nothing Or txtFname.Text = "" Or txtLname.Text = "" Or txtAge.Text = "" Or txtAddress.Text = "" Or txtContact.Text = "" Or cboAttainment.Text = Nothing Or cboGrLevel.Text = Nothing And cboYrLevel.Text = Nothing Or cboSection.Text = "" And cboCourse.Text = "" Then
                MessageBox.Show("All fields are  required !", "Required")
                Exit Sub
            Else
                If btnSave.Text = "SAVE" Then
                    MyCon.Open()
                    MyCommand.Connection = MyCon
                    MyCommand.CommandText = "SELECT * FROM candidate WHERE CAN_ID = '" & txtCanID.Text & "'"
                    MyAdapter.SelectCommand = MyCommand
                    Dim MySQLData As MySqlDataReader = MyCommand.ExecuteReader
                    If MySQLData.HasRows = 0 Then
                        MyCon.Close()
                        MySQLData.Close()
                        ExecButton("INSERT INTO attainment VALUES ('','" & txtAttainID.Text & "','" & cboAttainment.Text & "','" & cboCourse.Text & "','" & cboYrLevel.Text & "', '" & cboGrLevel.Text & "','" & cboSection.Text & "')")
                        ExecButton("INSERT INTO candidate VALUES ('','" & txtCanID.Text & "','" & cboTeam.Text & "','" & txtFname.Text & "', '" & txtMname.Text & "','" & txtLname.Text & "', '" & txtAge.Text & "', '" & cboGender.Text & "', '" & txtAddress.Text & "','" & txtContact.Text & "','" & txtTalent.Text & "','" & txtAttainID.Text & "','" & txtPath.Text & "')")
                        MsgBox("Records have been successfully saved.", MsgBoxStyle.Information, "Success")
                        PictureBox1.ImageLocation = "C:\Users\Admin\Documents\123.png"
                        Clear()
                        GenCanID()
                        GenAttainID()
                        Attain()
                        checkPhoto.Checked = False
                        panelPhoto.Hide()
                        MyCon.Close()
                        Exit Sub
                    End If
                End If
            End If

        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtContact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
        End If
        If txtContact.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.Leave
        Dim strMname As String = "^[a-zA-Z\s]+$"
        Dim reMname As New Regex(strMname) 'Attach Pattern To lastname Textbox
        If Not reMname.IsMatch(txtFname.Text) Then

            txtFname.Clear()
        End If
    End Sub

    Private Sub txtMname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMname.Leave
        Dim strMname As String = "^[a-zA-Z\s]+$"
        Dim reMname As New Regex(strMname) 'Attach Pattern To lastname Textbox
        If Not reMname.IsMatch(txtMname.Text) Then

            txtMname.Clear()
        End If
    End Sub

    
    Private Sub txtLname_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLname.Leave
        Dim strMname As String = "^[a-zA-Z\s]+$"
        Dim reMname As New Regex(strMname) 'Attach Pattern To lastname Textbox
        If Not reMname.IsMatch(txtLname.Text) Then

            txtLname.Clear()
        End If
    End Sub
End Class