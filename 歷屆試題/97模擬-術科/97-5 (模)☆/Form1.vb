Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, ic(2), sum(2), icc(2) As String
    Dim n, x, ib(2), ibb(2) As Integer

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
            ReDim ib(2), ic(2) : n = 0
            For i = 1 To Len(ia)
                If Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) <= 57 Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, i, 1)
                Else
                    n += 1 : ReDim Preserve ib(n), ic(n - 1)
                    ic(n - 1) = Microsoft.VisualBasic.Mid(ia, i, 1)
                End If
            Next

            ReDim sum(2), icc(n - 1), ibb(n) : x = 0

            For i = 1 To n - 1  '括多少數
                For j = 0 To n - 1 '泡沫
                    If j + i <= n Then
                        For k = 0 To n
                            If k <> n Then icc(k) = ic(k)
                            ibb(k) = ib(k)
                        Next


                        For k = j To j + i - 1  '從哪括到哪
                            If icc(k) = "*" Then '先計算括號內乘的
                                If ibb(k + 1) = 0 Then
                                    For l = k + 2 To j + i - 1
                                        If l <> 0 Then
                                            ibb(k) = ibb(k) * ibb(l) : ibb(l) = 0
                                        End If
                                    Next
                                Else
                                    ibb(k) = ibb(k) * ibb(k + 1)
                                    ibb(k + 1) = 0 : icc(k) = ""
                                End If
                            End If
                        Next

                        For k = j To j + i - 1
                            If icc(k) = "+" Then '計算括號內+與-
                                ibb(k) = ibb(k) + ibb(k + 1) : ibb(k + 1) = 0
                            ElseIf ic(k) = "-" Then
                                ibb(k) = ibb(k) - ibb(k + 1) : ibb(k + 1) = 0
                            End If
                        Next

                        For k = 0 To n - 1
                            If icc(k) = "*" Then '先計算完整乘的
                                If ibb(k + 1) = 0 Then
                                    For l = k + 2 To n
                                        If l <> 0 Then
                                            ibb(k) = ibb(k) * ibb(l) : ibb(l) = 0
                                        End If
                                    Next
                                Else
                                    ibb(k) = ibb(k) * ibb(k + 1)
                                    ibb(k + 1) = 0 : icc(k) = ""
                                End If
                            End If
                        Next
                        For k = 0 To n - 1
                            If icc(k) = "+" Then '計算完整+與-
                                ibb(k) = ibb(k) + ibb(k + 1) : ibb(k + 1) = 0
                            ElseIf ic(k) = "-" Then
                                If ibb(k + 1) = 0 Then
                                    For l = k + 2 To n
                                        If l <> 0 Then
                                            ibb(k) = ibb(k) - ibb(l) : ibb(l) = 0
                                        End If
                                    Next

                                Else
                                    ibb(k) = ibb(k) - ibb(k + 1) : ibb(k + 1) = 0
                                End If

                            End If
                        Next

                        For k = n To 0 Step -1 '帶入該算是的加總
                            If ibb(k) <> 0 Then sum(x) = ibb(k) : x += 1 : ReDim Preserve sum(x) : Exit For
                        Next

                    Else : Exit For
                    End If
                Next
            Next

            Array.Sort(sum)
            Array.Reverse(sum)
            sw.WriteLine(sum(0))

        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
