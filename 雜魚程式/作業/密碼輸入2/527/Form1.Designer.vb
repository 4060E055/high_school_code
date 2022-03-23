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
        Me.Label1 = New System.Windows.Forms.Label
        Me.T1 = New System.Windows.Forms.TextBox
        Me.L2 = New System.Windows.Forms.Label
        Me.B1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("華康娃娃體(P)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "請輸入密碼"
        '
        'T1
        '
        Me.T1.Font = New System.Drawing.Font("華康娃娃體(P)", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.T1.ForeColor = System.Drawing.Color.Red
        Me.T1.Location = New System.Drawing.Point(23, 66)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(104, 22)
        Me.T1.TabIndex = 1
        '
        'L2
        '
        Me.L2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.L2.Font = New System.Drawing.Font("華康娃娃體(P)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.L2.ForeColor = System.Drawing.Color.Red
        Me.L2.Location = New System.Drawing.Point(21, 151)
        Me.L2.Name = "L2"
        Me.L2.Size = New System.Drawing.Size(154, 36)
        Me.L2.TabIndex = 2
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B1.Font = New System.Drawing.Font("華康娃娃體(P)", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B1.ForeColor = System.Drawing.Color.Red
        Me.B1.Location = New System.Drawing.Point(187, 55)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(76, 40)
        Me.B1.TabIndex = 3
        Me.B1.Text = "登入"
        Me.B1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.L2)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents L2 As System.Windows.Forms.Label
    Friend WithEvents B1 As System.Windows.Forms.Button

End Class
