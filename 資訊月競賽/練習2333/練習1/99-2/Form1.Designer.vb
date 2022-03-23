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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.List1 = New System.Windows.Forms.ListBox
        Me.List3 = New System.Windows.Forms.ListBox
        Me.List2 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.List5 = New System.Windows.Forms.ListBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "天干"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "地支"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "生肖"
        '
        'List1
        '
        Me.List1.FormattingEnabled = True
        Me.List1.ItemHeight = 12
        Me.List1.Location = New System.Drawing.Point(12, 37)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(38, 148)
        Me.List1.TabIndex = 3
        '
        'List3
        '
        Me.List3.FormattingEnabled = True
        Me.List3.ItemHeight = 12
        Me.List3.Location = New System.Drawing.Point(136, 37)
        Me.List3.Name = "List3"
        Me.List3.Size = New System.Drawing.Size(38, 148)
        Me.List3.TabIndex = 4
        '
        'List2
        '
        Me.List2.FormattingEnabled = True
        Me.List2.ItemHeight = 12
        Me.List2.Location = New System.Drawing.Point(74, 37)
        Me.List2.Name = "List2"
        Me.List2.Size = New System.Drawing.Size(38, 148)
        Me.List2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "重排"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(76, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(38, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "重排"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(138, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "重排"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "組合數"
        '
        'List5
        '
        Me.List5.FormattingEnabled = True
        Me.List5.ItemHeight = 12
        Me.List5.Location = New System.Drawing.Point(198, 37)
        Me.List5.Name = "List5"
        Me.List5.Size = New System.Drawing.Size(166, 148)
        Me.List5.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(289, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "進行組合"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Location = New System.Drawing.Point(243, 9)
        Me.Combo1.MaxLength = 99
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(87, 20)
        Me.Combo1.TabIndex = 12
        Me.Combo1.Text = "1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 233)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.List5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List3)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "排列組合"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents List3 As System.Windows.Forms.ListBox
    Friend WithEvents List2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents List5 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox

End Class
