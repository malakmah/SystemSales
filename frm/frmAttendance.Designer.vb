<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
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
        CType(Me.txt_Hour.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SimpleButton5.Location = New System.Drawing.Point(13, 126)
        Me.SimpleButton5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(136, 95)
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
        Me.LayoutControl1.Location = New System.Drawing.Point(496, 126)
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
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile
        Me.BackgroundImageStore = Global.SystemSales.My.Resources.Resources.bh_advisor_dribbble
        Me.ClientSize = New System.Drawing.Size(997, 480)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.txt_Hour)
        Me.Controls.Add(Me.TXT_Date)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.SimpleButton3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAttendance"
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
End Class
