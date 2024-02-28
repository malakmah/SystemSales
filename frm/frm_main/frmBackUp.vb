
Imports System.Data.SqlClient
Public Class frmBACK_UP
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server("DESKTOP-NR9B9G1\SQLEXPRESS")
    End Sub

    Sub server(ByVal str As String)
        DB.conn = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        DB.Open()
        cmd = New SqlCommand("SELECT * FROM sysservers where srvproduct='SQL Server'", DB.conn)
        dread = cmd.ExecuteReader()
        While dread.Read
            CMBServer.Items.Add(dread(2))
        End While
        dread.Close()
    End Sub

    Sub connection()
        DB.conn = New SqlConnection("Data Source=" & Trim(CMBServer.Text) & ";Database=Master;integrated security=SSPI;")
        DB.Open()
        CMBDatabase.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM sysdatabases", DB.conn)
        dread = cmd.ExecuteReader()
        While dread.Read
            CMBDatabase.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Private Sub CMBServer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBServer.SelectedIndexChanged
        connection()
    End Sub

    Sub query(ByVal que As String)
        On Error Resume Next
        DB.Close()
        DB.Open()

        cmd = New SqlCommand(que, DB.conn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("Successfully Done")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

    Sub blank(ByVal str As String)
        If CMBServer.Text = "" Or CMBDatabase.Text = "" Then
            MsgBox("Server name and database Blank Field")
            Exit Sub
        Else
            If str = "backup" Then
                SaveFileDialog1.FileName = CMBDatabase.Text
                SaveFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                Dim save As String
                save = SaveFileDialog1.FileName
                query("backup database " & CMBDatabase.Text & " to disk='" & save & "'")
            ElseIf str = "restore" Then
                OpenFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                query("restore database " & CMBDatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
            End If
        End If
    End Sub

    Private Sub ButtonBACKUP_Click(sender As Object, e As EventArgs) Handles ButtonBACKUP.Click
        blank("backup")
    End Sub

    Private Sub ButtonRESTORE_Click(sender As Object, e As EventArgs) Handles ButtonRESTORE.Click
        blank("restore")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
