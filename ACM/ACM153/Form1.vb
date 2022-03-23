Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(2), aa As String
    Dim n, ia(2), x, oo(2), z, nn As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do
            ii(n) = Trim(sr.ReadLine)
            If ii(n) = "#" Then Exit Do
            ReDim ia(Len(ii(n)) - 1) : nn = 0
            For i = 1 To Len(ii(n)) '分解輸入資料並轉換成asc碼
                ia(i - 1) = Asc(Microsoft.VisualBasic.Mid(ii(n), i, 1))

            Next
            aa = ""
            Array.Sort(ia) '利用asc碼小到大排序
            For i = 1 To Len(ii(n)) '檢查是否跟輸入資料一樣
                aa &= Chr(ia(i - 1))
            Next
            If aa = ii(n) Then GoTo 2
1:          x = 0 : z = 0
            For i = Len(ii(n)) - 1 To 1 Step -1
                If ia(i) > ia(i - 1) And i = Len(ii(n)) - 1 Then
                    x = ia(i) : ia(i) = ia(i - 1) : ia(i - 1) = x : aa = ""
                    For j = 0 To Len(ii(n)) - 1 '檢查轉換後的結果是否跟輸入資料一樣
                        aa &= Chr(ia(j))
                    Next
                    nn += 1 '計算轉換多少次
                    If aa = ii(n) Then Exit For
                    GoTo 1
                ElseIf ia(i) > ia(i - 1) And i <> Len(ii(n)) Then

                    ReDim oo(2)
                    x = ia(i) - ia(i - 1) : z = i
                    For j = i + 1 To Len(ii(n)) - 1 '找出要交換的變數(找出最小差)
                        If ia(j) - ia(i - 1) < x And ia(j) - ia(i - 1) > 0 Then x = ia(j) - ia(i - 1) : z = j
                    Next
                    x = ia(i - 1) : ia(i - 1) = ia(z) : ia(z) = x '交換
                    z = 0
                    For j = i To Len(ii(n)) - 1

                        oo(z) = ia(j) : z += 1 : ReDim Preserve oo(z) '將要排序的變數丟到oo
                    Next

                    ReDim Preserve oo(z - 1) : aa = ""
                    Array.Sort(oo) : z = 0
                    For j = i To Len(ii(n)) - 1 '將排好的變數丟到原序列裡
                        ia(j) = oo(z) : z += 1
                    Next
                    For j = 0 To Len(ii(n)) - 1 '檢查轉換後的結果是否跟輸入資料一樣
                        aa &= Chr(ia(j))
                    Next
                    nn += 1 '計算轉換多少次
                    If aa = ii(n) Then Exit For
                    GoTo 1

                End If
            Next
2:          sw.WriteLine(nn + 1)
            n += 1 : ReDim Preserve ii(n)
        Loop


        sw.Flush() : sw.Close() : End
    End Sub
End Class
