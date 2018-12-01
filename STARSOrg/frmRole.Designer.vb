<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRole
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
        Me.components = New System.ComponentModel.Container()
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
        Me.lblRoles = New System.Windows.Forms.Label()
        Me.grpNewRole = New System.Windows.Forms.GroupBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.grpRoles = New System.Windows.Forms.GroupBox()
        Me.lstRoles = New System.Windows.Forms.ListBox()
        Me.grpEdit = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtRoleID = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblRoleID = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.grpNewRole.SuspendLayout()
        Me.grpRoles.SuspendLayout()
        Me.grpEdit.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tss0, Me.tsbHome, Me.tss1, Me.tsbMember, Me.tss2, Me.tsbRole, Me.tss3, Me.tsbEvent, Me.tss4, Me.tsbRSVP, Me.tss5, Me.tsbCourse, Me.tss6, Me.tsbSemester, Me.tss11, Me.tsbLogout, Me.tss10, Me.tsbHelp, Me.tss7, Me.tss9, Me.tsbTutor, Me.tss8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(737, 58)
        Me.ToolStrip1.TabIndex = 2
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
        'lblRoles
        '
        Me.lblRoles.BackColor = System.Drawing.Color.White
        Me.lblRoles.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoles.Location = New System.Drawing.Point(64, 85)
        Me.lblRoles.Name = "lblRoles"
        Me.lblRoles.Size = New System.Drawing.Size(611, 77)
        Me.lblRoles.TabIndex = 3
        Me.lblRoles.Text = "Roles"
        Me.lblRoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNewRole
        '
        Me.grpNewRole.Controls.Add(Me.chkNew)
        Me.grpNewRole.Location = New System.Drawing.Point(45, 204)
        Me.grpNewRole.Name = "grpNewRole"
        Me.grpNewRole.Size = New System.Drawing.Size(233, 115)
        Me.grpNewRole.TabIndex = 4
        Me.grpNewRole.TabStop = False
        Me.grpNewRole.Text = "New Role"
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(8, 35)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(96, 19)
        Me.chkNew.TabIndex = 0
        Me.chkNew.Text = "Add new role"
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'grpRoles
        '
        Me.grpRoles.Controls.Add(Me.lstRoles)
        Me.grpRoles.Location = New System.Drawing.Point(45, 348)
        Me.grpRoles.Name = "grpRoles"
        Me.grpRoles.Size = New System.Drawing.Size(233, 155)
        Me.grpRoles.TabIndex = 5
        Me.grpRoles.TabStop = False
        Me.grpRoles.Text = "Roles"
        '
        'lstRoles
        '
        Me.lstRoles.FormattingEnabled = True
        Me.lstRoles.ItemHeight = 15
        Me.lstRoles.Location = New System.Drawing.Point(41, 22)
        Me.lstRoles.Name = "lstRoles"
        Me.lstRoles.Size = New System.Drawing.Size(139, 109)
        Me.lstRoles.TabIndex = 0
        '
        'grpEdit
        '
        Me.grpEdit.Controls.Add(Me.txtDesc)
        Me.grpEdit.Controls.Add(Me.btnCancel)
        Me.grpEdit.Controls.Add(Me.btnSave)
        Me.grpEdit.Controls.Add(Me.txtRoleID)
        Me.grpEdit.Controls.Add(Me.lblDesc)
        Me.grpEdit.Controls.Add(Me.lblRoleID)
        Me.grpEdit.Location = New System.Drawing.Point(355, 204)
        Me.grpEdit.Name = "grpEdit"
        Me.grpEdit.Size = New System.Drawing.Size(339, 299)
        Me.grpEdit.TabIndex = 6
        Me.grpEdit.TabStop = False
        Me.grpEdit.Text = "Edit Role"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(114, 92)
        Me.txtDesc.MaxLength = 15
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(203, 133)
        Me.txtDesc.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(231, 254)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 27)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(114, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtRoleID
        '
        Me.txtRoleID.Location = New System.Drawing.Point(114, 43)
        Me.txtRoleID.MaxLength = 15
        Me.txtRoleID.Name = "txtRoleID"
        Me.txtRoleID.Size = New System.Drawing.Size(203, 23)
        Me.txtRoleID.TabIndex = 2
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(22, 96)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(70, 15)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Description:"
        '
        'lblRoleID
        '
        Me.lblRoleID.AutoSize = True
        Me.lblRoleID.Location = New System.Drawing.Point(22, 46)
        Me.lblRoleID.Name = "lblRoleID"
        Me.lblRoleID.Size = New System.Drawing.Size(47, 15)
        Me.lblRoleID.TabIndex = 0
        Me.lblRoleID.Text = "Role ID:"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(588, 520)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(87, 27)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmRole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(737, 567)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.grpEdit)
        Me.Controls.Add(Me.grpRoles)
        Me.Controls.Add(Me.grpNewRole)
        Me.Controls.Add(Me.lblRoles)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmRole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNewRole.ResumeLayout(False)
        Me.grpNewRole.PerformLayout()
        Me.grpRoles.ResumeLayout(False)
        Me.grpEdit.ResumeLayout(False)
        Me.grpEdit.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents tss11 As ToolStripSeparator
    Friend WithEvents tsbLogout As ToolStripButton
    Friend WithEvents tss10 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents tss7 As ToolStripSeparator
    Friend WithEvents tss9 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents tss8 As ToolStripSeparator
    Friend WithEvents lblRoles As Label
    Friend WithEvents grpNewRole As GroupBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents grpRoles As GroupBox
    Friend WithEvents lstRoles As ListBox
    Friend WithEvents grpEdit As GroupBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtRoleID As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblRoleID As Label
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents btnPrint As Button
End Class
