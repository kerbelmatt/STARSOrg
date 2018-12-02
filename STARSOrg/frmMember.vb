Imports System.Data.SqlClient

Public Class frmMember

    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private myDB As CDB
    Private sqlDR As SqlDataReader
    Private strPicturePath As String

#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs)
        ' We need to do this because we're not putting image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs)
        ' We need to do this because we're not putting image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvents_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs)
        'no action needed as we're already on the ROLE form!
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemesters_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs)
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
#End Region

    Private Sub LoadMembers()
        Dim objDR As SqlDataReader
        lstCurrentMembers.Items.Clear()
        Try
            objDR = objMembers.GetAllMembers()
            Do While objDR.Read
                lstCurrentMembers.Items.Add(objDR.Item("PID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmMemberManagement LoadMembers(): " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If objMembers.CurrentObject.PID <> "" Then
            lstCurrentMembers.SelectedIndex = lstCurrentMembers.FindStringExact(objMembers.CurrentObject.PID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmMemberManagement_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
        myDB = New CDB
        If Not myDB.OpenDB Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMemberManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadMembers()
        grpMemberInfo.Enabled = False
        grpMembers.Enabled = True
    End Sub

    Private Sub LoadSelectedMemberInfo()
        Try
            objMembers.GetMemberByMemberID(lstCurrentMembers.SelectedItem)
            With objMembers.CurrentObject
                txtMemID.Text = .PID
                txtFName.Text = .FName
                txtMI.Text = .MI
                txtLName.Text = .LName
                txtEmail.Text = .Email
                txtPhone.Text = .Phone
                txtPhotoPath.Text = .PhotoPath
                strPicturePath = txtPhotoPath.Text.ToString
                picMember.Image = Image.FromFile(strPicturePath)
            End With
        Catch ex As Exception
            MessageBox.Show("Error Loading List of Members: " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCurrentMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCurrentMembers.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstCurrentMembers.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNewMember.Checked = False
        LoadSelectedMemberInfo()
        grpMemberInfo.Enabled = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Currently not functional, work in progress
        Dim blnErrors As Boolean
        Dim params As New ArrayList
        If txtSearch.Text.Length = 0 Then 'Missing Search Value
            errP.SetError(txtSearch, "You must enter a search value here")
            blnErrors = True
        End If

        params.Add(New SqlParameter("@lastname", txtSearch.Text))
        sqlDA = myDB.GetDataAdapterBySP("dbo.sp_GetMemberLNameList", params)
        dt = New DataTable
        sqlDA.Fill(dt)
        lstCurrentMembers.DataSource = dt
    End Sub

    Private Sub btnSelectPhoto_Click(sender As Object, e As EventArgs) Handles btnSelectPhoto.Click
        Dim intResult As Integer
        ofdOpen.InitialDirectory = Application.StartupPath
        ofdOpen.Filter = "Image Types |*.gif;*.jpg;*.png;*.bmp"
        ofdOpen.FilterIndex = 2
        intResult = ofdOpen.ShowDialog
        If intResult = DialogResult.Cancel Then
            'User cancelled the open dialog box
            Exit Sub
        End If
        txtPhotoPath.Text = ofdOpen.FileName
        strPicturePath = ofdOpen.FileName
        picMember.Image = Image.FromFile(strPicturePath)
    End Sub

    Private Sub btnSaveMember_Click(sender As Object, e As EventArgs) Handles btnSaveMember.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""

        'First perform validation
        If Not ValidateTextBoxLength(txtFName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLName, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objMembers.CurrentObject
            .PID = txtMemID.Text
            .FName = txtFName.Text
            .MI = txtMI.Text
            .LName = txtLName.Text
            .Email = txtEmail.Text
            .Phone = txtPhone.Text
            .PhotoPath = txtPhotoPath.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objMembers.Save
            If intResult = 1 Then
                tslStatus.Text = "Member Saved Successfully"
            End If
            If intResult = -1 Then
                'Member isn't unique
                MessageBox.Show("MemberID must be unique. Unable to save member record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Unknown database error: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadMembers()
        chkNewMember.Checked = False
        grpMembers.Enabled = True
    End Sub

    Private Sub btnReportMember_Click(sender As Object, e As EventArgs) Handles btnReportMember.Click
        MessageBox.Show("Window will be displayed here with formatted report of all members and security levels", "Incomplete Functionality", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        chkNewMember.Checked = False
        errP.Clear()
        If lstCurrentMembers.SelectedIndex <> -1 Then
            LoadSelectedMemberInfo() 'reload the previously selected record
        Else 'Disable the edit area - nothing was previously selected
            grpMemberInfo.Enabled = False
        End If
        blnClearing = False
        objMembers.CurrentObject.IsNewMember = False
        grpMembers.Enabled = True
    End Sub

    Private Sub chkNewMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMember.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewMember.Checked Then
            tslStatus.Text = ""
            txtMemID.Clear()
            txtFName.Clear()
            txtLName.Clear()
            txtMI.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            txtPhotoPath.Clear()
            lstCurrentMembers.SelectedIndex = -1
            txtMemID.Enabled = True
            grpMembers.Enabled = False
            grpMemberInfo.Enabled = True
            objMembers.CreateNewMember()
            picMember.Image = My.Resources.Resources.STARS_National_LOGO
        Else
            grpMembers.Enabled = True
            grpMemberInfo.Enabled = False
            objMembers.CurrentObject.IsNewMember = False
            txtMemID.Enabled = False
        End If
    End Sub

    Private Sub SetTsbPermissions()
        If user_Role = "ADMIN" Then
            'All toolstrip items are available
        End If
        'Officers can't access member management
        If user_Role = "OFFICER" Then
            tsbMember.Enabled = False
            tsbMember.Visible = False
            tss2.Visible = False
        End If
        'Members can't access course, role, member, or semester management
        If user_Role = "MEMBER" Then
            tsbCourse.Enabled = False
            tsbCourse.Visible = False
            tsbRoles.Enabled = False
            tsbRoles.Visible = False
            tsbMember.Enabled = False
            tsbMember.Visible = False
            tsbSemesters.Enabled = False
            tsbSemesters.Visible = False
            tss2.Visible = False : tss3.Visible = False : tss6.Visible = False : tss7.Visible = False
        End If
        'Guests can only access RSVP form
        If user_Role = "GUEST" Then
            tsbCourse.Enabled = False
            tsbCourse.Visible = False
            tsbRoles.Enabled = False
            tsbRoles.Visible = False
            tsbEvents.Enabled = False
            tsbEvents.Visible = False
            tsbMember.Enabled = False
            tsbMember.Visible = False
            tsbTutor.Enabled = False
            tsbTutor.Visible = False
            tsbSemesters.Enabled = False
            tsbSemesters.Visible = False
            tss2.Visible = False : tss3.Visible = False : tss4.Visible = False : tss5.Visible = False
            tss7.Visible = False : tss8.Visible = False : tss9.Visible = False
        End If
    End Sub
End Class