<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm6
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
        Me.grid_prode = New DevExpress.XtraGrid.GridControl()
        Me.Grid_ITEMS_COUNT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grid_prode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_ITEMS_COUNT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_prode
        '
        Me.grid_prode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_prode.Location = New System.Drawing.Point(0, 0)
        Me.grid_prode.MainView = Me.Grid_ITEMS_COUNT
        Me.grid_prode.Name = "grid_prode"
        Me.grid_prode.Size = New System.Drawing.Size(865, 379)
        Me.grid_prode.TabIndex = 2
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'XtraForm6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 379)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grid_prode)
        Me.Name = "XtraForm6"
        Me.Text = "XtraForm6"
        CType(Me.grid_prode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_ITEMS_COUNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_prode As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_ITEMS_COUNT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
