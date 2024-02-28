Imports SystemSales.DB
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient
Public Class frm_Sales_Returns
    Dim DT As New DataTable
    Dim cmd As New SqlCommand

    Private Sub RepositoryItemButtonEdit4_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit4.Click
        Dim frm As New Frm_Sales
        If GridView3.RowCount = Nothing Then Return
        Dim SELECT_ROW() As Integer = GridView3.GetSelectedRows()
        For Each rowHandle As Integer In SELECT_ROW
            If rowHandle >= 0 Then
                frm.GridControl1.DataSource = Nothing
                Call CLER_POS_MASTER_TEXTBOX()

                frm.TxtFacturePosId.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Id").ToString
                frm.TxtFacturePosCode.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString
                frm.TxtFacturePosDate.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Date").ToString
                frm.TxtFacturePosHeure.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Heure").ToString
                frm.TxtFacturePosCustomers.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Customers").ToString
                frm.TxtFacturePosUsername.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Username").ToString
                frm.TXTFaccturePosTotal.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Sous_Total").ToString
                frm.txtFacturePosRemises.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Remises").ToString
                frm.TXT_Toitl.Text = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Grand_Total").ToString


                '    Dim passcode As String
                '    passcode = GridView3.GetRowCellValue(GridView3.FocusedRowHandle, "POS_MASTER_Code").ToString


                '    ' Dim sql_Detel = "select POS_DETAILS_Items_Barcode, POS_DETAILS_Items_Name,POS_DETAILS_Items_Prix_Vente,POS_DETAILS_Items_Quantite,POS_DETAILS_Items_Sous_Total from TBL_POS_DETAILS where POS_DETAILS_Code=N'" & (passcode.ToString) & "'"
                '    With cmd
                '        DB.Open()
                '        cmd = New SqlCommand("sql_mk")
                '        cmd.CommandType = CommandType.StoredProcedure
                '        cmd.Parameters.AddWithValue("@id", passcode)
                '        Dim Reader As SqlDataReader = cmd.ExecuteReader
                '        Dim New_Handle As Integer = DevExpress.XtraGrid.GridControl.NewItemRowHandle
                '        While Reader.Read
                '            frm.GridView1.AddNewRow()
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Counter"), String.Format(frm.GridView1.RowCount).ToString())
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Barcode"), Convert.ToString(Reader.Item("POS_DETAILS_Items_Barcode").ToString))
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Name"), Convert.ToString(Reader.Item("POS_DETAILS_Items_Name").ToString))
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Prix_Vente"), Format(Convert.ToDecimal(Reader.Item("POS_DETAILS_Items_Prix_Vente").ToString), "#,##0.00"))
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Quntite"), Convert.ToInt32(Reader.Item("POS_DETAILS_Items_Quantite").ToString))
                '            frm.GridView1.SetRowCellValue(New_Handle, frm.GridView1.Columns("GridView_Items_Sous_Toal"), Format(Convert.ToDecimal(Reader.Item("POS_DETAILS_Items_Sous_Total").ToString), "#,##0.00"))
                '            frm.GridView1.UpdateCurrentRow()
                frm.Show()
                '        End While
                '        Reader.Close()

                '    End With
                '    cmd.Dispose()
            End If
        Next rowHandle

    End Sub
    Public Sub RETRIEVE_DATA_FROM_TABELS_POS_MASTER()
        grid_POS.DataSource = Nothing
        '  DT.Clear()
        Dim DA As New SqlClient.SqlDataAdapter("SELECT POS_MASTER_Id, POS_MASTER_Code ,POS_MASTER_Username ,POS_MASTER_Date ,POS_MASTER_Heure,POS_MASTER_Customers,POS_MASTER_Sous_Total,POS_MASTER_Remises,POS_MASTER_Grand_Total from TBL_POS_MASTER", DB.conn)
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

    Private Sub frm_Sales_Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RETRIEVE_DATA_FROM_TABELS_POS_MASTER()
    End Sub
    Sub CLER_POS_MASTER_TEXTBOX()
        'frm.TxtFacturePosId.Text = vbNullString
        'frm.TxtFacturePosCode.Text = vbNullString
        'frm.TxtFacturePosDate.Text = vbNullString
        'frm.TxtFacturePosHeure.Text = vbNullString
        'frm.TxtFacturePosCustomers.Text = vbNullString
        'frm.TxtFacturePosUsername.Text = vbNullString
        'frm.TXTFaccturePosTotal.Text = vbNullString
        'frm.txtFacturePosRemises.Text = vbNullString
        'frm.TXT_Toitl.Text = vbNullString

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
End Class