Public Class Frm_PriceList

    Private Sub Frm_PriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GET_SQL_GET_ITEMS()
        Me.Grid_grid_Pirse.Columns.Item("الكود").Width = 100
        Me.Grid_grid_Pirse.Columns.Item("الاسم").Width = 150
        Me.Grid_grid_Pirse.Columns.Item("الكميه").Width = 150

        Me.Grid_grid_Pirse.Columns.Item("الصوره").Width = 100
        Me.Grid_grid_Pirse.Columns.Item("سعر البيع").Width = 130
        Me.Grid_grid_Pirse.Columns.Item("سعر الشراء").Width = 130

    End Sub
    Public Sub GET_SQL_GET_ITEMS()
        DB.Close()
        DB.Open()
        grid_Pirse.DataSource = DB.GetData("SQL_GET_TB_ITEMS")

        DB.Close()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Grid_grid_Pirse.ShowPrintPreview()
    End Sub

    Private Sub grid_Pirse_Click(sender As Object, e As EventArgs) Handles grid_Pirse.Click
        Grid_grid_Pirse.ShowPrintPreview()

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Grid_grid_Pirse.ShowRibbonPrintPreview()
    End Sub
End Class