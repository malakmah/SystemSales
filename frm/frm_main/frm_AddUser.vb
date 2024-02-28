Imports System.Data.SqlClient
Imports SystemSales.DB
Imports System.IO
Imports System.Text
Imports DevExpress.XtraEditors

Public Class frmAdd_User
    Dim Cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub XtraForm9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DevExpress.Skins.SkinManager.EnableFormSkins()
        'DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Pumpkin"
        log_grig()
        logUser()
    End Sub
    Sub log_grig()
        DB.Open()
        dvg_user.DataSource = DB.GetData("SQL_GET_USERLOGEN")
        DataGridView1.DataSource = DB.GetData("SQL_GET_USERLOGEN")

        DB.Close()
    End Sub

    Private Sub frmAdd_User_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim Frm As New DialogResult
        Frm = XtraMessageBox.Show("هل تريد فعلا الخروج من الصفحة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            animateWin(Me, False)
            DB.Close()
            Me.Dispose()
        End If
        If Frm = DialogResult.No Then
            Exit Sub
        End If
    End Sub

   

   

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        OpenFileDialog1.Filter = "All Images |* .PNG ; *.JPG; *.BMP"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            buc.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs)


    End Sub
    Sub logUser()

        da = New SqlDataAdapter("select ID, Name from Tbl_Employee", DB.conn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.NewRow()
            dr("Name") = "--Select--"
            dr("ID") = "0"
            dt.Rows.InsertAt(dr, 0)
            cob_UserName.DataSource = Nothing
            Me.cob_UserName.DataSource = dt
            Me.cob_UserName.DisplayMember = "Name"
            Me.cob_UserName.ValueMember = "ID"
            'omUserName.Properties.Items.Add(dt)
        End If
    End Sub



    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txt_FirstName.Text = "" Or txt_paas.Text = "" Or cob_UserName.Text = "" Then
                XtraMessageBox.Show("الرجاء اكمال البيانات المطلوبه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            For i As Integer = 0 To DataGridView1.RowCount - 1
                If cob_UserName.Text = DataGridView1.Rows(i).Cells(1).Value Then

                    XtraMessageBox.Show("المستخدم مسجل بلفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

            Next
            For i As Integer = 0 To DataGridView1.RowCount - 1
                If txt_FirstName.Text = DataGridView1.Rows(i).Cells(2).Value Then

                    XtraMessageBox.Show("المستخدم مسجل بلفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Next
            DB.Open()
            Cmd = New SqlCommand("sql_add_Userlogen", DB.conn)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@User_Name", cob_UserName.Text)
            Cmd.Parameters.AddWithValue("@Name", txt_FirstName.Text)
            Cmd.Parameters.AddWithValue("@Pass", Main_Mod.Encrypt(txt_paas.Text.Trim))
            Cmd.Parameters.AddWithValue("@b1", b1.Checked)
            Cmd.Parameters.AddWithValue("@b2", b2.Checked)
            Cmd.Parameters.AddWithValue("@b3", b3.Checked)
            Cmd.Parameters.AddWithValue("@b4", b4.Checked)
            Cmd.Parameters.AddWithValue("@b5", b5.Checked)
            Cmd.Parameters.AddWithValue("@b6", b6.Checked)
            Cmd.Parameters.AddWithValue("@b7", b7.Checked)
            Cmd.Parameters.AddWithValue("@b8", b8.Checked)
            Cmd.Parameters.AddWithValue("@b9", b9.Checked)
            Cmd.Parameters.AddWithValue("@b10", b10.Checked)
            Cmd.Parameters.AddWithValue("@b11", b11.Checked)
            Cmd.Parameters.AddWithValue("@b12", b12.Checked)
            Cmd.Parameters.AddWithValue("@b13", b13.Checked)
            Cmd.Parameters.AddWithValue("@b14", b14.Checked)
            Cmd.Parameters.AddWithValue("@b15", b15.Checked)
            Cmd.Parameters.AddWithValue("@b16", b16.Checked)
            Dim ms As New MemoryStream
            buc.Image.Save(ms, buc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            Cmd.Parameters.Add(New SqlParameter("@image", SqlDbType.Image)).Value = picter
            Cmd.ExecuteNonQuery()
            XtraMessageBox.Show("Add successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            DB.Close()
            log_grig()
            log_grig()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            'If txt_FirstName.Text = "" Or txt_paas.Text = "" Or cob_UserName.Text = "" Then
            '    XtraMessageBox.Show("الرجاء اكمال البيانات المطلوبه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    Exit Sub
            'End If

            'For i As Integer = 0 To DataGridView1.RowCount - 1
            '    If txt_FirstName.Text = DataGridView1.Rows(i).Cells(2).Value Then

            '        XtraMessageBox.Show("المستخدم مسجل بلفعل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        Exit Sub
            '    End If
            'Next
            DB.Open()
            Cmd = New SqlCommand("SQL_MOD_User_Logen", DB.conn)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", txt_code.Text)
            Cmd.Parameters.AddWithValue("@User_Name", cob_UserName.Text)
            Cmd.Parameters.AddWithValue("@Name", txt_FirstName.Text)
            Cmd.Parameters.AddWithValue("@Pass", Main_Mod.Encrypt(txt_paas.Text.Trim))
            Cmd.Parameters.AddWithValue("@b1", b1.Checked)
            Cmd.Parameters.AddWithValue("@b2", b2.Checked)
            Cmd.Parameters.AddWithValue("@b3", b3.Checked)
            Cmd.Parameters.AddWithValue("@b4", b4.Checked)
            Cmd.Parameters.AddWithValue("@b5", b5.Checked)
            Cmd.Parameters.AddWithValue("@b6", b6.Checked)
            Cmd.Parameters.AddWithValue("@b7", b7.Checked)
            Cmd.Parameters.AddWithValue("@b8", b8.Checked)
            Cmd.Parameters.AddWithValue("@b9", b9.Checked)
            Cmd.Parameters.AddWithValue("@b10", b10.Checked)
            Cmd.Parameters.AddWithValue("@b11", b11.Checked)
            Cmd.Parameters.AddWithValue("@b12", b12.Checked)
            Cmd.Parameters.AddWithValue("@b13", b13.Checked)
            Cmd.Parameters.AddWithValue("@b14", b14.Checked)
            Cmd.Parameters.AddWithValue("@b15", b15.Checked)
            Cmd.Parameters.AddWithValue("@b16", b16.Checked)
            Dim ms As New MemoryStream
            buc.Image.Save(ms, buc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            Cmd.Parameters.Add(New SqlParameter("@image", SqlDbType.Image)).Value = picter
            Cmd.ExecuteNonQuery()
            DB.Close()
            log_grig()
            XtraMessageBox.Show("Add successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAll.CheckedChanged
        If CheckAll.Checked = True Then
            b1.Checked = True
            b2.Checked = True
            b3.Checked = True
            b4.Checked = True
            b5.Checked = True
            b6.Checked = True
            b7.Checked = True
            b8.Checked = True
            b9.Checked = True
            b10.Checked = True
            b11.Checked = True
            b12.Checked = True
            b13.Checked = True
            b14.Checked = True
            b15.Checked = True
            b16.Checked = True
        ElseIf CheckAll.Checked = False Then
            b1.Checked = False
            b2.Checked = False
            b3.Checked = False
            b4.Checked = False
            b5.Checked = False
            b6.Checked = False
            b7.Checked = False
            b8.Checked = False
            b9.Checked = False
            b10.Checked = False
            b11.Checked = False
            b12.Checked = False
            b13.Checked = False
            b14.Checked = False
            b15.Checked = False
            b16.Checked = False

        End If
    End Sub

    Private Sub cob_UserName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cob_UserName.SelectedIndexChanged
        txt_FirstName.Text = ""
        txt_paas.Text = ""
    End Sub

    Private Sub buc_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RepositoryItemButtonEdit37_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonEdit37.Click
        Me.txt_code.Text = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الكود").ToString
        Me.cob_UserName.Text = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الاسم كامل").ToString
        Me.txt_FirstName.Text = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الاسم").ToString
        Me.txt_paas.Text = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الباسورد").ToString
        Dim logo_Byts As [Byte]()
        logo_Byts = Me.dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الصوره")
        Dim Ms_Stream As New MemoryStream(logo_Byts, True)
        Dim isimage As System.Drawing.Image = New Bitmap(Ms_Stream)
        Me.buc.Image = isimage
        Me.buc.BackgroundImageLayout = ImageLayout.Stretch

        Me.b1.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "قسم المبيعات").ToString
        Me.b2.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الاعدادت").ToString
        Me.b3.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الاصناف").ToString
        Me.b4.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "العملاء").ToString
        Me.b5.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الموردين").ToString
        Me.b6.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الموظفين").ToString
        Me.b7.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الخزينه").ToString
        Me.b8.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "المصروفات").ToString
        Me.b9.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "فاتوره بيع").ToString
        Me.b10.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "فاتوره مشتريات").ToString
        Me.b11.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "مرتجع مشتريات").ToString
        Me.b12.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "مرتجع مبيعات").ToString
        Me.b13.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "بيان اسعار").ToString
        Me.b14.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "حضور وانصراف").ToString
        Me.b15.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "الاحصيات").ToString
        Me.b16.Checked = dvg_userA.GetRowCellValue(dvg_userA.FocusedRowHandle, "دفع نقدى").ToString
    End Sub
    Public Function Encrypt(password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
           
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show("هل تريد حقا حذف العميل المحدد  " & Environment.NewLine & Convert.ToString(Me.txt_FirstName.Text.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                DB.Open()
                Cmd = New SqlCommand("SQL_DEL_ADD_USER", DB.conn)
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Parameters.AddWithValue("@Code", txt_code.Text)
                Cmd.ExecuteNonQuery()
                XtraMessageBox.Show("Deletet successfully", "Deletet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                log_grig()
                txt_FirstName.Text = ""
                txt_paas.Text = ""
            End If
            If Frm = DialogResult.No Then
                Exit Sub
            End If
            DB.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        '    Dim Frm As New DialogResult
        '    Frm = XtraMessageBox.Show("هل تريد فعلا الخروج من الصفحة ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        '    If Frm = DialogResult.Yes Then
        '        animateWin(Me, False)
        '        DB.Close()
        '        Me.Dispose()
        '    End If
        '    If Frm = DialogResult.No Then
        '        Exit Sub
        '    End If
        Me.Close()
    End Sub
End Class