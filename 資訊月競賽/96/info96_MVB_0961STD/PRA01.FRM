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
Dim x, y As String

Private Sub txtInput_Change()
Dim xlength As Integer
Dim xtemp As String

y = ""
xlength = Len(txtInput.Text)
For i = 1 To xlength
    xtemp = Mid$(txtInput.Text, i, 1) '取txtInput字串中的每個字母
    '第一次轉換
    If xtemp = "Y" Then
       xtemp = "A"
    Else
      If xtemp = "Z" Then
       xtemp = "B"
      Else
       xtemp = Chr$(Asc(xtemp) + 2)  '字串的ASCII加2碼當做第一次轉換之密碼
      End If
    End If

    '第二次轉換
    'A->K，Z->E，C->H，S->U，R->V，K->N，P->T，B->C
    Select Case xtemp
    Case "A"
        xtemp = "K"
    Case "Z"
        xtemp = "E"
    Case "C"
        xtemp = "H"
    Case "S"
        xtemp = "U"
    Case "R"
        xtemp = "V"
    Case "K"
        xtemp = "N"
    Case "P"
        xtemp = "T"
    Case "B"
        xtemp = "C"
    End Select

    '第三次轉換
    '若為 AEIOU 轉成小寫之aeiou,若為 JQK 轉成123,若為 XYZ 均轉為？
    Select Case xtemp
    Case "A"
        xtemp = "a"
    Case "E"
        xtemp = "e"
    Case "I"
        xtemp = "i"
    Case "O"
        xtemp = "o"
    Case "U"
        xtemp = "u"
    Case "J"
        xtemp = "1"
    Case "Q"
        xtemp = "2"
    Case "K"
        xtemp = "3"
    Case "X", "Y", "Z"
        xtemp = "?"
    End Select

    y = y + xtemp
Next i
lblOutput.Caption = y

End Sub
