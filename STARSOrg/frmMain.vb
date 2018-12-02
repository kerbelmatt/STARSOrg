Public Class frmMain
    Private RoleInfo As frmRole
    Private SecurityInfo As frmSecurity
    Private TutorInfo As frmTutor
    Private MemberInfo As frmMember

    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogout.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'we need to do this only because we put the graphic image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogout.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'we need to do this only because we put the graphic image in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub SetToolbar()
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
            tss7.Visible = False : tss8.Visible = False : tss9.Visible = False
        End If
    End Sub

    Private Sub PerformNextAction()
        Select Case intNextAction
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
                tsbHome.PerformClick()
            Case ACTION_LOGOUT
                tsbLogout.PerformClick()
            Case ACTION_MEMBER
                tsbMember.PerformClick()
            Case ACTION_ROLE
                tsbRole.PerformClick()
            Case ACTION_RSVP
                tsbRSVP.PerformClick()
            Case ACTION_SEMESTER
                tsbSemester.PerformClick()
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize everything here
        'instantiate a form object for each form in the application
        RoleInfo = New frmRole
        SecurityInfo = New frmSecurity
        TutorInfo = New frmTutor
        MemberInfo = New frmMember
        SecurityInfo.ShowDialog()
        SetToolbar()
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection string = " & gstrConn, "DB Error")
            EndProgram()
        End Try

    End Sub

    Private Sub EndProgram()
        Dim f As Form
        Me.Cursor = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()
        End If
        Me.Cursor = Cursors.Default
        Application.Exit()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        Me.Hide()
        RoleInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        EndProgram()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        Me.Hide()
        TutorInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        Me.Hide()
        MemberInfo.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
End Class
