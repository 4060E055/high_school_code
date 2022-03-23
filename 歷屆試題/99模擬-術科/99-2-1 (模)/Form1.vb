Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-2-1.txt")
    Dim fw As New FileInfo("out-2-1.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ib(2), n, x As Integer
    Dim ia As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        For i = 1 To 4 '有4行輸入資料
            ia = Trim(sr.ReadLine)
            ReDim ib(2) : n = 0
            For j = 1 To Len(ia)
                If Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ia, j, 1)) <= 57 Then
                    ib(n) &= Microsoft.VisualBasic.Mid(ia, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ia, j, 1) = "," Then
                    n += 1 : ReDim Preserve ib(n)
                End If
            Next
            Array.Sort(ib):  Array.Reverse(ib)
1:          For j = 1 To ib(0)
                ib(j) -= 1
            Next
            ib(0) = -1
            Array.Sort(ib) : Array.Reverse(ib)
            ReDim Preserve ib(n - 1) : n -= 1
            x = 0
            For j = 0 To n
                If ib(j) <> 0 Then Exit For
                If j = n Then sw.WriteLine("正確") : GoTo 2
            Next
            For j = 0 To n
                If ib(j) < 0 Then sw.WriteLine("不正確") : GoTo 2
            Next
            GoTo 1
2:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
