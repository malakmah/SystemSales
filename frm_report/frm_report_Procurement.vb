
Public Class frm_report_Procurement
    Public code As String = ""
    Private Sub frm_report_Procurement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsProcurement.SQL_GET_RPT_Procurement' table. You can move, or remove it, as needed.
        Me.SQL_GET_RPT_ProcurementTableAdapter.Fill(Me.dsProcurement.SQL_GET_RPT_Procurement, code)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class