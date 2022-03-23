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
        Me.T1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.L1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.T2 = New System.Windows.Forms.TextBox
        Me.L2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.T1.Location = New System.Drawing.Point(17, 25)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(115, 25)
        Me.T1.TabIndex = 0
        Me.T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(151, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.L1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Navy
        Me.L1.Location = New System.Drawing.Point(14, 69)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(118, 41)
        Me.L1.TabIndex = 2
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(151, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "清除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(151, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "計算"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(151, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(54, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "清除"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(16, 144)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(115, 22)
        Me.T2.TabIndex = 6
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.L2.Location = New System.Drawing.Point(13, 187)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(132, 197)
        Me.L2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 393)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents L2 As System.Windows.Forms.Label

End Class
