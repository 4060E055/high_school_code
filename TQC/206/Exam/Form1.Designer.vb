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
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.btnPathBrowse = New System.Windows.Forms.Button
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.btnSaveTo = New System.Windows.Forms.Button
        Me.btnEnd = New System.Windows.Forms.Button
        Me.OO1 = New System.Windows.Forms.OpenFileDialog
        Me.SS1 = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "檔案路徑："
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(98, 27)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(238, 22)
        Me.txtFilePath.TabIndex = 1
        '
        'btnPathBrowse
        '
        Me.btnPathBrowse.Location = New System.Drawing.Point(349, 27)
        Me.btnPathBrowse.Name = "btnPathBrowse"
        Me.btnPathBrowse.Size = New System.Drawing.Size(42, 23)
        Me.btnPathBrowse.TabIndex = 2
        Me.btnPathBrowse.Text = "瀏覽"
        Me.btnPathBrowse.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(73, 81)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 3
        Me.btnOpenFile.Text = "開啟舊檔"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnSaveTo
        '
        Me.btnSaveTo.Location = New System.Drawing.Point(167, 81)
        Me.btnSaveTo.Name = "btnSaveTo"
        Me.btnSaveTo.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveTo.TabIndex = 4
        Me.btnSaveTo.Text = "另存新檔"
        Me.btnSaveTo.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(261, 81)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "離開"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'OO1
        '
        Me.OO1.FileName = "OpenFileDialog1"
        Me.OO1.Filter = " ""文書檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"""
        Me.OO1.RestoreDirectory = True
        '
        'SS1
        '
        Me.SS1.Filter = " ""文書檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 118)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSaveTo)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnPathBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "簡易的檔案操作"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnPathBrowse As System.Windows.Forms.Button
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveTo As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents OO1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SS1 As System.Windows.Forms.SaveFileDialog

End Class
