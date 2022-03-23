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
        Me.picView = New System.Windows.Forms.PictureBox
        Me.btnPrevious = New System.Windows.Forms.Button
        Me.btnNext = New System.Windows.Forms.Button
        Me.btnFirst = New System.Windows.Forms.Button
        Me.btnLast = New System.Windows.Forms.Button
        Me.btnLarge = New System.Windows.Forms.Button
        Me.btnSmall = New System.Windows.Forms.Button
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picView
        '
        Me.picView.Image = Global.VBD01.My.Resources.Resources.img01
        Me.picView.Location = New System.Drawing.Point(12, 12)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(268, 176)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picView.TabIndex = 0
        Me.picView.TabStop = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(83, 236)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(62, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "上一張"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(153, 236)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "下一張"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Enabled = False
        Me.btnFirst.Location = New System.Drawing.Point(12, 236)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(63, 23)
        Me.btnFirst.TabIndex = 3
        Me.btnFirst.Text = "第一張"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(216, 236)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(64, 23)
        Me.btnLast.TabIndex = 4
        Me.btnLast.Text = "最後一張"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnLarge
        '
        Me.btnLarge.Location = New System.Drawing.Point(158, 199)
        Me.btnLarge.Name = "btnLarge"
        Me.btnLarge.Size = New System.Drawing.Size(85, 23)
        Me.btnLarge.TabIndex = 5
        Me.btnLarge.Text = "放大"
        Me.btnLarge.UseVisualStyleBackColor = True
        '
        'btnSmall
        '
        Me.btnSmall.Location = New System.Drawing.Point(52, 199)
        Me.btnSmall.Name = "btnSmall"
        Me.btnSmall.Size = New System.Drawing.Size(86, 23)
        Me.btnSmall.TabIndex = 6
        Me.btnSmall.Text = "縮小"
        Me.btnSmall.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnSmall)
        Me.Controls.Add(Me.btnLarge)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.picView)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "簡易圖片瀏覽器"
        CType(Me.picView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picView As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnLarge As System.Windows.Forms.Button
    Friend WithEvents btnSmall As System.Windows.Forms.Button

End Class
