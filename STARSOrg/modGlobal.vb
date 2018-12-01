﻿Module modGlobal
    'contains all variables, constants, procedures, and functions that need to be accessed in more than one form
#Region "Screen Constants"
    Public Const ACTION_NONE = 0
    Public Const ACTION_HOME = 1
    Public Const ACTION_MEMBER = 2
    Public Const ACTION_ROLE = 3
    Public Const ACTION_EVENT = 4
    Public Const ACTION_RSVP = 5
    Public Const ACTION_COURSE = 6
    Public Const ACTION_SEMESTER = 7
    Public Const ACTION_HELP = 8
    Public Const ACTION_TUTOR = 9
    Public Const ACTION_LOGOUT = 10
#End Region

    Public intNextAction As Integer
    Public myDB As New CDB
    Public user_PID As String
    Public user_LName As String
    Public user_FName As String
    Public user_Role As String


End Module
