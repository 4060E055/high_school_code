<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.L1 = New System.Windows.Forms.Label
        Me.B1 = New System.Windows.Forms.Button
        Me.L2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "請輸入密碼"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(26, 89)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(84, 22)
        Me.T1.TabIndex = 1
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L1.Location = New System.Drawing.Point(24, 152)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(141, 33)
        Me.L1.TabIndex = 2
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(201, 35)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(81, 31)
        Me.B1.TabIndex = 3
        Me.B1.Text = "登入"
        Me.B1.UseVisualStyleBackColor = True
        '
        'L2
        '
        Me.L2.Location = New System.Drawing.Point(95, 54)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(17, 14)
        Me.L2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L2 As System.Windows.Forms.Label

End Class
