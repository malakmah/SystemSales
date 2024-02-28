Imports DevExpress.XtraEditors

Public Class frm_ExpiredItems
    Sub New()


        InitializeComponent()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Pumpkin"
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Glass Oceans"
        ''Blue
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Stardust"



    End Sub
    Private Sub FRM_item_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("ar-DZ")
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("ar-DZ")
        Call getDate()
        Call CHECK_PRODUCT_EXPIRE_DATE()
        Me.Grid_ITEMS_COUNT.ColumnPanelRowHeight = 35
        Me.Grid_ITEMS_COUNT.RowHeight = 25
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Barcode").Caption = "رمز الباركود"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_NAME").Caption = "الاسم"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Unite").Caption = "النوع"
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Prix_Achat").Caption = "سعر البيع"

        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Date_Expire").Caption = " تاريخ الانتهاء"

        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Date_Expire").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Grid_ITEMS_COUNT.Columns("ITEMS_Date_Expire").DisplayFormat.FormatString = "yyyy-MM-dd"


    End Sub
    Dim DA As New SqlClient.SqlDataAdapter


    Sub getDate()

        Try
            DB.Open()
            grid_prode.DataSource = DB.GetData("select s.ITEMS_Barcode,ITEMS_NAME,ITEMS_Unite,ITEMS_Prix_Achat,ITEMS_Date_Expire from TB_ITEMS s where ITEMS_Date_Expire < '" & DateTime.Now.ToString("yyyy-MM-dd") & "' order by ITEMS_Date_Expire")

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message & "تم انتهاء تاريخ صلاحيه تناولها واستعمالها", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Finally
        End Try

    End Sub
    Public Sub CHECK_PRODUCT_EXPIRE_DATE()
        DB.Open()
        Dim DT As New DataTable
        DA = New SqlClient.SqlDataAdapter("select s.ITEMS_Barcode,ITEMS_NAME,ITEMS_Unite,ITEMS_Prix_Achat,ITEMS_Date_Expire from TB_ITEMS s where ITEMS_Date_Expire < '" & DateTime.Now.ToString("yyyy-MM-dd") & "' order by ITEMS_Date_Expire", DB.conn)
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
            XtraMessageBox.Show(Expired_Messge & "تم انتهاء تاريخ صلاحيه تناولها واستعمالها", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


        End If

    End Sub

End Class