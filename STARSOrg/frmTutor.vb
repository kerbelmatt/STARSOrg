Imports System.Data.SqlClient

Public Class frmTutor
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private sqlDR As SqlDataReader
    Private objTutors As CTutors
    Private objSemesters As CSemesters
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private intSelectedSemester As Integer
    Private intCourses As Integer
    Private frmTutorReport As frmTutorReport
    Dim blnCourses() As Boolean

    Private Sub frmTutor_Load(sender As Object, e As EventArgs) Handles Me.Load

        intCourses = myDB.GetSingleValueFromSP("sp_getNumCourses", Nothing)
        ReDim blnCourses(intCourses)
        SetTsbPermissions()
        objSemesters = New CSemesters
        objCourses = New CCourses
        objTutors = New CTutors
        LoadSemesters()
        LoadAvailableCourses()
        LoadMyCourses()
    End Sub

#Region "Toolbar Stuff"

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        ' We need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        ' We need to do this only because we are not putting our images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        ' Nothing to do here, already on Tutor page
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
            tsbRole.Enabled = False
            tsbRole.Visible = False
            tsbMember.Enabled = False
            tsbMember.Visible = False
            tsbSemester.Enabled = False
            tsbSemester.Visible = False
            tss2.Visible = False : tss3.Visible = False : tss6.Visible = False : tss7.Visible = False
        End If
        'Guests can only access RSVP form
        If user_Role = "GUEST" Then
            tsbCourse.Enabled = False
            tsbCourse.Visible = False
            tsbRole.Enabled = False
            tsbRole.Visible = False
            tsbEvent.Enabled = False
            tsbEvent.Visible = False
            tsbMember.Enabled = False
            tsbMember.Visible = False
            tsbTutor.Enabled = False
            tsbTutor.Visible = False
            tsbSemester.Enabled = False
            tsbSemester.Visible = False
            tss2.Visible = False : tss3.Visible = False : tss4.Visible = False : tss5.Visible = False
            tss7.Visible = False : t.Visible = False : tss9.Visible = False
        End If
    End Sub
#End Region

    Private Sub LoadSemesters()
        Dim objReader As SqlDataReader
        lstSemester.Items.Clear()
        Try
            objReader = objSemesters.GetAllSemesters()
            Do While objReader.Read
                lstSemester.Items.Add(objReader.Item("SemesterID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmTutor LoadSemesters(): " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If objSemesters.CurrentObject.SemesterDescription <> "" Then
            lstSemester.SelectedIndex = lstSemester.FindStringExact(objSemesters.CurrentObject.SemesterDescription)
        End If
        blnReloading = False
    End Sub

    Private Sub LoadAvailableCourses()
        ' NOTE: This sub will need to change, it is not complete. Must check boolean array to see if 
        ' current course has already been selected by the user
        Dim objReader As SqlDataReader
        clbCourses.Items.Clear()
        Try
            objReader = objCourses.GetAllCourses()
            Do While objReader.Read
                clbCourses.Items.Add(objReader.Item("CourseID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmTutor LoadAvailableCourses(): " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMyCourses()
        ' Use a stored procedure to get the courses that the user is tutoring for, call in form load event
        Dim objReader As SqlDataReader
        lstMember.Items.Clear()
        Try
            objReader = objTutors.GetAllTutors()
            Do While objReader.Read
                lstMember.Items.Add(objReader.Item("CourseID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmTutor LoadMyCourses(): " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTutor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'ClearScreenControls(Me)

    End Sub

    Private Sub lstSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemester.SelectedIndexChanged
        ' The user changed the selected semester, load appropriate (available) courses into clbCourses
        ' Also clear 'My Courses' beforehand
        Dim courseCheck As Integer

        For index As Integer = 0 To intCourses - 1 ' Clear all course selections
            If clbCourses.GetItemChecked(index) Then
                clbCourses.SetItemChecked(index, False)
            End If
        Next

        For index As Integer = 0 To intCourses - 1
            If blnCourses(index) = 1 Then
                clbCourses.SetItemChecked(index, True)
            End If
        Next

        For index As Integer = 1 To intCourses - 1
            Dim params As New ArrayList
            params.Add(New SqlParameter("SemesterID", lstSemester.SelectedIndex.ToString))
            params.Add(New SqlParameter("PID", user_PID)) ' change this parameter value to the value given by security
            params.Add(New SqlParameter("CourseName", clbCourses.Items(index).ToString))

            courseCheck = myDB.GetSingleValueFromSP("sp_checkCourseExists", params)

            If courseCheck = 1 Then ' Member is tutoring this course for the semester, Update 'My Courses'
                blnCourses(index) = 1
            End If
            clbCourses.Items(index).ToString()
        Next

    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        ' The user has (hopefully) made their course selections they want to tutor
        ' Check for errors and update database information accordingly.
        Dim blnErrors As Boolean
        Dim intResult As Integer
        tslStatus.Text = ""

        If clbCourses.SelectedIndex = -1 Then
            errP.SetError(clbCourses, "You must select a course to commit")
            blnErrors = True
        End If

        If lstSemester.SelectedIndex = -1 Then
            errP.SetError(lstSemester, "You must select a semester.")
            blnErrors = True
        End If

        If blnErrors Then ' If there were errors, do not proceed
            Exit Sub
        End If

        ' Use multiple if statements with (and also)
        For index As Integer = 1 To intCourses - 1
            If Not clbCourses.GetItemChecked(index) AndAlso Not blnCourses(index) Then
                ' No action, course never selected
            End If
            If clbCourses.GetItemChecked(index) AndAlso blnCourses(index) Then
                ' No action, course was previously selected and there is no change
            End If
            If clbCourses.GetItemChecked(index) AndAlso Not blnCourses(index) Then
                ' Add this course to this tutor's course list for the selected semester
                lstMember.Items.Add(clbCourses.Items(index).ToString)
                objTutors.CreateNewTutor()
                With objTutors.CurrentObject
                    .PID = "8192384" 'user_PID
                    .CourseID = clbCourses.Items(index).ToString
                    .SemesterID = lstSemester.SelectedItem.ToString
                End With
                Try
                    Me.Cursor = Cursors.WaitCursor
                    intResult = objTutors.Save
                    If intResult = 1 Then
                        tslStatus.Text = "Tutor record saved"
                    End If
                    If intResult = -1 Then
                        MessageBox.Show("ukid must be unique. Unable to save tutor record.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Me.Cursor = Cursors.Default
                Catch ex As Exception

                End Try
            End If
            If Not clbCourses.GetItemChecked(index) AndAlso blnCourses(index) Then
                ' Delete this course from this tutor's course list for the selected semester
                ' Pass in three parameters for PID CourseID and SemesterID to stored procedure
                Dim params As ArrayList
                params.Add(New SqlParameter("PID", user_PID))
                params.Add(New SqlParameter("CourseID", clbCourses.Items(index).ToString))
                params.Add(New SqlParameter("SemesterID", lstSemester.SelectedItem.ToString))
                myDB.ExecSP("sp_deleteCourse", params)
            End If
        Next
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmTutorReport = New frmTutorReport
        frmTutorReport.Display()
    End Sub
End Class