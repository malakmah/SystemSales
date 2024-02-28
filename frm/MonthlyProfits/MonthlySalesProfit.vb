Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts
Imports System.Data.SqlClient
Public Class MonthlySalesProfit
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub MonthlySalesProfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DB.Open()
        da = New SqlDataAdapter("SELECT YEAR(POS_MASTER_Date)AS PosMaster_Year,MONTH(POS_MASTER_Date)AS Pos_Master_Month,SUM(POS_MASTER_Grand_Total)AS POS_Grand_Total FROM TBL_POS_MASTER Group by YEAR(POS_MASTER_Date),month (POS_MASTER_Date)order by YEAR(POS_MASTER_Date)", DB.conn)
        da.Fill(dt)
        Dim Pos_Ser As New DevExpress.XtraCharts.Series("الفواتير الفوريه", DevExpress.XtraCharts.ViewType.Bar)
        Me.ChartControl1.Series.Add(Pos_Ser)
        Pos_Ser.DataSource = dt
        Pos_Ser.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        Pos_Ser.ArgumentDataMember = "Pos_Master_Month"
        Pos_Ser.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Pos_Ser.ValueDataMembers.AddRange(New String() {"POS_Grand_Total"})
        Pos_Ser.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Me.ChartControl1.Series.AddRange(New Series() {Pos_Ser})
    End Sub

End Class