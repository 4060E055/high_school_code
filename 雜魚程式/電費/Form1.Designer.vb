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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.R3 = New System.Windows.Forms.RadioButton()
        Me.R2 = New System.Windows.Forms.RadioButton()
        Me.R1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "電費試算表"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "請輸入度數："
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.R3)
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.R1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(89, 77)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "用戶別"
        '
        'R3
        '
        Me.R3.AutoSize = True
        Me.R3.Location = New System.Drawing.Point(11, 59)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(71, 16)
        Me.R3.TabIndex = 2
        Me.R3.Text = "學校用戶"
        Me.R3.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Location = New System.Drawing.Point(11, 38)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(59, 16)
        Me.R2.TabIndex = 1
        Me.R2.Text = "營業用"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Checked = True
        Me.R1.Location = New System.Drawing.Point(11, 17)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(59, 16)
        Me.R1.TabIndex = 0
        Me.R1.TabStop = True
        Me.R1.Text = "家庭用"
        Me.R1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1)
        Me.GroupBox2.Location = New System.Drawing.Point(126, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(56, 46)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選項"
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(3, 18)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(48, 16)
        Me.C1.TabIndex = 0
        Me.C1.Text = "夏日"
        Me.C1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.Location = New System.Drawing.Point(19, 193)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(196, 35)
        Me.L1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 25)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(102, 51)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(89, 22)
        Me.T1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 204)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents R3 As System.Windows.Forms.RadioButton
    Friend WithEvents R2 As System.Windows.Forms.RadioButton
    Friend WithEvents R1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T1 As System.Windows.Forms.TextBox

End Class
