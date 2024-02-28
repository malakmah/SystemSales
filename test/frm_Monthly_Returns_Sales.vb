Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts
Imports System.Data.SqlClient
Public Class frm_Monthly_Returns_Sales
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub frm_Monthly_Returns_Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Open()
        da = New SqlDataAdapter("SELECT YEAR(Returns_Sales_Date)AS PosProcurement_Year,MONTH(Returns_Sales_Date)AS Pos_Procurement_Month,SUM(Returns_Sales_Grand_Total)AS POS_Procurement_Grand_Total FROM TBL_Sales_Returns Group by YEAR(Returns_Sales_Date),month (Returns_Sales_Date)order by YEAR(Returns_Sales_Date)", DB.conn)
        da.Fill(dt)
        Dim Pos_Ser As New DevExpress.XtraCharts.Series("الفواتير الشهريه لمرتجع المبيعات", DevExpress.XtraCharts.ViewType.Bar)
        Me.ChartControl1.Series.Add(Pos_Ser)
        Pos_Ser.DataSource = dt
        Pos_Ser.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        Pos_Ser.ArgumentDataMember = "Pos_Procurement_Month"
        Pos_Ser.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Pos_Ser.ValueDataMembers.AddRange(New String() {"POS_Procurement_Grand_Total"})
        Pos_Ser.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Me.ChartControl1.Series.AddRange(New Series() {Pos_Ser})
        DB.Close()
    End Sub
End Class