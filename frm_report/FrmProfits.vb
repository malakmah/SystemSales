Imports System.Data.SqlClient
Imports DevExpress.XtraCharts
Public Class FrmProfits
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim dt2 As New DataTable



    Sub getchat()
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
        Dim View_Pos As DevExpress.XtraCharts.SideBySideBarSeriesView = TryCast(Pos_Ser.View, DevExpress.XtraCharts.SideBySideBarSeriesView)
        View_Pos.BarDistance = 0.1
        View_Pos.BarDistanceFixed = 2
        View_Pos.BarWidth = 0.4
        View_Pos.EqualBarWidth = True
        View_Pos.Color = Color.Blue
        Dim ChartTitel As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
        ChartTitel.Text = "التدرج البيانى السنوى لقيمه فواتير المبيعات الفوريه حسب الشهور"
    End Sub
    Sub getchat2()
        DB.Open()
        da = New SqlDataAdapter("SELECT YEAR(POS_Procurement_Date)AS PosMaster_Year,MONTH(POS_Procurement_Date)AS Pos_Master_Month,SUM(POS_Procurement_Grand_Total)AS POS_Grand_Total FROM TBL_POS_Procurement Group by YEAR(POS_Procurement_Date),month (POS_Procurement_Date)order by YEAR(POS_Procurement_Date)", DB.conn)
        da.Fill(dt2)
        Dim Pos_Procurement As New DevExpress.XtraCharts.Series("الفواتير الفوريه للمشتريات", DevExpress.XtraCharts.ViewType.Bar)
        Me.ChartControl2.Series.Add(Pos_Procurement)
        Pos_Procurement.DataSource = dt2
        Pos_Procurement.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        Pos_Procurement.ArgumentDataMember = "Pos_Master_Month"
        Pos_Procurement.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Pos_Procurement.ValueDataMembers.AddRange(New String() {"POS_Grand_Total"})
        Pos_Procurement.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Me.ChartControl2.Series.AddRange(New Series() {Pos_Procurement})
        Dim View_Pos As DevExpress.XtraCharts.SideBySideBarSeriesView = TryCast(Pos_Procurement.View, DevExpress.XtraCharts.SideBySideBarSeriesView)
        View_Pos.BarDistance = 0.1
        View_Pos.BarDistanceFixed = 2
        View_Pos.BarWidth = 0.4
        View_Pos.EqualBarWidth = True
        View_Pos.Color = Color.Blue
        Dim ChartTitel As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
        ChartTitel.Text = "التدرج البيانى السنوى لقيمه فواتير المبيعات الفوريه حسب الشهور"
    End Sub



    Private Sub FrmProfits_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        getchat()
        getchat2()
    End Sub
End Class