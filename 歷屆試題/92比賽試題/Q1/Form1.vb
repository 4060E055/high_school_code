Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔1.txt") '輸入檔
    Dim g1 As New FileInfo("輸出檔1.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim str(5) As String '每行輸入資料的變數
    Dim ans(,), z, f, x() As Integer
    'ans(多少訂貨,4種產品分別數量) z=多少訂貨  f=連接第幾個數(3、2公分的總剩餘空間) x=訂貨的個別數量

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

        '-------------------帶入數------------------------------------
        Do
            str(z) = sr.ReadLine '把每一行丟入字串變數
            z += 1 '第幾行
        Loop While str(z - 1) <> "" '如果那一行沒有字  程式將會跳出迴圈
        z -= 1
        ReDim ans(z - 1, 3), x(z - 1) '重新定義輸入的變數  重新定義多少訂貨的變數

        For i = 0 To z - 1
            f = 0
            For k = 1 To Len(str(i)) '個別提出數
                If Asc(Microsoft.VisualBasic.Mid(str(i), k, 1)) <> 32 Then '測試該字是否為空白 
                    ans(i, f) &= Microsoft.VisualBasic.Mid(str(i), k, 1) '連接那一行的那個數
                Else  '否則
                    If ans(i, f) > 20000 Or ans(i, f) < 0 Then '檢驗資料正確性
                        MsgBox("資料輸入錯誤，程式即將結束執行", MsgBoxStyle.Critical, "注意!")
                        End
                    End If
                    f += 1 '下一行
                End If
            Next
        Next

        '-----------------------計算------------------------------------
        For i = 0 To z - 1
            x(i) += ans(i, 3) '計算4公分產品需要的箱子數量
            x(i) += ans(i, 2) '計算3公分產品需要的箱子數量
            f = ans(i, 2) * 44 '計算3公分產品剩餘空間
            x(i) += ans(i, 1) \ 8 '計算2公分產品需要的箱子數量
            If ans(i, 1) Mod 8 <> 0 Then '如果數量未能剛好裝滿n箱 則計算出剩餘空間
                f += (8 - (ans(i, 1) Mod 8)) * 8
                x(i) += 1 '箱子數量+1
            End If

            '若剩餘空間不夠裝1公分產品 則計算剩下的1公分產品需要的箱子數量
            If ans(i, 0) - f > 0 Then
                x(i) += (ans(i, 0) - f) \ (4 * 4 * 4) '計算1公分的產品能剛好裝滿多少箱子
                If (ans(i, 0) - f) Mod (4 * 4 * 4) <> 0 Then '若還有未滿一箱的1公分產品 則需再多1箱
                    x(i) += 1 '箱子數量+1
                End If
            End If
            sw.WriteLine(x(i)) '輸出答案(各筆訂購的最少包裝箱數目)
        Next

        sw.Flush() : sw.Close() '存檔  關閉
        End '關閉執行程式
    End Sub
End Class
