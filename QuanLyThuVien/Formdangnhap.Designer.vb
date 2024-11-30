<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formdangnhap
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
        Me.Cance = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBmk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBtk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cance
        '
        Me.Cance.Location = New System.Drawing.Point(321, 234)
        Me.Cance.Name = "Cance"
        Me.Cance.Size = New System.Drawing.Size(75, 31)
        Me.Cance.TabIndex = 13
        Me.Cance.Text = "Cancel"
        Me.Cance.UseVisualStyleBackColor = True
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(212, 234)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 31)
        Me.OK.TabIndex = 12
        Me.OK.Text = "Ok"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Mật khẩu"
        '
        'TBmk
        '
        Me.TBmk.Location = New System.Drawing.Point(254, 166)
        Me.TBmk.Name = "TBmk"
        Me.TBmk.Size = New System.Drawing.Size(200, 22)
        Me.TBmk.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tài khoản"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(249, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Đăng nhập"
        '
        'TBtk
        '
        Me.TBtk.Location = New System.Drawing.Point(254, 125)
        Me.TBtk.Name = "TBtk"
        Me.TBtk.Size = New System.Drawing.Size(200, 22)
        Me.TBtk.TabIndex = 7
        '
        'Formdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 310)
        Me.Controls.Add(Me.Cance)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBmk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBtk)
        Me.Name = "Formdangnhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cance As Button
    Friend WithEvents OK As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TBmk As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBtk As TextBox
End Class
