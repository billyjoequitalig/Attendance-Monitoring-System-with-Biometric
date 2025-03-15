Imports Microsoft.Reporting.WinForms

Public Class frmWeeklyPrint

    Private Sub frmReportWeekly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WeeklyReport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.WeeklyReport.DataTable1)
        Dim parReportParam1 As New ReportParameter("WhosPrinted", frmMain.WhosPrint)
        Dim CellLead As New ReportParameter("celllead", frmWeeklyReport.cbSearchCell.Text)
        Dim NetLead As New ReportParameter("netlead", frmWeeklyReport.cbSearchNet.Text)
        Dim Total As New ReportParameter("total", "Total No. of Attendees: " & frmWeeklyReport.lblGrandTotal.Text)
        Dim TotalLate As New ReportParameter("totallate", "Late Attendees: " & frmWeeklyReport.lblTotalLate.Text)
        Dim TotalOnTime As New ReportParameter("totalontime", "On Time Attendees: " & frmWeeklyReport.lblTotalOntime.Text)
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {parReportParam1, NetLead, CellLead, Total, TotalLate, TotalOnTime})
        If frmWeeklyReport.cbSearchNet.SelectedIndex <= 0 And frmWeeklyReport.cbSearchCell.SelectedIndex <= 0 Then
            Me.DataTable1TableAdapter.FillByDate(Me.WeeklyReport.DataTable1, frmWeeklyReport.DateTimePicker1.Text)
            Me.ReportViewer1.RefreshReport()
        ElseIf frmWeeklyReport.cbSearchNet.SelectedIndex >= 0 And frmWeeklyReport.cbSearchCell.Text = "All" Then
            Me.DataTable1TableAdapter.FillByNetLead(Me.WeeklyReport.DataTable1, frmWeeklyReport.DateTimePicker1.Text, frmWeeklyReport.cbSearchNet.Text)
            Me.ReportViewer1.RefreshReport()
        ElseIf frmWeeklyReport.cbSearchCell.SelectedIndex >= 0 And frmWeeklyReport.cbSearchNet.Text = "All" Then
            Me.DataTable1TableAdapter.FillByCellLead(Me.WeeklyReport.DataTable1, frmWeeklyReport.DateTimePicker1.Text, frmWeeklyReport.cbSearchCell.Text)
            Me.ReportViewer1.RefreshReport()
        ElseIf frmWeeklyReport.cbSearchNet.SelectedIndex >= 0 And frmWeeklyReport.cbSearchCell.SelectedIndex >= 0 Then
            Me.DataTable1TableAdapter.FillByLeaders(Me.WeeklyReport.DataTable1, frmWeeklyReport.DateTimePicker1.Text, frmWeeklyReport.cbSearchNet.Text, frmWeeklyReport.cbSearchCell.Text)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class