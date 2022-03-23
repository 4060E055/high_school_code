Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(2) As String
    Dim n, a1(2), x, min As Integer 'n=輸入多少行資料

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ii(n) = Trim(sr.ReadLine) '取出每行輸入資料
            If ii(n) = "#" Then Exit Do
            '以下3行指令皆為判斷I、R、M的指令分別有多少，好方便宣告陣列
            If Microsoft.VisualBasic.Mid(ii(n), 1, 1) = "I" Then : a1(0) += 1
            ElseIf Microsoft.VisualBasic.Mid(ii(n), 1, 1) = "R" Then : a1(1) += 1
            ElseIf Microsoft.VisualBasic.Mid(ii(n), 1, 1) = "M" Then : a1(2) += 1
            End If
            n += 1 : ReDim Preserve ii(n)
        Loop
        n -= 1 : ReDim Preserve ii(n)

        Dim aa1(a1(0) - 1, 1), aa2(a1(1) - 1, 3), aa3(a1(2) - 1, 1) As Integer '宣告I、R、M的陣列
        a1(0) = 0 : a1(1) = 0 : a1(2) = 0
        For i = 0 To n
            x = -1
            For j = 1 To Len(ii(i)) '分解每行的輸入
                If Microsoft.VisualBasic.Mid(ii(i), 1, 1) = "I" Then
                    For k = j + 1 To Len(ii(i))
                        If Microsoft.VisualBasic.Mid(ii(i), k, 1) <> " " Then
                            aa1(a1(0), 0) &= Microsoft.VisualBasic.Mid(ii(i), k, 1)
                            If Microsoft.VisualBasic.Mid(ii(i), k + 1, 1) = " " Then
                                For l = k + 2 To Len(ii(i))
                                    If Microsoft.VisualBasic.Mid(ii(i), l, 1) <> " " Then
                                        aa1(a1(0), 1) &= Microsoft.VisualBasic.Mid(ii(i), l, 1)
                                        If l = Len(ii(i)) Then a1(0) += 1 : GoTo 1
                                    End If
                                Next
                            End If
                        End If
                    Next
                ElseIf Microsoft.VisualBasic.Mid(ii(i), 1, 1) = "R" Then
                    For k = j + 1 To Len(ii(i))
                        If Microsoft.VisualBasic.Mid(ii(i), k, 1) <> " " Then
                            aa2(a1(1), x) &= Microsoft.VisualBasic.Mid(ii(i), k, 1)
                            If k = Len(ii(i)) Then a1(1) += 1 : GoTo 1
                        ElseIf Microsoft.VisualBasic.Mid(ii(i), k + 1, 1) <> " " Then
                            x += 1
                        End If
                    Next
                ElseIf Microsoft.VisualBasic.Mid(ii(i), 1, 1) = "M" Then
                    For k = j + 1 To Len(ii(i))
                        If Microsoft.VisualBasic.Mid(ii(i), k, 1) <> " " Then
                            aa3(a1(2), 0) &= Microsoft.VisualBasic.Mid(ii(i), k, 1)
                            If Microsoft.VisualBasic.Mid(ii(i), k + 1, 1) = " " Then
                                For l = k + 2 To Len(ii(i))
                                    If Microsoft.VisualBasic.Mid(ii(i), l, 1) <> " " Then
                                        aa3(a1(2), 1) &= Microsoft.VisualBasic.Mid(ii(i), l, 1)
                                        If l = Len(ii(i)) Then a1(2) += 1 : GoTo 1
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next
1:      Next

        Dim c(a1(0) - 1), b(2) As Integer
        For j = 0 To a1(2) - 1 '每個點選地區

            n = 0 : ReDim b(2), c(a1(0) - 1) : x = 0

            For k = 0 To a1(1) - 1 '先找出它是否位於某些視窗中
                If aa3(j, 0) > aa2(k, 0) And aa3(j, 1) > aa2(k, 1) And aa3(j, 0) < aa2(k, 2) And aa3(j, 1) < aa2(k, 3) Then
                    b(n) = k + 65 : x += 1
                    n += 1 : ReDim Preserve b(n)
                End If
                If k = a1(1) - 1 And x <> 0 Then
                    min = b(0)
                    For l = 0 To n - 1 '若有重複堆疊,則判斷哪個視窗是最後出現的
                        If min < b(l) Then min = b(l)
                    Next
                    sw.WriteLine(Chr(min)) : GoTo 2 '輸出
                End If
            Next

            '----------------------------------------------------------------------
            For k = 0 To a1(0) - 1 '若無在視窗中,則先求出他離所有icon的距離的2次方
                c(k) = (aa1(k, 0) - aa3(j, 0)) ^ 2 + (aa1(k, 1) - aa3(j, 1)) ^ 2
            Next
            min = c(0) : x = 0
            For k = 0 To a1(0) - 1 '比對差,找出離最近得icon
                If min > c(k) Then min = c(k) : x = k
            Next
            n = 0
            For k = 0 To a1(0) - 1 '找出是否有一樣近的icon
                If min = c(k) Then
                    b(n) = k
                    n += 1 : ReDim Preserve b(n)
                End If
            Next

            Array.Sort(b) '小到大排序
            For k = 1 To n '輸出
                sw.Write(Space(3 - Len(CStr(b(k) + 1))) & b(k) + 1)
            Next
            sw.WriteLine()
2:      Next
     
        sw.Flush() : sw.Close() : End
    End Sub
End Class
