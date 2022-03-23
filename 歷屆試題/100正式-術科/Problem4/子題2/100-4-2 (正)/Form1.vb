Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in1.txt")
    Dim frr As New FileInfo("in2.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, n2(4), n1(4), n, max, bb, x, s As Integer 'ii=幾筆資料 n2=每組資料的數字部分 
    Dim qq() As String = {"C", "D", "H", "S,"}
    Dim ia(2), aa As String 'n1=每組資料的花色部分 ia=每筆輸入資料 aa=交換用

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Or frr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Dim srr As StreamReader = frr.OpenText


        For i = 0 To 1 '2個黨
            If i = 0 Then ii = Trim(sr.ReadLine)
            If i = 1 Then ii = Trim(srr.ReadLine)

            Dim nn(ii - 1, 2) As Integer
            ReDim ia(2) : x = 0
            For j = 1 To ii '分解輸入資料並個別帶入
                If i = 0 Then ia(x) = Trim(sr.ReadLine) : x += 1 : ReDim Preserve ia(x)
                If i = 1 Then ia(x) = Trim(srr.ReadLine) : x += 1 : ReDim Preserve ia(x)

                ReDim n2(4), n1(4)
                n = 0
                For k = 1 To Len(ia(x - 1))
                    If Asc(Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)) >= 65 And _
                        Asc(Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)) <= 90 Then '判斷是符號還數字
                        aa = Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)

                        Select Case aa    '將花色轉換成數字(方便判斷)
                            Case "C"
                                n1(n) = 1
                            Case "D"
                                n1(n) = 2
                            Case "H"
                                n1(n) = 3
                            Case "S"
                                n1(n) = 4
                        End Select

                    ElseIf Asc(Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)) >= 48 _
                        And Asc(Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)) <= 57 Then
                        n2(n) &= Microsoft.VisualBasic.Mid(ia(x - 1), k, 1)
                    ElseIf Microsoft.VisualBasic.Mid(ia(x - 1), k, 1) = " " Then : n += 1 '若為空白則跳下一個
                    End If

                Next

                For k = 0 To 4 '依數字由小到大排序
                    For l = k To 4
                        If n2(k) > n2(l) Then
                            aa = n2(k) : n2(k) = n2(l) : n2(l) = aa
                            aa = n1(k) : n1(k) = n1(l) : n1(l) = aa
                        End If
                    Next
                Next

                For k = 0 To 3 '判斷是否為順子
                    If n2(k) + 1 = n2(k + 1) And k = 3 Then '有加例外狀況(k to A)
                        nn(j - 1, 0) = 5
                        If n2(0) = 1 Then : nn(j, 2) = 14 '若最後一個為A 
                        Else : nn(j - 1, 2) = n2(4)
                        End If

                        For l = 0 To 3 '判斷是否為桐花
                            If n1(l) <> n1(l + 1) Then : Exit For
                            ElseIf l = 3 Then : nn(j - 1, 0) = 8 : nn(j - 1, 1) = n1(0)
                            End If
                        Next
                        GoTo 1
                    ElseIf n2(k) + 1 <> n2(k + 1) And (n2(0) <> 1 or n2(4) <> 13) Then : Exit For
                    End If
                Next

                max = 0
                For k = 0 To 4
                    n = 0
                    For l = 0 To 4
                        If n2(k) = n2(l) Then
                            n += 1
                            If n > max Then  max = n
                        End If

                        If n = 3 Or n = 4 Or k = 4 Then '找出最多一樣的排的數字的位自
                            s = 0
                            For m = 0 To 4
                                For o = 0 To 4
                                    If n2(m) = n2(o) And m <> o Then
                                        s += 1
                                        If s = max - 1 Then nn(j - 1, 2) = n2(m)
                                    End If
                                Next
                            Next
                           
                        End If

                        If max = 4 And l = 4 Then '判斷是否為4條
                            nn(j - 1, 0) = 7
                            GoTo 1
                        ElseIf max = 3 And l = 4 Then '判斷是否為葫蘆 or 3條
                            nn(j - 1, 0) = 4
                            For p = 0 To 4 '進階判斷是否為葫蘆
                                n = 0
                                For q = 0 To 4
                                    If n2(q) = n2(p) And n2(q) <> nn(j - 1, 2) Then n += 1
                                    If q = 4 And (n = 2 Or n = 3) Then nn(j - 1, 0) = 6
                                Next
                            Next
                            GoTo 1
                        ElseIf max = 2 And k = 4 Then '判斷是否為兩對 or 一對 or葫蘆
                            nn(j - 1, 0) = 2 : nn(j - 1, 1) = n1(k)


                            For p = 0 To 4
                                For q = 0 To 4
                                    If n2(k) = n2(q) And k <> q Then '找出1對中最大的花色
                                        If n1(k) > n1(q) Then : nn(j - 1, 1) = n1(k)
                                        Else : nn(j - 1, 1) = n1(q)
                                        End If
                                        Exit For
                                    End If
                                Next
                            Next

                            For p = 0 To 4 '進階判斷是否為兩對
                                For q = 0 To 4
                                    If n2(p) = n2(q) And p <> q And n2(p) <> nn(j - 1, 2) Then
                                        nn(j - 1, 0) = 3
                                        If nn(j - 1, 2) < n2(p) Then '找出兩隊中最大的對子
                                            nn(j - 1, 2) = n2(p)
                                            If n1(p) > n1(q) Then : nn(j - 1, 1) = n1(p) '找出地2對子中的最大的花色
                                            Else : nn(j - 1, 1) = n1(q)
                                            End If
                                        End If
                                        GoTo 1
                                    End If
                                Next
                            Next
                            GoTo 1
                        ElseIf k = 4 Then '以上都不是則為雜牌
                            max = n2(0) : n = 0
                            For m = 1 To 4 '找出最大數字
                                If n2(m) > max Then max = n2(m) : n = m
                            Next

                            nn(j - 1, 2) = max : max = n1(n)
                            For m = 0 To 4 '若最大數字不只一個  則在判斷它的花色
                                If n2(m) = n2(n) And n1(m) > max Then max = n1(m)
                            Next
                            nn(j - 1, 1) = max : nn(j - 1, 0) = 1

                            GoTo 1
                        End If
                    Next
                Next
1:          Next
            max = 0
            For l = 0 To ii - 1 '找出最大的排組
                If nn(l, 0) > nn(max, 0) Then '比對排的種類
                    max = l
                ElseIf nn(l, 0) = nn(max, 0) Then
                    If nn(l, 2) > nn(max, 2) Then '比對排的數字
                        max = l
                    ElseIf nn(l, 2) = nn(max, 2) Then
                        If nn(l, 1) > nn(max, 1) Then '比對排的花色
                            max = l
                        End If

                    End If
                End If
            Next
            sw.WriteLine(ia(max))

            For l = 0 To ii - 1 '找出最小的排組
                If nn(l, 0) < nn(max, 0) Then '比對排的種類
                    max = l
                ElseIf nn(l, 0) = nn(max, 0) Then
                    If nn(l, 2) < nn(max, 2) Then '比對排的數字
                        max = l
                    ElseIf nn(l, 2) = nn(max, 2) Then
                        If nn(l, 1) < nn(max, 1) Then '比對排的花色
                            max = l
                        End If
                    End If
                End If
            Next
            sw.WriteLine(ia(max) & vbNewLine)    
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
