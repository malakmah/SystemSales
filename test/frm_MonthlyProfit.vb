Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation

Partial Public Class frm_MonthlyProfit

    Private employeesUserControl As XtraUserControl
    Private customersUserControl As XtraUserControl
    Public Sub New()
        InitializeComponent()
        'employeesUserControl = CreateUserControl("Employees")
        'customersUserControl = CreateUserControl("Customers")
        ' accordionControl.SelectedElement = employeesAccordionControlElement
    End Sub
 

    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs)
        DOCPL.Show()
    End Sub

    Private Sub frm_MonthlyProfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB.Close()
        DB.Open()
        gvd_All_Purchase.DataSource = DB.GetData("SQL_GET_Returns_Procurement")
        DB.Close()
    End Sub

    Private Sub ribbonControl_Click(sender As Object, e As EventArgs) Handles ribbonControl.Click

    End Sub
End Class
