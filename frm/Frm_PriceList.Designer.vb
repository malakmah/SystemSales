<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PriceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_PriceList))
        Me.RepositoryItemButtonEdit34 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit35 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit36 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Grid_grid_Pirse = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_Pirse = New DevExpress.XtraGrid.GridControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemButtonEdit34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_grid_Pirse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_Pirse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemButtonEdit34
        '
        Me.RepositoryItemButtonEdit34.AutoHeight = False
        Me.RepositoryItemButtonEdit34.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit34.Name = "RepositoryItemButtonEdit34"
        Me.RepositoryItemButtonEdit34.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemButtonEdit35
        '
        Me.RepositoryItemButtonEdit35.AutoHeight = False
        Me.RepositoryItemButtonEdit35.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit35.Name = "RepositoryItemButtonEdit35"
        Me.RepositoryItemButtonEdit35.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemButtonEdit36
        '
        Me.RepositoryItemButtonEdit36.AutoHeight = False
        Me.RepositoryItemButtonEdit36.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit36.Name = "RepositoryItemButtonEdit36"
        Me.RepositoryItemButtonEdit36.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Grid_grid_Pirse
        '
        Me.Grid_grid_Pirse.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Grid_grid_Pirse.Appearance.HeaderPanel.Options.UseFont = True
        Me.Grid_grid_Pirse.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.Grid_grid_Pirse.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_grid_Pirse.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Grid_grid_Pirse.Appearance.Row.Options.UseFont = True
        Me.Grid_grid_Pirse.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_grid_Pirse.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_grid_Pirse.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn39, Me.GridColumn2, Me.GridColumn1, Me.GridColumn48})
        Me.Grid_grid_Pirse.GridControl = Me.grid_Pirse
        Me.Grid_grid_Pirse.Name = "Grid_grid_Pirse"
        Me.Grid_grid_Pirse.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Grid_grid_Pirse.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.Grid_grid_Pirse.OptionsSelection.EnableAppearanceHideSelection = False
        Me.Grid_grid_Pirse.OptionsView.ColumnAutoWidth = False
        '
        'GridColumn18
        '
        Me.GridColumn18.AccessibleName = "الكود"
        Me.GridColumn18.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.GridColumn18.AppearanceCell.Options.UseFont = True
        Me.GridColumn18.Caption = "الكود"
        Me.GridColumn18.FieldName = "الكود"
        Me.GridColumn18.FieldNameSortGroup = "الكود"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        Me.GridColumn18.Width = 121
        '
        'GridColumn39
        '
        Me.GridColumn39.AccessibleName = "الاسم"
        Me.GridColumn39.Caption = "الاسم"
        Me.GridColumn39.CustomizationCaption = "الاسم"
        Me.GridColumn39.FieldName = "الاسم"
        Me.GridColumn39.FieldNameSortGroup = "الاسم"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.ReadOnly = True
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 1
        Me.GridColumn39.Width = 107
        '
        'GridColumn2
        '
        Me.GridColumn2.AccessibleDescription = "سعر البيع"
        Me.GridColumn2.AccessibleName = "سعر البيع"
        Me.GridColumn2.Caption = "سعر البيع"
        Me.GridColumn2.CustomizationCaption = "سعر البيع"
        Me.GridColumn2.FieldName = "سعر البيع"
        Me.GridColumn2.FieldNameSortGroup = "سعر البيع"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.UnboundExpression = "سعر البيع"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.AccessibleDescription = "سعر الشراء"
        Me.GridColumn1.AccessibleName = "سعر الشراء"
        Me.GridColumn1.Caption = "سعر الشراء"
        Me.GridColumn1.CustomizationCaption = "سعر الشراء"
        Me.GridColumn1.FieldName = "سعر الشراء"
        Me.GridColumn1.FieldNameSortGroup = "سعر الشراء"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.UnboundExpression = "سعر الشراء"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        Me.GridColumn1.Width = 207
        '
        'GridColumn48
        '
        Me.GridColumn48.AccessibleDescription = "الصوره"
        Me.GridColumn48.AccessibleName = "الصوره"
        Me.GridColumn48.Caption = "الصوره"
        Me.GridColumn48.CustomizationCaption = "الصوره"
        Me.GridColumn48.FieldName = "الصوره"
        Me.GridColumn48.FieldNameSortGroup = "الصوره"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.ReadOnly = True
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 4
        Me.GridColumn48.Width = 456
        '
        'grid_Pirse
        '
        Me.grid_Pirse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_Pirse.Location = New System.Drawing.Point(0, 0)
        Me.grid_Pirse.MainView = Me.Grid_grid_Pirse
        Me.grid_Pirse.Name = "grid_Pirse"
        Me.grid_Pirse.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit34, Me.RepositoryItemButtonEdit35, Me.RepositoryItemButtonEdit36})
        Me.grid_Pirse.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grid_Pirse.Size = New System.Drawing.Size(873, 473)
        Me.grid_Pirse.TabIndex = 7
        Me.grid_Pirse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_grid_Pirse})
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(413, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(47, 34)
        Me.SimpleButton1.TabIndex = 9
        '
        'Frm_PriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 473)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.grid_Pirse)
        Me.Name = "Frm_PriceList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_PriceList"
        CType(Me.RepositoryItemButtonEdit34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_grid_Pirse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_Pirse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepositoryItemButtonEdit34 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit35 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit36 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Grid_grid_Pirse As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_Pirse As DevExpress.XtraGrid.GridControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
