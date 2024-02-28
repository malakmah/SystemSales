<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresence))
        Me.txt_Hour = New DevExpress.XtraEditors.TextEdit()
        Me.TXT_Date = New DevExpress.XtraEditors.TextEdit()
        Me.TXTName = New System.Windows.Forms.ComboBox()
        Me.txt_Presence_Departure = New System.Windows.Forms.ComboBox()
        Me.txt_Condition = New System.Windows.Forms.ComboBox()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.GvdPlu = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.txt_Hour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GvdPlu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_Hour
        '
        Me.txt_Hour.Enabled = False
        Me.txt_Hour.Location = New System.Drawing.Point(833, 47)
        Me.txt_Hour.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_Hour.Name = "txt_Hour"
        Me.txt_Hour.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Hour.Properties.Appearance.Options.UseFont = True
        Me.txt_Hour.Size = New System.Drawing.Size(163, 26)
        Me.txt_Hour.TabIndex = 358
        '
        'TXT_Date
        '
        Me.TXT_Date.Enabled = False
        Me.TXT_Date.Location = New System.Drawing.Point(833, 10)
        Me.TXT_Date.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXT_Date.Name = "TXT_Date"
        Me.TXT_Date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Date.Properties.Appearance.Options.UseFont = True
        Me.TXT_Date.Size = New System.Drawing.Size(163, 26)
        Me.TXT_Date.TabIndex = 357
        '
        'TXTName
        '
        Me.TXTName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTName.FormattingEnabled = True
        Me.TXTName.Location = New System.Drawing.Point(12, 37)
        Me.TXTName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TXTName.Name = "TXTName"
        Me.TXTName.Size = New System.Drawing.Size(251, 27)
        Me.TXTName.TabIndex = 356
        '
        'txt_Presence_Departure
        '
        Me.txt_Presence_Departure.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Presence_Departure.FormattingEnabled = True
        Me.txt_Presence_Departure.Items.AddRange(New Object() {"حضور", "انصراف"})
        Me.txt_Presence_Departure.Location = New System.Drawing.Point(12, 12)
        Me.txt_Presence_Departure.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_Presence_Departure.Name = "txt_Presence_Departure"
        Me.txt_Presence_Departure.Size = New System.Drawing.Size(251, 27)
        Me.txt_Presence_Departure.TabIndex = 355
        '
        'txt_Condition
        '
        Me.txt_Condition.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Condition.FormattingEnabled = True
        Me.txt_Condition.Items.AddRange(New Object() {"حاضر", "غائب"})
        Me.txt_Condition.Location = New System.Drawing.Point(12, 62)
        Me.txt_Condition.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_Condition.Name = "txt_Condition"
        Me.txt_Condition.Size = New System.Drawing.Size(251, 31)
        Me.txt_Condition.TabIndex = 354
        '
        'SimpleButton5
        '
        Me.SimpleButton5.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(291, 211)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(314, 36)
        Me.SimpleButton5.TabIndex = 353
        Me.SimpleButton5.Text = "Add"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Red
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(0, -5)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(93, 60)
        Me.SimpleButton3.TabIndex = 352
        Me.SimpleButton3.Text = "Close"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txt_Presence_Departure)
        Me.LayoutControl1.Controls.Add(Me.txt_Condition)
        Me.LayoutControl1.Controls.Add(Me.TXTName)
        Me.LayoutControl1.Location = New System.Drawing.Point(291, 97)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsView.RightToLeftMirroringApplied = True
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(314, 108)
        Me.LayoutControl1.TabIndex = 359
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(314, 108)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.TXTName
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(294, 25)
        Me.LayoutControlItem1.Text = "الموظف"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(35, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 75)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(294, 13)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_Condition
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(294, 25)
        Me.LayoutControlItem3.Text = "الحاله"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(35, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_Presence_Departure
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(294, 25)
        Me.LayoutControlItem2.Text = "الحضور"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(35, 13)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.GvdPlu)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl6.Location = New System.Drawing.Point(0, 253)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(997, 227)
        Me.GroupControl6.TabIndex = 366
        Me.GroupControl6.Text = "حضور وانصراف"
        '
        'GvdPlu
        '
        Me.GvdPlu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GvdPlu.Location = New System.Drawing.Point(2, 21)
        Me.GvdPlu.MainView = Me.GridView2
        Me.GvdPlu.Name = "GvdPlu"
        Me.GvdPlu.Size = New System.Drawing.Size(993, 204)
        Me.GvdPlu.TabIndex = 361
        Me.GvdPlu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView2.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView2.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView2.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Appearance.Row.Options.UseTextOptions = True
        Me.GridView2.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.GridView2.GridControl = Me.GvdPlu
        Me.GridView2.Name = "GridView2"
        '
        'GridColumn7
        '
        Me.GridColumn7.AccessibleDescription = "الكود"
        Me.GridColumn7.AccessibleName = "الكود"
        Me.GridColumn7.Caption = "الكود"
        Me.GridColumn7.CustomizationCaption = "الكود"
        Me.GridColumn7.FieldName = "الكود"
        Me.GridColumn7.FieldNameSortGroup = "الكود"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.AccessibleDescription = "الاسم"
        Me.GridColumn8.AccessibleName = "الاسم"
        Me.GridColumn8.Caption = "الاسم"
        Me.GridColumn8.CustomizationCaption = "الاسم"
        Me.GridColumn8.FieldName = "الاسم"
        Me.GridColumn8.FieldNameSortGroup = "الاسم"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.AccessibleDescription = "الحضور"
        Me.GridColumn9.AccessibleName = "الحضور"
        Me.GridColumn9.Caption = "الحضور"
        Me.GridColumn9.CustomizationCaption = "الحضور"
        Me.GridColumn9.FieldName = "الحضور"
        Me.GridColumn9.FieldNameSortGroup = "الحضور"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.AccessibleDescription = "الحاله"
        Me.GridColumn10.AccessibleName = "الحاله"
        Me.GridColumn10.Caption = "الحاله"
        Me.GridColumn10.CustomizationCaption = "الحاله"
        Me.GridColumn10.FieldName = "الحاله"
        Me.GridColumn10.FieldNameSortGroup = "الحاله"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.AccessibleDescription = "التاريخ"
        Me.GridColumn11.AccessibleName = "التاريخ"
        Me.GridColumn11.Caption = "التاريخ"
        Me.GridColumn11.CustomizationCaption = "التاريخ"
        Me.GridColumn11.DisplayFormat.FormatString = "d"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn11.FieldName = "التاريخ"
        Me.GridColumn11.FieldNameSortGroup = "التاريخ"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.ReadOnly = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 5
        '
        'GridColumn12
        '
        Me.GridColumn12.AccessibleDescription = "الساعه"
        Me.GridColumn12.AccessibleName = "الساعه"
        Me.GridColumn12.Caption = "الساعه"
        Me.GridColumn12.CustomizationCaption = "الساعه"
        Me.GridColumn12.DisplayFormat.FormatString = "d"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn12.FieldName = "الساعه"
        Me.GridColumn12.FieldNameSortGroup = "الساعه"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.ReadOnly = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(50, 97)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(10, 20)
        Me.DataGridView2.TabIndex = 367
        Me.DataGridView2.Visible = False
        '
        'frmPresence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 480)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.txt_Hour)
        Me.Controls.Add(Me.TXT_Date)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPresence"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPresence"
        CType(Me.txt_Hour.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GvdPlu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Hour As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TXT_Date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TXTName As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Presence_Departure As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Condition As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GvdPlu As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
