Public Class frmRptRuternSales 
    Public Code As String
    Private Sub frmRptRuternSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsRuternSales.SQL_GET_RPT_Returns_Sales' table. You can move, or remove it, as needed.
        Me.SQL_GET_RPT_Returns_SalesTableAdapter.Fill(Me.dsRuternSales.SQL_GET_RPT_Returns_Sales, Code)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class