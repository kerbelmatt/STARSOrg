Imports System.Data.SqlClient
Public Class CTutor
    ' Represents a record in the TUTOR_COURSE table
    Private _mstrukid As String
    Private _mstrPID As String
    Private _mstrCourseID As String
    Private _mstrSemesterID As String
    Private _isNewTutor As Boolean

    ' Constructor
    Public Sub New()
        _mstrukid = ""
        _mstrPID = ""
        _mstrCourseID = ""
        _mstrSemesterID = ""
    End Sub

#Region "Exposed Properties"
    Public Property ukid As String
        Get
            Return _mstrukid
        End Get
        Set(strVal As String)
            _mstrukid = strVal
        End Set
    End Property

    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property

    Public Property CourseID As String
        Get
            Return _mstrCourseID
        End Get
        Set(strVal As String)
            _mstrCourseID = strVal
        End Set
    End Property

    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property

    Public Property IsNewTutor As Boolean
        Get
            Return _isNewTutor
        End Get
        Set(blnVal As Boolean)
            _isNewTutor = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        ' This property's code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            Return params
        End Get
    End Property
#End Region

    Public Function Save() As Integer
        ' Return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewTutor Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("ukid", _mstrukid))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckTutorIDExists", params)
            If Not strResult = 0 Then
                Return -1 ' Not UNIQUE
            End If
        End If
        ' If not a new tutor, or it is new and has a unique ID, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveTutor", GetSaveParameters())
    End Function
End Class
