<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpMembers = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstCurrentMembers = New System.Windows.Forms.ListBox()
        Me.chkNewMember = New System.Windows.Forms.CheckBox()
        Me.grpNewMember = New System.Windows.Forms.GroupBox()
        Me.grpMemberInfo = New System.Windows.Forms.GroupBox()
        Me.txtMemID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReportMember = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSaveMember = New System.Windows.Forms.Button()
        Me.btnSelectPhoto = New System.Windows.Forms.Button()
        Me.picMember = New System.Windows.Forms.PictureBox()
        Me.txtPhotoPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tss0 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.tss3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.tss4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.tss5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.tss6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.tss11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogout = New System.Windows.Forms.ToolStripButton()
        Me.tss10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.tss7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tss9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.tss8 = New System.Windows.Forms.ToolStripSeparator()
        Me.grpMembers.SuspendLayout()
        Me.grpNewMember.SuspendLayout()
        Me.grpMemberInfo.SuspendLayout()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(875, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MEMBER MANAGEMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpMembers
        '
        Me.grpMembers.Controls.Add(Me.btnSearch)
        Me.grpMembers.Controls.Add(Me.txtSearch)
        Me.grpMembers.Controls.Add(Me.Label2)
        Me.grpMembers.Controls.Add(Me.lstCurrentMembers)
        Me.grpMembers.Location = New System.Drawing.Point(14, 202)
        Me.grpMembers.Name = "grpMembers"
        Me.grpMembers.Size = New System.Drawing.Size(296, 312)
        Me.grpMembers.TabIndex = 6
        Me.grpMembers.TabStop = False
        Me.grpMembers.Text = "Current Members"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(196, 268)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(93, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(10, 238)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(278, 23)
        Me.txtSearch.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search By Last Name"
        '
        'lstCurrentMembers
        '
        Me.lstCurrentMembers.FormattingEnabled = True
        Me.lstCurrentMembers.ItemHeight = 15
        Me.lstCurrentMembers.Location = New System.Drawing.Point(7, 27)
        Me.lstCurrentMembers.Name = "lstCurrentMembers"
        Me.lstCurrentMembers.Size = New System.Drawing.Size(282, 184)
        Me.lstCurrentMembers.TabIndex = 2
        '
        'chkNewMember
        '
        Me.chkNewMember.AutoSize = True
        Me.chkNewMember.Location = New System.Drawing.Point(19, 27)
        Me.chkNewMember.Name = "chkNewMember"
        Me.chkNewMember.Size = New System.Drawing.Size(123, 19)
        Me.chkNewMember.TabIndex = 1
        Me.chkNewMember.Text = "Add New Member"
        Me.chkNewMember.UseVisualStyleBackColor = True
        '
        'grpNewMember
        '
        Me.grpNewMember.Controls.Add(Me.chkNewMember)
        Me.grpNewMember.Location = New System.Drawing.Point(14, 136)
        Me.grpNewMember.Name = "grpNewMember"
        Me.grpNewMember.Size = New System.Drawing.Size(296, 59)
        Me.grpNewMember.TabIndex = 1
        Me.grpNewMember.TabStop = False
        Me.grpNewMember.Text = "New Member"
        '
        'grpMemberInfo
        '
        Me.grpMemberInfo.Controls.Add(Me.txtMemID)
        Me.grpMemberInfo.Controls.Add(Me.Label9)
        Me.grpMemberInfo.Controls.Add(Me.btnReportMember)
        Me.grpMemberInfo.Controls.Add(Me.btnCancel)
        Me.grpMemberInfo.Controls.Add(Me.btnSaveMember)
        Me.grpMemberInfo.Controls.Add(Me.btnSelectPhoto)
        Me.grpMemberInfo.Controls.Add(Me.picMember)
        Me.grpMemberInfo.Controls.Add(Me.txtPhotoPath)
        Me.grpMemberInfo.Controls.Add(Me.Label5)
        Me.grpMemberInfo.Controls.Add(Me.txtLName)
        Me.grpMemberInfo.Controls.Add(Me.Label8)
        Me.grpMemberInfo.Controls.Add(Me.txtEmail)
        Me.grpMemberInfo.Controls.Add(Me.Label7)
        Me.grpMemberInfo.Controls.Add(Me.txtPhone)
        Me.grpMemberInfo.Controls.Add(Me.Label6)
        Me.grpMemberInfo.Controls.Add(Me.txtMI)
        Me.grpMemberInfo.Controls.Add(Me.Label4)
        Me.grpMemberInfo.Controls.Add(Me.txtFName)
        Me.grpMemberInfo.Controls.Add(Me.Label3)
        Me.grpMemberInfo.Location = New System.Drawing.Point(336, 136)
        Me.grpMemberInfo.Name = "grpMemberInfo"
        Me.grpMemberInfo.Size = New System.Drawing.Size(553, 377)
        Me.grpMemberInfo.TabIndex = 8
        Me.grpMemberInfo.TabStop = False
        Me.grpMemberInfo.Text = "Member Information"
        '
        'txtMemID
        '
        Me.txtMemID.Location = New System.Drawing.Point(449, 222)
        Me.txtMemID.Name = "txtMemID"
        Me.txtMemID.Size = New System.Drawing.Size(98, 23)
        Me.txtMemID.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(369, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Member ID:"
        '
        'btnReportMember
        '
        Me.btnReportMember.Location = New System.Drawing.Point(362, 323)
        Me.btnReportMember.Name = "btnReportMember"
        Me.btnReportMember.Size = New System.Drawing.Size(96, 38)
        Me.btnReportMember.TabIndex = 14
        Me.btnReportMember.Text = "Report"
        Me.btnReportMember.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(229, 323)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(96, 38)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSaveMember
        '
        Me.btnSaveMember.Location = New System.Drawing.Point(96, 323)
        Me.btnSaveMember.Name = "btnSaveMember"
        Me.btnSaveMember.Size = New System.Drawing.Size(96, 38)
        Me.btnSaveMember.TabIndex = 12
        Me.btnSaveMember.Text = "Save"
        Me.btnSaveMember.UseVisualStyleBackColor = True
        '
        'btnSelectPhoto
        '
        Me.btnSelectPhoto.Location = New System.Drawing.Point(347, 251)
        Me.btnSelectPhoto.Name = "btnSelectPhoto"
        Me.btnSelectPhoto.Size = New System.Drawing.Size(91, 24)
        Me.btnSelectPhoto.TabIndex = 11
        Me.btnSelectPhoto.Text = "Select Photo"
        Me.btnSelectPhoto.UseVisualStyleBackColor = True
        '
        'picMember
        '
        Me.picMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMember.Image = Global.STARSOrg.My.Resources.Resources.STARS_National_LOGO
        Me.picMember.Location = New System.Drawing.Point(372, 27)
        Me.picMember.Name = "picMember"
        Me.picMember.Size = New System.Drawing.Size(175, 173)
        Me.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMember.TabIndex = 19
        Me.picMember.TabStop = False
        '
        'txtPhotoPath
        '
        Me.txtPhotoPath.Location = New System.Drawing.Point(96, 252)
        Me.txtPhotoPath.Name = "txtPhotoPath"
        Me.txtPhotoPath.Size = New System.Drawing.Size(245, 23)
        Me.txtPhotoPath.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Photo Path:"
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(96, 117)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(245, 23)
        Me.txtLName.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Last Name:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 162)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(245, 23)
        Me.txtEmail.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Email:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(96, 207)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(245, 23)
        Me.txtPhone.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Phone:"
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(96, 72)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(245, 23)
        Me.txtMI.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Middle Initial:"
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(96, 27)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(245, 23)
        Me.txtFName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name:"
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(904, 25)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Size = New System.Drawing.Size(630, 20)
        Me.tslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss0, Me.tsbHome, Me.tss1, Me.tsbMember, Me.tss2, Me.tsbRole, Me.tss3, Me.tsbEvent, Me.tss4, Me.tsbRSVP, Me.tss5, Me.tsbCourse, Me.tss6, Me.tsbSemester, Me.tss11, Me.tsbLogout, Me.tss10, Me.tsbHelp, Me.tss7, Me.tss9, Me.tsbTutor, Me.tss8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(904, 58)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tss0
        '
        Me.tss0.AutoSize = False
        Me.tss0.Name = "tss0"
        Me.tss0.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'tss1
        '
        Me.tss1.AutoSize = False
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'tss2
        '
        Me.tss2.AutoSize = False
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLES"
        '
        'tss3
        '
        Me.tss3.AutoSize = False
        Me.tss3.Name = "tss3"
        Me.tss3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENTS"
        '
        'tss4
        '
        Me.tss4.AutoSize = False
        Me.tss4.Name = "tss4"
        Me.tss4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'tss5
        '
        Me.tss5.AutoSize = False
        Me.tss5.Name = "tss5"
        Me.tss5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSES"
        '
        'tss6
        '
        Me.tss6.AutoSize = False
        Me.tss6.Name = "tss6"
        Me.tss6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'tss11
        '
        Me.tss11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss11.AutoSize = False
        Me.tss11.Name = "tss11"
        Me.tss11.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogout
        '
        Me.tsbLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogout.AutoSize = False
        Me.tsbLogout.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogout.Name = "tsbLogout"
        Me.tsbLogout.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogout.Text = "LOG OUT"
        '
        'tss10
        '
        Me.tss10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss10.AutoSize = False
        Me.tss10.Name = "tss10"
        Me.tss10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'tss7
        '
        Me.tss7.AutoSize = False
        Me.tss7.Name = "tss7"
        Me.tss7.Size = New System.Drawing.Size(10, 50)
        '
        'tss9
        '
        Me.tss9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tss9.AutoSize = False
        Me.tss9.Name = "tss9"
        Me.tss9.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'tss8
        '
        Me.tss8.AutoSize = False
        Me.tss8.Name = "tss8"
        Me.tss8.Size = New System.Drawing.Size(10, 50)
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(904, 542)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpMemberInfo)
        Me.Controls.Add(Me.grpNewMember)
        Me.Controls.Add(Me.grpMembers)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Member Management"
        Me.grpMembers.ResumeLayout(False)
        Me.grpMembers.PerformLayout()
        Me.grpNewMember.ResumeLayout(False)
        Me.grpNewMember.PerformLayout()
        Me.grpMemberInfo.ResumeLayout(False)
        Me.grpMemberInfo.PerformLayout()
        CType(Me.picMember, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents grpMembers As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstCurrentMembers As ListBox
    Friend WithEvents chkNewMember As CheckBox
    Friend WithEvents grpNewMember As GroupBox
    Friend WithEvents grpMemberInfo As GroupBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picMember As PictureBox
    Friend WithEvents txtPhotoPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents btnSelectPhoto As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReportMember As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveMember As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents tslStatus As ToolStripStatusLabel
    Friend WithEvents txtMemID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tss0 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents tss1 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents tss2 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents tss3 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents tss4 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents tss5 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents tss6 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents tss11 As ToolStripSeparator
    Friend WithEvents tsbLogout As ToolStripButton
    Friend WithEvents tss10 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents tss7 As ToolStripSeparator
    Friend WithEvents tss9 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents tss8 As ToolStripSeparator
End Class
