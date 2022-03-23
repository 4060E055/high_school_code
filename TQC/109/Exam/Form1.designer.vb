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
        Me.btnGO = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbUPD = New System.Windows.Forms.CheckBox
        Me.cbUPF = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbC3 = New System.Windows.Forms.RadioButton
        Me.rbC2 = New System.Windows.Forms.RadioButton
        Me.rbC1 = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.rbB3 = New System.Windows.Forms.RadioButton
        Me.rbB2 = New System.Windows.Forms.RadioButton
        Me.rbB1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(349, 232)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(41, 34)
        Me.btnGO.TabIndex = 5
        Me.btnGO.Text = "結帳"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "單價"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "X 數量"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(154, 237)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(50, 22)
        Me.txtQty.TabIndex = 21
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "元"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(44, 236)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(57, 22)
        Me.txtPrice.TabIndex = 23
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Navy
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(270, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 22)
        Me.Label4.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "="
        '
        'txtAmt
        '
        Me.txtAmt.BackColor = System.Drawing.Color.Blue
        Me.txtAmt.Font = New System.Drawing.Font("新細明體", 16.0!)
        Me.txtAmt.ForeColor = System.Drawing.Color.White
        Me.txtAmt.Location = New System.Drawing.Point(237, 237)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(81, 33)
        Me.txtAmt.TabIndex = 31
        Me.txtAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 49)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "主餐"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(183, 21)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(183, 16)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "２號餐：雙層漢堡套餐(99元）"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 21)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(169, 16)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "１號餐：兩塊雞套餐(129元)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbUPD)
        Me.GroupBox2.Controls.Add(Me.cbUPF)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 49)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "５元升級"
        '
        'cbUPD
        '
        Me.cbUPD.AutoSize = True
        Me.cbUPD.Location = New System.Drawing.Point(103, 21)
        Me.cbUPD.Name = "cbUPD"
        Me.cbUPD.Size = New System.Drawing.Size(72, 16)
        Me.cbUPD.TabIndex = 8
        Me.cbUPD.Text = "可樂加大"
        Me.cbUPD.UseVisualStyleBackColor = True
        '
        'cbUPF
        '
        Me.cbUPF.AutoSize = True
        Me.cbUPF.Location = New System.Drawing.Point(8, 21)
        Me.cbUPF.Name = "cbUPF"
        Me.cbUPF.Size = New System.Drawing.Size(72, 16)
        Me.cbUPF.TabIndex = 7
        Me.cbUPF.Text = "薯條加大"
        Me.cbUPF.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbC3)
        Me.GroupBox3.Controls.Add(Me.rbC2)
        Me.GroupBox3.Controls.Add(Me.rbC1)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 49)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "飲料"
        '
        'rbC3
        '
        Me.rbC3.AutoSize = True
        Me.rbC3.Location = New System.Drawing.Point(170, 21)
        Me.rbC3.Name = "rbC3"
        Me.rbC3.Size = New System.Drawing.Size(47, 16)
        Me.rbC3.TabIndex = 5
        Me.rbC3.Text = "雪碧"
        Me.rbC3.UseVisualStyleBackColor = True
        '
        'rbC2
        '
        Me.rbC2.AutoSize = True
        Me.rbC2.Location = New System.Drawing.Point(87, 21)
        Me.rbC2.Name = "rbC2"
        Me.rbC2.Size = New System.Drawing.Size(47, 16)
        Me.rbC2.TabIndex = 4
        Me.rbC2.Text = "紅茶"
        Me.rbC2.UseVisualStyleBackColor = True
        '
        'rbC1
        '
        Me.rbC1.AutoSize = True
        Me.rbC1.Checked = True
        Me.rbC1.Location = New System.Drawing.Point(8, 21)
        Me.rbC1.Name = "rbC1"
        Me.rbC1.Size = New System.Drawing.Size(47, 16)
        Me.rbC1.TabIndex = 3
        Me.rbC1.TabStop = True
        Me.rbC1.Text = "可樂"
        Me.rbC1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbB3)
        Me.GroupBox4.Controls.Add(Me.rbB2)
        Me.GroupBox4.Controls.Add(Me.rbB1)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 49)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "副餐"
        '
        'rbB3
        '
        Me.rbB3.AutoSize = True
        Me.rbB3.Location = New System.Drawing.Point(170, 21)
        Me.rbB3.Name = "rbB3"
        Me.rbB3.Size = New System.Drawing.Size(47, 16)
        Me.rbB3.TabIndex = 5
        Me.rbB3.Text = "沙拉"
        Me.rbB3.UseVisualStyleBackColor = True
        '
        'rbB2
        '
        Me.rbB2.AutoSize = True
        Me.rbB2.Location = New System.Drawing.Point(87, 21)
        Me.rbB2.Name = "rbB2"
        Me.rbB2.Size = New System.Drawing.Size(47, 16)
        Me.rbB2.TabIndex = 4
        Me.rbB2.Text = "玉米"
        Me.rbB2.UseVisualStyleBackColor = True
        '
        'rbB1
        '
        Me.rbB1.AutoSize = True
        Me.rbB1.Checked = True
        Me.rbB1.Location = New System.Drawing.Point(8, 21)
        Me.rbB1.Name = "rbB1"
        Me.rbB1.Size = New System.Drawing.Size(47, 16)
        Me.rbB1.TabIndex = 3
        Me.rbB1.TabStop = True
        Me.rbB1.Text = "薯條"
        Me.rbB1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 282)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGO)
        Me.Name = "Form1"
        Me.Text = "HAPPY速食店"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbB3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbB2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbB1 As System.Windows.Forms.RadioButton
    Friend WithEvents cbUPD As System.Windows.Forms.CheckBox
    Friend WithEvents cbUPF As System.Windows.Forms.CheckBox
    Friend WithEvents rbC3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbC2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbC1 As System.Windows.Forms.RadioButton

End Class
