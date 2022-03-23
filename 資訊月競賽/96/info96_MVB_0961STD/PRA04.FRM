VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer TimerMove 
      Left            =   3240
      Top             =   2640
   End
   Begin VB.Timer TimerSwitch 
      Left            =   2640
      Top             =   2640
   End
   Begin VB.CommandButton CommandBegin 
      Caption         =   "開始"
      Height          =   495
      Left            =   3600
      TabIndex        =   7
      Top             =   360
      Width           =   735
   End
   Begin VB.TextBox TextSecond 
      Height          =   375
      Index           =   1
      Left            =   960
      TabIndex        =   3
      Text            =   "3"
      Top             =   2280
      Width           =   855
   End
   Begin VB.TextBox TextSecond 
      Height          =   375
      Index           =   0
      Left            =   960
      TabIndex        =   2
      Text            =   "2"
      Top             =   1680
      Width           =   855
   End
   Begin VB.HScrollBar HScrollValue 
      Height          =   375
      Index           =   1
      Left            =   2040
      Max             =   10
      Min             =   1
      TabIndex        =   1
      Top             =   2280
      Value           =   3
      Width           =   2415
   End
   Begin VB.HScrollBar HScrollValue 
      Height          =   375
      Index           =   0
      Left            =   2040
      Max             =   10
      Min             =   1
      TabIndex        =   0
      Top             =   1680
      Value           =   2
      Width           =   2415
   End
   Begin VB.Shape ShapeWheel 
      BorderStyle     =   0  'Transparent
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   1
      Left            =   720
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   135
   End
   Begin VB.Shape ShapeWheel 
      BorderStyle     =   0  'Transparent
      FillColor       =   &H0000FFFF&
      FillStyle       =   0  'Solid
      Height          =   135
      Index           =   0
      Left            =   240
      Shape           =   3  'Circle
      Top             =   1320
      Width           =   135
   End
   Begin VB.Label LabelBus 
      BackColor       =   &H0000FFFF&
      Caption         =   "形象公車"
      Height          =   255
      Left            =   120
      TabIndex        =   8
      Top             =   1080
      Width           =   855
   End
   Begin VB.Label LabelSecond 
      Caption         =   "5"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   21.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2880
      TabIndex        =   6
      Top             =   360
      Width           =   615
   End
   Begin VB.Label LabelLight 
      Caption         =   "綠燈"
      BeginProperty Font 
         Name            =   "標楷體"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   120
      TabIndex        =   5
      Top             =   2280
      Width           =   735
   End
   Begin VB.Label LabelLight 
      Caption         =   "紅燈"
      BeginProperty Font 
         Name            =   "標楷體"
         Size            =   15.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   4
      Top             =   1680
      Width           =   735
   End
   Begin VB.Shape ShapeLight 
      FillColor       =   &H000000FF&
      Height          =   495
      Index           =   1
      Left            =   1560
      Shape           =   3  'Circle
      Top             =   360
      Width           =   735
   End
   Begin VB.Shape ShapeLight 
      FillColor       =   &H000000FF&
      FillStyle       =   0  'Solid
      Height          =   495
      Index           =   0
      Left            =   360
      Shape           =   3  'Circle
      Top             =   360
      Width           =   735
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim CanMove

Private Sub CommandBegin_Click()
    TimerSwitch.Interval = HScrollValue(0).Value * 1000
    TimerSwitch.Enabled = True
    TimerMove.Interval = 1000
    TimerMove.Enabled = True
    

       HScrollValue(0).Enabled = False
       HScrollValue(1).Enabled = False
       
       TextSecond(0).Enabled = False
       
       TextSecond(1).Enabled = False
       
       
       
    
End Sub

Private Sub Form_Load()
    TimerSwitch.Enabled = False
    TimerMove.Enabled = False
    
    CanMove = False
    
    
End Sub

Private Sub HScrollValue_Change(Index As Integer)
       Dim i, j As Integer
       
       
       TextSecond(Index).Text = HScrollValue(Index).Value
       i = TextSecond(0).Text
       j = TextSecond(1).Text
       
       LabelSecond.Caption = i + j

       
End Sub



Private Sub TimerSwitch_Timer()
     ShapeLight(0).FillStyle = 1
     ShapeLight(1).FillStyle = 0
     ShapeLight(1).FillColor = RGB(0, 255, 0)
     TimerSwitch.Enabled = False
     
     CanMove = True
     
     
     
End Sub

Private Sub TimerMove_Timer()
     Dim i, j As Integer
       
       
       i = TextSecond(0).Text
       j = TextSecond(1).Text
       

     If (CanMove = True) Then
              LabelBus.Left = LabelBus.Left + 200
              ShapeWheel(0).Left = ShapeWheel(0).Left + 200
              ShapeWheel(1).Left = ShapeWheel(1).Left + 200
              If (LabelBus.Left > 4000) Then
                  LabelBus.Left = 120
                  ShapeWheel(0).Left = 240
                  ShapeWheel(1).Left = 720
              End If
              
     End If
     If (LabelSecond.Caption - 1 > 0) Then
          
          LabelSecond.Caption = LabelSecond.Caption - 1
          
              
     Else
          LabelSecond.Caption = i + j
          TimerSwitch.Enabled = True
          ShapeLight(1).FillStyle = 1
          ShapeLight(0).FillStyle = 0
          ShapeLight(0).FillColor = RGB(255, 0, 0)
          TimerSwitch.Enabled = True
          CanMove = False

     
     End If
     
End Sub


