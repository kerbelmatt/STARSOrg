Imports System.Data.SqlClient
Public Class CTutors
    ' Represents the TUTOR_COURSE table and its associated business rules
    Private _Tutor As CTutor

    ' Constructor
    Public Sub New()
        ' Instantiate the CTutor object
        _Tutor = New CTutor
    End Sub

    Public ReadOnly Property CurrentObject() As CTutor
        Get
            Return _Tutor
        End Get
    End Property

    Public Sub Clear()
        _Tutor = New CTutor
    End Sub

    Public Sub CreateNewTutor()
        ' Call this when clearing the edit portion of the screen to add a new tutor
        Clear()
        _Tutor.IsNewTutor = True
    End Sub

    Public Function Save() As Integer
        Return _Tutor.Save
    End Function

    Public Function GetAllTutors() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllTutors", Nothing)
    End Function

    Public Function GetTutorByTutorID(strID As String) As CTutor
        Dim params As New ArrayList
        params.Add(New SqlParameter("ukid", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getTutorByTutorID", params))
        Return _Tutor
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CTutor
        Using sqlDR
            If sqlDR.Read() Then ' Found the Tutor record
                With _Tutor
                    .ukid = sqlDR.Item("ukid") & ""
                    .PID = sqlDR.Item("PID") & ""
                    .CourseID = sqlDR.Item("CourseID") & ""
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                End With
            Else
                ' Did not get a matching Tutor record
            End If
        End Using
        sqlDR.Close()
        Return _Tutor
    End Function
End Class
