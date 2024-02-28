Imports System.Data.SqlClient, System.Data, System, SystemSales.Messages
'Imports System.Data.SqlClient
''' <summary>
'''ملاحظات هامة
''' ExecuteReader : يستخدم عند تمرير استعلام يجلب أكثر من سجل من قاعدة البيانات
'''  ExecuteNonQuery : يُستخدم عند تمرير استعلام لتعديل البيانات من إضافة إلى حذف أو تعديل وبذلك لا توجد بيانات مُعادة من قاعدة البيانات.
''' </summary>
''' 

Public Class DB
    'متغير عام مشارك نوعه نص قيمته اسم الداتا بيز
    ' Public Shared DBName As String = "StoreManagement.accdb"
    'متغير عام مشارك نوعه اتصال بالداتا بيز قيمته نص الاتصال
    ' Public Shared conn = SqlConnection("Data Source=" + +";Initial Catalog=DB_Hospital_1;Integrated Security=True;")
    Public Shared conn As New SqlConnection("Data Source=MALAK;Initial Catalog=Sales_DB;Integrated Security=True;TrustServerCertificate=True")
    'متغير عام مشارك نوعة اوامر الداتا بيز قيمته امر فارغ
    Public Shared Cmd = New SqlCommand("", conn)

    'داله عامة مشاركة لا تقوم بإرجاع قيم مهمتها فتح الداتا بيز عند استخدامها
    Public Shared Sub Open()
        Try
            'إذا كان الاتصال مغلقاً قم بعمل اتصال أي افتح الداتا بيز
            If (conn.State = ConnectionState.Closed) Then conn.Open()

            'إذا كان هناك خطأ قم بإظهارة في رسالة
        Catch ex As Exception
            MsgError(ex.Message)

        End Try

    End Sub

    'دالة عامة مشاركة مع كافة الفورمز داخل البرنامج مهمتها تقوم بإغلاق قاعدة البيانات إذا كانت مفتوحة
    Public Shared Sub Close()
        Try
            'لو كانت حالة الاتصال مفتوح قم بإغلاق الاتصال أي اغلق قاعدة البيانات 
            If (conn.State = ConnectionState.Open) Then conn.Close()
            'إذا كان هناك خطأ قم بإظهارة في رسالة
        Catch ex As Exception
            MsgError(ex.Message)
        End Try

    End Sub

    ' دالة عامة مشاركة تقوم بإرجاع قيمة نصية وهي جملة الاستعلام الذي سنقوم به لإرجاع بيانات من قاعدة البيانات
    'نوع الاستعلام هو جملة Select
    Public Shared Function GetData(Selectt As String) As DataTable
        Try
            ' الاعلان عن متغير من نوع جدول
            Dim tbl As New DataTable()
            ' تم إسناد جملة الاستعلام إلي المتغير Cmd
            'المتغير كانت فيمه الامر فارغة الان تحتوي علي جملة الاستعلام
            Cmd.CommandText = Selectt
            'قم بتحميل البيانات في الجدول الذي قمنا بالعلان عنه
            tbl.Load(Cmd.ExecuteReader())
            ' قم بارجاع قيمة البيانات التي في الجدول الذي قمنا بلإعلان عنه
            Return tbl
            'إذا كان هناك خطأ
        Catch ex As Exception
            'أظهر رسالة الخطأ
            MsgError(ex.Message)
            ' قم بإرجاع جدول جديد إي فارغ لا يحتوي علي أي شئ
            Return New DataTable()
        End Try

    End Function

    'دالة عامة مشاركة تقوم بإرجاع قيمة نصية وهي أمر يتم تنفيذه علي قاعدة البيانات مثل حذف او تحديث او اضافة
    Public Shared Sub Run(SQL As String)
        Try
            'إسناد جملة الامر إلي المتغير الذي يحتوي علي نص الاتصال وامر فارغ
            ' الأن تم إسناد الامر إلي المتغير مثال
            'Cmd = New OleDbCommand( SQL , conn)
            Cmd.CommandText = SQL
            'الان تنفيذ الامر
            Cmd.ExecuteNonQuery()
            'إذا كان هناك خطأ قم بإظهار رسالة الخطأ
        Catch ex As Exception
            MsgError(ex.Message)
        End Try

    End Sub

End Class
