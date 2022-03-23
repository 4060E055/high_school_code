Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-1-2.txt")
    Dim fw As New FileInfo("out-1-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ii, n, x As Integer
    Dim ia, ib, ic(2) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ii = sr.ReadLine
        For i = 1 To ii
            ia = " " & Trim(sr.ReadLine) & " "
            ib = ""
            For j = 1 To Len(ia) - 1
                If Microsoft.VisualBasic.Mid(ia, j, 2) = " A" Or Microsoft.VisualBasic.Mid(ia, j, 2) = " a" Then
                    x = 0
                    For k = j + 1 To Len(ia) - 1
                        ib &= Microsoft.VisualBasic.Mid(ia, k, 1)
                        If Asc(Microsoft.VisualBasic.Mid(ia, k + 1, 1)) < 97 Or Asc(Microsoft.VisualBasic.Mid(ia, k + 1, 1)) > 122 Then Exit For

                    Next
                    x = Len(ib)
                    For k = 0 To n
                        If ib = ic(k) Then : Exit For
                        ElseIf k = n Then
                            ic(n) = ib : n += 1
                            ReDim Preserve ic(n)

                        End If
                    Next
                    ib = "":  j += x
                End If
            Next
        Next

        For i = 0 To n
            sw.WriteLine(ic(i))
        Next
        sw.Flush() : sw.Close() : End
    End Sub
End Class
