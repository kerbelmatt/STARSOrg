Imports System.Data.SqlClient

Public Class CAudits
    'Represents the Audit table and its associated business rules
    Private _Audit As CAudit

    'constructor
    Public Sub New()
        'instantiate the CAudit object
        _Audit = New CAudit
    End Sub
    Public ReadOnly Property CurrentObject() As CAudit
        Get
            Return _Audit
        End Get
    End Property
    Public Sub Clear()
        _Audit = New CAudit
    End Sub

    Public Function Save() As Integer
        Return _Audit.Save()
    End Function

    Public Function GetAllAudits() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllAudits", Nothing)
    End Function

    Public Function GetAuditByPID(strID As String) As CAudit
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getAuditsByPID", params))
        Return _Audit
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CAudit
        Using sqlDR
            If sqlDR.Read() Then 'found the Audit record
                With _Audit
                    .PID = sqlDR.Item("PID") & ""
                    .AccessTimestamp = sqlDR.Item("ACCESSTIMESTAMP") & ""
                    .Success = sqlDR.Item("Success") & ""
                End With
            Else
                'did not get a matching Audit record
            End If
        End Using
        sqlDR.Close()
        Return _Audit
    End Function
End Class
