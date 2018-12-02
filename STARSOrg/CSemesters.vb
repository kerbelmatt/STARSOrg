Imports System.Data.SqlClient
Public Class CSemesters
    ' Represents the SEMESTER table and its associated business rules
    Private _Semester As CSemester

    ' Constructor
    Public Sub New()
        ' Instantiate the CSemester object
        _Semester = New CSemester
    End Sub

    Public ReadOnly Property CurrentObject() As CSemester
        Get
            Return _Semester
        End Get
    End Property

    Public Sub Clear()
        _Semester = New CSemester
    End Sub

    Public Sub CreateNewSemester()
        ' Call this when clearing the edit portion of the screen to add a new semester
        Clear()
        _Semester.IsNewSemester = True
    End Sub

    Public Function Save() As Integer
        Return _Semester.Save
    End Function

    Public Function GetAllSemesters() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllSemesters", Nothing)
    End Function

    Public Function GetSemesterBySemesterID(strID As String)
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_getSemesterBySemesterID", params))
        Return _Semester
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CSemester
        Using sqlDR
            If sqlDR.Read() Then
                With _Semester
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                    .SemesterDescription = sqlDR.Item("SemesterDescription") & ""
                End With
            Else
                ' Did not get a matching semester record
            End If
        End Using
        sqlDR.Close()
        Return _Semester
    End Function
End Class
