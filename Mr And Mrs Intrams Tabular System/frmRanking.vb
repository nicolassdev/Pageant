Public Class frmRanking

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

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        frmMajorRank.Dispose()

    End Sub

    Private Sub frmRanking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panelMajbtn.Hide()
        panelMinbtn.Hide()
        panelTalbtn.Hide()
    End Sub

    Private Sub btnMajor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMajor.Click
        frmMajorRank.MdiParent = Me
        frmMinorRank.Close()
        frmTalentRank.Close()
        frmMajorRank.Show()
    End Sub

    Private Sub btnMinor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinor.Click
        frmMinorRank.MdiParent = Me
        frmMajorRank.Close()
        frmTalentRank.Close()
        frmMinorRank.Show()
    End Sub

    Private Sub btnTalent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTalent.Click
        frmTalentRank.MdiParent = Me
        frmMajorRank.Close()
        frmMinorRank.Close()
        frmTalentRank.Show()

    End Sub
End Class