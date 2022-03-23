Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("in.txt")
    Dim fw As New FileInfo("out.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Byte
    Dim ib, aa, n As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText

        ia = sr.ReadLine

        For i = 1 To ia
            ib = sr.ReadLine
            If ib = 0 Then sw.WriteLine(0) : GoTo 1
            n = 0
            Do
                If ib Mod 2 = 1 Then
                    n += 1
                End If
                ib \= 2
            Loop Until ib = 1
            sw.WriteLine(n + 1)
1:      Next

        sw.Flush() : sw.Close() : End
    End Sub
End Class
