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
        Me.gpTP = New System.Windows.Forms.GroupBox
        Me.rbC = New System.Windows.Forms.RadioButton
        Me.rbD = New System.Windows.Forms.RadioButton
        Me.rbS = New System.Windows.Forms.RadioButton
        Me.rbM = New System.Windows.Forms.RadioButton
        Me.rbA = New System.Windows.Forms.RadioButton
        Me.lblOP = New System.Windows.Forms.Label
        Me.lblAns = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.T1 = New System.Windows.Forms.TextBox
        Me.T2 = New System.Windows.Forms.TextBox
        Me.gpTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpTP
        '
        Me.gpTP.Controls.Add(Me.rbC)
        Me.gpTP.Controls.Add(Me.rbD)
        Me.gpTP.Controls.Add(Me.rbS)
        Me.gpTP.Controls.Add(Me.rbM)
        Me.gpTP.Controls.Add(Me.rbA)
        Me.gpTP.Location = New System.Drawing.Point(12, 12)
        Me.gpTP.Name = "gpTP"
        Me.gpTP.Size = New System.Drawing.Size(378, 53)
        Me.gpTP.TabIndex = 11
        Me.gpTP.TabStop = False
        Me.gpTP.Text = "運算方法"
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(311, 21)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(47, 16)
        Me.rbC.TabIndex = 5
        Me.rbC.Text = "連加"
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.Location = New System.Drawing.Point(236, 21)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(47, 16)
        Me.rbD.TabIndex = 3
        Me.rbD.Text = "除法"
        Me.rbD.UseVisualStyleBackColor = True
        '
        'rbS
        '
        Me.rbS.AutoSize = True
        Me.rbS.Location = New System.Drawing.Point(87, 21)
        Me.rbS.Name = "rbS"
        Me.rbS.Size = New System.Drawing.Size(47, 16)
        Me.rbS.TabIndex = 1
        Me.rbS.Text = "減法"
        Me.rbS.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Location = New System.Drawing.Point(164, 20)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(47, 16)
        Me.rbM.TabIndex = 2
        Me.rbM.Text = "乘法"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Checked = True
        Me.rbA.Location = New System.Drawing.Point(10, 21)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(47, 16)
        Me.rbA.TabIndex = 0
        Me.rbA.TabStop = True
        Me.rbA.Text = "加法"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'lblOP
        '
        Me.lblOP.AutoSize = True
        Me.lblOP.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblOP.Location = New System.Drawing.Point(172, 88)
        Me.lblOP.Name = "lblOP"
        Me.lblOP.Size = New System.Drawing.Size(19, 19)
        Me.lblOP.TabIndex = 15
        Me.lblOP.Text = "+"
        '
        'lblAns
        '
        Me.lblAns.BackColor = System.Drawing.Color.Maroon
        Me.lblAns.Font = New System.Drawing.Font("新細明體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAns.ForeColor = System.Drawing.Color.White
        Me.lblAns.Location = New System.Drawing.Point(141, 144)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(174, 22)
        Me.lblAns.TabIndex = 16
        Me.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 28)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = " ＝"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(46, 90)
        Me.T1.Name = "T1"
        Me.T1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T1.Size = New System.Drawing.Size(100, 22)
        Me.T1.TabIndex = 18
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(215, 90)
        Me.T2.Name = "T2"
        Me.T2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.T2.Size = New System.Drawing.Size(100, 22)
        Me.T2.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 212)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.gpTP)
        Me.Controls.Add(Me.lblOP)
        Me.Name = "Form1"
        Me.Text = "四則運算"
        Me.gpTP.ResumeLayout(False)
        Me.gpTP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpTP As System.Windows.Forms.GroupBox
    Friend WithEvents rbD As System.Windows.Forms.RadioButton
    Friend WithEvents rbM As System.Windows.Forms.RadioButton
    Friend WithEvents rbS As System.Windows.Forms.RadioButton
    Friend WithEvents rbA As System.Windows.Forms.RadioButton
    Friend WithEvents lblOP As System.Windows.Forms.Label
    Friend WithEvents rbC As System.Windows.Forms.RadioButton
    Friend WithEvents lblAns As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox

End Class
