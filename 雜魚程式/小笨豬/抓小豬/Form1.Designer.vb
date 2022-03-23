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
        Me.B1 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.L1 = New System.Windows.Forms.Label()
        Me.BB = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(84, 12)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(54, 30)
        Me.B1.TabIndex = 0
        Me.B1.TabStop = False
        Me.B1.Text = "稻草堆"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(45, 48)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(54, 30)
        Me.B2.TabIndex = 0
        Me.B2.TabStop = False
        Me.B2.Text = "垃圾堆"
        Me.B2.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(120, 48)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(54, 30)
        Me.B3.TabIndex = 0
        Me.B3.TabStop = False
        Me.B3.Text = "小木屋"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B5
        '
        Me.B5.Location = New System.Drawing.Point(84, 84)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(54, 30)
        Me.B5.TabIndex = 0
        Me.B5.TabStop = False
        Me.B5.Text = "爛泥巴"
        Me.B5.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Location = New System.Drawing.Point(10, 145)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(109, 12)
        Me.L1.TabIndex = 4
        Me.L1.Text = "猜猜小笨豬在哪裡!!"
        '
        'BB
        '
        Me.BB.Location = New System.Drawing.Point(158, 138)
        Me.BB.Name = "BB"
        Me.BB.Size = New System.Drawing.Size(72, 27)
        Me.BB.TabIndex = 5
        Me.BB.Text = "再玩一次"
        Me.BB.UseVisualStyleBackColor = True
        '
        'B6
        '
        Me.B6.Location = New System.Drawing.Point(158, 84)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(54, 30)
        Me.B6.TabIndex = 0
        Me.B6.TabStop = False
        Me.B6.Text = "矮牆間"
        Me.B6.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.Location = New System.Drawing.Point(12, 84)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(54, 30)
        Me.B4.TabIndex = 0
        Me.B4.TabStop = False
        Me.B4.Text = "廚餘桶"
        Me.B4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 190)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.BB)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Name = "Form1"
        Me.Text = "抓小豬"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B5 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents BB As System.Windows.Forms.Button
    Friend WithEvents B6 As System.Windows.Forms.Button
    Friend WithEvents B4 As System.Windows.Forms.Button

End Class
