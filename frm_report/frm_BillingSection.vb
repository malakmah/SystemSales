Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class frm_BillingSection

    Public Sub New()
        InitializeComponent()
       
    End Sub
   
    Private Sub frm_BillingSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dridProcurement.Columns.Item("طباعه").Width = 100
        Me.dridProcurement.Columns.Item("الترقيم").Width = 100
        Me.dridProcurement.Columns.Item("الكود").Width = 100
        Me.dridProcurement.Columns.Item("التاريخ").Width = 100
        Me.dridProcurement.Columns.Item("العميل").Width = 150
        Me.dridProcurement.Columns.Item("الكاشير").Width = 150
        Me.dridProcurement.Columns.Item("المبلغ").Width = 100
        Me.dridProcurement.Columns.Item("الخصم").Width = 100
        Me.dridProcurement.Columns.Item("الاجمالى").Width = 100
        '''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.gvg_Sales.Columns.Item("طباعه").Width = 100
        Me.gvg_Sales.Columns.Item("الترقيم").Width = 100
        Me.gvg_Sales.Columns.Item("الكود").Width = 100
        Me.gvg_Sales.Columns.Item("التاريخ").Width = 150
        Me.gvg_Sales.Columns.Item("العميل").Width = 150
        Me.gvg_Sales.Columns.Item("الكاشير").Width = 100
        Me.gvg_Sales.Columns.Item("المبلغ").Width = 100
        Me.gvg_Sales.Columns.Item("الخصم").Width = 100
        Me.gvg_Sales.Columns.Item("الاجمالى").Width = 100
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.GridReturns_Sales.Columns.Item("طباعه").Width = 100
        Me.GridReturns_Sales.Columns.Item("الترقيم").Width = 100
        Me.GridReturns_Sales.Columns.Item("الكود").Width = 100
        Me.GridReturns_Sales.Columns.Item("التاريخ").Width = 150
        Me.GridReturns_Sales.Columns.Item("العميل").Width = 150
        Me.GridReturns_Sales.Columns.Item("الكاشير").Width = 100
        Me.GridReturns_Sales.Columns.Item("المبلغ").Width = 100
        Me.GridReturns_Sales.Columns.Item("الخصم").Width = 100
        Me.GridReturns_Sales.Columns.Item("الاجمالى").Width = 100
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.GridReturns_Procurement.Columns.Item("طباعه").Width = 100
        Me.GridReturns_Procurement.Columns.Item("الترقيم").Width = 100
        Me.GridReturns_Procurement.Columns.Item("الكود").Width = 100
        Me.GridReturns_Procurement.Columns.Item("التاريخ").Width = 150
        Me.GridReturns_Procurement.Columns.Item("العميل").Width = 150
        Me.GridReturns_Procurement.Columns.Item("الكاشير").Width = 100
        Me.GridReturns_Procurement.Columns.Item("المبلغ").Width = 100
        Me.GridReturns_Procurement.Columns.Item("الخصم").Width = 100
        Me.GridReturns_Procurement.Columns.Item("الاجمالى").Width = 100
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        DockPanel1.Close()
        DockPanel2.Close()
        DockPanel3.Close()
        DockPanel4.Close()
        DB.Close()
        DB.Open()
        dvg_Sales.DataSource = DB.GetData("SQL_GET_POS_MASTER")
        GridProcurement.DataSource = DB.GetData("SQL_GET_POS_Procurement")
        dridReturns_Sales.DataSource = DB.GetData("SQL_GET_Returns_Sales")
        dvgReturns_Procurement.DataSource = DB.GetData("SQL_GET_Returns_Procurement")
        BarStaticItem1.Caption = gvg_Sales.DataRowCount
        BarStaticItem2.Caption = dridProcurement.DataRowCount
        BarStaticItem3.Caption = GridReturns_Sales.DataRowCount
        BarStaticItem4.Caption = GridReturns_Procurement.DataRowCount

        DB.Close()
    End Sub

    Private Sub employeesAccordionControlElement_Click(sender As Object, e As EventArgs) Handles employeesAccordionControlElement.Click
        DockPanel3.Close()
        DockPanel2.Close()
        DockPanel4.Close()

        DockPanel1.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit1.Click
        Dim id As String = gvg_Sales.GetRowCellValue(gvg_Sales.FocusedRowHandle, "الكود").ToString
        Dim frm As New frm_rp_workorder
        frm.code = id
        frm.Show()
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub

    Private Sub customersAccordionControlElement_Click(sender As Object, e As EventArgs) Handles customersAccordionControlElement.Click
        DockPanel3.Close()
        DockPanel1.Close()
        DockPanel4.Close()

        DockPanel2.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit7_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit7.Click
        Dim id As String = dridProcurement.GetRowCellValue(dridProcurement.FocusedRowHandle, "الكود").ToString
        Dim frm As New frm_report_Procurement
        frm.code = id
        frm.Show()
    End Sub

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click
        DockPanel1.Close()
        DockPanel2.Close()
        DockPanel4.Close()
        DockPanel3.Show()
    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click
        DockPanel1.Close()
        DockPanel2.Close()
        DockPanel3.Close()
        DockPanel4.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit10_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit10.Click
        Dim id As String = GridReturns_Sales.GetRowCellValue(GridReturns_Sales.FocusedRowHandle, "الكود").ToString
        Dim frm As New frmRptRuternSales
        frm.code = id
        frm.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit13_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit13.Click
        Dim id As String = GridReturns_Procurement.GetRowCellValue(GridReturns_Procurement.FocusedRowHandle, "الكود").ToString
        Dim frm As New rptRPT_Purchase_Returns
        frm.Code = id
        frm.Show()
    End Sub
End Class
