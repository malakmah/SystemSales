Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frm_Employee
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False
    Dim cmd As SqlCommand
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Try
            If TXT_ADDER.Text = "" Or TXT_NAME.Text = "" Or TXT_PON.Text = "" Then
                XtraMessageBox.Show("الرجاء اكمال البيانات المطلوبه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            'جزء الاضافه
            'فتح الاتصال 
            DB.Open()
            ' SqlCommand  يسمح لى باضفه اسنور بروسيجر
            cmd = New SqlCommand("SQL_ADD_Employee", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.AddWithValue("@ID", TXT_ID.Text)
            cmd.Parameters.AddWithValue("@Name", TXT_NAME.Text)
            cmd.Parameters.AddWithValue("@Address", TXT_ADDER.Text)
            cmd.Parameters.AddWithValue("@Phone", TXT_PON.Text)
            cmd.Parameters.AddWithValue("@EmployeeType", GR_Type.Text)
            cmd.Parameters.AddWithValue("@date", TXT_DATE.EditValue)
            Dim ms As New MemoryStream
            buc.Image.Save(ms, buc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            cmd.Parameters.Add(New SqlParameter("@image", SqlDbType.Image)).Value = picter '''''    
            cmd.ExecuteNonQuery()
            'MsgInformation("Modified successfully")
            Dim Frm As New DialogResult

            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" تمت بنجاح عملية حفظ الموظف  .. هل تريد المواصلة و الموظف مورد جديد  ؟؟ " & Environment.NewLine & Convert.ToString(Me.TXT_NAME.Text.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                clertext()
            End If
            If Frm = DialogResult.No Then
                Me.Close()   ''''''''قفل الاتصال
            End If
            DB.Close()
            GET_SQL_GET_Employee()        ''''''''GET بتراجع البيانات من جدول العملاء
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub clertext()
        TXT_ID.Text = ""
        TXT_ADDER.Text = ""
        TXT_NAME.Text = ""
        TXT_PON.Text = ""
        buc.Text = ""
    End Sub

    Private Sub frm_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GR_Type.Properties.Items.Add("Admin")
        GR_Type.Properties.Items.Add("User")

        TXT_DATE.EditValue = DateTime.Now

    End Sub



    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Try
            If TXT_ADDER.Text = "" Or TXT_NAME.Text = "" Or TXT_PON.Text = "" Then
                XtraMessageBox.Show("الرجاء اكمال البيانات المطلوبه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            DB.Open()
            cmd = New SqlCommand("SQL_MOD_Employee", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@ID", TXT_ID.Text)
            cmd.Parameters.AddWithValue("Name", TXT_NAME.Text)
            cmd.Parameters.AddWithValue("@Address", TXT_ADDER.Text)
            cmd.Parameters.AddWithValue("@Phone", TXT_PON.Text)
            cmd.Parameters.AddWithValue("@EmployeeType", GR_Type.Text)
            cmd.Parameters.AddWithValue("@date", TXT_DATE.EditValue)
            Dim ms As New MemoryStream
            buc.Image.Save(ms, buc.Image.RawFormat)
            Dim picter() As Byte = ms.ToArray
            cmd.Parameters.Add(New SqlParameter("@image", SqlDbType.Image)).Value = picter
            cmd.ExecuteNonQuery()
            'MsgInformation("Modified successfully")
            Dim Frm As New DialogResult
            Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" تمت بنجاح عملية حفظ الموظف  .. هل تريد المواصلة و الموظف مورد جديد  ؟؟ " & Environment.NewLine & Convert.ToString(Me.TXT_NAME.Text.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Frm = DialogResult.Yes Then
                clertext()
            End If
            If Frm = DialogResult.No Then
                Me.Close()
            End If
            DB.Close()
            GET_SQL_GET_Employee()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub GET_SQL_GET_Employee()
        DB.Close()
        DB.Open()
        frm_Main.grvd_Employee.DataSource = DB.GetData("SQL_GET_Employee")
        DB.Close()

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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim k As New Frm_Camera
        k.ShowDialog()
        If TempFileNames2.Length > 0 Then

            buc.Image = Image.FromFile(TempFileNames2)
            Photoname = TempFileNames2
            IsImageChanged = True
        End If
    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub buc_EditValueChanged(sender As Object, e As EventArgs) Handles buc.EditValueChanged

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        OpenFileDialog1.Filter = "All Images |* .PNG ; *.JPG; *.BMP"
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            buc.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class