Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib As String
    Dim ic(2), a As Integer
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
            For j = 1 To Len(ib) '帶入術
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then : n += 1
                End If
            Next

            Array.Sort(ic)

            For j = ic(0) To 1 Step -1 '找出最大公因數
                For k = 0 To 2
                    If ic(k) Mod j <> 0 Then : Exit For
                    ElseIf k = 2 Then : a = j : GoTo 1
                    End If
                Next
            Next
1:          sw.WriteLine((ic(0) * ic(1) * ic(2)) / a ^ 3)

        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
