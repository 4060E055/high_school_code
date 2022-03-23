Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ib As String
    Dim ia, n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        ia = sr.ReadLine

        For i = 1 To ia
            ib = Trim(sr.ReadLine) : n = 0
            For j = 1 To Len(ib)
                If (Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) >= 97 And Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) <= 122) Or _
                   (Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) >= 65 And Asc(Microsoft.VisualBasic.Mid(ib, j, 1)) <= 90) Then
                    n += 1
                End If
            Next
            sw.WriteLine(n)
        Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
