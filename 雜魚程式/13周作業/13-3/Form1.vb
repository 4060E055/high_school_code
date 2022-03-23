Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fw.Exists = False Then
            fw.Create()
        End If
        For i = 1 To 99 Step 2
            a += i ^ 3
        Next
        sw.WriteLine(a)
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
