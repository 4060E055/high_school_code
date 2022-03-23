Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-5-2.txt")
    Dim fw As New FileInfo("out-5-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, oo(2), sum, n1 As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        For i = 2 To ii
            sum = 0
            For j = 1 To i - 1 '找出他的因數
                If i Mod j = 0 Then sum += j
                If sum > i Then Exit For '若目前因數家總大於原數則下一個
                If j = i - 1 And sum = i Then
                    oo(n1) = i : n1 += 1 : ReDim Preserve oo(n1)
                End If
            Next
        Next

        Array.Sort(oo)
        For i = 1 To n1
            sw.WriteLine(oo(i))
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
