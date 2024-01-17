Public Class frmAdmin
 
    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If DialogResult = DialogResult.OK Then
            frmHome.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnCandidate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandidate.Click
        frmCandidate.MdiParent = Me
        frmJudge.Hide()
        frmJudge.Dispose()
        frmCandidate.Show()

    End Sub

    Private Sub btnJudge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJudge.Click
        frmJudge.MdiParent = Me
        frmCandidate.Hide()
        frmCandidate.Dispose()
        frmJudge.Show()

    End Sub

    Private Sub btnCandidate_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandidate.MouseHover
        panelCan.Show()
    End Sub

    Private Sub btnCandidate_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCandidate.MouseLeave
        panelCan.Hide()
    End Sub

    Private Sub btnJudge_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJudge.MouseHover
        panelJud.Show()
    End Sub

    Private Sub btnJudge_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJudge.MouseLeave
        panelJud.Hide()
    End Sub

    Private Sub panelOut_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelOut.MouseHover
        panelOut.Show()
    End Sub

    Private Sub panelOut_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelOut.MouseLeave
        panelOut.Hide()
    End Sub

    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panelCan.Hide()
        panelJud.Hide()
        panelOut.Hide()
    End Sub
End Class