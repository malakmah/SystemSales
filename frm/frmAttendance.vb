Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class frmAttendance
    Dim cmd As New SqlCommand
    Dim da As SqlDataAdapter
    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            DB.Open()
            cmd = New SqlCommand("SQL_ADD_AttendingAndLeaving", DB.conn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Name", TXTName.Text)
            cmd.Parameters.AddWithValue("@Presence_Departure", txt_Presence_Departure.Text)
            cmd.Parameters.AddWithValue("@Condition", txt_Condition.Text)
            cmd.Parameters.AddWithValue("@Hour", txt_Hour.Text)
            cmd.Parameters.AddWithValue("@Date", TXT_Date.Text)
            cmd.ExecuteNonQuery()
            DB.Close()
            XtraMessageBox.Show("Add successfully")
            Me.txt_Hour.Text = DateTime.Now.ToString("HH:mm:ss")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txt_Hour.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub frmPresence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TXT_Date.Text = DateTime.Now.ToString("yyyy-MM-dd")
        logEmployee()
    End Sub
    Sub logEmployee()
        Dim dt = New DataTable
        da = New SqlDataAdapter("select ID, Name from Tbl_Employee", DB.conn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Dim dr As DataRow = dt.NewRow()
            dr("Name") = "--Select--"
            dr("ID") = "0"
            dt.Rows.InsertAt(dr, 0)
            TXTName.DataSource = Nothing
            Me.TXTName.DataSource = dt
            Me.TXTName.DisplayMember = "Name"
            Me.TXTName.ValueMember = "ID"
            'omUserName.Properties.Items.Add(dt)
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub
End Class