<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ExpiredItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grid_prode = New DevExpress.XtraGrid.GridControl()
        Me.Grid_ITEMS_COUNT = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grid_prode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_ITEMS_COUNT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grid_prode)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1002, 511)
        Me.GroupControl1.TabIndex = 0
        '
        'grid_prode
        '
        Me.grid_prode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_prode.Location = New System.Drawing.Point(2, 21)
        Me.grid_prode.MainView = Me.Grid_ITEMS_COUNT
        Me.grid_prode.Name = "grid_prode"
        Me.grid_prode.Size = New System.Drawing.Size(998, 488)
        Me.grid_prode.TabIndex = 0
        Me.grid_prode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Grid_ITEMS_COUNT})
        '
        'Grid_ITEMS_COUNT
        '
        Me.Grid_ITEMS_COUNT.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_ITEMS_COUNT.Appearance.HeaderPanel.Options.UseFont = True
        Me.Grid_ITEMS_COUNT.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.Grid_ITEMS_COUNT.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_ITEMS_COUNT.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid_ITEMS_COUNT.Appearance.Row.Options.UseFont = True
        Me.Grid_ITEMS_COUNT.Appearance.Row.Options.UseTextOptions = True
        Me.Grid_ITEMS_COUNT.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Grid_ITEMS_COUNT.GridControl = Me.grid_prode
        Me.Grid_ITEMS_COUNT.Name = "Grid_ITEMS_COUNT"
        '
        'frm_ExpiredItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 511)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ExpiredItems"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاصناف منتهية الصلاحية"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grid_prode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_ITEMS_COUNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grid_prode As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_ITEMS_COUNT As DevExpress.XtraGrid.Views.Grid.GridView
End Class
