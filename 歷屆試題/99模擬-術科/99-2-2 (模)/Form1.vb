Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in-2-2.txt")
    Dim fw As New FileInfo("out-2-2.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n, a As Integer
    Dim ib, ic, oo(2) As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine
        ib = sr.ReadLine
        Dim ii(ia - 1, 1) As String

        For i = 0 To ia - 1
            ic = Trim(sr.ReadLine) : n = 0
            For j = 1 To Len(ic)
                If Asc(Microsoft.VisualBasic.Mid(ic, j, 1)) >= 65 And Asc(Microsoft.VisualBasic.Mid(ic, j, 1)) <= 90 Then
                    ii(i, n) = Microsoft.VisualBasic.Mid(ic, j, 1) : n += 1
                End If
            Next
        Next
        n = 0
1:      For i = 0 To ia - 1
            If ii(i, 0) = ib Then
                oo(n) = ii(i, 0)
                n += 1 : ReDim Preserve oo(n)
                If ii(i, 1) <> "" Then
                    ib = ii(i, 1) : GoTo 1
                Else
                    For j = n - 1 To 0 Step -1
                        sw.Write(oo(j) & "　")
                    Next
                    Exit For
                End If
            End If
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
