Public Class frmMain
    Private RoleInfo As frmRole
    Private SecurityInfo As frmSecurity

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

    Private Sub PeformNextAction()
        Select Case intNextAction
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbEvent.PerformClick()
            Case ACTION_HOME
                tsbEvent.PerformClick()
            Case ACTION_LOGOUT
                tsbEvent.PerformClick()
            Case ACTION_MEMBER
                tsbEvent.PerformClick()
            Case ACTION_ROLE
                tsbEvent.PerformClick()
            Case ACTION_RSVP
                tsbEvent.PerformClick()
            Case ACTION_SEMESTER
                tsbEvent.PerformClick()
            Case ACTION_TUTOR
                tsbEvent.PerformClick()
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'initialize everything here
        'instantiate a form object for each form in the application
        RoleInfo = New frmRole
        SecurityInfo = New frmSecurity
        SecurityInfo.ShowDialog()
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
    End Sub

    Private Sub tsbLogout_Click(sender As Object, e As EventArgs) Handles tsbLogout.Click
        EndProgram()
    End Sub
End Class
