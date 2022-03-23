VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form PRD02 
   BorderStyle     =   1  '單線固定
   Caption         =   "簡易編輯器"
   ClientHeight    =   8355
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   7950
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8355
   ScaleWidth      =   7950
   StartUpPosition =   2  '螢幕中央
   Begin VB.Frame Frame1 
      Caption         =   "尋找及取代"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1935
      Left            =   1560
      TabIndex        =   6
      Top             =   6240
      Width           =   6255
      Begin VB.CommandButton btnOK 
         Caption         =   "確　定"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   4800
         TabIndex        =   12
         Top             =   1320
         Width           =   1215
      End
      Begin VB.CommandButton btnReDo 
         Caption         =   "回復取代"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   3600
         TabIndex        =   13
         Top             =   1320
         Width           =   1215
      End
      Begin VB.CheckBox chkApplyAll 
         Caption         =   "全部尋找"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   1320
         TabIndex        =   11
         Top             =   1440
         Width           =   1455
      End
      Begin VB.TextBox txtReplace 
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   450
         Left            =   1320
         TabIndex        =   10
         Top             =   840
         Width           =   4695
      End
      Begin VB.TextBox txtSearch 
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   12
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   450
         Left            =   1320
         TabIndex        =   9
         Top             =   400
         Width           =   4695
      End
      Begin VB.Label labReplace 
         Caption         =   "　取代為："
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
         Left            =   120
         TabIndex        =   8
         Top             =   940
         Width           =   1455
      End
      Begin VB.Label labSearch 
         Caption         =   "尋找目標："
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
         Left            =   120
         TabIndex        =   7
         Top             =   480
         Width           =   1455
      End
   End
   Begin VB.OptionButton optReplace 
      Caption         =   "取代"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   5
      Top             =   7320
      Width           =   1095
   End
   Begin VB.OptionButton optSearch 
      Caption         =   "搜尋"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   240
      TabIndex        =   4
      Top             =   6600
      Width           =   1095
   End
   Begin RichTextLib.RichTextBox rtfText 
      Height          =   5295
      Left            =   120
      TabIndex        =   3
      Top             =   720
      Width           =   7695
      _ExtentX        =   13573
      _ExtentY        =   9340
      _Version        =   393217
      Enabled         =   -1  'True
      ReadOnly        =   -1  'True
      ScrollBars      =   3
      Appearance      =   0
      TextRTF         =   $"PRD02.frx":0000
   End
   Begin MSComDlg.CommonDialog dlgFile 
      Left            =   3720
      Top             =   120
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
   End
   Begin VB.CommandButton btnSaveFile 
      Caption         =   "另存新檔"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   2520
      TabIndex        =   1
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton btnOpenFile 
      Caption         =   "開啟舊檔"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1320
      TabIndex        =   2
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton btnNewFile 
      Caption         =   "建立新檔"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "PRD02"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim blnRunReDo As Boolean

'記錄"尋找"及"取代"的初始位置(第一次執行時起始位置)
Dim FoundPOS, FoundPOS2 As Integer

'記錄"尋找"及"取代"的比對位置
Dim SetPOS, SetPOS2 As Integer

'記錄"尋找"及"取代"的啟始位置(記錄功能進行中的下一個起始位置)
Dim StartPOS, StartPOS2 As Integer

'記錄尋找及取代的文字顏色值
Dim SelColor As Double

'記錄"尋找"及"取代"最後找到的位置
Dim LastFoundPOS As Integer
Public Sub FindString(tmpSearchText As String)
SelColor = &HFF&

'初始化StartPOS的值
If FoundPOS = -1 Or blnRunReDo = True Then
    FoundPOS = 0
    StartPOS = 0
End If

Do While (FoundPOS <> -1)
    '設定開始尋找的位置，尋找相符文字
    
    
    '如果是執行ReDo功能，則只作到上次置換的位置
    If blnRunReDo = True Then
        If (FoundPOS > LastFoundPOS) And (LastFoundPOS <> -1) Then Exit Do
    End If
    
    '開始搜尋
    If FoundPOS <> -1 Then

        
        '設定找到的文字為粗體
        rtfText.SelBold = True
        '設定找到的文字顏色為紅色
        rtfText.SelColor = SelColor
    End If
        
    '若沒有勾選「全部尋找」，則僅執行一次就離開
    If chkApplyAll.Value = Unchecked And blnRunReDo = False Then Exit Do
        
Loop

End Sub


Public Sub ReplaceString(tmpSearchText As String, tmpReplaceText As String)
SelColor = &HFF&

If FoundPOS2 = -1 Or blnRunReDo = True Then
    FoundPOS2 = 0
    StartPOS2 = 0
End If

Do While (FoundPOS2 <> -1)
    '設定開始尋找的位置，尋找相符文字
    
    
    '記錄最後一個找到的位置
    If blnRunReDo = False Then LastFoundPOS = FoundPOS2
    
    If FoundPOS2 <> -1 Then

        
        '設定找到的文字為粗體
        rtfText.SelBold = True
        '設定找到的文字顏色為紅色
        rtfText.SelColor = SelColor
    End If
       
    If chkApplyAll.Value = Unchecked And blnRunReDo = False Then Exit Do
    
Loop
btnReDo.Enabled = True


End Sub

Private Sub btnNewFile_Click()
Me.Caption = ""
rtfText.TextRTF = ""
rtfText.Locked = False
End Sub


Private Sub btnOK_Click()

'若選擇的項目是"搜尋功能"
If optSearch.Value = True Then
    
End If

'若選擇的項目是"取代功能"
If optReplace.Value = True Then
    
End If

End Sub

Private Sub btnOpenFile_Click()
Dim strFileName As String

With dlgFile
    .DialogTitle = "開啟舊檔"
    .CancelError = True
    
    '設定檔案篩選條件
    .Filter = ""
    
    .ShowOpen
    
    If Len(.FileName) = 0 Then
        Exit Sub
    Else
        strFileName = .FileName
    End If
    
End With

'載入文件

Me.Caption = ""
rtfText.Locked = False
End Sub


Private Sub btnReDo_Click()
blnRunReDo = True

'執行ReDo


blnRunReDo = False
btnReDo.Enabled = False

End Sub

Private Sub btnSaveFile_Click()
Dim strFileName As String

With dlgFile
    .DialogTitle = "另存新檔"
    .Filter = ""
    .ShowSave
    
    If Len(.FileName) = 0 Then
        Exit Sub
    Else
        strFileName = .FileName
    End If
    
End With

    '儲存檔案
    
    Me.Caption = ""
End Sub


Private Sub Form_Load()
blnRunReDo = False
StartPOS = 0
End Sub

Private Sub optReplace_Click()
If optReplace.Value = True Then
    txtReplace.Enabled = True
    
End If
End Sub

Private Sub optSearch_Click()
If optSearch.Value = True Then
    txtReplace.Enabled = False
    
End If
End Sub


