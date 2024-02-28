<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpiration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpiration))
        Me.grid_prode = New DevExpress.XtraGrid.GridControl()
        Me.Grid_ITEMS_COUNT = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
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
        Me.grid_prode.Size = New System.Drawing.Size(854, 383)
        Me.grid_prode.TabIndex = 1
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
        'SimpleButton1
        '
        Me.SimpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(303, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(41, 35)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'frmExpiration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 383)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.grid_prode)
        Me.Name = "frmExpiration"
        Me.Text = "Expiration"
        CType(Me.grid_prode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_ITEMS_COUNT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_prode As DevExpress.XtraGrid.GridControl
    Friend WithEvents Grid_ITEMS_COUNT As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
