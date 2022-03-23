Imports System.IO
Public Class 書
    Dim f1 As New FileInfo("test1.txt") '輸入檔
    Dim g1 As New FileInfo("result1.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim a As Byte '(代替數)  答案
    Dim z() As Byte '每校人數
    Dim b1, d1 As Integer '  d1=有多少因數
    Dim c() As Integer '因數集合
    Dim x As Byte '有多少所學校

    Private Sub 書_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Sub zxc() '提出資料
        Dim sr As StreamReader = f1.OpenText
        x = Val(sr.ReadLine) '輸入資料(參賽學校數)
        If x < 2 OrElse x > 50 Then '檢驗輸入資料的正確性
            MsgBox("請輸入2~100內的數", MsgBoxStyle.Critical, "注意!!")
            End
        Else

            ReDim c(x - 1) : ReDim z(x - 1)
            For i = 0 To x - 1
                z(i) = Val(sr.ReadLine) '輸入資料(參賽學生人數)
                If Val(z(i)) < 2 OrElse Val(z(i)) > 100 Then '檢驗輸入資料的正確性
                    MsgBox("請輸入正確", MsgBoxStyle.Critical, "注意!!")
                    End
                End If

            Next
            sr.Close()
            '運算
            Array.Sort(z) '由小到大排列
            For i = z(0) To 2 Step -1
                For j = 0 To x - 1
                    If z(j) Mod i = 0 Then '計算此數是否為每個數的最大因數
                        b1 += 1
                        If b1 = x Then '每個數皆為此數的因數時成立
                            c(d1) = i '輸入該因數
                            d1 += 1 '計算有多少因數
                            For k = 0 To x - 1
                                z(k) = z(k) / i '這樣才不會有重複因數
                            Next
                        End If
                    End If
                Next
                b1 = 0
            Next
            a = 1
            For i = 0 To (d1 - 1)
                a *= c(i) '把所有計算的因數乘起來
            Next
            sw.Write(a) '輸出答案
            sw.Flush() : sw.Close()
        End If
        End
    End Sub
End Class
