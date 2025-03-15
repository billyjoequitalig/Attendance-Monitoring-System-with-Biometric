Public Class frmReportWeekly

    Private Sub frmReportWeekly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WeeklyReport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.WeeklyReport.DataTable1)
        'TODO: This line of code loads data into the 'WeeklyReport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.WeeklyReport.DataTable1)
        'TODO: This line of code loads data into the 'WeeklyReport.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.WeeklyReport.DataTable1)
        'TODO: This line of code loads data into the 'WeeklyReport.DataTable1' table. You can move, or remove it, as needed.
        'Me.DataTable1TableAdapter.Fill(Me.WeeklyReport.DataTable1)
        Me.DataTable1TableAdapter.FillByDate(Me.WeeklyReport.DataTable1, frmReport.DateTimePicker1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class