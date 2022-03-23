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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.L1 = New System.Windows.Forms.Label()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "題1(左)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.Yellow
        Me.L1.Location = New System.Drawing.Point(23, 118)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(0, 12)
        Me.L1.TabIndex = 1
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(12, 53)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.ReadOnly = True
        Me.T1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.T1.Size = New System.Drawing.Size(79, 224)
        Me.T1.TabIndex = 2
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(12, 12)
        Me.T2.Multiline = True
        Me.T2.Name = "T2"
        Me.T2.ReadOnly = True
        Me.T2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.T2.Size = New System.Drawing.Size(203, 35)
        Me.T2.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(66, 24)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "題2(上)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 292)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
