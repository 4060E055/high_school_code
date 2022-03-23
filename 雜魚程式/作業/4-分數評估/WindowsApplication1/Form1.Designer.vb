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
        Me.T1 = New System.Windows.Forms.TextBox
        Me.B1 = New System.Windows.Forms.Button
        Me.L1 = New System.Windows.Forms.Label
        Me.L2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T1.ForeColor = System.Drawing.Color.Blue
        Me.T1.Location = New System.Drawing.Point(28, 52)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(133, 25)
        Me.T1.TabIndex = 0
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.B1.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B1.ForeColor = System.Drawing.Color.Blue
        Me.B1.Location = New System.Drawing.Point(204, 52)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(80, 32)
        Me.B1.TabIndex = 1
        Me.B1.Text = "計算"
        Me.B1.UseVisualStyleBackColor = False
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L1.Font = New System.Drawing.Font("微軟正黑體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Blue
        Me.L1.Location = New System.Drawing.Point(25, 102)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(171, 36)
        Me.L1.TabIndex = 2
        '
        'L2
        '
        Me.L2.AutoSize = True
        Me.L2.Font = New System.Drawing.Font("標楷體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Purple
        Me.L2.Location = New System.Drawing.Point(12, 18)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(184, 16)
        Me.L2.TabIndex = 3
        Me.L2.Text = "請輸入你最""love""的分數"
        '
        'F1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(296, 162)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.T1)
        Me.Name = "F1"
        Me.Text = "爛爛分數"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label

End Class
