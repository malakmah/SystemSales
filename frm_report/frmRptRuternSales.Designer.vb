<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptRuternSales
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SQL_GET_RPT_Returns_SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRuternSales = New SystemSales.dsRuternSales()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SQL_GET_RPT_Returns_SalesTableAdapter = New SystemSales.dsRuternSalesTableAdapters.SQL_GET_RPT_Returns_SalesTableAdapter()
        CType(Me.SQL_GET_RPT_Returns_SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRuternSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SQL_GET_RPT_Returns_SalesBindingSource
        '
        Me.SQL_GET_RPT_Returns_SalesBindingSource.DataMember = "SQL_GET_RPT_Returns_Sales"
        Me.SQL_GET_RPT_Returns_SalesBindingSource.DataSource = Me.dsRuternSales
        '
        'dsRuternSales
        '
        Me.dsRuternSales.DataSetName = "dsRuternSales"
        Me.dsRuternSales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SQL_GET_RPT_Returns_SalesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SystemSales.rpt_ReturnedSales.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(513, 635)
        Me.ReportViewer1.TabIndex = 0
        '
        'SQL_GET_RPT_Returns_SalesTableAdapter
        '
        Me.SQL_GET_RPT_Returns_SalesTableAdapter.ClearBeforeFill = True
        '
        'frmRptRuternSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 635)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRptRuternSales"
        Me.Text = "frmRptRuternSales"
        CType(Me.SQL_GET_RPT_Returns_SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRuternSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SQL_GET_RPT_Returns_SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRuternSales As SystemSales.dsRuternSales
    Friend WithEvents SQL_GET_RPT_Returns_SalesTableAdapter As SystemSales.dsRuternSalesTableAdapters.SQL_GET_RPT_Returns_SalesTableAdapter
End Class
