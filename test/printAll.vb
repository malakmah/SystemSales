Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts
Imports System.Data.SqlClient

Partial Public Class frm_MonthlyProfits
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub tileBar_SelectedItemChanged(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles tileBar.SelectedItemChanged
        navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item)
    End Sub

    Private Sub printAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MonthlySalesProfit()
        MonthlyPurchaseProfits()
    End Sub
    Sub MonthlySalesProfit()
        'DB.Open()
        'da = New SqlDataAdapter("SELECT YEAR(POS_MASTER_Date)AS PosMaster_Year,MONTH(POS_MASTER_Date)AS Pos_Master_Month,SUM(POS_MASTER_Grand_Total)AS POS_Grand_Total FROM TBL_POS_MASTER Group by YEAR(POS_MASTER_Date),month (POS_MASTER_Date)order by YEAR(POS_MASTER_Date)", DB.conn)
        'da.Fill(dt)
        'Dim Pos_Ser As New DevExpress.XtraCharts.Series("الفواتير الفوريه", DevExpress.XtraCharts.ViewType.Bar)
        'Me.ChartControl2.Series.Add(Pos_Ser)
        'Pos_Ser.DataSource = dt
        'Pos_Ser.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        'Pos_Ser.ArgumentDataMember = "Pos_Master_Month"
        'Pos_Ser.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        'Pos_Ser.ValueDataMembers.AddRange(New String() {"POS_Grand_Total"})
        'Pos_Ser.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        'Me.ChartControl2.Series.AddRange(New Series() {Pos_Ser})
    End Sub
    Sub MonthlyPurchaseProfits()
        DB.Open()
        da = New SqlDataAdapter("SELECT YEAR(POS_Procurement_Date)AS PosProcurement_Year,MONTH(POS_Procurement_Date)AS Pos_Procurement_Month,SUM(POS_Procurement_Grand_Total)AS POS_Procurement_Grand_Total FROM TBL_POS_Procurement Group by YEAR(POS_Procurement_Date),month (POS_Procurement_Date)order by YEAR(POS_Procurement_Date)", DB.conn)
        da.Fill(dt)
        Dim Pos_Ser As New DevExpress.XtraCharts.Series("الفواتير الشهريه للمشتريات", DevExpress.XtraCharts.ViewType.Bar)
        Me.ChartControl1.Series.Add(Pos_Ser)
        Pos_Ser.DataSource = dt
        Pos_Ser.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
        Pos_Ser.ArgumentDataMember = "Pos_Procurement_Month"
        Pos_Ser.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Pos_Ser.ValueDataMembers.AddRange(New String() {"POS_Procurement_Grand_Total"})
        Pos_Ser.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Me.ChartControl1.Series.AddRange(New Series() {Pos_Ser})
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        MonthlySalesProfit()
        MonthlyPurchaseProfits()
    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub
End Class
