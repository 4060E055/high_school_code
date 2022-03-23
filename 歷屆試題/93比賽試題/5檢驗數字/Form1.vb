Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("test5.txt") '輸入檔
    Dim g1 As New FileInfo("result5.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    Dim b, d As Byte '有多少阿拉伯數字'代替數
    Dim c As String '輸入的字串
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If f1.Exists Then '判斷輸入檔是否存在
            If g1.Exists Then '判斷輸出檔是否存在
                Call zxc()
            Else '不存在則創建
                g1.Create()
                Call zxc()
            End If
        Else '不存在則結束執行
            MsgBox("未找到test5.txt檔", MsgBoxStyle.Critical, "注意!!")
            End
        End If
    End Sub
  
    Sub zxc()
        Dim sr As StreamReader = f1.OpenText
        c = sr.ReadLine '讀取輸入字串
        If Len(c) < 1 OrElse Len(c) > 100 Then '檢驗輸入正確性
            MsgBox("輸入已超過範圍,限定輸入1-100個字元", MsgBoxStyle.Critical, "注意!!")
            End
        End If
        For i = 1 To Len(c) '執行n個字串個數的迴圈
            d = Asc(Microsoft.VisualBasic.Mid(c, i, 1)) '取締n個字
            If d <= 57 AndAlso d >= 48 Then '檢驗是否為阿拉伯數字
                b += 1
            End If
        Next
        sw.Write(b) '輸出答案
        sw.Flush()
        sw.Close()
        End
    End Sub

End Class
