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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtEdgeC = New System.Windows.Forms.TextBox
        Me.txtEdgeB = New System.Windows.Forms.TextBox
        Me.txtEdgeA = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblArea = New System.Windows.Forms.TextBox
        Me.lblLength = New System.Windows.Forms.TextBox
        Me.lblKind = New System.Windows.Forms.TextBox
        Me.lblYN = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEdgeC)
        Me.GroupBox1.Controls.Add(Me.txtEdgeB)
        Me.GroupBox1.Controls.Add(Me.txtEdgeA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "輸入邊長"
        '
        'txtEdgeC
        '
        Me.txtEdgeC.Location = New System.Drawing.Point(62, 97)
        Me.txtEdgeC.Name = "txtEdgeC"
        Me.txtEdgeC.Size = New System.Drawing.Size(100, 22)
        Me.txtEdgeC.TabIndex = 5
        '
        'txtEdgeB
        '
        Me.txtEdgeB.Location = New System.Drawing.Point(62, 63)
        Me.txtEdgeB.Name = "txtEdgeB"
        Me.txtEdgeB.Size = New System.Drawing.Size(100, 22)
        Me.txtEdgeB.TabIndex = 4
        '
        'txtEdgeA
        '
        Me.txtEdgeA.Location = New System.Drawing.Point(62, 29)
        Me.txtEdgeA.Name = "txtEdgeA"
        Me.txtEdgeA.Size = New System.Drawing.Size(100, 22)
        Me.txtEdgeA.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "邊常c="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "邊常b="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "邊常a="
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblArea)
        Me.GroupBox2.Controls.Add(Me.lblLength)
        Me.GroupBox2.Controls.Add(Me.lblKind)
        Me.GroupBox2.Controls.Add(Me.lblYN)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 133)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "顯示判斷後之結果"
        '
        'lblArea
        '
        Me.lblArea.Location = New System.Drawing.Point(103, 104)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(100, 22)
        Me.lblArea.TabIndex = 10
        '
        'lblLength
        '
        Me.lblLength.Location = New System.Drawing.Point(103, 75)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(100, 22)
        Me.lblLength.TabIndex = 9
        '
        'lblKind
        '
        Me.lblKind.Location = New System.Drawing.Point(103, 46)
        Me.lblKind.Name = "lblKind"
        Me.lblKind.Size = New System.Drawing.Size(100, 22)
        Me.lblKind.TabIndex = 8
        '
        'lblYN
        '
        Me.lblYN.Location = New System.Drawing.Point(103, 17)
        Me.lblYN.Name = "lblYN"
        Me.lblYN.Size = New System.Drawing.Size(100, 22)
        Me.lblYN.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "三角形面積?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "三角形周長?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "何種三角形?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "是否為三角形?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "判斷及計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 207)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "三角形計算"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.TextBox
    Friend WithEvents lblLength As System.Windows.Forms.TextBox
    Friend WithEvents lblKind As System.Windows.Forms.TextBox
    Friend WithEvents lblYN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEdgeC As System.Windows.Forms.TextBox
    Friend WithEvents txtEdgeB As System.Windows.Forms.TextBox
    Friend WithEvents txtEdgeA As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
