VERSION 5.00
Begin VB.Form PRA01 
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CommandAdd 
      Caption         =   "增加星星數"
      Height          =   375
      Left            =   3120
      TabIndex        =   8
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CommandLeft 
      Caption         =   "左"
      Height          =   255
      Left            =   0
      TabIndex        =   6
      Top             =   2040
      Width           =   1095
   End
   Begin VB.CommandButton CommandRight 
      Caption         =   "右"
      Height          =   255
      Left            =   1440
      TabIndex        =   5
      Top             =   2040
      Width           =   1095
   End
   Begin VB.CommandButton CommandDown 
      Caption         =   "下"
      Height          =   255
      Left            =   720
      TabIndex        =   4
      Top             =   2280
      Width           =   1095
   End
   Begin VB.CommandButton CommandUp 
      Caption         =   "上"
      Height          =   255
      Left            =   720
      TabIndex        =   3
      Top             =   1800
      Width           =   1095
   End
   Begin VB.TextBox TextValue 
      Height          =   285
      Left            =   1440
      TabIndex        =   1
      Text            =   "3600"
      Top             =   2760
      Width           =   735
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   14
      Left            =   2400
      Shape           =   3  'Circle
      Top             =   720
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   13
      Left            =   1920
      Shape           =   3  'Circle
      Top             =   480
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   12
      Left            =   1320
      Shape           =   3  'Circle
      Top             =   840
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   11
      Left            =   120
      Shape           =   3  'Circle
      Top             =   120
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   10
      Left            =   960
      Shape           =   3  'Circle
      Top             =   480
      Width           =   135
   End
   Begin VB.Label LabelX 
      Caption         =   "月亮的X軸座標"
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   2760
      Width           =   1695
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   9
      Left            =   840
      Shape           =   3  'Circle
      Top             =   0
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   8
      Left            =   4200
      Shape           =   3  'Circle
      Top             =   360
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   7
      Left            =   4320
      Shape           =   3  'Circle
      Top             =   840
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   6
      Left            =   240
      Shape           =   3  'Circle
      Top             =   840
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   5
      Left            =   3240
      Shape           =   3  'Circle
      Top             =   840
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   4
      Left            =   2640
      Shape           =   3  'Circle
      Top             =   240
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   3
      Left            =   1680
      Shape           =   3  'Circle
      Top             =   720
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   2
      Left            =   2400
      Shape           =   3  'Circle
      Top             =   360
      Width           =   135
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   1
      Left            =   1440
      Shape           =   3  'Circle
      Top             =   240
      Width           =   135
   End
   Begin VB.Shape ShapeMask 
      BorderStyle     =   0  'Transparent
      FillColor       =   &H8000000F&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   3720
      Shape           =   3  'Circle
      Top             =   120
      Width           =   615
   End
   Begin VB.Label LabelTitle 
      Alignment       =   2  'Center
      Caption         =   "佳節愉快"
      BeginProperty Font 
         Name            =   "標楷體"
         Size            =   27.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   615
      Left            =   0
      TabIndex        =   2
      Top             =   1080
      Width           =   4575
   End
   Begin VB.Label LabelStarCount 
      Caption         =   "目前有5顆星星"
      Height          =   375
      Left            =   3000
      TabIndex        =   0
      Top             =   2760
      Width           =   1695
   End
   Begin VB.Shape ShapeStar 
      FillColor       =   &H00FFFFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   0
      Left            =   360
      Shape           =   3  'Circle
      Top             =   360
      Width           =   135
   End
   Begin VB.Shape ShapeMoon 
      BorderStyle     =   0  'Transparent
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   615
      Left            =   3600
      Shape           =   3  'Circle
      Top             =   240
      Width           =   615
   End
End
Attribute VB_Name = "PRA01"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim StarCount


Private Sub CommandAdd_Click()

   Dim k As String
  
  
  ShapeStar(StarCount).Visible = True
  StarCount = StarCount + 1
  k = StarCount
  
  LabelStarCount.Caption = "目前有" + k + "顆星星"
   
End Sub
  



Private Sub CommandUp_Click()
  
  
  ShapeMask.Top = ShapeMask.Top - 20
  
  
End Sub

Private Sub CommandDown_Click()
  
  
  ShapeMask.Top = ShapeMask.Top + 20
  
End Sub


Private Sub CommandRight_Click()

 
  ShapeMask.Left = ShapeMask.Left + 20

End Sub

Private Sub CommandLeft_Click()
 
  
  ShapeMask.Left = ShapeMask.Left - 20
  
End Sub


Private Sub Form_Load()

   ShapeStar(5).Visible = False
   ShapeStar(6).Visible = False
   ShapeStar(7).Visible = False
   ShapeStar(8).Visible = False
   ShapeStar(9).Visible = False
   ShapeStar(10).Visible = False
   ShapeStar(11).Visible = False
   ShapeStar(12).Visible = False
   ShapeStar(13).Visible = False
   ShapeStar(14).Visible = False
   
   StarCount = 5
   TextValue.Text = ShapeMoon.Left
   
   
End Sub

Private Sub LabelTitle_Click()
      LabelTitle.Caption = "Happy Times"
End Sub

Private Sub LabelTitle_DblClick()
       LabelTitle.Caption = "佳節愉快"
End Sub

Private Sub TextValue_Change()
Dim diff
    diff = TextValue.Text - ShapeMoon.Left
    ShapeMoon.Left = TextValue.Text
    ShapeMask.Left = ShapeMask.Left + diff
End Sub

