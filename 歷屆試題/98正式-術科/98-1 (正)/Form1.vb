Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n, x As Byte
    Dim ib, ic(2) As String
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
                If Microsoft.VisualBasic.Mid(ib, j, 1) <> " " And Microsoft.VisualBasic.Mid(ib, j, 1) <> "." _
               And Microsoft.VisualBasic.Mid(ib, j, 1) <> "," And Microsoft.VisualBasic.Mid(ib, j, 1) <> ":" Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                    n += 1 : ReDim Preserve ic(n)
                End If
            Next
            x = n
            For j = 0 To n
                For k = 0 To n
                    If ic(j) = ic(k) And j <> k Then
                        x -= 1 : ic(j) = "" : Exit For
                    ElseIf Len(ic(j)) = Len(ic(k)) And j <> k Then '避免大小寫的區分

                        For l = 1 To Len(ic(j))
                            If Asc(Microsoft.VisualBasic.Mid(ic(j), l, 1)) > Asc(Microsoft.VisualBasic.Mid(ic(k), l, 1)) Then
                                If Asc(Microsoft.VisualBasic.Mid(ic(j), l, 1)) - 32 <> _
                                     Asc(Microsoft.VisualBasic.Mid(ic(k), l, 1)) Then
                                    Exit For
                                ElseIf l = Len(ic(j)) Then
                                    ic(j) = "" : x -= 1
                                End If
                            ElseIf Asc(Microsoft.VisualBasic.Mid(ic(j), l, 1)) < Asc(Microsoft.VisualBasic.Mid(ic(k), l, 1)) Then
                                If Asc(Microsoft.VisualBasic.Mid(ic(j), l, 1)) <> _
                                 Asc(Microsoft.VisualBasic.Mid(ic(k), l, 1)) - 32 Then
                                    Exit For
                                ElseIf l = Len(ic(j)) Then
                                    ic(j) = "" : x -= 1
                                End If
                            End If
                        Next
                    End If
                    If ic(j) = "" Then Exit For
                Next
            Next
            sw.WriteLine(x + 1)
            ib = sr.ReadLine
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
