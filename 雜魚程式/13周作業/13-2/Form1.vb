Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, b, c, d As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        a = Val(sr.ReadLine)
        c = 1
        For i = 1 To a
            sw.Write(b & " ")
            d = b
            b = c + b
            c = d
            If b > a Then Exit For
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
