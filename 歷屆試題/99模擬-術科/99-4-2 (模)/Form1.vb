Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-4-2.txt")
    Dim fw As New FileInfo("out-4-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, nn(23, 4), n, ib(3) As Integer 'ii=買幾種東西 nn=可能購買種類 n=計數變數 ib=每項商品購買金額
    Dim ia() As String = {"肉", "菜", "蛋", "果"}
    Dim iii, ic(23, 3) As String 'iii=地2行輸入資料 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        iii = Trim(sr.ReadLine)

        For i = 1 To Len(iii) '帶入4種商品購買金額
            If Asc(Microsoft.VisualBasic.Mid(iii, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(iii, i, 1)) <= 57 Then
                ib(n) &= Microsoft.VisualBasic.Mid(iii, i, 1)
            ElseIf Microsoft.VisualBasic.Mid(iii, i, 1) = "," Then
                n += 1
            End If
        Next

        n = 0
        For i = 0 To 3 '列出全部可能
            For j = 0 To 3
                For k = 0 To 3
                    For l = 0 To 3
                        If i <> j And j <> k And k <> l And i <> l And i <> k And j <> l Then
                            nn(n, 0) = i : nn(n, 1) = j : nn(n, 2) = k : nn(n, 3) = l : n += 1
                        End If
                    Next
                Next
            Next
        Next

        For i = 0 To 23
            For j = 0 To 3
                For k = 1 To ii '計算所有可能的購買金額
                    If nn(i, j) + 1 = k Then nn(i, 4) += ib(j)
                Next
            Next
        Next

        For i = 0 To 23 '找出每種各是購買那些東西
            For k = 0 To 3
                For l = 1 To ii
                    If nn(i, k) + 1 = l Then : ic(i, k) = 2 : Exit For
                    ElseIf l = ii Then : ic(i, k) = 1
                    End If
                Next
            Next
        Next

        For i = 0 To 23
            For j = 0 To 23 '依個總可能的購買總金額大到小排序
                If nn(i, 4) > nn(j, 4) Then
                    For k = 0 To 3
                        n = ic(i, k) : ic(i, k) = ic(j, k) : ic(j, k) = n
                    Next
                    For k = 0 To 4
                        n = nn(i, k) : nn(i, k) = nn(j, k) : nn(j, k) = n
                    Next
                End If
            Next
        Next

        For i = 0 To 23
            For j = 0 To 23 '篩選找出有重複位置的
                For k = 0 To 3
                    If ic(i, k) <> ic(j, k) Then : Exit For
                    ElseIf k = 3 And i <> j Then
                        For l = 0 To 3
                            ic(j, l) = 0
                        Next
                    End If
                Next
            Next
        Next

        For i = 0 To 23
            If ic(i, 0) <> 0 Then
                For j = 0 To 3
                    If ic(i, j) = 2 Then : sw.Write("(" & ia(j) & ")")
                    Else : sw.Write(ia(j))
                    End If
                Next
                sw.Write("　" & nn(i, 4) & vbNewLine)
            End If
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
