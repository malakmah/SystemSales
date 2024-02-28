Imports System.Data.SqlClient
Imports SystemSales.DB
Public Class frm_rp_workorder
    Public code As String = ""
    Private Sub USER_LOGEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DataTable1TableAdapter.Fill(Me.dsWorkOrder.DataTable1, code)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class