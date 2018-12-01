Imports System.Data.SqlClient
Public Class CMembers
    ' Represents the MEMBER table and its associated business rules
    Private _Member As CMember

    ' Constructor
    Public Sub New()
        ' Instantiate the CMember object
        _Member = New CMember
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property

    Public Sub Clear()
        _Member = New CMember
    End Sub

    Public Sub CreateNewMember()
        ' Call this when clearing the edit portion of the screen to add a new member
        Clear()
        _Member.IsNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllMembers", Nothing)
    End Function

    Public Function GetMemberByMemberID(strID As String) As CMember
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getMemberByMemberID", params))
        Return _Member
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CMember
        Using sqlDR
            If sqlDR.Read() Then ' Found the member record
                With _Member
                    .PID = sqlDR.Item("PID") & ""
                    .FName = sqlDR.Item("FName") & ""
                    .LName = sqlDR.Item("LName") & ""
                    .MI = sqlDR.Item("MI") & ""
                    .Email = sqlDR.Item("Email") & ""
                    .Phone = sqlDR.Item("Phone") & ""
                    .PhotoPath = sqlDR.Item("PhotoPath") & ""
                End With
            Else
                ' Did not get a matching member record
            End If
        End Using
        sqlDR.Close()
        Return _Member
    End Function
End Class
