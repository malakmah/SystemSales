Imports DevExpress.XtraEditors

Public Class XtraForm6

    Private Sub XtraForm6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("ar-DZ")
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("ar-DZ")
        Call getDate()
        Call CHECK_PRODUCT_EXPIRE_DATE()
        Me.Grid_ITEMS_COUNT.ColumnPanelRowHeight = 35
        Me.Grid_ITEMS_COUNT.RowHeight = 25
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Barcode").Caption = "رمز الباركود"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_NAME").Caption = "الاسم"
        ' Me.Grid_ITEMS_COUNT.Columns("ITEMS_Unite").Caption = "النوع"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Prix_Achat").Caption = "سعر البيع"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Prix_Vente").Caption = "سعر الشراء"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Stock").Caption = "الكميه"

        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Date_Expire").Caption = "تاريخ الشراء"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Date_Expire").DisplayFormat.FormatString = "yyyy-MM-dd"

    End Sub
    Sub getDate()

        Try
            DB.Open()
            grid_prode.DataSource = DB.GetData("select ITEMS_Barcode,ITEMS_NAME,ITEMS_Prix_Achat,ITEMS_Prix_Vente,ITEMS_Stock,ITEMS_Date_Expire from TB_ITEMS where ITEMS_Stock <3 order by ITEMS_Date_Expire")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message & "تم انتهاء تاريخ صلاحيه تناولها واستعمالها", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Finally
        End Try

    End Sub
    Public Sub CHECK_PRODUCT_EXPIRE_DATE()
        DB.Open()
        Dim DT As New DataTable
        Dim DA = New SqlClient.SqlDataAdapter("select ITEMS_Barcode,ITEMS_NAME,ITEMS_Prix_Achat,ITEMS_Prix_Vente,ITEMS_Stock,ITEMS_Date_Expire from TB_ITEMS where ITEMS_Stock <3 order by ITEMS_Date_Expire", DB.conn)
        DA.Fill(DT)

        Dim Today = DateTime.Now.ToString("yyyy-MM-dd")
        Dim EXpired_producn As New List(Of String)
        Dim Expired_Messge As String = "المنتجات التاليه اسماها :" & Environment.NewLine
        Dim Expired_INDEX = 1

        For Each New_Date As DataRow In DT.Rows
            Dim RentExpiranion As Date = CDate(New_Date.Item("ITEMS_Date_Expire").ToString)
            If Date.Compare(RentExpiranion, Today) < 0 Then
                EXpired_producn.Add(New_Date.Item("ITEMS_NAME"))
                Expired_Messge &= Expired_INDEX & "." & "." & New_Date.Item("ITEMS_Barcode") & "." & New_Date.Item("ITEMS_NAME") & vbNewLine

            End If

            Expired_INDEX += 1

        Next
        If Not EXpired_producn.Count.Equals(0) Then
            XtraMessageBox.Show(Expired_Messge & "الكميه على وشق الانتهاء", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        grid_prode.ExportToXlsx(Application.StartupPath & "/myreport.Xlsx")
    End Sub
End Class