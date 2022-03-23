Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim aa(1), n, x, z, a, b As Integer 'aa=輸入的兩筆資料 n=剩下多少人 x=計算要殺哪個 
    Dim ii As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ii = Trim(sr.ReadLine)
2:      n = 0 : ReDim aa(1)
        For i = 1 To Len(ii) '取數
            If Microsoft.VisualBasic.Mid(ii, i, 1) <> " " Then
                aa(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
            Else
                n += 1
            End If
        Next
        Dim oa(aa(0) - 1) As Integer
        If aa(0) = 1 Then sw.WriteLine(1) : GoTo 1 '若只有一人  則直接輸出
        n = aa(0) : ReDim Preserve oa(n) : x = 0

        For i = 1 To aa(0) '輸入每個位子的人的編號
            oa(i - 1) = i
        Next

        Do
10:
            For i = 1 To aa(1) '計算要被殺的人的位子
       
                x += 1
                If x > n And (n <> 3 Or x > (n + 1)) Then
6:                  x = x - n - 1  '如果算超出有的人數,則歸0繼續算
                    If x > n Then x += 1 : GoTo 6
                ElseIf x > n Then
                    x = x - n   '如果算超出有的人數,則歸0繼續算
                End If

                a = x
                If i = aa(1) Then '如果找到位置之後再找出替補的人的位置
                    If x = 0 Then x += 1
                    For j = 1 To aa(1)
                        a += 1
                        If a > n Then a -= n
                        If oa(x - 1) = oa(a - 1) Then
                            a += 1
                            If a > n Then a -= n
                        End If

                        If j = aa(1) Then

                            oa(x - 1) = oa(a - 1) : oa(a - 1) = 0 : n -= 1
                            z = oa(x - 1)
                        End If
                    Next


                    For j = a - 1 To n - 1 '替補空缺
                        oa(j) = oa(j + 1) : oa(j + 1) = 0
                    Next

                    If n = 2 Then '勝兩個數時則直接判斷哪個數是最後存活的

                        If aa(1) Mod 2 = 0 Then
                            For j = 0 To 1
                                If oa(j) = z Then
                                    oa(j) = 0 : z = j : Exit For
                                End If
                            Next

                            For j = z To n - 1 '替補空缺
                                oa(j) = oa(j + 1) : oa(j + 1) = 0
                            Next
                            n -= 1 : GoTo 4

                        Else
                            For j = 0 To 1
                                If oa(j) <> z Then
                                    oa(j) = 0 : z = j : Exit For
                                End If
                            Next
                            For j = z To n - 1 '替補空缺
                                oa(j) = oa(j + 1) : oa(j + 1) = 0
                            Next

                            n -= 1 : GoTo 4
                        End If

                    End If

                    If n <> 1 Then GoTo 10


                End If


            Next

4:          If oa(0) = 1 And n = 1 Then
                sw.WriteLine(1) : Exit Do
            ElseIf n = 1 Then
                x = 0
                For i = 1 To aa(0) '找出從哪開始算才不會被殺
                    x += 1
                    If oa(0) + x > aa(0) Then
                        sw.WriteLine(1 + x) : Exit Do
                    End If
                Next
            End If
        Loop
1:      ii = Trim(sr.ReadLine)
        If ii <> "0 0" Then GoTo 2


        sw.Flush() : sw.Close() : End
    End Sub
End Class
