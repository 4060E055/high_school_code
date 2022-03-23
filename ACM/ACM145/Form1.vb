Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim hh(,) As Double = {{0.1, 0.06, 0.02}, {0.25, 0.15, 0.05}, _
                           {0.53, 0.33, 0.13}, {0.87, 0.47, 0.17}, {1.44, 0.8, 0.3}}
    Dim ii(2) As String
    Dim n, x, a As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do '取數
            ii(n) = Trim(sr.ReadLine)
            If ii(n) = "#" Then Exit Do
            n += 1 : ReDim Preserve ii(n)
        Loop
        ReDim Preserve ii(n - 1) : n -= 1

        Dim ia(n, 1) As String '地區,號碼
        Dim ib(n, 3) As Integer '開始時間~結束時間(時,分,時,分)
        Dim oa(n, 3) As Single '每個區域所使用的地分鐘數,總金額

        For i = 0 To n '帶入輸入的數
            ia(i, 0) = Microsoft.VisualBasic.Left(ii(i), 1) : x = 0 : a = 0
            For j = 3 To Len(ii(i))
                If Microsoft.VisualBasic.Mid(ii(i), j, 1) = " " Then x += j + 1 : Exit For
                ia(i, 1) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
            Next
    
            For j = x To Len(ii(i))
                If Microsoft.VisualBasic.Mid(ii(i), j, 1) <> " " Then
                    ib(i, a) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
                Else
                    a += 1
                End If
            Next

            If ib(i, 2) < ib(i, 0) Then '判斷是否終間有中斷

                For j = ib(i, 0) To 23 'x-24HR
                    If j >= 8 And j < 18 Then '8-18HR
                        oa(i, 0) += 60
                        If j = ib(i, 0) Then oa(i, 0) -= ib(i, 1)

                    ElseIf j >= 18 And j < 22 Then '18-22HR
                        oa(i, 1) += 60
                        If j = ib(i, 0) Then oa(i, 1) -= ib(i, 1)

                    Else '22-8HR
                        oa(i, 2) += 60
                        If j = ib(i, 0) Then oa(i, 2) -= ib(i, 1)

                    End If
                Next

                For j = 0 To ib(i, 2) '0-x HR
                    If j >= 8 And j < 18 Then '8-18HR
                        oa(i, 0) += 60
                        If j = ib(i, 2) Then oa(i, 0) -= (60 - ib(i, 3))
                    ElseIf j >= 18 And j < 22 Then '18-22HR
                        oa(i, 1) += 60
                        If j = ib(i, 2) Then oa(i, 1) -= (60 - ib(i, 3))
                    Else '22-8HR
                        If j = ib(i, 2) Then
                            oa(i, 2) += ib(i, 3)
                        Else
                            oa(i, 2) += 60
                        End If
                    End If
                Next

            ElseIf ib(i, 2) = ib(i, 0) Then '24HR

                oa(i, 0) = (18 - 8) * 60
                oa(i, 1) = (22 - 18) * 60
                oa(i, 2) = (24 - 22 + 8) * 60

            Else '無中斷的時間

                For j = ib(i, 0) To ib(i, 2)
                    If j >= 8 And j < 18 Then '8-18HR

                        If j = ib(i, 0) Then
                            oa(i, 0) -= ib(i, 1)
                        ElseIf j = ib(i, 2) Then
                            oa(i, 0) += ib(i, 3)
                        Else : oa(i, 0) += 60
                        End If

                    ElseIf j >= 18 And j < 22 Then '18-22HR
                        If j = ib(i, 0) Then
                            oa(i, 1) -= ib(i, 1)
                        ElseIf j = ib(i, 2) Then
                            oa(i, 1) += ib(i, 3)
                        Else : oa(i, 1) += 60
                        End If
                    Else '22-8HR
                        If j = ib(i, 0) Then
                            oa(i, 2) += (60 - ib(i, 1))
                        ElseIf j = ib(i, 2) Then
                            oa(i, 2) += ib(i, 3)
                        Else : oa(i, 2) += 60
                        End If
                    End If
                Next
            End If

            For j = 0 To 2
                oa(i, 3) += oa(i, j) * hh((Asc(ia(i, 0)) - 65), j)
            Next

            sw.WriteLine(Space(10 - Len(ia(i, 1))) & ia(i, 1) & Space(6 - Len(CStr(oa(i, 0)))) & oa(i, 0) _
                  & Space(6 - Len(CStr(oa(i, 1)))) & oa(i, 1) & Space(6 - Len(CStr(oa(i, 2)))) & oa(i, 2) _
            & Space(2) & ia(i, 0) & Space(8 - Len(CStr(Format(oa(i, 3), "####.00")))) & Format(oa(i, 3), "####.00"))

        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
