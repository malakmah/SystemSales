<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Supplir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Supplir))
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.buc = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.btnAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.btnUp = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TXT_DATE = New DevExpress.XtraEditors.DateEdit()
        Me.ck1 = New DevExpress.XtraEditors.CheckEdit()
        Me.ck2 = New DevExpress.XtraEditors.CheckEdit()
        Me.TXT_PON = New DevExpress.XtraEditors.TextEdit()
        Me.TXT_ID = New DevExpress.XtraEditors.TextEdit()
        Me.TXT_ADDER = New DevExpress.XtraEditors.TextEdit()
        Me.TXT_NAME = New DevExpress.XtraEditors.TextEdit()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.buc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TXT_DATE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_DATE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_PON.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_ADDER.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_NAME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(527, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(196, 35)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "اضافه وتعديل مورد"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(263, 204)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(40, 33)
        Me.SimpleButton2.TabIndex = 20
        Me.SimpleButton2.Text = "Add"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.SimpleButton2)
        Me.GroupControl2.Controls.Add(Me.buc)
        Me.GroupControl2.Location = New System.Drawing.Point(9, 23)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(303, 282)
        Me.GroupControl2.TabIndex = 324
        Me.GroupControl2.Text = "GroupControl2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 200)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(40, 33)
        Me.SimpleButton1.TabIndex = 21
        Me.SimpleButton1.Text = "Add"
        '
        'buc
        '
        Me.buc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.buc.EditValue = Global.SystemSales.My.Resources.Resources.business_application_addmale_useradd_insert_add_user_client_23121
        Me.buc.Location = New System.Drawing.Point(0, 15)
        Me.buc.Name = "buc"
        Me.buc.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.buc.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.buc.Size = New System.Drawing.Size(303, 179)
        Me.buc.TabIndex = 19
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Red
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(80, 52)
        Me.SimpleButton3.TabIndex = 3
        Me.SimpleButton3.Text = "Close"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label5.Location = New System.Drawing.Point(330, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 23)
        Me.Label5.TabIndex = 332
        Me.Label5.Text = "تاريخ التسجيل"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label7.Location = New System.Drawing.Point(332, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "هاتف شخصى"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label8.Location = New System.Drawing.Point(332, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "العنوان"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label4.Location = New System.Drawing.Point(332, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "النوع"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(332, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الاسم"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(332, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الكود"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.btnAdd)
        Me.GroupControl4.Controls.Add(Me.btnUp)
        Me.GroupControl4.Location = New System.Drawing.Point(318, 245)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.ShowCaption = False
        Me.GroupControl4.Size = New System.Drawing.Size(441, 60)
        Me.GroupControl4.TabIndex = 325
        Me.GroupControl4.Text = "GroupControl4"
        '
        'btnAdd
        '
        Me.btnAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Appearance.Options.UseFont = True
        Me.btnAdd.ImageOptions.Image = CType(resources.GetObject("SimpleButton5.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(297, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 46)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "حفظ"
        '
        'btnUp
        '
        Me.btnUp.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Appearance.Options.UseFont = True
        Me.btnUp.ImageOptions.Image = CType(resources.GetObject("SimpleButton6.ImageOptions.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(158, 5)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(128, 46)
        Me.btnUp.TabIndex = 7
        Me.btnUp.Text = "تعديل"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 53)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(767, 311)
        Me.GroupControl1.TabIndex = 325
        Me.GroupControl1.Text = "الموردين"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Label5)
        Me.GroupControl3.Controls.Add(Me.TXT_DATE)
        Me.GroupControl3.Controls.Add(Me.ck1)
        Me.GroupControl3.Controls.Add(Me.ck2)
        Me.GroupControl3.Controls.Add(Me.Label7)
        Me.GroupControl3.Controls.Add(Me.Label8)
        Me.GroupControl3.Controls.Add(Me.Label4)
        Me.GroupControl3.Controls.Add(Me.Label2)
        Me.GroupControl3.Controls.Add(Me.TXT_PON)
        Me.GroupControl3.Controls.Add(Me.TXT_ID)
        Me.GroupControl3.Controls.Add(Me.Label1)
        Me.GroupControl3.Controls.Add(Me.TXT_ADDER)
        Me.GroupControl3.Controls.Add(Me.TXT_NAME)
        Me.GroupControl3.Location = New System.Drawing.Point(318, 24)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.ShowCaption = False
        Me.GroupControl3.Size = New System.Drawing.Size(437, 215)
        Me.GroupControl3.TabIndex = 323
        Me.GroupControl3.Text = "GroupControl3"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.EditValue = Nothing
        Me.TXT_DATE.Location = New System.Drawing.Point(10, 178)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TXT_DATE.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TXT_DATE.Size = New System.Drawing.Size(312, 20)
        Me.TXT_DATE.TabIndex = 331
        '
        'ck1
        '
        Me.ck1.EditValue = True
        Me.ck1.Location = New System.Drawing.Point(226, 70)
        Me.ck1.Name = "ck1"
        Me.ck1.Properties.Caption = "شركه"
        Me.ck1.Size = New System.Drawing.Size(96, 19)
        Me.ck1.TabIndex = 14
        '
        'ck2
        '
        Me.ck2.Location = New System.Drawing.Point(73, 70)
        Me.ck2.Name = "ck2"
        Me.ck2.Properties.Caption = "فرد"
        Me.ck2.Size = New System.Drawing.Size(104, 19)
        Me.ck2.TabIndex = 8
        '
        'TXT_PON
        '
        Me.TXT_PON.Location = New System.Drawing.Point(10, 144)
        Me.TXT_PON.Name = "TXT_PON"
        Me.TXT_PON.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TXT_PON.Properties.Appearance.Options.UseFont = True
        Me.TXT_PON.Size = New System.Drawing.Size(312, 24)
        Me.TXT_PON.TabIndex = 30
        '
        'TXT_ID
        '
        Me.TXT_ID.Enabled = False
        Me.TXT_ID.Location = New System.Drawing.Point(10, 5)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TXT_ID.Properties.Appearance.Options.UseFont = True
        Me.TXT_ID.Size = New System.Drawing.Size(312, 24)
        Me.TXT_ID.TabIndex = 1
        '
        'TXT_ADDER
        '
        Me.TXT_ADDER.Location = New System.Drawing.Point(10, 102)
        Me.TXT_ADDER.Name = "TXT_ADDER"
        Me.TXT_ADDER.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TXT_ADDER.Properties.Appearance.Options.UseFont = True
        Me.TXT_ADDER.Size = New System.Drawing.Size(312, 24)
        Me.TXT_ADDER.TabIndex = 28
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(10, 35)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.TXT_NAME.Properties.Appearance.Options.UseFont = True
        Me.TXT_NAME.Size = New System.Drawing.Size(312, 24)
        Me.TXT_NAME.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.Firebrick
        Me.PanelControl1.Appearance.BorderColor = System.Drawing.Color.Black
        Me.PanelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PanelControl1.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Appearance.Options.UseBorderColor = True
        Me.PanelControl1.Appearance.Options.UseFont = True
        Me.PanelControl1.Appearance.Options.UseForeColor = True
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(767, 47)
        Me.PanelControl1.TabIndex = 326
        '
        'frm_Supplir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 361)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Supplir"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Supplir"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.buc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.TXT_DATE.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_DATE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_PON.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_ADDER.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_NAME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buc As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_DATE As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ck1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ck2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_PON As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TXT_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_ADDER As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TXT_NAME As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
