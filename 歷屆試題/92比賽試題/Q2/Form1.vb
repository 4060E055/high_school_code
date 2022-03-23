Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔2.txt") '輸入檔
    Dim g1 As New FileInfo("輸出檔2.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim ans1(1), ans2(), ans3(), z As String 'ans1 = 要相乘的兩數   ans2 = 中間相乘的結果  z=輸入的資料(乘數結果(2進位)) 
    Dim a(2), b, c As Integer ' a = 乘數  b= (代替數)
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
        z = sr.ReadLine '提出資料

        For k = 1 To Len(z)
            If Asc(Microsoft.VisualBasic.Mid(z, k, 1)) <> 32 AndAlso _
                Microsoft.VisualBasic.Mid(z, k, 1) <> "x" Then '如果那一行的那一個字不為0 則執行程式

                ans1(b) &= Microsoft.VisualBasic.Mid(z, k, 1) '連接那一行的那個數
            ElseIf Microsoft.VisualBasic.Mid(z, k, 1) = "x" Then
                b += 1 '下一行
            End If
        Next
        If Len(ans1(0)) > 10 OrElse Len(ans1(1)) > 10 Then '檢驗輸入資料的正確性
            MsgBox("輸入的資料錯誤，程式即將結束執行")
            End
        End If

        '-------------------計算結果------------------------------------
        ReDim ans2(Len(ans1(1)) - 1), ans3(Len(ans1(0)) + Len(ans1(1)) + 1)

        For i = 1 To Len(ans1(1))  '計算n個中間數
            ans2(i - 1) = Val(ans1(0)) * Val(Microsoft.VisualBasic.Mid(ans1(1), i, 1))
            If ans2(i - 1) = 0 Then
                For k = 1 To Len(ans1(0)) - 1
                    ans2(i - 1) &= "0"
                Next
            End If
        Next
        Array.Reverse(ans2)

        For k = 0 To 1 '將兩數轉換為10進位
            b = 0
            For i = Len(ans1(k)) To 1 Step -1
                a(k) += Microsoft.VisualBasic.Mid(ans1(k), i, 1) * 2 ^ (b)
                b += 1
            Next
        Next

        a(2) = a(0) * a(1) '兩數(十進位)相乘

        ReDim ans3(Len(ans1(0)) + Len(ans1(1)) + 1)

        b = a(2) * 2
        c = 0
        Do '將乘數結果換成2進位
            b = b \ 2
            ans3(c) = CStr(b Mod 2)
            c += 1
        Loop Until b = 1

        '--------輸出結果--------------------------------------------

        '輸出前3行結果
        sw.WriteLine(Space(20 - Len(ans1(0))) & ans1(0))
        sw.WriteLine(Space(20 - Len(ans1(1))) & ans1(1))
        sw.WriteLine("--------------------")

        For i = 1 To Len(ans1(1)) '輸出中間區段結果
            sw.WriteLine(Space(20 - Len(ans2(i - 1)) - i + 1) & ans2(i - 1))
        Next

        sw.WriteLine("--------------------")

        For i = c To 1 Step -1 '連接相乘後的結果
            ans3(c) &= ans3(i - 1)
        Next
        sw.WriteLine(Space(20 - Len(ans3(c))) & ans3(c)) '輸出相乘後的結果
        sw.Flush() : sw.Close() '存檔  關閉
        End '關閉執行程式
    End Sub

End Class
