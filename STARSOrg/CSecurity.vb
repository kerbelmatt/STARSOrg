Imports System.Data.SqlClient

Public Class CSecurity
    ' Represents a single record in the SECURITY table
    Private _mstrPID As String
    Private _mstrUserID As String
    Private _mstrPassword As String
    Private _mstrSecRole As String
    Private _isNewSecurity As Boolean

    ' Constructor
    Public Sub New()
        _mstrPID = ""
        _mstrUserID = ""
        _mstrPassword = ""
        _mstrSecRole = ""
    End Sub

#Region "Exposed Properties"
    Public Property PID As String ' Match the column name in the database
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property

    Public Property UserID As String
        Get
            Return _mstrUserID
        End Get
        Set(strVal As String)
            _mstrUserID = strVal
        End Set
    End Property

    Public Property Password As String
        Get
            Return _mstrPassword
        End Get
        Set(strVal As String)
            _mstrPassword = strVal
        End Set
    End Property

    Public Property SecRole As String
        Get
            Return _mstrSecRole
        End Get
        Set(strVal As String)
            _mstrSecRole = strVal
        End Set
    End Property

    Public Property IsNewSecurity As Boolean
        Get
            Return _isNewSecurity
        End Get
        Set(blnVal As Boolean)
            _isNewSecurity = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("UserID", _mstrUserID))
            params.Add(New SqlParameter("Password", _mstrPassword))
            params.Add(New SqlParameter("SecRole", _mstrSecRole))
            Return params
        End Get
    End Property
#End Region

    Public Function Save() As Integer
        ' Return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If IsNewSecurity Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckSecurityIDExists", params)
            If Not strResult = 0 Then
                Return -1 ' Not Unique!!
            End If
        End If
        Return myDB.ExecSP("sp_SaveSecurity", GetSaveParameters())
    End Function

End Class

