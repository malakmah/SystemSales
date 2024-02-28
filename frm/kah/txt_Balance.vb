Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frm_Balance
    Dim cmd As New SqlCommand
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If txt_Amount.Text = "" Or Description.Text = "" Or txt_username.Text = "" Then
                XtraMessageBox.Show("الرجاء التاكد من البيانات")

                Exit Sub
            End If
            DB.Open()
            cmd = New SqlCommand("SQL_ADD_Balance", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@UserName", txt_username.Text)
            cmd.Parameters.AddWithValue("@Amount", txt_Amount.Text)
            cmd.Parameters.AddWithValue("@Description", Description.Text)
            cmd.Parameters.AddWithValue("@Date", Txt_date.Text)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("SQL_MOOD_Amount_Additions", DB.conn)
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

    Private Sub txt_Balance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd")

    End Sub
End Class