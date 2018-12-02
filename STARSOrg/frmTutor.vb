Imports System.Data.SqlClient

''' IDEAS
''' Rather than using a boolean array to check which courses have already been selected by the user, 
''' Can the COURSE table be crossed with the TUTOR_COURSE table with the user PID as a parameter? 
''' This way you could check to see which CourseID's are already present and not bother loading them
''' into the list
''' IDEAS

Public Class frmTutor
    Private sqlDA As SqlDataAdapter
    Private dt As DataTable
    Private sqlDR As SqlDataReader
    Private objTutors As CTutors
    Private objSemesters As CSemesters
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean

    Private Sub frmTutor_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSemesters = New CSemesters
        objCourses = New CCourses
        LoadSemesters()
        LoadAvailableCourses()
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
#End Region

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    End Sub

    Private Sub LoadSemesters()
        Dim objReader As SqlDataReader
        lstSemester.Items.Clear()
        Try
            objReader = objSemesters.GetAllSemesters()
            Do While objReader.Read
                lstSemester.Items.Add(objReader.Item("SemesterDescription"))
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
                clbCourses.Items.Add(objReader.Item("CourseName"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in frmTutor LoadAvailableCourses(): " & ex.ToString, "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMyCourses()
        ' Use a stored procedure to get the courses that the user is tutoring for, call in form load event
        'Dim objDR As SqlDataReader

    End Sub

    Private Sub frmTutor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
    End Sub

    Private Sub lstSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemester.SelectedIndexChanged
        ' The user changed the selected semester, load appropriate (available) courses into clbCourses
        Select Case lstSemester.SelectedItem.ToString
            Case "Fall 2016"

            Case "Fall 2017"

            Case "Spring 2017"

            Case "Summer 2017"

            Case Else
                MessageBox.Show("Unexpected case in lstSemester_SelectedIndexChanged() Sub", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        ' The user has (hopefully) made their course selections they want to tutor
        ' Check for errors and update database information accordingly.
        Dim blnErrors As Boolean
        If clbCourses.SelectedIndex = -1 Then
            errP.SetError(clbCourses, "You must select a course to commit")
            blnErrors = True
        End If

        If blnErrors Then ' If there were errors, do not proceed
            Exit Sub
        End If
    End Sub
End Class