Imports System.IO
Public Class Form1
    Dim i1 As New FileInfo("in-3-1-1.txt")
    Dim ii1 As New FileInfo("in-3-1-2.txt")
    Dim o1 As New FileInfo("out3-1.txt")
    Dim o2 As StreamWriter = o1.CreateText
    Dim mm, ll As String '身分證字號  第一個英文字
    Dim z As Byte = 9  '代替數
    Dim l11, l22, ii As Byte '第一個英文字對照的十位數語個位數 'ii=多少筆資料
    Dim dd(8), a123(25) As Integer '1-9數+檢測碼    a-z i o 相對應的數
    Dim abc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "I", "O"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If i1.Exists = False Or ii1.Exists = False Then
            MsgBox("輸入檔不存在,程式即將結束執行")
            End
        End If
        If o1.Exists = False Then
            o1.Create()
        End If
        Dim i2 As StreamReader = i1.OpenText
        Dim ii2 As StreamReader = ii1.OpenText


      

        For i = 0 To 25 '輸入A-Z I O的編號
            a123(i) = i + 10
        Next

        For i = 0 To 1 '兩格輸入檔
            If i = 0 Then ii = i2.ReadLine
            If i = 1 Then ii = ii2.ReadLine
            For j = 1 To ii '每個輸入檔有ii筆資料
                If i = 0 Then mm = i2.ReadLine '輸入身分證
                If i = 1 Then mm = ii2.ReadLine '輸入身分證


                ll = Microsoft.VisualBasic.Mid(mm, 1, 1) '第一個數
                '取得Y對應的數再將十位數  個位數  帶到2個變數中
                l11 = Val(Microsoft.VisualBasic.Left(a123(Array.IndexOf(abc, ll)), 1))
                l22 = Val(Microsoft.VisualBasic.Right(a123(Array.IndexOf(abc, ll)), 1))

                For k = 0 To 7 '輸入身分證1-8個數
                    dd(k) = Val(Microsoft.VisualBasic.Mid(mm, k + 2, 1))
                Next

                '計算檢查碼
                z = 9
                dd(8) = l11 + l22 * 9
                For k = 0 To 7
                    z -= 1
                    dd(8) += dd(k) * z
                Next

                dd(8) = 10 - dd(8) Mod 10
                '比對檢查碼正確與否
                If dd(8) = Val(Microsoft.VisualBasic.Right(mm, 1)) Then
                    o2.WriteLine("1")
                Else
                    o2.WriteLine("0")
                End If

            Next
        Next
      
        o2.Flush() : o2.Close()
        End
    End Sub
End Class
