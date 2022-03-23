Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔4.txt") '輸入檔
    Dim g1 As New FileInfo("輸出檔4.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim su(0), ss(), z, x As Single 'su = 輸入或產生的新數  ss = 平方,分解  z = (代替數)  x = 個數
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '檢驗輸入檔是否存在
            If g1.Exists Then '檢驗輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("找不到檔案，程式即將結束", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub


    Sub zxc()
        Dim sr As StreamReader = f1.OpenText

        '-------------------帶入數------------------------------------
        z = sr.ReadLine '提出輸入的資料
        If z <= 1 OrElse z <> Fix(z) Then '檢驗輸入的正確性
            MsgBox("輸入錯誤，程式即將結束執行", MsgBoxStyle.Critical, "注意!")
            End
        End If


        '----------------計算----------------------------------------
        Do

            ReDim Preserve su(x)
            su(x) = z '丟入新數

            x += 1 '計算算出多少新數
            z = Len(CStr(su(x - 1) ^ 2)) '新數的平方
            ReDim ss(z - 1)
            For i = 1 To z '分解新數來比對
                ss(i - 1) = Val(Microsoft.VisualBasic.Mid(su(x - 1) ^ 2, i, 1))
            Next
            Array.Sort(ss) '小到大排序
            z = Val(ss(0) & ss(z - 1))  '最小數字與最大數字結合

            Erase ss '清除ss陣列

        Loop Until su.Contains(z) = True '如果有重複及跳出
        ReDim Preserve su(x)
        su(x) = z '丟入最後的新數


        '------------------輸出-------------------------
        For i = 0 To x
            If i = x Then sw.Write("*") '重複的數前面連接*
            sw.Write(su(i) & vbTab & Space(4 - Len(CStr(su(i) ^ 2))) & su(i) ^ 2 & vbNewLine)
        Next

        sw.Flush() : sw.Close() '存檔  關閉
        End '關閉執行程式
    End Sub

End Class
