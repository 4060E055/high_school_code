Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib, aa As String
    Dim ic(2) As Double
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
            ReDim ic(2) : n = 0
            For j = 1 To Len(ib)
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                    n += 1 : ReDim Preserve ic(n)
                End If
            Next
            ic(0) = 0
            For j = 1 To n
                ic(0) += ic(j)
            Next
            aa = Format(ic(0) / n, "#####.000")
            If Microsoft.VisualBasic.Right(aa, 1) > 4 Then
                ic(0) += 0.01
                aa = Format(ic(0) / n, "######.00")
            Else
                aa = Format(ic(0) / n, "######.00")
            End If
            sw.WriteLine(aa)
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
