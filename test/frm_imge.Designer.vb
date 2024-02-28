<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_imge
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
        Me.ImageSlider1 = New DevExpress.XtraEditors.Controls.ImageSlider()
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageSlider1
        '
        Me.ImageSlider1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.[Default]
        Me.ImageSlider1.Location = New System.Drawing.Point(12, 12)
        Me.ImageSlider1.Name = "ImageSlider1"
        Me.ImageSlider1.Size = New System.Drawing.Size(668, 446)
        Me.ImageSlider1.TabIndex = 0
        Me.ImageSlider1.Text = "ImageSlider1"
        '
        'frm_imge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 470)
        Me.Controls.Add(Me.ImageSlider1)
        Me.Name = "frm_imge"
        Me.Text = "frm_imge"
        CType(Me.ImageSlider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageSlider1 As DevExpress.XtraEditors.Controls.ImageSlider
End Class
