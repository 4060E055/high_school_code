Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("test3.txt") '輸入檔
    Dim g1 As New FileInfo("result3.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim ab(5) As Double 'a1  b1  a2  b2  a3  b3
    Dim a, b As Double '分子  分母
    Dim d As String '輸入的資料

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            Dim sr As StreamReader = f1.OpenText

            For i = 0 To 4 Step 2
                d = sr.ReadLine '提出資料(字串)
                If d = "" Then '檢驗該字串是否存在
                    MsgBox("未輸入完整程式將結束執行", MsgBoxStyle.Critical)
                    End
                End If
                For j = 1 To Len(d) - 1 '執行N個字串個數的迴圈
                    If Asc(Microsoft.VisualBasic.Mid(d, j, 1)) <> 32 Then '如果不為空白即連接成一整個數
                        ab(i) &= Val(Microsoft.VisualBasic.Mid(d, j, 1))
                    ElseIf Asc(Microsoft.VisualBasic.Mid(d, j, 1)) = 32 Then '為空白跳到下一個數在開始連接
                        For k = j + 1 To Len(d)
                            ab(i + 1) &= Val(Microsoft.VisualBasic.Mid(d, k, 1))
                        Next
                        Exit For '結束回圈
                    End If
                Next
            Next
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("未找到檔案", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub

    Sub zxc()
        a = ab(0) * (ab(3) * ab(5) + ab(4)) '計算分子
        b = ab(1) * (ab(3) * ab(5) + ab(4)) + ab(4) * ab(5) '計算分母
        For i = 2 To a
            If a Mod i = 0 AndAlso b Mod i = 0 Then '算算分子分母共通的因數
                a = a / i : b = b / i '化簡分子分母
            End If
        Next
        sw.WriteLine(a & Space(2) & b) '寫入答案
        sw.Flush()
        sw.Close()
        End
    End Sub

End Class
