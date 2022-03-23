Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Integer
    Dim ic(2), a As Integer
    Dim ib, aa As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine
        For i = 1 To ia
            ib = Trim(sr.ReadLine)
            ReDim ic(2) : n = 0 : aa = ""
            For j = 1 To Len(ib)
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    aa &= Microsoft.VisualBasic.Mid(ib, j, 1)
                Else
                    ic(n) = Val(aa) : aa = ""
                    n += 1 : ReDim Preserve ic(n)
                End If
            Next
            ic(n) = Val(aa) : aa = ""
            a = ic(1) - ic(0)
            For j = 0 To n - 1
                If a <> ic(j + 1) - ic(j) Then
                    sw.WriteLine("G " & ic(j + 1) / ic(j)) : Exit For
                ElseIf j = n - 1 Then
                    sw.WriteLine("A " & a)
                End If
            Next
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
