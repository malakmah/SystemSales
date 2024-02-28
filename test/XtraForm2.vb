Imports DevExpress.LookAndFeel

Public Class XtraForm2

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Using FRM As New DevExpress.XtraEditors.ColorWheel.ColorWheelForm
            FRM.StartPosition = FormStartPosition.CenterParent
            FRM.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            FRM.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            FRM.ShowInTaskbar = False
            FRM.ShowDialog(Me)

        End Using
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim frm_Owner = Me
        Using diaog = New DevExpress.Customization.SvgSkinPaletteSelector(frm_Owner)
            diaog.StartPosition = FormStartPosition.CenterParent
            diaog.ShowDialog()

        End Using
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim Frm As New DialogResult
        ' Frm = DevExpress.XtraEditors.XtraMessageBox.Show(" تمت بنجاح عملية حفظ فاتورة المبيعات رقم  .. هل تريد المواصلة و طباعة وصل تسليم المنتجات  ؟؟ " & Environment.NewLine & Convert.ToString(Me.TxtFacturePosCode.Text.Trim) & " ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Frm = DialogResult.Yes Then
            Call SAVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
            Call RETRIEVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()
            Application.ExitThread()
        Else

        End If
    End Sub
End Class