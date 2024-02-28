Imports SystemSales.DB
Imports SystemSales.Messages

Imports System.Data.SqlClient
Imports System.IO
Public Class frm_imge

    Private Sub frm_imge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Tasks.Task.Factory.StartNew(Sub() ITMS_LOG())
    End Sub

    Sub ITMS_LOG()
        Try
            DB.Open()
            Dim cmd As New SqlCommand("SELECT * FROM Tbl_Customer", DB.conn)

            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                Dim len As Long = dr.GetBytes(6, 0, Nothing, 0, 0)
                Dim Arry(CInt(len)) As Byte
                dr.GetBytes(6, 0, Arry, 0, CInt(len))
                Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream(Arry)
                Dim BMP As System.Drawing.Bitmap = New System.Drawing.Bitmap(MS)

                Me.ImageSlider1.Images.Add(BMP)
                Me.ImageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter
                Me.ImageSlider1.AnimationTime = 1200
                Me.ImageSlider1.SlideNext()

            End While
            DB.conn.Close()
            DB.Close()

        Catch ex As Exception
            MsgError(ex.Message)
        End Try
       
    End Sub

End Class
     
       