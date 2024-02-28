<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Logen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Logen))
        Me.TxtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Log = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Exit = New DevExpress.XtraEditors.SimpleButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Btn_Login = New DevExpress.XtraEditors.SimpleButton()
        Me.ck_AddButn = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ck_AddButn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.EditValue = "Full Name"
        Me.TxtUserName.EnterMoveNextControl = True
        Me.TxtUserName.Location = New System.Drawing.Point(667, 195)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.TxtUserName.Properties.Appearance.Options.UseFont = True
        Me.TxtUserName.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUserName.Size = New System.Drawing.Size(200, 30)
        Me.TxtUserName.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.EditValue = "password"
        Me.TxtPassword.EnterMoveNextControl = True
        Me.TxtPassword.Location = New System.Drawing.Point(667, 231)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.TxtPassword.Properties.Appearance.Options.UseFont = True
        Me.TxtPassword.Properties.Appearance.Options.UseForeColor = True
        Me.TxtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(200, 30)
        Me.TxtPassword.TabIndex = 1
        '
        'btn_Log
        '
        Me.btn_Log.Location = New System.Drawing.Point(783, 298)
        Me.btn_Log.Name = "btn_Log"
        Me.btn_Log.Size = New System.Drawing.Size(102, 23)
        Me.btn_Log.TabIndex = 2
        Me.btn_Log.Text = "Log / in"
        Me.btn_Log.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 300
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.BackgroundImage = CType(resources.GetObject("PictureEdit1.BackgroundImage"), System.Drawing.Image)
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.EditValue = Global.SystemSales.My.Resources.Resources.R1
        Me.PictureEdit1.Location = New System.Drawing.Point(207, 44)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(711, 396)
        Me.PictureEdit1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(161, 134)
        Me.Label1.TabIndex = 3
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(675, 298)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(102, 23)
        Me.btn_Exit.TabIndex = 5
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Btn_Login
        '
        Me.Btn_Login.Location = New System.Drawing.Point(675, 327)
        Me.Btn_Login.Name = "Btn_Login"
        Me.Btn_Login.Size = New System.Drawing.Size(210, 23)
        Me.Btn_Login.TabIndex = 6
        Me.Btn_Login.Text = "Log / in"
        Me.Btn_Login.Visible = False
        '
        'ck_AddButn
        '
        Me.ck_AddButn.Location = New System.Drawing.Point(1082, 96)
        Me.ck_AddButn.Name = "ck_AddButn"
        Me.ck_AddButn.Properties.Caption = "CheckEdit1"
        Me.ck_AddButn.Size = New System.Drawing.Size(16, 19)
        Me.ck_AddButn.TabIndex = 7
        '
        'frm_Logen
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = CType(resources.GetObject("$this.BackgroundImageStore"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1096, 542)
        Me.Controls.Add(Me.ck_AddButn)
        Me.Controls.Add(Me.Btn_Login)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Log)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.PictureEdit1)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.InactiveGlowColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "frm_Logen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TxtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ck_AddButn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Log As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Exit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Btn_Login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ck_AddButn As DevExpress.XtraEditors.CheckEdit
End Class
