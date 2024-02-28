Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing.Drawing2D
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.WXPaint
Imports DevExpress.Utils
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraEditors.ColorPick.Picker

Public Class frm_Purchase

    Private Sub XtraForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CREATE_COLUNMS_DATATABEL(8)
        Call POUPL_LOOKUP(Me.RepositoryItemGridLookUpEdit1)
        TXT_Enabled()
        TotalAmount()
        logSupplir()

    End Sub
    Dim SQLRED As SqlDataReader
    Sub TotalAmount()
        DB.Close()
        DB.Open()
        CMD = New SqlCommand("select Amount from Tbl_Safe_Deposit_Box", DB.conn)
        SQLRED = CMD.ExecuteReader
        If SQLRED.Read Then
            TXT_AMONT.Text = SQLRED("Amount").ToString
        End If
        DB.Close()
    End Sub
    Sub TXT_Enabled()
        Me.TxtFacturePosId.ReadOnly = True
        Me.TxtFacturePosCode.ReadOnly = True
        Me.TxtFacturePosDate.ReadOnly = True
        Me.TxtFacturePosHeure.ReadOnly = True
        Me.TxtFacturePosUsername.ReadOnly = True
        Me.txt_qountati.ReadOnly = True
        Me.TXT_Toitl.ReadOnly = True
        Me.TXTFaccturePosTotal.ReadOnly = True
        Me.txtFacturePosRemises.ReadOnly = True


    End Sub

    Dim DT As System.Data.DataTable = New DataTable
    Dim GridLookUp_FilterString As String
    Dim CMD As SqlCommand
    Dim data_prostini As Integer
    Dim Data_Position As Integer
    Function CREATE_COLUNMS_DATATABEL(Optional ByVal RowCount As Integer = 7) As DataTable
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Lookup", .DataType = GetType(String)})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Counter", .DataType = GetType(String)})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Barcode", .DataType = GetType(String)})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Name", .DataType = GetType(String)})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Prix_Vente", .DataType = GetType(Decimal), .DefaultValue = "0.00"})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Stock", .DataType = GetType(Int32), .DefaultValue = "00"})
        DT.Columns.Add(New System.Data.DataColumn With {.ColumnName = "GridView_Items_Quntite", .DataType = GetType(Int32), .DefaultValue = "00"})

        Dim Delete_Repository As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = CType(Me.GridControl1.RepositoryItems.Add("ButtonEdit"), RepositoryItemButtonEdit)
        Delete_Repository.TextEditStyle = TextEditStyles.HideTextEditor

        AddHandler Delete_Repository.ButtonClick, AddressOf Me.AUTOMATICALLY_DELETE_RECORD_ButtonClick

        Dim Delete_Button As EditorButton = Delete_Repository.Buttons(0)
        Delete_Button.Kind = ButtonPredefines.Glyph
        Delete_Button.Caption = "الحذف"
        Delete_Button.ImageOptions.Image = My.Resources.Delete
        Dim Delete_Column As GridColumn = Me.GridView1.Columns.AddField("الحذف")
        Delete_Column.VisibleIndex = 8
        Delete_Column.Width = 80
        Delete_Column.ColumnEdit = Delete_Repository

        Me.GridControl1.DataSource = DT.DefaultView
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.ColumnPanelRowHeight = 40
        Me.GridView1.RowHeight = 30
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.Columns.Item("GridView_Items_Prix_Vente").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "GridView_Items_Prix_Vente", "{0:N2}")
        Me.GridView1.Columns.Item("GridView_Items_Quntite").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "GridView_Items_Quntite", "{0}")
        Me.GridView1.Columns.Item("GridView_Items_Sous_Toal").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "GridView_Items_Sous_Toal", "{0:N2}جنيه مصرى")

        Me.GridControl1.DataSource = DT.DefaultView

        Return DT
    End Function
    Dim infoter As System.Data.DataTable = New DataTable

    Sub POUPL_LOOKUP(ByVal Grid_Lookup As RepositoryItemGridLookUpEdit)
        infoter.Clear()
        Grid_Lookup.DataSource = Nothing
        Dim dr As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter("select ITEMS_Barcode,ITEMS_NAME,ITEMS_Prix_Vente,ITEMS_Stock from TB_ITEMS order by ITEMS_Barcode Asc", DB.conn)
        dr.Fill(infoter)
        If infoter.Rows.Count > 0 Then
            Grid_Lookup.DataSource = infoter
            Grid_Lookup.DisplayMember = "ITEMS_NAME"
            Grid_Lookup.ValueMember = "ITEMS_NAME"
            Grid_Lookup.View.Appearance.FocusedRow.BackColor = Color.Magenta
            Grid_Lookup.PopupFormSize = New Size(500, 400)
            Grid_Lookup.View.ColumnPanelRowHeight = 25
            Grid_Lookup.View.Columns.Clear()

            Grid_Lookup.View.Columns.AddVisible("ITEMS_Barcode", "باركود المنتج")
            Grid_Lookup.View.Columns.AddVisible("ITEMS_NAME", "اسم المنتج")
            Grid_Lookup.View.Columns.AddVisible("ITEMS_Prix_Vente", "سعرالبيع")
            Grid_Lookup.View.Columns.AddVisible("ITEMS_Stock", "الكميه المخزنه")

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

    Private Sub RepositoryItemGridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEdit1.EditValueChanged
        Try

            Dim look_Edt As GridLookUpEdit = CType(sender, GridLookUpEdit)
            Dim select_datarow As DataRowView = CType(look_Edt.GetSelectedDataRow(), DataRowView)
            Try
                Me.GridView1.SetFocusedRowCellValue("GridView_Items_Barcode", select_datarow("ITEMS_Barcode"))
            Catch ex As Exception
                Exit Sub
            End Try

            For Each Duplicate_Data As DataRow In DT.Rows
                If Duplicate_Data("GridView_Items_Barcode") = Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "GridView_Items_Barcode") Then
                    Dim Focused_View As ColumnView = CType(Me.GridControl1.FocusedView, ColumnView)
                    Focused_View.DeleteRow(Focused_View.FocusedRowHandle)
                    Call FOCUSED_ROW_POSITION(Duplicate_Data)
                    DevExpress.XtraEditors.XtraMessageBox.Show("الرجاء الإنتباه .. هذا المنتج مسجّل مسبقا بسلة المبيعات " & "  " & Convert.ToString(Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "GridView_Items_Name")) & "  " & "!! .. و لا يمكن إعادة تسجيله بنفس رمز الباركود", " خطأ في التسجيل ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Me.GridView1.SetFocusedRowCellValue("GridView_Items_Quntite", Me.GridView1.GetRowCellValue(Me.GridView1.FocusedRowHandle, "GridView_Items_Quntite") + 1)
                    Return
                End If
            Next

            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Counter", String.Format((Me.GridView1.DataRowCount + 1).ToString("00")))
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Barcode", select_datarow("ITEMS_Barcode"))
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Name", select_datarow("ITEMS_NAME"))
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Prix_Vente", select_datarow("ITEMS_Prix_Vente"))
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Stock", select_datarow("ITEMS_Stock"))

            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Quntite", 1)
        Catch ex As ApplicationException
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Counter", "")
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Barcode", "")
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Name", "")
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Prix_Vente", "00.00")
            Me.GridView1.SetFocusedRowCellValue("GridView_Items_Quntite", "00")
            Exit Sub
        End Try
    End Sub

    Private Sub GridView1_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        Dim Views As GridView = TryCast(sender, GridView)
        If e.Column.FieldName = "GridView_Items_Sous_Toal" AndAlso e.IsGetData Then
            e.Value = RETRVE_SOUS_TOTAL(Views, e.ListSourceRowIndex)
        End If
        Call CALCULATE_TOTAL_QUANTITE()
        Me.TXTFaccturePosTotal.Text = CType(Me.GridView1.Columns("GridView_Items_Sous_Toal").SummaryItem.SummaryValue, Decimal)
        Me.TXTFaccturePosTotal.Text = Format(Val(Me.TXTFaccturePosTotal.Text.Trim), "00.00")

        CALCULATE_TOTAL_QUANTITE()

    End Sub
    Private Function RETRVE_SOUS_TOTAL(views As GridView, Rows_index As Integer) As Decimal
        Dim Prodect As Decimal = 0.0
        Dim prodect_Qunatuty As Integer = 0

        Prodect = views.GetListSourceRowCellValue(Rows_index, "GridView_Items_Prix_Vente")
        prodect_Qunatuty = views.GetListSourceRowCellValue(Rows_index, "GridView_Items_Quntite")
        Return Prodect * prodect_Qunatuty

    End Function
    Private Sub FILTER_SEARCHING_GRIDLOOKUP_CONTROL(ByVal Sender As Object)
        BeginInvoke(Function()
                        Try
                            GridLookUp_FilterString += " ! "
                            Dim Edit As GridLookUpEdit = TryCast(Sender, GridLookUpEdit)
                            Dim GridView As GridView = TryCast(Edit.Properties.View, GridView)
                            Dim Fi_Search As System.Reflection.FieldInfo = GridView.[GetType]().GetField("extraFilter", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
                            GridLookUp_FilterString = Edit.AutoSearchText

                            Dim First_Option As New DevExpress.Data.Filtering.FunctionOperator("Like", New DevExpress.Data.Filtering.OperandProperty("ITEMS_Barcode"), New DevExpress.Data.Filtering.OperandValue("%" & Edit.AutoSearchText & "%"))
                            Dim Second_Option As New DevExpress.Data.Filtering.FunctionOperator("Like", New DevExpress.Data.Filtering.OperandProperty("ITEMS_NAME"), New DevExpress.Data.Filtering.OperandValue("%" & Edit.AutoSearchText & "%"))

                            Dim FilterCondition As String = ""
                            FilterCondition = (New DevExpress.Data.Filtering.GroupOperator(DevExpress.Data.Filtering.GroupOperatorType.Or, New DevExpress.Data.Filtering.CriteriaOperator() {First_Option, Second_Option})).ToString()
                            Fi_Search.SetValue(GridView, FilterCondition)
                            Dim Mi_Search As System.Reflection.MethodInfo = GridView.[GetType]().GetMethod("ApplyColumnsFilterEx", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
                            Mi_Search.Invoke(GridView, Nothing)
                        Catch ex As Exception
                            XtraMessageBox.Show(ex.Message, "خطأ غير متوقّع", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        End Try
                        Return True
                    End Function)

    End Sub

    Function Forcusen_RowPos(row_data As DataRow) As Integer
        data_prostini = DT.Rows.IndexOf(row_data)
        Me.GridView1.FocusedRowHandle = data_prostini
        Return data_prostini
    End Function

    Private Sub RepositoryItemGridLookUpEdit1_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemGridLookUpEdit1.EditValueChanging
        Me.BeginInvoke(New MethodInvoker(Sub() FILTER_SEARCHING_GRIDLOOKUP_CONTROL(sender)))
    End Sub

    Private Sub RepositoryItemGridLookUpEdit1_Popup(sender As Object, e As EventArgs) Handles RepositoryItemGridLookUpEdit1.Popup
        FILTER_SEARCHING_GRIDLOOKUP_CONTROL(sender)
    End Sub
    Sub CALCULATE_TOTAL_QUANTITE()
        Dim Qunatite_totale As Integer
        For i As Integer = 0 To Me.GridView1.DataRowCount - 1
            Qunatite_totale = Qunatite_totale + Convert.ToInt32(Me.GridView1.GetRowCellValue(i, Me.GridView1.Columns("GridView_Items_Quntite")))
        Next
        txt_qountati.Text = Qunatite_totale.ToString
        Me.txt_qountati.Text = IIf(Qunatite_totale = 0, "00", String.Format("{0}", Qunatite_totale))
    End Sub

    Private Sub TXTFaccturePosTotal_EditValueChanged(sender As Object, e As EventArgs) Handles TXTFaccturePosTotal.EditValueChanged
        Dim Sous_Totel As Decimal = 0.0
        Dim valer_Chareges As Decimal = 0.0
        Dim valer_Remariss As Decimal = 0.0
        Try
            Sous_Totel = Val(Replace(Me.TXTFaccturePosTotal.Text, ",", "."))
            valer_Remariss = Val(Replace(txtFacturePosRemises.Text, ",", "."))

        Catch ex As Exception
            MsgBox("no ")
        End Try
        If Val(Replace(Me.TXTFaccturePosTotal.Text, ",", ".")) > 0 Then
            Me.TXT_Toitl.Text = Sous_Totel + valer_Chareges - valer_Remariss
            Me.TXT_Toitl.Text = Format(Val(Me.TXT_Toitl.Text.Trim), "00.00")
        End If
    End Sub

    Private Sub txtFacturePosRemises_EditValueChanged(sender As Object, e As EventArgs) Handles txtFacturePosRemises.EditValueChanged
        Dim Sous_Totel As Decimal = 0.0
        Dim valer_Chareges As Decimal = 0.0
        Dim valer_Remariss As Decimal = 0.0
        Try
            Sous_Totel = Val(Replace(Me.TXTFaccturePosTotal.Text, ",", "."))
            valer_Remariss = Val(Replace(txtFacturePosRemises.Text, ",", "."))

        Catch ex As Exception
            MsgBox("no ")
        End Try
        If Val(Replace(Me.TXTFaccturePosTotal.Text, ",", ".")) > 0 Then
            Me.TXT_Toitl.Text = Sous_Totel + valer_Chareges - valer_Remariss
            Me.TXT_Toitl.Text = Format(Val(Me.TXT_Toitl.Text.Trim), "00.00")
        End If


    End Sub

    Private Sub TXT_PoslnputCharges_KeyDown(sender As Object, e As KeyEventArgs)

        Dim duplise As Double
        If e.KeyCode = Keys.Enter Then

            Beep()
        End If

    End Sub

    Private Sub TXT_PoslnputCharges_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Private Sub txtFacturePosRemises_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFacturePosRemises.KeyPress
        If Me.txtFacturePosRemises.Text.Trim = vbNullString Or Me.txtFacturePosRemises.Text.Trim = "00.00" Then
            Me.txtFacturePosRemises.Text = vbNullString
        End If
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
                If Me.txtFacturePosRemises.Text.Contains(".") Then
                    If Me.txtFacturePosRemises.Text.Split(".")(1).Length < 2 Then
                        If Char.IsDigit(e.KeyChar) = False Then e.Handled = True
                    Else
                        e.Handled = True
                    End If
                End If
            Else
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub but_add_Click(sender As Object, e As EventArgs)
        Me.TxtFacturePosId.Text = DateTime.Now.ToString("yyyy-MM-dd")
        Me.TxtFacturePosHeure.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub
    Function FOCUSED_ROW_POSITION(Row_Data As DataRow) As Integer
        Data_Position = DT.Rows.IndexOf(Row_Data)
        Me.GridView1.FocusedRowHandle = Data_Position
        Return Data_Position
    End Function
    Private Sub GridView1_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles GridView1.ValidateRow

    End Sub
    Private Sub AUTOMATICALLY_DELETE_RECORD_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs)
        If Me.GridView1.DataRowCount = 0 Then
            Me.TXTFaccturePosTotal.Text = "00.00"
            Me.txt_qountati.Text = "00"
            ' Me.txt_FacposCharges.Text = "00.00"
            Me.txtFacturePosRemises.Text = "00.00"
            Me.TXT_Toitl.Text = "00.00"
            Return
        ElseIf XtraMessageBox.Show("  هل أنت متأكّد من أنّك تريد حذف بيانات هذا المنتج :  " & " ? ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call DELETE_SELECTED_ROWS(Me.GridView1)
            Call CALCULATE_TOTAL_QUANTITE()
        End If
    End Sub

    Private Sub DELETE_SELECTED_ROWS(ByVal View As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim Row_Data As System.Data.DataRow
        Dim Rrows() As System.Data.DataRow
        Dim I As Integer
        ReDim Rrows(View.SelectedRowsCount - 1)
        For I = 0 To View.SelectedRowsCount - 1
            Rrows(I) = View.GetDataRow(View.GetSelectedRows(I))
        Next
        View.BeginSort()
        Try
            For Each Row_Data In Rrows
                Row_Data.Delete()
            Next
        Finally
            View.EndSort()

        End Try
    End Sub
    Public Function RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE(Field_Name, Table_Name) As Integer
        RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE = 0
        Dim Sql = "SELECT COUNT(" & Field_Name & ") From  " & Table_Name
        Dim Adp As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(Sql, DB.conn)
        Dim DS As System.Data.DataSet = New System.Data.DataSet
        Adp.Fill(DS)
        Dim DT As New System.Data.DataTable
        DT = DS.Tables(0)
        If DT.Rows.Count > 0 Then
            Dim I = DT.Rows.Count - 1
            RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE = Convert.ToInt32(DT.Rows(I).Item(0))
        End If
    End Function

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.OptionsBehavior.ReadOnly = False
        Dim Rresult As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد فعلا إضافة فاتورة مبيعات جديدة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Rresult = System.Windows.Forms.DialogResult.Yes Then

            Me.TxtFacturePosId.Text = RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE("POS_Procurement_id", "TBL_POS_Procurement")
            Me.TxtFacturePosCode.Text = Format(Val(RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE("POS_Procurement_id", "TBL_POS_Procurement") + 1), "POS000000")
            Me.TxtFacturePosDate.Text = DateTime.Now.ToString("yyyy-MM-dd")
            Me.TxtFacturePosHeure.Text = DateTime.Now.ToString("HH:mm:ss")
            Me.TxtFacturePosSupplir.Text = "CUS" & DateTime.Now.ToString("yyyyMMddHHmmss")
            ' Me.TxtFacturePosUsername.Text = MDIParent1.BarStaticItem1.Caption
            clertext()
        End If



    End Sub
    Sub clertext()
        '  Me.TxtFacturePosId.Text = vbNullString
        ' Me.TxtFacturePosCode.Text = vbNullString
        ' Me.TxtFacturePosDate.Text = vbNullString
        ' Me.TxtFacturePosHeure.Text = vbNullString
        ' Me.TxtFacturePosCustomers.Text = vbNullString
        ' Me.TxtFacturePosUsername.Text = vbNullString
        Me.txt_qountati.Text = "00.00"
        Me.TXT_Toitl.Text = "00.00"
        ' Me.TxtFacturePosSousTotal.Text = "00.00"
        ' Me.TxtFacturePosCharges.Text = "00.00"
        Me.txtFacturePosRemises.Text = "00.00"
        Me.TXTFaccturePosTotal.Text = "00.00"
        DT.Clear()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            If TXT_Toitl.Text > TXT_AMONT.Text Then
                Dim Frm1 As New DialogResult
                Frm1 = DevExpress.XtraEditors.XtraMessageBox.Show("المبلغ غير متوفر فى الخزنه لان" & Environment.NewLine & Convert.ToString(Me.TXT_Toitl.Text.Trim))
                Exit Sub
            End If
            DB.Open()
            CMD = New SqlCommand("sql_add_Procurement_Master", DB.conn)
            CMD.CommandType = CommandType.StoredProcedure

            CMD.Parameters.AddWithValue("@POS_Procurement_Id", SqlDbType.Int).Value = Convert.ToInt32(Me.TxtFacturePosId.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Code", SqlDbType.NVarChar).Value = Convert.ToString(Me.TxtFacturePosCode.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Date", SqlDbType.Date).Value = Format(CDate(Me.TxtFacturePosDate.Text.Trim), "yyyy-MM-dd")
            CMD.Parameters.AddWithValue("@POS_Procurement_Heure", SqlDbType.NVarChar).Value = Convert.ToString(Me.TxtFacturePosHeure.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Customers", SqlDbType.NVarChar).Value = Convert.ToString(Me.TxtFacturePosSupplir.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Username", SqlDbType.NVarChar).Value = Convert.ToString(Me.TxtFacturePosUsername.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Sous_Total", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.TXTFaccturePosTotal.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Remises", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.txtFacturePosRemises.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_Procurement_Grand_Total", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.TXT_Toitl.Text.Trim)
            CMD.Parameters.AddWithValue("@POS_ValueinEgyptian", SqlDbType.NVarChar).Value = Convert.ToString(Me.txtLiteral.Text.Trim)


            CMD.ExecuteNonQuery()
            For I As Integer = 0 To Me.GridView1.DataRowCount - 1


                CMD = New SqlCommand("SQL_ADD_TBL_Procurement_DETAILS", DB.conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@POS_DETAILS_Code", SqlDbType.NVarChar).Value = Convert.ToString(Me.TxtFacturePosCode.Text.Trim)
                CMD.Parameters.AddWithValue("@POS_DETAILS_Items_Barcode", SqlDbType.NVarChar).Value = Convert.ToString(Me.GridView1.GetRowCellValue(I, "GridView_Items_Barcode"))
                CMD.Parameters.AddWithValue("@POS_DETAILS_Items_Name", SqlDbType.NVarChar).Value = Convert.ToString(Me.GridView1.GetRowCellValue(I, "GridView_Items_Name"))
                CMD.Parameters.AddWithValue("@POS_DETAILS_Items_Prix_Vente", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.GridView1.GetRowCellValue(I, "GridView_Items_Prix_Vente"))
                CMD.Parameters.AddWithValue("@POS_DETAILS_Items_Quantite", SqlDbType.Int).Value = Convert.ToInt32(Me.GridView1.GetRowCellValue(I, "GridView_Items_Quntite"))
                CMD.Parameters.AddWithValue("@POS_DETAILS_Items_Sous_Total", SqlDbType.Decimal).Value = Convert.ToDecimal(Me.GridView1.GetRowCellValue(I, "GridView_Items_Sous_Toal"))

                CMD.ExecuteNonQuery()
                CMD = New SqlCommand("SQL_TotalAmount_lack", DB.conn)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Amount", TXT_Toitl.Text)
                CMD.ExecuteNonQuery()
            Next

            Call UPDATE_ITEMS_STORE()
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" تمت بنجاح عملية حفظ فاتورة المبيعات رقم  .. هل تريد المواصلة و طباعة وصل تسليم المنتجات  ؟؟ " & Environment.NewLine & Convert.ToString(Me.TxtFacturePosCode.Text.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                GridView1.OptionsBehavior.ReadOnly = True

                Dim fr As New frm_report_Procurement
                fr.code = TxtFacturePosCode.Text
                fr.Show()

                Call RETRIEVE_LAST_FACTURE_POS_CODE()
                Call PRINT_FACTURE_POS_REPORT()
            End If
            DB.Close()

        Catch ex As Exception

            XtraMessageBox.Show(ex.Message, "خطأ غير متوقع", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            DB.Close()
        End Try


    End Sub
    Public Sub UPDATE_ITEMS_STORE()
        For M As Integer = 0 To Me.GridView1.DataRowCount - 1
            Dim New_Quantity As Integer = Val(Me.GridView1.GetRowCellValue(M, "GridView_Items_Stock")) + Val(Me.GridView1.GetRowCellValue(M, "GridView_Items_Quntite"))
            Dim InfoCommand As New SqlClient.SqlCommand
            InfoCommand.Connection = DB.conn
            InfoCommand.CommandText = "UPDATE TB_ITEMS SET ITEMS_Stock = " & New_Quantity & " Where ITEMS_Barcode = '" & Convert.ToString(Me.GridView1.GetRowCellValue(M, "GridView_Items_Barcode")) & "'"
            InfoCommand.ExecuteNonQuery()
        Next
    End Sub
    Sub RETRIEVE_LAST_FACTURE_POS_CODE()
        Dim Sql As String = "SELECT MAX(POS_MASTER_Code) From TBL_POS_MASTER"
        Dim InfoCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(Sql, DB.conn)
        Dim DA As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(InfoCommand)
        Dim InfoTable As System.Data.DataTable = New System.Data.DataTable
        DA.Fill(InfoTable)
        Me.TxtFacturePosPrintCode.Text = InfoTable.Rows(0)(0).ToString
    End Sub
    Private Sub PRINT_FACTURE_POS_REPORT()

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbl.Visible = False Then
            lbl.Visible = True
        ElseIf lbl.Visible = True Then
            lbl.Visible = False
        End If
    End Sub
    Sub logSupplir()
        Dim dt = New DataTable
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter("select ID, Name from Tbl_Supplir", DB.conn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.NewRow()
            dr("Name") = "--فورى--"
            dr("ID") = "0"
            dt.Rows.InsertAt(dr, 0)
            TxtFacturePosSupplir.DataSource = Nothing
            Me.TxtFacturePosSupplir.DataSource = dt
            Me.TxtFacturePosSupplir.DisplayMember = "Name"
            Me.TxtFacturePosSupplir.ValueMember = "ID"
        End If
    End Sub
    Private Sub ConvertNumber()
        If (TXT_Toitl.Text > 0) Then
            Dim Numeric As Decimal = Decimal.Parse(TXT_Toitl.Text.Trim)
            txtLiteral.Text = NumericToLiteral.Convert(Numeric, False, "جنيه", "جنيهات")
        Else
            txtLiteral.Text = ""
        End If
    End Sub

    Private Sub TXT_Toitl_EditValueChanged(sender As Object, e As EventArgs) Handles TXT_Toitl.EditValueChanged
        ConvertNumber()
    End Sub
    Private Sub TXT_Toitl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_Toitl.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim Frm As New DialogResult
        Frm = XtraMessageBox.Show("هل تريد فعلا الخروج من الصفحة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            animateWin(Me, False)
            DB.Close()
            Me.Dispose()
        Else
            Me.Close()
        End If
    End Sub
End Class