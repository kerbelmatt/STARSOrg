Imports System.Data.SqlClient

Public Class frmSecurity
    Private objSecurities As CSecurities
    Private objAudits As CAudits
    Private objMembers As CMembers

    Private Sub frmSecurity_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecurities = New CSecurities
        objAudits = New CAudits
        objMembers = New CMembers
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        user_PID = "0000001"
        user_FName = "Guest"
        user_LName = "Guest"
        user_Role = "GUEST"
        Dim intResult As Integer
        With objAudits.CurrentObject
            .PID = user_PID
            .ACCESSTIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            .SUCCESS = True
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objAudits.Save
            If intResult = -1 Then 'error occurred in stored procedure
                MessageBox.Show("Error in Audit entry", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Audit entry: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = Cursors.Default
        Me.Hide()
        frmMain.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim blnErrors As Boolean

        If Not ValidateTextBoxLength(txtPassword, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtUserID, errP) Then
            blnErrors = True
        End If

        Dim mstrUserID = txtUserID.Text
        Dim mstrPassword = txtPassword.Text

        Try
            Me.Cursor = Cursors.WaitCursor
            objSecurities.CheckCredentials(mstrUserID, mstrPassword)
            If objSecurities.CurrentObject.PID = "" Then 'error occurred in stored procedure
                MessageBox.Show("Login unsuccessful, please check username and password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Cursor = Cursors.Default
            Else
                With objSecurities.CurrentObject
                    user_PID = .PID
                    user_Role = .SecRole
                End With
                MessageBox.Show("Successful Login. User PID: " & user_PID)
                Me.Cursor = Cursors.Default
                Me.Hide()
                frmMain.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error in CheckCredentials()")
        End Try






        'With objAudits.CurrentObject
        '    .PID = user_PID
        '    .ACCESSTIMESTAMP = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        '    .SUCCESS = True
        'End With
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    intResult = objAudits.Save
        '    If intResult = -1 Then 'error occurred in stored procedure
        '        MessageBox.Show("Error in Audit entry", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Unable to save Audit entry: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        'Me.Cursor = Cursors.Default

    End Sub

    Private Sub frmSecurity_Closed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub
End Class