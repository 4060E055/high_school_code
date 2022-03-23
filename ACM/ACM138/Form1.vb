Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, b, n, oa(9, 1), i As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If fw.Exists = False Then
            fw.Create()
        End If

        Do
            i += 1 '計算到第i號
            a = 0 : b = 0
            For j = i - 1 To 1 Step -1 '往後加總
                a += j
            Next
            For j = i + 1 To i * 2 '往前加總
                b += j
                If a = b Then '相等則輸出
                    sw.WriteLine(Space(10 - Len(CStr(i))) & i & Space(10 - Len(CStr(j))) & j) : n += 1 : Exit For
                ElseIf b > a Then : Exit For
                End If
            Next
            If n = 10 Then Exit Do '條件滿足則結束
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
