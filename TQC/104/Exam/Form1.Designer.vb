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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabLogin = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.pwdTB = New System.Windows.Forms.TextBox
        Me.userTB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabNewUser = New System.Windows.Forms.TabPage
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.emailTB1 = New System.Windows.Forms.TextBox
        Me.sexFRB1 = New System.Windows.Forms.RadioButton
        Me.sexMRB1 = New System.Windows.Forms.RadioButton
        Me.pwdCTB1 = New System.Windows.Forms.TextBox
        Me.pwdTB1 = New System.Windows.Forms.TextBox
        Me.nameTB1 = New System.Windows.Forms.TextBox
        Me.userTypeCB1 = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabUserData = New System.Windows.Forms.TabPage
        Me.userTypeCB = New System.Windows.Forms.ComboBox
        Me.emailLabel = New System.Windows.Forms.Label
        Me.sexFRB2 = New System.Windows.Forms.RadioButton
        Me.sexMRB2 = New System.Windows.Forms.RadioButton
        Me.pwdTB2 = New System.Windows.Forms.TextBox
        Me.nameTB2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabLogin.SuspendLayout()
        Me.TabNewUser.SuspendLayout()
        Me.TabUserData.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabLogin)
        Me.TabControl1.Controls.Add(Me.TabNewUser)
        Me.TabControl1.Controls.Add(Me.TabUserData)
        Me.TabControl1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(10, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(407, 333)
        Me.TabControl1.TabIndex = 0
        '
        'TabLogin
        '
        Me.TabLogin.Controls.Add(Me.Button2)
        Me.TabLogin.Controls.Add(Me.Button1)
        Me.TabLogin.Controls.Add(Me.pwdTB)
        Me.TabLogin.Controls.Add(Me.userTB)
        Me.TabLogin.Controls.Add(Me.Label2)
        Me.TabLogin.Controls.Add(Me.Label1)
        Me.TabLogin.Location = New System.Drawing.Point(4, 29)
        Me.TabLogin.Name = "TabLogin"
        Me.TabLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLogin.Size = New System.Drawing.Size(399, 300)
        Me.TabLogin.TabIndex = 1
        Me.TabLogin.Text = "登入"
        Me.TabLogin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(188, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "重新輸入"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "登入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pwdTB
        '
        Me.pwdTB.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pwdTB.Location = New System.Drawing.Point(180, 108)
        Me.pwdTB.Name = "pwdTB"
        Me.pwdTB.Size = New System.Drawing.Size(121, 27)
        Me.pwdTB.TabIndex = 3
        Me.pwdTB.UseSystemPasswordChar = True
        '
        'userTB
        '
        Me.userTB.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.userTB.Location = New System.Drawing.Point(180, 68)
        Me.userTB.Name = "userTB"
        Me.userTB.Size = New System.Drawing.Size(121, 27)
        Me.userTB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "密碼："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "使用者名稱："
        '
        'TabNewUser
        '
        Me.TabNewUser.Controls.Add(Me.Button5)
        Me.TabNewUser.Controls.Add(Me.Button4)
        Me.TabNewUser.Controls.Add(Me.Button3)
        Me.TabNewUser.Controls.Add(Me.emailTB1)
        Me.TabNewUser.Controls.Add(Me.sexFRB1)
        Me.TabNewUser.Controls.Add(Me.sexMRB1)
        Me.TabNewUser.Controls.Add(Me.pwdCTB1)
        Me.TabNewUser.Controls.Add(Me.pwdTB1)
        Me.TabNewUser.Controls.Add(Me.nameTB1)
        Me.TabNewUser.Controls.Add(Me.userTypeCB1)
        Me.TabNewUser.Controls.Add(Me.Label8)
        Me.TabNewUser.Controls.Add(Me.Label7)
        Me.TabNewUser.Controls.Add(Me.Label6)
        Me.TabNewUser.Controls.Add(Me.Label5)
        Me.TabNewUser.Controls.Add(Me.Label4)
        Me.TabNewUser.Controls.Add(Me.Label3)
        Me.TabNewUser.Location = New System.Drawing.Point(4, 29)
        Me.TabNewUser.Name = "TabNewUser"
        Me.TabNewUser.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNewUser.Size = New System.Drawing.Size(399, 300)
        Me.TabNewUser.TabIndex = 0
        Me.TabNewUser.Text = "新增"
        Me.TabNewUser.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(190, 249)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(84, 31)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "重新輸入"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(295, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 28)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "查詢"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(80, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 31)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "新增"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'emailTB1
        '
        Me.emailTB1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.emailTB1.Location = New System.Drawing.Point(168, 209)
        Me.emailTB1.Name = "emailTB1"
        Me.emailTB1.Size = New System.Drawing.Size(155, 27)
        Me.emailTB1.TabIndex = 12
        '
        'sexFRB1
        '
        Me.sexFRB1.AutoSize = True
        Me.sexFRB1.Location = New System.Drawing.Point(217, 175)
        Me.sexFRB1.Name = "sexFRB1"
        Me.sexFRB1.Size = New System.Drawing.Size(42, 20)
        Me.sexFRB1.TabIndex = 11
        Me.sexFRB1.Text = "女"
        Me.sexFRB1.UseVisualStyleBackColor = True
        '
        'sexMRB1
        '
        Me.sexMRB1.AutoSize = True
        Me.sexMRB1.Checked = True
        Me.sexMRB1.Location = New System.Drawing.Point(168, 175)
        Me.sexMRB1.Name = "sexMRB1"
        Me.sexMRB1.Size = New System.Drawing.Size(42, 20)
        Me.sexMRB1.TabIndex = 10
        Me.sexMRB1.TabStop = True
        Me.sexMRB1.Text = "男"
        Me.sexMRB1.UseVisualStyleBackColor = True
        '
        'pwdCTB1
        '
        Me.pwdCTB1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pwdCTB1.Location = New System.Drawing.Point(168, 139)
        Me.pwdCTB1.Name = "pwdCTB1"
        Me.pwdCTB1.Size = New System.Drawing.Size(116, 27)
        Me.pwdCTB1.TabIndex = 9
        Me.pwdCTB1.UseSystemPasswordChar = True
        '
        'pwdTB1
        '
        Me.pwdTB1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.pwdTB1.Location = New System.Drawing.Point(168, 101)
        Me.pwdTB1.Name = "pwdTB1"
        Me.pwdTB1.Size = New System.Drawing.Size(116, 27)
        Me.pwdTB1.TabIndex = 8
        Me.pwdTB1.UseSystemPasswordChar = True
        '
        'nameTB1
        '
        Me.nameTB1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.nameTB1.Location = New System.Drawing.Point(168, 57)
        Me.nameTB1.Name = "nameTB1"
        Me.nameTB1.Size = New System.Drawing.Size(116, 27)
        Me.nameTB1.TabIndex = 7
        '
        'userTypeCB1
        '
        Me.userTypeCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userTypeCB1.FormattingEnabled = True
        Me.userTypeCB1.Items.AddRange(New Object() {"系統管理者", "一般使用者", "訪客"})
        Me.userTypeCB1.Location = New System.Drawing.Point(168, 21)
        Me.userTypeCB1.Name = "userTypeCB1"
        Me.userTypeCB1.Size = New System.Drawing.Size(116, 24)
        Me.userTypeCB1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "權限："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "E-Mail："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "性別："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "確認密碼："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "密碼："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "使用者名稱："
        '
        'TabUserData
        '
        Me.TabUserData.Controls.Add(Me.userTypeCB)
        Me.TabUserData.Controls.Add(Me.emailLabel)
        Me.TabUserData.Controls.Add(Me.sexFRB2)
        Me.TabUserData.Controls.Add(Me.sexMRB2)
        Me.TabUserData.Controls.Add(Me.pwdTB2)
        Me.TabUserData.Controls.Add(Me.nameTB2)
        Me.TabUserData.Controls.Add(Me.Label9)
        Me.TabUserData.Controls.Add(Me.Label10)
        Me.TabUserData.Controls.Add(Me.Label11)
        Me.TabUserData.Controls.Add(Me.Label13)
        Me.TabUserData.Controls.Add(Me.Label14)
        Me.TabUserData.Location = New System.Drawing.Point(4, 29)
        Me.TabUserData.Name = "TabUserData"
        Me.TabUserData.Size = New System.Drawing.Size(399, 300)
        Me.TabUserData.TabIndex = 2
        Me.TabUserData.Text = "基本資料"
        Me.TabUserData.UseVisualStyleBackColor = True
        '
        'userTypeCB
        '
        Me.userTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.userTypeCB.Enabled = False
        Me.userTypeCB.FormattingEnabled = True
        Me.userTypeCB.Items.AddRange(New Object() {"系統管理者", "一般使用者", "訪客"})
        Me.userTypeCB.Location = New System.Drawing.Point(168, 21)
        Me.userTypeCB.Name = "userTypeCB"
        Me.userTypeCB.Size = New System.Drawing.Size(116, 24)
        Me.userTypeCB.TabIndex = 26
        '
        'emailLabel
        '
        Me.emailLabel.Location = New System.Drawing.Point(169, 182)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(77, 16)
        Me.emailLabel.TabIndex = 25
        '
        'sexFRB2
        '
        Me.sexFRB2.AutoSize = True
        Me.sexFRB2.BackColor = System.Drawing.Color.Transparent
        Me.sexFRB2.Enabled = False
        Me.sexFRB2.Location = New System.Drawing.Point(217, 145)
        Me.sexFRB2.Name = "sexFRB2"
        Me.sexFRB2.Size = New System.Drawing.Size(42, 20)
        Me.sexFRB2.TabIndex = 24
        Me.sexFRB2.TabStop = True
        Me.sexFRB2.Text = "女"
        Me.sexFRB2.UseVisualStyleBackColor = False
        '
        'sexMRB2
        '
        Me.sexMRB2.AutoSize = True
        Me.sexMRB2.BackColor = System.Drawing.Color.Transparent
        Me.sexMRB2.Enabled = False
        Me.sexMRB2.Location = New System.Drawing.Point(168, 145)
        Me.sexMRB2.Name = "sexMRB2"
        Me.sexMRB2.Size = New System.Drawing.Size(42, 20)
        Me.sexMRB2.TabIndex = 23
        Me.sexMRB2.TabStop = True
        Me.sexMRB2.Text = "男"
        Me.sexMRB2.UseVisualStyleBackColor = False
        '
        'pwdTB2
        '
        Me.pwdTB2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pwdTB2.Location = New System.Drawing.Point(168, 101)
        Me.pwdTB2.Name = "pwdTB2"
        Me.pwdTB2.ReadOnly = True
        Me.pwdTB2.Size = New System.Drawing.Size(100, 27)
        Me.pwdTB2.TabIndex = 21
        '
        'nameTB2
        '
        Me.nameTB2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.nameTB2.Location = New System.Drawing.Point(168, 57)
        Me.nameTB2.Name = "nameTB2"
        Me.nameTB2.ReadOnly = True
        Me.nameTB2.Size = New System.Drawing.Size(116, 27)
        Me.nameTB2.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "權限："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(96, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "E-Mail："
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(106, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "性別："
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(106, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "密碼："
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(58, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "使用者名稱："
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(405, 331)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "使用者帳號管理"
        Me.TabControl1.ResumeLayout(False)
        Me.TabLogin.ResumeLayout(False)
        Me.TabLogin.PerformLayout()
        Me.TabNewUser.ResumeLayout(False)
        Me.TabNewUser.PerformLayout()
        Me.TabUserData.ResumeLayout(False)
        Me.TabUserData.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabNewUser As System.Windows.Forms.TabPage
    Friend WithEvents TabLogin As System.Windows.Forms.TabPage
    Friend WithEvents TabUserData As System.Windows.Forms.TabPage
    Friend WithEvents pwdTB As System.Windows.Forms.TextBox
    Friend WithEvents userTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents userTypeCB1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sexFRB1 As System.Windows.Forms.RadioButton
    Friend WithEvents sexMRB1 As System.Windows.Forms.RadioButton
    Friend WithEvents pwdCTB1 As System.Windows.Forms.TextBox
    Friend WithEvents pwdTB1 As System.Windows.Forms.TextBox
    Friend WithEvents nameTB1 As System.Windows.Forms.TextBox
    Friend WithEvents emailTB1 As System.Windows.Forms.TextBox
    Friend WithEvents sexFRB2 As System.Windows.Forms.RadioButton
    Friend WithEvents sexMRB2 As System.Windows.Forms.RadioButton
    Friend WithEvents pwdTB2 As System.Windows.Forms.TextBox
    Friend WithEvents nameTB2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents emailLabel As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents userTypeCB As System.Windows.Forms.ComboBox

End Class
