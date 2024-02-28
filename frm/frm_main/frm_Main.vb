Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.LookAndFeel

Public Class frm_Main
    'Dim DT As New DataTable
    'Dim CMD As New SqlCommand
    'Dim DA As New SqlDataAdapter
    Private Sub TileItem18_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b1.ItemClick
        log()
        docSeles.Show()
    End Sub

    Private Sub frm_Min_FormClosing1(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'e.Cancel = True
        'Call RETRIEVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
        'Call RETRIEVE_MIXER_FIRST_SECOND_COLOR_IN_SETTINGS()
    End Sub
    Private Sub RETRIEVE_MIXER_FIRST_SECOND_COLOR_IN_SETTINGS()
        UserLookAndFeel.Default.SkinMaskColor = My.Settings.SkinFirstMixerColor
        UserLookAndFeel.Default.SkinMaskColor2 = My.Settings.SkinSecondMixerColor
        UserLookAndFeel.Default.UpdateStyleSettings()

    End Sub

    Private Sub frm_Min_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        Exit Sub
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Welcom.Close()
        frmSettings.Bar1.Visible = False
        frmSettings.SimpleButton2.Visible = False
        frmSettings.Show()

        LOGDATA()
        frmSettings.Close()
        frmSettings.Bar1.Visible = True
        frmSettings.SimpleButton2.Visible = True


        SkinRibbonGalleryBarItem4.VisibleInSearchMenu = True
        BarStaticIName.Caption = "اسم المستخدم : "
        BName.Caption = text_userName.Text
        TotalAmount()
        Me.BarStaticDate.Caption = ":Sales System: نظام مبيعات كامل"


        Dim SkinName As RegistryKey = Registry.CurrentUser.CreateSubKey("@SOFTWARE\WINREGISTRY")
        If SkinName IsNot Nothing Then
            'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = SkinName.GetValue("@SkinName").ToString

        End If



        'lab.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Pumpkin"
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Glass Oceans"
        ''Blue
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Stardust"

        DB.Open()
        Dim DT As New DataTable

        Dim DA = New SqlClient.SqlDataAdapter("select s.ITEMS_Barcode,ITEMS_NAME,ITEMS_Unite,ITEMS_Prix_Achat,ITEMS_Date_Expire from TB_ITEMS s where ITEMS_Date_Expire < '" & DateTime.Now.ToString("yyyy-MM-dd") & "' order by ITEMS_Date_Expire", DB.conn)

        DA.Fill(DT)
        'count_items.Text = DT.Rows.Count

        docSeles.Close()
        DOK_ITEMS.Close()
        Doc_COUSTEMR.Close()
        DockPanel1.Close()
        Doc_Supplir.Close()
        Dok_Employee.Close()
        DockimgeItem.Close()
        docHome.Show()

        color()
        ' SP.Visible = False
    End Sub
    Sub logitem2()
        DB.Open()
        Dim DT As New DataTable

        Dim DA = New SqlClient.SqlDataAdapter("select ITEMS_Barcode,ITEMS_NAME,ITEMS_Prix_Achat,ITEMS_Prix_Vente,ITEMS_Stock,ITEMS_Date_Expire from TB_ITEMS where ITEMS_Stock <3 order by ITEMS_Date_Expire", DB.conn)

        DA.Fill(DT)
        ' count_items.Text = DT.Rows.Count

        docSeles.Close()
        DOK_ITEMS.Close()
        Doc_COUSTEMR.Close()
        DockPanel1.Close()
        docHome.Show()
        color()
    End Sub
   
    Sub passtext()
        Dim frm As New frm_item
        frm.txt_code.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Id").ToString
        frm.comitems.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Code").ToString
        frm.txt__Prix_Vente.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Date").ToString
        frm.txt_Prix_Achat.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Id").ToString
        frm.comitems.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Code").ToString
        frm.txt_qunt.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Date").ToString
        frm.txt_Date_Expire.EditValue = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "POS_MASTER_Date").ToString


    End Sub
    Sub passSupplir()
        Dim frm As New frm_Supplir
        frm.btnAdd.Enabled = False
        frm.TXT_ID.Text = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الكود").ToString
        frm.TXT_NAME.Text = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الاسم").ToString
        frm.TXT_ADDER.Text = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "العنوان").ToString
        frm.TXT_PON.Text = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الهاتف").ToString
        frm.buc.EditValue = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الصوره").ToString
        frm.TXT_DATE.EditValue = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "التاريخ").ToString
        Dim logo_Byts As [Byte]()
        logo_Byts = Me.Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الصوره")
        Dim Ms_Stream As New MemoryStream(logo_Byts, True)
        Dim isimage As System.Drawing.Image = New Bitmap(Ms_Stream)
        frm.buc.Image = isimage
        frm.buc.BackgroundImageLayout = ImageLayout.Stretch
        frm.Show()

    End Sub
    Sub passCustomer()
        Dim frm As New frm_Customer
        frm.btnAdd.Enabled = False

        frm.TXT_ID.Text = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الكود").ToString
        frm.TXT_NAME.Text = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الاسم").ToString
        frm.TXT_ADDER.Text = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "العنوان").ToString
        frm.TXT_PON.Text = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الهاتف").ToString
        frm.buc.EditValue = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الصوره").ToString
        frm.TXT_DATE.EditValue = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "التاريخ").ToString
        Dim logo_Byts As [Byte]()
        logo_Byts = Me.Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الصوره")
        Dim Ms_Stream As New MemoryStream(logo_Byts, True)
        Dim isimage As System.Drawing.Image = New Bitmap(Ms_Stream)
        frm.buc.Image = isimage
        frm.buc.BackgroundImageLayout = ImageLayout.Stretch
        frm.Show()

    End Sub
    Sub passEmployee()
        Dim frm As New frm_Employee
        frm.btnadd.Enabled = False

        frm.TXT_ID.Text = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الكود").ToString
        frm.TXT_NAME.Text = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الاسم").ToString
        frm.TXT_ADDER.Text = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "العنوان").ToString
        frm.TXT_PON.Text = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الهاتف").ToString
        frm.GR_Type.Text = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "النوع").ToString

        frm.buc.EditValue = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الصوره").ToString
        frm.TXT_DATE.EditValue = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "التاريخ").ToString

        Dim logo_Byts As [Byte]()
        logo_Byts = Me.grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الصوره")
        Dim Ms_Stream As New MemoryStream(logo_Byts, True)
        Dim isimage As System.Drawing.Image = New Bitmap(Ms_Stream)
        frm.buc.Image = isimage
        frm.buc.BackgroundImageLayout = ImageLayout.Stretch
        frm.Show()

    End Sub
    Sub passItem()
        Dim frm As New frm_item
        frm.btn_add.Enabled = False
        frm.txt_code.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "الكود").ToString
        frm.txt_ITEMS_Barcode.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "التسلسل").ToString
        frm.txt_name.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "الاسم").ToString
        frm.comitems.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "النوع").ToString
        frm.txt__Prix_Vente.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "سعر البيع").ToString
        frm.txt_Prix_Achat.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "سعر الشراء").ToString
        frm.txt_qunt.Text = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "الكميه").ToString
        frm.txt_Date_Expire.EditValue = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "التاريخ").ToString

        Dim logo_Byts As [Byte]()
        logo_Byts = Me.Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "الصوره")
        Dim Ms_Stream As New MemoryStream(logo_Byts, True)
        Dim isimage As System.Drawing.Image = New Bitmap(Ms_Stream)
        frm.pc.Image = isimage
        frm.pc.BackgroundImageLayout = ImageLayout.Stretch
        frm.Show()

    End Sub
    Sub DeleteSupplir()
        Try


            Dim id As String = ""
            Dim cmd As SqlCommand
            id = Grid_get_Supplir.GetRowCellValue(Grid_get_Supplir.FocusedRowHandle, "الكود").ToString
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" هل تريد حذف المورد رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                DB.Open()
                cmd = New SqlCommand("SQ_DEL_Supplir", DB.conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(" تم حذف المورد رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            End If
        Catch ex As Exception

        End Try


    End Sub
    Sub DeleteEmployee()
        Try
            Dim id As String = ""
            Dim cmd As SqlCommand
            id = grv_Employee.GetRowCellValue(grv_Employee.FocusedRowHandle, "الكود").ToString
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" هل تريد حذف المورد رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                DB.Open()
                cmd = New SqlCommand("SQ_DEL_Employee", DB.conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(" تم حذف المورد رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                GET_SQL_GET_Employee()
            End If
        Catch ex As Exception

        End Try


    End Sub
    Sub DeleteCustomer()
        Try
            Dim id As String = ""
            Dim cmd As SqlCommand
            id = Grid_Customer.GetRowCellValue(Grid_Customer.FocusedRowHandle, "الكود").ToString
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" هل تريد حذف العميل رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                DB.Open()
                cmd = New SqlCommand("SQ_DEL_Customer", DB.conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ID", id)
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(" تم حذف العميل رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                GET_Customer()
            End If
        Catch ex As Exception

        End Try


    End Sub
    Sub DeleteItems()
        Try
            Dim id As String = ""
            Dim cmd As SqlCommand
            id = Grid_ITEMS_.GetRowCellValue(Grid_ITEMS_.FocusedRowHandle, "الكود").ToString
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" هل تريد حذف المنتج رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                DB.Open()
                cmd = New SqlCommand("SQL_DEL_ITEMS", DB.conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@ITEMS_ID", id)
                cmd.ExecuteNonQuery()
                Grid_ITEMS.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
                DB.Close()
                XtraMessageBox.Show(" تم حذف المورد رقم  ..؟؟ " & Environment.NewLine & Convert.ToString(id.Trim) & " ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                'GET_SQL_GET_ITEMS()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Sub color()
       
        Me.Grid_ITEMS_.Columns.Item("الكود").Width = 100
        Me.Grid_ITEMS_.Columns.Item("التسلسل").Width = 200
        Me.Grid_ITEMS_.Columns.Item("الاسم").Width = 150
        Me.Grid_ITEMS_.Columns.Item("النوع").Width = 150
        Me.Grid_ITEMS_.Columns.Item("سعر البيع").Width = 130
        Me.Grid_ITEMS_.Columns.Item("سعر الشراء").Width = 130
        Me.Grid_ITEMS_.Columns.Item("الكميه").Width = 115
        Me.Grid_ITEMS_.Columns.Item("الصوره").Width = 117
        'Me.Grid_ITEMS_.Columns.Item("التاريخ").Width = 110
        'Me.Grid_ITEMS_.OptionsView.ShowFooter = True
        'Me.Grid_ITEMS_.Columns.Item("الاسم").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "التارخ", "SUM={0:N2}")


        'Me.Grid_Customer.OptionsView.ShowPreview = False

        'Me.Grid_Customer.Columns.Item("الاسم").Visible = True
        'Me.Grid_Customer.Columns.Item("الصوره").VisibleIndex = 7

        'Me.gvd_Customer.LookAndFeel.UseDefaultLookAndFeel = False
        'Me.gvd_Customer.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat



        Me.Grid_Customer.Columns.Item("الكود").Width = 100
        Me.Grid_Customer.Columns.Item("الاسم").Width = 250
        Me.Grid_Customer.Columns.Item("العنوان").Width = 200
        Me.Grid_Customer.Columns.Item("الهاتف").Width = 200
        Me.Grid_Customer.Columns.Item("النوع").Width = 150
        Me.Grid_Customer.Columns.Item("التاريخ").Width = 200
        Me.Grid_Customer.Columns.Item("الصوره").Width = 150
        Me.grv_Employee.OptionsView.ShowFooter = True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.Grid_get_Supplir.Columns.Item("الكود").Width = 100
        Me.Grid_get_Supplir.Columns.Item("الاسم").Width = 250
        Me.Grid_get_Supplir.Columns.Item("العنوان").Width = 200
        Me.Grid_get_Supplir.Columns.Item("الهاتف").Width = 200
        Me.Grid_get_Supplir.Columns.Item("النوع").Width = 150
        Me.Grid_get_Supplir.Columns.Item("التاريخ").Width = 200
        Me.Grid_get_Supplir.Columns.Item("الصوره").Width = 150
        Me.grv_Employee.OptionsView.ShowFooter = True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.grv_Employee.Columns.Item("الكود").Width = 100
        Me.grv_Employee.Columns.Item("الاسم").Width = 250
        Me.grv_Employee.Columns.Item("العنوان").Width = 200
        Me.grv_Employee.Columns.Item("النوع").Width = 150
        Me.grv_Employee.Columns.Item("التاريخ").Width = 200
        Me.grv_Employee.Columns.Item("الصوره").Width = 180
        Me.grv_Employee.OptionsView.ShowFooter = True
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    End Sub

    Private Sub TileItem17_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem17.ItemClick
        log()
        FrmTameLinx.ShowDialog()

    End Sub



    Private Sub TileItem3_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        log()
        frm_item.Show()

    End Sub

    Private Sub TileItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b4.ItemClick
        log()
        Doc_COUSTEMR.Show()
    End Sub
    Sub log()

        SplashScreenManager.ShowForm(Me, GetType(Loading), True, True, False)
        SplashScreenManager.Default.SetWaitFormCaption("Please wait......")
        Dim i As Integer
        For i = 0 To 50 - 1 Step i + 1
            Thread.Sleep(10)

        Next
        SplashScreenManager.CloseForm()
    End Sub
    Sub LOGDATA()
        GET_Customer()
        GEY_ITEMS()
        GET_SQL_GET_Supplir()
        GET_SQL_GET_Employee()
        TotalAmount()
    End Sub
    Public Sub GET_SQL_GET_Supplir()
        DB.Close()
        DB.Open()
        grid_Supplir.DataSource = DB.GetData("SQL_GET_Supplir")
        DB.Close()

    End Sub
    Public Sub GET_Customer()
        DB.Close()
        DB.Open()
        gvd_Customer.DataSource = DB.GetData("SQL_GET_Customer")
        DB.Close()

    End Sub
    Public Sub GEY_ITEMS()
        DB.conn.Open()
        Grid_ITEMS.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        DB.Close()
    End Sub
    Public Sub GET_SQL_GET_Employee()
        DB.Close()
        DB.Open()
        grvd_Employee.DataSource = DB.GetData("SQL_GET_Employee")
        DB.Close()

    End Sub
    Public Sub GET_SQL_GET_ITEMS()
        DB.Close()
        DB.Open()
        GridControl2.DataSource = DB.GetData("SQL_GET_TB_ITEMS")

        DB.Close()

    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'If CheckBox1.Checked = True Then
        '    SP.Visible = True
        'End If
        'If CheckBox1.Checked = False Then
        '    SP.Visible = False
        'End If
    End Sub

    Private Sub SP_Click(sender As Object, e As EventArgs)
        log()
        'Me.gvd_Customer.ColumnPanelRowHeight = 40
        'Me.gvd_Customer.RowHeight = 30
        frm_Customer.Show()
    End Sub

    Private Sub TileItem8_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b9.ItemClick
        log()
        Frm_Sales.TxtFacturePosUsername.Text = text_userName.Text
        Frm_Sales.Show()

    End Sub

    Private Sub TileControl2_Click(sender As Object, e As EventArgs) Handles TileControl2.Click

    End Sub

    Private Sub TileItem3_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b3.ItemClick
        log()

        '  Me.Grid_ITEMS_.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.Grid_ITEMS_.ColumnPanelRowHeight = 40
        Me.Grid_ITEMS_.RowHeight = 30
        DOK_ITEMS.Show()
    End Sub

    Private Sub TileItem19_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        'XtraForm1.Show()
    End Sub

    Private Sub TileItem7_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b7.ItemClick
        DockPanel1.Show()
        GET_SQL_GET_ITEMS()
        TotalAmount()
        ' GEY_ITEMS2()
        'Threading.Tasks.Task.Factory.StartNew(Sub() ITMS_LOG())
        'ITMS_LOG()
    End Sub

    Private Sub TileItem21_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)
        log()
        frm_FullData.Show()
    End Sub


    Private Sub TileItem11_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b13.ItemClick
        Frm_PriceList.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim frm As New frm_item
        frm.ShowDialog()
    End Sub

    Private Sub b16_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b16.ItemClick
        ' frmAdd_User.ShowDialog()
        Dim frm As New frmProfits
        frm.Show()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        frm_Customer.Show()
    End Sub



    Private Sub TileItem1_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        ' XtraForm1.Show()
        XtraForm6.Show()
        'DockimgeItem.Show()
    End Sub

    Private Sub TileItem3_ItemClick_2(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem3.ItemClick
        log()

        frmExpiration.Show()
    End Sub

    Private Sub TileItem4_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem4.ItemClick
        log()
        DockPanel1.Close()
        docSeles.Show()
        'itim_count.Show()
    End Sub

    Private Sub b5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles b5.ItemClick
        Doc_Supplir.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit34_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit34.Click
        passSupplir()
    End Sub

    Private Sub RepositoryItemButtonEdit35_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit35.Click
        DeleteSupplir()
        GET_SQL_GET_Supplir()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        log()
        Dim frm As New frm_Supplir
        frm.btnUp.Enabled = False
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        log()
        Doc_Supplir.Close()
        docSeles.Show()
    End Sub

    Private Sub b6_ItemClick(sender As Object, e As TileItemEventArgs) Handles b6.ItemClick
        Dok_Employee.Show()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        log()
        Dok_Employee.Close()
        docSeles.Show()

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        frm_Employee.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit37_Click(sender As Object, e As EventArgs)
        passEmployee()
    End Sub

    Private Sub RepositoryItemButtonEdit38_Click(sender As Object, e As EventArgs)
        log()
        DeleteEmployee()
        GET_SQL_GET_Employee()
    End Sub

    Private Sub bb_ItemClick(sender As Object, e As TileItemEventArgs) Handles bb.ItemClick
        log()
        frm_Purchase.Show()
    End Sub

    Private Sub bb2_ItemClick(sender As Object, e As TileItemEventArgs) Handles bb2.ItemClick
        log()
        frmPresence.ShowDialog()
        ' frm_.ShowDialog()
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.Close()
    End Sub

    Private Sub frm_Min_FormClosing(sender As Object, e As FormClosingEventArgs)

        Dim SkinName As RegistryKey = Registry.CurrentUser.CreateSubKey("@SOFTWARE\WINREGISTRY")
        SkinName.SetValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName.ToString())
        SkinName.Close()
    End Sub




    Private Sub b11_ItemClick(sender As Object, e As TileItemEventArgs) Handles b11.ItemClick
        log()
        report_WorkOrder.Show()
    End Sub

    Private Sub b12_ItemClick(sender As Object, e As TileItemEventArgs) Handles b12.ItemClick
        log()
        Frm_Purchases_All.Show()
    End Sub

    Private Sub b8_ItemClick(sender As Object, e As TileItemEventArgs) Handles b8.ItemClick
        log()
        frm_Expnses.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BarStaticDate.Caption = DateTime.Now
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        log()
        frm_Balance.Show()
    End Sub

    Private Sub RepositoryItemButtonEdit43_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit43.Click
        passCustomer()
    End Sub

    Private Sub RepositoryItemButtonEdit44_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit44.Click
        DeleteCustomer()
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        log()
        Dim frm As New frm_Customer
        frm.btnUp.Enabled = False
        frm.Show()
    End Sub

    Private Sub SimpleButton2_Click_1(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        log()
        Doc_COUSTEMR.Close()
        docSeles.Show()

    End Sub

    Private Sub RibbonControl1_Click(sender As Object, e As EventArgs) Handles RibbonControl1.Click

    End Sub

    Private Sub RepositoryItemButtonEdit37_Click_1(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit37.Click
        passEmployee()
    End Sub

    Private Sub RepositoryItemButtonEdit38_Click_1(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit38.Click
        DeleteEmployee()
    End Sub

    Private Sub RepositoryItemButtonEdit46_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit46.Click
        passItem()
    End Sub

    Private Sub RepositoryItemButtonEdit47_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit47.Click
        DeleteItems()
    End Sub
    Dim SQLRED As SqlDataReader
    Dim CMD As SqlCommand
    Sub TotalAmount()
        DB.Close()
        DB.Open()
        CMD = New SqlCommand("select Amount from Tbl_Safe_Deposit_Box", DB.conn)
        SQLRED = CMD.ExecuteReader
        If SQLRED.Read Then
            TXT_AMOUNT.Text = SQLRED("Amount").ToString
        End If
        DB.Close()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        log()
        Dim frm As New frm_Employee
        frm.btnUp.Enabled = False
        frm.ShowDialog()
    End Sub

    Private Sub GroupControl9_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl9.Paint
    End Sub

    Private Sub b14_ItemClick(sender As Object, e As TileItemEventArgs) Handles b14.ItemClick
        log()
        Dim frmw As New frm_FullData
        frmw.ShowDialog()

    End Sub

    Private Sub b2_ItemClick(sender As Object, e As TileItemEventArgs) Handles b2.ItemClick
        log()
        Dim frm As New frmSettings
        frm.ShowDialog()
    End Sub

    Private Sub b15_ItemClick(sender As Object, e As TileItemEventArgs) Handles b15.ItemClick
        log()
        Dim frm As New frmAdd_User
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        log()
        DOK_ITEMS.Close()
        docSeles.Show()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        log()
        Dim fr As New frm_item
        fr.btn_up.Enabled = False
        fr.ShowDialog()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim Frm As New DialogResult
        Frm = DevExpress.XtraEditors.XtraMessageBox.Show("انت على وشك المغادره  .. تيم لينكس ؟؟ " & Environment.NewLine & Convert.ToString(Me.text_userName.Text) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            Application.ExitThread()
        End If
        If Frm = DialogResult.No Then

        End If

    End Sub

    Private Sub frm_Min_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.MaximumSizeChanged
        Exit Sub
    End Sub

 

    Private Sub frm_Min_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Exit Sub
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim Frm As New DialogResult
        Frm = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد تبديل الحساب" & Environment.NewLine & Convert.ToString(Me.text_userName.Text) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            Dim form As New frm_Logen
            form.ShowDialog()
            Me.Close()
        End If
        If Frm = DialogResult.No Then
            Exit Sub
        End If
       
       
    End Sub

   
    Private Sub Grid_ITEMS_Click(sender As Object, e As EventArgs) Handles Grid_ITEMS.Click

    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Me.Close()
    End Sub

    Private Sub TileControl1_Click(sender As Object, e As EventArgs) Handles TileControl1.Click

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Application.Exit()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim frm As New frmBACK_UP
        frm.ShowDialog()
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As TileItemEventArgs) Handles TileItem2.ItemClick
        TotalAmount()
    End Sub
End Class
