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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.image = New System.Windows.Forms.PictureBox()
        Me.image1 = New System.Windows.Forms.PictureBox()
        Me.image4 = New System.Windows.Forms.PictureBox()
        Me.image3 = New System.Windows.Forms.PictureBox()
        Me.image2 = New System.Windows.Forms.PictureBox()
        Me.image5 = New System.Windows.Forms.PictureBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'image
        '
        Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image.Location = New System.Drawing.Point(70, 11)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(489, 307)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 0
        Me.image.TabStop = False
        '
        'image1
        '
        Me.image1.Location = New System.Drawing.Point(17, 335)
        Me.image1.Name = "image1"
        Me.image1.Size = New System.Drawing.Size(90, 80)
        Me.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image1.TabIndex = 1
        Me.image1.TabStop = False
        '
        'image4
        '
        Me.image4.Location = New System.Drawing.Point(356, 335)
        Me.image4.Name = "image4"
        Me.image4.Size = New System.Drawing.Size(90, 80)
        Me.image4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image4.TabIndex = 2
        Me.image4.TabStop = False
        '
        'image3
        '
        Me.image3.Location = New System.Drawing.Point(243, 335)
        Me.image3.Name = "image3"
        Me.image3.Size = New System.Drawing.Size(90, 80)
        Me.image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image3.TabIndex = 3
        Me.image3.TabStop = False
        '
        'image2
        '
        Me.image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.image2.Location = New System.Drawing.Point(130, 335)
        Me.image2.Name = "image2"
        Me.image2.Size = New System.Drawing.Size(90, 80)
        Me.image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image2.TabIndex = 4
        Me.image2.TabStop = False
        '
        'image5
        '
        Me.image5.Location = New System.Drawing.Point(469, 335)
        Me.image5.Name = "image5"
        Me.image5.Size = New System.Drawing.Size(90, 80)
        Me.image5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image5.TabIndex = 5
        Me.image5.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Shape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(572, 422)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Red
        Me.Shape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Shape1.BorderColor = System.Drawing.Color.Red
        Me.Shape1.BorderWidth = 4
        Me.Shape1.FillColor = System.Drawing.Color.Red
        Me.Shape1.FillGradientColor = System.Drawing.Color.Red
        Me.Shape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.Shape1.Location = New System.Drawing.Point(15, 333)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(95, 85)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "5.gif")
        Me.ImageList1.Images.SetKeyName(1, "1.gif")
        Me.ImageList1.Images.SetKeyName(2, "2.gif")
        Me.ImageList1.Images.SetKeyName(3, "3.gif")
        Me.ImageList1.Images.SetKeyName(4, "4.gif")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 422)
        Me.Controls.Add(Me.image5)
        Me.Controls.Add(Me.image4)
        Me.Controls.Add(Me.image3)
        Me.Controls.Add(Me.image2)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.image)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "  "
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents image1 As System.Windows.Forms.PictureBox
    Friend WithEvents image4 As System.Windows.Forms.PictureBox
    Friend WithEvents image3 As System.Windows.Forms.PictureBox
    Friend WithEvents image2 As System.Windows.Forms.PictureBox
    Friend WithEvents image5 As System.Windows.Forms.PictureBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
