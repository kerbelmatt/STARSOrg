Imports System.Data.SqlClient
Public Class CSecurities
    ' Represents the SECURITY table and its associated business rules
    Private _Security As CSecurity

    ' Constructor
    Public Sub New()
        ' Instantiate the CSecurity object
        _Security = New CSecurity
    End Sub

    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _Security
        End Get
    End Property

    Public Sub Clear()
        _Security = New CSecurity
    End Sub

    Public Sub CreateNewSecurity()
        ' Call this when clearing the edit portion of the screen to add a new security
        Clear()
        _Security.IsNewSecurity = True
    End Sub

    Public Function Save() As Integer
        Return _Security.Save
    End Function

    Public Function CheckCredentials(strUserID As String, strPassword As String) As Integer
        Dim params As New ArrayList
        params.Add(New SqlParameter("UserID", strUserID))
        params.Add(New SqlParameter("Password", strPassword))
        Dim strResult As String = myDB.GetSingleValueFromSP("sp_getPIDbyLogin", params)
        If strResult = -1 Then
            'Invalid login
            Return -1
        Else
            Return CInt(strResult)
        End If
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CSecurity
        Using sqlDR
            If sqlDR.Read() Then
                With _Security
                    .PID = sqlDR.Item("PID") & ""
                    .UserID = sqlDR.Item("UserID") & ""
                    .Password = sqlDR.Item("Password") & ""
                    .SecRole = sqlDR.Item("SecRole") & ""
                End With
            Else
                ' Did not get a matching security record
            End If
        End Using
        sqlDR.Close()
        Return _Security
    End Function
End Class