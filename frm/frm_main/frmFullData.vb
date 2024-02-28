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

        DB.Close()
        DB.Open()
        GridControl3.DataSource = DB.GetData("SQL_GET_Supplir")
        GridControl1.DataSource = DB.GetData("SQL_GET_Customer")
        GridControl4.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        GridControl2.DataSource = DB.GetData("SQL_GET_Employee")
        grid_POS.DataSource = DB.GetData("SQL_GET_POS_MASTER")

        DB.Close()





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
        frm_MonthlyProfit.ShowDialog()
    End Sub

    Private Sub RepositoryItemButtonEdit1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
