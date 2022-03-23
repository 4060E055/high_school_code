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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt5 = New System.Windows.Forms.TextBox
        Me.txt10 = New System.Windows.Forms.TextBox
        Me.txt50 = New System.Windows.Forms.TextBox
        Me.chk5 = New System.Windows.Forms.CheckBox
        Me.chk10 = New System.Windows.Forms.CheckBox
        Me.chk50 = New System.Windows.Forms.CheckBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.m1 = New System.Windows.Forms.ToolStripMenuItem
        Me.m2 = New System.Windows.Forms.ToolStripMenuItem
        Me.m3 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "兌換金額："
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(78, 34)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(177, 22)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.Text = "345"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.txt5)
        Me.GroupBox1.Controls.Add(Me.txt10)
        Me.GroupBox1.Controls.Add(Me.txt50)
        Me.GroupBox1.Controls.Add(Me.chk5)
        Me.GroupBox1.Controls.Add(Me.chk10)
        Me.GroupBox1.Controls.Add(Me.chk50)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 78)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "兌換種類"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "$1"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(173, 45)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(76, 22)
        Me.txt1.TabIndex = 9
        Me.txt1.Text = "0"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(122, 44)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(45, 22)
        Me.txt5.TabIndex = 8
        Me.txt5.Text = "0"
        Me.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt10
        '
        Me.txt10.Location = New System.Drawing.Point(70, 45)
        Me.txt10.Name = "txt10"
        Me.txt10.Size = New System.Drawing.Size(42, 22)
        Me.txt10.TabIndex = 7
        Me.txt10.Text = "0"
        Me.txt10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt50
        '
        Me.txt50.Location = New System.Drawing.Point(19, 45)
        Me.txt50.Name = "txt50"
        Me.txt50.Size = New System.Drawing.Size(42, 22)
        Me.txt50.TabIndex = 5
        Me.txt50.Text = "0"
        Me.txt50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(119, 22)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(36, 16)
        Me.chk5.TabIndex = 3
        Me.chk5.Text = "$5"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk10
        '
        Me.chk10.AutoSize = True
        Me.chk10.Location = New System.Drawing.Point(71, 22)
        Me.chk10.Name = "chk10"
        Me.chk10.Size = New System.Drawing.Size(42, 16)
        Me.chk10.TabIndex = 2
        Me.chk10.Text = "$10"
        Me.chk10.UseVisualStyleBackColor = True
        '
        'chk50
        '
        Me.chk50.AutoSize = True
        Me.chk50.Location = New System.Drawing.Point(19, 22)
        Me.chk50.Name = "chk50"
        Me.chk50.Size = New System.Drawing.Size(42, 16)
        Me.chk50.TabIndex = 0
        Me.chk50.Text = "$50"
        Me.chk50.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'm1
        '
        Me.m1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.m2, Me.m3})
        Me.m1.Name = "m1"
        Me.m1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.m1.ShowShortcutKeys = False
        Me.m1.Size = New System.Drawing.Size(57, 20)
        Me.m1.Text = "功能(&F)"
        '
        'm2
        '
        Me.m2.Name = "m2"
        Me.m2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.m2.ShowShortcutKeys = False
        Me.m2.Size = New System.Drawing.Size(152, 22)
        Me.m2.Text = "兌換(&C)"
        '
        'm3
        '
        Me.m3.Name = "m3"
        Me.m3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.m3.ShowShortcutKeys = False
        Me.m3.Size = New System.Drawing.Size(152, 22)
        Me.m3.Text = "離開(&X)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 153)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "換零錢機"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk5 As System.Windows.Forms.CheckBox
    Friend WithEvents chk10 As System.Windows.Forms.CheckBox
    Friend WithEvents chk50 As System.Windows.Forms.CheckBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt5 As System.Windows.Forms.TextBox
    Friend WithEvents txt10 As System.Windows.Forms.TextBox
    Friend WithEvents txt50 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents m1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents m3 As System.Windows.Forms.ToolStripMenuItem

End Class
