Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Public Class frmRequestPassword
    Dim cmd As New SqlCommand

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        DB.conn.Open()
        cmd = New SqlCommand("RESTPASSORD", DB.conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NAME", TxtCode.Text)
        cmd.ExecuteNonQuery()

        XtraMessageBox.Show(".......تم ارسال الباسورد|\\==>//| يرجى الانتظار .......")
        DB.Close()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
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