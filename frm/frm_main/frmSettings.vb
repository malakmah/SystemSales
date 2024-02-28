Imports DevExpress.LookAndFeel
Imports System.Data.SqlClient
Public Class frmSettings
    Dim cmd As New SqlCommand
    Sub New()
        InitializeComponent()
        ' AddHandler Me.FormClosing, AddressOf frmSettings_
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        '  DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(Me.SkinPaletteDropDownButtonIte, True, True)
    End Sub
    Protected Overrides Sub OnShown(ByVal e As EventArgs)
        MyBase.OnShown(e)
        Call RETRIEVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
        Call RETRIEVE_MIXER_FIRST_SECOND_COLOR_IN_SETTINGS()
    End Sub

    Private Sub frmSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call RETRIEVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
        Call RETRIEVE_MIXER_FIRST_SECOND_COLOR_IN_SETTINGS()
    End Sub

    Private Sub SAVE_MIXeR_FIrSt_Second_COlOr_IN_SETTINGs()
        My.Settings.SkinFirstMixerColor = UserLookAndFeel.Default.SkinMaskColor
        My.Settings.SkinSecondMixerColor = UserLookAndFeel.Default.SkinMaskColor2
        My.Settings.Save()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim Frm As New DialogResult
        Frm = DevExpress.XtraEditors.XtraMessageBox.Show("تم حفظ الثيم بنجاح  ..؟؟ " & Environment.NewLine & Convert.ToString(frm_Main.text_userName.Text) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            Call SAVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
            Call SAVE_MIXeR_FIrSt_Second_COlOr_IN_SETTINGs()
            Me.Close()
        End If
        If Frm = DialogResult.No Then
            Exit Sub

        End If


    End Sub



    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Using frm As New DevExpress.XtraEditors.ColorWheel.ColorWheelForm
            frm.StartPosition = FormStartPosition.CenterParent
            frm.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            frm.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            frm.ShowInTaskbar = False
            frm.ShowDialog(Me)
        End Using
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim Frm_Owner = Me
        Using dialog = New DevExpress.Customization.SvgSkinPaletteSelector(Frm_Owner)
            dialog.StartPosition = FormStartPosition.CenterParent
            dialog.ShowDialog()
        End Using
    End Sub
    Private Sub RETRIEVE_MIXER_FIRST_SECOND_COLOR_IN_SETTINGS()
        UserLookAndFeel.Default.SkinMaskColor = My.Settings.SkinFirstMixerColor
        UserLookAndFeel.Default.SkinMaskColor2 = My.Settings.SkinSecondMixerColor
        UserLookAndFeel.Default.UpdateStyleSettings()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub


 

  

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        frmBACK_UP.Show()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        'Dim sf As New SaveFileDialog
        'sf.Filter = "Backup Files (*.Bak) |*.bak"
        'If sf.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    cmd = New SqlCommand("Backup Database Sales_DB To Disk='" + sf.FileName + "'", DB.conn)
        '    DB.Open()
        '    cmd.ExecuteNonQuery()
        '    DB.Close()
        '    MsgBox("add")

        'End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        ' Dim cles As New classLibrary1
    End Sub
End Class