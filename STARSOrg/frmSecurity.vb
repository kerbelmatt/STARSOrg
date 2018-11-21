Imports System.Data.SqlClient

Public Class frmSecurity
    Private objSecurities As CSecurities

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub Login()
        Dim objReader As SqlDataReader

        Try

        Catch ex As Exception
            'could have CDB throw the error and trap it here
        End Try
    End Sub
End Class