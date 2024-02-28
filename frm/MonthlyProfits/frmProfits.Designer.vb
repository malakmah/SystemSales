<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfits
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfits))
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl3 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup1 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem4 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem3 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileControl3
        '
        Me.TileControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileControl3.Groups.Add(Me.TileGroup1)
        Me.TileControl3.Location = New System.Drawing.Point(0, 0)
        Me.TileControl3.MaxId = 19
        Me.TileControl3.Name = "TileControl3"
        Me.TileControl3.Size = New System.Drawing.Size(1230, 145)
        Me.TileControl3.TabIndex = 2
        Me.TileControl3.Text = "TileControl3"
        '
        'TileGroup1
        '
        Me.TileGroup1.Items.Add(Me.TileItem2)
        Me.TileGroup1.Items.Add(Me.TileItem4)
        Me.TileGroup1.Items.Add(Me.TileItem5)
        Me.TileGroup1.Items.Add(Me.TileItem3)
        Me.TileGroup1.Items.Add(Me.TileItem1)
        Me.TileGroup1.Name = "TileGroup1"
        '
        'TileItem2
        '
        Me.TileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Navy
        Me.TileItem2.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem2.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem2.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement1.ImageOptions.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        TileItemElement1.Text = "قسم الفواتير"
        TileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        Me.TileItem2.Elements.Add(TileItemElement1)
        Me.TileItem2.Id = 17
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem4
        '
        Me.TileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red
        Me.TileItem4.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement2.Appearance.Disabled.Options.UseTextOptions = True
        TileItemElement2.Appearance.Disabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement2.Appearance.Normal.Options.UseFont = True
        TileItemElement2.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement2.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileItemElement2.ImageOptions.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        TileItemElement2.ImageOptions.ImageUri.Uri = "Cancel"
        TileItemElement2.Text = "مرتجع شراء"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        Me.TileItem4.Elements.Add(TileItemElement2)
        Me.TileItem4.Id = 11
        Me.TileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem4.Name = "TileItem4"
        '
        'TileItem5
        '
        Me.TileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TileItem5.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileItem5.AppearanceItem.Normal.Options.UseBackColor = True
        Me.TileItem5.AppearanceItem.Normal.Options.UseFont = True
        TileItemElement3.ImageOptions.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        TileItemElement3.Text = "مرتجع مبيعات"
        TileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        Me.TileItem5.Elements.Add(TileItemElement3)
        Me.TileItem5.Id = 18
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem5.Name = "TileItem5"
        '
        'TileItem3
        '
        Me.TileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Blue
        Me.TileItem3.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement4.Appearance.Normal.Options.UseFont = True
        TileItemElement4.ImageOptions.ImageUri.Uri = "icon%20builder/business_doughnutchart"
        TileItemElement4.Text = "الارباح الشهريه للمبيعات"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        Me.TileItem3.Elements.Add(TileItemElement4)
        Me.TileItem3.Id = 10
        Me.TileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem3.Name = "TileItem3"
        '
        'TileItem1
        '
        Me.TileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal
        Me.TileItem1.AppearanceItem.Normal.Options.UseBackColor = True
        TileItemElement5.Appearance.Disabled.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Disabled.Options.UseFont = True
        TileItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.Transparent
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Appearance.Normal.Options.UseTextOptions = True
        TileItemElement5.Appearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        TileItemElement5.ImageOptions.ImageUri.Uri = "outlook%20inspired/shipmentreceived"
        TileItemElement5.ImageOptions.SvgImage = CType(resources.GetObject("resource.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        TileItemElement5.Text = "الارباح الشهريه للمشتريات"
        TileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
        Me.TileItem1.Elements.Add(TileItemElement5)
        Me.TileItem1.Id = 9
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'TileControl1
        '
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(240, 150)
        Me.TileControl1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 145)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1230, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 145)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1230, 274)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'frmProfits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 419)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TileControl3)
        Me.Name = "frmProfits"
        Me.Text = "Profits"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileControl3 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem3 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem4 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
End Class
