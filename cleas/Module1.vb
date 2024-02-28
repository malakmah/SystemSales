Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Module Module1

    Public Sub SAVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()

        My.MySettings.Default("SkinDevExpressName") = UserLookAndFeel.Default.SkinName
        If IsVectorskin(UserLookAndFeel.Default.SkinName) Then
            My.MySettings.Default("PaletteDevExpressName") = UserLookAndFeel.Default.ActiveSvgPaletteName
        End If
        My.MySettings.Default.Save()
    End Sub

    Public Sub RETRIEVE_SKIN_HAME_PALETTE_HAME_IN_SETTINGS()

        If My.MySettings.Default("SkinDevExpressName") IsNot Nothing AndAlso My.MySettings.Default("SkinDevExpressName").ToString() <> String.Empty Then

            If IsVectorskin(My.MySettings.Default("SkinDevExpressName").ToString()) AndAlso My.MySettings.Default("PaletteDevExpressName") IsNot Nothing AndAlso My.MySettings.Default("PaletteDevExpressName").ToString() <> String.Empty Then

                UserLookAndFeel.Default.SetSkinStyle(My.MySettings.Default("SkinDevExpressName").ToString(), My.MySettings.Default("PaletteDevExpressName").ToString)
            Else
                Setskin(My.MySettings.Default("SkinDevExpressName").ToString())

            End If
        ElseIf My.MySettings.Default("PaletteDevExpressName") IsNot Nothing AndAlso My.MySettings.Default("PaletteDevExpressName").ToString() Then
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Bezier, My.MySettings.Default("PaletteDevExpressName").ToString())

        End If
    End Sub
    Public Function IsVectorskin(ByVal SkinName As String) As Boolean

        Return SkinCollectionHelper.GetSkinCategory(SkinName) = SkinCategory.SVG
    End Function

    Public Sub Setskin(ByVal SkinName As String)

        UserLookAndFeel.Default.SetSkinStyle(SkinName)

    End Sub

End Module
