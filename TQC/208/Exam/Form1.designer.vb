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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lbItems = New System.Windows.Forms.ListBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.lbAdd = New System.Windows.Forms.ListBox
        Me.btnDel = New System.Windows.Forms.Button
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbPrice = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblTP = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton
        Me.冰品選擇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.重選ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.八寶冰ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.水果冰ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Maroon
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(249, 250)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(77, 34)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.ItemHeight = 12
        Me.lbItems.Location = New System.Drawing.Point(25, 95)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(120, 124)
        Me.lbItems.TabIndex = 15
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(151, 122)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(46, 23)
        Me.BtnAdd.TabIndex = 16
        Me.BtnAdd.Text = ">>"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'lbAdd
        '
        Me.lbAdd.FormattingEnabled = True
        Me.lbAdd.ItemHeight = 12
        Me.lbAdd.Location = New System.Drawing.Point(206, 95)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(120, 124)
        Me.lbAdd.TabIndex = 17
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(151, 178)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(46, 23)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "<<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtQty.Location = New System.Drawing.Point(151, 257)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(46, 27)
        Me.txtQty.TabIndex = 20
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "單價"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 24
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbPrice.Location = New System.Drawing.Point(72, 260)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(16, 16)
        Me.lbPrice.TabIndex = 25
        Me.lbPrice.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "數量"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "合計"
        '
        'LblTP
        '
        Me.LblTP.AutoSize = True
        Me.LblTP.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTP.Location = New System.Drawing.Point(261, 40)
        Me.LblTP.Name = "LblTP"
        Me.LblTP.Size = New System.Drawing.Size(65, 12)
        Me.LblTP.TabIndex = 30
        Me.LblTP.Text = "請選擇冰品"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(352, 25)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripButton2.Text = "結束"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.冰品選擇ToolStripMenuItem, Me.ToolStripSeparator1, Me.重選ToolStripMenuItem})
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripButton1.Text = "功能選單"
        '
        '冰品選擇ToolStripMenuItem
        '
        Me.冰品選擇ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.八寶冰ToolStripMenuItem, Me.水果冰ToolStripMenuItem})
        Me.冰品選擇ToolStripMenuItem.Name = "冰品選擇ToolStripMenuItem"
        Me.冰品選擇ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.冰品選擇ToolStripMenuItem.Text = "冰品選擇"
        '
        '重選ToolStripMenuItem
        '
        Me.重選ToolStripMenuItem.Name = "重選ToolStripMenuItem"
        Me.重選ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.重選ToolStripMenuItem.Text = "重選"
        '
        '八寶冰ToolStripMenuItem
        '
        Me.八寶冰ToolStripMenuItem.Name = "八寶冰ToolStripMenuItem"
        Me.八寶冰ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.八寶冰ToolStripMenuItem.Text = "八寶冰"
        '
        '水果冰ToolStripMenuItem
        '
        Me.水果冰ToolStripMenuItem.Name = "水果冰ToolStripMenuItem"
        Me.水果冰ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.水果冰ToolStripMenuItem.Text = "水果冰"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 326)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LblTP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.lbAdd)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.lblTotal)
        Me.Name = "Form1"
        Me.Text = "剉冰店"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents lbAdd As System.Windows.Forms.ListBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblTP As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents 冰品選擇ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 八寶冰ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 水果冰ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 重選ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton

End Class
