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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdb03 = New System.Windows.Forms.RadioButton
        Me.rdb02 = New System.Windows.Forms.RadioButton
        Me.rdb01 = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt03 = New System.Windows.Forms.TextBox
        Me.txt02 = New System.Windows.Forms.TextBox
        Me.txt01 = New System.Windows.Forms.TextBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.票選第一品牌ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.離開ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "熱門手機品牌的票選系統"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "參與投票"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(76, 22)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(77, 22)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "總投票數："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdb03)
        Me.GroupBox2.Controls.Add(Me.rdb02)
        Me.GroupBox2.Controls.Add(Me.rdb01)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 130)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選擇手機品牌"
        '
        'rdb03
        '
        Me.rdb03.AutoSize = True
        Me.rdb03.Location = New System.Drawing.Point(16, 94)
        Me.rdb03.Name = "rdb03"
        Me.rdb03.Size = New System.Drawing.Size(87, 16)
        Me.rdb03.TabIndex = 2
        Me.rdb03.TabStop = True
        Me.rdb03.Text = "Nokia諾基亞"
        Me.rdb03.UseVisualStyleBackColor = True
        '
        'rdb02
        '
        Me.rdb02.AutoSize = True
        Me.rdb02.Location = New System.Drawing.Point(16, 61)
        Me.rdb02.Name = "rdb02"
        Me.rdb02.Size = New System.Drawing.Size(150, 16)
        Me.rdb02.TabIndex = 1
        Me.rdb02.TabStop = True
        Me.rdb02.Text = "SonyErricsson新力易利信"
        Me.rdb02.UseVisualStyleBackColor = True
        '
        'rdb01
        '
        Me.rdb01.AutoSize = True
        Me.rdb01.Location = New System.Drawing.Point(16, 29)
        Me.rdb01.Name = "rdb01"
        Me.rdb01.Size = New System.Drawing.Size(114, 16)
        Me.rdb01.TabIndex = 0
        Me.rdb01.TabStop = True
        Me.rdb01.Text = "Motorola摩托羅拉"
        Me.rdb01.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt03)
        Me.GroupBox3.Controls.Add(Me.txt02)
        Me.GroupBox3.Controls.Add(Me.txt01)
        Me.GroupBox3.Location = New System.Drawing.Point(197, 96)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(77, 129)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "目前票數"
        '
        'txt03
        '
        Me.txt03.Location = New System.Drawing.Point(9, 86)
        Me.txt03.Name = "txt03"
        Me.txt03.Size = New System.Drawing.Size(57, 22)
        Me.txt03.TabIndex = 2
        Me.txt03.Text = "0"
        Me.txt03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt02
        '
        Me.txt02.Location = New System.Drawing.Point(9, 53)
        Me.txt02.Name = "txt02"
        Me.txt02.Size = New System.Drawing.Size(57, 22)
        Me.txt02.TabIndex = 1
        Me.txt02.Text = "0"
        Me.txt02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt01
        '
        Me.txt01.Location = New System.Drawing.Point(9, 21)
        Me.txt01.Name = "txt01"
        Me.txt01.Size = New System.Drawing.Size(57, 22)
        Me.txt01.TabIndex = 0
        Me.txt01.Text = "0"
        Me.txt01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '票選第一品牌ToolStripMenuItem
        '
        Me.票選第一品牌ToolStripMenuItem.Name = "票選第一品牌ToolStripMenuItem"
        Me.票選第一品牌ToolStripMenuItem.ShortcutKeyDisplayString = "(O)"
        Me.票選第一品牌ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.票選第一品牌ToolStripMenuItem.ShowShortcutKeys = False
        Me.票選第一品牌ToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.票選第一品牌ToolStripMenuItem.Text = "票選第一品牌(&O)"
        '
        '離開ToolStripMenuItem
        '
        Me.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem"
        Me.離開ToolStripMenuItem.ShortcutKeyDisplayString = "(X)"
        Me.離開ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.離開ToolStripMenuItem.ShowShortcutKeys = False
        Me.離開ToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.離開ToolStripMenuItem.Text = "離開(&X)"
        '
        '功能ToolStripMenuItem
        '
        Me.功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.票選第一品牌ToolStripMenuItem, Me.離開ToolStripMenuItem})
        Me.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem"
        Me.功能ToolStripMenuItem.ShortcutKeyDisplayString = "(F)"
        Me.功能ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.功能ToolStripMenuItem.ShowShortcutKeys = False
        Me.功能ToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.功能ToolStripMenuItem.Text = "功能(&F)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 238)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "熱門手機品牌票選"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdb01 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb03 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb02 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt03 As System.Windows.Forms.TextBox
    Friend WithEvents txt02 As System.Windows.Forms.TextBox
    Friend WithEvents txt01 As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 功能ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 票選第一品牌ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 離開ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
