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
        Me.txtMusicPath = New System.Windows.Forms.TextBox
        Me.btnMusicBrowse = New System.Windows.Forms.Button
        Me.btnPlay = New System.Windows.Forms.Button
        Me.btnEnd = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "音效位置"
        '
        'txtMusicPath
        '
        Me.txtMusicPath.Location = New System.Drawing.Point(72, 22)
        Me.txtMusicPath.Name = "txtMusicPath"
        Me.txtMusicPath.Size = New System.Drawing.Size(255, 22)
        Me.txtMusicPath.TabIndex = 1
        '
        'btnMusicBrowse
        '
        Me.btnMusicBrowse.Location = New System.Drawing.Point(353, 22)
        Me.btnMusicBrowse.Name = "btnMusicBrowse"
        Me.btnMusicBrowse.Size = New System.Drawing.Size(43, 23)
        Me.btnMusicBrowse.TabIndex = 2
        Me.btnMusicBrowse.Text = "瀏覽"
        Me.btnMusicBrowse.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(72, 66)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "播放"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(153, 66)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 4
        Me.btnEnd.Text = "結束"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 103)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnMusicBrowse)
        Me.Controls.Add(Me.txtMusicPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " 音效播放機"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMusicPath As System.Windows.Forms.TextBox
    Friend WithEvents btnMusicBrowse As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
