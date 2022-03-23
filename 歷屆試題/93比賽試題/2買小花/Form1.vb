Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("test2.txt") '輸入檔
    Dim g1 As New FileInfo("result2.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim x, a(4) As Byte 'x=有多少錢  a=每朵花的數量
    Dim b() As Byte = {50, 10, 5, 1} '每朵花的金額

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入黨是否存在
            Dim sr As StreamReader = f1.OpenText
            x = Val(sr.ReadLine) '輸入資料($$)
            If x > 99 OrElse x < 1 Then '檢驗資料輸入的正確性
                MsgBox("請輸入1~99的金額", MsgBoxStyle.Critical, "注意!!")
                End
            End If
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("找不到檔案", MsgBoxStyle.Critical, "注意")
            End
        End If

    End Sub
    Sub zxc()
        For i = 0 To 3
            a(i) = x \ b(i) '計算每種花個別數量
            x = x - b(i) * a(i) '計算剩餘金錢
            a(4) += a(i) '計算總購買花數
        Next
        sw.WriteLine(a(4)) '輸出總購買花數
        For i = 0 To 3 '輸出個別購買花數
            sw.WriteLine(a(i))
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
