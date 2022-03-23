Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim ib, aa As String
    Dim ic(2), n As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        Do
            ia = sr.ReadLine
            If ia = 0 Then Exit Do
            ib = Trim(sr.ReadLine) & " "
            ReDim ic(ia - 1) : n = 0

            For i = 1 To Len(ib)
                If Microsoft.VisualBasic.Mid(ib, i, 1) = " " Then
                    ic(n) = Val(aa) : n += 1 : aa = ""
                Else
                    aa &= Microsoft.VisualBasic.Mid(ib, i, 1)
                End If
            Next

            Array.Sort(ic)
            For i = 0 To ia - 1
                sw.Write(ic(i) & " ")
            Next
            sw.WriteLine()
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
