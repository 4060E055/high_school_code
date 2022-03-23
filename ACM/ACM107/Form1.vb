Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(2) As String '每列輸入ㄉ資料
    Dim n, x, a, b As Integer 'n=多少組資料
    Dim h As Single
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do '計算有幾組資料
            n += 1
            ii(n - 1) = Trim(sr.ReadLine) & " "
            If ii(n - 1) = "0 0 " Then Exit Do
            ReDim Preserve ii(n)
        Loop
        n -= 1
        Dim ia(n - 1, 3) As Integer '(每組資料,貓ㄉ高度and最後工作ㄉ貓ㄉ數目AND 變出N隻貓ㄉ"n+1" and nㄉx次方ㄉx)
        For i = 0 To n - 1
            x = 0
            For j = 1 To Len(ii(i))
                If Microsoft.VisualBasic.Mid(ii(i), j, 1) <> " " Then
                    ia(i, x) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
                Else
                    x += 1
                End If
            Next
        Next

        For i = 0 To n - 1
            For j = 2 To ia(i, 0)
                h = ia(i, 0) : x = 0
                Do
                    h = h / j
                    x += 1
                    If h = 1 Then ia(i, 2) = j : ia(i, 3) = x : Exit For
                Loop Until h < 1
            Next
        Next

        For i = 0 To n - 1
            a = 0 : b = 0
            For j = 1 To ia(i, 3) '計算總共有幾隻貓
                a += (ia(i, 2) - 1) ^ j
                b += (ia(i, 2) - 1) ^ j * (1 / ia(i, 2)) ^ j * ia(i, 0)
            Next
            sw.WriteLine(a - ia(i, 1) + 1 & " " & b + ia(i, 0))
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
