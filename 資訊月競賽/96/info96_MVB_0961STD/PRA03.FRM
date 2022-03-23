VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "三角形計算"
   ClientHeight    =   3750
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   7815
   LinkTopic       =   "Form1"
   ScaleHeight     =   3750
   ScaleWidth      =   7815
   StartUpPosition =   3  '系統預設值
   Begin VB.Frame Frame2 
      Caption         =   "輸入邊長"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   14.25
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2535
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   2775
      Begin VB.TextBox txtEdgeC 
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   1200
         TabIndex        =   15
         Top             =   1680
         Width           =   1215
      End
      Begin VB.TextBox txtEdgeB 
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   435
         Left            =   1200
         TabIndex        =   14
         Top             =   1080
         Width           =   1215
      End
      Begin VB.TextBox txtEdgeA 
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Left            =   1200
         TabIndex        =   13
         Top             =   480
         Width           =   1215
      End
      Begin VB.Label Label1 
         Caption         =   "邊長c="
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   120
         TabIndex        =   9
         Top             =   1680
         Width           =   1095
      End
      Begin VB.Label Label1 
         Caption         =   "邊長b="
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   120
         TabIndex        =   8
         Top             =   1080
         Width           =   1095
      End
      Begin VB.Label Label1 
         Caption         =   "邊長a="
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   7
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "顯示判斷後之結果"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   14.25
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2535
      Left            =   3120
      TabIndex        =   1
      Top             =   120
      Width           =   4695
      Begin VB.Label lblArea 
         Appearance      =   0  '平面
         BackColor       =   &H80000005&
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   450
         Left            =   2520
         TabIndex        =   16
         Top             =   1800
         Width           =   1695
      End
      Begin VB.Label lblLength 
         Appearance      =   0  '平面
         BackColor       =   &H80000005&
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   450
         Left            =   2520
         TabIndex        =   12
         Top             =   1320
         Width           =   1695
      End
      Begin VB.Label lblKind 
         Appearance      =   0  '平面
         BackColor       =   &H80000005&
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   450
         Left            =   2520
         TabIndex        =   11
         Top             =   840
         Width           =   1695
      End
      Begin VB.Label lblYN 
         Appearance      =   0  '平面
         BackColor       =   &H80000005&
         BorderStyle     =   1  '單線固定
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000008&
         Height          =   450
         Left            =   2520
         TabIndex        =   10
         Top             =   360
         Width           =   1700
      End
      Begin VB.Label Label2 
         Caption         =   "三角形面積?"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   240
         TabIndex        =   5
         Top             =   1920
         Width           =   2055
      End
      Begin VB.Label Label2 
         Caption         =   "三角形周長?"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   240
         TabIndex        =   4
         Top             =   1440
         Width           =   2055
      End
      Begin VB.Label Label2 
         Caption         =   "何種三角形?"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   240
         TabIndex        =   3
         Top             =   960
         Width           =   2055
      End
      Begin VB.Label Label2 
         Caption         =   "是否為三角形?"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   240
         TabIndex        =   2
         Top             =   480
         Width           =   2055
      End
   End
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "判斷及計算"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   14.25
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2040
      TabIndex        =   0
      Top             =   3000
      Width           =   1935
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim a, b, c, s As Double
Dim tri_could As Boolean
Dim tri_length, tri_area As Double

Private Sub cmdCalculate_Click()
a = Val(txtEdgeA.Text)   '取得a,b,c三邊周長及計算s=(a+b+c)/2
b = Val(txtEdgeB.Text)
c = Val(txtEdgeC.Text)
s = (a + b + c) / 2
'設為初使狀態
lblYN.Caption = ""
lblKind.Caption = ""
lblLength.Caption = ""
lblArea.Caption = ""
'判斷是否為三角形
If a = 0 Or b = 0 Or c = 0 Then  '若有任一邊=0,則不為三角形
  tri_could = False
Else
  If a + b > c And b + c > a And c + a > b Then '若有兩邊之和小於第三邊的情形,
     tri_could = True                           '則不為三角形
  Else
     tri_could = False
  End If
End If
If tri_could = True Then
  lblYN.Caption = "是"
Else
  lblYN.Caption = "否"
End If
If tri_could = True Then
'判斷三角形的種類
  If a = Sqr(b ^ 2 + c ^ 2) Or b = Sqr(a ^ 2 + c ^ 2) Or c = Sqr(a ^ 2 + b ^ 2) Then
     lblKind.Caption = "直角三角形"   '若一邊具有a2+b2=c2則為直角三角形
  Else
    If a < Sqr(b ^ 2 + c ^ 2) And b < Sqr(a ^ 2 + c ^ 2) And c < Sqr(a ^ 2 + b ^ 2) Then
      lblKind.Caption = "銳角三角形"   '若所有邊具有a2+b2＜c2則為銳角三角形
    Else
      lblKind.Caption = "鈍角三角形"  '若所有邊具有a2+b2＞c2則為鈍角三角形
    End If
  End If
'求三角形的周長
tri_length = Round(a + b + c, 2)
lblLength.Caption = Str(tri_length)
'求三角形的面積
tri_area = Round(Sqr(s * (s - a) * (s - b) * (s - c)), 2)
lblArea.Caption = Str(tri_area)
End If

End Sub

