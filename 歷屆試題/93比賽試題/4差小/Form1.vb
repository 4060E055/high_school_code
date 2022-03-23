Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("test4.txt") '輸入檔
    Dim g1 As New FileInfo("result4.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim x, z(), a, n() As Byte ' 人數  體重 代替數 加總
    Dim b(), bb As String ' 答案 代替數
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出黨是否存在
                Call zxc()
            Else '不存在則創建一個
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("找不到test4.txt檔", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub

    Sub zxc()

        Dim sr As StreamReader = f1.OpenText
        x = Val(sr.ReadLine) '取出學生總數

        If x < 4 OrElse x > 20 Then '檢驗輸入數是否正確
            MsgBox("輸入人數錯誤", MsgBoxStyle.Critical, "注意!!")
            End
        End If

        If x Mod 2 = 1 Then x -= 1 '確認是否為偶數

        ReDim z(x - 1)

        For i = 0 To x - 1 '讀檔
            z(i) = sr.ReadLine '取出個別學生體重
            If z(i) < 30 OrElse z(i) > 150 Then '檢驗輸入正確性
                MsgBox("輸入體重錯誤", MsgBoxStyle.Critical, "注意!!")
                End
            End If
        Next

            '運算
        Array.Sort(z) '由小到大排列
        ReDim b(x / 2 - 1), n(x / 2 - 1)
        For j = 1 To x
            n(j - 1) = z(j - 1) + z(x - j) '小+大的答案
            '每行輸出的答案
            b(j - 1) = n(j - 1) & Space(1) & "=" & Space(1) & z(j - 1) & Space(1) & "+" & Space(1) & z(x - j)
            If j = x / 2 Then Exit For
        Next

        For i = 1 To x / 2 - 1 '依總和由大排到小
            For j = 1 To x / 2 - 1
                If n(i - 1) > n(j - 1) Then
                    a = n(i - 1)
                    n(i - 1) = n(j - 1)
                    n(j - 1) = a

                    bb = b(i - 1)
                    b(i - 1) = b(j - 1)
                    b(j - 1) = bb
                End If
            Next
        Next

        '輸入答案
        For i = 0 To x / 2 - 1
            sw.WriteLine(b(i))
        Next
        sw.Flush() : sw.Close()
        End

    End Sub
End Class
