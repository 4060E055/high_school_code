Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1), aa As String
    Dim a, b, n As Integer
    Dim oa(51, 51) As String
    Dim ob(51) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do

            ii(0) = Trim(sr.ReadLine) & " "
3:          a = 0 : ii(1) = Trim(sr.ReadLine) & " "
            For i = 0 To 1

                For j = 1 To Len(ii(i))
                    If Microsoft.VisualBasic.Mid(ii(i), j, 1) <> " " Then
                        oa(a, 0) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
                    Else
                        a += 1
                    End If
                Next

            Next
            a -= 1

            For i = 0 To 51
                ob(i) = 1
            Next

1:          For i = 1 To 51

                If i - 3 >= 0 And oa(i, 0) <> "" Then

                    '當此牌與他左邊的第三張牌有「Match」的時候，就把這張牌移到那張牌上面去
                    If (Microsoft.VisualBasic.Mid(oa(i, ob(i) - 1), 1, 1) = Microsoft.VisualBasic.Mid(oa(i - 3, ob(i - 3) - 1), 1, 1) Or _
                        Microsoft.VisualBasic.Mid(oa(i, ob(i) - 1), 2, 1) = Microsoft.VisualBasic.Mid(oa(i - 3, ob(i - 3) - 1), 2, 1)) Then

                        oa(i - 3, ob(i - 3)) = oa(i, ob(i) - 1) : oa(i, ob(i) - 1) = "" : ob(i) -= 1 : ob(i - 3) += 1
                        b = i : Call zxc() : GoTo 1

                    Else : GoTo 2
                    End If
2:              ElseIf i - 1 >= 0 And oa(i, 0) <> "" Then

                    '當此牌與他左邊的牌有「Match」的時候，就把這張牌移到那張牌上面去
                    If Microsoft.VisualBasic.Mid(oa(i, ob(i) - 1), 1, 1) = Microsoft.VisualBasic.Mid(oa(i - 1, ob(i - 1) - 1), 1, 1) Or _
                        Microsoft.VisualBasic.Mid(oa(i, ob(i) - 1), 2, 1) = Microsoft.VisualBasic.Mid(oa(i - 1, ob(i - 1) - 1), 2, 1) Then
                        oa(i - 1, ob(i - 1)) = oa(i, ob(i) - 1) : oa(i, ob(i) - 1) = "" : ob(i) -= 1 : ob(i - 1) += 1
                        b = i : Call zxc() : GoTo 1
                    End If
                Else
                    Exit For
                End If
            Next

            aa = "" : n = 0
            If oa(1, 0) <> "" Then
                For i = 0 To 52
                    If oa(i, 0) <> "" Then
                        n += 1 : aa &= ob(i) & " "
                    Else : Exit For
                    End If
                Next
                sw.Write(n & " piles remaining: " & aa)
            Else
                sw.WriteLine("1 pile remaining: 52")
            End If
            sw.WriteLine()
            ii(0) = Trim(sr.ReadLine) & " "
            If ii(0) = "# " Then
                Exit Do
            Else
                ReDim oa(51, 51) : GoTo 3
            End If

        Loop

        sw.Flush() : sw.Close() : End
    End Sub
    Sub zxc()

        For j = b To 50 '如果因為移動一張牌使得產生一個空格，把右邊所有的牌堆往左移一格

            If oa(j, 0) = "" And oa(j + 1, 0) <> "" Then

                oa(j, 0) = oa(j + 1, ob(j + 1) - 1) : oa(j + 1, ob(j + 1) - 1) = "" : ob(j) += 1 : ob(j + 1) -= 1

            ElseIf ob(j + 1) - 1 <= 0 Then : Exit For
            End If
        Next

        For k = 0 To 51 '檢查用
            If oa(k, 0) <> "" Then
                sw.WriteLine()
            End If
            For l = 0 To 51
                If oa(k, l) <> "" Then
                    sw.Write(oa(k, l) & " ")
                End If
            Next
        Next
        sw.WriteLine(vbNewLine & "---------------------")

    End Sub
End Class

