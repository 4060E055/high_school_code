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
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(12, 55)
        Me.T1.MaxLength = 100
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.T1.Size = New System.Drawing.Size(258, 67)
        Me.T1.TabIndex = 2
        Me.T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "請輸入任意字串"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 24)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "輸入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(9, 155)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.T2.Size = New System.Drawing.Size(258, 60)
        Me.T2.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "解密"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(12, 250)
        Me.T3.Multiline = True
        Me.T3.Name = "T3"
        Me.T3.ReadOnly = True
        Me.T3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.T3.Size = New System.Drawing.Size(255, 79)
        Me.T3.TabIndex = 10
        Me.T3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "請輸入要解密的字串"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "＊若要解密，請將解密檔放在程式旁"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 348)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.T1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents T3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
