VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.Form PRD02 
   BorderStyle     =   1  '��u�T�w
   Caption         =   "²���s�边"
   ClientHeight    =   8355
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   7950
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   8355
   ScaleWidth      =   7950
   StartUpPosition =   2  '�ù�����
   Begin VB.Frame Frame1 
      Caption         =   "�M��Ψ��N"
      BeginProperty Font 
         Name            =   "�s�ө���"
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
         Caption         =   "�T�@�w"
         BeginProperty Font 
            Name            =   "�s�ө���"
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
         Caption         =   "�^�_���N"
         Enabled         =   0   'False
         BeginProperty Font 
            Name            =   "�s�ө���"
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
         Caption         =   "�����M��"
         BeginProperty Font 
            Name            =   "�s�ө���"
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
            Name            =   "�s�ө���"
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
            Name            =   "�s�ө���"
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
         Caption         =   "�@���N���G"
         BeginProperty Font 
            Name            =   "�s�ө���"
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
         Caption         =   "�M��ؼСG"
         BeginProperty Font 
            Name            =   "�s�ө���"
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
      Caption         =   "���N"
      BeginProperty Font 
         Name            =   "�s�ө���"
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
      Caption         =   "�j�M"
      BeginProperty Font 
         Name            =   "�s�ө���"
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
      Caption         =   "�t�s�s��"
      BeginProperty Font 
         Name            =   "�s�ө���"
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
      Caption         =   "�}������"
      BeginProperty Font 
         Name            =   "�s�ө���"
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
      Caption         =   "�إ߷s��"
      BeginProperty Font 
         Name            =   "�s�ө���"
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

'�O��"�M��"��"���N"����l��m(�Ĥ@������ɰ_�l��m)
Dim FoundPOS, FoundPOS2 As Integer

'�O��"�M��"��"���N"������m
Dim SetPOS, SetPOS2 As Integer

'�O��"�M��"��"���N"���ҩl��m(�O���\��i�椤���U�@�Ӱ_�l��m)
Dim StartPOS, StartPOS2 As Integer

'�O���M��Ψ��N����r�C���
Dim SelColor As Double

'�O��"�M��"��"���N"�̫��쪺��m
Dim LastFoundPOS As Integer
Public Sub FindString(tmpSearchText As String)
SelColor = &HFF&

'��l��StartPOS����
If FoundPOS = -1 Or blnRunReDo = True Then
    FoundPOS = 0
    StartPOS = 0
End If

Do While (FoundPOS <> -1)
    '�]�w�}�l�M�䪺��m�A�M��۲Ť�r
    
    
    '�p�G�O����ReDo�\��A�h�u�@��W���m������m
    If blnRunReDo = True Then
        If (FoundPOS > LastFoundPOS) And (LastFoundPOS <> -1) Then Exit Do
    End If
    
    '�}�l�j�M
    If FoundPOS <> -1 Then

        
        '�]�w��쪺��r������
        rtfText.SelBold = True
        '�]�w��쪺��r�C�⬰����
        rtfText.SelColor = SelColor
    End If
        
    '�Y�S���Ŀ�u�����M��v�A�h�Ȱ���@���N���}
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
    '�]�w�}�l�M�䪺��m�A�M��۲Ť�r
    
    
    '�O���̫�@�ӧ�쪺��m
    If blnRunReDo = False Then LastFoundPOS = FoundPOS2
    
    If FoundPOS2 <> -1 Then

        
        '�]�w��쪺��r������
        rtfText.SelBold = True
        '�]�w��쪺��r�C�⬰����
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

'�Y��ܪ����جO"�j�M�\��"
If optSearch.Value = True Then
    
End If

'�Y��ܪ����جO"���N�\��"
If optReplace.Value = True Then
    
End If

End Sub

Private Sub btnOpenFile_Click()
Dim strFileName As String

With dlgFile
    .DialogTitle = "�}������"
    .CancelError = True
    
    '�]�w�ɮ׿z�����
    .Filter = ""
    
    .ShowOpen
    
    If Len(.FileName) = 0 Then
        Exit Sub
    Else
        strFileName = .FileName
    End If
    
End With

'���J���

Me.Caption = ""
rtfText.Locked = False
End Sub


Private Sub btnReDo_Click()
blnRunReDo = True

'����ReDo


blnRunReDo = False
btnReDo.Enabled = False

End Sub

Private Sub btnSaveFile_Click()
Dim strFileName As String

With dlgFile
    .DialogTitle = "�t�s�s��"
    .Filter = ""
    .ShowSave
    
    If Len(.FileName) = 0 Then
        Exit Sub
    Else
        strFileName = .FileName
    End If
    
End With

    '�x�s�ɮ�
    
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


