Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As String
    Dim ib(2), n, a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = Trim(sr.ReadLine)
            If ia = "" Then Exit Do
            ReDim ib(2) : n = 0
            For i = 1 To Len(ia) '帶入術
                If Microsoft.VisualBasic.Mid(ia, i, 1) <> " " Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, i, 1)
                Else
                    n += 1 : ReDim Preserve ib(n)
                End If
            Next

            For i = 0 To n '依第一位數由小到大排序
                For j = i + 1 To n
                    If Microsoft.VisualBasic.Left(ib(i), 1) > Microsoft.VisualBasic.Left(ib(j), 1) Then
                        a = ib(i) : ib(i) = ib(j) : ib(j) = a
                    End If
                Next
            Next

            For i = 0 To n
                For j = i + 1 To n '若第一位數一樣在一後幾位排序
                    If Microsoft.VisualBasic.Left(ib(i), 1) = Microsoft.VisualBasic.Left(ib(j), 1) Then
                        If Len(CStr(ib(i))) <> Len(CStr(ib(j))) Then '如果兩者長度不一 則將他們弄到一樣長度

                            If Len(CStr(ib(i))) > Len(CStr(ib(j))) Then
                                a = ib(j)
                                For k = j + 1 To n '將他們長度取道一樣
                                    For l = 1 To Len(CStr(ib(k)))
                                        a &= Microsoft.VisualBasic.Mid(ib(k), l, 1)
                                        If Len(ib(i)) = Len(a) Then k = n + 1 : Exit For
                                    Next
                                Next

                                For k = 1 To Len(CStr(ib(i))) '判斷誰大誰小
                                    If Microsoft.VisualBasic.Mid(ib(i), k, 1) > Microsoft.VisualBasic.Mid(a, k, 1) Then
                                        a = ib(i) : ib(i) = ib(j) : ib(j) = a : Exit For
                                    End If
                                Next
                            Else
                                a = ib(i)
                                For k = i + 1 To n '將他們長度取道一樣
                                    For l = 1 To Len(CStr(ib(k)))
                                        a &= Microsoft.VisualBasic.Mid(ib(k), l, 1)
                                        If Len(ib(j)) = Len(a) Then k = n + 1 : Exit For
                                    Next
                                Next
                            End If

                            For k = 1 To Len(CStr(ib(i))) '判斷誰大誰小
                                If Microsoft.VisualBasic.Mid(ib(i), k, 1) > Microsoft.VisualBasic.Mid(a, k, 1) Then
                                    a = ib(i) : ib(i) = ib(j) : ib(j) = a : Exit For
                                End If
                            Next


                        ElseIf Len(CStr(ib(i))) = Len(CStr(ib(j))) Then
                            For k = 1 To Len(CStr(ib(i)))
                                If Microsoft.VisualBasic.Mid(ib(i), k, 1) > Microsoft.VisualBasic.Mid(ib(j), k, 1) Then
                                    a = ib(i) : ib(i) = ib(j) : ib(j) = a : Exit For
                                End If
                            Next
                        End If
                    End If
                Next
            Next

            For i = 0 To n
                sw.Write(ib(i))
            Next
            sw.WriteLine()

        Loop


        sw.Flush() : sw.Close() : End
    End Sub
End Class
