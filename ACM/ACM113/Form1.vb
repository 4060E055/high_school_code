Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, b As Decimal
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        Do
            a = Val(Trim(sr.ReadLine))
            b = Val(Trim(sr.ReadLine))
            If a = 0 And b = 0 Then Exit Do
            sw.WriteLine(b ^ (1 / a))
        Loop
        sw.Flush() : sw.Close() : End
    End Sub
End Class
