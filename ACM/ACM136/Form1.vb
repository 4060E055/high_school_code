Imports System.IO
Public Class Form1

    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim n, i As Integer
    Dim a() As Integer = {2, 3, 5}
    Dim aa(2) As Decimal
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If fw.Exists = False Then
            fw.Create()
        End If

        aa(0) = 1
        Do
            For k = 0 To 2
                For j = 0 To n '檢查是否有重複ㄉ
                    If aa(j) = a(k) * aa(i) Then
                        Exit For
                    ElseIf j = n Then
                        n += 1 : ReDim Preserve aa(n)
                        aa(n) = a(k) * aa(i) '乘以自己本身的倍數已得出新數
                    End If
                Next
            Next
            Array.Sort(aa) '小到大排列
            If n >= 1600 Then
                sw.WriteLine("The 1500'th ugly number is <" & aa(1499) & ">.") : Exit Do
            End If
            i += 1
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
