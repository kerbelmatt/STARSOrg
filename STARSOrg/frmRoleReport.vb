﻿Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmRoleReport

    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Role As CRole

    Private Sub frmRoleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.rpvReport.RefreshReport()
    End Sub

    Public Sub Display()
        Role = New CRole()
        rpvReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptRoles.rdlc"
        ds = New DataSet
        da = Role.GetReportData
        da.Fill(ds)
        rpvReport.LocalReport.DataSources.Add(New ReportDataSource("dsRoles", ds.Tables(0)))
        rpvReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class