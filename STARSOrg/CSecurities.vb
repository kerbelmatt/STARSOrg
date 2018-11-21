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

    Public Function GetAllSecurities() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllSecurities", Nothing)
    End Function

    Public Function GetSecurityBySecurityID(strID As String) As CSecurity
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getSecurityBySecurityID", params))
        Return _Security
    End Function

    Public Function CheckCredentials(strUserID As String, strPassword As String) As CSecurity
        Dim params As New ArrayList
        params.Add(New SqlParameter("UserID", strUserID))
        params.Add(New SqlParameter("Password", strPassword))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_checkCredentials", params))
        Return _Security
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CSecurity
        Using sqlDR
            If sqlDR.Read() Then ' Found the role record
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