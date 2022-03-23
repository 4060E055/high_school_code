Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in2-1.txt")
    Dim fw As New FileInfo("out2-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii As String
    Dim ia(14, 14) As Byte
    Dim n, a, b(14) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)
        Do

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
                        b(j) = 1
                    ElseIf ia(i, j) = 0 Then
                        If i > 0 And i < 14 Then '第2~14行
                            If ia(i + 1, j) = 1 Then
                                b(j) = 1 : i += 1
                            ElseIf ia(i - 1, j) = 1 Then

                                b(j) = 1 : i -= 1
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
                                b(j) = 1 : i += 1
                            ElseIf j > 0 Then
                                If ia(i + 1, j - 1) = 1 Then
                                    i += 1 : j -= 1

                                Else : Exit For
                                End If
                            Else : Exit For
                            End If

                        ElseIf i = 14 Then '第15行
                            If ia(i - 1, j) = 1 Then
                                b(j) = 1 : i -= 1
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
                                sw.WriteLine("FALSE") : GoTo 1
                            End If
                        Next
                        i = a
                    End If
                Next
                If i = 14 Then sw.WriteLine("TRUE") : Exit For
                i = a
            Next

1:          ii = Trim(sr.ReadLine)
            If ii = "" Then Exit Do
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
