<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.C1 = New System.Windows.Forms.CheckBox
        Me.C2 = New System.Windows.Forms.CheckBox
        Me.C3 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.L1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(12, 21)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(96, 16)
        Me.C1.TabIndex = 0
        Me.C1.Text = "原味披薩$250"
        Me.C1.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(12, 43)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(96, 16)
        Me.C2.TabIndex = 1
        Me.C2.Text = "牛肉披薩$275"
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Location = New System.Drawing.Point(12, 65)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(96, 16)
        Me.C3.TabIndex = 2
        Me.C3.Text = "海鮮披薩$350"
        Me.C3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "數量："
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(171, 19)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(100, 22)
        Me.T1.TabIndex = 4
        Me.T1.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 32)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "計算金額"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.SystemColors.ControlText
        Me.L1.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L1.ForeColor = System.Drawing.Color.Lime
        Me.L1.Location = New System.Drawing.Point(10, 94)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(261, 41)
        Me.L1.TabIndex = 6
        Me.L1.Text = "Label2"
        Me.L1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 144)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Name = "Form1"
        Me.Text = "點披薩程式"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents C2 As System.Windows.Forms.CheckBox
    Friend WithEvents C3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label

End Class
