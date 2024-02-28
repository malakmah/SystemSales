Imports SystemSales.DB
Imports SystemSales.Messages

Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frm_item
    Dim CMD As SqlCommand
    Private Sub LabelControl9_Click(sender As Object, e As EventArgs)




    End Sub




    Sub New()


        InitializeComponent()


        Me.txt_ITEMS_Barcode.Text = Format(Val(RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE("ITEMS_Barcode", "TB_ITEMS") + 1), "POS000000")

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txt__Prix_Vente.Text = "" Or txt_name.Text = "" Or txt_Prix_Achat.Text = "" Or txt_qunt.Text = "" Then
                XtraMessageBox.Show("الرجاء اكمال البيانات المطلوبه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Me.txt_ITEMS_Barcode.Text = Format(Val(RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE("ITEMS_Barcode", "TB_ITEMS") + 1), "POS000000")
            If txt_Prix_Achat.Text >= txt__Prix_Vente.Text Then
                MsgInformation("سعر البيع اقل من سعر الشراء")

                txt_Prix_Achat.BackColor = Color.Red
                Exit Sub
            End If
            DB.Open()
            CMD = New SqlCommand("sql_add_TB_ITEMS", DB.conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@ITEMS_Barcode", txt_ITEMS_Barcode.Text)
            CMD.Parameters.AddWithValue("@ITEMS_NAME", txt_name.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Unite", comitems.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Prix_Achat", txt_Prix_Achat.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Prix_Vente", txt__Prix_Vente.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Stock", txt_qunt.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Date_Expire", txt_Date_Expire.EditValue)

            Dim ms As New MemoryStream
            pc.Image.Save(ms, pc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            CMD.Parameters.Add(New SqlParameter("@IMage", SqlDbType.Image)).Value = picter
            CMD.ExecuteNonQuery()
            DB.Close()
            ' MsgInformation("Added successfully")
            XtraMessageBox.Show("Added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            GEY_ITEMS()
            Me.Close()

        Catch ex As Exception
            MsgError(ex.Message)
        End Try

    End Sub

    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        Try
            If txt_code.Text = "" Then
                XtraMessageBox.Show("لا يمكن تعديل هذه الصنف يجب اضافته اولاء", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub

            End If



            Me.txt_ITEMS_Barcode.Text = Format(Val(RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE("ITEMS_Barcode", "TB_ITEMS") + 1), "POS000000")
            If txt_Prix_Achat.Text >= txt__Prix_Vente.Text Then
                MsgInformation("سعر البيع اقل من سعر الشراء")

                txt_Prix_Achat.BackColor = Color.Red
                Exit Sub
            End If
            DB.Open()
            CMD = New SqlCommand("SQL_MOOD_ITEMS", DB.conn)
            CMD.CommandType = CommandType.StoredProcedure
            CMD.Parameters.AddWithValue("@ITEMS_ID", txt_code.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Barcode", txt_ITEMS_Barcode.Text)
            CMD.Parameters.AddWithValue("@ITEMS_NAME", txt_name.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Unite", comitems.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Prix_Achat", txt_Prix_Achat.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Prix_Vente", txt__Prix_Vente.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Stock", txt_qunt.Text)
            CMD.Parameters.AddWithValue("@ITEMS_Date_Expire", txt_Date_Expire.EditValue)

            Dim ms As New MemoryStream
            pc.Image.Save(ms, pc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            CMD.Parameters.Add(New SqlParameter("@IMage", SqlDbType.Image)).Value = picter
            CMD.ExecuteNonQuery()
            DB.Close()
            XtraMessageBox.Show("Added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            GEY_ITEMS()
            Me.Close()

        Catch ex As Exception
            MsgError(ex.Message)
        End Try
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs)
        Try
            DB.Open()
            CMD = New SqlCommand("SQL_DEL_Tb_Categories", DB.conn)
            CMD.CommandText = CommandType.StoredProcedure
            'CMD.Parameters.AddWithValue("@ID", TXT_ID.Text)
            CMD.ExecuteNonQuery()
            DB.Close()
        Catch ex As Exception
            MsgBox("test")
        End Try
    End Sub

    Private Sub bynpic_Click(sender As Object, e As EventArgs) Handles bynpic.Click
        OpenFileDialog1.Filter = "All Images |* .PNG ; *.JPG; *.BMP; *.TIFF; "
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            pc.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub frm_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Date_Expire.EditValue = DateTime.Now
        txt_Date_Expire.Enabled = False
    End Sub

    Public Sub GEY_ITEMS()
        DB.Open()
        frm_Main.Grid_ITEMS.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        DB.Close()
    End Sub

    Public Function RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE(Field_Name, Table_Name) As Integer
        RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE = 0
        Dim Sql = "SELECT COUNT(" & Field_Name & ") From  " & Table_Name
        Dim Adp As System.Data.SqlClient.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(Sql, DB.conn)
        Dim DS As System.Data.DataSet = New System.Data.DataSet
        Adp.Fill(DS)
        Dim DT As System.Data.DataTable
        DT = DS.Tables(0)
        If DT.Rows.Count > 0 Then
            Dim I = DT.Rows.Count - 1
            RETRIEVE_MAXIMUM_RECORD_CODE_IN_TABLE = Convert.ToInt32(DT.Rows(I).Item(0))
        End If
    End Function

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub GroupControl2_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl2.Paint

    End Sub
End Class