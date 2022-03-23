Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim ib, aa As String
    Dim ic(2), n, oa(2), x As Integer 'oa=計算所有總和
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine

        For i = 1 To ia
            ib = Trim(sr.ReadLine) & " "
            ReDim ic(2) : n = 0
            For j = 1 To Len(ib)
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    aa &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                    ic(n) = Val(aa) : aa = ""
                    n += 1 : ReDim Preserve ic(n)
                End If
            Next
            ReDim oa(2) : x = 0
            For j = 1 To n '+多少數

                For k = 1 To n '從哪裡開始+
                    If k + j - 1 <= n Then
                        For l = k To k + j - 1 '開始加
                            oa(x) += ic(l - 1)
                        Next
                        x += 1 : ReDim Preserve oa(x)

                    End If
                Next
            Next
            ReDim Preserve oa(x - 1)
            Array.Sort(oa)
            Array.Reverse(oa)
            sw.WriteLine(oa(0))
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
