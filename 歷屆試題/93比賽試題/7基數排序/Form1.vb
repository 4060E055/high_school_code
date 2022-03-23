Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("test7.txt") '輸入檔
    Dim g1 As New FileInfo("result7.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim x As Byte '輸入個數
    Dim z(), y(4) As String 'z=每個輸入的數  y=個十百

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("未找到輸入檔test7.txt", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub
    Sub zxc()
        Dim sr As StreamReader = f1.OpenText
        x = sr.ReadLine '提出資料(數值個數)
        If x < 2 OrElse x > 10 Then '檢驗資料正確性
            MsgBox("輸入錯誤", MsgBoxStyle.Critical, "注意!!")
            End
        End If
        ReDim z(x - 1)
        For i = 0 To x - 1
            z(i) = sr.ReadLine '輸入各數值
            If z(i) = "" Then '檢驗資料是否存在
                MsgBox("未輸入完整", MsgBoxStyle.Critical, "注意!!")
                End
            ElseIf Len(z(i)) > 3 Then '檢驗資料正確性
                MsgBox("輸入數最大長度只能3位數", MsgBoxStyle.Critical, "注意!!")
                End
            End If
        Next

        For i = 0 To 3
            For s = 0 To 4 '弄成結果輸出資料之一
                y(i) &= z(s)
                If s <> 4 Then y(i) &= "、"
            Next

            If i = 3 Then Exit For '避免多算錯誤
            For j = 0 To 4
                For k = 0 To 3
                    '分別以各 十 百 位數來排大小
                    If Val(Microsoft.VisualBasic.Right(z(k), i + 1)) > Val(Microsoft.VisualBasic.Right(z(k + 1), i + 1)) Then
                        y(4) = z(k) '交換數
                        z(k) = z(k + 1)
                        z(k + 1) = y(4)
                    End If
                Next
            Next
        Next
        For i = 0 To 3
            sw.WriteLine(y(i)) '寫入資料
        Next
        sw.Flush() : sw.Close()
        End

    End Sub

End Class
