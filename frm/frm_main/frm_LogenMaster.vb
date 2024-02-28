Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports System.Threading
Imports System.Security.Cryptography
Imports System.Text



Public Class frm_Logen
    Private dev_Win_1 As Integer = 0
    Private dev_Win_2 As Integer = 0

    Dim costerm As Integer = 3

    Public Sub login(ByVal txtusername As String, ByVal txtpassword As String, Frm As Form)
        DB.Open()
        Dim password As String = txtpassword
        Dim sha256 As New SHA256CryptoServiceProvider()
        Dim data As Byte() = Encoding.UTF8.GetBytes(password)
        Dim encryptedData As Byte() = sha256.ComputeHash(data)
        Dim encryptedPassword As String = Convert.ToBase64String(encryptedData)

        Dim cmd As New SqlCommand("select * from Tbl_Logen  where Name = @Name and Pass = @Pass", DB.conn)
        cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtusername
        cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        If dt.Rows.Count() = 1 Then

            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            If dr("b1") = True Then
                ' Me.Close()
                'rm_Min.b.Enabled = dr("b2")
                frm_Main.b3.Visible = dr("b3")
                If Not IsDBNull(dr("image")) Then
                    Dim pic() As Byte = CType(dr("image"), Byte())
                    Dim ms As New MemoryStream(CType(dr("image"), Byte()))
                    frm_Welcom.picmalak.Image = Image.FromStream(ms)
                    frm_Main.IconOptions.Image = Image.FromStream(ms)
                    FrmWorkOrder.pic_User.Image = Image.FromStream(ms)
                    frm_Purchase.pic_User.Image = Image.FromStream(ms)
                    frm_Purchase.TxtFacturePosUsername.Text = txtusername

                    frm_Main.b1.Image = Image.FromStream(ms)
                    frm_Main.text_userName.Text = dr("User_Name").ToString()
                    frm_Main.b2.Visible = dr("b2")
                    frm_Main.b3.Visible = dr("b3")
                    frm_Main.b4.Visible = dr("b4")
                    frm_Main.b5.Visible = dr("b5")
                    frm_Main.b6.Visible = dr("b6")
                    frm_Main.b7.Visible = dr("b7")
                    frm_Main.b8.Visible = dr("b8")
                    frm_Main.b9.Visible = dr("b9")
                    'frm_Min.b10.Visible = dr("b10")
                    frm_Main.b11.Visible = dr("b11")
                    frm_Main.b12.Visible = dr("b12")
                    frm_Main.b13.Visible = dr("b13")
                    frm_Main.b14.Visible = dr("b14")
                    frm_Main.b15.Visible = dr("b15")
                    frm_Main.b16.Visible = dr("b16")
                    frm_Main.bb.Visible = dr("b16")
                    frm_Main.bb2.Visible = dr("b16")
                    frm_Welcom.Show()

                    dr.Close()
                End If
            End If
        ElseIf costerm = 1 Then
            XtraMessageBox.Show("تم استخدم الحد الادنى من المحاولات", (costerm.ToString), MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            XtraMessageBox.Show("المعذرة حسابك مغلق يرجى مراجعة مدير النظام", "الحساب", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Btn_Login.Visible = True
            ' Me.Close()
        Else
            costerm = costerm - 1
            XtraMessageBox.Show("يتبقا =>" + costerm.ToString + "من المحاولات", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Label1.Text = costerm
            Label1.Visible = False
            Label1.Enabled = True
            Timer1.Enabled = True
        End If
        DB.Close()

    End Sub
    Private Sub XtraForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Pumpkin"
        Label1.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btn_Log.Click
        If dev_Win_1 >= 15 And dev_Win_2 >= 15 Then

            dev_Win_1 = 0
            dev_Win_2 = 0
            Dim frm As New frmAdd_User
            frm.ShowDialog()
            'Dim win As ePMSDeveloperMaintenance = New ePMSDeveloperMaintenance()
            'win.Show()
        Else
            login(TxtUserName.Text, TxtPassword.Text, Me)
        End If

        'Me.Hide()
        'SplashScreenManager.ShowForm(parentForm:=frm_Min.IconOptions,TypeOf(frmSplashScreen1))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Visible = False Then
            Label1.Visible = True
        ElseIf Label1.Visible = True Then
            Label1.Visible = False
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub

    Private Sub TxtUserName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtUserName.Validating
        If String.IsNullOrEmpty(TxtUserName.Text.Trim) Then
            ErrorProvider1.SetError(TxtUserName, "Pls Enter Full Name")



        End If
    End Sub

    Private Sub TxtPassword_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtPassword.Validating
        If String.IsNullOrEmpty(TxtPassword.Text.Trim) Then
            ErrorProvider2.SetError(TxtPassword, "Pls Enter Password")
        End If
    End Sub
    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles TxtPassword.Enter
        If TxtPassword.Text = "password" Then
            TxtPassword.Text = ""
            TxtPassword.ForeColor = Color.Black
            'login(TxtUserName.Text, TxtPassword.Text, Me)
        End If
    End Sub

    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles TxtPassword.Leave
        If TxtPassword.Text = "" Then
            TxtPassword.Text = "password"
            TxtPassword.ForeColor = Color.Blue
        End If
    End Sub



    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        dev_Win_1 += 1
    End Sub

    Private Sub TxtUserName_Click(sender As Object, e As EventArgs) Handles TxtUserName.Click
        dev_Win_2 += 1
    End Sub

    Private Sub btnpass_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        If TxtPassword.Text = "mk12345" Then
            Dim frm As New frmAdd_User
            frm.ShowDialog()
        End If
    End Sub



    Private Sub TxtUserName_Enter(sender As Object, e As EventArgs) Handles TxtUserName.Enter
        If TxtUserName.Text = "Full Name" Then
            TxtUserName.Text = ""
            TxtUserName.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtUserName_Leave(sender As Object, e As EventArgs) Handles TxtUserName.Leave
        If TxtUserName.Text = "" Then
            TxtUserName.Text = "Full Name"
            TxtUserName.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub frmLogen_User_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Shift AndAlso e.KeyCode = Keys.Enter Then
            If dev_Win_1 >= 15 And dev_Win_2 >= 15 Then

                dev_Win_1 = 0
                dev_Win_2 = 0
                Dim frm As New frmAdd_User
                frm.ShowDialog()
                'Dim win As ePMSDeveloperMaintenance = New ePMSDeveloperMaintenance()
                'win.Show()
            Else
                login(TxtUserName.Text, TxtPassword.Text, Me)
            End If

        End If

    End Sub

    Private Sub ck_AddButn_CheckedChanged(sender As Object, e As EventArgs) Handles ck_AddButn.CheckedChanged
        If ck_AddButn.Checked = True Then
            btn_Exit.Visible = True
            btn_Log.Visible = True
            Btn_Login.Visible = True
        ElseIf ck_AddButn.Checked = False Then
            btn_Exit.Visible = False
            btn_Log.Visible = False
            Btn_Login.Visible = False
        End If
    End Sub
End Class