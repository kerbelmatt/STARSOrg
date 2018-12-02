Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmTutorReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Tutor As CTutor

    Private Sub frmTutorReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rpvReport.RefreshReport()
    End Sub

    Public Sub Display()
        Tutor = New CTutor
        rpvReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptTutors.rdlc"
        ds = New DataSet
        da = Tutor.GetReportData()
        da.Fill(ds)
        rpvReport.LocalReport.DataSources.Add(New ReportDataSource("dsTutors", ds.Tables(0)))
        rpvReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub
End Class