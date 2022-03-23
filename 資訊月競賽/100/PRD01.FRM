VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  '單線固定
   Caption         =   "啃炸雞餐點服務"
   ClientHeight    =   6735
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6225
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   6735
   ScaleWidth      =   6225
   StartUpPosition =   3  '系統預設值
   Begin VB.CommandButton cmdReset 
      Caption         =   "重設"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   23
      Top             =   6240
      Width           =   1215
   End
   Begin VB.CommandButton cmdCalculate 
      Caption         =   "結帳"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2160
      TabIndex        =   21
      Top             =   6240
      Width           =   1215
   End
   Begin VB.Frame Frame3 
      Caption         =   "冷飲"
      ForeColor       =   &H00FF0000&
      Height          =   3975
      Left            =   3120
      TabIndex        =   14
      Top             =   2040
      Width           =   2895
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   5
         Left            =   2040
         TabIndex        =   85
         Text            =   "0"
         Top             =   3120
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   5
         Left            =   2505
         Max             =   10
         TabIndex        =   84
         Top             =   3120
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   4
         Left            =   2040
         TabIndex        =   83
         Text            =   "0"
         Top             =   2640
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   4
         Left            =   2505
         Max             =   10
         TabIndex        =   82
         Top             =   2640
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   3
         Left            =   2040
         TabIndex        =   81
         Text            =   "0"
         Top             =   2160
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   3
         Left            =   2505
         Max             =   10
         TabIndex        =   80
         Top             =   2160
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   2
         Left            =   2040
         TabIndex        =   79
         Text            =   "0"
         Top             =   1680
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   2
         Left            =   2505
         Max             =   10
         TabIndex        =   78
         Top             =   1680
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   1
         Left            =   2040
         TabIndex        =   77
         Text            =   "0"
         Top             =   1200
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   1
         Left            =   2505
         Max             =   10
         TabIndex        =   76
         Top             =   1200
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkQ 
         Height          =   380
         Index           =   0
         Left            =   2040
         TabIndex        =   75
         Text            =   "0"
         Top             =   720
         Width           =   450
      End
      Begin VB.VScrollBar vsbDrink 
         Height          =   375
         Index           =   0
         Left            =   2505
         Max             =   10
         TabIndex        =   74
         Top             =   720
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   5
         Left            =   1320
         TabIndex        =   52
         Text            =   "30"
         Top             =   3120
         Width           =   520
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   4
         Left            =   1320
         TabIndex        =   51
         Text            =   "25"
         Top             =   2640
         Width           =   520
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   3
         Left            =   1320
         TabIndex        =   50
         Text            =   "35"
         Top             =   2160
         Width           =   520
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   2
         Left            =   1320
         TabIndex        =   49
         Text            =   "20"
         Top             =   1680
         Width           =   520
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   1
         Left            =   1320
         TabIndex        =   48
         Text            =   "30"
         Top             =   1200
         Width           =   520
      End
      Begin VB.TextBox txtDrinkPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   0
         Left            =   1320
         TabIndex        =   47
         Text            =   "40"
         Top             =   720
         Width           =   520
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "數量"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   11
         Left            =   2040
         TabIndex        =   35
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "單價"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   10
         Left            =   1320
         TabIndex        =   34
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "品名"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   9
         Left            =   120
         TabIndex        =   33
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label17 
         Appearance      =   0  '平面
         Caption         =   "果汁"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   20
         Top             =   3120
         Width           =   735
      End
      Begin VB.Label Label16 
         Appearance      =   0  '平面
         Caption         =   "冰紅茶"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   19
         Top             =   2640
         Width           =   975
      End
      Begin VB.Label Label15 
         Appearance      =   0  '平面
         Caption         =   "冰咖啡"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   18
         Top             =   2160
         Width           =   975
      End
      Begin VB.Label Label14 
         Appearance      =   0  '平面
         Caption         =   "可樂(小)"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   17
         Top             =   1680
         Width           =   1095
      End
      Begin VB.Label Label13 
         Appearance      =   0  '平面
         Caption         =   "可樂(中)"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   16
         Top             =   1200
         Width           =   1095
      End
      Begin VB.Label Label12 
         Appearance      =   0  '平面
         Caption         =   "可樂(大)"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   15
         Top             =   720
         Width           =   1095
      End
   End
   Begin VB.Frame Frame2 
      Caption         =   "熱食"
      ForeColor       =   &H00FF0000&
      Height          =   3975
      Left            =   120
      TabIndex        =   2
      Top             =   2040
      Width           =   3015
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   5
         Left            =   2160
         TabIndex        =   73
         Text            =   "0"
         Top             =   3120
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   5
         Left            =   2625
         Max             =   10
         TabIndex        =   72
         Top             =   3120
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   4
         Left            =   2160
         TabIndex        =   71
         Text            =   "0"
         Top             =   2640
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   4
         Left            =   2625
         Max             =   10
         TabIndex        =   70
         Top             =   2640
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   3
         Left            =   2160
         TabIndex        =   69
         Text            =   "0"
         Top             =   2160
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   3
         Left            =   2625
         Max             =   10
         TabIndex        =   68
         Top             =   2160
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   2
         Left            =   2160
         TabIndex        =   67
         Text            =   "0"
         Top             =   1680
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   2
         Left            =   2625
         Max             =   10
         TabIndex        =   66
         Top             =   1680
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   1
         Left            =   2160
         TabIndex        =   65
         Text            =   "0"
         Top             =   1200
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   1
         Left            =   2625
         Max             =   10
         TabIndex        =   64
         Top             =   1200
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotQ 
         Height          =   380
         Index           =   0
         Left            =   2160
         TabIndex        =   63
         Text            =   "0"
         Top             =   720
         Width           =   450
      End
      Begin VB.VScrollBar vsbHot 
         Height          =   375
         Index           =   0
         Left            =   2625
         Max             =   10
         TabIndex        =   62
         Top             =   720
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   5
         Left            =   1440
         TabIndex        =   46
         Text            =   "88"
         Top             =   3120
         Width           =   520
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   4
         Left            =   1440
         TabIndex        =   45
         Text            =   "48"
         Top             =   2640
         Width           =   520
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   3
         Left            =   1440
         TabIndex        =   44
         Text            =   "30"
         Top             =   2160
         Width           =   520
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   2
         Left            =   1440
         TabIndex        =   43
         Text            =   "65"
         Top             =   1680
         Width           =   520
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   1
         Left            =   1440
         TabIndex        =   42
         Text            =   "45"
         Top             =   1200
         Width           =   520
      End
      Begin VB.TextBox txtHotPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H80000009&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   0
         Left            =   1440
         TabIndex        =   41
         Text            =   "25"
         Top             =   720
         Width           =   520
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "數量"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   8
         Left            =   2160
         TabIndex        =   32
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "單價"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   7
         Left            =   1320
         TabIndex        =   31
         Top             =   240
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "品名"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   6
         Left            =   120
         TabIndex        =   30
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label11 
         Appearance      =   0  '平面
         Caption         =   "巨無霸"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   13
         Top             =   3120
         Width           =   855
      End
      Begin VB.Label Label10 
         Appearance      =   0  '平面
         Caption         =   "香香堡"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   12
         Top             =   2640
         Width           =   855
      End
      Begin VB.Label Label9 
         Appearance      =   0  '平面
         Caption         =   "漢堡"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   11
         Top             =   2160
         Width           =   615
      End
      Begin VB.Label Label8 
         Appearance      =   0  '平面
         Caption         =   "9塊炸雞塊"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   10
         Top             =   1680
         Width           =   1215
      End
      Begin VB.Label Label7 
         Appearance      =   0  '平面
         Caption         =   "6塊炸雞塊"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   9
         Top             =   1200
         Width           =   1215
      End
      Begin VB.Label Label6 
         Appearance      =   0  '平面
         Caption         =   "薯條"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   240
         TabIndex        =   8
         Top             =   720
         Width           =   615
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "套餐服務"
      ForeColor       =   &H00FF0000&
      Height          =   1935
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   5895
      Begin VB.TextBox txtMealQ 
         Height          =   380
         Index           =   4
         Left            =   5040
         TabIndex        =   61
         Text            =   "0"
         Top             =   960
         Width           =   450
      End
      Begin VB.VScrollBar vsbMeal 
         Height          =   375
         Index           =   4
         Left            =   5505
         Max             =   10
         TabIndex        =   60
         Top             =   960
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtMealQ 
         Height          =   380
         Index           =   3
         Left            =   5040
         TabIndex        =   59
         Text            =   "0"
         Top             =   480
         Width           =   450
      End
      Begin VB.VScrollBar vsbMeal 
         Height          =   375
         Index           =   3
         Left            =   5505
         Max             =   10
         TabIndex        =   58
         Top             =   480
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtMealQ 
         Height          =   380
         Index           =   2
         Left            =   2160
         TabIndex        =   57
         Text            =   "0"
         Top             =   1440
         Width           =   450
      End
      Begin VB.VScrollBar vsbMeal 
         Height          =   375
         Index           =   2
         Left            =   2625
         Max             =   10
         TabIndex        =   56
         Top             =   1440
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtMealQ 
         Height          =   380
         Index           =   1
         Left            =   2160
         TabIndex        =   55
         Text            =   "0"
         Top             =   960
         Width           =   450
      End
      Begin VB.VScrollBar vsbMeal 
         Height          =   375
         Index           =   1
         Left            =   2625
         Max             =   10
         TabIndex        =   54
         Top             =   960
         Value           =   10
         Width           =   255
      End
      Begin VB.VScrollBar vsbMeal 
         Height          =   375
         Index           =   0
         Left            =   2645
         Max             =   10
         TabIndex        =   53
         Top             =   480
         Value           =   10
         Width           =   255
      End
      Begin VB.TextBox txtMealPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H8000000E&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   4
         Left            =   4320
         TabIndex        =   40
         Text            =   "399"
         Top             =   960
         Width           =   520
      End
      Begin VB.TextBox txtMealPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H8000000E&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   3
         Left            =   4320
         TabIndex        =   39
         Text            =   "139"
         Top             =   480
         Width           =   520
      End
      Begin VB.TextBox txtMealPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H8000000E&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   2
         Left            =   1440
         TabIndex        =   38
         Text            =   "119"
         Top             =   1440
         Width           =   520
      End
      Begin VB.TextBox txtMealPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H8000000E&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   1
         Left            =   1440
         TabIndex        =   37
         Text            =   "149"
         Top             =   960
         Width           =   520
      End
      Begin VB.TextBox txtMealPrice 
         Alignment       =   1  '靠右對齊
         BackColor       =   &H8000000E&
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   14.25
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF00FF&
         Height          =   405
         Index           =   0
         Left            =   1440
         TabIndex        =   36
         Text            =   "199"
         Top             =   480
         Width           =   520
      End
      Begin VB.TextBox txtMealQ 
         Height          =   380
         Index           =   0
         Left            =   2180
         TabIndex        =   1
         Text            =   "0"
         Top             =   480
         Width           =   450
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "數量"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   5
         Left            =   5040
         TabIndex        =   29
         Top             =   180
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "單價"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   4
         Left            =   4320
         TabIndex        =   28
         Top             =   180
         Width           =   615
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "數量"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   3
         Left            =   2160
         TabIndex        =   27
         Top             =   180
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "單價"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   2
         Left            =   1320
         TabIndex        =   26
         Top             =   180
         Width           =   735
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "品名"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   1
         Left            =   3120
         TabIndex        =   25
         Top             =   180
         Width           =   1095
      End
      Begin VB.Label Label20 
         Alignment       =   2  '置中對齊
         Appearance      =   0  '平面
         BackColor       =   &H0080FF80&
         Caption         =   "品名"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   24
         Top             =   180
         Width           =   1095
      End
      Begin VB.Label Label5 
         Caption         =   "桶裝炸雞"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   3120
         TabIndex        =   7
         Top             =   1000
         Width           =   1095
      End
      Begin VB.Label Label4 
         Caption         =   "兒童套餐"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   3120
         TabIndex        =   6
         Top             =   550
         Width           =   1095
      End
      Begin VB.Label Label3 
         Caption         =   "超值3號餐"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   255
         Left            =   120
         TabIndex        =   5
         Top             =   1500
         Width           =   1215
      End
      Begin VB.Label Label2 
         Caption         =   "超值2號餐"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   120
         TabIndex        =   4
         Top             =   1000
         Width           =   1215
      End
      Begin VB.Label Label1 
         Appearance      =   0  '平面
         Caption         =   "超值1號餐"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H000000FF&
         Height          =   375
         Left            =   120
         TabIndex        =   3
         Top             =   550
         Width           =   1215
      End
      Begin VB.Line Line1 
         BorderColor     =   &H00FFFFFF&
         X1              =   3000
         X2              =   3000
         Y1              =   120
         Y2              =   1920
      End
   End
   Begin VB.Label lblTotal 
      Appearance      =   0  '平面
      BackColor       =   &H00FFFF80&
      Caption         =   "待客人點餐中"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF00FF&
      Height          =   375
      Left            =   3480
      TabIndex        =   22
      Top             =   6240
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
