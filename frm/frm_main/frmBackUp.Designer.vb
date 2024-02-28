<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBACK_UP
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
        Me.components = New System.ComponentModel.Container()
        Me.CMBServer = New System.Windows.Forms.ComboBox()
        Me.CMBDatabase = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ButtonBACKUP = New System.Windows.Forms.Button()
        Me.ButtonRESTORE = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMBServer
        '
        Me.CMBServer.Enabled = False
        Me.CMBServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBServer.FormattingEnabled = True
        Me.CMBServer.Location = New System.Drawing.Point(101, 49)
        Me.CMBServer.Name = "CMBServer"
        Me.CMBServer.Size = New System.Drawing.Size(244, 23)
        Me.CMBServer.TabIndex = 0
        Me.CMBServer.Text = "DESKTOP-NR9B9G1\SQLEXPRESS"
        '
        'CMBDatabase
        '
        Me.CMBDatabase.Enabled = False
        Me.CMBDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDatabase.FormattingEnabled = True
        Me.CMBDatabase.Location = New System.Drawing.Point(101, 87)
        Me.CMBDatabase.Name = "CMBDatabase"
        Me.CMBDatabase.Size = New System.Drawing.Size(244, 23)
        Me.CMBDatabase.TabIndex = 1
        Me.CMBDatabase.Text = "Sales_DB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SERVER:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DATABASES:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(101, 117)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(244, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'ButtonBACKUP
        '
        Me.ButtonBACKUP.BackColor = System.Drawing.Color.ForestGreen
        Me.ButtonBACKUP.FlatAppearance.BorderSize = 0
        Me.ButtonBACKUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBACKUP.ForeColor = System.Drawing.Color.White
        Me.ButtonBACKUP.Location = New System.Drawing.Point(49, 147)
        Me.ButtonBACKUP.Name = "ButtonBACKUP"
        Me.ButtonBACKUP.Size = New System.Drawing.Size(125, 23)
        Me.ButtonBACKUP.TabIndex = 5
        Me.ButtonBACKUP.Text = "BACKUP"
        Me.ButtonBACKUP.UseVisualStyleBackColor = False
        '
        'ButtonRESTORE
        '
        Me.ButtonRESTORE.BackColor = System.Drawing.Color.Crimson
        Me.ButtonRESTORE.FlatAppearance.BorderSize = 0
        Me.ButtonRESTORE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRESTORE.ForeColor = System.Drawing.Color.White
        Me.ButtonRESTORE.Location = New System.Drawing.Point(180, 147)
        Me.ButtonRESTORE.Name = "ButtonRESTORE"
        Me.ButtonRESTORE.Size = New System.Drawing.Size(113, 23)
        Me.ButtonRESTORE.TabIndex = 6
        Me.ButtonRESTORE.Text = "RESTORE"
        Me.ButtonRESTORE.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(420, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "BACK-UP AND RESTORE DATABASE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 32)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(299, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmBACK_UP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonRESTORE)
        Me.Controls.Add(Me.ButtonBACKUP)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMBDatabase)
        Me.Controls.Add(Me.CMBServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBACK_UP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBServer As System.Windows.Forms.ComboBox
    Friend WithEvents CMBDatabase As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonBACKUP As System.Windows.Forms.Button
    Friend WithEvents ButtonRESTORE As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
