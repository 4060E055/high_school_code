Imports System.IO
Public Class Form1
    Dim fw As New FileInfo("output.txt")
    Dim fr As New FileInfo("input.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim ans As String
    Dim a As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        a = Val(sr.ReadLine)
        For k = a To 1 Step -1
            For i = 1 To k
                ans &= "*"
            Next
            ans &= Space((a - k) * 2)
            For i = 1 To k
                ans &= "*"
            Next
            ans &= vbNewLine
        Next
        For k = 2 To a
            For i = 1 To k
                ans &= "*"
            Next
            ans &= Space((a - k) * 2)
            For i = 1 To k
                ans &= "*"
            Next
            ans &= vbNewLine
        Next
        sw.WriteLine(ans) : sw.Flush() : sw.Close() : End
    End Sub
End Class
