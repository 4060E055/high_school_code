Imports System.IO
Public Class Form1
    Dim f1 As New FileInfo("輸入檔6.txt") '輸入檔
    Dim g1 As New FileInfo("輸出檔6.txt") '輸出檔
    Dim sw As StreamWriter = g1.CreateText
    '矩陣aa,bb,cc = (行數,每行的第幾個) z1=aa的列數 x1=aa的行數  z2=bb的列數  x2=bb的行數  (下面的註解)
    Dim aa(4, 4), bb(4, 4), cc(0, 0), z1, x1, z2, x2 As SByte
    Dim ss, rr As String   'ss = (取數)

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
        '-------------取數-----------------------------------------------
        ss = sr.ReadLine '取出第n行全部的字
        Do
            x1 = 0
            For i = 1 To Len(ss) '每行1個1個字元慢慢取出
                If Asc(Microsoft.VisualBasic.Mid(ss, i, 1)) <> 32 Then
                    rr &= Microsoft.VisualBasic.Mid(ss, i, 1) '不為空白才連接那個字元
                ElseIf Asc(Microsoft.VisualBasic.Mid(ss, i, 1)) = 32 Then
                    aa(z1, x1) = Val(rr) '為空白的話把連接出的字丟掉數裡
                    rr = ""  '☆以免重複連接
                    x1 += 1 '計算有幾行
                End If
            Next

            aa(z1, x1) = Val(rr) '☆避免漏掉
            rr = "" '☆以免重複連接
            z1 += 1 '計算有幾列
            ss = sr.ReadLine '取出第n行全部的字
        Loop Until ss = "" '如果沒字好取才跳出
        ss = sr.ReadLine

        Do
            x2 = 0
            For i = 1 To Len(ss) '每行1個1個字元慢慢取出
                If Asc(Microsoft.VisualBasic.Mid(ss, i, 1)) <> 32 Then
                    rr &= Microsoft.VisualBasic.Mid(ss, i, 1) '不為空白才連接那個字元
                ElseIf Asc(Microsoft.VisualBasic.Mid(ss, i, 1)) = 32 Then
                    bb(z2, x2) = Val(rr) '為空白的話把連接出的字丟掉數裡
                    rr = "" '☆以免重複連接
                    x2 += 1 '計算有幾行
                End If
            Next

            bb(z2, x2) = Val(rr) '☆避免漏掉
            rr = "" '☆以免重複連接
            z2 += 1 '計算有幾列
            ss = sr.ReadLine '取出第n行全部的字
        Loop Until ss = "" '如果沒字好取才跳出

        '----------------------計算----------------------------------------
        ReDim cc(z1 - 1, x2)

        For i = 0 To z1 - 1 'c的列數
            For k = 0 To x2 'c的行數
                For j = 0 To x1 '第n個cc=第i行aa*第k列bb的加總
                    cc(i, k) += aa(i, j) * bb(j, k)
                Next
            Next
        Next

        For i = 0 To z1 - 1 '輸出
            For k = 0 To x2
                sw.Write(cc(i, k) & Space(1))
            Next
            sw.Write(vbNewLine) '換行
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
