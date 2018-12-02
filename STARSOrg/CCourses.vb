Imports System.Data.SqlClient
Public Class CCourses
    ' Represents the COURSE table and its associated business rules
    Private _Course As CCourse

    ' Constructor
    Public Sub New()
        ' Instantiate the CCourse object
        _Course = New CCourse
    End Sub

    Public ReadOnly Property CurrentObject() As CCourse
        Get
            Return _Course
        End Get
    End Property

    Public Sub Clear()
        _Course = New CCourse
    End Sub

    Public Sub CreateNewCourse()
        ' Call this when clearing the edit portion of the screen to add a new course
        Clear()
        _Course.IsNewCourse = True
    End Sub

    Public Function Save() As Integer
        Return _Course.Save
    End Function

    Public Function GetAllCourses() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_getAllCourses", Nothing)
    End Function

    Public Function GetCourseByCourseID(strID As String) As CCourse
        Dim params As New ArrayList
        params.Add(New SqlParameter("CourseID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetCourseByCourseID", params))
        Return _Course
    End Function

    Public Function FillObject(sqlDR As SqlDataReader) As CCourse
        Using sqlDR
            If sqlDR.Read() Then
                With _Course
                    .CourseID = sqlDR.Item("CourseID") & ""
                    .CourseName = sqlDR.Item("CourseName") & ""
                End With
            Else
                ' Did not get a matching course record
            End If
        End Using
        sqlDR.Close()
        Return _Course
    End Function
End Class
