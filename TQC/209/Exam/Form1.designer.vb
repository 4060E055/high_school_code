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
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lbItems = New System.Windows.Forms.ListBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.lbAdd = New System.Windows.Forms.ListBox
        Me.btnDel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbPrice = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblTP = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDays = New System.Windows.Forms.Label
        Me.lblQty = New System.Windows.Forms.Label
        Me.lblAmt = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.功能選單ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.影片種類ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.N熱門新片ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.S經典動畫ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.重新選擇ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Maroon
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(246, 295)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(118, 34)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.ItemHeight = 12
        Me.lbItems.Location = New System.Drawing.Point(20, 70)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(120, 160)
        Me.lbItems.TabIndex = 15
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(166, 101)
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
        Me.lbAdd.Location = New System.Drawing.Point(244, 70)
        Me.lbAdd.Name = "lbAdd"
        Me.lbAdd.Size = New System.Drawing.Size(120, 160)
        Me.lbAdd.TabIndex = 17
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(166, 184)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(46, 23)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "<<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "單價"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 24
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbPrice.Location = New System.Drawing.Point(123, 40)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(16, 16)
        Me.lbPrice.TabIndex = 25
        Me.lbPrice.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "數量"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "小計"
        '
        'LblTP
        '
        Me.LblTP.AutoSize = True
        Me.LblTP.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LblTP.Location = New System.Drawing.Point(18, 44)
        Me.LblTP.Name = "LblTP"
        Me.LblTP.Size = New System.Drawing.Size(61, 12)
        Me.LblTP.TabIndex = 30
        Me.LblTP.Text = "N熱門新片"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 268)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "歸還日"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(244, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "已租片清單"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "天數"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblDays.Location = New System.Drawing.Point(70, 305)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(16, 16)
        Me.lblDays.TabIndex = 40
        Me.lblDays.Text = "0"
        '
        'lblQty
        '
        Me.lblQty.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblQty.Location = New System.Drawing.Point(233, 263)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(16, 16)
        Me.lblQty.TabIndex = 38
        Me.lblQty.Text = "0"
        '
        'lblAmt
        '
        Me.lblAmt.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(301, 265)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(16, 16)
        Me.lblAmt.TabIndex = 41
        Me.lblAmt.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(187, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "合計"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能選單ToolStripMenuItem, Me.結束ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(419, 24)
        Me.MenuStrip1.TabIndex = 43
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '功能選單ToolStripMenuItem
        '
        Me.功能選單ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.影片種類ToolStripMenuItem, Me.ToolStripSeparator1, Me.重新選擇ToolStripMenuItem})
        Me.功能選單ToolStripMenuItem.Name = "功能選單ToolStripMenuItem"
        Me.功能選單ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.功能選單ToolStripMenuItem.Text = "功能選單"
        '
        '影片種類ToolStripMenuItem
        '
        Me.影片種類ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.N熱門新片ToolStripMenuItem, Me.S經典動畫ToolStripMenuItem})
        Me.影片種類ToolStripMenuItem.Name = "影片種類ToolStripMenuItem"
        Me.影片種類ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.影片種類ToolStripMenuItem.Text = "影片種類"
        '
        'N熱門新片ToolStripMenuItem
        '
        Me.N熱門新片ToolStripMenuItem.Name = "N熱門新片ToolStripMenuItem"
        Me.N熱門新片ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.N熱門新片ToolStripMenuItem.Text = "N熱門新片"
        '
        'S經典動畫ToolStripMenuItem
        '
        Me.S經典動畫ToolStripMenuItem.Name = "S經典動畫ToolStripMenuItem"
        Me.S經典動畫ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.S經典動畫ToolStripMenuItem.Text = "S經典動畫"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        '重新選擇ToolStripMenuItem
        '
        Me.重新選擇ToolStripMenuItem.Name = "重新選擇ToolStripMenuItem"
        Me.重新選擇ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.重新選擇ToolStripMenuItem.Text = "重新選擇"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(70, 261)
        Me.DateTimePicker1.MinDate = New Date(2012, 10, 25, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 22)
        Me.DateTimePicker1.TabIndex = 44
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 357)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblTP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.lbAdd)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.lbItems)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "影片出租"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents lbAdd As System.Windows.Forms.ListBox
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbPrice As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblTP As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 功能選單ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 影片種類ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents N熱門新片ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents S經典動畫ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 重新選擇ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 結束ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker

End Class
