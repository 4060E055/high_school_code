Imports System.IO
Public Class Form1
    Dim i1 As New FileInfo("input.txt")
    Dim o1 As New FileInfo("output.txt")
    Dim o2 As StreamWriter = o1.CreateText
    Dim mm, ll As String '身分證字號  第一個英文字
    Dim z As Byte = 9  '代替數
    Dim l11, l22 As Byte '第一個英文字對照的十位數語個位數
    Dim dd(8), a123(25) As Integer '1-9數+檢測碼    a-z i o 相對應的數
    Dim abc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "I", "O"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If i1.Exists = False Then
            MsgBox("輸入檔不存在,程式即將結束執行")
            End
        End If
        If o1.Exists = False Then
            o1.Create()
        End If
        Dim i2 As StreamReader = i1.OpenText
        mm = i2.ReadLine  '輸入身分證

        '檢驗輸入正確性
        If Asc(Microsoft.VisualBasic.Left(mm, 1)) > 90 Or Asc(Microsoft.VisualBasic.Left(mm, 1)) < 65 Or Len(mm) <> 10 Then
            MsgBox("輸入錯誤,程式即將結束執行", MsgBoxStyle.Critical, "注意")
            End
        End If

        For i = 0 To 25 '輸入A-Z I O的編號
            a123(i) = i + 10
        Next

        ll = Microsoft.VisualBasic.Mid(mm, 1, 1) '第一個數
        '取得Y對應的數再將十位數  個位數  帶到2個變數中
        l11 = Val(Microsoft.VisualBasic.Left(a123(Array.IndexOf(abc, ll)), 1))
        l22 = Val(Microsoft.VisualBasic.Right(a123(Array.IndexOf(abc, ll)), 1))

        For i = 0 To 7 '輸入身分證1-8個數
            dd(i) = Val(Microsoft.VisualBasic.Mid(mm, i + 2, 1))
        Next

        '計算檢查碼
        dd(8) = l11 + l22 * 9
        For i = 0 To 7
            z -= 1
            dd(8) += dd(i) * z
        Next
        dd(8) = 10 - dd(8) Mod 10
        '比對檢查碼正確與否
        If dd(8) = Val(Microsoft.VisualBasic.Right(mm, 1)) Then
            o2.WriteLine("正確")
        Else
            o2.WriteLine("錯誤")
        End If
        o2.Flush() : o2.Close()
        End
    End Sub
End Class
