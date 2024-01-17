<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.panelOut = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.panelJud = New System.Windows.Forms.Panel()
        Me.btnJudge = New System.Windows.Forms.Button()
        Me.panelCan = New System.Windows.Forms.Panel()
        Me.btnCandidate = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 36)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(255, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tabular System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(103, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "MRS Intrams"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MR and"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Panel7.Controls.Add(Me.panelOut)
        Me.Panel7.Controls.Add(Me.btnLogout)
        Me.Panel7.Controls.Add(Me.panelJud)
        Me.Panel7.Controls.Add(Me.btnJudge)
        Me.Panel7.Controls.Add(Me.panelCan)
        Me.Panel7.Controls.Add(Me.btnCandidate)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.ForeColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(0, 36)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(176, 597)
        Me.Panel7.TabIndex = 6
        '
        'panelOut
        '
        Me.panelOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.panelOut.Location = New System.Drawing.Point(162, 509)
        Me.panelOut.Name = "panelOut"
        Me.panelOut.Size = New System.Drawing.Size(14, 72)
        Me.panelOut.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_log_out_64
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 509)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnLogout.Size = New System.Drawing.Size(176, 72)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'panelJud
        '
        Me.panelJud.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.panelJud.Location = New System.Drawing.Point(162, 220)
        Me.panelJud.Name = "panelJud"
        Me.panelJud.Size = New System.Drawing.Size(17, 72)
        Me.panelJud.TabIndex = 3
        '
        'btnJudge
        '
        Me.btnJudge.FlatAppearance.BorderSize = 0
        Me.btnJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJudge.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJudge.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_judge_64
        Me.btnJudge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJudge.Location = New System.Drawing.Point(3, 220)
        Me.btnJudge.Name = "btnJudge"
        Me.btnJudge.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.btnJudge.Size = New System.Drawing.Size(176, 72)
        Me.btnJudge.TabIndex = 2
        Me.btnJudge.Text = "Judge"
        Me.btnJudge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnJudge.UseVisualStyleBackColor = True
        '
        'panelCan
        '
        Me.panelCan.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.panelCan.Location = New System.Drawing.Point(162, 109)
        Me.panelCan.Name = "panelCan"
        Me.panelCan.Size = New System.Drawing.Size(17, 75)
        Me.panelCan.TabIndex = 1
        '
        'btnCandidate
        '
        Me.btnCandidate.FlatAppearance.BorderSize = 0
        Me.btnCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCandidate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCandidate.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_candidate_64
        Me.btnCandidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCandidate.Location = New System.Drawing.Point(3, 109)
        Me.btnCandidate.Name = "btnCandidate"
        Me.btnCandidate.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnCandidate.Size = New System.Drawing.Size(176, 72)
        Me.btnCandidate.TabIndex = 0
        Me.btnCandidate.Text = "Candidate"
        Me.btnCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCandidate.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 633)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents panelOut As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents panelJud As System.Windows.Forms.Panel
    Friend WithEvents btnJudge As System.Windows.Forms.Button
    Friend WithEvents panelCan As System.Windows.Forms.Panel
    Friend WithEvents btnCandidate As System.Windows.Forms.Button
End Class
