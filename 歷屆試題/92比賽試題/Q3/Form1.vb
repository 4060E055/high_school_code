Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔3.txt") '輸入檔
    Dim g1 As New FileInfo("輸出檔3.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim w, n, n1(), n2(), z As Integer ' w = 偏移量 n=字母個數 nn = 轉換後的數 z = 偏碼值
    Dim r1, abc(9), r2 As String 'r1 = 輸入數  abc = 對應數編碼(0-9) r2 = 結果 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("找不到檔案", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub
    Sub zxc()
        Dim sr As StreamReader = f1.OpenText
        '-------------------對應數------------------------------------
        For i = 97 To 106 '輸入a-j
            abc(i - 97) = Chr(i)
        Next

        '-------------------帶入數------------------------------------
        r1 = sr.ReadLine '取數(需加密的字串)
        n = Len(r1) '取出該字串的位數
        For i = 1 To Len(r1) '計算有多少個字母

            If Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) = 32 Then
                n -= 1 '減掉字串數中的空白
            ElseIf Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) < 65 OrElse Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) > 90 Then
                MsgBox("資料輸入錯誤，程式即將結束執行", MsgBoxStyle.Critical, "注意!") '檢驗資料的正確性
                End
            End If
        Next


        '------------------------計算-------------------------------
        w = n Mod 10 '計算偏移量
        ReDim n1(n - 1), n2(n - 1)

        For i = 1 To Len(r1)
            If Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) <> 32 Then '取出第n個英文字

                z = Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) + w '開始偏移
                If z > 90 Then z = 65 + (z - 90) '該數的偏碼值
                For k = 0 To 9   ' 比對該十位數字所對應到的英文字母
                    If Val(Microsoft.VisualBasic.Mid(z, 1, 1)) = k Then
                        r2 &= abc(k)
                    End If
                Next
                For k = 0 To 9   ' 比對該個位數字所對應到的英文字母
                    If Val(Microsoft.VisualBasic.Mid(z, 2, 1)) = k Then
                        r2 &= abc(k)
                    End If
                Next
            ElseIf Asc(Microsoft.VisualBasic.Mid(r1, i, 1)) = 32 Then
                r2 &= "*" '為空白則連接*
            End If
        Next
        r2 &= "#"
        '--------------輸出------------------------------------------
        For i = 1 To Len(CStr(n))
            For k = 0 To 9 '測試該數對應到字母a-j的哪個
                If Val(Microsoft.VisualBasic.Mid(n, i, 1)) = k Then
                    r2 &= abc(k) '對應到則連接
                End If
            Next
        Next
        sw.WriteLine("**" & r2 & "***") '輸出結果

        sw.Flush() : sw.Close() '存檔  關閉
        End '關閉執行程式
    End Sub
End Class
