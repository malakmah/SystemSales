Imports SystemSales.DB
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Public Class Frm_Purchases_All
    Dim DT As New DataTable
    Private Sub Frm_Purchases_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RETRIEVE_DATA_FROM_TABELS_Procurement()

        Me.grdReturned.Columns.Item("عرض").Width = 100
        Me.grdReturned.Columns.Item("مرتجع").Width = 100
        Me.grdReturned.Columns.Item("POS_Procurement_Id").Width = 100
        Me.grdReturned.Columns.Item("POS_Procurement_Date").Width = 100
        ' Me.grdReturned.Columns.Item("POS_Procurement_Heure").Width = 150
        Me.grdReturned.Columns.Item("POS_Procurement_Heure").Width = 100
        Me.grdReturned.Columns.Item("POS_Procurement_Customers").Width = 100
        Me.grdReturned.Columns.Item("POS_Procurement_Username").Width = 100
        Me.grdReturned.Columns.Item("POS_Procurement_Sous_Total").Width = 90
        Me.grdReturned.Columns.Item("POS_Procurement_Remises").Width = 80
        Me.grdReturned.Columns.Item("POS_Procurement_Grand_Total").Width = 80

        Me.grdReturned.OptionsView.ShowFooter = True

        Me.GridTED.Columns.Item("POS_DETAILS_Items_Barcode").Width = 100
        Me.GridTED.Columns.Item("POS_DETAILS_Items_Name").Width = 100
        Me.GridTED.Columns.Item("POS_DETAILS_Items_Prix_Vente").Width = 100
        Me.GridTED.Columns.Item("POS_DETAILS_Items_Quantite").Width = 90
        Me.GridTED.Columns.Item("POS_DETAILS_Items_Sous_Total").Width = 80
    End Sub


    Public Sub RETRIEVE_DATA_FROM_TABELS_Procurement()
        grid_POS.DataSource = Nothing
        '  DT.Clear()
        Dim DA As New SqlClient.SqlDataAdapter("SELECT POS_Procurement_Id, POS_Procurement_Code ,POS_Procurement_Username ,POS_Procurement_Date ,POS_Procurement_Heure,POS_Procurement_Customers,POS_Procurement_Sous_Total,POS_Procurement_Remises,POS_Procurement_Grand_Total from TBL_POS_Procurement WHERE CAST(POS_Procurement_Date AS DATE) = CAST(GETDATE() AS DATE)And  POS_Procurement_Situation ='0';", DB.conn)
        Try
            DB.Open()

            DA.Fill(DT)
            DB.Close()
            DA = Nothing

        Catch ex As Exception
            MsgBox("eroer")
        End Try
        If DT.Rows.Count <> 0 Then
            With grid_POS
                .DataSource = DT
                Me.BindingContext(DT).Position = Me.BindingContext(DT).Count = 0
            End With
        End If
        Me.grdReturned.Columns("POS_Procurement_Date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.grdReturned.Columns("POS_Procurement_Heure").DisplayFormat.FormatString = "yyyy-MM-dd"

    End Sub

    Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
        If grdReturned.RowCount = Nothing Then Return
        Dim SELECT_ROW() As Integer = grdReturned.GetSelectedRows()
        For Each rowHandle As Integer In SELECT_ROW
            If rowHandle >= 0 Then
                Me.GridDET.DataSource = Nothing
                Call CLER_POS_MASTER_TEXTBOX()

                Me.TxtFacturePosId.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Id").ToString
                Me.TxtFacturePosCode.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Code").ToString
                Me.TxtFacturePosDate.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Date").ToString
                Me.TxtFacturePosHeure.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Heure").ToString
                Me.TxtFacturePosCustomers.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Customers").ToString
                Me.TxtFacturePosUsername.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Username").ToString
                Me.TXTFaccturePosTotal.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Sous_Total").ToString
                Me.txtFacturePosRemises.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Remises").ToString
                Me.TXT_Toitl.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Grand_Total").ToString

                Call POPULATE_GLOBALE_DATATABLE(GridDET, "SELECT * FROM TBL_Procurement_DETAILS WHERE POS_DETAILS_Code ='" & grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Code").ToString & "'")
            End If
        Next rowHandle




    End Sub
    Sub CLER_POS_MASTER_TEXTBOX()
        Me.TxtFacturePosId.Text = vbNullString
        Me.TxtFacturePosCode.Text = vbNullString
        Me.TxtFacturePosDate.Text = vbNullString
        Me.TxtFacturePosHeure.Text = vbNullString
        Me.TxtFacturePosCustomers.Text = vbNullString
        Me.TxtFacturePosUsername.Text = vbNullString
        Me.TXTFaccturePosTotal.Text = vbNullString
        Me.txtFacturePosRemises.Text = vbNullString
        Me.TXT_Toitl.Text = vbNullString

    End Sub
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridTED.FocusedRowChanged
        Me.GridTED.Appearance.FocusedRow.BackColor = Color.Red
        Me.GridTED.Appearance.FocusedRow.ForeColor = Color.LightYellow
    End Sub
    Public Function POPULATE_GLOBALE_DATATABLE(ByVal Grd As DevExpress.XtraGrid.GridControl, Sql As String)
        If DB.conn.State = ConnectionState.Closed Then DB.conn.Open()
        Dim InfoTable As DataTable = New System.Data.DataTable
        Dim InfoAdapter As New System.Data.SqlClient.SqlDataAdapter
        InfoAdapter.SelectCommand = New System.Data.SqlClient.SqlCommand(Sql, DB.conn)
        InfoAdapter.Fill(InfoTable)
        Grd.DataSource = InfoTable.DefaultView
        If DB.conn.State = ConnectionState.Open Then DB.conn.Close()
        Return InfoTable
    End Function

    Private Sub RepositoryItemButtonEdit5_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit5.Click
        Dim FRM As New frm_ReturnedPurchase
        If grdReturned.RowCount = Nothing Then Return
        Dim SELECT_ROW() As Integer = grdReturned.GetSelectedRows()
        For Each rowHandle As Integer In SELECT_ROW
            If rowHandle >= 0 Then
                Me.GridDET.DataSource = Nothing
                Call CLER_POS_MASTER_TEXTBOX()


                FRM.TxtFacturePosId.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Id").ToString
                FRM.TxtFacturePosCode.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Code").ToString
                FRM.TxtFacturePosDate.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Date").ToString
                FRM.TxtFacturePosHeure.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Heure").ToString
                FRM.TxtFacturePosSupplir.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Customers").ToString
                FRM.TxtFacturePosUsername.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Username").ToString
                FRM.TXTFaccturePosTotal.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Sous_Total").ToString
                FRM.txtFacturePosRemises.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Remises").ToString
                FRM.TXT_Toitl.Text = grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Grand_Total").ToString
                Call POUPL_LOOKUP(FRM.RepositoryItemGridLookUpEdit1)
                FRM.Show()

                ' Call POPULATE_GLOBALE_DATATABLE(FRM.RepositoryItemGridLookUpEdit1, "SELECT * FROM TBL_POS_DETAILS WHERE POS_DETAILS_Code ='" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString & "'")
            End If
        Next rowHandle


    End Sub
    Public Function POPULATE_GLOBALE_DATATABLE(Sql As String) As DataTable
        If DB.conn.State = ConnectionState.Closed Then DB.conn.Open()
        Dim InfoTable As DataTable = New System.Data.DataTable
        Dim InfoAdapter As New System.Data.SqlClient.SqlDataAdapter
        InfoAdapter.SelectCommand = New System.Data.SqlClient.SqlCommand(Sql, DB.conn)
        InfoAdapter.Fill(InfoTable)
        If DB.conn.State = ConnectionState.Open Then DB.conn.Close()
        Return InfoTable
    End Function
    Dim infoter As System.Data.DataTable = New DataTable
    Sub POUPL_LOOKUP(ByVal Grid_Lookup As RepositoryItemGridLookUpEdit)
        Dim FRM As New frm_ReturnedPurchase
        infoter.Clear()
        Grid_Lookup.DataSource = Nothing
        Dim dr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("SELECT POS_DETAILS_Items_Barcode,POS_DETAILS_Items_Name,POS_DETAILS_Items_Prix_Vente,POS_DETAILS_Items_Quantite FROM TBL_Procurement_DETAILS WHERE POS_DETAILS_Code ='" & grdReturned.GetRowCellValue(grdReturned.FocusedRowHandle, "POS_Procurement_Code").ToString & "'", DB.conn)
        dr.Fill(infoter)
        If infoter.Rows.Count > 0 Then
            Grid_Lookup.DataSource = infoter
            Grid_Lookup.DisplayMember = "POS_DETAILS_Items_Name"
            Grid_Lookup.ValueMember = "POS_DETAILS_Items_Name"
            Grid_Lookup.View.Appearance.FocusedRow.BackColor = Color.Magenta
            Grid_Lookup.PopupFormSize = New Size(500, 400)
            Grid_Lookup.View.ColumnPanelRowHeight = 25
            Grid_Lookup.View.Columns.Clear()

            Grid_Lookup.View.Columns.AddVisible("POS_DETAILS_Items_Barcode", "باركود المنتج")
            Grid_Lookup.View.Columns.AddVisible("POS_DETAILS_Items_Name", "اسم المنتج")
            Grid_Lookup.View.Columns.AddVisible("POS_DETAILS_Items_Prix_Vente", "سعرالبيع")
            Grid_Lookup.View.Columns.AddVisible("POS_DETAILS_Items_Quantite", "الكميه المخزنه")

            Grid_Lookup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Grid_Lookup.ImmediatePopup = True
            Grid_Lookup.View.OptionsView.ShowColumnHeaders = True
            Grid_Lookup.View.OptionsView.ShowPreview = False
            Grid_Lookup.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Grid_Lookup.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
            Grid_Lookup.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
            Grid_Lookup.SearchMode = Repository.GridLookUpSearchMode.AutoComplete

        Else
            Grid_Lookup.DataSource = Nothing
        End If
    End Sub
End Class
