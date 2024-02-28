Imports System.Data.SqlClient
Imports System.Text

Module Main_Mod
    Public TempFileNames2 As String
    Public Function Max_ID(TableName As String, ColumnName As String)
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(" & ColumnName & ") From " & TableName & " ", DB.conn)
            If DB.conn.State = 1 Then DB.Close()
            DB.Open()
            Number = cmd.ExecuteScalar
            DB.Close()
        Catch ex As Exception
            Number = 0
            DB.Close()
        End Try
        Return Number
    End Function

    Public Sub fillcmb_Cat_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Cat_Tbl ", DB.conn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "CatName"
            cmb.ValueMember = "Cat_ID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub fillcmb_Unit_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Unit_Tbl ", DB.conn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "UnitName"
            cmb.ValueMember = "Unit_ID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub ChoosePicture(Pbox As PictureBox)
        Dim a As New OpenFileDialog
        With a
            .AddExtension = True
            .CheckPathExists = True
            .CheckFileExists = True
            .Title = "Choose Image"
            .Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG)| *.PNG; *.JPG; *.GIF; *.JPEG | All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Pbox.Image = Image.FromFile(.FileName)
            End If
        End With
    End Sub
    Public Enum AnimateWindowFlags
        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000
    End Enum
    Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean
    Sub animateWin(ByVal frmToAnimate As Form, ByVal showForm As Boolean)
        If showForm Then
            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 1000, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_HIDE)
        End If
    End Sub



    Public Function Encrypt(password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
End Module
