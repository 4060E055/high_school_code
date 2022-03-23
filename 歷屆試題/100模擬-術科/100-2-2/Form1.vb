Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in2-2.txt")
    Dim fw As New FileInfo("out2-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii As String
    Dim ia(14, 14), ib(2), ic(2) As Byte
    Dim n, a, b(14) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)


        For i = 0 To 14 '分解輸入資料
            For j = 0 To 14
                ia(i, j) = Microsoft.VisualBasic.Mid(ii, j + 1, 1)
            Next
            ii = Trim(sr.ReadLine)
        Next

        For i = 0 To 14
            a = i
            For j = 0 To 14

                If ia(i, j) = 1 Then
                    b(j) = i
                ElseIf ia(i, j) = 0 Then
                    If i > 0 And i < 14 Then '第2~14行
                        If ia(i + 1, j) = 1 Then
                            b(j) = i + 1 : i += 1
                        ElseIf ia(i - 1, j) = 1 Then

                            b(j) = i - 1 : i -= 1
                        ElseIf j > 0 Then
                            If ia(i + 1, j - 1) = 1 Then
                                i += 1 : j -= 1
                            ElseIf ia(i - 1, j - 1) = 1 Then
                                i -= 1 : j -= 1
                            Else : Exit For
                            End If
                        Else : Exit For
                        End If



                    ElseIf i = 0 Then '第1行
                        If ia(i + 1, j) = 1 Then
                            b(j) = i + 1 : i += 1
                        ElseIf j > 0 Then
                            If ia(i + 1, j - 1) = 1 Then
                                i += 1 : j -= 1

                            Else : Exit For
                            End If
                        Else : Exit For
                        End If

                    ElseIf i = 14 Then '第15行
                        If ia(i - 1, j) = 1 Then
                            b(j) = i - 1 : i -= 1
                        Else : Exit For
                        End If

                    End If
                End If
                If j = 14 Then
                    For k = 0 To 14 '檢驗是否牆都是連起來的
                        If b(k) = 0 Then
                            For l = 0 To 14
                                b(l) = 0
                            Next
                            Exit For
                        ElseIf k = 14 Then
                            GoTo 1
                        End If
                    Next
                    i = a
                End If
            Next
            If i = 14 Then Exit For
            i = a
        Next

1:
        Do


            ii = Trim(sr.ReadLine)
2:          n = 0 : ReDim ib(2), ic(2)
            For j = 1 To Len(ii) '輸入起點位置
                If Microsoft.VisualBasic.Mid(ii, j, 1) <> " " Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ii, j, 1)
                Else : n += 1
                End If
            Next

            n = 0
            ii = Trim(sr.ReadLine)
            For j = 1 To Len(ii) '輸入終點位置
                If Microsoft.VisualBasic.Mid(ii, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ii, j, 1)
                Else : n += 1
                End If
            Next


            If ib(0) > b(ib(1) - 1) Then : ib(2) = 1 '找出分界點 算出他在哪個區域
            Else : ib(2) = 0
            End If
            If ic(0) > b(ic(1) - 1) Then : ic(2) = 1
            Else : ic(2) = 0
            End If
            If ib(2) = ic(2) Then : sw.WriteLine("TRUE") '檢測是否同區域中
            Else : sw.WriteLine("FALSE")
            End If

            ii = Trim(sr.ReadLine) : ii = Trim(sr.ReadLine)
            If ii = "" Then : Exit Do
            Else : GoTo 2
            End If


        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
