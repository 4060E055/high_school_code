Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText

    Dim ia, aa, bb As String
    Dim nn(2), n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = sr.ReadLine
            If ia = "" Then Exit Do
            ReDim nn(ia - 1)
            ia = Trim(sr.ReadLine) & " "
            n = 0
            For i = 1 To Len(ia)
                If (Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) >= 48 And _
                    Asc(Microsoft.VisualBasic.Mid(ia, i, 1)) <= 97) Or Microsoft.VisualBasic.Mid(ia, i, 1) = "-" Then
                    aa &= Microsoft.VisualBasic.Mid(ia, i, 1)
                ElseIf Microsoft.VisualBasic.Mid(ia, i, 1) = " " Then
                    nn(n) = Val(aa) : n += 1 : aa = ""
                End If
            Next
            Array.Sort(nn)
            Array.Reverse(nn)
            For i = 0 To n - 1
                sw.Write(nn(i) & " ")
            Next
            sw.WriteLine()
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
