Public Class rptRPT_Purchase_Returns 
    Public Code As String
    Private Sub rptRPT_Purchase_Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsRuternrptProcurement.SQL_GET_RPT_Purchase_Returns' table. You can move, or remove it, as needed.
        Me.SQL_GET_RPT_Purchase_ReturnsTableAdapter.Fill(Me.dsRuternrptProcurement.SQL_GET_RPT_Purchase_Returns, Code)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class