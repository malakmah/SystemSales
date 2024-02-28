<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Sales_Returns
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
        Me.grid_POS = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.grid_POS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_POS
        '
        Me.grid_POS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_POS.Location = New System.Drawing.Point(0, 0)
        Me.grid_POS.MainView = Me.GridView3
        Me.grid_POS.Name = "grid_POS"
        Me.grid_POS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit4, Me.RepositoryItemButtonEdit5, Me.RepositoryItemButtonEdit6})
        Me.grid_POS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grid_POS.Size = New System.Drawing.Size(766, 436)
        Me.grid_POS.TabIndex = 6
        Me.grid_POS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Red
        Me.GridView3.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView3.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView3.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.Appearance.Row.ForeColor = System.Drawing.Color.Blue
        Me.GridView3.Appearance.Row.Options.UseFont = True
        Me.GridView3.Appearance.Row.Options.UseForeColor = True
        Me.GridView3.Appearance.Row.Options.UseTextOptions = True
        Me.GridView3.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn32, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn30, Me.GridColumn34, Me.GridColumn1})
        Me.GridView3.GridControl = Me.grid_POS
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView3.OptionsSelection.EnableAppearanceHideSelection = False
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        '
        'GridColumn31
        '
        Me.GridColumn31.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn31.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn31.Caption = "btn_idete"
        Me.GridColumn31.ColumnEdit = Me.RepositoryItemButtonEdit4
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 0
        Me.GridColumn31.Width = 44
        '
        'RepositoryItemButtonEdit4
        '
        Me.RepositoryItemButtonEdit4.AutoHeight = False
        Me.RepositoryItemButtonEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit4.Name = "RepositoryItemButtonEdit4"
        Me.RepositoryItemButtonEdit4.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn32
        '
        Me.GridColumn32.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn32.Caption = "btn_prnt"
        Me.GridColumn32.ColumnEdit = Me.RepositoryItemButtonEdit5
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 1
        Me.GridColumn32.Width = 39
        '
        'RepositoryItemButtonEdit5
        '
        Me.RepositoryItemButtonEdit5.AutoHeight = False
        Me.RepositoryItemButtonEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit5.Name = "RepositoryItemButtonEdit5"
        Me.RepositoryItemButtonEdit5.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "الترقيم"
        Me.GridColumn23.FieldName = "POS_MASTER_Id"
        Me.GridColumn23.FieldNameSortGroup = "الكود"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        Me.GridColumn23.Width = 48
        '
        'GridColumn24
        '
        Me.GridColumn24.AccessibleName = "اسم الصنف"
        Me.GridColumn24.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn24.AppearanceCell.Options.UseFont = True
        Me.GridColumn24.Caption = "الكود"
        Me.GridColumn24.FieldName = "POS_MASTER_Code"
        Me.GridColumn24.FieldNameSortGroup = "اسم الصنف"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 3
        Me.GridColumn24.Width = 121
        '
        'GridColumn25
        '
        Me.GridColumn25.AccessibleName = "نوع الصنف"
        Me.GridColumn25.Caption = "التاريخ"
        Me.GridColumn25.FieldName = "POS_MASTER_Date"
        Me.GridColumn25.FieldNameSortGroup = "نوع الصنف"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 4
        Me.GridColumn25.Width = 107
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "التوقيت"
        Me.GridColumn26.FieldName = "POS_MASTER_Heure"
        Me.GridColumn26.FieldNameSortGroup = "سعر البيع"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 5
        Me.GridColumn26.Width = 101
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "العميل"
        Me.GridColumn27.FieldName = "POS_MASTER_Customers"
        Me.GridColumn27.FieldNameSortGroup = "سعر الشراء"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 6
        Me.GridColumn27.Width = 88
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "الكاشير"
        Me.GridColumn28.FieldName = "POS_MASTER_Username"
        Me.GridColumn28.FieldNameSortGroup = "سعر الجمله"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 7
        Me.GridColumn28.Width = 106
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "المبلغ"
        Me.GridColumn30.FieldName = "POS_MASTER_Sous_Total"
        Me.GridColumn30.FieldNameSortGroup = "بدايه الصلاحيه"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 8
        '
        'GridColumn34
        '
        Me.GridColumn34.AccessibleName = "نهايه الصلاحيه"
        Me.GridColumn34.Caption = "الخصم"
        Me.GridColumn34.FieldName = "POS_MASTER_Remises"
        Me.GridColumn34.FieldNameSortGroup = "نهايه الصلاحيه"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 9
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "الاجمالى"
        Me.GridColumn1.FieldName = "POS_MASTER_Grand_Total"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 10
        '
        'RepositoryItemButtonEdit6
        '
        Me.RepositoryItemButtonEdit6.AutoHeight = False
        Me.RepositoryItemButtonEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit6.Name = "RepositoryItemButtonEdit6"
        Me.RepositoryItemButtonEdit6.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_Sales_Returns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 436)
        Me.Controls.Add(Me.grid_POS)
        Me.Name = "frm_Sales_Returns"
        Me.Text = "frm_Sales_Returns"
        CType(Me.grid_POS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_POS As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
