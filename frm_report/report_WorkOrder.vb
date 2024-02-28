Imports SystemSales.DB
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Public Class report_WorkOrder
    Dim DT As New DataTable

    Private Sub report_WorkOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub
    Private Sub XtraForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Stardust"
        RETRIEVE_DATA_FROM_TABELS_POS_MASTER()
        Me.GridView3.Columns.Item("عرض").Width = 100
        Me.GridView3.Columns.Item("مرتجع").Width = 100
        'Me.GridView3.Columns.Item("POS_Procurement_Id").Width = 100
        'Me.GridView3.Columns.Item("POS_Procurement_Date").Width = 100
        '' Me.grdReturned.Columns.Item("POS_Procurement_Heure").Width = 150
        'Me.GridView3.Columns.Item("POS_Procurement_Heure").Width = 100
        'Me.GridView3.Columns.Item("POS_Procurement_Customers").Width = 100
        'Me.GridView3.Columns.Item("POS_Procurement_Username").Width = 100
        'Me.GridView3.Columns.Item("POS_Procurement_Sous_Total").Width = 90
        'Me.GridView3.Columns.Item("POS_Procurement_Remises").Width = 80
        'Me.GridView3.Columns.Item("POS_Procurement_Grand_Total").Width = 80

        ' Me.GridView3.OptionsView.ShowFooter = True
    End Sub
    Public Sub RETRIEVE_DATA_FROM_TABELS_POS_MASTER()
        grid_POS.DataSource = Nothing
        '  DT.Clear()
        Dim DA As New SqlClient.SqlDataAdapter("SELECT POS_MASTER_Id, POS_MASTER_Code ,POS_MASTER_Username ,POS_MASTER_Date ,POS_MASTER_Heure,POS_MASTER_Customers,POS_MASTER_Sous_Total,POS_MASTER_Remises,POS_MASTER_Grand_Total from TBL_POS_MASTER WHERE  CAST(POS_MASTER_Date AS DATE) = CAST(GETDATE() AS DATE)And POS_MASTER_Situation ='0';", DB.conn)
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
        Me.GridView3.Columns("POS_MASTER_Date").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridView3.Columns("POS_MASTER_Heure").DisplayFormat.FormatString = "yyyy-MM-dd"

    End Sub

    Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
        If GridView3.RowCount = Nothing Then Return
        Dim SELECT_ROW() As Integer = GridView3.GetSelectedRows()
        For Each rowHandle As Integer In SELECT_ROW
            If rowHandle >= 0 Then
                Me.GridControl1.DataSource = Nothing
                Call CLER_POS_MASTER_TEXTBOX()

                Me.TxtFacturePosId.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Id").ToString
                Me.TxtFacturePosCode.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString
                Me.TxtFacturePosDate.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Date").ToString
                Me.TxtFacturePosHeure.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Heure").ToString
                Me.TxtFacturePosCustomers.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Customers").ToString
                Me.TxtFacturePosUsername.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Username").ToString
                Me.TXTFaccturePosTotal.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Sous_Total").ToString
                Me.txtFacturePosRemises.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Remises").ToString
                Me.TXT_Toitl.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Grand_Total").ToString

                Call POPULATE_GLOBALE_DATATABLE(GridControl1, "SELECT * FROM TBL_POS_DETAILS WHERE POS_DETAILS_Code ='" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString & "'")
            End If
        Next rowHandle




    End Sub
    Dim infoter As System.Data.DataTable = New DataTable
    Sub POUPL_LOOKUP(ByVal Grid_Lookup As RepositoryItemGridLookUpEdit)
        Dim FRM As New frm_ReturnedSales
        infoter.Clear()
        Grid_Lookup.DataSource = Nothing
        Dim dr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("SELECT POS_DETAILS_Items_Barcode,POS_DETAILS_Items_Name,POS_DETAILS_Items_Prix_Vente,POS_DETAILS_Items_Quantite FROM TBL_POS_DETAILS WHERE POS_DETAILS_Code ='" & GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString & "'", DB.conn)
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
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Me.GridView1.Appearance.FocusedRow.BackColor = Color.Red
        Me.GridView1.Appearance.FocusedRow.ForeColor = Color.LightYellow
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
        Dim FRM As New frm_ReturnedSales
        If GridView3.RowCount = Nothing Then Return
        Dim SELECT_ROW() As Integer = GridView3.GetSelectedRows()
        For Each rowHandle As Integer In SELECT_ROW
            If rowHandle >= 0 Then
                Me.GridControl1.DataSource = Nothing
                Call CLER_POS_MASTER_TEXTBOX()

                FRM.TxtFacturePosId.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Id").ToString
                FRM.TxtFacturePosCode.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString
                FRM.TxtFacturePosDate.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Date").ToString
                FRM.TxtFacturePosHeure.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Heure").ToString
                'FRM.TxtFacturePosCustomers.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Customers").ToString
                FRM.TxtFacturePosUsername.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Username").ToString
                FRM.TXTFaccturePosTotal.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Sous_Total").ToString
                FRM.txtFacturePosRemises.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Remises").ToString
                FRM.TXT_Toitl.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Grand_Total").ToString
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

End Class

