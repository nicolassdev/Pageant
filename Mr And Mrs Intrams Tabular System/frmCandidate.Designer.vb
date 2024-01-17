<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCandidate
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
        Me.txtCanID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtAttainID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTalent = New System.Windows.Forms.TextBox()
        Me.cboAttainment = New System.Windows.Forms.ComboBox()
        Me.gbxCollege = New System.Windows.Forms.GroupBox()
        Me.cboCourse = New System.Windows.Forms.ComboBox()
        Me.cboYrLevel = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gbxShs = New System.Windows.Forms.GroupBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cboGrLevel = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gbxCan = New System.Windows.Forms.GroupBox()
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCollege.SuspendLayout()
        Me.gbxShs.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCan.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCanID
        '
        Me.txtCanID.Enabled = False
        Me.txtCanID.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanID.Location = New System.Drawing.Point(55, 36)
        Me.txtCanID.Multiline = True
        Me.txtCanID.Name = "txtCanID"
        Me.txtCanID.Size = New System.Drawing.Size(240, 24)
        Me.txtCanID.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(35, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "CANDIDATE ID : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(334, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "TEAM NAME"
        '
        'cboTeam
        '
        Me.cboTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTeam.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTeam.FormattingEnabled = True
        Me.cboTeam.Items.AddRange(New Object() {"BLUE TEAM", "RED TEAM", "GREEN TEAM", "ORANGE TEAM", "YELLOW TEAM", "PURPLE TEAM", "BROWN TEAM", "BLACK TEAM"})
        Me.cboTeam.Location = New System.Drawing.Point(347, 35)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(228, 25)
        Me.cboTeam.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "FIRST NAME :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(35, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "LAST NAME "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(35, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "MIDDLE NAME :"
        '
        'txtMname
        '
        Me.txtMname.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMname.Location = New System.Drawing.Point(55, 135)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(240, 24)
        Me.txtMname.TabIndex = 3
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(55, 185)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(240, 24)
        Me.txtLname.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(35, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "AGE :"
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(87, 216)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(86, 25)
        Me.txtAge.TabIndex = 5
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAge.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(35, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 15)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "GENDER "
        '
        'cboGender
        '
        Me.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGender.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cboGender.Location = New System.Drawing.Point(58, 265)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(115, 25)
        Me.cboGender.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 15)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "ADDRESS :"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(55, 313)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(240, 24)
        Me.txtAddress.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(35, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 15)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "CONTACT :"
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(55, 361)
        Me.txtContact.MaxLength = 11
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(240, 24)
        Me.txtContact.TabIndex = 8
        '
        'txtAttainID
        '
        Me.txtAttainID.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttainID.Location = New System.Drawing.Point(328, 361)
        Me.txtAttainID.Multiline = True
        Me.txtAttainID.Name = "txtAttainID"
        Me.txtAttainID.Size = New System.Drawing.Size(247, 24)
        Me.txtAttainID.TabIndex = 37
        Me.txtAttainID.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(335, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "TALENT "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(398, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 15)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "OPTIONAL :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(334, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 15)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "ATTAINMENT :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(862, 106)
        Me.DataGridView1.TabIndex = 41
        '
        'txtTalent
        '
        Me.txtTalent.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalent.Location = New System.Drawing.Point(347, 87)
        Me.txtTalent.Multiline = True
        Me.txtTalent.Name = "txtTalent"
        Me.txtTalent.Size = New System.Drawing.Size(228, 24)
        Me.txtTalent.TabIndex = 9
        '
        'cboAttainment
        '
        Me.cboAttainment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAttainment.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAttainment.FormattingEnabled = True
        Me.cboAttainment.Items.AddRange(New Object() {"COLLEGE", "SENIOR HIGH SCHOOL"})
        Me.cboAttainment.Location = New System.Drawing.Point(347, 136)
        Me.cboAttainment.Name = "cboAttainment"
        Me.cboAttainment.Size = New System.Drawing.Size(228, 25)
        Me.cboAttainment.TabIndex = 10
        '
        'gbxCollege
        '
        Me.gbxCollege.Controls.Add(Me.cboCourse)
        Me.gbxCollege.Controls.Add(Me.cboYrLevel)
        Me.gbxCollege.Controls.Add(Me.Label15)
        Me.gbxCollege.Controls.Add(Me.Label16)
        Me.gbxCollege.Controls.Add(Me.Label17)
        Me.gbxCollege.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCollege.ForeColor = System.Drawing.Color.Black
        Me.gbxCollege.Location = New System.Drawing.Point(338, 188)
        Me.gbxCollege.Name = "gbxCollege"
        Me.gbxCollege.Size = New System.Drawing.Size(255, 164)
        Me.gbxCollege.TabIndex = 44
        Me.gbxCollege.TabStop = False
        Me.gbxCollege.Text = "COLLEGE"
        Me.gbxCollege.Visible = False
        '
        'cboCourse
        '
        Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourse.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCourse.FormattingEnabled = True
        Me.cboCourse.ItemHeight = 17
        Me.cboCourse.Items.AddRange(New Object() {"BSCS", "BSIS", "ACT-APP DEVELOPMENT", "ACT-NETWORKING"})
        Me.cboCourse.Location = New System.Drawing.Point(10, 108)
        Me.cboCourse.Name = "cboCourse"
        Me.cboCourse.Size = New System.Drawing.Size(228, 25)
        Me.cboCourse.TabIndex = 19
        '
        'cboYrLevel
        '
        Me.cboYrLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYrLevel.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYrLevel.FormattingEnabled = True
        Me.cboYrLevel.ItemHeight = 17
        Me.cboYrLevel.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th"})
        Me.cboYrLevel.Location = New System.Drawing.Point(10, 47)
        Me.cboYrLevel.Name = "cboYrLevel"
        Me.cboYrLevel.Size = New System.Drawing.Size(228, 25)
        Me.cboYrLevel.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(-2, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 18)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Course :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(-2, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Year Level :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(16, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 19)
        Me.Label17.TabIndex = 16
        '
        'gbxShs
        '
        Me.gbxShs.Controls.Add(Me.cboSection)
        Me.gbxShs.Controls.Add(Me.cboGrLevel)
        Me.gbxShs.Controls.Add(Me.Label18)
        Me.gbxShs.Controls.Add(Me.Label19)
        Me.gbxShs.Controls.Add(Me.Label20)
        Me.gbxShs.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxShs.ForeColor = System.Drawing.Color.Black
        Me.gbxShs.Location = New System.Drawing.Point(338, 188)
        Me.gbxShs.Name = "gbxShs"
        Me.gbxShs.Size = New System.Drawing.Size(255, 164)
        Me.gbxShs.TabIndex = 45
        Me.gbxShs.TabStop = False
        Me.gbxShs.Text = "SENIOR HIGH SCHOOL"
        Me.gbxShs.Visible = False
        '
        'cboSection
        '
        Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSection.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.ItemHeight = 17
        Me.cboSection.Items.AddRange(New Object() {"ICT-1", "ICT-2", "STEM-1", "STEM-2", "CSS-1", "CSS-2"})
        Me.cboSection.Location = New System.Drawing.Point(20, 107)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(208, 25)
        Me.cboSection.TabIndex = 19
        '
        'cboGrLevel
        '
        Me.cboGrLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrLevel.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrLevel.FormattingEnabled = True
        Me.cboGrLevel.ItemHeight = 17
        Me.cboGrLevel.Items.AddRange(New Object() {"11th Grade", "12th Grade"})
        Me.cboGrLevel.Location = New System.Drawing.Point(20, 47)
        Me.cboGrLevel.Name = "cboGrLevel"
        Me.cboGrLevel.Size = New System.Drawing.Size(208, 25)
        Me.cboGrLevel.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 18)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "Section :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 18)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "Grade Level :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Poor Richard", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(16, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 19)
        Me.Label20.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 425)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(886, 165)
        Me.Panel4.TabIndex = 46
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.loupe
        Me.PictureBox1.Location = New System.Drawing.Point(33, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(265, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(322, 24)
        Me.txtSearch.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SEARCH CANDIDATE"
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(55, 85)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(240, 24)
        Me.txtFname.TabIndex = 2
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 3
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDelete.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_delete_32
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(722, 186)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(134, 45)
        Me.btnDelete.TabIndex = 50
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 3
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdate.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_update_32
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(722, 113)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(134, 45)
        Me.btnUpdate.TabIndex = 49
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Copperplate Gothic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnClear.Image = Global.Mr_And_Mrs_Intrams_Tabular_System.My.Resources.Resources.icons8_clear_32
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(721, 37)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 45)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'gbxCan
        '
        Me.gbxCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbxCan.Controls.Add(Me.gbxCollege)
        Me.gbxCan.Controls.Add(Me.cboAttainment)
        Me.gbxCan.Controls.Add(Me.txtTalent)
        Me.gbxCan.Controls.Add(Me.Label14)
        Me.gbxCan.Controls.Add(Me.gbxShs)
        Me.gbxCan.Controls.Add(Me.Label13)
        Me.gbxCan.Controls.Add(Me.Label12)
        Me.gbxCan.Controls.Add(Me.txtAttainID)
        Me.gbxCan.Controls.Add(Me.txtContact)
        Me.gbxCan.Controls.Add(Me.Label11)
        Me.gbxCan.Controls.Add(Me.txtAddress)
        Me.gbxCan.Controls.Add(Me.Label10)
        Me.gbxCan.Controls.Add(Me.cboGender)
        Me.gbxCan.Controls.Add(Me.Label9)
        Me.gbxCan.Controls.Add(Me.txtAge)
        Me.gbxCan.Controls.Add(Me.Label7)
        Me.gbxCan.Controls.Add(Me.txtLname)
        Me.gbxCan.Controls.Add(Me.txtMname)
        Me.gbxCan.Controls.Add(Me.Label4)
        Me.gbxCan.Controls.Add(Me.Label5)
        Me.gbxCan.Controls.Add(Me.txtFname)
        Me.gbxCan.Controls.Add(Me.Label1)
        Me.gbxCan.Controls.Add(Me.cboTeam)
        Me.gbxCan.Controls.Add(Me.Label6)
        Me.gbxCan.Controls.Add(Me.Label8)
        Me.gbxCan.Controls.Add(Me.txtCanID)
        Me.gbxCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbxCan.Location = New System.Drawing.Point(23, 13)
        Me.gbxCan.Name = "gbxCan"
        Me.gbxCan.Size = New System.Drawing.Size(656, 402)
        Me.gbxCan.TabIndex = 51
        Me.gbxCan.TabStop = False
        '
        'frmCandidate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(886, 590)
        Me.Controls.Add(Me.gbxCan)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCandidate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCandidate"
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCollege.ResumeLayout(False)
        Me.gbxCollege.PerformLayout()
        Me.gbxShs.ResumeLayout(False)
        Me.gbxShs.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCan.ResumeLayout(False)
        Me.gbxCan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCanID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboTeam As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtAttainID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtTalent As System.Windows.Forms.TextBox
    Friend WithEvents cboAttainment As System.Windows.Forms.ComboBox
    Friend WithEvents gbxCollege As System.Windows.Forms.GroupBox
    Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
    Friend WithEvents cboYrLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gbxShs As System.Windows.Forms.GroupBox
    Friend WithEvents cboSection As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents gbxCan As System.Windows.Forms.GroupBox
End Class
