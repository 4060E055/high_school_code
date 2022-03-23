VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   1  '單線固定
   Caption         =   "密碼轉換"
   ClientHeight    =   1410
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4320
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1410
   ScaleWidth      =   4320
   StartUpPosition =   3  '系統預設值
   Begin VB.TextBox txtInput 
      Height          =   375
      Left            =   1320
      TabIndex        =   3
      Top             =   360
      Width           =   2895
   End
   Begin VB.Label lblOutput 
      BorderStyle     =   1  '單線固定
      Height          =   375
      Left            =   1320
      TabIndex        =   2
      Top             =   840
      Width           =   2895
   End
   Begin VB.Label Label2 
      BorderStyle     =   1  '單線固定
      Caption         =   "輸出字串"
      BeginProperty Font 
         Name            =   "文鼎標準楷體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   840
      Width           =   1095
   End
   Begin VB.Label Label1 
      BorderStyle     =   1  '單線固定
      Caption         =   "輸入字串"
      BeginProperty Font 
         Name            =   "文鼎標準楷體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   360
      Width           =   1095
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
