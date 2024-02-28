Public Class XtraForm3 

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
        frm_BillingSection.ShowDialog()
    End Sub

    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        Dim frm As New MonthlySalesProfit
        frm.ShowDialog()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        Dim frm As New frm_Monthly_Profits
        frm.ShowDialog()

    End Sub

    Private Sub XtraForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        Dim frm As New frm_Returns_Purchase
        frm.ShowDialog()

    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        Dim frm As New frm_Monthly_Returns_Sales
        frm.ShowDialog()

    End Sub
End Class