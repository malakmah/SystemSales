Imports DevExpress.XtraEditors
Imports DevExpress.XtraCharts
Imports System.Data.SqlClient
Public Class frm_Monthly_Profits
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub frm_frm_Monthly_Profits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class