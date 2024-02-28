<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_Procurement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report_Procurement))
        Me.SQL_GET_RPT_ProcurementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsProcurement = New SystemSales.dsProcurement()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SQL_GET_RPT_ProcurementTableAdapter = New SystemSales.dsProcurementTableAdapters.SQL_GET_RPT_ProcurementTableAdapter()
        CType(Me.SQL_GET_RPT_ProcurementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsProcurement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SQL_GET_RPT_ProcurementBindingSource
        '
        Me.SQL_GET_RPT_ProcurementBindingSource.DataMember = "SQL_GET_RPT_Procurement"
        Me.SQL_GET_RPT_ProcurementBindingSource.DataSource = Me.dsProcurement
        '
        'dsProcurement
        '
        Me.dsProcurement.DataSetName = "dsProcurement"
        Me.dsProcurement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SQL_GET_RPT_ProcurementBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SystemSales.rp_Procurement.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(527, 641)
        Me.ReportViewer1.TabIndex = 0
        '
        'SQL_GET_RPT_ProcurementTableAdapter
        '
        Me.SQL_GET_RPT_ProcurementTableAdapter.ClearBeforeFill = True
        '
        'frm_report_Procurement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 641)
        Me.Controls.Add(Me.ReportViewer1)
        Me.IconOptions.SvgImage = CType(resources.GetObject("frm_report_Procurement.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.Name = "frm_report_Procurement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SQL_GET_RPT_ProcurementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsProcurement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SQL_GET_RPT_ProcurementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsProcurement As SystemSales.dsProcurement
    Friend WithEvents SQL_GET_RPT_ProcurementTableAdapter As SystemSales.dsProcurementTableAdapters.SQL_GET_RPT_ProcurementTableAdapter
End Class
