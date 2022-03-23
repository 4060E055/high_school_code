Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii(1), aa As String
    Dim n, x, a, b As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do '將輸入檔裡ㄉ每行分別取出
            ii(n) = Trim(sr.ReadLine)
            n += 1
            ReDim Preserve ii(n)
        Loop Until ii(n - 1) = ""

        n -= 1 : ReDim Preserve ii(n - 1)

        Dim lhr(n - 1, 2) As Integer 'lhr=輸入ㄉ個別資料 

        For i = 0 To n - 1 '分解每行數
            x = 0
            For j = 1 To Len(ii(i))
                If Microsoft.VisualBasic.Mid(ii(i), j, 1) <> " " Then
                    lhr(i, x) &= Microsoft.VisualBasic.Mid(ii(i), j, 1)
                Else
                    x += 1
                End If
            Next
        Next

        x = 0
        For i = 0 To n - 1 '找出長到哪
            If x < lhr(i, 2) Then x = lhr(i, 2)
        Next

        Dim ss(x) As Integer

        For i = 0 To n - 1 '將每個位置ㄉ高度帶入
            a = lhr(i, 0) : b = lhr(i, 2)
            For j = a To b
                If lhr(i, 1) > ss(j - 1) Then '判斷高度比他大才帶入
                    ss(j - 1) = lhr(i, 1)
                End If
            Next
        Next
        a = 0
        For i = 0 To x
            If ss(i) > a Then
                sw.Write(i + 1 & " " & ss(i) & " ")
                a = ss(i)
            ElseIf ss(i) < a Then
                sw.Write(i & " " & ss(i) & " ")
                a = ss(i)
            End If


        Next


        sw.Flush() : sw.Close() : End
    End Sub
End Class
