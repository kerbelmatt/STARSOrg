Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class CAudit
    'Represents a single record in the Audit table
    Private _mstrPID As String
    Private _mstrACCESSTIMESTAMP As String
    Private _mblnSUCCESS As SqlBoolean
    'Constructor

    Public Sub New()
        _mstrPID = ""
        _mstrACCESSTIMESTAMP = ""
        _mblnSUCCESS = False
    End Sub
#Region "Exposed Properties"
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property
    Public Property ACCESSTIMESTAMP As String
        Get
            Return _mstrACCESSTIMESTAMP
        End Get
        Set(strVal As String)
            _mstrACCESSTIMESTAMP = strVal
        End Set
    End Property

    Public Property SUCCESS As SqlBoolean
        Get
            Return _mblnSUCCESS
        End Get
        Set(blnVal As SqlBoolean)
            _mblnSUCCESS = blnVal
        End Set
    End Property

    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this property's code will create the parameters for the stored procedure to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("ACCESSTIMESTAMP", _mstrACCESSTIMESTAMP))
            params.Add(New SqlParameter("SUCCESS", _mblnSUCCESS))
            Return params
        End Get
    End Property
#End Region

    Public Function Save() As Integer
        Return myDB.ExecSP("dbo.sp_saveAudit", GetSaveParameters())
    End Function

    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_getAllAudits", Nothing)
    End Function

End Class
