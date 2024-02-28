Public Class Messages

    Public Shared Sub MsgWarrning(Message As String)
        MessageBox.Show(Message, "رسائل التحذير",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
    End Sub

    Public Shared Sub MsgError(Message As String)
        MessageBox.Show(Message, "رسائل الاخطاء",
                        MessageBoxButtons.OK, MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
    End Sub
    Public Shared Sub MsgInformation(Message As String)
        MessageBox.Show(Message, "رسائل الاستعلامات", MessageBoxButtons.OK,
                        MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading)
    End Sub

End Class
