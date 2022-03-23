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
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dayRB2 = New System.Windows.Forms.RadioButton
        Me.dayRB1 = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.movieCB = New System.Windows.Forms.CheckBox
        Me.vrCB = New System.Windows.Forms.CheckBox
        Me.tickDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.groupTB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tickPanel = New System.Windows.Forms.Panel
        Me.tickRB4 = New System.Windows.Forms.RadioButton
        Me.tickRB3 = New System.Windows.Forms.RadioButton
        Me.tickRB2 = New System.Windows.Forms.RadioButton
        Me.tickRB1 = New System.Windows.Forms.RadioButton
        Me.perCB = New System.Windows.Forms.CheckBox
        Me.grpCB = New System.Windows.Forms.CheckBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.payPanel = New System.Windows.Forms.Panel
        Me.payLabel = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2.SuspendLayout()
        Me.tickPanel.SuspendLayout()
        Me.payPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(92, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "資訊科技博物館 售票系統"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "一/二日券："
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dayRB2)
        Me.Panel2.Controls.Add(Me.dayRB1)
        Me.Panel2.Location = New System.Drawing.Point(185, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(143, 33)
        Me.Panel2.TabIndex = 1
        '
        'dayRB2
        '
        Me.dayRB2.AutoSize = True
        Me.dayRB2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dayRB2.Location = New System.Drawing.Point(70, 5)
        Me.dayRB2.Name = "dayRB2"
        Me.dayRB2.Size = New System.Drawing.Size(58, 20)
        Me.dayRB2.TabIndex = 1
        Me.dayRB2.Text = "二日"
        Me.dayRB2.UseVisualStyleBackColor = True
        '
        'dayRB1
        '
        Me.dayRB1.AutoSize = True
        Me.dayRB1.Checked = True
        Me.dayRB1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.dayRB1.Location = New System.Drawing.Point(3, 5)
        Me.dayRB1.Name = "dayRB1"
        Me.dayRB1.Size = New System.Drawing.Size(58, 20)
        Me.dayRB1.TabIndex = 0
        Me.dayRB1.TabStop = True
        Me.dayRB1.Text = "一日"
        Me.dayRB1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "加購特展："
        '
        'movieCB
        '
        Me.movieCB.AutoSize = True
        Me.movieCB.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.movieCB.Location = New System.Drawing.Point(185, 250)
        Me.movieCB.Name = "movieCB"
        Me.movieCB.Size = New System.Drawing.Size(78, 20)
        Me.movieCB.TabIndex = 5
        Me.movieCB.Text = "3D電影"
        Me.movieCB.UseVisualStyleBackColor = True
        '
        'vrCB
        '
        Me.vrCB.AutoSize = True
        Me.vrCB.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.vrCB.Location = New System.Drawing.Point(270, 250)
        Me.vrCB.Name = "vrCB"
        Me.vrCB.Size = New System.Drawing.Size(119, 20)
        Me.vrCB.TabIndex = 6
        Me.vrCB.Text = "虛擬實境Golf"
        Me.vrCB.UseVisualStyleBackColor = True
        '
        'tickDate
        '
        Me.tickDate.Checked = False
        Me.tickDate.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tickDate.Location = New System.Drawing.Point(184, 117)
        Me.tickDate.Name = "tickDate"
        Me.tickDate.Size = New System.Drawing.Size(144, 27)
        Me.tickDate.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(91, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "參觀日期："
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(122, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 33)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "確定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(262, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "人"
        '
        'groupTB
        '
        Me.groupTB.Enabled = False
        Me.groupTB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.groupTB.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.groupTB.Location = New System.Drawing.Point(184, 207)
        Me.groupTB.Name = "groupTB"
        Me.groupTB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.groupTB.Size = New System.Drawing.Size(71, 26)
        Me.groupTB.TabIndex = 4
        Me.groupTB.Text = "20"
        Me.groupTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(173, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "張"
        '
        'tickPanel
        '
        Me.tickPanel.Controls.Add(Me.Label6)
        Me.tickPanel.Controls.Add(Me.tickRB4)
        Me.tickPanel.Controls.Add(Me.tickRB3)
        Me.tickPanel.Controls.Add(Me.tickRB2)
        Me.tickPanel.Controls.Add(Me.tickRB1)
        Me.tickPanel.Location = New System.Drawing.Point(184, 160)
        Me.tickPanel.Name = "tickPanel"
        Me.tickPanel.Size = New System.Drawing.Size(215, 31)
        Me.tickPanel.TabIndex = 3
        '
        'tickRB4
        '
        Me.tickRB4.AutoSize = True
        Me.tickRB4.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tickRB4.Location = New System.Drawing.Point(137, 5)
        Me.tickRB4.Name = "tickRB4"
        Me.tickRB4.Size = New System.Drawing.Size(34, 20)
        Me.tickRB4.TabIndex = 3
        Me.tickRB4.Text = "4"
        Me.tickRB4.UseVisualStyleBackColor = True
        '
        'tickRB3
        '
        Me.tickRB3.AutoSize = True
        Me.tickRB3.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tickRB3.Location = New System.Drawing.Point(93, 5)
        Me.tickRB3.Name = "tickRB3"
        Me.tickRB3.Size = New System.Drawing.Size(34, 20)
        Me.tickRB3.TabIndex = 2
        Me.tickRB3.Text = "3"
        Me.tickRB3.UseVisualStyleBackColor = True
        '
        'tickRB2
        '
        Me.tickRB2.AutoSize = True
        Me.tickRB2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tickRB2.Location = New System.Drawing.Point(47, 5)
        Me.tickRB2.Name = "tickRB2"
        Me.tickRB2.Size = New System.Drawing.Size(34, 20)
        Me.tickRB2.TabIndex = 1
        Me.tickRB2.Text = "2"
        Me.tickRB2.UseVisualStyleBackColor = True
        '
        'tickRB1
        '
        Me.tickRB1.AutoSize = True
        Me.tickRB1.Checked = True
        Me.tickRB1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tickRB1.Location = New System.Drawing.Point(4, 5)
        Me.tickRB1.Name = "tickRB1"
        Me.tickRB1.Size = New System.Drawing.Size(34, 20)
        Me.tickRB1.TabIndex = 0
        Me.tickRB1.TabStop = True
        Me.tickRB1.Text = "1"
        Me.tickRB1.UseVisualStyleBackColor = True
        '
        'perCB
        '
        Me.perCB.AutoSize = True
        Me.perCB.Checked = True
        Me.perCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.perCB.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.perCB.Location = New System.Drawing.Point(92, 167)
        Me.perCB.Name = "perCB"
        Me.perCB.Size = New System.Drawing.Size(91, 20)
        Me.perCB.TabIndex = 16
        Me.perCB.Text = "個人票："
        Me.perCB.UseVisualStyleBackColor = True
        '
        'grpCB
        '
        Me.grpCB.AutoSize = True
        Me.grpCB.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.grpCB.Location = New System.Drawing.Point(92, 209)
        Me.grpCB.Name = "grpCB"
        Me.grpCB.Size = New System.Drawing.Size(91, 20)
        Me.grpCB.TabIndex = 17
        Me.grpCB.Text = "團體票："
        Me.grpCB.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.Location = New System.Drawing.Point(228, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 33)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "重新輸入"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'payPanel
        '
        Me.payPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.payPanel.Controls.Add(Me.payLabel)
        Me.payPanel.Controls.Add(Me.Label2)
        Me.payPanel.Location = New System.Drawing.Point(0, 338)
        Me.payPanel.Name = "payPanel"
        Me.payPanel.Size = New System.Drawing.Size(455, 67)
        Me.payPanel.TabIndex = 19
        Me.payPanel.Visible = False
        '
        'payLabel
        '
        Me.payLabel.AutoSize = True
        Me.payLabel.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.payLabel.Location = New System.Drawing.Point(210, 21)
        Me.payLabel.Name = "payLabel"
        Me.payLabel.Size = New System.Drawing.Size(54, 23)
        Me.payLabel.TabIndex = 1
        Me.payLabel.Text = "NT$ "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "應付金額："
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 56)
        Me.Panel1.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(454, 405)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.payPanel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.grpCB)
        Me.Controls.Add(Me.perCB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.groupTB)
        Me.Controls.Add(Me.tickPanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tickDate)
        Me.Controls.Add(Me.vrCB)
        Me.Controls.Add(Me.movieCB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "售票表單"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.tickPanel.ResumeLayout(False)
        Me.tickPanel.PerformLayout()
        Me.payPanel.ResumeLayout(False)
        Me.payPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dayRB2 As System.Windows.Forms.RadioButton
    Friend WithEvents dayRB1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents movieCB As System.Windows.Forms.CheckBox
    Friend WithEvents vrCB As System.Windows.Forms.CheckBox
    Friend WithEvents tickDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents groupTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tickPanel As System.Windows.Forms.Panel
    Friend WithEvents tickRB4 As System.Windows.Forms.RadioButton
    Friend WithEvents tickRB3 As System.Windows.Forms.RadioButton
    Friend WithEvents tickRB2 As System.Windows.Forms.RadioButton
    Friend WithEvents tickRB1 As System.Windows.Forms.RadioButton
    Friend WithEvents perCB As System.Windows.Forms.CheckBox
    Friend WithEvents grpCB As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents payPanel As System.Windows.Forms.Panel
    Friend WithEvents payLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
