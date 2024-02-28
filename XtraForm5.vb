Imports System.Threading


Public Class frm_print
    Public Declare Function SetWindowPos Lib "user32.dll" (ByVal hwnd As Int32, ByVal hWndInsertAfter As Int32, ByVal x As Int32, ByVal y As Int32, ByVal cx As Int32, ByVal cy As Int32, ByVal wFlags As Int32) As Int32

    Public Const HWND_TOPMOST = -1
    Public Const HWND_NOTOPMOST = -2
    Public Const SWP_NOSIZE = &H1
    Public Const SWP_NOMOVE = &H2
    Public Const SWP_NOACTIVATE = &H10
    Public Const SWP_SHOWWINDOW = &H40
    Private Sub frm_print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.WindowsDefaultLocation
        Me.TopMost = True
        Me.Top = 93
        'Me.Left = 195
        Me.Height = 845
        'Me.Width = 1288

        'Dim bmp As Bitmap = My.Resources.Facture
        'Me.Icon = Icon.FromHandle(bmp.GetHicon)

        'Top Most
        SetWindowPos(Handle, HWND_TOPMOST, Left / 15, Top / 15, Width / 15, Height / 15, SWP_NOACTIVATE Or SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE)

        Dim CultureInfo As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("ar")
        Thread.CurrentThread.CurrentUICulture = CultureInfo

        DocumentViewer1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ViewWholePage)
        DocumentViewer1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HandTool, New Object() {True})
        DocumentViewer1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails, New Object() {True})

    End Sub
End Class