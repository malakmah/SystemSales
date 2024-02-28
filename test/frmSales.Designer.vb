<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtLiteral = New DevExpress.XtraEditors.TextEdit()
        Me.lbl = New DevExpress.XtraEditors.LabelControl()
        Me.TxtFacturePosPrintCode = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFacturePosHeure = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFacturePosDate = New DevExpress.XtraEditors.TextEdit()
        Me.ProgressBar1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFacturePosCode = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtFacturePosId = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.TXT_Toitl = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtLiteral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFacturePosPrintCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.TxtFacturePosHeure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFacturePosDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.TxtFacturePosCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFacturePosId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.TXT_Toitl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtLiteral)
        Me.GroupControl2.Controls.Add(Me.lbl)
        Me.GroupControl2.Controls.Add(Me.TxtFacturePosPrintCode)
        Me.GroupControl2.Controls.Add(Me.PictureBox2)
        Me.GroupControl2.Controls.Add(Me.GroupControl5)
        Me.GroupControl2.Controls.Add(Me.ProgressBar1)
        Me.GroupControl2.Controls.Add(Me.GroupControl4)
        Me.GroupControl2.Controls.Add(Me.GroupControl7)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1260, 106)
        Me.GroupControl2.TabIndex = 3
        '
        'txtLiteral
        '
        Me.txtLiteral.Location = New System.Drawing.Point(114, -2)
        Me.txtLiteral.Name = "txtLiteral"
        Me.txtLiteral.Size = New System.Drawing.Size(263, 20)
        Me.txtLiteral.TabIndex = 4
        '
        'lbl
        '
        Me.lbl.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.lbl.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl.Appearance.Options.UseBackColor = True
        Me.lbl.Appearance.Options.UseFont = True
        Me.lbl.Appearance.Options.UseForeColor = True
        Me.lbl.Location = New System.Drawing.Point(444, 37)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(167, 45)
        Me.lbl.TabIndex = 44
        Me.lbl.Text = "فاتوره بيع"
        Me.lbl.Visible = False
        '
        'TxtFacturePosPrintCode
        '
        Me.TxtFacturePosPrintCode.Location = New System.Drawing.Point(813, -3)
        Me.TxtFacturePosPrintCode.Name = "TxtFacturePosPrintCode"
        Me.TxtFacturePosPrintCode.Size = New System.Drawing.Size(229, 20)
        Me.TxtFacturePosPrintCode.TabIndex = 1
        Me.TxtFacturePosPrintCode.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(617, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.Label3)
        Me.GroupControl5.Controls.Add(Me.TxtFacturePosHeure)
        Me.GroupControl5.Controls.Add(Me.Label4)
        Me.GroupControl5.Controls.Add(Me.TxtFacturePosDate)
        Me.GroupControl5.Location = New System.Drawing.Point(716, 23)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(298, 77)
        Me.GroupControl5.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(195, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "توقيت الفاتوره:"
        '
        'TxtFacturePosHeure
        '
        Me.TxtFacturePosHeure.Enabled = False
        Me.TxtFacturePosHeure.Location = New System.Drawing.Point(6, 51)
        Me.TxtFacturePosHeure.Name = "TxtFacturePosHeure"
        Me.TxtFacturePosHeure.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TxtFacturePosHeure.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtFacturePosHeure.Properties.Appearance.Options.UseFont = True
        Me.TxtFacturePosHeure.Properties.Appearance.Options.UseForeColor = True
        Me.TxtFacturePosHeure.Size = New System.Drawing.Size(183, 24)
        Me.TxtFacturePosHeure.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(195, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "تاريخ الفاتوره:"
        '
        'TxtFacturePosDate
        '
        Me.TxtFacturePosDate.Enabled = False
        Me.TxtFacturePosDate.Location = New System.Drawing.Point(6, 24)
        Me.TxtFacturePosDate.Name = "TxtFacturePosDate"
        Me.TxtFacturePosDate.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TxtFacturePosDate.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtFacturePosDate.Properties.Appearance.Options.UseFont = True
        Me.TxtFacturePosDate.Properties.Appearance.Options.UseForeColor = True
        Me.TxtFacturePosDate.Size = New System.Drawing.Size(183, 24)
        Me.TxtFacturePosDate.TabIndex = 30
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Image = CType(resources.GetObject("ProgressBar1.Image"), System.Drawing.Image)
        Me.ProgressBar1.Location = New System.Drawing.Point(318, 24)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(104, 77)
        Me.ProgressBar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProgressBar1.TabIndex = 41
        Me.ProgressBar1.TabStop = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.Label1)
        Me.GroupControl4.Controls.Add(Me.TxtFacturePosCode)
        Me.GroupControl4.Controls.Add(Me.Label2)
        Me.GroupControl4.Controls.Add(Me.TxtFacturePosId)
        Me.GroupControl4.Location = New System.Drawing.Point(1020, 23)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(300, 77)
        Me.GroupControl4.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(176, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "كود الفاتوره"
        '
        'TxtFacturePosCode
        '
        Me.TxtFacturePosCode.Enabled = False
        Me.TxtFacturePosCode.Location = New System.Drawing.Point(5, 51)
        Me.TxtFacturePosCode.Name = "TxtFacturePosCode"
        Me.TxtFacturePosCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TxtFacturePosCode.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtFacturePosCode.Properties.Appearance.Options.UseFont = True
        Me.TxtFacturePosCode.Properties.Appearance.Options.UseForeColor = True
        Me.TxtFacturePosCode.Size = New System.Drawing.Size(165, 24)
        Me.TxtFacturePosCode.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(176, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 23)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "الرقم التسلسلى:"
        '
        'TxtFacturePosId
        '
        Me.TxtFacturePosId.Enabled = False
        Me.TxtFacturePosId.Location = New System.Drawing.Point(5, 24)
        Me.TxtFacturePosId.Name = "TxtFacturePosId"
        Me.TxtFacturePosId.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TxtFacturePosId.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtFacturePosId.Properties.Appearance.Options.UseFont = True
        Me.TxtFacturePosId.Properties.Appearance.Options.UseForeColor = True
        Me.TxtFacturePosId.Size = New System.Drawing.Size(165, 24)
        Me.TxtFacturePosId.TabIndex = 30
        '
        'GroupControl7
        '
        Me.GroupControl7.AppearanceCaption.Options.UseTextOptions = True
        Me.GroupControl7.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GroupControl7.CaptionImageOptions.Image = CType(resources.GetObject("GroupControl7.CaptionImageOptions.Image"), System.Drawing.Image)
        Me.GroupControl7.Controls.Add(Me.TXT_Toitl)
        Me.GroupControl7.Location = New System.Drawing.Point(49, 24)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(263, 77)
        Me.GroupControl7.TabIndex = 3
        '
        'TXT_Toitl
        '
        Me.TXT_Toitl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_Toitl.Enabled = False
        Me.TXT_Toitl.Location = New System.Drawing.Point(2, 33)
        Me.TXT_Toitl.Name = "TXT_Toitl"
        Me.TXT_Toitl.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Toitl.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXT_Toitl.Properties.Appearance.Options.UseFont = True
        Me.TXT_Toitl.Properties.Appearance.Options.UseForeColor = True
        Me.TXT_Toitl.Properties.Appearance.Options.UseTextOptions = True
        Me.TXT_Toitl.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TXT_Toitl.Size = New System.Drawing.Size(259, 40)
        Me.TXT_Toitl.TabIndex = 30
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 559)
        Me.Controls.Add(Me.GroupControl2)
        Me.Name = "frmSales"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "frmSales"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtLiteral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFacturePosPrintCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.TxtFacturePosHeure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFacturePosDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.TxtFacturePosCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFacturePosId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.TXT_Toitl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtLiteral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFacturePosPrintCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtFacturePosHeure As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFacturePosDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProgressBar1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFacturePosCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFacturePosId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TXT_Toitl As DevExpress.XtraEditors.TextEdit
End Class
