Imports System.IO
Public Class Form1
    Dim fr As New FileInfo("input.txt")
    Dim fw As New FileInfo("output.txt")
    Dim sw As StreamWriter = fw.CreateText
    Dim a(1), n, aa As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If fr.Exists = False Then
            MsgBox("未找到input.txt檔，程式即將結束執行。")
            End
        ElseIf fw.Exists = False Then
            fw.Create()
        End If
        Dim sr As StreamReader = fr.OpenText
        a(0) = sr.ReadLine
        aa = a(0)
        Do
            For i = 2 To aa
                If a(0) > i Then
                    If a(0) Mod i = 0 Then
                        a(0) = a(0) / i
                        n += 1
                        ReDim Preserve a(n)
                        a(n) = i
                        Exit For
                    End If
                End If
                If i = aa Then
                    Exit Do
                End If
            Next
        Loop

        For i = 0 To n
            sw.Write(a(i))
            If i <> n Then sw.Write("*")
        Next
        sw.Flush() : sw.Close()
        End
    End Sub
End Class
