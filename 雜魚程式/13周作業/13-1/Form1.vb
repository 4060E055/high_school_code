Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a, b As Integer 'a=原數

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        a = Val(sr.ReadLine)
        If a <= 1 Then
            MsgBox("請輸入大於1的數，程式即將結束執行")
            End
        End If
        sw.WriteLine("1")
        For j = 2 To a
            For i = 2 To (j - 1)
                b = j Mod i
                If b = 0 Then
                    Exit For
                End If
            Next
            If b <> 0 Then
                sw.WriteLine(j)
            End If
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
