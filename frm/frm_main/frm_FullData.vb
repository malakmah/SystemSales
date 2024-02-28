Imports DevExpress.XtraEditors
Imports SystemSales.DB
Partial Public Class frm_FullData

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub tileBar_SelectedItemChanged(ByVal sender As Object, ByVal e As TileItemEventArgs) Handles tileBar.SelectedItemChanged
        navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item)
    End Sub

    Private Sub itim_count_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dvg_AllSales.Columns.Item("طباعه").Width = 100
        Me.dvg_AllSales.Columns.Item("الترقيم").Width = 100
        Me.dvg_AllSales.Columns.Item("الكود").Width = 150
        Me.dvg_AllSales.Columns.Item("التاريخ").Width = 100
        Me.dvg_AllSales.Columns.Item("العميل").Width = 150
        Me.dvg_AllSales.Columns.Item("الكاشير").Width = 150
        Me.dvg_AllSales.Columns.Item("المبلغ").Width = 150
        Me.dvg_AllSales.Columns.Item("الخصم").Width = 150
        Me.dvg_AllSales.Columns.Item("الاجمالى").Width = 160
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''''
        'Me.GridView2.Columns.Item("طباعه").Width = 100
        'Me.GridView2.Columns.Item("الترقيم").Width = 100
        'Me.GridView2.Columns.Item("الكود").Width = 150
        'Me.GridView2.Columns.Item("التاريخ").Width = 100
        'Me.GridView2.Columns.Item("العميل").Width = 150
        'Me.GridView2.Columns.Item("الكاشير").Width = 150
        'Me.GridView2.Columns.Item("المبلغ").Width = 150
        'Me.GridView2.Columns.Item("الخصم").Width = 150
        'Me.GridView2.Columns.Item("الاجمالى").Width = 160
        ' '''''''''''''''''''
        'Me.GridView3.Columns.Item("طباعه").Width = 100
        'Me.GridView3.Columns.Item("الترقيم").Width = 100
        'Me.GridView3.Columns.Item("الكود").Width = 150
        'Me.GridView3.Columns.Item("التاريخ").Width = 100
        'Me.GridView3.Columns.Item("العميل").Width = 150
        'Me.GridView3.Columns.Item("الكاشير").Width = 150
        'Me.GridView3.Columns.Item("المبلغ").Width = 150
        'Me.GridView3.Columns.Item("الخصم").Width = 150
        'Me.GridView3.Columns.Item("الاجمالى").Width = 160
        'DB.Open()
        'gvd_All_Purchase.DataSource = DB.GetData("SQL_GET_POS_Procurement")
        'dvg_Allpurchase.DataSource = DB.GetData("SQL_GET_Returns_Procurement")
        'GridControl6.DataSource = DB.GetData("SQL_GET_Returns_Sales")
        'grid_POS.DataSource = DB.GetData("SQL_GET_POS_MASTER")
        'GridControl4.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        TileBarItem2.Text = dvg_AllSales.DataRowCount
        Customer.Text = TileView1.DataRowCount
        Employee.Text = TileView2.DataRowCount
        Supplir.Text = TileView3.DataRowCount
        TileBarItem3.Text = LayoutView2.DataRowCount

        ' tile_Procurement.Text = GridView1.DataRowCount
        ' TileBarItem6.Text = GridView3.DataRowCount
        'TileBarItem5.Text = GridView2.DataRowCount

        DB.Close()
    End Sub
    Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
        Dim id As String = dvg_AllSales.GetRowCellValue(dvg_AllSales.FocusedRowHandle, "الكود").ToString
        Dim frm As New frm_rp_workorder
        frm.code = id
        frm.Show()
    End Sub

    Private Sub tileBar_Click(sender As Object, e As EventArgs) Handles tileBar.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        frm_EarningsReport.ShowDialog()
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
