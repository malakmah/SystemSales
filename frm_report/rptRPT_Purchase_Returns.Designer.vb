<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptRPT_Purchase_Returns
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsRuternrptProcurement = New SystemSales.dsRuternrptProcurement()
        Me.SQL_GET_RPT_Purchase_ReturnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQL_GET_RPT_Purchase_ReturnsTableAdapter = New SystemSales.dsRuternrptProcurementTableAdapters.SQL_GET_RPT_Purchase_ReturnsTableAdapter()
        CType(Me.dsRuternrptProcurement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQL_GET_RPT_Purchase_ReturnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SQL_GET_RPT_Purchase_ReturnsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SystemSales.rpt_Returnedpu.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(527, 641)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsRuternrptProcurement
        '
        Me.dsRuternrptProcurement.DataSetName = "dsRuternrptProcurement"
        Me.dsRuternrptProcurement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SQL_GET_RPT_Purchase_ReturnsBindingSource
        '
        Me.SQL_GET_RPT_Purchase_ReturnsBindingSource.DataMember = "SQL_GET_RPT_Purchase_Returns"
        Me.SQL_GET_RPT_Purchase_ReturnsBindingSource.DataSource = Me.dsRuternrptProcurement
        '
        'SQL_GET_RPT_Purchase_ReturnsTableAdapter
        '
        Me.SQL_GET_RPT_Purchase_ReturnsTableAdapter.ClearBeforeFill = True
        '
        'rptRPT_Purchase_Returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 641)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptRPT_Purchase_Returns"
        Me.Text = "rptRPT_Purchase_Returns"
        CType(Me.dsRuternrptProcurement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQL_GET_RPT_Purchase_ReturnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SQL_GET_RPT_Purchase_ReturnsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRuternrptProcurement As SystemSales.dsRuternrptProcurement
    Friend WithEvents SQL_GET_RPT_Purchase_ReturnsTableAdapter As SystemSales.dsRuternrptProcurementTableAdapters.SQL_GET_RPT_Purchase_ReturnsTableAdapter
End Class
