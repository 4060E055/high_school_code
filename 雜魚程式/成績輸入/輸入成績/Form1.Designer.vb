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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(6, 49)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(212, 147)
        Me.T1.TabIndex = 0
        Me.T1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(166, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(52, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "輸入"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 202)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T1)
        Me.Name = "Form1"
        Me.Text = "輸入成績"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
