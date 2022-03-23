Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("test.txt")
    Dim fw As New FileInfo("result.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ia As Integer
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
            Select Case ia
                Case Is > 10000 : sw.WriteLine(ia * 0.55)
                Case Is > 5000 : sw.WriteLine(ia * 0.6)
                Case Is > 2000 : sw.WriteLine(ia * 0.7)
            End Select
        Loop

        sw.Flush() : sw.Close() : End
    End Sub
End Class
