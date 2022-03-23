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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.L3 = New System.Windows.Forms.Label()
        Me.L2 = New System.Windows.Forms.Label()
        Me.L4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.T3)
        Me.GroupBox1.Controls.Add(Me.T2)
        Me.GroupBox1.Controls.Add(Me.T1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "輸入邊長"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.L4)
        Me.GroupBox2.Controls.Add(Me.L2)
        Me.GroupBox2.Controls.Add(Me.L3)
        Me.GroupBox2.Controls.Add(Me.L1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(235, 162)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "顯示判斷後之結果"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "邊長a="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "邊長b="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "邊長c="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 12)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "是否為三角形?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 12)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "何種三角形?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 12)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "三角形周長?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 12)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "三角形面積?"
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(72, 36)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(84, 22)
        Me.T1.TabIndex = 3
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(72, 63)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(84, 22)
        Me.T2.TabIndex = 4
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(72, 91)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(84, 22)
        Me.T3.TabIndex = 5
        '
        'L1
        '
        Me.L1.BackColor = System.Drawing.Color.Silver
        Me.L1.Location = New System.Drawing.Point(104, 36)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(93, 22)
        Me.L1.TabIndex = 4
        '
        'L3
        '
        Me.L3.BackColor = System.Drawing.Color.Silver
        Me.L3.Location = New System.Drawing.Point(104, 91)
        Me.L3.Name = "L3"
        Me.L3.Size = New System.Drawing.Size(93, 22)
        Me.L3.TabIndex = 5
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.Silver
        Me.L2.Location = New System.Drawing.Point(104, 63)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(93, 22)
        Me.L2.TabIndex = 6
        '
        'L4
        '
        Me.L4.BackColor = System.Drawing.Color.Silver
        Me.L4.Location = New System.Drawing.Point(104, 118)
        Me.L4.Name = "L4"
        Me.L4.Size = New System.Drawing.Size(93, 22)
        Me.L4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(27, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "判斷及計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 191)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents L4 As System.Windows.Forms.Label
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents L3 As System.Windows.Forms.Label
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
