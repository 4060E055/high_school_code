Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib, ic(2) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine
        For i = 1 To ia
            ib = sr.ReadLine
            ReDim ic(2) : ic(0) = 2 : n = 1
            For j = 3 To ib - 1
                For k = 2 To j - 1
                    If j Mod k = 0 Then Exit For
                    If k = j - 1 Then ic(n) = j : n += 1 : ReDim Preserve ic(n)
                Next
            Next

            For j = 0 To n - 1 '找出哪兩個質數相加會=ib
                For k = 0 To n - 1
                    If ic(j) + ic(k) = ib And j <> k Then
                        sw.WriteLine(ic(j) & " " & ic(k)) : GoTo 1
                    End If
                Next
            Next
1:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
