Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔5.txt")
    Dim g1 As New FileInfo("輸出檔5.txt")
    Dim sw As StreamWriter = g1.CreateText
    Dim score(), num(), rank(), x, z As Byte 'score=輸入成績 num=學號 rank=名次  x=有多少成績 z=(代替數)
    Dim a As String ' a = (代替數)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出檔是否存在
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
        Do
            a = sr.ReadLine '提出數

            If a = "" Then Exit Do
            ReDim Preserve score(x + 1)
            For i = 1 To Len(a)
                If Asc(Microsoft.VisualBasic.Mid(a, i, 1)) = 32 Then '如果為空白  才開始連接需要的資料
                    For k = i + 1 To Len(a)
                        If Asc(Microsoft.VisualBasic.Mid(a, k, 1)) = 32 Then
                            Exit For '以防使用者資料多輸入
                        Else : score(x) &= Val(Microsoft.VisualBasic.Mid(a, k, 1))
                        End If
                    Next
                    Exit For
                End If
            Next
            x += 1 '計算有多少個成績
        Loop
        If x > 50 OrElse x < 1 Then '檢驗資料正確性
            MsgBox("資料輸入錯誤，程式即將結束執行", MsgBoxStyle.Critical, "注意!")
            End
        End If
        ReDim Preserve num(x - 1), rank(x - 1) '重新宣告學號  名次的變數(保留資料)
        For i = 0 To x - 1 '輸入學號
            num(i) = i + 1
        Next

        '------------處理------------------------------------
        For k = 0 To x - 1 '將分數由大到小排序
            For i = 0 To x - 1
                If score(k) > score(i) Then '如果大於則交換成績
                    z = score(k) : score(k) = score(i) : score(i) = z
                    z = num(k) : num(k) = num(i) : num(i) = z '☆學號跟分數是一起變動
                End If
            Next
        Next

        z = 0
        For i = 0 To x - 1  '成績排名
            rank(i) = z + 1 '輸入排名
            If score(i) > score(i + 1) Then z += 1 '如果成績大於下一個成績才進到下一個名次
        Next

        '-------------------輸出--------------
        sw.WriteLine("學號   程式設計   名次")
        For i = 1 To x
            sw.WriteLine(Space(2 - Len(CStr(num(i - 1)))) & num(i - 1) & Space(10 - Len(CStr(score(i - 1)))) _
                          & score(i - 1) & Space(9 - Len(CStr(rank(i - 1)))) & rank(i - 1))
        Next

        sw.Flush() : sw.Close() '存檔  關閉
        End '結束
    End Sub
End Class
