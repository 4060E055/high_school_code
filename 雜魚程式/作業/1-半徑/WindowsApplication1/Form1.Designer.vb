<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F1
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
        Me.L1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.L3 = New System.Windows.Forms.Label
        Me.L22 = New System.Windows.Forms.Label
        Me.L11 = New System.Windows.Forms.Label
        Me.B1 = New System.Windows.Forms.Button
        Me.B2 = New System.Windows.Forms.Button
        Me.T1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L1.Location = New System.Drawing.Point(12, 25)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(104, 16)
        Me.L1.TabIndex = 0
        Me.L1.Text = "請輸入半徑："
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L2.Location = New System.Drawing.Point(16, 70)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(104, 16)
        Me.L2.TabIndex = 1
        Me.L2.Text = "圓　周　長："
        '
        'L3
        '
        Me.L3.AutoSize = True
        Me.L3.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L3.Location = New System.Drawing.Point(15, 116)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(104, 16)
        Me.L3.TabIndex = 2
        Me.L3.Text = "圓　面　積："
        '
        'L22
        '
        Me.L22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L22.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L22.ForeColor = System.Drawing.Color.Purple
        Me.L22.Location = New System.Drawing.Point(122, 116)
        Me.L22.Name = "L22"
        Me.L22.Size = New System.Drawing.Size(113, 16)
        Me.L22.TabIndex = 3
        '
        'L11
        '
        Me.L11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L11.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L11.ForeColor = System.Drawing.Color.Purple
        Me.L11.Location = New System.Drawing.Point(122, 70)
        Me.L11.Name = "L11"
        Me.L11.Size = New System.Drawing.Size(113, 16)
        Me.L11.TabIndex = 4
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B1.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B1.ForeColor = System.Drawing.Color.Purple
        Me.B1.Location = New System.Drawing.Point(15, 159)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(84, 32)
        Me.B1.TabIndex = 5
        Me.B1.Text = "計算"
        Me.B1.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B2.ForeColor = System.Drawing.Color.Purple
        Me.B2.Location = New System.Drawing.Point(151, 159)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(84, 32)
        Me.B2.TabIndex = 6
        Me.B2.Text = "結束"
        Me.B2.UseVisualStyleBackColor = False
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T1.ForeColor = System.Drawing.Color.Purple
        Me.T1.Location = New System.Drawing.Point(122, 25)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(113, 19)
        Me.T1.TabIndex = 7
        '
        'F1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(259, 217)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L11)
        Me.Controls.Add(Me.L22)
        Me.Controls.Add(Me.L3)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Name = "F1"
        Me.Text = "計算圓周長與面積"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents L22 As System.Windows.Forms.Label
    Friend WithEvents L11 As System.Windows.Forms.Label
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.TextBox

End Class
