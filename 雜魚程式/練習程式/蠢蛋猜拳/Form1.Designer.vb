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
        Me.P2 = New System.Windows.Forms.PictureBox()
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.B1 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P2
        '
        Me.P2.Image = Global.WindowsApplication2.My.Resources.Resources._1
        Me.P2.Location = New System.Drawing.Point(22, 88)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(77, 108)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P2.TabIndex = 0
        Me.P2.TabStop = False
        '
        'P1
        '
        Me.P1.Image = Global.WindowsApplication2.My.Resources.Resources._2
        Me.P1.Location = New System.Drawing.Point(184, 88)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(89, 80)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P1.TabIndex = 1
        Me.P1.TabStop = False
        '
        'B1
        '
        Me.B1.Location = New System.Drawing.Point(51, 232)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(48, 23)
        Me.B1.TabIndex = 2
        Me.B1.Text = "剪刀"
        Me.B1.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.Location = New System.Drawing.Point(184, 231)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(48, 23)
        Me.B3.TabIndex = 3
        Me.B3.Text = "布"
        Me.B3.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.Location = New System.Drawing.Point(117, 232)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(48, 23)
        Me.B2.TabIndex = 4
        Me.B2.Text = "石頭"
        Me.B2.UseVisualStyleBackColor = True
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(72, 25)
        Me.T2.Name = "T2"
        Me.T2.ReadOnly = True
        Me.T2.Size = New System.Drawing.Size(131, 22)
        Me.T2.TabIndex = 5
        Me.T2.Text = "目前分數："
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(51, 273)
        Me.T1.Multiline = True
        Me.T1.Name = "T1"
        Me.T1.ReadOnly = True
        Me.T1.Size = New System.Drawing.Size(185, 27)
        Me.T1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 330)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.T2)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.P2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P2 As System.Windows.Forms.PictureBox
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents B1 As System.Windows.Forms.Button
    Friend WithEvents B3 As System.Windows.Forms.Button
    Friend WithEvents B2 As System.Windows.Forms.Button
    Friend WithEvents T2 As System.Windows.Forms.TextBox
    Friend WithEvents T1 As System.Windows.Forms.TextBox

End Class
