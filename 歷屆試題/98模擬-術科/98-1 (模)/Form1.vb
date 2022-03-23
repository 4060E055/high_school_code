Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia, n As Byte
    Dim ib As String
    Dim ic(2) As Integer
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
            For j = 1 To Len(ib) '分解數
                If Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) >= 48 And Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) <= 57 Then
                    ic(n) &= Microsoft.VisualBasic.Mid(ib, j, 1)
                ElseIf Microsoft.VisualBasic.Mid(ib, j, 1) = " " Then
                    n += 1 : ReDim Preserve ic(n)
                End If
            Next

            For j = 0 To n
                For k = 0 To n
                    If ic(j) = ic(k) And j <> k And ic(j) <> -1 And ic(k) <> -1 Then
                        ic(j) = -1 : ic(k) = -1 : n -= 2
                    End If
                Next
            Next
            sw.WriteLine(n + 1)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
