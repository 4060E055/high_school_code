﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P2
        '
        Me.P2.Image = Global.滑溜溜的鼠.My.Resources.Resources._222
        Me.P2.Location = New System.Drawing.Point(366, 298)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(74, 90)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P2.TabIndex = 1
        Me.P2.TabStop = False
        '
        'P1
        '
        Me.P1.Image = Global.滑溜溜的鼠.My.Resources.Resources._111
        Me.P1.Location = New System.Drawing.Point(535, 278)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(23, 24)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 711)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents P2 As System.Windows.Forms.PictureBox

End Class
