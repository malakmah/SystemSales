Public Class frm_Welcom

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar2.Value <> 100 And Me.Opacity <> 100 Then
            ProgressBar2.Value += 2
            Me.Opacity += 2 / 100
        End If
        If ProgressBar2.Value = 100 Then
            Timer1.Enabled = False

            frm_Main.Show()
            ' frmSettings.Show()
            Me.Hide()
        End If
        If ProgressBar2.Value = 30 Then

            Label4.Text = "" & "جاري تحميــــــــــــــــل البيانات..............."
        ElseIf ProgressBar2.Value = 60 Then
            Label4.Text = "تم تحميل البيانات بنجاح " & vbNewLine & "جاري تجهيز البرنامج ................"
        ElseIf ProgressBar2.Value = 90 Then
            Label4.Text = "تم تجهيز البرنامج بنجاح اهلا بيك"
        End If

        Label7.Text = ProgressBar2.Value & " %"

        Label5.Text = ProgressBar2.Value & " %"

    End Sub

    Private Sub XtraForm10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Close()
        DB.Open()
        frm_Main.grid_Supplir.DataSource = DB.GetData("SQL_GET_Supplir")
        frm_Main.gvd_Customer.DataSource = DB.GetData("SQL_GET_Customer")
        frm_Main.Grid_ITEMS.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        frm_Main.grvd_Employee.DataSource = DB.GetData("SQL_GET_Employee")
        frm_Main.GridControl2.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
        'frm_FullData.GridControl1.DataSource = DB.GetData("SQL_GET_Customer")
        'frm_FullData.GridControl2.DataSource = DB.GetData("SQL_GET_Employee")
        'frm_FullData.GridControl3.DataSource = DB.GetData("SQL_GET_Supplir")
        'frm_FullData.grid_POS.DataSource = DB.GetData("SQL_GET_POS_MASTER")
        'frm_FullData.GridControl4.DataSource = DB.GetData("SQL_GET_TB_ITEMS")
       
        DB.Close()
    End Sub
   
    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub picmalak_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class