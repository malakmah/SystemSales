Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frm_Expnses
    Dim cmd = New SqlCommand

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbl.Visible = False Then
            lbl.Visible = True
        ElseIf lbl.Visible = True Then
            lbl.Visible = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txt_Amount.Text = "" Or Description.Text = "" Or txt_username.Text = "" Then
                XtraMessageBox.Show("الرجاء التاكد من البيانات")

                Exit Sub
            End If
            DB.Open()
            cmd = New SqlCommand("Sql_add_TBL_Expenses", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", txt_username.Text)
            cmd.Parameters.AddWithValue("@Amount", txt_Amount.Text)
            cmd.Parameters.AddWithValue("@Description", Description.Text)
            cmd.Parameters.AddWithValue("@Date", Txt_date.Text)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("SQL_MOOD_Expenses", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Amount", txt_Amount.Text)
            cmd.ExecuteNonQuery()
            DB.Close()

            XtraMessageBox.Show("Add successfully")
            Me.Txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frm_Expnses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = frm_Main.text_userName.Text
        Me.Txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub Description_TextChanged(sender As Object, e As EventArgs) Handles Description.TextChanged

    End Sub
End Class