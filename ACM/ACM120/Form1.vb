Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim oa(3), n, aa, a, b, c As Integer
    Dim ii As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = Trim(sr.ReadLine)
        Do
            n = 0:  ReDim oa(2)
            For i = 1 To Len(ii) '取第n行的數
                If Microsoft.VisualBasic.Mid(ii, i, 1) <> " " Then
                    oa(n) &= Microsoft.VisualBasic.Mid(ii, i, 1)
                Else
                    n += 1
                    ReDim Preserve oa(n)
                End If
            Next

            Array.Reverse(oa)
            For i = n To 0 Step -1
                sw.Write(oa(i) & " ")
            Next
            sw.WriteLine()

            b = 0
            Do
                For i = n + 1 To 1 Step -1
                    If i <> oa(b) Then '如果該數不在應在的位子上
                        a = 0
                        For j = 0 To n '求現在該數在哪個位置
                            If i = oa(j) Then a = j : Exit For
                        Next

                        c = n
                        For j = a To (n - a + 1) \ 2 + a - 1 '從該數開始反轉
                            aa = oa(j) : oa(j) = oa(c) : oa(c) = aa
                            c -= 1
                            If j = (n - a + 1) \ 2 + a - 1 Then sw.Write(a + 1 & " ")
                        Next
                        c = n
                        For j = b To n \ 2  '將該數丟到他應在的位置
                            aa = oa(j) : oa(j) = oa(c) : oa(c) = aa
                            c -= 1
                            If j = n \ 2 Then sw.Write(b + 1 & " ")
                        Next
                    End If

                    Array.Reverse(oa)
                    For j = 0 To n
                        If oa(j) <> j + 1 Then
                            Exit For
                        ElseIf j = n Then : Exit Do
                        End If
                    Next
                    Array.Reverse(oa)

                    b += 1
                Next
            Loop
            sw.WriteLine(0)
            ii = Trim(sr.ReadLine)
            If ii = "" Then Exit Do
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
